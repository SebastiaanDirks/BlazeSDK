using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.OAuth;

public class GetUserAccessTokenResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AccessToken", "mAccessToken", 0x0543CB00, TdfType.String, 0, true), // atok
        new TdfMemberInfo("ClientId", "mClientId", 0x0CC24400, TdfType.String, 1, true), // clid
        new TdfMemberInfo("ValidUntil", "mValidUntil", 0x58130900, TdfType.TimeValue, 2, true), // vali
    ];
    private ITdfMember[] __members;

    private TdfString _accessToken = new(__typeInfos[0]);
    private TdfString _clientId = new(__typeInfos[1]);
    private TdfTimeValue _validUntil = new(__typeInfos[2]);

    public GetUserAccessTokenResponse()
    {
        __members = [
            _accessToken,
            _clientId,
            _validUntil,
        ];
    }

    public override Tdf CreateNew() => new GetUserAccessTokenResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetUserAccessTokenResponse";
    public override string GetFullClassName() => "Blaze::OAuth::GetUserAccessTokenResponse";

    public string AccessToken
    {
        get => _accessToken.Value;
        set => _accessToken.Value = value;
    }

    public string ClientId
    {
        get => _clientId.Value;
        set => _clientId.Value = value;
    }

    public TimeValue ValidUntil
    {
        get => _validUntil.Value;
        set => _validUntil.Value = value;
    }

}
