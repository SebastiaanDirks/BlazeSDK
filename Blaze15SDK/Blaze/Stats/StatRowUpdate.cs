using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Stats;

public class StatRowUpdate : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Category", "mCategory", 0x0C150000, TdfType.String, 0, true), // cat
        new TdfMemberInfo("EntityId", "mEntityId", 0x14910000, TdfType.UInt64, 1, true), // eid
        new TdfMemberInfo("KeyScopeNameValueMap", "mKeyScopeNameValueMap", 0x2D354D00, TdfType.Map, 2, true), // ksum
        new TdfMemberInfo("PeriodTypes", "mPeriodTypes", 0x41465000, TdfType.List, 3, true), // ptyp
        new TdfMemberInfo("Updates", "mUpdates", 0x55011400, TdfType.List, 4, true), // updt
    ];
    private ITdfMember[] __members;

    private TdfString _category = new(__typeInfos[0]);
    private TdfUInt64 _entityId = new(__typeInfos[1]);
    private TdfMap<string, long> _keyScopeNameValueMap = new(__typeInfos[2]);
    private TdfList<int> _periodTypes = new(__typeInfos[3]);
    private TdfList<Blaze15SDK.Blaze.Stats.StatUpdate> _updates = new(__typeInfos[4]);

    public StatRowUpdate()
    {
        __members = [ _category, _entityId, _keyScopeNameValueMap, _periodTypes, _updates ];
    }

    public override Tdf CreateNew() => new StatRowUpdate();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "StatRowUpdate";
    public override string GetFullClassName() => "Blaze::Stats::StatRowUpdate";

    public string Category
    {
        get => _category.Value;
        set => _category.Value = value;
    }

    public ulong EntityId
    {
        get => _entityId.Value;
        set => _entityId.Value = value;
    }

    public IDictionary<string, long> KeyScopeNameValueMap
    {
        get => _keyScopeNameValueMap.Value;
        set => _keyScopeNameValueMap.Value = value;
    }

    public IList<int> PeriodTypes
    {
        get => _periodTypes.Value;
        set => _periodTypes.Value = value;
    }

    public IList<Blaze15SDK.Blaze.Stats.StatUpdate> Updates
    {
        get => _updates.Value;
        set => _updates.Value = value;
    }

}
