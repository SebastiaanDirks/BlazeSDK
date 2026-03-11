using EATDF;
using EATDF.Serialization;
using EATDF.Types;
using System.Text;

namespace Blaze.Core;

/// <summary>
/// Logs all incoming and outgoing Blaze packets to an XML file.
/// Thread-safe: multiple connections can log concurrently.
/// The file is always valid XML — the closing tag is written after every entry
/// and overwritten when the next entry is appended.
/// </summary>
public sealed class BlazePacketLogger : IDisposable
{
    private static readonly byte[] ClosingTag = Encoding.UTF8.GetBytes("</blazelog>" + Environment.NewLine);

    private readonly FileStream _fs;
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

        _fs = new FileStream(expandedPath, FileMode.Create, FileAccess.Write, FileShare.Read);
        WriteRaw("<?xml version=\"1.0\" encoding=\"UTF-8\"?>" + Environment.NewLine);
        WriteRaw("<blazelog>" + Environment.NewLine);
        _fs.Write(ClosingTag);
        _fs.Flush();
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
            StringBuilder sb = new StringBuilder();

            sb.Append("    <packet");
            AppendAttr(sb, "timestamp", timestamp);
            AppendAttr(sb, "protocol", protocol);
            AppendAttr(sb, "direction", direction);
            AppendAttr(sb, "connection", connectionId.ToString());
            AppendAttr(sb, "component", componentName);
            AppendAttr(sb, "componentId", $"0x{componentId:X4}");
            AppendAttr(sb, "command", commandName);
            AppendAttr(sb, "commandId", $"0x{commandId:X4}");
            AppendAttr(sb, "messageType", messageType);
            AppendAttr(sb, "messageNum", messageNum.ToString());
            AppendAttr(sb, "userIndex", userIndex.ToString());

            if (errorCode != 0)
            {
                AppendAttr(sb, "errorCode", $"0x{errorCode:X4}");
                if (errorName != null)
                    AppendAttr(sb, "errorName", errorName);
            }

            if (string.IsNullOrEmpty(tdfXml))
            {
                sb.AppendLine(" />");
            }
            else
            {
                sb.AppendLine(">");
                sb.Append(tdfXml);
                sb.AppendLine("    </packet>");
            }

            byte[] entryBytes = Encoding.UTF8.GetBytes(sb.ToString());

            lock (_lock)
            {
                if (_disposed) return;

                // Seek back over the previous closing tag, write the entry, then re-write the closing tag
                _fs.Seek(-ClosingTag.Length, SeekOrigin.Current);
                _fs.Write(entryBytes);
                _fs.Write(ClosingTag);
                _fs.Flush();
            }
        }
        catch
        {
            // Logging must never crash the server
        }
    }

    private static void AppendAttr(StringBuilder sb, string name, string value)
    {
        sb.Append($" {name}=\"{EscapeAttribute(value)}\"");
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

    private void WriteRaw(string text)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(text);
        _fs.Write(bytes);
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
            _fs.Flush();
            _fs.Dispose();
        }
    }
}
