using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Stats;

public class KeyScopedStatValues : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GroupName", "mGroupName", 0x1D238D00, TdfType.String, 0, true), // grnm
        new TdfMemberInfo("KeyString", "mKeyString", 0x2C564000, TdfType.String, 1, true), // key
        new TdfMemberInfo("Last", "mLast", 0x3014D400, TdfType.Bool, 2, true), // last
        new TdfMemberInfo("StatValues", "mStatValues", 0x4D44C000, TdfType.Struct, 3, true), // sts
        new TdfMemberInfo("ViewId", "mViewId", 0x58910000, TdfType.UInt32, 4, true), // vid
    ];
    private ITdfMember[] __members;

    private TdfString _groupName = new(__typeInfos[0]);
    private TdfString _keyString = new(__typeInfos[1]);
    private TdfBool _last = new(__typeInfos[2]);
    private TdfStruct<Blaze15SDK.Blaze.Stats.StatValues?> _statValues = new(__typeInfos[3]);
    private TdfUInt32 _viewId = new(__typeInfos[4]);

    public KeyScopedStatValues()
    {
        __members = [ _groupName, _keyString, _last, _statValues, _viewId ];
    }

    public override Tdf CreateNew() => new KeyScopedStatValues();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "KeyScopedStatValues";
    public override string GetFullClassName() => "Blaze::Stats::KeyScopedStatValues";

    public string GroupName
    {
        get => _groupName.Value;
        set => _groupName.Value = value;
    }

    public string KeyString
    {
        get => _keyString.Value;
        set => _keyString.Value = value;
    }

    public bool Last
    {
        get => _last.Value;
        set => _last.Value = value;
    }

    public Blaze15SDK.Blaze.Stats.StatValues? StatValues
    {
        get => _statValues.Value;
        set => _statValues.Value = value;
    }

    public uint ViewId
    {
        get => _viewId.Value;
        set => _viewId.Value = value;
    }

}
