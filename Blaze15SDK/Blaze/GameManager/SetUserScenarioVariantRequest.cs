using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class SetUserScenarioVariantRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Persona", "mPersona", 0x40549300, TdfType.String, 0, true), // pers
        new TdfMemberInfo("ScenarioName", "mScenarioName", 0x4C314E00, TdfType.String, 1, true), // scen
        new TdfMemberInfo("ScenarioVariant", "mScenarioVariant", 0x4C358100, TdfType.String, 2, true), // scva
    ];
    private ITdfMember[] __members;

    private TdfString _persona = new(__typeInfos[0]);
    private TdfString _scenarioName = new(__typeInfos[1]);
    private TdfString _scenarioVariant = new(__typeInfos[2]);

    public SetUserScenarioVariantRequest()
    {
        __members = [ _persona, _scenarioName, _scenarioVariant ];
    }

    public override Tdf CreateNew() => new SetUserScenarioVariantRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetUserScenarioVariantRequest";
    public override string GetFullClassName() => "Blaze::GameManager::SetUserScenarioVariantRequest";

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

    public string ScenarioVariant
    {
        get => _scenarioVariant.Value;
        set => _scenarioVariant.Value = value;
    }

}
