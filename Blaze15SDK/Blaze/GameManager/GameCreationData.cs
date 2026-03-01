using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class GameCreationData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EntryCriteriaMap", "mEntryCriteriaMap", 0x0D225400, TdfType.Map, 0, true), // crit
        new TdfMemberInfo("DisconnectReservationTimeout", "mDisconnectReservationTimeout", 0x11250F00, TdfType.Int64, 1, true), // drto
        new TdfMemberInfo("DataSourceNameList", "mDataSourceNameList", 0x1444CF00, TdfType.List, 2, true), // edso
        new TdfMemberInfo("IsExternalOwner", "mIsExternalOwner", 0x14F5CE00, TdfType.Bool, 3, true), // eown
        new TdfMemberInfo("ExternalSessionIdentSetup", "mExternalSessionIdentSetup", 0x15851300, TdfType.Struct, 4, true), // exts
        new TdfMemberInfo("GameModRegister", "mGameModRegister", 0x1CD48700, TdfType.UInt32, 5, true), // gmrg
        new TdfMemberInfo("GameName", "mGameName", 0x1CE04D00, TdfType.String, 6, true), // gnam
        new TdfMemberInfo("PermissionSystemName", "mPermissionSystemName", 0x1D04CE00, TdfType.String, 7, true), // gpsn
        new TdfMemberInfo("GameSettings", "mGameSettings", 0x1D315400, TdfType.Enum, 8, true), // gset
        new TdfMemberInfo("GameReportName", "mGameReportName", 0x1D465000, TdfType.String, 9, true), // gtyp
        new TdfMemberInfo("SkipInitializing", "mSkipInitializing", 0x38938900, TdfType.Bool, 10, true), // nini
        new TdfMemberInfo("NetworkTopology", "mNetworkTopology", 0x3943D000, TdfType.Enum, 11, true), // ntop
        new TdfMemberInfo("SlotCapacitiesMap", "mSlotCapacitiesMap", 0x40340D00, TdfType.Map, 12, true), // pcpm
        new TdfMemberInfo("MaxPlayerCapacity", "mMaxPlayerCapacity", 0x40D05800, TdfType.UInt16, 13, true), // pmax
        new TdfMemberInfo("MinPlayerCapacity", "mMinPlayerCapacity", 0x40D24E00, TdfType.UInt16, 14, true), // pmin
        new TdfMemberInfo("PresenceDisabledList", "mPresenceDisabledList", 0x41210C00, TdfType.List, 15, true), // prdl
        new TdfMemberInfo("PresenceMode", "mPresenceMode", 0x41215300, TdfType.Enum, 16, true), // pres
        new TdfMemberInfo("PlayerReservationTimeout", "mPlayerReservationTimeout", 0x41250F00, TdfType.Int64, 17, true), // prto
        new TdfMemberInfo("QueueCapacity", "mQueueCapacity", 0x44305000, TdfType.UInt16, 18, true), // qcap
        new TdfMemberInfo("RoleInformation", "mRoleInformation", 0x48E18F00, TdfType.Struct, 19, true), // rnfo
        new TdfMemberInfo("ExternalSessionCustomData", "mExternalSessionCustomData", 0x4C405400, TdfType.Map, 20, true), // sdat
        new TdfMemberInfo("ExternalSessionStatus", "mExternalSessionStatus", 0x4D350100, TdfType.Struct, 21, true), // ssta
        new TdfMemberInfo("ExternalSessionTemplateName", "mExternalSessionTemplateName", 0x4D434E00, TdfType.String, 22, true), // stmn
        new TdfMemberInfo("TeamIds", "mTeamIds", 0x50911300, TdfType.List, 23, true), // tids
        new TdfMemberInfo("VoipNetwork", "mVoipNetwork", 0x58F25000, TdfType.Enum, 24, true), // voip
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _entryCriteriaMap = new(__typeInfos[0]);
    private TdfInt64 _disconnectReservationTimeout = new(__typeInfos[1]);
    private TdfList<string> _dataSourceNameList = new(__typeInfos[2]);
    private TdfBool _isExternalOwner = new(__typeInfos[3]);
    private TdfStruct<Blaze15SDK.Blaze.ExternalSessionIdentification?> _externalSessionIdentSetup = new(__typeInfos[4]);
    private TdfUInt32 _gameModRegister = new(__typeInfos[5]);
    private TdfString _gameName = new(__typeInfos[6]);
    private TdfString _permissionSystemName = new(__typeInfos[7]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.GameSettings> _gameSettings = new(__typeInfos[8]);
    private TdfString _gameReportName = new(__typeInfos[9]);
    private TdfBool _skipInitializing = new(__typeInfos[10]);
    private TdfEnum<Blaze15SDK.Blaze.GameNetworkTopology> _networkTopology = new(__typeInfos[11]);
    private TdfMap<Blaze15SDK.Blaze.GameManager.SlotType, ushort> _slotCapacitiesMap = new(__typeInfos[12]);
    private TdfUInt16 _maxPlayerCapacity = new(__typeInfos[13]);
    private TdfUInt16 _minPlayerCapacity = new(__typeInfos[14]);
    private TdfList<Blaze15SDK.Blaze.ClientPlatformType> _presenceDisabledList = new(__typeInfos[15]);
    private TdfEnum<Blaze15SDK.Blaze.PresenceMode> _presenceMode = new(__typeInfos[16]);
    private TdfInt64 _playerReservationTimeout = new(__typeInfos[17]);
    private TdfUInt16 _queueCapacity = new(__typeInfos[18]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.RoleInformation?> _roleInformation = new(__typeInfos[19]);
    private TdfMap<string, string> _externalSessionCustomData = new(__typeInfos[20]);
    private TdfStruct<Blaze15SDK.Blaze.ExternalSessionStatus?> _externalSessionStatus = new(__typeInfos[21]);
    private TdfString _externalSessionTemplateName = new(__typeInfos[22]);
    private TdfList<ushort> _teamIds = new(__typeInfos[23]);
    private TdfEnum<Blaze15SDK.Blaze.VoipTopology> _voipNetwork = new(__typeInfos[24]);

    public GameCreationData()
    {
        __members = [ _entryCriteriaMap, _disconnectReservationTimeout, _dataSourceNameList, _isExternalOwner, _externalSessionIdentSetup, _gameModRegister, _gameName, _permissionSystemName, _gameSettings, _gameReportName, _skipInitializing, _networkTopology, _slotCapacitiesMap, _maxPlayerCapacity, _minPlayerCapacity, _presenceDisabledList, _presenceMode, _playerReservationTimeout, _queueCapacity, _roleInformation, _externalSessionCustomData, _externalSessionStatus, _externalSessionTemplateName, _teamIds, _voipNetwork ];
    }

    public override Tdf CreateNew() => new GameCreationData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameCreationData";
    public override string GetFullClassName() => "Blaze::GameManager::GameCreationData";

    public IDictionary<string, string> EntryCriteriaMap
    {
        get => _entryCriteriaMap.Value;
        set => _entryCriteriaMap.Value = value;
    }

    public long DisconnectReservationTimeout
    {
        get => _disconnectReservationTimeout.Value;
        set => _disconnectReservationTimeout.Value = value;
    }

    public IList<string> DataSourceNameList
    {
        get => _dataSourceNameList.Value;
        set => _dataSourceNameList.Value = value;
    }

    public bool IsExternalOwner
    {
        get => _isExternalOwner.Value;
        set => _isExternalOwner.Value = value;
    }

    public Blaze15SDK.Blaze.ExternalSessionIdentification? ExternalSessionIdentSetup
    {
        get => _externalSessionIdentSetup.Value;
        set => _externalSessionIdentSetup.Value = value;
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

    public string PermissionSystemName
    {
        get => _permissionSystemName.Value;
        set => _permissionSystemName.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.GameSettings GameSettings
    {
        get => _gameSettings.Value;
        set => _gameSettings.Value = value;
    }

    public string GameReportName
    {
        get => _gameReportName.Value;
        set => _gameReportName.Value = value;
    }

    public bool SkipInitializing
    {
        get => _skipInitializing.Value;
        set => _skipInitializing.Value = value;
    }

    public Blaze15SDK.Blaze.GameNetworkTopology NetworkTopology
    {
        get => _networkTopology.Value;
        set => _networkTopology.Value = value;
    }

    public IDictionary<Blaze15SDK.Blaze.GameManager.SlotType, ushort> SlotCapacitiesMap
    {
        get => _slotCapacitiesMap.Value;
        set => _slotCapacitiesMap.Value = value;
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

    public IDictionary<string, string> ExternalSessionCustomData
    {
        get => _externalSessionCustomData.Value;
        set => _externalSessionCustomData.Value = value;
    }

    public Blaze15SDK.Blaze.ExternalSessionStatus? ExternalSessionStatus
    {
        get => _externalSessionStatus.Value;
        set => _externalSessionStatus.Value = value;
    }

    public string ExternalSessionTemplateName
    {
        get => _externalSessionTemplateName.Value;
        set => _externalSessionTemplateName.Value = value;
    }

    public IList<ushort> TeamIds
    {
        get => _teamIds.Value;
        set => _teamIds.Value = value;
    }

    public Blaze15SDK.Blaze.VoipTopology VoipNetwork
    {
        get => _voipNetwork.Value;
        set => _voipNetwork.Value = value;
    }

}
