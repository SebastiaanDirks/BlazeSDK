using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Util;

public class GetTelemetryServerRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UseKey2", "mUseKey2", 0x2C565200, TdfType.Bool, 0, true), // key2
        new TdfMemberInfo("ServiceName", "mServiceName", 0x4CE04D00, TdfType.String, 1, true), // snam
    ];
    private ITdfMember[] __members;

    private TdfBool _useKey2 = new(__typeInfos[0]);
    private TdfString _serviceName = new(__typeInfos[1]);

    public GetTelemetryServerRequest()
    {
        __members = [ _useKey2, _serviceName ];
    }

    public override Tdf CreateNew() => new GetTelemetryServerRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetTelemetryServerRequest";
    public override string GetFullClassName() => "Blaze::GameManager::GetTelemetryServerRequest";

    public bool UseKey2
    {
        get => _useKey2.Value;
        set => _useKey2.Value = value;
    }

    public string ServiceName
    {
        get => _serviceName.Value;
        set => _serviceName.Value = value;
    }

}
