using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Stats;

public class LeaderboardStatsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Count", "mCount", 0x0CF54E00, TdfType.Int32, 0, true), // coun
        new TdfMemberInfo("KeyScopeNameValueMap", "mKeyScopeNameValueMap", 0x2D354D00, TdfType.Map, 1, true), // ksum
        new TdfMemberInfo("BoardId", "mBoardId", 0x30224400, TdfType.Int32, 2, true), // lbid
        new TdfMemberInfo("BoardName", "mBoardName", 0x38134500, TdfType.String, 3, true), // name
        new TdfMemberInfo("PeriodOffset", "mPeriodOffset", 0x40F18600, TdfType.Int32, 4, true), // poff
        new TdfMemberInfo("PeriodId", "mPeriodId", 0x41224400, TdfType.Int32, 5, true), // prid
        new TdfMemberInfo("RankStart", "mRankStart", 0x4D449400, TdfType.Int32, 6, true), // strt
        new TdfMemberInfo("Time", "mTime", 0x50934500, TdfType.Int32, 7, true), // time
        new TdfMemberInfo("UserSetId", "mUserSetId", 0x55315400, TdfType.ObjectId, 8, true), // uset
    ];
    private ITdfMember[] __members;

    private TdfInt32 _count = new(__typeInfos[0]);
    private TdfMap<string, long> _keyScopeNameValueMap = new(__typeInfos[1]);
    private TdfInt32 _boardId = new(__typeInfos[2]);
    private TdfString _boardName = new(__typeInfos[3]);
    private TdfInt32 _periodOffset = new(__typeInfos[4]);
    private TdfInt32 _periodId = new(__typeInfos[5]);
    private TdfInt32 _rankStart = new(__typeInfos[6]);
    private TdfInt32 _time = new(__typeInfos[7]);
    private TdfObjectId _userSetId = new(__typeInfos[8]);

    public LeaderboardStatsRequest()
    {
        __members = [ _count, _keyScopeNameValueMap, _boardId, _boardName, _periodOffset, _periodId, _rankStart, _time, _userSetId ];
    }

    public override Tdf CreateNew() => new LeaderboardStatsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LeaderboardStatsRequest";
    public override string GetFullClassName() => "Blaze::Stats::LeaderboardStatsRequest";

    public int Count
    {
        get => _count.Value;
        set => _count.Value = value;
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

    public int RankStart
    {
        get => _rankStart.Value;
        set => _rankStart.Value = value;
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
