using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class ReplicatedGameData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AdminPlayerList", "mAdminPlayerList", 0x04434E00, TdfType.List, 0, true), // admn
        new TdfMemberInfo("OwnsFirstPartyPresence", "mOwnsFirstPartyPresence", 0x05049300, TdfType.Bool, 1, true), // aprs
        new TdfMemberInfo("BaseGameClientPlatformList", "mBaseGameClientPlatformList", 0x08340C00, TdfType.List, 2, true), // bcpl
        new TdfMemberInfo("SlotCapacities", "mSlotCapacities", 0x0C140000, TdfType.List, 3, true), // cap
        new TdfMemberInfo("CCSMode", "mCCSMode", 0x0C334400, TdfType.Enum, 4, true), // ccmd
        new TdfMemberInfo("ExternalSessionCorrelationId", "mExternalSessionCorrelationId", 0x0CF24400, TdfType.String, 5, true), // coid
        new TdfMemberInfo("ClientPlatformList", "mClientPlatformList", 0x0D03D600, TdfType.List, 6, true), // cpov
        new TdfMemberInfo("EntryCriteriaMap", "mEntryCriteriaMap", 0x0D225400, TdfType.Map, 7, true), // crit
        new TdfMemberInfo("ConnectionSetId", "mConnectionSetId", 0x0D324400, TdfType.String, 8, true), // csid
        new TdfMemberInfo("CreateTime", "mCreateTime", 0x0D424D00, TdfType.Int64, 9, true), // ctim
        new TdfMemberInfo("DedicatedServerHostInfo", "mDedicatedServerHostInfo", 0x1084D400, TdfType.Struct, 10, true), // dhst
        new TdfMemberInfo("DedicatedServerHostNetworkAddressList", "mDedicatedServerHostNetworkAddressList", 0x10E15400, TdfType.List, 11, true), // dnet
        new TdfMemberInfo("DisconnectReservationTimeout", "mDisconnectReservationTimeout", 0x11250F00, TdfType.Int64, 12, true), // drto
        new TdfMemberInfo("ExternalOwnerInfo", "mExternalOwnerInfo", 0x14F5CE00, TdfType.Struct, 13, true), // eown
        new TdfMemberInfo("ExternalSessionIdentification", "mExternalSessionIdentification", 0x15324400, TdfType.Struct, 14, true), // esid
        new TdfMemberInfo("ExternalSessionName", "mExternalSessionName", 0x15338D00, TdfType.String, 15, true), // esnm
        new TdfMemberInfo("GameEventAddress", "mGameEventAddress", 0x1C504400, TdfType.String, 16, true), // gead
        new TdfMemberInfo("GameEndEventUri", "mGameEndEventUri", 0x1C515500, TdfType.String, 17, true), // geeu
        new TdfMemberInfo("GameType", "mGameType", 0x1C751900, TdfType.Enum, 18, true), // ggty
        new TdfMemberInfo("GameId", "mGameId", 0x1C910000, TdfType.UInt64, 19, true), // gid
        new TdfMemberInfo("GameModRegister", "mGameModRegister", 0x1CD48700, TdfType.UInt32, 20, true), // gmrg
        new TdfMemberInfo("GameName", "mGameName", 0x1CE04D00, TdfType.String, 21, true), // gnam
        new TdfMemberInfo("GameProtocolVersionHash", "mGameProtocolVersionHash", 0x1D058800, TdfType.UInt64, 22, true), // gpvh
        new TdfMemberInfo("GameSettings", "mGameSettings", 0x1D315400, TdfType.Enum, 23, true), // gset
        new TdfMemberInfo("GameStartEventUri", "mGameStartEventUri", 0x1D315500, TdfType.String, 24, true), // gseu
        new TdfMemberInfo("GameReportingId", "mGameReportingId", 0x1D324400, TdfType.UInt64, 25, true), // gsid
        new TdfMemberInfo("GameState", "mGameState", 0x1D350100, TdfType.Enum, 26, true), // gsta
        new TdfMemberInfo("GameReportName", "mGameReportName", 0x1D465000, TdfType.String, 27, true), // gtyp
        new TdfMemberInfo("GameStatusUrl", "mGameStatusUrl", 0x1D548C00, TdfType.String, 28, true), // gurl
        new TdfMemberInfo("TopologyHostNetworkAddressList", "mTopologyHostNetworkAddressList", 0x20E15400, TdfType.List, 29, true), // hnet
        new TdfMemberInfo("MaxPlayerCapacity", "mMaxPlayerCapacity", 0x34305000, TdfType.UInt16, 30, true), // mcap
        new TdfMemberInfo("MinPlayerCapacity", "mMinPlayerCapacity", 0x34E0D000, TdfType.UInt16, 31, true), // mncp
        new TdfMemberInfo("NpSessionId", "mNpSessionId", 0x3904C900, TdfType.String, 32, true), // npsi
        new TdfMemberInfo("ServerNotResetable", "mServerNotResetable", 0x39215300, TdfType.Bool, 33, true), // nres
        new TdfMemberInfo("NetworkTopology", "mNetworkTopology", 0x3943D000, TdfType.Enum, 34, true), // ntop
        new TdfMemberInfo("OriginalGameClientPlatformList", "mOriginalGameClientPlatformList", 0x3C340C00, TdfType.List, 35, true), // ocpl
        new TdfMemberInfo("PersistedGameId", "mPersistedGameId", 0x40724400, TdfType.String, 36, true), // pgid
        new TdfMemberInfo("PersistedGameIdSecret", "mPersistedGameIdSecret", 0x4074D200, TdfType.String, 37, true), // pgsr
        new TdfMemberInfo("PlatformHostInfo", "mPlatformHostInfo", 0x4084D400, TdfType.Struct, 38, true), // phst
        new TdfMemberInfo("CCSPool", "mCCSPool", 0x40F3CC00, TdfType.String, 39, true), // pool
        new TdfMemberInfo("PresenceDisabledList", "mPresenceDisabledList", 0x41210C00, TdfType.List, 40, true), // prdl
        new TdfMemberInfo("PresenceMode", "mPresenceMode", 0x41215300, TdfType.Enum, 41, true), // pres
        new TdfMemberInfo("PlayerReservationTimeout", "mPlayerReservationTimeout", 0x41250F00, TdfType.Int64, 42, true), // prto
        new TdfMemberInfo("PingSiteAlias", "mPingSiteAlias", 0x41305300, TdfType.String, 43, true), // psas
        new TdfMemberInfo("IsPseudoGame", "mIsPseudoGame", 0x41315500, TdfType.Bool, 44, true), // pseu
        new TdfMemberInfo("PermissionSystemName", "mPermissionSystemName", 0x41338D00, TdfType.String, 45, true), // psnm
        new TdfMemberInfo("QueueCapacity", "mQueueCapacity", 0x44305000, TdfType.UInt16, 46, true), // qcap
        new TdfMemberInfo("RoleInformation", "mRoleInformation", 0x48E18F00, TdfType.Struct, 47, true), // rnfo
        new TdfMemberInfo("Scid", "mScid", 0x4C324400, TdfType.String, 48, true), // scid
        new TdfMemberInfo("SharedSeed", "mSharedSeed", 0x4C514400, TdfType.UInt32, 49, true), // seed
        new TdfMemberInfo("ExternalSessionTemplateName", "mExternalSessionTemplateName", 0x4D434E00, TdfType.String, 50, true), // stmn
        new TdfMemberInfo("CreateGameTemplateName", "mCreateGameTemplateName", 0x50134500, TdfType.String, 51, true), // tame
        new TdfMemberInfo("TopologyHostInfo", "mTopologyHostInfo", 0x5084D400, TdfType.Struct, 52, true), // thst
        new TdfMemberInfo("TournamentIdentification", "mTournamentIdentification", 0x50910000, TdfType.Struct, 53, true), // tid
        new TdfMemberInfo("TeamIds", "mTeamIds", 0x50911300, TdfType.List, 54, true), // tids
        new TdfMemberInfo("UUID", "mUUID", 0x55524400, TdfType.String, 55, true), // uuid
        new TdfMemberInfo("VoipNetwork", "mVoipNetwork", 0x58F25000, TdfType.Enum, 56, true), // voip
        new TdfMemberInfo("GameProtocolVersionString", "mGameProtocolVersionString", 0x59351200, TdfType.String, 57, true), // vstr
    ];
    private ITdfMember[] __members;

    private TdfList<long> _adminPlayerList = new(__typeInfos[0]);
    private TdfBool _ownsFirstPartyPresence = new(__typeInfos[1]);
    private TdfList<Blaze15SDK.Blaze.ClientPlatformType> _baseGameClientPlatformList = new(__typeInfos[2]);
    private TdfList<ushort> _slotCapacities = new(__typeInfos[3]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.CCSMode> _cCSMode = new(__typeInfos[4]);
    private TdfString _externalSessionCorrelationId = new(__typeInfos[5]);
    private TdfList<Blaze15SDK.Blaze.ClientPlatformType> _clientPlatformList = new(__typeInfos[6]);
    private TdfMap<string, string> _entryCriteriaMap = new(__typeInfos[7]);
    private TdfString _connectionSetId = new(__typeInfos[8]);
    private TdfInt64 _createTime = new(__typeInfos[9]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.HostInfo?> _dedicatedServerHostInfo = new(__typeInfos[10]);
    private TdfList<Blaze15SDK.Blaze.NetworkAddress> _dedicatedServerHostNetworkAddressList = new(__typeInfos[11]);
    private TdfInt64 _disconnectReservationTimeout = new(__typeInfos[12]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.HostInfo?> _externalOwnerInfo = new(__typeInfos[13]);
    private TdfStruct<Blaze15SDK.Blaze.ExternalSessionIdentification?> _externalSessionIdentification = new(__typeInfos[14]);
    private TdfString _externalSessionName = new(__typeInfos[15]);
    private TdfString _gameEventAddress = new(__typeInfos[16]);
    private TdfString _gameEndEventUri = new(__typeInfos[17]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.GameType> _gameType = new(__typeInfos[18]);
    private TdfUInt64 _gameId = new(__typeInfos[19]);
    private TdfUInt32 _gameModRegister = new(__typeInfos[20]);
    private TdfString _gameName = new(__typeInfos[21]);
    private TdfUInt64 _gameProtocolVersionHash = new(__typeInfos[22]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.GameSettings> _gameSettings = new(__typeInfos[23]);
    private TdfString _gameStartEventUri = new(__typeInfos[24]);
    private TdfUInt64 _gameReportingId = new(__typeInfos[25]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.GameState> _gameState = new(__typeInfos[26]);
    private TdfString _gameReportName = new(__typeInfos[27]);
    private TdfString _gameStatusUrl = new(__typeInfos[28]);
    private TdfList<Blaze15SDK.Blaze.NetworkAddress> _topologyHostNetworkAddressList = new(__typeInfos[29]);
    private TdfUInt16 _maxPlayerCapacity = new(__typeInfos[30]);
    private TdfUInt16 _minPlayerCapacity = new(__typeInfos[31]);
    private TdfString _npSessionId = new(__typeInfos[32]);
    private TdfBool _serverNotResetable = new(__typeInfos[33]);
    private TdfEnum<Blaze15SDK.Blaze.GameNetworkTopology> _networkTopology = new(__typeInfos[34]);
    private TdfList<Blaze15SDK.Blaze.ClientPlatformType> _originalGameClientPlatformList = new(__typeInfos[35]);
    private TdfString _persistedGameId = new(__typeInfos[36]);
    private TdfString _persistedGameIdSecret = new(__typeInfos[37]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.HostInfo?> _platformHostInfo = new(__typeInfos[38]);
    private TdfString _cCSPool = new(__typeInfos[39]);
    private TdfList<Blaze15SDK.Blaze.ClientPlatformType> _presenceDisabledList = new(__typeInfos[40]);
    private TdfEnum<Blaze15SDK.Blaze.PresenceMode> _presenceMode = new(__typeInfos[41]);
    private TdfInt64 _playerReservationTimeout = new(__typeInfos[42]);
    private TdfString _pingSiteAlias = new(__typeInfos[43]);
    private TdfBool _isPseudoGame = new(__typeInfos[44]);
    private TdfString _permissionSystemName = new(__typeInfos[45]);
    private TdfUInt16 _queueCapacity = new(__typeInfos[46]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.RoleInformation?> _roleInformation = new(__typeInfos[47]);
    private TdfString _scid = new(__typeInfos[48]);
    private TdfUInt32 _sharedSeed = new(__typeInfos[49]);
    private TdfString _externalSessionTemplateName = new(__typeInfos[50]);
    private TdfString _createGameTemplateName = new(__typeInfos[51]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.HostInfo?> _topologyHostInfo = new(__typeInfos[52]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.TournamentIdentification?> _tournamentIdentification = new(__typeInfos[53]);
    private TdfList<ushort> _teamIds = new(__typeInfos[54]);
    private TdfString _uUID = new(__typeInfos[55]);
    private TdfEnum<Blaze15SDK.Blaze.VoipTopology> _voipNetwork = new(__typeInfos[56]);
    private TdfString _gameProtocolVersionString = new(__typeInfos[57]);

    public ReplicatedGameData()
    {
        __members = [ _adminPlayerList, _ownsFirstPartyPresence, _baseGameClientPlatformList, _slotCapacities, _cCSMode, _externalSessionCorrelationId, _clientPlatformList, _entryCriteriaMap, _connectionSetId, _createTime, _dedicatedServerHostInfo, _dedicatedServerHostNetworkAddressList, _disconnectReservationTimeout, _externalOwnerInfo, _externalSessionIdentification, _externalSessionName, _gameEventAddress, _gameEndEventUri, _gameType, _gameId, _gameModRegister, _gameName, _gameProtocolVersionHash, _gameSettings, _gameStartEventUri, _gameReportingId, _gameState, _gameReportName, _gameStatusUrl, _topologyHostNetworkAddressList, _maxPlayerCapacity, _minPlayerCapacity, _npSessionId, _serverNotResetable, _networkTopology, _originalGameClientPlatformList, _persistedGameId, _persistedGameIdSecret, _platformHostInfo, _cCSPool, _presenceDisabledList, _presenceMode, _playerReservationTimeout, _pingSiteAlias, _isPseudoGame, _permissionSystemName, _queueCapacity, _roleInformation, _scid, _sharedSeed, _externalSessionTemplateName, _createGameTemplateName, _topologyHostInfo, _tournamentIdentification, _teamIds, _uUID, _voipNetwork, _gameProtocolVersionString ];
    }

    public override Tdf CreateNew() => new ReplicatedGameData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ReplicatedGameData";
    public override string GetFullClassName() => "Blaze::GameManager::ReplicatedGameData";

    public IList<long> AdminPlayerList
    {
        get => _adminPlayerList.Value;
        set => _adminPlayerList.Value = value;
    }

    public bool OwnsFirstPartyPresence
    {
        get => _ownsFirstPartyPresence.Value;
        set => _ownsFirstPartyPresence.Value = value;
    }

    public IList<Blaze15SDK.Blaze.ClientPlatformType> BaseGameClientPlatformList
    {
        get => _baseGameClientPlatformList.Value;
        set => _baseGameClientPlatformList.Value = value;
    }

    public IList<ushort> SlotCapacities
    {
        get => _slotCapacities.Value;
        set => _slotCapacities.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.CCSMode CCSMode
    {
        get => _cCSMode.Value;
        set => _cCSMode.Value = value;
    }

    public string ExternalSessionCorrelationId
    {
        get => _externalSessionCorrelationId.Value;
        set => _externalSessionCorrelationId.Value = value;
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

    public string ConnectionSetId
    {
        get => _connectionSetId.Value;
        set => _connectionSetId.Value = value;
    }

    public long CreateTime
    {
        get => _createTime.Value;
        set => _createTime.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.HostInfo? DedicatedServerHostInfo
    {
        get => _dedicatedServerHostInfo.Value;
        set => _dedicatedServerHostInfo.Value = value;
    }

    public IList<Blaze15SDK.Blaze.NetworkAddress> DedicatedServerHostNetworkAddressList
    {
        get => _dedicatedServerHostNetworkAddressList.Value;
        set => _dedicatedServerHostNetworkAddressList.Value = value;
    }

    public long DisconnectReservationTimeout
    {
        get => _disconnectReservationTimeout.Value;
        set => _disconnectReservationTimeout.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.HostInfo? ExternalOwnerInfo
    {
        get => _externalOwnerInfo.Value;
        set => _externalOwnerInfo.Value = value;
    }

    public Blaze15SDK.Blaze.ExternalSessionIdentification? ExternalSessionIdentification
    {
        get => _externalSessionIdentification.Value;
        set => _externalSessionIdentification.Value = value;
    }

    public string ExternalSessionName
    {
        get => _externalSessionName.Value;
        set => _externalSessionName.Value = value;
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

    public Blaze15SDK.Blaze.GameManager.GameType GameType
    {
        get => _gameType.Value;
        set => _gameType.Value = value;
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

    public ulong GameProtocolVersionHash
    {
        get => _gameProtocolVersionHash.Value;
        set => _gameProtocolVersionHash.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.GameSettings GameSettings
    {
        get => _gameSettings.Value;
        set => _gameSettings.Value = value;
    }

    public string GameStartEventUri
    {
        get => _gameStartEventUri.Value;
        set => _gameStartEventUri.Value = value;
    }

    public ulong GameReportingId
    {
        get => _gameReportingId.Value;
        set => _gameReportingId.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.GameState GameState
    {
        get => _gameState.Value;
        set => _gameState.Value = value;
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

    public IList<Blaze15SDK.Blaze.NetworkAddress> TopologyHostNetworkAddressList
    {
        get => _topologyHostNetworkAddressList.Value;
        set => _topologyHostNetworkAddressList.Value = value;
    }

    public ushort MaxPlayerCapacity
    {
        get => _maxPlayerCapacity.Value;
        set => _maxPlayerCapacity.Value = value;
    }

    public ushort MinPlayerCapacity
    {
        get => _minPlayerCapacity.Value;
        set => _minPlayerCapacity.Value = value;
    }

    public string NpSessionId
    {
        get => _npSessionId.Value;
        set => _npSessionId.Value = value;
    }

    public bool ServerNotResetable
    {
        get => _serverNotResetable.Value;
        set => _serverNotResetable.Value = value;
    }

    public Blaze15SDK.Blaze.GameNetworkTopology NetworkTopology
    {
        get => _networkTopology.Value;
        set => _networkTopology.Value = value;
    }

    public IList<Blaze15SDK.Blaze.ClientPlatformType> OriginalGameClientPlatformList
    {
        get => _originalGameClientPlatformList.Value;
        set => _originalGameClientPlatformList.Value = value;
    }

    public string PersistedGameId
    {
        get => _persistedGameId.Value;
        set => _persistedGameId.Value = value;
    }

    public string PersistedGameIdSecret
    {
        get => _persistedGameIdSecret.Value;
        set => _persistedGameIdSecret.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.HostInfo? PlatformHostInfo
    {
        get => _platformHostInfo.Value;
        set => _platformHostInfo.Value = value;
    }

    public string CCSPool
    {
        get => _cCSPool.Value;
        set => _cCSPool.Value = value;
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

    public long PlayerReservationTimeout
    {
        get => _playerReservationTimeout.Value;
        set => _playerReservationTimeout.Value = value;
    }

    public string PingSiteAlias
    {
        get => _pingSiteAlias.Value;
        set => _pingSiteAlias.Value = value;
    }

    public bool IsPseudoGame
    {
        get => _isPseudoGame.Value;
        set => _isPseudoGame.Value = value;
    }

    public string PermissionSystemName
    {
        get => _permissionSystemName.Value;
        set => _permissionSystemName.Value = value;
    }

    public ushort QueueCapacity
    {
        get => _queueCapacity.Value;
        set => _queueCapacity.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.RoleInformation? RoleInformation
    {
        get => _roleInformation.Value;
        set => _roleInformation.Value = value;
    }

    public string Scid
    {
        get => _scid.Value;
        set => _scid.Value = value;
    }

    public uint SharedSeed
    {
        get => _sharedSeed.Value;
        set => _sharedSeed.Value = value;
    }

    public string ExternalSessionTemplateName
    {
        get => _externalSessionTemplateName.Value;
        set => _externalSessionTemplateName.Value = value;
    }

    public string CreateGameTemplateName
    {
        get => _createGameTemplateName.Value;
        set => _createGameTemplateName.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.HostInfo? TopologyHostInfo
    {
        get => _topologyHostInfo.Value;
        set => _topologyHostInfo.Value = value;
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

    public string UUID
    {
        get => _uUID.Value;
        set => _uUID.Value = value;
    }

    public Blaze15SDK.Blaze.VoipTopology VoipNetwork
    {
        get => _voipNetwork.Value;
        set => _voipNetwork.Value = value;
    }

    public string GameProtocolVersionString
    {
        get => _gameProtocolVersionString.Value;
        set => _gameProtocolVersionString.Value = value;
    }

}
