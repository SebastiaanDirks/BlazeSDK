using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class MatchmakingCensusData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlayerMatchmakingRatePerPingsiteGroup", "mPlayerMatchmakingRatePerPingsiteGroup", 0xC2DCA700, TdfType.Map, 0, true), // Tag: PMRG
        new TdfMemberInfo("EstimatedTimeToMatchPerPingsiteGroup", "mEstimatedTimeToMatchPerPingsiteGroup", 0xC34D2700, TdfType.Map, 1, true), // Tag: PTTG
        new TdfMemberInfo("ScenarioMatchmakingData", "mScenarioMatchmakingData", 0xCE4D2100, TdfType.Map, 2, true), // Tag: SDTA
    ];
    private ITdfMember[] __members;

    private TdfMap<string, IDictionary<string, float>> _playerMatchmakingRatePerPingsiteGroup = new(__typeInfos[0]);
    private TdfMap<string, IDictionary<string, long>> _estimatedTimeToMatchPerPingsiteGroup = new(__typeInfos[1]);
    private TdfMap<string, Blaze15SDK.Blaze.GameManager.ScenarioMatchmakingCensusData> _scenarioMatchmakingData = new(__typeInfos[2]);

    public MatchmakingCensusData()
    {
        __members = [ _playerMatchmakingRatePerPingsiteGroup, _estimatedTimeToMatchPerPingsiteGroup, _scenarioMatchmakingData ];
    }

    public override Tdf CreateNew() => new MatchmakingCensusData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "MatchmakingCensusData";
    public override string GetFullClassName() => "Blaze::GameManager::MatchmakingCensusData";

    public IDictionary<string, IDictionary<string, float>> PlayerMatchmakingRatePerPingsiteGroup
    {
        get => _playerMatchmakingRatePerPingsiteGroup.Value;
        set => _playerMatchmakingRatePerPingsiteGroup.Value = value;
    }

    public IDictionary<string, IDictionary<string, long>> EstimatedTimeToMatchPerPingsiteGroup
    {
        get => _estimatedTimeToMatchPerPingsiteGroup.Value;
        set => _estimatedTimeToMatchPerPingsiteGroup.Value = value;
    }

    public IDictionary<string, Blaze15SDK.Blaze.GameManager.ScenarioMatchmakingCensusData> ScenarioMatchmakingData
    {
        get => _scenarioMatchmakingData.Value;
        set => _scenarioMatchmakingData.Value = value;
    }

}
