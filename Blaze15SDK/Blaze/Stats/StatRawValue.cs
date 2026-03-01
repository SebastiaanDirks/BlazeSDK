using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Stats;

public class StatRawValue : Union
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("FloatValue", "floatValue", 0x18C3D400, TdfType.Float, 0, true), // flot
        new TdfMemberInfo("IntValue", "intValue", 0x24E50000, TdfType.Int64, 1, true), // int
        new TdfMemberInfo("StringValue", "stringValue", 0x4D448000, TdfType.String, 2, true), // str
    ];
    private ITdfMember[] __members;

    private TdfFloat _floatValue = new(__typeInfos[0]);
    private TdfInt64 _intValue = new(__typeInfos[1]);
    private TdfString _stringValue = new(__typeInfos[2]);

    public StatRawValue()
    {
        __members = [ _floatValue, _intValue, _stringValue ];
    }

    public override Tdf CreateNew() => new StatRawValue();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "StatRawValue";
    public override string GetFullClassName() => "Blaze::Stats::StatRawValue";

    public override ITdfMember? GetActiveMember()
    {
        return ActiveIndex switch
        {
            0 => _floatValue,
            1 => _intValue,
            2 => _stringValue,
            _ => null
        };
    }

    public float FloatValue
    {
        get => _floatValue.Value;
        set { SwitchActiveIndex(0); _floatValue.Value = value; }
    }

    public long IntValue
    {
        get => _intValue.Value;
        set { SwitchActiveIndex(1); _intValue.Value = value; }
    }

    public string StringValue
    {
        get => _stringValue.Value;
        set { SwitchActiveIndex(2); _stringValue.Value = value; }
    }

}
