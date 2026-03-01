using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class ScenarioVariantConfig : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Criteria", "mCriteria", 0x0D225400, TdfType.String, 0, true), // crit
        new TdfMemberInfo("SubSession", "mSubSession", 0x4D509300, TdfType.List, 1, true), // subs
        new TdfMemberInfo("SubVariantOf", "mSubVariantOf", 0x4D63C600, TdfType.List, 2, true), // svof
    ];
    private ITdfMember[] __members;

    private TdfString _criteria = new(__typeInfos[0]);
    private TdfList<string> _subSession = new(__typeInfos[1]);
    private TdfList<string> _subVariantOf = new(__typeInfos[2]);

    public ScenarioVariantConfig()
    {
        __members = [ _criteria, _subSession, _subVariantOf ];
    }

    public override Tdf CreateNew() => new ScenarioVariantConfig();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ScenarioVariantConfig";
    public override string GetFullClassName() => "Blaze::GameManager::ScenarioVariantConfig";

    public string Criteria
    {
        get => _criteria.Value;
        set => _criteria.Value = value;
    }

    public IList<string> SubSession
    {
        get => _subSession.Value;
        set => _subSession.Value = value;
    }

    public IList<string> SubVariantOf
    {
        get => _subVariantOf.Value;
        set => _subVariantOf.Value = value;
    }

}
