using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class GetGameListRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CommonGameData", "mCommonGameData", 0x0CD1C400, TdfType.Struct, 0, true), // cmgd
        new TdfMemberInfo("ListConfigName", "mListConfigName", 0x10E04D00, TdfType.String, 1, true), // dnam
        new TdfMemberInfo("IgnoreGameEntryCriteria", "mIgnoreGameEntryCriteria", 0x24738F00, TdfType.Bool, 2, true), // igno
        new TdfMemberInfo("ListCapacity", "mListCapacity", 0x30305000, TdfType.UInt32, 3, true), // lcap
        new TdfMemberInfo("ListCriteria", "mListCriteria", 0x34D30300, TdfType.Struct, 4, true), // mmlc
        new TdfMemberInfo("PlayerJoinData", "mPlayerJoinData", 0x40C28400, TdfType.Struct, 5, true), // pljd
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.GameManager.CommonGameRequestData?> _commonGameData = new(__typeInfos[0]);
    private TdfString _listConfigName = new(__typeInfos[1]);
    private TdfBool _ignoreGameEntryCriteria = new(__typeInfos[2]);
    private TdfUInt32 _listCapacity = new(__typeInfos[3]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.MatchmakingCriteriaData?> _listCriteria = new(__typeInfos[4]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.PlayerJoinData?> _playerJoinData = new(__typeInfos[5]);

    public GetGameListRequest()
    {
        __members = [ _commonGameData, _listConfigName, _ignoreGameEntryCriteria, _listCapacity, _listCriteria, _playerJoinData ];
    }

    public override Tdf CreateNew() => new GetGameListRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetGameListRequest";
    public override string GetFullClassName() => "Blaze::GameManager::GetGameListRequest";

    public Blaze15SDK.Blaze.GameManager.CommonGameRequestData? CommonGameData
    {
        get => _commonGameData.Value;
        set => _commonGameData.Value = value;
    }

    public string ListConfigName
    {
        get => _listConfigName.Value;
        set => _listConfigName.Value = value;
    }

    public bool IgnoreGameEntryCriteria
    {
        get => _ignoreGameEntryCriteria.Value;
        set => _ignoreGameEntryCriteria.Value = value;
    }

    public uint ListCapacity
    {
        get => _listCapacity.Value;
        set => _listCapacity.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.MatchmakingCriteriaData? ListCriteria
    {
        get => _listCriteria.Value;
        set => _listCriteria.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.PlayerJoinData? PlayerJoinData
    {
        get => _playerJoinData.Value;
        set => _playerJoinData.Value = value;
    }

}
