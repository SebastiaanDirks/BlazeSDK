using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class MatchmakingSetupContext : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EstimatedTimeToMatch", "mEstimatedTimeToMatch", 0x15450D00, TdfType.Int64, 0, true), // ettm
        new TdfMemberInfo("FitScore", "mFitScore", 0x18950000, TdfType.UInt32, 1, true), // fit
        new TdfMemberInfo("GameEntryType", "mGameEntryType", 0x1C539400, TdfType.Enum, 2, true), // gent
        new TdfMemberInfo("InitiatorId", "mInitiatorId", 0x24E25400, TdfType.Int64, 3, true), // init
        new TdfMemberInfo("MaxPossibleFitScore", "mMaxPossibleFitScore", 0x34160600, TdfType.UInt32, 4, true), // maxf
        new TdfMemberInfo("ScenarioId", "mScenarioId", 0x3530C400, TdfType.UInt64, 5, true), // mscd
        new TdfMemberInfo("SessionId", "mSessionId", 0x35324400, TdfType.UInt64, 6, true), // msid
        new TdfMemberInfo("MatchmakingResult", "mMatchmakingResult", 0x49331400, TdfType.Enum, 7, true), // rslt
        new TdfMemberInfo("MatchmakingTimeoutDuration", "mMatchmakingTimeoutDuration", 0x50F55400, TdfType.Int64, 8, true), // tout
        new TdfMemberInfo("TimeToMatch", "mTimeToMatch", 0x51434000, TdfType.Int64, 9, true), // ttm
        new TdfMemberInfo("TotalUsersInGame", "mTotalUsersInGame", 0x5151CD00, TdfType.UInt64, 10, true), // tugm
        new TdfMemberInfo("TotalUsersInMatchmaking", "mTotalUsersInMatchmaking", 0x51534D00, TdfType.UInt64, 11, true), // tumm
        new TdfMemberInfo("TotalUsersOnline", "mTotalUsersOnline", 0x5154D200, TdfType.UInt64, 12, true), // tusr
        new TdfMemberInfo("UserSessionId", "mUserSessionId", 0x55324400, TdfType.UInt64, 13, true), // usid
    ];
    private ITdfMember[] __members;

    private TdfInt64 _estimatedTimeToMatch = new(__typeInfos[0]);
    private TdfUInt32 _fitScore = new(__typeInfos[1]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.GameEntryType> _gameEntryType = new(__typeInfos[2]);
    private TdfInt64 _initiatorId = new(__typeInfos[3]);
    private TdfUInt32 _maxPossibleFitScore = new(__typeInfos[4]);
    private TdfUInt64 _scenarioId = new(__typeInfos[5]);
    private TdfUInt64 _sessionId = new(__typeInfos[6]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.MatchmakingResult> _matchmakingResult = new(__typeInfos[7]);
    private TdfInt64 _matchmakingTimeoutDuration = new(__typeInfos[8]);
    private TdfInt64 _timeToMatch = new(__typeInfos[9]);
    private TdfUInt64 _totalUsersInGame = new(__typeInfos[10]);
    private TdfUInt64 _totalUsersInMatchmaking = new(__typeInfos[11]);
    private TdfUInt64 _totalUsersOnline = new(__typeInfos[12]);
    private TdfUInt64 _userSessionId = new(__typeInfos[13]);

    public MatchmakingSetupContext()
    {
        __members = [ _estimatedTimeToMatch, _fitScore, _gameEntryType, _initiatorId, _maxPossibleFitScore, _scenarioId, _sessionId, _matchmakingResult, _matchmakingTimeoutDuration, _timeToMatch, _totalUsersInGame, _totalUsersInMatchmaking, _totalUsersOnline, _userSessionId ];
    }

    public override Tdf CreateNew() => new MatchmakingSetupContext();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "MatchmakingSetupContext";
    public override string GetFullClassName() => "Blaze::GameManager::MatchmakingSetupContext";

    public long EstimatedTimeToMatch
    {
        get => _estimatedTimeToMatch.Value;
        set => _estimatedTimeToMatch.Value = value;
    }

    public uint FitScore
    {
        get => _fitScore.Value;
        set => _fitScore.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.GameEntryType GameEntryType
    {
        get => _gameEntryType.Value;
        set => _gameEntryType.Value = value;
    }

    public long InitiatorId
    {
        get => _initiatorId.Value;
        set => _initiatorId.Value = value;
    }

    public uint MaxPossibleFitScore
    {
        get => _maxPossibleFitScore.Value;
        set => _maxPossibleFitScore.Value = value;
    }

    public ulong ScenarioId
    {
        get => _scenarioId.Value;
        set => _scenarioId.Value = value;
    }

    public ulong SessionId
    {
        get => _sessionId.Value;
        set => _sessionId.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.MatchmakingResult MatchmakingResult
    {
        get => _matchmakingResult.Value;
        set => _matchmakingResult.Value = value;
    }

    public long MatchmakingTimeoutDuration
    {
        get => _matchmakingTimeoutDuration.Value;
        set => _matchmakingTimeoutDuration.Value = value;
    }

    public long TimeToMatch
    {
        get => _timeToMatch.Value;
        set => _timeToMatch.Value = value;
    }

    public ulong TotalUsersInGame
    {
        get => _totalUsersInGame.Value;
        set => _totalUsersInGame.Value = value;
    }

    public ulong TotalUsersInMatchmaking
    {
        get => _totalUsersInMatchmaking.Value;
        set => _totalUsersInMatchmaking.Value = value;
    }

    public ulong TotalUsersOnline
    {
        get => _totalUsersOnline.Value;
        set => _totalUsersOnline.Value = value;
    }

    public ulong UserSessionId
    {
        get => _userSessionId.Value;
        set => _userSessionId.Value = value;
    }

}
