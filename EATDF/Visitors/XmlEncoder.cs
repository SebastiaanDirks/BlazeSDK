using EATDF.Members;
using EATDF.Types;
using EATDF.Xml;

namespace EATDF.Visitors;

public class XmlEncoder : ITdfVisitor
{
    private readonly XmlWriter _writer;

    private enum State
    {
        Normal,
        Array,
        Map,
        Union,
        Variable
    }

    private struct StateEntry
    {
        public State State;
        public byte ActiveMember;
        public bool EncodeMemberIndex;
        public bool NextIsMapKey;
        public uint VariableTdfId;
        public string? VariableTdfClass;
    }

    private readonly StateEntry[] _stateStack = new StateEntry[32];
    private int _stateDepth = 0;

    /// <summary>
    /// The VALU tag (0xDA1B3500) used by unions with reserved member tags.
    /// </summary>
    private const uint ValuTag = 0xDA1B3500;

    public XmlEncoder(Stream stream)
    {
        _writer = new XmlWriter(stream);
        _stateStack[0].State = State.Normal;
    }

    public void VisitTdf(Tdf value)
    {
        string className = GetClassName(value);

        _writer.WriteStartDocument();
        _writer.WriteStartElement(className);
        _writer.WriteNewLine();

        VisitMembers(value);

        _writer.WriteEndElement();
        _writer.WriteEndDocument();
    }

    public bool VisitBool(TdfBool value, Tdf parent, bool visitHeader)
    {
        if (visitHeader && !value.IsSet()) return false;
        WritePrimitive(value, parent, value.Value ? "1" : "0");
        return true;
    }

    public bool VisitInt8(TdfInt8 value, Tdf parent, bool visitHeader)
    {
        if (visitHeader && !value.IsSet()) return false;
        WritePrimitive(value, parent, value.Value.ToString());
        return true;
    }

    public bool VisitUInt8(TdfUInt8 value, Tdf parent, bool visitHeader)
    {
        if (visitHeader && !value.IsSet()) return false;
        WritePrimitive(value, parent, value.Value.ToString());
        return true;
    }

    public bool VisitInt16(TdfInt16 value, Tdf parent, bool visitHeader)
    {
        if (visitHeader && !value.IsSet()) return false;
        WritePrimitive(value, parent, value.Value.ToString());
        return true;
    }

    public bool VisitUInt16(TdfUInt16 value, Tdf parent, bool visitHeader)
    {
        if (visitHeader && !value.IsSet()) return false;
        WritePrimitive(value, parent, value.Value.ToString());
        return true;
    }

    public bool VisitInt32(TdfInt32 value, Tdf parent, bool visitHeader)
    {
        if (visitHeader && !value.IsSet()) return false;
        WritePrimitive(value, parent, value.Value.ToString());
        return true;
    }

    public bool VisitUInt32(TdfUInt32 value, Tdf parent, bool visitHeader)
    {
        if (visitHeader && !value.IsSet()) return false;
        WritePrimitive(value, parent, value.Value.ToString());
        return true;
    }

    public bool VisitInt64(TdfInt64 value, Tdf parent, bool visitHeader)
    {
        if (visitHeader && !value.IsSet()) return false;
        WritePrimitive(value, parent, value.Value.ToString());
        return true;
    }

    public bool VisitUInt64(TdfUInt64 value, Tdf parent, bool visitHeader)
    {
        if (visitHeader && !value.IsSet()) return false;
        WritePrimitive(value, parent, value.Value.ToString());
        return true;
    }

    public bool VisitFloat(TdfFloat value, Tdf parent, bool visitHeader)
    {
        if (visitHeader && !value.IsSet()) return false;
        WritePrimitive(value, parent, value.Value.ToString("G"));
        return true;
    }

    public bool VisitString(TdfString value, Tdf parent, bool visitHeader)
    {
        if (visitHeader && !value.IsSet()) return false;
        WritePrimitive(value, parent, value.Value);
        return true;
    }

    public bool VisitEnum<TEnum>(TdfEnum<TEnum> value, Tdf parent, bool visitHeader) where TEnum : Enum, new()
    {
        if (visitHeader && !value.IsSet()) return false;
        WritePrimitive(value, parent, value.Value.ToString());
        return true;
    }

