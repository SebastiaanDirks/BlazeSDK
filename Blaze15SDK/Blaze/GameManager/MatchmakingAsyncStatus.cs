using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class MatchmakingAsyncStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CreateGameStatus", "mCreateGameStatus", 0x0C74C000, TdfType.Struct, 0, true), // cgs
        new TdfMemberInfo("VariableCustomAsyncStatus", "mVariableCustomAsyncStatus", 0x0D605200, TdfType.Map, 1, true), // cvar
        new TdfMemberInfo("ExpandedPingSiteRuleStatus", "mExpandedPingSiteRuleStatus", 0x1504D200, TdfType.Struct, 2, true), // epsr
        new TdfMemberInfo("FindGameStatus", "mFindGameStatus", 0x1874C000, TdfType.Struct, 3, true), // fgs
        new TdfMemberInfo("GameAttributeRuleStatusMap", "mGameAttributeRuleStatusMap", 0x1C14CD00, TdfType.Map, 4, true), // gasm
        new TdfMemberInfo("GeoLocationRuleStatus", "mGeoLocationRuleStatus", 0x1C53D300, TdfType.Struct, 5, true), // geos
        new TdfMemberInfo("HostBalanceRuleStatus", "mHostBalanceRuleStatus", 0x20248400, TdfType.Struct, 6, true), // hbrd
        new TdfMemberInfo("HostViabilityRuleStatus", "mHostViabilityRuleStatus", 0x21648400, TdfType.Struct, 7, true), // hvrd
        new TdfMemberInfo("PlayerAttributeRuleStatusMap", "mPlayerAttributeRuleStatusMap", 0x4014CD00, TdfType.Map, 8, true), // pasm
        new TdfMemberInfo("PlayerCountRuleStatus", "mPlayerCountRuleStatus", 0x40C0CE00, TdfType.Struct, 9, true), // plcn
        new TdfMemberInfo("PlayerSlotUtilizationRuleStatus", "mPlayerSlotUtilizationRuleStatus", 0x40C55400, TdfType.Struct, 10, true), // plut
        new TdfMemberInfo("RankRuleStatus", "mRankRuleStatus", 0x49210100, TdfType.Struct, 11, true), // rrda
        new TdfMemberInfo("QualityFactorScores", "mQualityFactorScores", 0x4C33D200, TdfType.List, 12, true), // scor
        new TdfMemberInfo("TeamBalanceRuleStatus", "mTeamBalanceRuleStatus", 0x50249300, TdfType.Struct, 13, true), // tbrs
        new TdfMemberInfo("TeamCompositionRuleStatus", "mTeamCompositionRuleStatus", 0x50341300, TdfType.Struct, 14, true), // tcps
        new TdfMemberInfo("TeamMinSizeRuleStatus", "mTeamMinSizeRuleStatus", 0x50D4D300, TdfType.Struct, 15, true), // tmss
        new TdfMemberInfo("TotalPlayerSlotsRuleStatus", "mTotalPlayerSlotsRuleStatus", 0x50F51300, TdfType.Struct, 16, true), // tots
        new TdfMemberInfo("TeamUEDPositionParityRuleStatus", "mTeamUEDPositionParityRuleStatus", 0x51041300, TdfType.Struct, 17, true), // tpps
        new TdfMemberInfo("TeamUEDBalanceRuleStatus", "mTeamUEDBalanceRuleStatus", 0x51509300, TdfType.Struct, 18, true), // tubs
        new TdfMemberInfo("UEDRuleStatusMap", "mUEDRuleStatusMap", 0x54511300, TdfType.Map, 19, true), // ueds
        new TdfMemberInfo("VirtualGameRuleStatus", "mVirtualGameRuleStatus", 0x58749300, TdfType.Struct, 20, true), // vgrs
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.GameManager.CreateGameStatus?> _createGameStatus = new(__typeInfos[0]);
    private TdfMap<string, object?> _variableCustomAsyncStatus = new(__typeInfos[1]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.ExpandedPingSiteRuleStatus?> _expandedPingSiteRuleStatus = new(__typeInfos[2]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.FindGameStatus?> _findGameStatus = new(__typeInfos[3]);
    private TdfMap<string, Blaze15SDK.Blaze.GameManager.GameAttributeRuleStatus> _gameAttributeRuleStatusMap = new(__typeInfos[4]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.GeoLocationRuleStatus?> _geoLocationRuleStatus = new(__typeInfos[5]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.HostBalanceRuleStatus?> _hostBalanceRuleStatus = new(__typeInfos[6]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.HostViabilityRuleStatus?> _hostViabilityRuleStatus = new(__typeInfos[7]);
    private TdfMap<string, Blaze15SDK.Blaze.GameManager.PlayerAttributeRuleStatus> _playerAttributeRuleStatusMap = new(__typeInfos[8]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.PlayerCountRuleStatus?> _playerCountRuleStatus = new(__typeInfos[9]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.PlayerSlotUtilizationRuleStatus?> _playerSlotUtilizationRuleStatus = new(__typeInfos[10]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.RankRuleStatus?> _rankRuleStatus = new(__typeInfos[11]);
    private TdfList<float> _qualityFactorScores = new(__typeInfos[12]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.TeamBalanceRuleStatus?> _teamBalanceRuleStatus = new(__typeInfos[13]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.TeamCompositionRuleStatus?> _teamCompositionRuleStatus = new(__typeInfos[14]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.TeamMinSizeRuleStatus?> _teamMinSizeRuleStatus = new(__typeInfos[15]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.TotalPlayerSlotsRuleStatus?> _totalPlayerSlotsRuleStatus = new(__typeInfos[16]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.TeamUEDPositionParityRuleStatus?> _teamUEDPositionParityRuleStatus = new(__typeInfos[17]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.TeamUEDBalanceRuleStatus?> _teamUEDBalanceRuleStatus = new(__typeInfos[18]);
    private TdfMap<string, Blaze15SDK.Blaze.GameManager.UEDRuleStatus> _uEDRuleStatusMap = new(__typeInfos[19]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.VirtualGameRuleStatus?> _virtualGameRuleStatus = new(__typeInfos[20]);

    public MatchmakingAsyncStatus()
    {
        __members = [ _createGameStatus, _variableCustomAsyncStatus, _expandedPingSiteRuleStatus, _findGameStatus, _gameAttributeRuleStatusMap, _geoLocationRuleStatus, _hostBalanceRuleStatus, _hostViabilityRuleStatus, _playerAttributeRuleStatusMap, _playerCountRuleStatus, _playerSlotUtilizationRuleStatus, _rankRuleStatus, _qualityFactorScores, _teamBalanceRuleStatus, _teamCompositionRuleStatus, _teamMinSizeRuleStatus, _totalPlayerSlotsRuleStatus, _teamUEDPositionParityRuleStatus, _teamUEDBalanceRuleStatus, _uEDRuleStatusMap, _virtualGameRuleStatus ];
    }

    public override Tdf CreateNew() => new MatchmakingAsyncStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "MatchmakingAsyncStatus";
    public override string GetFullClassName() => "Blaze::GameManager::MatchmakingAsyncStatus";

    public Blaze15SDK.Blaze.GameManager.CreateGameStatus? CreateGameStatus
    {
        get => _createGameStatus.Value;
        set => _createGameStatus.Value = value;
    }

    public IDictionary<string, object?> VariableCustomAsyncStatus
    {
        get => _variableCustomAsyncStatus.Value;
        set => _variableCustomAsyncStatus.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.ExpandedPingSiteRuleStatus? ExpandedPingSiteRuleStatus
    {
        get => _expandedPingSiteRuleStatus.Value;
        set => _expandedPingSiteRuleStatus.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.FindGameStatus? FindGameStatus
    {
        get => _findGameStatus.Value;
        set => _findGameStatus.Value = value;
    }

    public IDictionary<string, Blaze15SDK.Blaze.GameManager.GameAttributeRuleStatus> GameAttributeRuleStatusMap
    {
        get => _gameAttributeRuleStatusMap.Value;
        set => _gameAttributeRuleStatusMap.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.GeoLocationRuleStatus? GeoLocationRuleStatus
    {
        get => _geoLocationRuleStatus.Value;
        set => _geoLocationRuleStatus.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.HostBalanceRuleStatus? HostBalanceRuleStatus
    {
        get => _hostBalanceRuleStatus.Value;
        set => _hostBalanceRuleStatus.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.HostViabilityRuleStatus? HostViabilityRuleStatus
    {
        get => _hostViabilityRuleStatus.Value;
        set => _hostViabilityRuleStatus.Value = value;
    }

    public IDictionary<string, Blaze15SDK.Blaze.GameManager.PlayerAttributeRuleStatus> PlayerAttributeRuleStatusMap
    {
        get => _playerAttributeRuleStatusMap.Value;
        set => _playerAttributeRuleStatusMap.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.PlayerCountRuleStatus? PlayerCountRuleStatus
    {
        get => _playerCountRuleStatus.Value;
        set => _playerCountRuleStatus.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.PlayerSlotUtilizationRuleStatus? PlayerSlotUtilizationRuleStatus
    {
        get => _playerSlotUtilizationRuleStatus.Value;
        set => _playerSlotUtilizationRuleStatus.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.RankRuleStatus? RankRuleStatus
    {
        get => _rankRuleStatus.Value;
        set => _rankRuleStatus.Value = value;
    }

    public IList<float> QualityFactorScores
    {
        get => _qualityFactorScores.Value;
        set => _qualityFactorScores.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.TeamBalanceRuleStatus? TeamBalanceRuleStatus
    {
        get => _teamBalanceRuleStatus.Value;
        set => _teamBalanceRuleStatus.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.TeamCompositionRuleStatus? TeamCompositionRuleStatus
    {
        get => _teamCompositionRuleStatus.Value;
        set => _teamCompositionRuleStatus.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.TeamMinSizeRuleStatus? TeamMinSizeRuleStatus
    {
        get => _teamMinSizeRuleStatus.Value;
        set => _teamMinSizeRuleStatus.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.TotalPlayerSlotsRuleStatus? TotalPlayerSlotsRuleStatus
    {
        get => _totalPlayerSlotsRuleStatus.Value;
        set => _totalPlayerSlotsRuleStatus.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.TeamUEDPositionParityRuleStatus? TeamUEDPositionParityRuleStatus
    {
        get => _teamUEDPositionParityRuleStatus.Value;
        set => _teamUEDPositionParityRuleStatus.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.TeamUEDBalanceRuleStatus? TeamUEDBalanceRuleStatus
    {
        get => _teamUEDBalanceRuleStatus.Value;
        set => _teamUEDBalanceRuleStatus.Value = value;
    }

    public IDictionary<string, Blaze15SDK.Blaze.GameManager.UEDRuleStatus> UEDRuleStatusMap
    {
        get => _uEDRuleStatusMap.Value;
        set => _uEDRuleStatusMap.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.VirtualGameRuleStatus? VirtualGameRuleStatus
    {
        get => _virtualGameRuleStatus.Value;
        set => _virtualGameRuleStatus.Value = value;
    }

}
