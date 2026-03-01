using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Stats;

public class CenteredLeaderboardStatsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ShowAtBottomIfNotFound", "mShowAtBottomIfNotFound", 0x08F51400, TdfType.Bool, 0, true), // bott
        new TdfMemberInfo("Center", "mCenter", 0x0C539400, TdfType.UInt64, 1, true), // cent
        new TdfMemberInfo("Count", "mCount", 0x0CF54E00, TdfType.Int32, 2, true), // coun
        new TdfMemberInfo("KeyScopeNameValueMap", "mKeyScopeNameValueMap", 0x2D354D00, TdfType.Map, 3, true), // ksum
        new TdfMemberInfo("BoardId", "mBoardId", 0x30224400, TdfType.Int32, 4, true), // lbid
        new TdfMemberInfo("BoardName", "mBoardName", 0x38134500, TdfType.String, 5, true), // name
        new TdfMemberInfo("PeriodOffset", "mPeriodOffset", 0x40F18600, TdfType.Int32, 6, true), // poff
        new TdfMemberInfo("PeriodId", "mPeriodId", 0x41224400, TdfType.Int32, 7, true), // prid
        new TdfMemberInfo("Time", "mTime", 0x50934500, TdfType.Int32, 8, true), // time
        new TdfMemberInfo("UserSetId", "mUserSetId", 0x55315400, TdfType.ObjectId, 9, true), // uset
    ];
    private ITdfMember[] __members;

    private TdfBool _showAtBottomIfNotFound = new(__typeInfos[0]);
    private TdfUInt64 _center = new(__typeInfos[1]);
    private TdfInt32 _count = new(__typeInfos[2]);
    private TdfMap<string, long> _keyScopeNameValueMap = new(__typeInfos[3]);
    private TdfInt32 _boardId = new(__typeInfos[4]);
    private TdfString _boardName = new(__typeInfos[5]);
    private TdfInt32 _periodOffset = new(__typeInfos[6]);
    private TdfInt32 _periodId = new(__typeInfos[7]);
    private TdfInt32 _time = new(__typeInfos[8]);
    private TdfObjectId _userSetId = new(__typeInfos[9]);

    public CenteredLeaderboardStatsRequest()
    {
        __members = [ _showAtBottomIfNotFound, _center, _count, _keyScopeNameValueMap, _boardId, _boardName, _periodOffset, _periodId, _time, _userSetId ];
    }

    public override Tdf CreateNew() => new CenteredLeaderboardStatsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CenteredLeaderboardStatsRequest";
    public override string GetFullClassName() => "Blaze::Stats::CenteredLeaderboardStatsRequest";

    public bool ShowAtBottomIfNotFound
    {
        get => _showAtBottomIfNotFound.Value;
        set => _showAtBottomIfNotFound.Value = value;
    }

    public ulong Center
    {
        get => _center.Value;
        set => _center.Value = value;
    }

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
