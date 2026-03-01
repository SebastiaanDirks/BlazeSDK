using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class NotifyMatchmakingSessionConnectionValidated : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ConnectionValidatedResults", "mConnectionValidatedResults", 0x0CF39600, TdfType.Struct, 0, true), // conv
        new TdfMemberInfo("DispatchSessionFinished", "mDispatchSessionFinished", 0x1094D000, TdfType.Bool, 1, true), // disp
        new TdfMemberInfo("GameId", "mGameId", 0x1C910000, TdfType.UInt64, 2, true), // gid
        new TdfMemberInfo("UserGroupId", "mUserGroupId", 0x1D224400, TdfType.ObjectId, 3, true), // grid
        new TdfMemberInfo("ScenarioId", "mScenarioId", 0x3530C400, TdfType.UInt64, 4, true), // mscd
        new TdfMemberInfo("SessionId", "mSessionId", 0x35324400, TdfType.UInt64, 5, true), // msid
        new TdfMemberInfo("QosValidationPerformed", "mQosValidationPerformed", 0x45359200, TdfType.Bool, 6, true), // qsvr
        new TdfMemberInfo("UserSessionId", "mUserSessionId", 0x55324400, TdfType.UInt64, 7, true), // usid
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.GameManager.ConnectionValidationResults?> _connectionValidatedResults = new(__typeInfos[0]);
    private TdfBool _dispatchSessionFinished = new(__typeInfos[1]);
    private TdfUInt64 _gameId = new(__typeInfos[2]);
    private TdfObjectId _userGroupId = new(__typeInfos[3]);
    private TdfUInt64 _scenarioId = new(__typeInfos[4]);
    private TdfUInt64 _sessionId = new(__typeInfos[5]);
    private TdfBool _qosValidationPerformed = new(__typeInfos[6]);
    private TdfUInt64 _userSessionId = new(__typeInfos[7]);

    public NotifyMatchmakingSessionConnectionValidated()
    {
        __members = [ _connectionValidatedResults, _dispatchSessionFinished, _gameId, _userGroupId, _scenarioId, _sessionId, _qosValidationPerformed, _userSessionId ];
    }

    public override Tdf CreateNew() => new NotifyMatchmakingSessionConnectionValidated();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyMatchmakingSessionConnectionValidated";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyMatchmakingSessionConnectionValidated";

    public Blaze15SDK.Blaze.GameManager.ConnectionValidationResults? ConnectionValidatedResults
    {
        get => _connectionValidatedResults.Value;
        set => _connectionValidatedResults.Value = value;
    }

    public bool DispatchSessionFinished
    {
        get => _dispatchSessionFinished.Value;
        set => _dispatchSessionFinished.Value = value;
    }

    public ulong GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public ObjectId UserGroupId
    {
        get => _userGroupId.Value;
        set => _userGroupId.Value = value;
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

    public bool QosValidationPerformed
    {
        get => _qosValidationPerformed.Value;
        set => _qosValidationPerformed.Value = value;
    }

    public ulong UserSessionId
    {
        get => _userSessionId.Value;
        set => _userSessionId.Value = value;
    }

}
