using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class TeamUEDPositionParityRuleStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MaxUEDDifferenceAcceptedBottomPlayers", "mMaxUEDDifferenceAcceptedBottomPlayers", 0x08424600, TdfType.UInt64, 0, true), // bdif
        new TdfMemberInfo("BottomPlayersCounted", "mBottomPlayersCounted", 0x08F50E00, TdfType.UInt16, 1, true), // botn
        new TdfMemberInfo("RuleName", "mRuleName", 0x38134500, TdfType.String, 2, true), // name
        new TdfMemberInfo("MaxUEDDifferenceAcceptedTopPlayers", "mMaxUEDDifferenceAcceptedTopPlayers", 0x50424600, TdfType.UInt64, 3, true), // tdif
        new TdfMemberInfo("TopPlayersCounted", "mTopPlayersCounted", 0x50F40E00, TdfType.UInt16, 4, true), // topn
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _maxUEDDifferenceAcceptedBottomPlayers = new(__typeInfos[0]);
    private TdfUInt16 _bottomPlayersCounted = new(__typeInfos[1]);
    private TdfString _ruleName = new(__typeInfos[2]);
    private TdfUInt64 _maxUEDDifferenceAcceptedTopPlayers = new(__typeInfos[3]);
    private TdfUInt16 _topPlayersCounted = new(__typeInfos[4]);

    public TeamUEDPositionParityRuleStatus()
    {
        __members = [ _maxUEDDifferenceAcceptedBottomPlayers, _bottomPlayersCounted, _ruleName, _maxUEDDifferenceAcceptedTopPlayers, _topPlayersCounted ];
    }

    public override Tdf CreateNew() => new TeamUEDPositionParityRuleStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "TeamUEDPositionParityRuleStatus";
    public override string GetFullClassName() => "Blaze::GameManager::TeamUEDPositionParityRuleStatus";

    public ulong MaxUEDDifferenceAcceptedBottomPlayers
    {
        get => _maxUEDDifferenceAcceptedBottomPlayers.Value;
        set => _maxUEDDifferenceAcceptedBottomPlayers.Value = value;
    }

    public ushort BottomPlayersCounted
    {
        get => _bottomPlayersCounted.Value;
        set => _bottomPlayersCounted.Value = value;
    }

    public string RuleName
    {
        get => _ruleName.Value;
        set => _ruleName.Value = value;
    }

    public ulong MaxUEDDifferenceAcceptedTopPlayers
    {
        get => _maxUEDDifferenceAcceptedTopPlayers.Value;
        set => _maxUEDDifferenceAcceptedTopPlayers.Value = value;
    }

    public ushort TopPlayersCounted
    {
        get => _topPlayersCounted.Value;
        set => _topPlayersCounted.Value = value;
    }

}
