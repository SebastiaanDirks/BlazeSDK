using System.Net;
using System.Net.Security;
using System.Net.Sockets;

namespace Blaze.Core;

/// <summary>
/// Wraps an HTTP request context for REST endpoints.
/// Implements IBlazeConnection so it can be used in BlazeRpcContext alongside BlazeRpcConnection.
/// </summary>
public class BlazeRestConnection : IBlazeConnection
{
    private readonly TcpClient _client;
    private readonly SslStream? _sslStream;

    public Guid Id { get; } = Guid.NewGuid();
    public EndPoint? RemoteEndPoint { get; }
    public EndPoint? LocalEndPoint { get; }
    public bool Connected => _client.Connected;
    public object? State { get; set; }
    public DateTime LastActivityTime { get; set; } = DateTime.UtcNow;

    internal Stream Stream { get; }

    internal BlazeRestConnection(TcpClient client)
    {
        _client = client;
        Stream = client.GetStream();
        RemoteEndPoint = client.Client.RemoteEndPoint;
        LocalEndPoint = client.Client.LocalEndPoint;
    }

    internal BlazeRestConnection(TcpClient client, SslStream sslStream)
    {
        _client = client;
        _sslStream = sslStream;
        Stream = sslStream;
        RemoteEndPoint = client.Client.RemoteEndPoint;
        LocalEndPoint = client.Client.LocalEndPoint;
    }

    public void Disconnect()
    {
        _sslStream?.Dispose();
        _client.Close();
    }

    public override string ToString()
    {
        string protocol = _sslStream != null ? "HTTPS" : "REST";
        if (RemoteEndPoint != null)
            return $"[{protocol} {RemoteEndPoint}]";

        return $"[{protocol} Conn: {Id}]";
    }
}
