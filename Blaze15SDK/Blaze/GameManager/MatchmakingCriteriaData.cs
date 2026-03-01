using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class MatchmakingCriteriaData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AvoidGamesRuleCriteria", "mAvoidGamesRuleCriteria", 0x04704D00, TdfType.Struct, 0, true), // agam
        new TdfMemberInfo("AvoidPlayersRuleCriteria", "mAvoidPlayersRuleCriteria", 0x05031200, TdfType.Struct, 1, true), // aplr
        new TdfMemberInfo("VariableCustomRulePrefs", "mVariableCustomRulePrefs", 0x0D605200, TdfType.Map, 2, true), // cvar
        new TdfMemberInfo("DedicatedServerAttributeRuleCriteriaMap", "mDedicatedServerAttributeRuleCriteriaMap", 0x11348300, TdfType.Map, 3, true), // dsrc
        new TdfMemberInfo("ExpandedPingSiteRuleCriteria", "mExpandedPingSiteRuleCriteria", 0x1504D200, TdfType.Struct, 4, true), // epsr
        new TdfMemberInfo("FreePlayerSlotsRuleCriteria", "mFreePlayerSlotsRuleCriteria", 0x19215300, TdfType.Struct, 5, true), // fres
        new TdfMemberInfo("GameAttributeRuleCriteriaMap", "mGameAttributeRuleCriteriaMap", 0x1C148300, TdfType.Map, 6, true), // garc
        new TdfMemberInfo("GeoLocationRuleCriteria", "mGeoLocationRuleCriteria", 0x1C53C000, TdfType.Struct, 7, true), // geo
        new TdfMemberInfo("GameNameRuleCriteria", "mGameNameRuleCriteria", 0x1CE04D00, TdfType.Struct, 8, true), // gnam
        new TdfMemberInfo("ModRuleCriteria", "mModRuleCriteria", 0x34F11200, TdfType.Struct, 9, true), // modr
        new TdfMemberInfo("HostBalancingRulePrefs", "mHostBalancingRulePrefs", 0x38150000, TdfType.Struct, 10, true), // nat
        new TdfMemberInfo("PlayerAttributeRuleCriteriaMap", "mPlayerAttributeRuleCriteriaMap", 0x40148300, TdfType.Map, 11, true), // parc
        new TdfMemberInfo("PlayerCountRuleCriteria", "mPlayerCountRuleCriteria", 0x40339400, TdfType.Struct, 12, true), // pcnt
        new TdfMemberInfo("PlayerSlotUtilizationRuleCriteria", "mPlayerSlotUtilizationRuleCriteria", 0x40350600, TdfType.Struct, 13, true), // pctf
        new TdfMemberInfo("PreferredGamesRuleCriteria", "mPreferredGamesRuleCriteria", 0x40748000, TdfType.Struct, 14, true), // pgr
        new TdfMemberInfo("PreferredPlayersRuleCriteria", "mPreferredPlayersRuleCriteria", 0x41031200, TdfType.Struct, 15, true), // pplr
        new TdfMemberInfo("PlatformRuleCriteria", "mPlatformRuleCriteria", 0x4120C000, TdfType.Struct, 16, true), // prc
        new TdfMemberInfo("RankedGameRulePrefs", "mRankedGameRulePrefs", 0x48138B00, TdfType.Struct, 17, true), // rank
        new TdfMemberInfo("ReputationRulePrefs", "mReputationRulePrefs", 0x48540000, TdfType.Struct, 18, true), // rep
        new TdfMemberInfo("RosterSizeRulePrefs", "mRosterSizeRulePrefs", 0x49369200, TdfType.Struct, 19, true), // rszr
        new TdfMemberInfo("TeamBalanceRulePrefs", "mTeamBalanceRulePrefs", 0x50248000, TdfType.Struct, 20, true), // tbr
        new TdfMemberInfo("TeamCountRulePrefs", "mTeamCountRulePrefs", 0x50339200, TdfType.Struct, 21, true), // tcnr
        new TdfMemberInfo("TeamCompositionRulePrefs", "mTeamCompositionRulePrefs", 0x50348000, TdfType.Struct, 22, true), // tcr
        new TdfMemberInfo("TeamMinSizeRulePrefs", "mTeamMinSizeRulePrefs", 0x50D4D200, TdfType.Struct, 23, true), // tmsr
        new TdfMemberInfo("TotalPlayerSlotsRuleCriteria", "mTotalPlayerSlotsRuleCriteria", 0x50F51300, TdfType.Struct, 24, true), // tots
        new TdfMemberInfo("TeamUEDPositionParityRulePrefs", "mTeamUEDPositionParityRulePrefs", 0x51041500, TdfType.Struct, 25, true), // tppu
        new TdfMemberInfo("TeamUEDBalanceRulePrefs", "mTeamUEDBalanceRulePrefs", 0x51548000, TdfType.Struct, 26, true), // tur
        new TdfMemberInfo("UEDRuleCriteriaMap", "mUEDRuleCriteriaMap", 0x54510000, TdfType.Map, 27, true), // ued
        new TdfMemberInfo("HostViabilityRulePrefs", "mHostViabilityRulePrefs", 0x58904200, TdfType.Struct, 28, true), // viab
        new TdfMemberInfo("VirtualGameRulePrefs", "mVirtualGameRulePrefs", 0x58949400, TdfType.Struct, 29, true), // virt
        new TdfMemberInfo("XblBlockPlayersRuleCriteria", "mXblBlockPlayersRuleCriteria", 0x61031200, TdfType.Struct, 30, true), // xplr
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.GameManager.AvoidGamesRuleCriteria?> _avoidGamesRuleCriteria = new(__typeInfos[0]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.AvoidPlayersRuleCriteria?> _avoidPlayersRuleCriteria = new(__typeInfos[1]);
    private TdfMap<string, object?> _variableCustomRulePrefs = new(__typeInfos[2]);
    private TdfMap<string, Blaze15SDK.Blaze.GameManager.DedicatedServerAttributeRuleCriteria> _dedicatedServerAttributeRuleCriteriaMap = new(__typeInfos[3]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.ExpandedPingSiteRuleCriteria?> _expandedPingSiteRuleCriteria = new(__typeInfos[4]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.FreePlayerSlotsRuleCriteria?> _freePlayerSlotsRuleCriteria = new(__typeInfos[5]);
    private TdfMap<string, Blaze15SDK.Blaze.GameManager.GameAttributeRuleCriteria> _gameAttributeRuleCriteriaMap = new(__typeInfos[6]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.GeoLocationRuleCriteria?> _geoLocationRuleCriteria = new(__typeInfos[7]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.GameNameRuleCriteria?> _gameNameRuleCriteria = new(__typeInfos[8]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.ModRuleCriteria?> _modRuleCriteria = new(__typeInfos[9]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.HostBalancingRulePrefs?> _hostBalancingRulePrefs = new(__typeInfos[10]);
    private TdfMap<string, Blaze15SDK.Blaze.GameManager.PlayerAttributeRuleCriteria> _playerAttributeRuleCriteriaMap = new(__typeInfos[11]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.PlayerCountRuleCriteria?> _playerCountRuleCriteria = new(__typeInfos[12]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.PlayerSlotUtilizationRuleCriteria?> _playerSlotUtilizationRuleCriteria = new(__typeInfos[13]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.PreferredGamesRuleCriteria?> _preferredGamesRuleCriteria = new(__typeInfos[14]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.PreferredPlayersRuleCriteria?> _preferredPlayersRuleCriteria = new(__typeInfos[15]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.PlatformRuleCriteria?> _platformRuleCriteria = new(__typeInfos[16]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.RankedGameRulePrefs?> _rankedGameRulePrefs = new(__typeInfos[17]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.ReputationRulePrefs?> _reputationRulePrefs = new(__typeInfos[18]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.RosterSizeRulePrefs?> _rosterSizeRulePrefs = new(__typeInfos[19]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.TeamBalanceRulePrefs?> _teamBalanceRulePrefs = new(__typeInfos[20]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.TeamCountRulePrefs?> _teamCountRulePrefs = new(__typeInfos[21]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.TeamCompositionRulePrefs?> _teamCompositionRulePrefs = new(__typeInfos[22]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.TeamMinSizeRulePrefs?> _teamMinSizeRulePrefs = new(__typeInfos[23]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.TotalPlayerSlotsRuleCriteria?> _totalPlayerSlotsRuleCriteria = new(__typeInfos[24]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.TeamUEDPositionParityRulePrefs?> _teamUEDPositionParityRulePrefs = new(__typeInfos[25]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.TeamUEDBalanceRulePrefs?> _teamUEDBalanceRulePrefs = new(__typeInfos[26]);
    private TdfMap<string, Blaze15SDK.Blaze.GameManager.UEDRuleCriteria> _uEDRuleCriteriaMap = new(__typeInfos[27]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.HostViabilityRulePrefs?> _hostViabilityRulePrefs = new(__typeInfos[28]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.VirtualGameRulePrefs?> _virtualGameRulePrefs = new(__typeInfos[29]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.XblBlockPlayersRuleCriteria?> _xblBlockPlayersRuleCriteria = new(__typeInfos[30]);

    public MatchmakingCriteriaData()
    {
        __members = [ _avoidGamesRuleCriteria, _avoidPlayersRuleCriteria, _variableCustomRulePrefs, _dedicatedServerAttributeRuleCriteriaMap, _expandedPingSiteRuleCriteria, _freePlayerSlotsRuleCriteria, _gameAttributeRuleCriteriaMap, _geoLocationRuleCriteria, _gameNameRuleCriteria, _modRuleCriteria, _hostBalancingRulePrefs, _playerAttributeRuleCriteriaMap, _playerCountRuleCriteria, _playerSlotUtilizationRuleCriteria, _preferredGamesRuleCriteria, _preferredPlayersRuleCriteria, _platformRuleCriteria, _rankedGameRulePrefs, _reputationRulePrefs, _rosterSizeRulePrefs, _teamBalanceRulePrefs, _teamCountRulePrefs, _teamCompositionRulePrefs, _teamMinSizeRulePrefs, _totalPlayerSlotsRuleCriteria, _teamUEDPositionParityRulePrefs, _teamUEDBalanceRulePrefs, _uEDRuleCriteriaMap, _hostViabilityRulePrefs, _virtualGameRulePrefs, _xblBlockPlayersRuleCriteria ];
    }

    public override Tdf CreateNew() => new MatchmakingCriteriaData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "MatchmakingCriteriaData";
    public override string GetFullClassName() => "Blaze::GameManager::MatchmakingCriteriaData";

    public Blaze15SDK.Blaze.GameManager.AvoidGamesRuleCriteria? AvoidGamesRuleCriteria
    {
        get => _avoidGamesRuleCriteria.Value;
        set => _avoidGamesRuleCriteria.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.AvoidPlayersRuleCriteria? AvoidPlayersRuleCriteria
    {
        get => _avoidPlayersRuleCriteria.Value;
        set => _avoidPlayersRuleCriteria.Value = value;
    }

    public IDictionary<string, object?> VariableCustomRulePrefs
    {
        get => _variableCustomRulePrefs.Value;
        set => _variableCustomRulePrefs.Value = value;
    }

    public IDictionary<string, Blaze15SDK.Blaze.GameManager.DedicatedServerAttributeRuleCriteria> DedicatedServerAttributeRuleCriteriaMap
    {
        get => _dedicatedServerAttributeRuleCriteriaMap.Value;
        set => _dedicatedServerAttributeRuleCriteriaMap.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.ExpandedPingSiteRuleCriteria? ExpandedPingSiteRuleCriteria
    {
        get => _expandedPingSiteRuleCriteria.Value;
        set => _expandedPingSiteRuleCriteria.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.FreePlayerSlotsRuleCriteria? FreePlayerSlotsRuleCriteria
    {
        get => _freePlayerSlotsRuleCriteria.Value;
        set => _freePlayerSlotsRuleCriteria.Value = value;
    }

    public IDictionary<string, Blaze15SDK.Blaze.GameManager.GameAttributeRuleCriteria> GameAttributeRuleCriteriaMap
    {
        get => _gameAttributeRuleCriteriaMap.Value;
        set => _gameAttributeRuleCriteriaMap.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.GeoLocationRuleCriteria? GeoLocationRuleCriteria
    {
        get => _geoLocationRuleCriteria.Value;
        set => _geoLocationRuleCriteria.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.GameNameRuleCriteria? GameNameRuleCriteria
    {
        get => _gameNameRuleCriteria.Value;
        set => _gameNameRuleCriteria.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.ModRuleCriteria? ModRuleCriteria
    {
        get => _modRuleCriteria.Value;
        set => _modRuleCriteria.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.HostBalancingRulePrefs? HostBalancingRulePrefs
    {
        get => _hostBalancingRulePrefs.Value;
        set => _hostBalancingRulePrefs.Value = value;
    }

    public IDictionary<string, Blaze15SDK.Blaze.GameManager.PlayerAttributeRuleCriteria> PlayerAttributeRuleCriteriaMap
    {
        get => _playerAttributeRuleCriteriaMap.Value;
        set => _playerAttributeRuleCriteriaMap.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.PlayerCountRuleCriteria? PlayerCountRuleCriteria
    {
        get => _playerCountRuleCriteria.Value;
        set => _playerCountRuleCriteria.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.PlayerSlotUtilizationRuleCriteria? PlayerSlotUtilizationRuleCriteria
    {
        get => _playerSlotUtilizationRuleCriteria.Value;
        set => _playerSlotUtilizationRuleCriteria.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.PreferredGamesRuleCriteria? PreferredGamesRuleCriteria
    {
        get => _preferredGamesRuleCriteria.Value;
        set => _preferredGamesRuleCriteria.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.PreferredPlayersRuleCriteria? PreferredPlayersRuleCriteria
    {
        get => _preferredPlayersRuleCriteria.Value;
        set => _preferredPlayersRuleCriteria.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.PlatformRuleCriteria? PlatformRuleCriteria
    {
        get => _platformRuleCriteria.Value;
        set => _platformRuleCriteria.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.RankedGameRulePrefs? RankedGameRulePrefs
    {
        get => _rankedGameRulePrefs.Value;
        set => _rankedGameRulePrefs.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.ReputationRulePrefs? ReputationRulePrefs
    {
        get => _reputationRulePrefs.Value;
        set => _reputationRulePrefs.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.RosterSizeRulePrefs? RosterSizeRulePrefs
    {
        get => _rosterSizeRulePrefs.Value;
        set => _rosterSizeRulePrefs.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.TeamBalanceRulePrefs? TeamBalanceRulePrefs
    {
        get => _teamBalanceRulePrefs.Value;
        set => _teamBalanceRulePrefs.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.TeamCountRulePrefs? TeamCountRulePrefs
    {
        get => _teamCountRulePrefs.Value;
        set => _teamCountRulePrefs.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.TeamCompositionRulePrefs? TeamCompositionRulePrefs
    {
        get => _teamCompositionRulePrefs.Value;
        set => _teamCompositionRulePrefs.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.TeamMinSizeRulePrefs? TeamMinSizeRulePrefs
    {
        get => _teamMinSizeRulePrefs.Value;
        set => _teamMinSizeRulePrefs.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.TotalPlayerSlotsRuleCriteria? TotalPlayerSlotsRuleCriteria
    {
        get => _totalPlayerSlotsRuleCriteria.Value;
        set => _totalPlayerSlotsRuleCriteria.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.TeamUEDPositionParityRulePrefs? TeamUEDPositionParityRulePrefs
    {
        get => _teamUEDPositionParityRulePrefs.Value;
        set => _teamUEDPositionParityRulePrefs.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.TeamUEDBalanceRulePrefs? TeamUEDBalanceRulePrefs
    {
        get => _teamUEDBalanceRulePrefs.Value;
        set => _teamUEDBalanceRulePrefs.Value = value;
    }

    public IDictionary<string, Blaze15SDK.Blaze.GameManager.UEDRuleCriteria> UEDRuleCriteriaMap
    {
        get => _uEDRuleCriteriaMap.Value;
        set => _uEDRuleCriteriaMap.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.HostViabilityRulePrefs? HostViabilityRulePrefs
    {
        get => _hostViabilityRulePrefs.Value;
        set => _hostViabilityRulePrefs.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.VirtualGameRulePrefs? VirtualGameRulePrefs
    {
        get => _virtualGameRulePrefs.Value;
        set => _virtualGameRulePrefs.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.XblBlockPlayersRuleCriteria? XblBlockPlayersRuleCriteria
    {
        get => _xblBlockPlayersRuleCriteria.Value;
        set => _xblBlockPlayersRuleCriteria.Value = value;
    }

}
