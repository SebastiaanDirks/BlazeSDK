using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.OAuth;

public class GetUserPsnTokenRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RetrieveUsing", "mRetrieveUsing", 0x3D739200, TdfType.Union, 0, true), // ownr
        new TdfMemberInfo("ForceRefresh", "mForceRefresh", 0x48518000, TdfType.Bool, 1, true), // ref
        new TdfMemberInfo("ServiceName", "mServiceName", 0x4D60CE00, TdfType.String, 2, true), // svcn
        new TdfMemberInfo("Platform", "mPlatform", 0x40C05400, TdfType.Enum, 3, true), // plat
    ];
    private ITdfMember[] __members;

    private TdfUnion<Blaze15SDK.Blaze.OAuth.PsnTokenOwnerId> _retrieveUsing = new(__typeInfos[0]);
    private TdfBool _forceRefresh = new(__typeInfos[1]);
    private TdfString _serviceName = new(__typeInfos[2]);
    private TdfEnum<Blaze15SDK.Blaze.ClientPlatformType> _platform = new(__typeInfos[3]);

    public GetUserPsnTokenRequest()
    {
        __members = [
            _retrieveUsing,
            _forceRefresh,
            _serviceName,
            _platform,
        ];
    }

    public override Tdf CreateNew() => new GetUserPsnTokenRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetUserPsnTokenRequest";
    public override string GetFullClassName() => "Blaze::OAuth::GetUserPsnTokenRequest";

    public Blaze15SDK.Blaze.OAuth.PsnTokenOwnerId RetrieveUsing
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

    public Blaze15SDK.Blaze.ClientPlatformType Platform
    {
        get => _platform.Value;
        set => _platform.Value = value;
    }

}
