using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.OAuth;

public class GetUserAccessTokenRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UserSessionId", "mUserSessionId", 0x55324400, TdfType.UInt64, 0, true), // usid
        new TdfMemberInfo("ServiceName", "mServiceName", 0x4D60CE00, TdfType.String, 1, true), // svcn
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _userSessionId = new(__typeInfos[0]);
    private TdfString _serviceName = new(__typeInfos[1]);

    public GetUserAccessTokenRequest()
    {
        __members = [
            _userSessionId,
            _serviceName,
        ];
    }

    public override Tdf CreateNew() => new GetUserAccessTokenRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetUserAccessTokenRequest";
    public override string GetFullClassName() => "Blaze::OAuth::GetUserAccessTokenRequest";

    public ulong UserSessionId
    {
        get => _userSessionId.Value;
        set => _userSessionId.Value = value;
    }

    public string ServiceName
    {
        get => _serviceName.Value;
        set => _serviceName.Value = value;
    }

}
