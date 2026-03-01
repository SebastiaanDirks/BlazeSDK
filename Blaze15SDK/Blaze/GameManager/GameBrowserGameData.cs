using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class GameBrowserGameData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AdminPlayerList", "mAdminPlayerList", 0x04434E00, TdfType.List, 0, true), // admn
        new TdfMemberInfo("GameAttribs", "mGameAttribs", 0x05451200, TdfType.Map, 1, true), // attr
        new TdfMemberInfo("SlotCapacities", "mSlotCapacities", 0x0C140000, TdfType.List, 2, true), // cap
        new TdfMemberInfo("ClientPlatformList", "mClientPlatformList", 0x0D03D600, TdfType.List, 3, true), // cpov
        new TdfMemberInfo("EntryCriteriaMap", "mEntryCriteriaMap", 0x0D225400, TdfType.Map, 4, true), // crit
        new TdfMemberInfo("DedicatedServerAttribs", "mDedicatedServerAttribs", 0x11351200, TdfType.Map, 5, true), // dstr
        new TdfMemberInfo("GameId", "mGameId", 0x1C910000, TdfType.UInt64, 6, true), // gid
        new TdfMemberInfo("GameModRegister", "mGameModRegister", 0x1CD48700, TdfType.UInt32, 7, true), // gmrg
        new TdfMemberInfo("GameName", "mGameName", 0x1CE04D00, TdfType.String, 8, true), // gnam
        new TdfMemberInfo("GameSettings", "mGameSettings", 0x1D315400, TdfType.Enum, 9, true), // gset
        new TdfMemberInfo("GameState", "mGameState", 0x1D350100, TdfType.Enum, 10, true), // gsta
        new TdfMemberInfo("GameType", "mGameType", 0x1D465000, TdfType.Enum, 11, true), // gtyp
        new TdfMemberInfo("GameStatusUrl", "mGameStatusUrl", 0x1D548C00, TdfType.String, 12, true), // gurl
        new TdfMemberInfo("HostNetworkAddressList", "mHostNetworkAddressList", 0x20E15400, TdfType.List, 13, true), // hnet
        new TdfMemberInfo("HostId", "mHostId", 0x20F4D400, TdfType.Int64, 14, true), // host
        new TdfMemberInfo("TopologyHostSessionId", "mTopologyHostSessionId", 0x21315300, TdfType.UInt64, 15, true), // hses
        new TdfMemberInfo("GameMode", "mGameMode", 0x34F10500, TdfType.String, 16, true), // mode
        new TdfMemberInfo("NetworkTopology", "mNetworkTopology", 0x3943D000, TdfType.Enum, 17, true), // ntop
        new TdfMemberInfo("PlayerCounts", "mPlayerCounts", 0x40339400, TdfType.List, 18, true), // pcnt
        new TdfMemberInfo("PresenceDisabledList", "mPresenceDisabledList", 0x41210C00, TdfType.List, 19, true), // prdl
        new TdfMemberInfo("PresenceMode", "mPresenceMode", 0x41215300, TdfType.Enum, 20, true), // pres
        new TdfMemberInfo("PingSiteAlias", "mPingSiteAlias", 0x41305300, TdfType.String, 21, true), // psas
        new TdfMemberInfo("PersistedGameId", "mPersistedGameId", 0x41324400, TdfType.String, 22, true), // psid
        new TdfMemberInfo("QueueCapacity", "mQueueCapacity", 0x44305000, TdfType.UInt16, 23, true), // qcap
        new TdfMemberInfo("QueueCount", "mQueueCount", 0x44339400, TdfType.UInt16, 24, true), // qcnt
        new TdfMemberInfo("RoleInformation", "mRoleInformation", 0x48E18F00, TdfType.Struct, 25, true), // rnfo
        new TdfMemberInfo("GameRoster", "mGameRoster", 0x48F4D400, TdfType.List, 26, true), // rost
        new TdfMemberInfo("ExternalSessionId", "mExternalSessionId", 0x4C910000, TdfType.UInt64, 27, true), // sid
        new TdfMemberInfo("TeamCapacity", "mTeamCapacity", 0x50305000, TdfType.UInt16, 28, true), // tcap
        new TdfMemberInfo("GameBrowserTeamInfoVector", "mGameBrowserTeamInfoVector", 0x50938600, TdfType.List, 29, true), // tinf
        new TdfMemberInfo("VoipTopology", "mVoipTopology", 0x58F25000, TdfType.Enum, 30, true), // voip
        new TdfMemberInfo("GameProtocolVersionString", "mGameProtocolVersionString", 0x59351200, TdfType.String, 31, true), // vstr
    ];
    private ITdfMember[] __members;

    private TdfList<long> _adminPlayerList = new(__typeInfos[0]);
    private TdfMap<string, string> _gameAttribs = new(__typeInfos[1]);
    private TdfList<ushort> _slotCapacities = new(__typeInfos[2]);
    private TdfList<Blaze15SDK.Blaze.ClientPlatformType> _clientPlatformList = new(__typeInfos[3]);
    private TdfMap<string, string> _entryCriteriaMap = new(__typeInfos[4]);
    private TdfMap<string, string> _dedicatedServerAttribs = new(__typeInfos[5]);
    private TdfUInt64 _gameId = new(__typeInfos[6]);
    private TdfUInt32 _gameModRegister = new(__typeInfos[7]);
    private TdfString _gameName = new(__typeInfos[8]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.GameSettings> _gameSettings = new(__typeInfos[9]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.GameState> _gameState = new(__typeInfos[10]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.GameType> _gameType = new(__typeInfos[11]);
    private TdfString _gameStatusUrl = new(__typeInfos[12]);
    private TdfList<Blaze15SDK.Blaze.NetworkAddress> _hostNetworkAddressList = new(__typeInfos[13]);
    private TdfInt64 _hostId = new(__typeInfos[14]);
    private TdfUInt64 _topologyHostSessionId = new(__typeInfos[15]);
    private TdfString _gameMode = new(__typeInfos[16]);
    private TdfEnum<Blaze15SDK.Blaze.GameNetworkTopology> _networkTopology = new(__typeInfos[17]);
    private TdfList<ushort> _playerCounts = new(__typeInfos[18]);
    private TdfList<Blaze15SDK.Blaze.ClientPlatformType> _presenceDisabledList = new(__typeInfos[19]);
    private TdfEnum<Blaze15SDK.Blaze.PresenceMode> _presenceMode = new(__typeInfos[20]);
    private TdfString _pingSiteAlias = new(__typeInfos[21]);
    private TdfString _persistedGameId = new(__typeInfos[22]);
    private TdfUInt16 _queueCapacity = new(__typeInfos[23]);
    private TdfUInt16 _queueCount = new(__typeInfos[24]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.RoleInformation?> _roleInformation = new(__typeInfos[25]);
    private TdfList<Blaze15SDK.Blaze.GameManager.GameBrowserPlayerData> _gameRoster = new(__typeInfos[26]);
    private TdfUInt64 _externalSessionId = new(__typeInfos[27]);
    private TdfUInt16 _teamCapacity = new(__typeInfos[28]);
    private TdfList<Blaze15SDK.Blaze.GameManager.GameBrowserTeamInfo> _gameBrowserTeamInfoVector = new(__typeInfos[29]);
    private TdfEnum<Blaze15SDK.Blaze.VoipTopology> _voipTopology = new(__typeInfos[30]);
    private TdfString _gameProtocolVersionString = new(__typeInfos[31]);

    public GameBrowserGameData()
    {
        __members = [ _adminPlayerList, _gameAttribs, _slotCapacities, _clientPlatformList, _entryCriteriaMap, _dedicatedServerAttribs, _gameId, _gameModRegister, _gameName, _gameSettings, _gameState, _gameType, _gameStatusUrl, _hostNetworkAddressList, _hostId, _topologyHostSessionId, _gameMode, _networkTopology, _playerCounts, _presenceDisabledList, _presenceMode, _pingSiteAlias, _persistedGameId, _queueCapacity, _queueCount, _roleInformation, _gameRoster, _externalSessionId, _teamCapacity, _gameBrowserTeamInfoVector, _voipTopology, _gameProtocolVersionString ];
    }

    public override Tdf CreateNew() => new GameBrowserGameData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameBrowserGameData";
    public override string GetFullClassName() => "Blaze::GameManager::GameBrowserGameData";

    public IList<long> AdminPlayerList
    {
        get => _adminPlayerList.Value;
        set => _adminPlayerList.Value = value;
    }

    public IDictionary<string, string> GameAttribs
    {
        get => _gameAttribs.Value;
        set => _gameAttribs.Value = value;
    }

    public IList<ushort> SlotCapacities
    {
        get => _slotCapacities.Value;
        set => _slotCapacities.Value = value;
    }

    public IList<Blaze15SDK.Blaze.ClientPlatformType> ClientPlatformList
    {
        get => _clientPlatformList.Value;
        set => _clientPlatformList.Value = value;
    }

    public IDictionary<string, string> EntryCriteriaMap
    {
        get => _entryCriteriaMap.Value;
        set => _entryCriteriaMap.Value = value;
    }

    public IDictionary<string, string> DedicatedServerAttribs
    {
        get => _dedicatedServerAttribs.Value;
        set => _dedicatedServerAttribs.Value = value;
    }

    public ulong GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public uint GameModRegister
    {
        get => _gameModRegister.Value;
        set => _gameModRegister.Value = value;
    }

    public string GameName
    {
        get => _gameName.Value;
        set => _gameName.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.GameSettings GameSettings
    {
        get => _gameSettings.Value;
        set => _gameSettings.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.GameState GameState
    {
        get => _gameState.Value;
        set => _gameState.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.GameType GameType
    {
        get => _gameType.Value;
        set => _gameType.Value = value;
    }

    public string GameStatusUrl
    {
        get => _gameStatusUrl.Value;
        set => _gameStatusUrl.Value = value;
    }

    public IList<Blaze15SDK.Blaze.NetworkAddress> HostNetworkAddressList
    {
        get => _hostNetworkAddressList.Value;
        set => _hostNetworkAddressList.Value = value;
    }

    public long HostId
    {
        get => _hostId.Value;
        set => _hostId.Value = value;
    }

    public ulong TopologyHostSessionId
    {
        get => _topologyHostSessionId.Value;
        set => _topologyHostSessionId.Value = value;
    }

    public string GameMode
    {
        get => _gameMode.Value;
        set => _gameMode.Value = value;
    }

    public Blaze15SDK.Blaze.GameNetworkTopology NetworkTopology
    {
        get => _networkTopology.Value;
        set => _networkTopology.Value = value;
    }

    public IList<ushort> PlayerCounts
    {
        get => _playerCounts.Value;
        set => _playerCounts.Value = value;
    }

    public IList<Blaze15SDK.Blaze.ClientPlatformType> PresenceDisabledList
    {
        get => _presenceDisabledList.Value;
        set => _presenceDisabledList.Value = value;
    }

    public Blaze15SDK.Blaze.PresenceMode PresenceMode
    {
        get => _presenceMode.Value;
        set => _presenceMode.Value = value;
    }

    public string PingSiteAlias
    {
        get => _pingSiteAlias.Value;
        set => _pingSiteAlias.Value = value;
    }

    public string PersistedGameId
    {
        get => _persistedGameId.Value;
        set => _persistedGameId.Value = value;
    }

    public ushort QueueCapacity
    {
        get => _queueCapacity.Value;
        set => _queueCapacity.Value = value;
    }

    public ushort QueueCount
    {
        get => _queueCount.Value;
        set => _queueCount.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.RoleInformation? RoleInformation
    {
        get => _roleInformation.Value;
        set => _roleInformation.Value = value;
    }

    public IList<Blaze15SDK.Blaze.GameManager.GameBrowserPlayerData> GameRoster
    {
        get => _gameRoster.Value;
        set => _gameRoster.Value = value;
    }

    public ulong ExternalSessionId
    {
        get => _externalSessionId.Value;
        set => _externalSessionId.Value = value;
    }

    public ushort TeamCapacity
    {
        get => _teamCapacity.Value;
        set => _teamCapacity.Value = value;
    }

    public IList<Blaze15SDK.Blaze.GameManager.GameBrowserTeamInfo> GameBrowserTeamInfoVector
    {
        get => _gameBrowserTeamInfoVector.Value;
        set => _gameBrowserTeamInfoVector.Value = value;
    }

    public Blaze15SDK.Blaze.VoipTopology VoipTopology
    {
        get => _voipTopology.Value;
        set => _voipTopology.Value = value;
    }

    public string GameProtocolVersionString
    {
        get => _gameProtocolVersionString.Value;
        set => _gameProtocolVersionString.Value = value;
    }

}
