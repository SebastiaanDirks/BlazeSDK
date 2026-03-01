using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze;

public class XboxOneExternalSessionIdentification : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("TemplateName", "mTemplateName", 0x4D434E00, TdfType.String, 0, true), // stmn
        new TdfMemberInfo("SessionName", "mSessionName", 0x15338D00, TdfType.String, 1, true), // esnm
        new TdfMemberInfo("CorrelationId", "mCorrelationId", 0x0CF24400, TdfType.String, 2, true), // coid
    ];
    private ITdfMember[] __members;

    private TdfString _templateName = new(__typeInfos[0]);
    private TdfString _sessionName = new(__typeInfos[1]);
    private TdfString _correlationId = new(__typeInfos[2]);

    public XboxOneExternalSessionIdentification()
    {
        __members = [
            _templateName,
            _sessionName,
            _correlationId,
        ];
    }

    public override Tdf CreateNew() => new XboxOneExternalSessionIdentification();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "XboxOneExternalSessionIdentification";
    public override string GetFullClassName() => "Blaze::XboxOneExternalSessionIdentification";

    public string TemplateName
    {
        get => _templateName.Value;
        set => _templateName.Value = value;
    }

    public string SessionName
    {
        get => _sessionName.Value;
        set => _sessionName.Value = value;
    }

    public string CorrelationId
    {
        get => _correlationId.Value;
        set => _correlationId.Value = value;
    }

}
