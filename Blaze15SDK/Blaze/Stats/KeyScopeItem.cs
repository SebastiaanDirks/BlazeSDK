using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Stats;

public class KeyScopeItem : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AggregateKeyValue", "mAggregateKeyValue", 0x0472D900, TdfType.Int64, 0, true), // agky
        new TdfMemberInfo("EnableAggregation", "mEnableAggregation", 0x14E04700, TdfType.Bool, 1, true), // enag
        new TdfMemberInfo("KeyScopeValues", "mKeyScopeValues", 0x2D358C00, TdfType.Map, 2, true), // ksvl
    ];
    private ITdfMember[] __members;

    private TdfInt64 _aggregateKeyValue = new(__typeInfos[0]);
    private TdfBool _enableAggregation = new(__typeInfos[1]);
    private TdfMap<long, long> _keyScopeValues = new(__typeInfos[2]);

    public KeyScopeItem()
    {
        __members = [ _aggregateKeyValue, _enableAggregation, _keyScopeValues ];
    }

    public override Tdf CreateNew() => new KeyScopeItem();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "KeyScopeItem";
    public override string GetFullClassName() => "Blaze::Stats::KeyScopeItem";

    public long AggregateKeyValue
    {
        get => _aggregateKeyValue.Value;
        set => _aggregateKeyValue.Value = value;
    }

    public bool EnableAggregation
    {
        get => _enableAggregation.Value;
        set => _enableAggregation.Value = value;
    }

    public IDictionary<long, long> KeyScopeValues
    {
        get => _keyScopeValues.Value;
        set => _keyScopeValues.Value = value;
    }

}
