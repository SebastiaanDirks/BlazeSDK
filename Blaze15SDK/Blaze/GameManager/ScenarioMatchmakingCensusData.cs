using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class ScenarioMatchmakingCensusData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GlobalPlayerMatchmakingRate", "mGlobalPlayerMatchmakingRate", 0x1D035200, TdfType.Float, 0, true), // gpmr
        new TdfMemberInfo("GlobalEstimatedTimeToMatch", "mGlobalEstimatedTimeToMatch", 0x1D450D00, TdfType.Int64, 1, true), // gttm
        new TdfMemberInfo("MatchmakingSessionPerPingSite", "mMatchmakingSessionPerPingSite", 0x35341000, TdfType.Map, 2, true), // mspp
        new TdfMemberInfo("NumOfMatchmakingSession", "mNumOfMatchmakingSession", 0x39535300, TdfType.UInt32, 3, true), // nums
        new TdfMemberInfo("PlayerMatchmakingRatePerPingsiteGroup", "mPlayerMatchmakingRatePerPingsiteGroup", 0x40D48700, TdfType.Map, 4, true), // pmrg
        new TdfMemberInfo("EstimatedTimeToMatchPerPingsiteGroup", "mEstimatedTimeToMatchPerPingsiteGroup", 0x41450700, TdfType.Map, 5, true), // pttg
        new TdfMemberInfo("ScenarioName", "mScenarioName", 0x4CE04D00, TdfType.String, 6, true), // snam
    ];
    private ITdfMember[] __members;

    private TdfFloat _globalPlayerMatchmakingRate = new(__typeInfos[0]);
    private TdfInt64 _globalEstimatedTimeToMatch = new(__typeInfos[1]);
    private TdfMap<string, uint> _matchmakingSessionPerPingSite = new(__typeInfos[2]);
    private TdfUInt32 _numOfMatchmakingSession = new(__typeInfos[3]);
    private TdfMap<string, IDictionary<string, float>> _playerMatchmakingRatePerPingsiteGroup = new(__typeInfos[4]);
    private TdfMap<string, IDictionary<string, long>> _estimatedTimeToMatchPerPingsiteGroup = new(__typeInfos[5]);
    private TdfString _scenarioName = new(__typeInfos[6]);

    public ScenarioMatchmakingCensusData()
    {
        __members = [ _globalPlayerMatchmakingRate, _globalEstimatedTimeToMatch, _matchmakingSessionPerPingSite, _numOfMatchmakingSession, _playerMatchmakingRatePerPingsiteGroup, _estimatedTimeToMatchPerPingsiteGroup, _scenarioName ];
    }

    public override Tdf CreateNew() => new ScenarioMatchmakingCensusData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ScenarioMatchmakingCensusData";
    public override string GetFullClassName() => "Blaze::GameManager::ScenarioMatchmakingCensusData";

    public float GlobalPlayerMatchmakingRate
    {
        get => _globalPlayerMatchmakingRate.Value;
        set => _globalPlayerMatchmakingRate.Value = value;
    }

    public long GlobalEstimatedTimeToMatch
    {
        get => _globalEstimatedTimeToMatch.Value;
        set => _globalEstimatedTimeToMatch.Value = value;
    }

    public IDictionary<string, uint> MatchmakingSessionPerPingSite
    {
        get => _matchmakingSessionPerPingSite.Value;
        set => _matchmakingSessionPerPingSite.Value = value;
    }

    public uint NumOfMatchmakingSession
    {
        get => _numOfMatchmakingSession.Value;
        set => _numOfMatchmakingSession.Value = value;
    }

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

    public string ScenarioName
    {
        get => _scenarioName.Value;
        set => _scenarioName.Value = value;
    }

}
