using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class ReplicatedGamePlayer : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlatformInfo", "mPlatformInfo", 0x04911300, TdfType.Struct, 0, true), // aids
        new TdfMemberInfo("CustomData", "mCustomData", 0x08C3C200, TdfType.Blob, 1, true), // blob
        new TdfMemberInfo("AccountCountry", "mAccountCountry", 0x0CE51900, TdfType.UInt32, 2, true), // cnty
        new TdfMemberInfo("ConnectionGroupId", "mConnectionGroupId", 0x0CF38700, TdfType.UInt64, 3, true), // cong
        new TdfMemberInfo("ConnectionSlotId", "mConnectionSlotId", 0x0D324400, TdfType.UInt8, 4, true), // csid
        new TdfMemberInfo("DirtySockUserIndex", "mDirtySockUserIndex", 0x11354900, TdfType.Int32, 5, true), // dsui
        new TdfMemberInfo("EncryptedBlazeId", "mEncryptedBlazeId", 0x14E0D200, TdfType.String, 6, true), // encr
        new TdfMemberInfo("ExternalId", "mExternalId", 0x15824400, TdfType.UInt64, 7, true), // exid
        new TdfMemberInfo("GameId", "mGameId", 0x1C910000, TdfType.UInt64, 8, true), // gid
        new TdfMemberInfo("HasJoinFirstPartyGameSessionPermission", "mHasJoinFirstPartyGameSessionPermission", 0x28641300, TdfType.Bool, 9, true), // jfps
        new TdfMemberInfo("JoinedViaMatchmaking", "mJoinedViaMatchmaking", 0x29634D00, TdfType.Bool, 10, true), // jvmm
        new TdfMemberInfo("AccountLocale", "mAccountLocale", 0x30F0C000, TdfType.UInt32, 11, true), // loc
        new TdfMemberInfo("PlayerName", "mPlayerName", 0x38134500, TdfType.String, 12, true), // name
        new TdfMemberInfo("PersonaNamespace", "mPersonaNamespace", 0x3814D000, TdfType.String, 13, true), // nasp
        new TdfMemberInfo("PlayerId", "mPlayerId", 0x40910000, TdfType.Int64, 14, true), // pid
        new TdfMemberInfo("NetworkAddress", "mNetworkAddress", 0x40E15400, TdfType.Struct, 15, true), // pnet
        new TdfMemberInfo("PlayerSettings", "mPlayerSettings", 0x41315400, TdfType.Enum, 16, true), // pset
        new TdfMemberInfo("ReservationCreationTimestamp", "mReservationCreationTimestamp", 0x48348500, TdfType.Int64, 17, true), // rcre
        new TdfMemberInfo("RoleName", "mRoleName", 0x48F30500, TdfType.String, 18, true), // role
        new TdfMemberInfo("ScenarioName", "mScenarioName", 0x4C314E00, TdfType.String, 19, true), // scen
        new TdfMemberInfo("SlotId", "mSlotId", 0x4C910000, TdfType.UInt8, 20, true), // sid
        new TdfMemberInfo("SlotType", "mSlotType", 0x4CC3D400, TdfType.Enum, 21, true), // slot
        new TdfMemberInfo("PlayerState", "mPlayerState", 0x4D405400, TdfType.Enum, 22, true), // stat
        new TdfMemberInfo("TeamIndex", "mTeamIndex", 0x50911800, TdfType.UInt16, 23, true), // tidx
        new TdfMemberInfo("JoinedGameTimestamp", "mJoinedGameTimestamp", 0x50934500, TdfType.Int64, 24, true), // time
        new TdfMemberInfo("UserGroupId", "mUserGroupId", 0x54724400, TdfType.ObjectId, 25, true), // ugid
        new TdfMemberInfo("PlayerSessionId", "mPlayerSessionId", 0x54910000, TdfType.UInt64, 26, true), // uid
        new TdfMemberInfo("UUID", "mUUID", 0x55524400, TdfType.String, 27, true), // uuid
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.PlatformInfo?> _platformInfo = new(__typeInfos[0]);
    private TdfBlob _customData = new(__typeInfos[1]);
    private TdfUInt32 _accountCountry = new(__typeInfos[2]);
    private TdfUInt64 _connectionGroupId = new(__typeInfos[3]);
    private TdfUInt8 _connectionSlotId = new(__typeInfos[4]);
    private TdfInt32 _dirtySockUserIndex = new(__typeInfos[5]);
    private TdfString _encryptedBlazeId = new(__typeInfos[6]);
    private TdfUInt64 _externalId = new(__typeInfos[7]);
    private TdfUInt64 _gameId = new(__typeInfos[8]);
    private TdfBool _hasJoinFirstPartyGameSessionPermission = new(__typeInfos[9]);
    private TdfBool _joinedViaMatchmaking = new(__typeInfos[10]);
    private TdfUInt32 _accountLocale = new(__typeInfos[11]);
    private TdfString _playerName = new(__typeInfos[12]);
    private TdfString _personaNamespace = new(__typeInfos[13]);
    private TdfInt64 _playerId = new(__typeInfos[14]);
    private TdfStruct<Blaze15SDK.Blaze.NetworkAddress?> _networkAddress = new(__typeInfos[15]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.PlayerSettings> _playerSettings = new(__typeInfos[16]);
    private TdfInt64 _reservationCreationTimestamp = new(__typeInfos[17]);
    private TdfString _roleName = new(__typeInfos[18]);
    private TdfString _scenarioName = new(__typeInfos[19]);
    private TdfUInt8 _slotId = new(__typeInfos[20]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.SlotType> _slotType = new(__typeInfos[21]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.PlayerState> _playerState = new(__typeInfos[22]);
    private TdfUInt16 _teamIndex = new(__typeInfos[23]);
    private TdfInt64 _joinedGameTimestamp = new(__typeInfos[24]);
    private TdfObjectId _userGroupId = new(__typeInfos[25]);
    private TdfUInt64 _playerSessionId = new(__typeInfos[26]);
    private TdfString _uUID = new(__typeInfos[27]);

    public ReplicatedGamePlayer()
    {
        __members = [ _platformInfo, _customData, _accountCountry, _connectionGroupId, _connectionSlotId, _dirtySockUserIndex, _encryptedBlazeId, _externalId, _gameId, _hasJoinFirstPartyGameSessionPermission, _joinedViaMatchmaking, _accountLocale, _playerName, _personaNamespace, _playerId, _networkAddress, _playerSettings, _reservationCreationTimestamp, _roleName, _scenarioName, _slotId, _slotType, _playerState, _teamIndex, _joinedGameTimestamp, _userGroupId, _playerSessionId, _uUID ];
    }

    public override Tdf CreateNew() => new ReplicatedGamePlayer();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ReplicatedGamePlayer";
    public override string GetFullClassName() => "Blaze::GameManager::ReplicatedGamePlayer";

    public Blaze15SDK.Blaze.PlatformInfo? PlatformInfo
    {
        get => _platformInfo.Value;
        set => _platformInfo.Value = value;
    }

    public byte[] CustomData
    {
        get => _customData.Value;
        set => _customData.Value = value;
    }

    public uint AccountCountry
    {
        get => _accountCountry.Value;
        set => _accountCountry.Value = value;
    }

    public ulong ConnectionGroupId
    {
        get => _connectionGroupId.Value;
        set => _connectionGroupId.Value = value;
    }

    public byte ConnectionSlotId
    {
        get => _connectionSlotId.Value;
        set => _connectionSlotId.Value = value;
    }

    public int DirtySockUserIndex
    {
        get => _dirtySockUserIndex.Value;
        set => _dirtySockUserIndex.Value = value;
    }

    public string EncryptedBlazeId
    {
        get => _encryptedBlazeId.Value;
        set => _encryptedBlazeId.Value = value;
    }

    public ulong ExternalId
    {
        get => _externalId.Value;
        set => _externalId.Value = value;
    }

    public ulong GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public bool HasJoinFirstPartyGameSessionPermission
    {
        get => _hasJoinFirstPartyGameSessionPermission.Value;
        set => _hasJoinFirstPartyGameSessionPermission.Value = value;
    }

    public bool JoinedViaMatchmaking
    {
        get => _joinedViaMatchmaking.Value;
        set => _joinedViaMatchmaking.Value = value;
    }

    public uint AccountLocale
    {
        get => _accountLocale.Value;
        set => _accountLocale.Value = value;
    }

    public string PlayerName
    {
        get => _playerName.Value;
        set => _playerName.Value = value;
    }

    public string PersonaNamespace
    {
        get => _personaNamespace.Value;
        set => _personaNamespace.Value = value;
    }

    public long PlayerId
    {
        get => _playerId.Value;
        set => _playerId.Value = value;
    }

    public Blaze15SDK.Blaze.NetworkAddress? NetworkAddress
    {
        get => _networkAddress.Value;
        set => _networkAddress.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.PlayerSettings PlayerSettings
    {
        get => _playerSettings.Value;
        set => _playerSettings.Value = value;
    }

    public long ReservationCreationTimestamp
    {
        get => _reservationCreationTimestamp.Value;
        set => _reservationCreationTimestamp.Value = value;
    }

    public string RoleName
    {
        get => _roleName.Value;
        set => _roleName.Value = value;
    }

    public string ScenarioName
    {
        get => _scenarioName.Value;
        set => _scenarioName.Value = value;
    }

    public byte SlotId
    {
        get => _slotId.Value;
        set => _slotId.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.SlotType SlotType
    {
        get => _slotType.Value;
        set => _slotType.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.PlayerState PlayerState
    {
        get => _playerState.Value;
        set => _playerState.Value = value;
    }

    public ushort TeamIndex
    {
        get => _teamIndex.Value;
        set => _teamIndex.Value = value;
    }

    public long JoinedGameTimestamp
    {
        get => _joinedGameTimestamp.Value;
        set => _joinedGameTimestamp.Value = value;
    }

    public ObjectId UserGroupId
    {
        get => _userGroupId.Value;
        set => _userGroupId.Value = value;
    }

    public ulong PlayerSessionId
    {
        get => _playerSessionId.Value;
        set => _playerSessionId.Value = value;
    }

    public string UUID
    {
        get => _uUID.Value;
        set => _uUID.Value = value;
    }

}
