namespace EATDF.Xml;

/// <summary>
/// SAX-style XML parser that reads XML into a flat key-value parameter map.
/// Keys are hierarchical paths like "classname/membername", "classname/arrayname/elementtype|1".
/// This matches the two-pass decode approach from the original C++ Xml2Decoder.
/// </summary>
internal class XmlReader
{
    /// <summary>
    /// Flat key-value map of all parsed XML content.
    /// Keys are case-insensitive hierarchical paths.
    /// </summary>
    public Dictionary<string, string> ParamMap { get; } = new(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// Tracks array sizes: key path -> element count.
    /// </summary>
    public Dictionary<string, int> ArraySizeMap { get; } = new(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// Tracks map keys: key path -> list of key values.
    /// </summary>
    public Dictionary<string, List<string>> MapKeysMap { get; } = new(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// Whether parsing completed successfully.
    /// </summary>
    public bool Success { get; private set; }

    private readonly Stack<string> _keyStack = new();
    private readonly Stack<ElementInfo> _elementStack = new();
    private string _currentKey = "";

    public void Parse(Stream stream)
    {
        try
        {
            var settings = new System.Xml.XmlReaderSettings
            {
                IgnoreComments = true,
                IgnoreProcessingInstructions = true,
                IgnoreWhitespace = false,
            };

            using var reader = System.Xml.XmlReader.Create(stream, settings);

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case System.Xml.XmlNodeType.Element:
                        HandleStartElement(reader);
                        if (reader.IsEmptyElement)
                            HandleEndElement(reader.LocalName);
                        break;

                    case System.Xml.XmlNodeType.EndElement:
                        HandleEndElement(reader.LocalName);
                        break;

                    case System.Xml.XmlNodeType.Text:
                    case System.Xml.XmlNodeType.CDATA:
                        HandleText(reader.Value);
                        break;
                }
            }

            Success = true;
        }
        catch (Exception)
        {
            Success = false;
        }
    }

    private void HandleStartElement(System.Xml.XmlReader reader)
    {
        string name = reader.LocalName;

        var info = new ElementInfo
        {
            Name = name,
            ParentKey = _currentKey,
        };

        // Read attributes
        if (reader.HasAttributes)
        {
            while (reader.MoveToNextAttribute())
            {
                string attrName = reader.LocalName;
                string attrValue = reader.Value;
                info.Attributes[attrName] = attrValue;

                // Store attribute in param map with attribute path
                string attrKey = BuildKey(_currentKey, name, attrName);
                ParamMap[attrKey] = attrValue;
            }
            reader.MoveToElement();
        }

        // Build the key for this element
        if (string.IsNullOrEmpty(_currentKey))
        {
            // Root element
            _currentKey = name;
        }
        else if (name == "entry")
        {
            // Map entry - use key attribute as part of the path
            if (info.Attributes.TryGetValue("key", out string? keyValue))
            {
                string mapPath = _currentKey;

                // Track map keys
                if (!MapKeysMap.TryGetValue(mapPath, out var keyList))
                {
                    keyList = new List<string>();
                    MapKeysMap[mapPath] = keyList;
                }
                keyList.Add(keyValue);

                _currentKey = _currentKey + "|" + keyValue;
            }
        }
        else
        {
            // Check if this is a repeated element (array item)
            string newKey = _currentKey + "/" + name;

            // Track array sizes
            string arraySizeKey = newKey;
            if (ArraySizeMap.TryGetValue(arraySizeKey, out int existingCount))
            {
                ArraySizeMap[arraySizeKey] = existingCount + 1;
                // Use |N suffix for non-first elements
                _currentKey = newKey + "|" + existingCount;
            }
            else
            {
                // First occurrence - could be a scalar or first array element
                // We'll store without suffix; if a second one appears, the first is index 0
                ArraySizeMap[arraySizeKey] = 1;
                _currentKey = newKey;
            }
        }

        _keyStack.Push(info.ParentKey);
        _elementStack.Push(info);
    }

    private void HandleEndElement(string name)
    {
        if (_elementStack.Count > 0)
        {
            _elementStack.Pop();
            _currentKey = _keyStack.Pop();
        }
    }

    private void HandleText(string text)
    {
        if (string.IsNullOrEmpty(_currentKey))
            return;

        string trimmed = text.Trim();
        if (trimmed.Length > 0)
        {
            // If key already has a value, append (for multi-line content like base64)
            if (ParamMap.TryGetValue(_currentKey, out string? existing))
                ParamMap[_currentKey] = existing + trimmed;
            else
                ParamMap[_currentKey] = trimmed;
        }
    }

    private static string BuildKey(string parentKey, string elementName, string attrName)
    {
        if (string.IsNullOrEmpty(parentKey))
            return elementName + "@" + attrName;
        return parentKey + "/" + elementName + "@" + attrName;
    }

    private class ElementInfo
    {
        public string Name { get; set; } = "";
        public string ParentKey { get; set; } = "";
        public Dictionary<string, string> Attributes { get; } = new(StringComparer.OrdinalIgnoreCase);
    }
}
