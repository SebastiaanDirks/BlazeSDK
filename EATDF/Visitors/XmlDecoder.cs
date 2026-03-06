using EATDF.Members;
using EATDF.Types;
using EATDF.Xml;
using System.Globalization;

namespace EATDF.Visitors;

public class XmlDecoder : ITdfVisitor
{
    private readonly XmlReader _reader;
    private readonly Stack<string> _keyStack = new();
    private string _currentKey = "";

    /// <summary>
    /// Whether decoding completed successfully.
    /// </summary>
    public bool Success => _reader.Success;

    /// <summary>
    /// The VALU tag (0xDA1B3500) used by unions with reserved member tags.
    /// </summary>
    private const uint ValuTag = 0xDA1B3500;

    public XmlDecoder(Stream stream)
    {
        _reader = new XmlReader();
        _reader.Parse(stream);
    }

    public void VisitTdf(Tdf value)
    {
        string className = GetClassName(value);

        // Set the root key to the class name
        _currentKey = className;

        VisitMembers(value);
    }

    public bool VisitBool(TdfBool value, Tdf parent, bool visitHeader)
    {
        if (!TryGetTextValue(value, visitHeader, out string? text)) return false;
        value.Value = text == "1" || text!.Equals("true", StringComparison.OrdinalIgnoreCase);
        return true;
    }

    public bool VisitInt8(TdfInt8 value, Tdf parent, bool visitHeader)
    {
        if (!TryGetTextValue(value, visitHeader, out string? text)) return false;
        if (sbyte.TryParse(text, out sbyte result))
        {
            value.Value = result;
            return true;
        }
        return false;
    }

    public bool VisitUInt8(TdfUInt8 value, Tdf parent, bool visitHeader)
    {
        if (!TryGetTextValue(value, visitHeader, out string? text)) return false;
        if (byte.TryParse(text, out byte result))
        {
            value.Value = result;
            return true;
        }
        return false;
    }

    public bool VisitInt16(TdfInt16 value, Tdf parent, bool visitHeader)
    {
        if (!TryGetTextValue(value, visitHeader, out string? text)) return false;
        if (short.TryParse(text, out short result))
        {
            value.Value = result;
            return true;
        }
        return false;
    }

    public bool VisitUInt16(TdfUInt16 value, Tdf parent, bool visitHeader)
    {
        if (!TryGetTextValue(value, visitHeader, out string? text)) return false;
        if (ushort.TryParse(text, out ushort result))
        {
            value.Value = result;
            return true;
        }
        return false;
    }

    public bool VisitInt32(TdfInt32 value, Tdf parent, bool visitHeader)
    {
        if (!TryGetTextValue(value, visitHeader, out string? text)) return false;
        if (int.TryParse(text, out int result))
        {
            value.Value = result;
            return true;
        }
        return false;
    }

    public bool VisitUInt32(TdfUInt32 value, Tdf parent, bool visitHeader)
    {
        if (!TryGetTextValue(value, visitHeader, out string? text)) return false;
        if (uint.TryParse(text, out uint result))
        {
            value.Value = result;
            return true;
        }
        return false;
    }

    public bool VisitInt64(TdfInt64 value, Tdf parent, bool visitHeader)
    {
        if (!TryGetTextValue(value, visitHeader, out string? text)) return false;
        if (long.TryParse(text, out long result))
        {
            value.Value = result;
            return true;
        }
        return false;
    }

    public bool VisitUInt64(TdfUInt64 value, Tdf parent, bool visitHeader)
    {
        if (!TryGetTextValue(value, visitHeader, out string? text)) return false;
        if (ulong.TryParse(text, out ulong result))
        {
            value.Value = result;
            return true;
        }
        return false;
    }

