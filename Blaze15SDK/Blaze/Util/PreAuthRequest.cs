using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Util;

public class PreAuthRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClientData", "mClientData", 0x0C405400, TdfType.Struct, 0, true), // cdat
        new TdfMemberInfo("ClientInfo", "mClientInfo", 0x0C938600, TdfType.Struct, 1, true), // cinf
        new TdfMemberInfo("FetchClientConfig", "mFetchClientConfig", 0x1830D200, TdfType.Struct, 2, true), // fccr
        new TdfMemberInfo("LocalAddress", "mLocalAddress", 0x30110400, TdfType.UInt32, 3, true), // ladd
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.Util.ClientData?> _clientData = new(__typeInfos[0]);
    private TdfStruct<Blaze15SDK.Blaze.ClientInfo?> _clientInfo = new(__typeInfos[1]);
    private TdfStruct<Blaze15SDK.Blaze.Util.FetchClientConfigRequest?> _fetchClientConfig = new(__typeInfos[2]);
    private TdfUInt32 _localAddress = new(__typeInfos[3]);

    public PreAuthRequest()
    {
        __members = [ _clientData, _clientInfo, _fetchClientConfig, _localAddress ];
    }

    public override Tdf CreateNew() => new PreAuthRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PreAuthRequest";
    public override string GetFullClassName() => "Blaze::GameManager::PreAuthRequest";

    public Blaze15SDK.Blaze.Util.ClientData? ClientData
    {
        get => _clientData.Value;
        set => _clientData.Value = value;
    }

    public Blaze15SDK.Blaze.ClientInfo? ClientInfo
    {
        get => _clientInfo.Value;
        set => _clientInfo.Value = value;
    }

    public Blaze15SDK.Blaze.Util.FetchClientConfigRequest? FetchClientConfig
    {
        get => _fetchClientConfig.Value;
        set => _fetchClientConfig.Value = value;
    }

    public uint LocalAddress
    {
        get => _localAddress.Value;
        set => _localAddress.Value = value;
    }

}
