using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.OAuth;

public class GetUserXblTokenRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RetrieveUsing", "mRetrieveUsing", 0x3D739200, TdfType.Union, 0, true), // ownr
        new TdfMemberInfo("ForceRefresh", "mForceRefresh", 0x48518000, TdfType.Bool, 1, true), // ref
        new TdfMemberInfo("ServiceName", "mServiceName", 0x4D60CE00, TdfType.String, 2, true), // svcn
        new TdfMemberInfo("RelyingParty", "mRelyingParty", 0x48C65000, TdfType.String, 3, true), // rlyp
    ];
    private ITdfMember[] __members;

    private TdfUnion<Blaze15SDK.Blaze.OAuth.XblTokenOwnerId> _retrieveUsing = new(__typeInfos[0]);
    private TdfBool _forceRefresh = new(__typeInfos[1]);
    private TdfString _serviceName = new(__typeInfos[2]);
    private TdfString _relyingParty = new(__typeInfos[3]);

    public GetUserXblTokenRequest()
    {
        __members = [
            _retrieveUsing,
            _forceRefresh,
            _serviceName,
            _relyingParty,
        ];
    }

    public override Tdf CreateNew() => new GetUserXblTokenRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetUserXblTokenRequest";
    public override string GetFullClassName() => "Blaze::OAuth::GetUserXblTokenRequest";

    public Blaze15SDK.Blaze.OAuth.XblTokenOwnerId RetrieveUsing
    {
        get => _retrieveUsing.Value;
        set => _retrieveUsing.Value = value;
    }

    public bool ForceRefresh
    {
        get => _forceRefresh.Value;
        set => _forceRefresh.Value = value;
    }

    public string ServiceName
    {
        get => _serviceName.Value;
        set => _serviceName.Value = value;
    }

    public string RelyingParty
    {
        get => _relyingParty.Value;
        set => _relyingParty.Value = value;
    }

}
