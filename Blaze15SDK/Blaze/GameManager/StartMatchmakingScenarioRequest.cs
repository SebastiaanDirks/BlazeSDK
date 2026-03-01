using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class StartMatchmakingScenarioRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CommonGameData", "mCommonGameData", 0x0CD1C400, TdfType.Struct, 0, true), // cmgd
        new TdfMemberInfo("PlayerJoinData", "mPlayerJoinData", 0x40C28400, TdfType.Struct, 1, true), // pljd
        new TdfMemberInfo("ScenarioAttributes", "mScenarioAttributes", 0x4C338100, TdfType.Map, 2, true), // scna
        new TdfMemberInfo("ScenarioName", "mScenarioName", 0x4C338D00, TdfType.String, 3, true), // scnm
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.GameManager.CommonGameRequestData?> _commonGameData = new(__typeInfos[0]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.PlayerJoinData?> _playerJoinData = new(__typeInfos[1]);
    private TdfMap<string, object> _scenarioAttributes = new(__typeInfos[2]);
    private TdfString _scenarioName = new(__typeInfos[3]);

    public StartMatchmakingScenarioRequest()
    {
        __members = [ _commonGameData, _playerJoinData, _scenarioAttributes, _scenarioName ];
    }

    public override Tdf CreateNew() => new StartMatchmakingScenarioRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "StartMatchmakingScenarioRequest";
    public override string GetFullClassName() => "Blaze::GameManager::StartMatchmakingScenarioRequest";

    public Blaze15SDK.Blaze.GameManager.CommonGameRequestData? CommonGameData
    {
        get => _commonGameData.Value;
        set => _commonGameData.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.PlayerJoinData? PlayerJoinData
    {
        get => _playerJoinData.Value;
        set => _playerJoinData.Value = value;
    }

    public IDictionary<string, object> ScenarioAttributes
    {
        get => _scenarioAttributes.Value;
        set => _scenarioAttributes.Value = value;
    }

    public string ScenarioName
    {
        get => _scenarioName.Value;
        set => _scenarioName.Value = value;
    }

}
