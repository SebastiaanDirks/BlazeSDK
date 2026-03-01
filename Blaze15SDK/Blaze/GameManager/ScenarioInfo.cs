using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class ScenarioInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ScenarioAttributes", "mScenarioAttributes", 0x05451200, TdfType.Map, 0, true), // attr
        new TdfMemberInfo("ScenarioName", "mScenarioName", 0x4C314E00, TdfType.String, 1, true), // scen
        new TdfMemberInfo("ScenarioVersion", "mScenarioVersion", 0x4C315600, TdfType.UInt32, 2, true), // scev
        new TdfMemberInfo("ScenarioVariant", "mScenarioVariant", 0x4C358100, TdfType.String, 3, true), // scva
        new TdfMemberInfo("SubSessionName", "mSubSessionName", 0x4D508E00, TdfType.String, 4, true), // subn
    ];
    private ITdfMember[] __members;

    private TdfMap<string, object> _scenarioAttributes = new(__typeInfos[0]);
    private TdfString _scenarioName = new(__typeInfos[1]);
    private TdfUInt32 _scenarioVersion = new(__typeInfos[2]);
    private TdfString _scenarioVariant = new(__typeInfos[3]);
    private TdfString _subSessionName = new(__typeInfos[4]);

    public ScenarioInfo()
    {
        __members = [ _scenarioAttributes, _scenarioName, _scenarioVersion, _scenarioVariant, _subSessionName ];
    }

    public override Tdf CreateNew() => new ScenarioInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ScenarioInfo";
    public override string GetFullClassName() => "Blaze::GameManager::ScenarioInfo";

    public IDictionary<string, object> ScenarioAttributes
    {
        get => _scenarioAttributes.Value;
        set => _scenarioAttributes.Value = value;
    }

    public string ScenarioName
    {
        get => _scenarioName.Value;
        set => _scenarioName.Value = value;
    }

    public uint ScenarioVersion
    {
        get => _scenarioVersion.Value;
        set => _scenarioVersion.Value = value;
    }

    public string ScenarioVariant
    {
        get => _scenarioVariant.Value;
        set => _scenarioVariant.Value = value;
    }

    public string SubSessionName
    {
        get => _subSessionName.Value;
        set => _subSessionName.Value = value;
    }

}
