using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class CreateGameRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AdminPlayerList", "mAdminPlayerList", 0x04434E00, TdfType.List, 0, true), // admn
        new TdfMemberInfo("CommonGameData", "mCommonGameData", 0x0CD1C400, TdfType.Struct, 1, true), // cmgd
        new TdfMemberInfo("ClientPlatformListOverride", "mClientPlatformListOverride", 0x0D03D600, TdfType.List, 2, true), // cpov
        new TdfMemberInfo("TournamentSessionData", "mTournamentSessionData", 0x15448E00, TdfType.Struct, 3, true), // etrn
        new TdfMemberInfo("GameEventAddress", "mGameEventAddress", 0x1C504400, TdfType.String, 4, true), // gead
        new TdfMemberInfo("GameEndEventUri", "mGameEndEventUri", 0x1C515500, TdfType.String, 5, true), // geeu
        new TdfMemberInfo("GameCreationData", "mGameCreationData", 0x1CD0C400, TdfType.Struct, 6, true), // gmcd
        new TdfMemberInfo("GameEventContentType", "mGameEventContentType", 0x1D314E00, TdfType.String, 7, true), // gsen
        new TdfMemberInfo("GameStartEventUri", "mGameStartEventUri", 0x1D315500, TdfType.String, 8, true), // gseu
        new TdfMemberInfo("GameReportName", "mGameReportName", 0x1D465000, TdfType.String, 9, true), // gtyp
        new TdfMemberInfo("GameStatusUrl", "mGameStatusUrl", 0x1D548C00, TdfType.String, 10, true), // gurl
        new TdfMemberInfo("ServerNotResetable", "mServerNotResetable", 0x39215300, TdfType.Bool, 11, true), // nres
        new TdfMemberInfo("SlotCapacities", "mSlotCapacities", 0x40305000, TdfType.List, 12, true), // pcap
        new TdfMemberInfo("SlotCapacitiesMap", "mSlotCapacitiesMap", 0x40340D00, TdfType.Map, 13, true), // pcpm
        new TdfMemberInfo("PersistedGameId", "mPersistedGameId", 0x40724400, TdfType.String, 14, true), // pgid
        new TdfMemberInfo("PersistedGameIdSecret", "mPersistedGameIdSecret", 0x4074C300, TdfType.Blob, 15, true), // pgsc
        new TdfMemberInfo("PlayerJoinData", "mPlayerJoinData", 0x40C28400, TdfType.Struct, 16, true), // pljd
        new TdfMemberInfo("TournamentIdentification", "mTournamentIdentification", 0x50910000, TdfType.Struct, 17, true), // tid
        new TdfMemberInfo("TeamIds", "mTeamIds", 0x50911300, TdfType.List, 18, true), // tids
    ];
    private ITdfMember[] __members;

    private TdfList<long> _adminPlayerList = new(__typeInfos[0]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.CommonGameRequestData?> _commonGameData = new(__typeInfos[1]);
    private TdfList<Blaze15SDK.Blaze.ClientPlatformType> _clientPlatformListOverride = new(__typeInfos[2]);
    private TdfStruct<Blaze15SDK.Blaze.TournamentSessionData?> _tournamentSessionData = new(__typeInfos[3]);
    private TdfString _gameEventAddress = new(__typeInfos[4]);
    private TdfString _gameEndEventUri = new(__typeInfos[5]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.GameCreationData?> _gameCreationData = new(__typeInfos[6]);
    private TdfString _gameEventContentType = new(__typeInfos[7]);
    private TdfString _gameStartEventUri = new(__typeInfos[8]);
    private TdfString _gameReportName = new(__typeInfos[9]);
    private TdfString _gameStatusUrl = new(__typeInfos[10]);
    private TdfBool _serverNotResetable = new(__typeInfos[11]);
    private TdfList<ushort> _slotCapacities = new(__typeInfos[12]);
    private TdfMap<Blaze15SDK.Blaze.GameManager.SlotType, ushort> _slotCapacitiesMap = new(__typeInfos[13]);
    private TdfString _persistedGameId = new(__typeInfos[14]);
    private TdfBlob _persistedGameIdSecret = new(__typeInfos[15]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.PlayerJoinData?> _playerJoinData = new(__typeInfos[16]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.TournamentIdentification?> _tournamentIdentification = new(__typeInfos[17]);
    private TdfList<ushort> _teamIds = new(__typeInfos[18]);

    public CreateGameRequest()
    {
        __members = [ _adminPlayerList, _commonGameData, _clientPlatformListOverride, _tournamentSessionData, _gameEventAddress, _gameEndEventUri, _gameCreationData, _gameEventContentType, _gameStartEventUri, _gameReportName, _gameStatusUrl, _serverNotResetable, _slotCapacities, _slotCapacitiesMap, _persistedGameId, _persistedGameIdSecret, _playerJoinData, _tournamentIdentification, _teamIds ];
    }

    public override Tdf CreateNew() => new CreateGameRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CreateGameRequest";
    public override string GetFullClassName() => "Blaze::GameManager::CreateGameRequest";

    public IList<long> AdminPlayerList
    {
        get => _adminPlayerList.Value;
        set => _adminPlayerList.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.CommonGameRequestData? CommonGameData
    {
        get => _commonGameData.Value;
        set => _commonGameData.Value = value;
    }

    public IList<Blaze15SDK.Blaze.ClientPlatformType> ClientPlatformListOverride
    {
        get => _clientPlatformListOverride.Value;
        set => _clientPlatformListOverride.Value = value;
    }

    public Blaze15SDK.Blaze.TournamentSessionData? TournamentSessionData
    {
        get => _tournamentSessionData.Value;
        set => _tournamentSessionData.Value = value;
    }

    public string GameEventAddress
    {
        get => _gameEventAddress.Value;
        set => _gameEventAddress.Value = value;
    }

    public string GameEndEventUri
    {
        get => _gameEndEventUri.Value;
        set => _gameEndEventUri.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.GameCreationData? GameCreationData
    {
        get => _gameCreationData.Value;
        set => _gameCreationData.Value = value;
    }

    public string GameEventContentType
    {
        get => _gameEventContentType.Value;
        set => _gameEventContentType.Value = value;
    }

    public string GameStartEventUri
    {
        get => _gameStartEventUri.Value;
        set => _gameStartEventUri.Value = value;
    }

    public string GameReportName
    {
        get => _gameReportName.Value;
        set => _gameReportName.Value = value;
    }

    public string GameStatusUrl
    {
        get => _gameStatusUrl.Value;
        set => _gameStatusUrl.Value = value;
    }

    public bool ServerNotResetable
    {
        get => _serverNotResetable.Value;
        set => _serverNotResetable.Value = value;
    }

    public IList<ushort> SlotCapacities
    {
        get => _slotCapacities.Value;
        set => _slotCapacities.Value = value;
    }

    public IDictionary<Blaze15SDK.Blaze.GameManager.SlotType, ushort> SlotCapacitiesMap
    {
        get => _slotCapacitiesMap.Value;
        set => _slotCapacitiesMap.Value = value;
    }

    public string PersistedGameId
    {
        get => _persistedGameId.Value;
        set => _persistedGameId.Value = value;
    }

    public byte[] PersistedGameIdSecret
    {
        get => _persistedGameIdSecret.Value;
        set => _persistedGameIdSecret.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.PlayerJoinData? PlayerJoinData
    {
        get => _playerJoinData.Value;
        set => _playerJoinData.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.TournamentIdentification? TournamentIdentification
    {
        get => _tournamentIdentification.Value;
        set => _tournamentIdentification.Value = value;
    }

    public IList<ushort> TeamIds
    {
        get => _teamIds.Value;
        set => _teamIds.Value = value;
    }

}
