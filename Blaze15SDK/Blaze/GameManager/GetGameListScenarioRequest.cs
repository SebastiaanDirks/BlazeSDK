using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class GetGameListScenarioRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CommonGameData", "mCommonGameData", 0x0CD1C400, TdfType.Struct, 0, true), // cmgd
        new TdfMemberInfo("GameBrowserScenarioAttributes", "mGameBrowserScenarioAttributes", 0x1C24C100, TdfType.Map, 1, true), // gbsa
        new TdfMemberInfo("GameBrowserScenarioName", "mGameBrowserScenarioName", 0x1CE4CE00, TdfType.String, 2, true), // gnsn
        new TdfMemberInfo("PlayerJoinData", "mPlayerJoinData", 0x40C28400, TdfType.Struct, 3, true), // pljd
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.GameManager.CommonGameRequestData?> _commonGameData = new(__typeInfos[0]);
    private TdfMap<string, object> _gameBrowserScenarioAttributes = new(__typeInfos[1]);
    private TdfString _gameBrowserScenarioName = new(__typeInfos[2]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.PlayerJoinData?> _playerJoinData = new(__typeInfos[3]);

    public GetGameListScenarioRequest()
    {
        __members = [ _commonGameData, _gameBrowserScenarioAttributes, _gameBrowserScenarioName, _playerJoinData ];
    }

    public override Tdf CreateNew() => new GetGameListScenarioRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetGameListScenarioRequest";
    public override string GetFullClassName() => "Blaze::GameManager::GetGameListScenarioRequest";

    public Blaze15SDK.Blaze.GameManager.CommonGameRequestData? CommonGameData
    {
        get => _commonGameData.Value;
        set => _commonGameData.Value = value;
    }

    public IDictionary<string, object> GameBrowserScenarioAttributes
    {
        get => _gameBrowserScenarioAttributes.Value;
        set => _gameBrowserScenarioAttributes.Value = value;
    }

    public string GameBrowserScenarioName
    {
        get => _gameBrowserScenarioName.Value;
        set => _gameBrowserScenarioName.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.PlayerJoinData? PlayerJoinData
    {
        get => _playerJoinData.Value;
        set => _playerJoinData.Value = value;
    }

}
