using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class ClearUserScenarioVariantRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Persona", "mPersona", 0x40549300, TdfType.String, 0, true), // pers
        new TdfMemberInfo("ScenarioName", "mScenarioName", 0x4C314E00, TdfType.String, 1, true), // scen
    ];
    private ITdfMember[] __members;

    private TdfString _persona = new(__typeInfos[0]);
    private TdfString _scenarioName = new(__typeInfos[1]);

    public ClearUserScenarioVariantRequest()
    {
        __members = [ _persona, _scenarioName ];
    }

    public override Tdf CreateNew() => new ClearUserScenarioVariantRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClearUserScenarioVariantRequest";
    public override string GetFullClassName() => "Blaze::GameManager::ClearUserScenarioVariantRequest";

    public string Persona
    {
        get => _persona.Value;
        set => _persona.Value = value;
    }

    public string ScenarioName
    {
        get => _scenarioName.Value;
        set => _scenarioName.Value = value;
    }

}
