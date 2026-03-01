using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class StartMatchmakingScenarioResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ExternalSessionCorrelationId", "mExternalSessionCorrelationId", 0x0CF24400, TdfType.String, 0, true), // coid
        new TdfMemberInfo("ExternalSessionName", "mExternalSessionName", 0x15338D00, TdfType.String, 1, true), // esnm
        new TdfMemberInfo("EstimatedTimeToMatch", "mEstimatedTimeToMatch", 0x15450D00, TdfType.Int64, 2, true), // ettm
        new TdfMemberInfo("ScenarioId", "mScenarioId", 0x35324400, TdfType.UInt64, 3, true), // msid
        new TdfMemberInfo("RecoTrackingTag", "mRecoTrackingTag", 0x49404700, TdfType.String, 4, true), // rtag
        new TdfMemberInfo("Scid", "mScid", 0x4C324400, TdfType.String, 5, true), // scid
        new TdfMemberInfo("ExternalSessionTemplateName", "mExternalSessionTemplateName", 0x4D434E00, TdfType.String, 6, true), // stmn
        new TdfMemberInfo("ScenarioVariant", "mScenarioVariant", 0x58148900, TdfType.String, 7, true), // vari
    ];
    private ITdfMember[] __members;

    private TdfString _externalSessionCorrelationId = new(__typeInfos[0]);
    private TdfString _externalSessionName = new(__typeInfos[1]);
    private TdfInt64 _estimatedTimeToMatch = new(__typeInfos[2]);
    private TdfUInt64 _scenarioId = new(__typeInfos[3]);
    private TdfString _recoTrackingTag = new(__typeInfos[4]);
    private TdfString _scid = new(__typeInfos[5]);
    private TdfString _externalSessionTemplateName = new(__typeInfos[6]);
    private TdfString _scenarioVariant = new(__typeInfos[7]);

    public StartMatchmakingScenarioResponse()
    {
        __members = [ _externalSessionCorrelationId, _externalSessionName, _estimatedTimeToMatch, _scenarioId, _recoTrackingTag, _scid, _externalSessionTemplateName, _scenarioVariant ];
    }

    public override Tdf CreateNew() => new StartMatchmakingScenarioResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "StartMatchmakingScenarioResponse";
    public override string GetFullClassName() => "Blaze::GameManager::StartMatchmakingScenarioResponse";

    public string ExternalSessionCorrelationId
    {
        get => _externalSessionCorrelationId.Value;
        set => _externalSessionCorrelationId.Value = value;
    }

    public string ExternalSessionName
    {
        get => _externalSessionName.Value;
        set => _externalSessionName.Value = value;
    }

    public long EstimatedTimeToMatch
    {
        get => _estimatedTimeToMatch.Value;
        set => _estimatedTimeToMatch.Value = value;
    }

    public ulong ScenarioId
    {
        get => _scenarioId.Value;
        set => _scenarioId.Value = value;
    }

    public string RecoTrackingTag
    {
        get => _recoTrackingTag.Value;
        set => _recoTrackingTag.Value = value;
    }

    public string Scid
    {
        get => _scid.Value;
        set => _scid.Value = value;
    }

    public string ExternalSessionTemplateName
    {
        get => _externalSessionTemplateName.Value;
        set => _externalSessionTemplateName.Value = value;
    }

    public string ScenarioVariant
    {
        get => _scenarioVariant.Value;
        set => _scenarioVariant.Value = value;
    }

}