    public bool VisitFloat(TdfFloat value, Tdf parent, bool visitHeader)
    {
        if (!TryGetTextValue(value, visitHeader, out string? text)) return false;
        if (float.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out float result))
        {
            value.Value = result;
            return true;
        }
        return false;
    }

    public bool VisitString(TdfString value, Tdf parent, bool visitHeader)
    {
        if (!TryGetTextValue(value, visitHeader, out string? text)) return false;
        value.Value = text!;
        return true;
    }

    public bool VisitEnum<TEnum>(TdfEnum<TEnum> value, Tdf parent, bool visitHeader) where TEnum : Enum, new()
    {
        if (!TryGetTextValue(value, visitHeader, out string? text)) return false;

        // Try parsing as enum name first
        if (Enum.TryParse(typeof(TEnum), text, ignoreCase: true, out object? enumValue) && enumValue != null)
        {
            value.Value = (TEnum)enumValue;
            return true;
        }

        // Fall back to numeric parse
        if (int.TryParse(text, out int numericValue))
        {
            value.Value = (TEnum)Enum.ToObject(typeof(TEnum), numericValue);
            return true;
        }

        return false;
    }

    public bool VisitTimeValue(TdfTimeValue value, Tdf parent, bool visitHeader)
    {
        if (!TryGetTextValue(value, visitHeader, out string? text)) return false;
        if (long.TryParse(text, out long microseconds))
        {
            value.Value = new TimeValue(microseconds);
            return true;
        }
        return false;
    }

    public bool VisitBlazeObjectType(TdfObjectType value, Tdf parent, bool visitHeader)
    {
        if (!TryGetTextValue(value, visitHeader, out string? text)) return false;

        // Format: "component/type"
        string[] parts = text!.Split('/');
        if (parts.Length >= 2 &&
            ushort.TryParse(parts[0], out ushort component) &&
            ushort.TryParse(parts[1], out ushort type))
        {
            value.Value = new ObjectType(component, type);
            return true;
        }
        return false;
    }

    public bool VisitBlazeObjectId(TdfObjectId value, Tdf parent, bool visitHeader)
    {
        if (!TryGetTextValue(value, visitHeader, out string? text)) return false;

        // Format: "component/type/id"
        string[] parts = text!.Split('/');
        if (parts.Length >= 3 &&
            ushort.TryParse(parts[0], out ushort component) &&
            ushort.TryParse(parts[1], out ushort type) &&
            long.TryParse(parts[2], out long id))
        {
            value.Value = new ObjectId(component, type, id);
            return true;
        }
        return false;
    }

    public bool VisitBlob(TdfBlob value, Tdf parent, bool visitHeader)
    {
        if (!TryGetTextValue(value, visitHeader, out string? text)) return false;

        try
        {
            value.Value = Convert.FromBase64String(text!);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool VisitStruct<TStruct>(TdfStruct<TStruct> value, Tdf parent, bool visitHeader) where TStruct : Tdf?, new()
    {
        string memberKey;
        if (visitHeader)
        {
            string memberName = value.TdfInfo.Name.ToLowerInvariant();
            memberKey = _currentKey + "/" + memberName;

            // Check if this key exists in the param map (any sub-key)
            if (!HasKeysWithPrefix(memberKey))
                return false;
        }
        else
        {
            memberKey = _currentKey;
        }

        if (value.Value == null)
            value.Value = new TStruct();

        if (value.Value == null)
            return false;

        PushKey(memberKey);
        VisitMembers(value.Value);
        PopKey();
        return true;
    }

    public bool VisitList<T>(TdfList<T> value, Tdf parent, bool visitHeader)
    {
        string listKey;
        if (visitHeader)
        {
            string memberName = value.TdfInfo.Name.ToLowerInvariant();
            listKey = _currentKey + "/" + memberName;
        }
        else
        {
            listKey = _currentKey;
        }

        // Determine the element name used for list items
        string elementName = GetListElementName(typeof(T));

        // Find the array size
        string arrayKey = listKey + "/" + elementName;
        int count = 0;
        if (_reader.ArraySizeMap.TryGetValue(arrayKey, out int size))
            count = size;

        if (count == 0)
            return false;

        var list = new List<T>();

        for (int i = 0; i < count; i++)
        {
            string itemKey = i == 0 ? arrayKey : arrayKey + "|" + i;

            PushKey(itemKey);
            T? item = ReadListItem<T>(itemKey);
            PopKey();

            if (item != null)
                list.Add(item);
        }

        value.Value = list;
        return true;
    }

    public bool VisitMap<TKey, TValue>(TdfMap<TKey, TValue> value, Tdf parent, bool visitHeader) where TKey : notnull
    {
        string mapKey;
        if (visitHeader)
        {
            string memberName = value.TdfInfo.Name.ToLowerInvariant();
            mapKey = _currentKey + "/" + memberName;
        }
        else
        {
            mapKey = _currentKey;
        }

        // Get map keys
        if (!_reader.MapKeysMap.TryGetValue(mapKey, out List<string>? mapKeys) || mapKeys.Count == 0)
            return false;

        var dict = new SortedDictionary<TKey, TValue>();

        foreach (string keyStr in mapKeys)
        {
            string entryKey = mapKey + "|" + keyStr;

            TKey? parsedKey = ParseValue<TKey>(keyStr);
            if (parsedKey == null)
                continue;

            // Try to read the value
            PushKey(entryKey);
            TValue? parsedValue = ReadMapValue<TValue>(entryKey);
            PopKey();

            if (parsedValue != null)
                dict[parsedKey] = parsedValue;
        }

        value.Value = dict;
        return true;
    }

    public bool VisitUnion<TUnion>(TdfUnion<TUnion> value, Tdf parent, bool visitHeader) where TUnion : Union, new()
    {
        string unionKey;
        if (visitHeader)
        {
            string memberName = value.TdfInfo.Name.ToLowerInvariant();
            unionKey = _currentKey + "/" + memberName;
        }
        else
        {
            unionKey = _currentKey;
        }

        // Try to read the member attribute
        string memberAttrKey = unionKey + "@member";
        if (_reader.ParamMap.TryGetValue(memberAttrKey, out string? memberIndexStr) &&
            byte.TryParse(memberIndexStr, out byte memberIndex))
        {
            value.Value ??= new TUnion();
            value.Value.SwitchActiveIndex(memberIndex);

            // Content is inside <valu> sub-element
            string valuKey = unionKey + "/valu";
            PushKey(valuKey);

            ITdfMember? activeMember = value.Value.GetActiveMember();
            if (activeMember != null)
                activeMember.Visit(this, value.Value, visitHeader: false);

            PopKey();
        }
        else
        {
            // Union without member attribute - try to detect active member by presence
            value.Value ??= new TUnion();

            // Try each possible member index
            if (!TryDetectUnionMember(value.Value, unionKey))
                return false;
        }

        return true;
    }

    public bool VisitVariable(TdfVariable value, Tdf parent, bool visitHeader)
    {
        string varKey;
        if (visitHeader)
        {
            string memberName = value.TdfInfo.Name.ToLowerInvariant();
            varKey = _currentKey + "/" + memberName;
        }
        else
        {
            varKey = _currentKey;
        }

        // Read tdfid attribute
        string tdfIdAttrKey = varKey + "@tdfid";
        if (!_reader.ParamMap.TryGetValue(tdfIdAttrKey, out string? tdfIdStr))
            return false;

        // Variable TDF decoding requires a registry to instantiate the correct type
        // For now, store the raw data and tdfid
        // TODO: Implement full variable TDF decoding with registry support
        return false;
    }

    // -- Private helpers --

    private void VisitMembers(Tdf tdf)
    {
        IEnumerator<ITdfMember> enumerator = tdf.AllMembers().GetEnumerator();

        if (enumerator.MoveNext())
        {
            do
            {
                ITdfMember member = enumerator.Current;
                bool visited = member.Visit(this, tdf, visitHeader: true);

                if (visited && !member.TdfInfo.IsUnique)
                {
                    while (enumerator.MoveNext())
                    {
                        ITdfMember next = enumerator.Current;
                        if (next.TdfInfo.Tag != member.TdfInfo.Tag)
                            break;
                    }
                }
            }
            while (enumerator.MoveNext());
        }
    }

    private static string GetClassName(Tdf tdf)
    {
        string name = tdf.GetClassName().ToLowerInvariant();

        if (name.Length > 8 && name.EndsWith("response"))
            name = name[..^8];

        return name;
    }

    private bool TryGetMemberValue(ITdfMember member, out string? text)
    {
        string memberName = member.TdfInfo.Name.ToLowerInvariant();
        string key = _currentKey + "/" + memberName;
        return _reader.ParamMap.TryGetValue(key, out text);
    }

    private bool TryGetCurrentValue(out string? text)
    {
        return _reader.ParamMap.TryGetValue(_currentKey, out text);
    }

    private bool TryGetTextValue(ITdfMember member, bool visitHeader, out string? text)
    {
        if (visitHeader)
            return TryGetMemberValue(member, out text);
        return TryGetCurrentValue(out text);
    }

    private bool HasKeysWithPrefix(string prefix)
    {
        foreach (var key in _reader.ParamMap.Keys)
        {
            if (key.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                return true;
        }

        // Also check array size map
        foreach (var key in _reader.ArraySizeMap.Keys)
        {
            if (key.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                return true;
        }

        return false;
    }

    private void PushKey(string newKey)
    {
        _keyStack.Push(_currentKey);
        _currentKey = newKey;
    }

    private void PopKey()
    {
        _currentKey = _keyStack.Pop();
    }

    private T? ReadListItem<T>(string itemKey)
    {
        if (typeof(T).IsSubclassOf(typeof(Tdf)) || typeof(T) == typeof(Tdf))
        {
            // Struct items: look for sub-keys under the item key
            // The struct name element is already part of the item key
            T? instance = Activator.CreateInstance<T>();
            if (instance is Tdf tdf)
            {
                VisitMembers(tdf);
                return instance;
            }
            return default;
        }

        // Primitive items: read from param map
        if (_reader.ParamMap.TryGetValue(itemKey, out string? text))
            return ParseValue<T>(text);

        return default;
    }

    private T? ReadMapValue<T>(string entryKey)
    {
        if (typeof(T).IsSubclassOf(typeof(Tdf)) || typeof(T) == typeof(Tdf))
        {
            // Struct values in maps
            // Find the struct element name under the entry
            foreach (var key in _reader.ParamMap.Keys)
            {
                if (key.StartsWith(entryKey + "/", StringComparison.OrdinalIgnoreCase))
                {
                    // Found a sub-key, try to decode the struct
                    string structPart = key[(entryKey.Length + 1)..];
                    string structName = structPart.Contains('/') ? structPart[..structPart.IndexOf('/')] : structPart;
                    string structKey = entryKey + "/" + structName;

                    T? instance = Activator.CreateInstance<T>();
                    if (instance is Tdf tdf)
                    {
                        PushKey(structKey);
                        VisitMembers(tdf);
                        PopKey();
                        return instance;
                    }
                    break;
                }
            }
            return default;
        }

        // Primitive values in maps
        if (_reader.ParamMap.TryGetValue(entryKey, out string? text))
            return ParseValue<T>(text);

        return default;
    }

    private static T? ParseValue<T>(string text)
    {
        Type type = typeof(T);

        try
        {
            if (type == typeof(string)) return (T)(object)text;
            if (type == typeof(bool)) return (T)(object)(text == "1" || text.Equals("true", StringComparison.OrdinalIgnoreCase));
            if (type == typeof(sbyte)) return (T)(object)sbyte.Parse(text);
            if (type == typeof(byte)) return (T)(object)byte.Parse(text);
            if (type == typeof(short)) return (T)(object)short.Parse(text);
            if (type == typeof(ushort)) return (T)(object)ushort.Parse(text);
            if (type == typeof(int)) return (T)(object)int.Parse(text);
            if (type == typeof(uint)) return (T)(object)uint.Parse(text);
            if (type == typeof(long)) return (T)(object)long.Parse(text);
            if (type == typeof(ulong)) return (T)(object)ulong.Parse(text);
            if (type == typeof(float)) return (T)(object)float.Parse(text, CultureInfo.InvariantCulture);
            if (type == typeof(TimeValue)) return (T)(object)new TimeValue(long.Parse(text));
            if (type == typeof(ObjectType))
            {
                string[] parts = text.Split('/');
                if (parts.Length >= 2)
                    return (T)(object)new ObjectType(ushort.Parse(parts[0]), ushort.Parse(parts[1]));
            }
            if (type == typeof(ObjectId))
            {
                string[] parts = text.Split('/');
                if (parts.Length >= 3)
                    return (T)(object)new ObjectId(ushort.Parse(parts[0]), ushort.Parse(parts[1]), long.Parse(parts[2]));
            }
            if (type.IsEnum)
            {
                if (Enum.TryParse(type, text, ignoreCase: true, out object? enumVal))
                    return (T)enumVal!;
                if (int.TryParse(text, out int numVal))
                    return (T)Enum.ToObject(type, numVal);
            }
        }
        catch
        {
            // Parse failure
        }

        return default;
    }

    private bool TryDetectUnionMember(Union union, string unionKey)
    {
        // For unions without member attribute, try to detect active member
        // by checking which member's field name exists in the param map
        // This iterates through possible member indices and checks each
        for (byte i = 0; i < 255; i++)
        {
            union.SwitchActiveIndex(i);
            ITdfMember? member = union.GetActiveMember();
            if (member == null)
            {
                union.Reset();
                return false;
            }

            string memberName = member.TdfInfo.Name.ToLowerInvariant();
            string memberKey = unionKey + "/" + memberName;

            if (HasKeysWithPrefix(memberKey) || _reader.ParamMap.ContainsKey(memberKey))
            {
                PushKey(unionKey);
                member.Visit(this, union, visitHeader: true);
                PopKey();
                return true;
            }
        }

        union.Reset();
        return false;
    }

    private static string GetListElementName(Type elementType)
    {
        if (elementType == typeof(string)) return "string";
        if (elementType == typeof(bool)) return "bool";
        if (elementType == typeof(sbyte)) return "int8";
        if (elementType == typeof(byte)) return "uint8";
        if (elementType == typeof(short)) return "int16";
        if (elementType == typeof(ushort)) return "uint16";
        if (elementType == typeof(int)) return "int32";
        if (elementType == typeof(uint)) return "uint32";
        if (elementType == typeof(long)) return "int64";
        if (elementType == typeof(ulong)) return "uint64";
        if (elementType == typeof(float)) return "float";
        if (elementType == typeof(ObjectType)) return "objecttype";
        if (elementType == typeof(ObjectId)) return "objectid";
        if (elementType == typeof(TimeValue)) return "timevalue";
        if (elementType.IsEnum) return "enum";
        // For struct types, the element name is the class name lowercased
        if (elementType.IsSubclassOf(typeof(Tdf)))
        {
            Tdf? instance = Activator.CreateInstance(elementType) as Tdf;
            return instance?.GetClassName().ToLowerInvariant() ?? "entry";
        }
        return "entry";
    }
}
