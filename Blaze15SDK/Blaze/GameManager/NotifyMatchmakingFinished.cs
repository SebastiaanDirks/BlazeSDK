using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class NotifyMatchmakingFinished : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("SessionDuration", "mSessionDuration", 0x11548100, TdfType.Int64, 0, true), // dura
        new TdfMemberInfo("MaxPossibleFitScore", "mMaxPossibleFitScore", 0x34160600, TdfType.UInt32, 1, true), // maxf
        new TdfMemberInfo("ScenarioId", "mScenarioId", 0x3530C400, TdfType.UInt64, 2, true), // mscd
        new TdfMemberInfo("SessionId", "mSessionId", 0x35324400, TdfType.UInt64, 3, true), // msid
        new TdfMemberInfo("MatchmakingResult", "mMatchmakingResult", 0x49331400, TdfType.Enum, 4, true), // rslt
        new TdfMemberInfo("UserSessionId", "mUserSessionId", 0x55324400, TdfType.UInt64, 5, true), // usid
    ];
    private ITdfMember[] __members;

    private TdfInt64 _sessionDuration = new(__typeInfos[0]);
    private TdfUInt32 _maxPossibleFitScore = new(__typeInfos[1]);
    private TdfUInt64 _scenarioId = new(__typeInfos[2]);
    private TdfUInt64 _sessionId = new(__typeInfos[3]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.MatchmakingResult> _matchmakingResult = new(__typeInfos[4]);
    private TdfUInt64 _userSessionId = new(__typeInfos[5]);

    public NotifyMatchmakingFinished()
    {
        __members = [ _sessionDuration, _maxPossibleFitScore, _scenarioId, _sessionId, _matchmakingResult, _userSessionId ];
    }

    public override Tdf CreateNew() => new NotifyMatchmakingFinished();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyMatchmakingFinished";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyMatchmakingFinished";

    public long SessionDuration
    {
        get => _sessionDuration.Value;
        set => _sessionDuration.Value = value;
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

    public ulong UserSessionId
    {
        get => _userSessionId.Value;
        set => _userSessionId.Value = value;
    }

}
