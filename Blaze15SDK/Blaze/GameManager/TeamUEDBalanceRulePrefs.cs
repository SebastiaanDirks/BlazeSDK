using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class TeamUEDBalanceRulePrefs : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RuleName", "mRuleName", 0x38134500, TdfType.String, 0, true), // name
        new TdfMemberInfo("RangeOffsetListName", "mRangeOffsetListName", 0x50830400, TdfType.String, 1, true), // thld
    ];
    private ITdfMember[] __members;

    private TdfString _ruleName = new(__typeInfos[0]);
    private TdfString _rangeOffsetListName = new(__typeInfos[1]);

    public TeamUEDBalanceRulePrefs()
    {
        __members = [ _ruleName, _rangeOffsetListName ];
    }

    public override Tdf CreateNew() => new TeamUEDBalanceRulePrefs();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "TeamUEDBalanceRulePrefs";
    public override string GetFullClassName() => "Blaze::GameManager::TeamUEDBalanceRulePrefs";

    public string RuleName
    {
        get => _ruleName.Value;
        set => _ruleName.Value = value;
    }

    public string RangeOffsetListName
    {
        get => _rangeOffsetListName.Value;
        set => _rangeOffsetListName.Value = value;
    }

}
