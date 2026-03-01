using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class NotifyMatchmakingScenarioPseudoSuccess : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ScenarioId", "mScenarioId", 0x3530C900, TdfType.UInt64, 0, true), // msci
        new TdfMemberInfo("PseudoSuccessList", "mPseudoSuccessList", 0x4134CC00, TdfType.List, 1, true), // pssl
        new TdfMemberInfo("ScenarioVersion", "mScenarioVersion", 0x4C315600, TdfType.UInt32, 2, true), // scev
        new TdfMemberInfo("ScenarioName", "mScenarioName", 0x4C338D00, TdfType.String, 3, true), // scnm
        new TdfMemberInfo("ScenarioVariant", "mScenarioVariant", 0x4C358100, TdfType.String, 4, true), // scva
        new TdfMemberInfo("ScenarioTimeoutDuration", "mScenarioTimeoutDuration", 0x50F55400, TdfType.Int64, 5, true), // tout
        new TdfMemberInfo("UserSessionId", "mUserSessionId", 0x55324400, TdfType.UInt64, 6, true), // usid
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _scenarioId = new(__typeInfos[0]);
    private TdfList<Blaze15SDK.Blaze.GameManager.NotifyMatchmakingPseudoSuccess> _pseudoSuccessList = new(__typeInfos[1]);
    private TdfUInt32 _scenarioVersion = new(__typeInfos[2]);
    private TdfString _scenarioName = new(__typeInfos[3]);
    private TdfString _scenarioVariant = new(__typeInfos[4]);
    private TdfInt64 _scenarioTimeoutDuration = new(__typeInfos[5]);
    private TdfUInt64 _userSessionId = new(__typeInfos[6]);

    public NotifyMatchmakingScenarioPseudoSuccess()
    {
        __members = [ _scenarioId, _pseudoSuccessList, _scenarioVersion, _scenarioName, _scenarioVariant, _scenarioTimeoutDuration, _userSessionId ];
    }

    public override Tdf CreateNew() => new NotifyMatchmakingScenarioPseudoSuccess();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyMatchmakingScenarioPseudoSuccess";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyMatchmakingScenarioPseudoSuccess";

    public ulong ScenarioId
    {
        get => _scenarioId.Value;
        set => _scenarioId.Value = value;
    }

    public IList<Blaze15SDK.Blaze.GameManager.NotifyMatchmakingPseudoSuccess> PseudoSuccessList
    {
        get => _pseudoSuccessList.Value;
        set => _pseudoSuccessList.Value = value;
    }

    public uint ScenarioVersion
    {
        get => _scenarioVersion.Value;
        set => _scenarioVersion.Value = value;
    }

    public string ScenarioName
    {
        get => _scenarioName.Value;
        set => _scenarioName.Value = value;
    }

    public string ScenarioVariant
    {
        get => _scenarioVariant.Value;
        set => _scenarioVariant.Value = value;
    }

    public long ScenarioTimeoutDuration
    {
        get => _scenarioTimeoutDuration.Value;
        set => _scenarioTimeoutDuration.Value = value;
    }

    public ulong UserSessionId
    {
        get => _userSessionId.Value;
        set => _userSessionId.Value = value;
    }

}
