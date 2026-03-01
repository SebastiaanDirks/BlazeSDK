using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Stats;

public class GetStatsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Category", "mCategory", 0x0C150000, TdfType.String, 0, true), // cat
        new TdfMemberInfo("EntityIds", "mEntityIds", 0x14910000, TdfType.List, 1, true), // eid
        new TdfMemberInfo("EntityType", "mEntityType", 0x15465000, TdfType.ObjectType, 2, true), // etyp
        new TdfMemberInfo("KeyScopeNameValueMap", "mKeyScopeNameValueMap", 0x2D331300, TdfType.Map, 3, true), // ksls
        new TdfMemberInfo("StatNames", "mStatNames", 0x38134500, TdfType.List, 4, true), // name
        new TdfMemberInfo("PeriodOffset", "mPeriodOffset", 0x40F18600, TdfType.Int32, 5, true), // poff
        new TdfMemberInfo("PeriodId", "mPeriodId", 0x41224400, TdfType.Int32, 6, true), // prid
        new TdfMemberInfo("PeriodType", "mPeriodType", 0x41465000, TdfType.Int32, 7, true), // ptyp
    ];
    private ITdfMember[] __members;

    private TdfString _category = new(__typeInfos[0]);
    private TdfList<ulong> _entityIds = new(__typeInfos[1]);
    private TdfObjectType _entityType = new(__typeInfos[2]);
    private TdfMap<string, long> _keyScopeNameValueMap = new(__typeInfos[3]);
    private TdfList<string> _statNames = new(__typeInfos[4]);
    private TdfInt32 _periodOffset = new(__typeInfos[5]);
    private TdfInt32 _periodId = new(__typeInfos[6]);
    private TdfInt32 _periodType = new(__typeInfos[7]);

    public GetStatsRequest()
    {
        __members = [ _category, _entityIds, _entityType, _keyScopeNameValueMap, _statNames, _periodOffset, _periodId, _periodType ];
    }

    public override Tdf CreateNew() => new GetStatsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetStatsRequest";
    public override string GetFullClassName() => "Blaze::Stats::GetStatsRequest";

    public string Category
    {
        get => _category.Value;
        set => _category.Value = value;
    }

    public IList<ulong> EntityIds
    {
        get => _entityIds.Value;
        set => _entityIds.Value = value;
    }

    public ObjectType EntityType
    {
        get => _entityType.Value;
        set => _entityType.Value = value;
    }

    public IDictionary<string, long> KeyScopeNameValueMap
    {
        get => _keyScopeNameValueMap.Value;
        set => _keyScopeNameValueMap.Value = value;
    }

    public IList<string> StatNames
    {
        get => _statNames.Value;
        set => _statNames.Value = value;
    }

    public int PeriodOffset
    {
        get => _periodOffset.Value;
        set => _periodOffset.Value = value;
    }

    public int PeriodId
    {
        get => _periodId.Value;
        set => _periodId.Value = value;
    }

    public int PeriodType
    {
        get => _periodType.Value;
        set => _periodType.Value = value;
    }

}
