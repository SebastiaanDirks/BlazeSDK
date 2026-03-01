using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class HostedConnectivityInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("HostingServerNetworkAddress", "mHostingServerNetworkAddress", 0x20E04400, TdfType.Struct, 0, true), // hnad
        new TdfMemberInfo("HostingServerConnectivityId", "mHostingServerConnectivityId", 0x21324400, TdfType.UInt32, 1, true), // hsid
        new TdfMemberInfo("LocalLowLevelConnectivityId", "mLocalLowLevelConnectivityId", 0x30324400, TdfType.UInt32, 2, true), // lcid
        new TdfMemberInfo("RemoteLowLevelConnectivityId", "mRemoteLowLevelConnectivityId", 0x48324400, TdfType.UInt32, 3, true), // rcid
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.NetworkAddress?> _hostingServerNetworkAddress = new(__typeInfos[0]);
    private TdfUInt32 _hostingServerConnectivityId = new(__typeInfos[1]);
    private TdfUInt32 _localLowLevelConnectivityId = new(__typeInfos[2]);
    private TdfUInt32 _remoteLowLevelConnectivityId = new(__typeInfos[3]);

    public HostedConnectivityInfo()
    {
        __members = [ _hostingServerNetworkAddress, _hostingServerConnectivityId, _localLowLevelConnectivityId, _remoteLowLevelConnectivityId ];
    }

    public override Tdf CreateNew() => new HostedConnectivityInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "HostedConnectivityInfo";
    public override string GetFullClassName() => "Blaze::GameManager::HostedConnectivityInfo";

    public Blaze15SDK.Blaze.NetworkAddress? HostingServerNetworkAddress
    {
        get => _hostingServerNetworkAddress.Value;
        set => _hostingServerNetworkAddress.Value = value;
    }

    public uint HostingServerConnectivityId
    {
        get => _hostingServerConnectivityId.Value;
        set => _hostingServerConnectivityId.Value = value;
    }

    public uint LocalLowLevelConnectivityId
    {
        get => _localLowLevelConnectivityId.Value;
        set => _localLowLevelConnectivityId.Value = value;
    }

    public uint RemoteLowLevelConnectivityId
    {
        get => _remoteLowLevelConnectivityId.Value;
        set => _remoteLowLevelConnectivityId.Value = value;
    }

}