    public bool VisitTimeValue(TdfTimeValue value, Tdf parent, bool visitHeader)
    {
        if (visitHeader && !value.IsSet()) return false;
        WritePrimitive(value, parent, value.Value.Microseconds.ToString());
        return true;
    }

    public bool VisitBlazeObjectType(TdfObjectType value, Tdf parent, bool visitHeader)
    {
        if (visitHeader && !value.IsSet()) return false;
        WritePrimitive(value, parent, value.Value.ToString());
        return true;
    }

    public bool VisitBlazeObjectId(TdfObjectId value, Tdf parent, bool visitHeader)
    {
        if (visitHeader && !value.IsSet()) return false;
        WritePrimitive(value, parent, value.Value.ToString());
        return true;
    }

    public bool VisitBlob(TdfBlob value, Tdf parent, bool visitHeader)
    {
        if (visitHeader && !value.IsSet()) return false;

        string elementName = value.TdfInfo.Name.ToLowerInvariant();
        string base64 = Convert.ToBase64String(value.Value);

        var attrs = new Dictionary<string, string>
        {
            ["count"] = base64.Length.ToString(),
            ["enc"] = "base64"
        };

        _writer.WriteStartElement(elementName, attrs);
        _writer.WriteNewLine();
        _writer.WriteRawText(base64);
        _writer.WriteEndElement();
        return true;
    }

    public bool VisitStruct<TStruct>(TdfStruct<TStruct> value, Tdf parent, bool visitHeader) where TStruct : Tdf?, new()
    {
        if (visitHeader && !value.IsSet()) return false;
        if (value.Value == null) return false;
        
        bool insideValuUnion = _stateStack[_stateDepth].State == State.Union
                               && _stateStack[_stateDepth].EncodeMemberIndex;

        PushStack(State.Normal);
        if (!insideValuUnion)
        {
            string elementName = value.TdfInfo.Name.ToLowerInvariant();
            _writer.WriteStartElement(elementName);
            _writer.WriteNewLine();
        }
        VisitMembers(value.Value);
        if (!insideValuUnion)
        {
            _writer.WriteEndElement();
        }
        PopStack();
        return true;
    }

    public bool VisitList<T>(TdfList<T> value, Tdf parent, bool visitHeader)
    {
        if (visitHeader && !value.IsSet()) return false;

        string elementName = value.TdfInfo.Name.ToLowerInvariant();
        bool parentIsArray = _stateStack[_stateDepth].State == State.Array;

        if (value.Value.Count == 0 && !parentIsArray)
            return true;

        _writer.WriteStartElement(elementName);
        _writer.WriteNewLine();

        PushStack(State.Array);

        foreach (T item in value.Value)
            WriteListElement(item, parent);

        PopStack();

        _writer.WriteEndElement();
        return true;
    }

    public bool VisitMap<TKey, TValue>(TdfMap<TKey, TValue> value, Tdf parent, bool visitHeader) where TKey : notnull
    {
        if (visitHeader && !value.IsSet()) return false;

        string elementName = value.TdfInfo.Name.ToLowerInvariant();
        bool parentIsArray = _stateStack[_stateDepth].State == State.Array;

        if (value.Value.Count == 0 && !parentIsArray)
            return true;

        _writer.WriteStartElement(elementName);
        _writer.WriteNewLine();

        PushStack(State.Map);
        _stateStack[_stateDepth].NextIsMapKey = true;

        foreach (var pair in value.Value)
        {
            string keyStr = ConvertToString(pair.Key);

            if (pair.Value is Tdf tdfValue)
            {
                var attrs = new Dictionary<string, string> { ["key"] = keyStr };
                _writer.WriteStartElement("entry", attrs);
                _writer.WriteNewLine();

                PushStack(State.Normal);
                string structName = tdfValue.GetClassName().ToLowerInvariant();
                _writer.WriteStartElement(structName);
                _writer.WriteNewLine();
                VisitMembers(tdfValue);
                _writer.WriteEndElement();
                PopStack();

                _writer.WriteEndElement();
            }
            else
            {
                string valueStr = ConvertToString(pair.Value);
                var attrs = new Dictionary<string, string> { ["key"] = keyStr };
                _writer.WriteElement("entry", valueStr, attrs);
            }
        }

        PopStack();

        _writer.WriteEndElement();
        return true;
    }

