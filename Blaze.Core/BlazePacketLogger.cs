using EATDF;
using EATDF.Serialization;
using EATDF.Types;
using System.Text;

namespace Blaze.Core;

/// <summary>
/// Logs all incoming and outgoing Blaze packets to an XML file.
/// Thread-safe: multiple connections can log concurrently.
/// Each packet entry is flushed immediately so data is preserved even on crash.
/// </summary>
public sealed class BlazePacketLogger : IDisposable
{
    private readonly StreamWriter _writer;
    private readonly object _lock = new();
    private readonly ITdfSerializer _xmlSerializer = new XmlSerializer();
    private bool _disposed;

    public BlazePacketLogger(string filePath)
    {
        string expandedPath = string.Format(filePath, DateTime.UtcNow);
        if (expandedPath.StartsWith('~'))
            expandedPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), expandedPath[1..].TrimStart(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar));
        expandedPath = Path.GetFullPath(expandedPath);
        string? directory = Path.GetDirectoryName(expandedPath);
        if (directory != null)
            Directory.CreateDirectory(directory);

        FileStream fs = new FileStream(expandedPath, FileMode.Create, FileAccess.Write, FileShare.Read);
        _writer = new StreamWriter(fs, new UTF8Encoding(false));
        _writer.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
        _writer.WriteLine("<blazelog>");
        _writer.Flush();
    }

    /// <summary>
    /// Logs an RPC or REST packet to the XML log file.
    /// </summary>
    public void LogPacket(
        string protocol,
        string direction,
        Guid connectionId,
        string componentName,
        ushort componentId,
        string commandName,
        ushort commandId,
        string messageType,
        uint messageNum,
        byte userIndex,
        ushort errorCode,
        string? errorName,
        Tdf? tdf)
    {
        try
        {
            string tdfXml = "";
            try
            {
                tdfXml = SerializeTdf(tdf);
            }
            catch
            {
                // TDF serialization failed — log the packet without payload
            }

            string timestamp = DateTime.UtcNow.ToString("o");

            lock (_lock)
            {
                if (_disposed) return;

                _writer.Write("    <packet");
                WriteAttr("timestamp", timestamp);
                WriteAttr("protocol", protocol);
                WriteAttr("direction", direction);
                WriteAttr("connection", connectionId.ToString());
                WriteAttr("component", componentName);
                WriteAttr("componentId", $"0x{componentId:X4}");
                WriteAttr("command", commandName);
                WriteAttr("commandId", $"0x{commandId:X4}");
                WriteAttr("messageType", messageType);
                WriteAttr("messageNum", messageNum.ToString());
                WriteAttr("userIndex", userIndex.ToString());

                if (errorCode != 0)
                {
                    WriteAttr("errorCode", $"0x{errorCode:X4}");
                    if (errorName != null)
                        WriteAttr("errorName", errorName);
                }

                if (string.IsNullOrEmpty(tdfXml))
                {
                    _writer.WriteLine(" />");
                }
                else
                {
                    _writer.WriteLine(">");
                    _writer.Write(tdfXml);
                    _writer.WriteLine("    </packet>");
                }

                _writer.Flush();
            }
        }
        catch
        {
            // Logging must never crash the server
        }
    }

    private void WriteAttr(string name, string value)
    {
        _writer.Write($" {name}=\"{EscapeAttribute(value)}\"");
    }

    private string SerializeTdf(Tdf? tdf)
    {
        if (tdf == null || tdf is EmptyMessage) return "";

        using MemoryStream ms = new MemoryStream();
        _xmlSerializer.Serialize(ms, tdf);
        string xml = Encoding.UTF8.GetString(ms.ToArray());

        // Strip the XML declaration line
        int newlineIdx = xml.IndexOf('\n');
        if (newlineIdx >= 0 && xml.StartsWith("<?xml"))
            xml = xml[(newlineIdx + 1)..];

        // Indent each line by 8 spaces (2 levels deep inside <blazelog><packet>)
        string[] lines = xml.Split('\n', StringSplitOptions.RemoveEmptyEntries);
        StringBuilder sb = new StringBuilder();
        foreach (string line in lines)
        {
            sb.Append("        ");
            sb.AppendLine(line.TrimEnd('\r'));
        }
        return sb.ToString();
    }

    private static string EscapeAttribute(string value)
    {
        if (value.AsSpan().IndexOfAny("&<>\"'") < 0) return value;
        return value
            .Replace("&", "&amp;")
            .Replace("<", "&lt;")
            .Replace(">", "&gt;")
            .Replace("\"", "&quot;")
            .Replace("'", "&apos;");
    }

    public void Dispose()
    {
        lock (_lock)
        {
            if (_disposed) return;
            _disposed = true;
            _writer.WriteLine("</blazelog>");
            _writer.Flush();
            _writer.Dispose();
        }
    }
}
