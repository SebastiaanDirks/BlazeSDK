using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Stats;

public class FilteredLeaderboardStatsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EnforceCutoffStatValue", "mEnforceCutoffStatValue", 0x0CF19600, TdfType.Bool, 0, true), // cofv
        new TdfMemberInfo("IncludeStatlessEntities", "mIncludeStatlessEntities", 0x18931400, TdfType.Bool, 1, true), // filt
        new TdfMemberInfo("ListOfIds", "mListOfIds", 0x24431300, TdfType.List, 2, true), // idls
        new TdfMemberInfo("KeyScopeNameValueMap", "mKeyScopeNameValueMap", 0x2D354D00, TdfType.Map, 3, true), // ksum
        new TdfMemberInfo("BoardId", "mBoardId", 0x30224400, TdfType.Int32, 4, true), // lbid
        new TdfMemberInfo("Limit", "mLimit", 0x30935400, TdfType.UInt32, 5, true), // limt
        new TdfMemberInfo("BoardName", "mBoardName", 0x38134500, TdfType.String, 6, true), // name
        new TdfMemberInfo("PeriodOffset", "mPeriodOffset", 0x40F18600, TdfType.Int32, 7, true), // poff
        new TdfMemberInfo("PeriodId", "mPeriodId", 0x41224400, TdfType.Int32, 8, true), // prid
        new TdfMemberInfo("Time", "mTime", 0x50934500, TdfType.Int32, 9, true), // time
        new TdfMemberInfo("UserSetId", "mUserSetId", 0x55315400, TdfType.ObjectId, 10, true), // uset
    ];
    private ITdfMember[] __members;

    private TdfBool _enforceCutoffStatValue = new(__typeInfos[0]);
    private TdfBool _includeStatlessEntities = new(__typeInfos[1]);
    private TdfList<ulong> _listOfIds = new(__typeInfos[2]);
    private TdfMap<string, long> _keyScopeNameValueMap = new(__typeInfos[3]);
    private TdfInt32 _boardId = new(__typeInfos[4]);
    private TdfUInt32 _limit = new(__typeInfos[5]);
    private TdfString _boardName = new(__typeInfos[6]);
    private TdfInt32 _periodOffset = new(__typeInfos[7]);
    private TdfInt32 _periodId = new(__typeInfos[8]);
    private TdfInt32 _time = new(__typeInfos[9]);
    private TdfObjectId _userSetId = new(__typeInfos[10]);

    public FilteredLeaderboardStatsRequest()
    {
        __members = [ _enforceCutoffStatValue, _includeStatlessEntities, _listOfIds, _keyScopeNameValueMap, _boardId, _limit, _boardName, _periodOffset, _periodId, _time, _userSetId ];
    }

    public override Tdf CreateNew() => new FilteredLeaderboardStatsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FilteredLeaderboardStatsRequest";
    public override string GetFullClassName() => "Blaze::Stats::FilteredLeaderboardStatsRequest";

    public bool EnforceCutoffStatValue
    {
        get => _enforceCutoffStatValue.Value;
        set => _enforceCutoffStatValue.Value = value;
    }

    public bool IncludeStatlessEntities
    {
        get => _includeStatlessEntities.Value;
        set => _includeStatlessEntities.Value = value;
    }

    public IList<ulong> ListOfIds
    {
        get => _listOfIds.Value;
        set => _listOfIds.Value = value;
    }

    public IDictionary<string, long> KeyScopeNameValueMap
    {
        get => _keyScopeNameValueMap.Value;
        set => _keyScopeNameValueMap.Value = value;
    }

    public int BoardId
    {
        get => _boardId.Value;
        set => _boardId.Value = value;
    }

    public uint Limit
    {
        get => _limit.Value;
        set => _limit.Value = value;
    }

    public string BoardName
    {
        get => _boardName.Value;
        set => _boardName.Value = value;
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

    public int Time
    {
        get => _time.Value;
        set => _time.Value = value;
    }

    public ObjectId UserSetId
    {
        get => _userSetId.Value;
        set => _userSetId.Value = value;
    }

}