    public bool VisitUnion<TUnion>(TdfUnion<TUnion> value, Tdf parent, bool visitHeader) where TUnion : Union, new()
    {
        if (visitHeader && !value.IsSet()) return false;
        if (value.Value == null) return false;

        string elementName = value.TdfInfo.Name.ToLowerInvariant();
        ITdfMember? activeMember = value.Value.GetActiveMember();

        bool encodeMemberIndex = activeMember != null && activeMember.TdfInfo.Tag == ValuTag;

        PushStack(State.Union);
        _stateStack[_stateDepth].ActiveMember = value.Value.ActiveIndex;
        _stateStack[_stateDepth].EncodeMemberIndex = encodeMemberIndex;

        if (encodeMemberIndex)
        {
            var attrs = new Dictionary<string, string>
            {
                ["member"] = value.Value.ActiveIndex.ToString()
            };
            _writer.WriteStartElement(elementName, attrs);
            _writer.WriteNewLine();

            if (activeMember != null)
            {
                _writer.WriteStartElement("valu");
                _writer.WriteNewLine();
                activeMember.Visit(this, value.Value, visitHeader: false);
                _writer.WriteEndElement();
            }
        }
        else
        {
            _writer.WriteStartElement(elementName);
            _writer.WriteNewLine();

            if (activeMember != null)
                activeMember.Visit(this, value.Value, visitHeader: false);
        }

        _writer.WriteEndElement();
        PopStack();
        return true;
    }

    public bool VisitVariable(TdfVariable value, Tdf parent, bool visitHeader)
    {
        if (visitHeader && !value.IsSet()) return false;
        if (value.Value is not Tdf tdfValue) return false;

        string elementName = value.TdfInfo.Name.ToLowerInvariant();

        var attrs = new Dictionary<string, string>
        {
            ["tdfid"] = tdfValue.GetTdfId().ToString(),
            ["tdfclass"] = tdfValue.GetFullClassName()
        };

        PushStack(State.Variable);
        _stateStack[_stateDepth].VariableTdfId = tdfValue.GetTdfId();
        _stateStack[_stateDepth].VariableTdfClass = tdfValue.GetFullClassName();

        _writer.WriteStartElement(elementName, attrs);
        _writer.WriteNewLine();
        VisitMembers(tdfValue);
        _writer.WriteEndElement();

        PopStack();
        return true;
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

    private void WritePrimitive(ITdfMember member, Tdf parent, string textValue)
    {
        string elementName = member.TdfInfo.Name.ToLowerInvariant();
        _writer.WriteElement(elementName, textValue);
    }

    private void WriteListElement<T>(T item, Tdf parent)
    {
        if (item is Tdf tdfItem)
        {
            string structName = tdfItem.GetClassName().ToLowerInvariant();
            PushStack(State.Normal);
            _writer.WriteStartElement(structName);
            _writer.WriteNewLine();
            VisitMembers(tdfItem);
            _writer.WriteEndElement();
            PopStack();
        }
        else
        {
            string typeName = GetListElementName(typeof(T));
            string textValue = ConvertToString(item);
            _writer.WriteElement(typeName, textValue);
        }
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
        return "entry";
    }

    private static string ConvertToString<T>(T value)
    {
        if (value is bool b) return b ? "1" : "0";
        if (value is TimeValue tv) return tv.Microseconds.ToString();
        if (value is ObjectType ot) return ot.ToString();
        if (value is ObjectId oid) return oid.ToString();
        if (value is Enum e) return e.ToString();
        return value?.ToString() ?? "";
    }

    private void PushStack(State state)
    {
        _stateDepth++;
        _stateStack[_stateDepth] = new StateEntry { State = state };
    }

    private void PopStack()
    {
        _stateDepth--;
    }
}
