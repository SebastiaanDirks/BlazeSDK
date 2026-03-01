using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class CreateGameTemplateRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CommonGameData", "mCommonGameData", 0x0C710000, TdfType.Struct, 0, true), // cgd
        new TdfMemberInfo("PlayerJoinData", "mPlayerJoinData", 0x40A10000, TdfType.Struct, 1, true), // pjd
        new TdfMemberInfo("TemplateAttributes", "mTemplateAttributes", 0x50D40100, TdfType.Map, 2, true), // tmpa
        new TdfMemberInfo("TemplateName", "mTemplateName", 0x50D40E00, TdfType.String, 3, true), // tmpn
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.GameManager.CommonGameRequestData?> _commonGameData = new(__typeInfos[0]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.PlayerJoinData?> _playerJoinData = new(__typeInfos[1]);
    private TdfMap<string, object> _templateAttributes = new(__typeInfos[2]);
    private TdfString _templateName = new(__typeInfos[3]);

    public CreateGameTemplateRequest()
    {
        __members = [ _commonGameData, _playerJoinData, _templateAttributes, _templateName ];
    }

    public override Tdf CreateNew() => new CreateGameTemplateRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CreateGameTemplateRequest";
    public override string GetFullClassName() => "Blaze::GameManager::CreateGameTemplateRequest";

    public Blaze15SDK.Blaze.GameManager.CommonGameRequestData? CommonGameData
    {
        get => _commonGameData.Value;
        set => _commonGameData.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.PlayerJoinData? PlayerJoinData
    {
        get => _playerJoinData.Value;
        set => _playerJoinData.Value = value;
    }

    public IDictionary<string, object> TemplateAttributes
    {
        get => _templateAttributes.Value;
        set => _templateAttributes.Value = value;
    }

    public string TemplateName
    {
        get => _templateName.Value;
        set => _templateName.Value = value;
    }

}
