using EATDF;
using EATDF.Members;
using EATDF.Serialization;
using EATDF.Types;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Blaze.Core;

/// <summary>
/// A lightweight HTTP server for REST endpoints.
/// Parses raw HTTP requests on TCP connections, routes to component/commands via the
/// shared IBlazeRouter, and sends HTTP responses. Mirrors the official Blaze RestProtocol.
/// </summary>
public class BlazeRestServer
{
    private TcpListener _listener;
    private readonly BlazeServerConfig _config;
    private readonly ILogger<BlazeRestServer> _logger;
    private readonly ITdfSerializer _xmlSerializer = new XmlSerializer();
    private uint _nextSeqNo;

    public IPEndPoint LocalEndpoint { get; private set; }
    public IBlazeRouter Router => _config.Router;
    public bool Started { get; private set; }

    public BlazeRestServer(BlazeServerConfig config, ILogger<BlazeRestServer> logger)
    {
        _config = config;
        _logger = logger;
        _listener = new TcpListener(config.LocalEndpoint);
        LocalEndpoint = config.LocalEndpoint;
    }

    public async Task StartAsync(CancellationToken cancellationToken = default)
    {
        _listener.Start(_config.Backlog > 0 ? _config.Backlog : 100);
        LocalEndpoint = (IPEndPoint)_listener.LocalEndpoint;
        _config.LocalEndpoint.Port = LocalEndpoint.Port;
        Started = true;

        string protocol = _config.Secure ? "HTTPS" : "HTTP";
        _logger.LogInformation("REST server started on {Endpoint} ({Protocol})", LocalEndpoint, protocol);

        try
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                TcpClient client = await _listener.AcceptTcpClientAsync(cancellationToken).ConfigureAwait(false);

                if (_logger.IsEnabled(LogLevel.Debug))
                    _logger.LogDebug("REST connection accepted from {Remote}", client.Client.RemoteEndPoint);

                _ = HandleConnectionAsync(client, cancellationToken);
            }
        }
        catch (OperationCanceledException) { }
        finally
        {
            _listener.Stop();
            Started = false;
            _logger.LogInformation("REST server stopped on {Endpoint}", LocalEndpoint);
        }
    }

    private async Task HandleConnectionAsync(TcpClient client, CancellationToken cancellationToken)
    {
        BlazeRestConnection connection;

        if (_config.Secure)
        {
            X509Certificate2? cert = _config.Certificate?.AsX509Certificate2();
            if (cert == null)
            {
                _logger.LogError("REST HTTPS enabled but no X509Certificate2 available. Dropping connection from {Remote}",
                    client.Client.RemoteEndPoint);
                client.Close();
                return;
            }

            SslStream sslStream = new SslStream(client.GetStream(), leaveInnerStreamOpen: false);
            try
            {
                await sslStream.AuthenticateAsServerAsync(cert).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "TLS handshake failed for REST connection from {Remote}", client.Client.RemoteEndPoint);
                await sslStream.DisposeAsync();
                client.Close();
                return;
            }

            connection = new BlazeRestConnection(client, sslStream);
        }
        else
        {
            connection = new BlazeRestConnection(client);
        }

        try
        {
            Stream stream = connection.Stream;

            while (client.Connected && !cancellationToken.IsCancellationRequested)
            {
                HttpRequest? request = await ReadHttpRequestAsync(stream, cancellationToken).ConfigureAwait(false);
                if (request == null)
                    break;

                connection.LastActivityTime = DateTime.UtcNow;

                await ProcessRequestAsync(connection, stream, request).ConfigureAwait(false);

                if (!request.KeepAlive)
                    break;
            }
        }
        catch (OperationCanceledException) { }
        catch (IOException) { } // Client disconnected
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error handling REST connection from {Remote}", connection.RemoteEndPoint);
        }
        finally
        {
            connection.Disconnect();
        }
    }

    private async Task ProcessRequestAsync(BlazeRestConnection connection, Stream stream, HttpRequest request)
    {
        HttpMethod method;
        try
        {
            method = RestResourceInfo.ParseMethod(request.MethodString);
        }
        catch (ArgumentException)
        {
            _logger.LogWarning("Unknown HTTP method: {Method}", request.MethodString);
            await SendErrorResponseAsync(stream, 405, "Method Not Allowed", 0, null, null).ConfigureAwait(false);
            return;
        }

        if (method == HttpMethod.POST && request.Headers.TryGetValue("X-BLAZE-METHOD", out string? methodOverride))
        {
            try
            {
                method = RestResourceInfo.ParseMethod(methodOverride);
            }
            catch (ArgumentException)
            {
                _logger.LogWarning("Unrecognized X-BLAZE-METHOD override: {Override}", methodOverride);
            }
        }

        var resolved = _config.Router.ResolveRestCommand(method, request.Path);
        if (resolved == null)
        {
            _logger.LogDebug("No REST command found for {Method} {Path}", request.MethodString, request.Path);
            await SendErrorResponseAsync(stream, 404, "Not Found", 2, null, null).ConfigureAwait(false);
            return;
        }

        var (component, commandFunc) = resolved.Value;

        if (_logger.IsEnabled(LogLevel.Debug))
            _logger.LogDebug("REST {Method} {Path} -> {Component}::{Command}",
                request.MethodString, request.Path, component.Name, commandFunc.Name);

        Tdf requestTdf = commandFunc.CreateRequestTdf();
        if (method == HttpMethod.GET)
        {
            PopulateFromQueryParams(requestTdf, request.QueryParams);
        }
        else if (request.Body.Length > 0)
        {
            ITdfSerializer serializer = GetSerializerForContentType(request.ContentType);
            using MemoryStream bodyStream = new MemoryStream(request.Body);
            if (!serializer.Deserialize(bodyStream, requestTdf))
            {
                _logger.LogWarning("Failed to deserialize REST request body for {Component}::{Command}",
                    component.Name, commandFunc.Name);
                await SendErrorResponseAsync(stream, 400, "Bad Request", 0, component, commandFunc).ConfigureAwait(false);
                return;
            }
        }

        uint seqNo = Interlocked.Increment(ref _nextSeqNo);

        request.Headers.TryGetValue("BLAZE-SESSION", out string? _);

        if (request.Headers.TryGetValue("X-BLAZE-SEQNO", out string? seqNoStr) &&
            uint.TryParse(seqNoStr, out uint requestSeqNo) && requestSeqNo != 0)
        {
            seqNo = requestSeqNo;
        }

        BlazeRpcContext context = new BlazeRpcContext()
        {
            Connection = connection,
            ErrorCode = 0,
            MessageNum = seqNo,
            UserIndex = 0,
            Context = 0
        };

        Tdf? responseTdf;
        ushort errorCode = 0;
        try
        {
            responseTdf = await commandFunc.InvokeAsync(requestTdf, context).ConfigureAwait(false);
        }
        catch (BlazeRpcException blazeException)
        {
            responseTdf = blazeException.ErrorResponse;
            errorCode = blazeException.ErrorCode;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unhandled exception in REST handler for {Component}::{Command}",
                component.Name, commandFunc.Name);
            await SendErrorResponseAsync(stream, 500, "Internal Server Error", 0, component, commandFunc).ConfigureAwait(false);
            return;
        }

        ITdfSerializer responseSerializer = GetSerializerForAccept(request.AcceptHeader);

        byte[] responseBody;
        if (responseTdf == null || responseTdf is EmptyMessage)
        {
            responseBody = Array.Empty<byte>();
        }
        else
        {
            using MemoryStream responseStream = new MemoryStream();
            responseSerializer.Serialize(responseStream, responseTdf);
            responseBody = responseStream.ToArray();
        }

        int httpStatus = errorCode == 0 ? 200 : GetHttpStatusForError(errorCode);
        string httpReason = errorCode == 0 ? "OK" : "Error";

        string contentType = "application/xml";
        await SendSuccessResponseAsync(stream, httpStatus, httpReason, responseBody, contentType,
            errorCode, component, commandFunc, seqNo).ConfigureAwait(false);
    }

    private async Task SendSuccessResponseAsync(Stream stream, int statusCode, string statusReason,
        byte[] body, string contentType, ushort blazeErrorCode,
        IBlazeComponent component, IRpcCommandFunc commandFunc, uint seqNo)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"HTTP/1.1 {statusCode} {statusReason}\r\n");
        if (blazeErrorCode != 0) 
            sb.Append($"X-BLAZE-ERRORCODE: {blazeErrorCode}\r\n");
        sb.Append($"X-BLAZE-COMPONENT: {component.Name}\r\n");
        sb.Append($"X-BLAZE-COMMAND: {commandFunc.Name}\r\n");
        sb.Append($"Content-Type: {contentType}\r\n");
        sb.Append($"Content-Length: {body.Length}\r\n");
        sb.Append($"X-BLAZE-SEQNO: {seqNo}\r\n");
        sb.Append("\r\n");

        byte[] headerBytes = Encoding.ASCII.GetBytes(sb.ToString());
        await stream.WriteAsync(headerBytes).ConfigureAwait(false);
        if (body.Length > 0)
            await stream.WriteAsync(body).ConfigureAwait(false);
        await stream.FlushAsync().ConfigureAwait(false);
    }

    private async Task SendErrorResponseAsync(Stream stream, int httpStatus, string httpReason,
        ushort blazeErrorCode, IBlazeComponent? component, IRpcCommandFunc? commandFunc)
    {
        string errorXml = $"<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" +
            $"<error>\n" +
            $"<component>{component?.Id ?? 0}</component>\n" +
            $"<errorCode>{blazeErrorCode}</errorCode>\n" +
            $"<errorName>{_config.Router.GetErrorName(blazeErrorCode)}</errorName>\n" +
            $"</error>";

        byte[] body = Encoding.UTF8.GetBytes(errorXml);

        StringBuilder sb = new StringBuilder();
        sb.Append($"HTTP/1.1 {httpStatus} {httpReason}\r\n");
        sb.Append($"X-BLAZE-ERRORCODE: {blazeErrorCode}\r\n");
        if (component != null)
            sb.Append($"X-BLAZE-COMPONENT: {component.Name}\r\n");
        if (commandFunc != null)
            sb.Append($"X-BLAZE-COMMAND: {commandFunc.Name}\r\n");
        sb.Append($"Content-Type: application/xml\r\n");
        sb.Append($"Content-Length: {body.Length}\r\n");
        sb.Append("\r\n");

        byte[] headerBytes = Encoding.ASCII.GetBytes(sb.ToString());
        await stream.WriteAsync(headerBytes).ConfigureAwait(false);
        await stream.WriteAsync(body).ConfigureAwait(false);
        await stream.FlushAsync().ConfigureAwait(false);
    }

    #region HTTP Parsing

    private async Task<HttpRequest?> ReadHttpRequestAsync(Stream stream, CancellationToken ct)
    {
        byte[] headerBuffer = new byte[8192];
        int totalRead = 0;
        int headerEnd = -1;

        // Read until we find the end of HTTP headers (\r\n\r\n)
        while (headerEnd < 0 && totalRead < headerBuffer.Length)
        {
            int bytesRead;
            try
            {
                bytesRead = await stream.ReadAsync(headerBuffer, totalRead, headerBuffer.Length - totalRead, ct).ConfigureAwait(false);
            }
            catch (IOException)
            {
                return null;
            }

            if (bytesRead == 0) return null;
            totalRead += bytesRead;

            headerEnd = FindCrLfCrLf(headerBuffer, totalRead);
        }

        if (headerEnd < 0) return null;

        int bodyOffset = headerEnd + 4;
        string headerStr = Encoding.ASCII.GetString(headerBuffer, 0, headerEnd);

        // Parse request line and headers
        string[] headerLines = headerStr.Split("\r\n");
        if (headerLines.Length == 0) return null;

        string[] requestParts = headerLines[0].Split(' ', 3);
        if (requestParts.Length < 3) return null;

        string methodStr = requestParts[0];
        string fullPath = requestParts[1];

        var headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        for (int i = 1; i < headerLines.Length; i++)
        {
            int colonIdx = headerLines[i].IndexOf(':');
            if (colonIdx > 0)
            {
                string key = headerLines[i].Substring(0, colonIdx).Trim();
                string value = headerLines[i].Substring(colonIdx + 1).Trim();
                headers[key] = value;
            }
        }

        // Read body based on Content-Length
        int contentLength = 0;
        if (headers.TryGetValue("Content-Length", out string? clStr))
            int.TryParse(clStr, out contentLength);

        byte[] body = Array.Empty<byte>();
        if (contentLength > 0)
        {
            body = new byte[contentLength];
            int bodyBytesInBuffer = totalRead - bodyOffset;
            int toCopy = Math.Min(bodyBytesInBuffer, contentLength);
            if (toCopy > 0)
                Buffer.BlockCopy(headerBuffer, bodyOffset, body, 0, toCopy);

            int remaining = contentLength - toCopy;
            int offset = toCopy;
            while (remaining > 0)
            {
                int read = await stream.ReadAsync(body, offset, remaining, ct).ConfigureAwait(false);
                if (read == 0) break;
                offset += read;
                remaining -= read;
            }
        }

        // Parse path and query string
        string path = fullPath;
        string queryString = "";
        var queryParams = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        int qIdx = fullPath.IndexOf('?');
        if (qIdx >= 0)
        {
            path = fullPath.Substring(0, qIdx);
            queryString = fullPath.Substring(qIdx + 1);
            foreach (string param in queryString.Split('&', StringSplitOptions.RemoveEmptyEntries))
            {
                int eq = param.IndexOf('=');
                if (eq > 0)
                    queryParams[Uri.UnescapeDataString(param.Substring(0, eq))] = Uri.UnescapeDataString(param.Substring(eq + 1));
                else
                    queryParams[Uri.UnescapeDataString(param)] = "";
            }
        }

        // Determine keep-alive (HTTP/1.1 defaults to keep-alive)
        bool keepAlive = !headers.TryGetValue("Connection", out string? connHeader) ||
                         !connHeader.Equals("close", StringComparison.OrdinalIgnoreCase);

        // Content-Type and Accept
        headers.TryGetValue("Content-Type", out string? contentType);
        headers.TryGetValue("Accept", out string? acceptHeader);

        return new HttpRequest
        {
            MethodString = methodStr,
            Path = path,
            FullPath = fullPath,
            Headers = headers,
            Body = body,
            KeepAlive = keepAlive,
            QueryString = queryString,
            QueryParams = queryParams,
            ContentType = contentType,
            AcceptHeader = acceptHeader
        };
    }

    private static int FindCrLfCrLf(byte[] buffer, int length)
    {
        for (int i = 0; i <= length - 4; i++)
        {
            if (buffer[i] == '\r' && buffer[i + 1] == '\n' &&
                buffer[i + 2] == '\r' && buffer[i + 3] == '\n')
                return i;
        }
        return -1;
    }

    #endregion

    #region Query Parameter Mapping

    private static void PopulateFromQueryParams(Tdf tdf, Dictionary<string, string> queryParams)
    {
        foreach (var (key, value) in queryParams)
        {
            if (tdf.TryGetMember(key, out var member))
                SetMemberFromString(member, value);
        }
    }

    private static void SetMemberFromString(ITdfMember member, string value)
    {
        switch (member)
        {
            case TdfString s:
                s.Value = value;
                break;
            case TdfInt8 i:
                if (sbyte.TryParse(value, out var i8)) i.Value = i8;
                break;
            case TdfInt16 i:
                if (short.TryParse(value, out var i16)) i.Value = i16;
                break;
            case TdfInt32 i:
                if (int.TryParse(value, out var i32)) i.Value = i32;
                break;
            case TdfInt64 i:
                if (long.TryParse(value, out var i64)) i.Value = i64;
                break;
            case TdfUInt8 u:
                if (byte.TryParse(value, out var u8)) u.Value = u8;
                break;
            case TdfUInt16 u:
                if (ushort.TryParse(value, out var u16)) u.Value = u16;
                break;
            case TdfUInt32 u:
                if (uint.TryParse(value, out var u32)) u.Value = u32;
                break;
            case TdfUInt64 u:
                if (ulong.TryParse(value, out var u64)) u.Value = u64;
                break;
            case TdfFloat f:
                if (float.TryParse(value, out var fv)) f.Value = fv;
                break;
            case TdfBool b:
                if (bool.TryParse(value, out var bv)) b.Value = bv;
                else if (value == "1") b.Value = true;
                else if (value == "0") b.Value = false;
                break;
        }
    }

    #endregion

    #region Serializer Selection

    private ITdfSerializer GetSerializerForContentType(string? contentType)
    {
        if (contentType == null) return _xmlSerializer;

        if (contentType.Contains("xml", StringComparison.OrdinalIgnoreCase))
            return _xmlSerializer;

        // Default to XML (JSON can be added in the future)
        return _xmlSerializer;
    }

    private ITdfSerializer GetSerializerForAccept(string? acceptHeader)
    {
        if (acceptHeader == null) return _xmlSerializer;

        if (acceptHeader.Contains("xml", StringComparison.OrdinalIgnoreCase))
            return _xmlSerializer;

        // Default to XML (JSON can be added in the future)
        return _xmlSerializer;
    }

    #endregion

    private static int GetHttpStatusForError(ushort errorCode)
    {
        // Basic mapping — can be extended with a full error-to-HTTP-status table
        return errorCode switch
        {
            0 => 200,
            _ => 500
        };
    }

    /// <summary>
    /// Internal HTTP request representation, parsed from raw TCP data.
    /// </summary>
    internal class HttpRequest
    {
        public required string MethodString { get; init; }
        public required string Path { get; init; }
        public required string FullPath { get; init; }
        public required Dictionary<string, string> Headers { get; init; }
        public required byte[] Body { get; init; }
        public required bool KeepAlive { get; init; }
        public required string QueryString { get; init; }
        public required Dictionary<string, string> QueryParams { get; init; }
        public string? ContentType { get; init; }
        public string? AcceptHeader { get; init; }
    }
}
