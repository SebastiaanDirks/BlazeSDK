using System.Text;

namespace EATDF.Xml;

internal class XmlWriter
{
    private readonly StreamWriter _writer;
    private readonly Stack<ElementState> _elementStack = new();
    private int _depth = 0;

    public XmlWriter(Stream stream)
    {
        _writer = new StreamWriter(stream, new UTF8Encoding(false), leaveOpen: true);
    }

    public void WriteStartDocument(string encoding = "UTF-8")
    {
        _writer.Write($"<?xml version=\"1.0\" encoding=\"{encoding}\"?>");
        _writer.WriteLine();
    }

    public void WriteEndDocument()
    {
        _writer.Flush();
    }

    public void WriteStartElement(string name, Dictionary<string, string>? attributes = null)
    {
        WriteIndent();
        _writer.Write('<');
        _writer.Write(name);

        if (attributes != null)
        {
            foreach (var attr in attributes)
            {
                _writer.Write(' ');
                _writer.Write(attr.Key);
                _writer.Write("=\"");
                _writer.Write(EscapeAttribute(attr.Value));
                _writer.Write('"');
            }
        }

        _writer.Write('>');

        _elementStack.Push(new ElementState(name));
        _depth++;
    }

    public void WriteEndElement()
    {
        _depth--;
        var state = _elementStack.Pop();

        if (state.HasChildElements)
            WriteIndent();

        _writer.Write("</");
        _writer.Write(state.Name);
        _writer.Write('>');
        _writer.WriteLine();

        if (_elementStack.Count > 0)
            _elementStack.Peek().HasChildElements = true;
    }

    public void WriteText(string value)
    {
        _writer.Write(EscapeText(value));
    }

    public void WriteRawText(string value)
    {
        _writer.Write(value);
    }

    public void WriteNewLine()
    {
        _writer.WriteLine();
        if (_elementStack.Count > 0)
            _elementStack.Peek().HasChildElements = true;
    }

    public void WriteElement(string name, string value, Dictionary<string, string>? attributes = null)
    {
        WriteIndent();
        _writer.Write('<');
        _writer.Write(name);

        if (attributes != null)
        {
            foreach (var attr in attributes)
            {
                _writer.Write(' ');
                _writer.Write(attr.Key);
                _writer.Write("=\"");
                _writer.Write(EscapeAttribute(attr.Value));
                _writer.Write('"');
            }
        }

        _writer.Write('>');
        _writer.Write(EscapeText(value));
        _writer.Write("</");
        _writer.Write(name);
        _writer.Write('>');
        _writer.WriteLine();

        if (_elementStack.Count > 0)
            _elementStack.Peek().HasChildElements = true;
    }

    private void WriteIndent()
    {
        for (int i = 0; i < _depth; i++)
            _writer.Write("    ");
    }

    private static string EscapeText(string value)
    {
        if (value.AsSpan().IndexOfAny("&<>") < 0)
            return value;

        return value
            .Replace("&", "&amp;")
            .Replace("<", "&lt;")
            .Replace(">", "&gt;");
    }

    private static string EscapeAttribute(string value)
    {
        if (value.AsSpan().IndexOfAny("&<>\"'") < 0)
            return value;

        return value
            .Replace("&", "&amp;")
            .Replace("<", "&lt;")
            .Replace(">", "&gt;")
            .Replace("\"", "&quot;")
            .Replace("'", "&apos;");
    }

    private class ElementState(string name)
    {
        public string Name { get; } = name;
        public bool HasChildElements { get; set; }
    }
}
