using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Redirector;

public class ServerInstance : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClientTypes", "mClientTypes", 0x0CC51000, TdfType.List, 0, true), // cltp
        new TdfMemberInfo("CurrentWorkingDirectory", "mCurrentWorkingDirectory", 0x0D710000, TdfType.String, 1, true), // cwd
        new TdfMemberInfo("Endpoints", "mEndpoints", 0x14E11000, TdfType.List, 2, true), // endp
        new TdfMemberInfo("InstanceId", "mInstanceId", 0x24400000, TdfType.UInt32, 3, true), // id
        new TdfMemberInfo("Load", "mLoad", 0x30F04400, TdfType.Int32, 4, true), // load
        new TdfMemberInfo("InstanceName", "mInstanceName", 0x38134500, TdfType.String, 5, true), // name
        new TdfMemberInfo("InService", "mInService", 0x4D60C000, TdfType.Bool, 6, true), // svc
        new TdfMemberInfo("InstanceType", "mInstanceType", 0x51940500, TdfType.Enum, 7, true), // type
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze15SDK.Blaze.ClientType> _clientTypes = new(__typeInfos[0]);
    private TdfString _currentWorkingDirectory = new(__typeInfos[1]);
    private TdfList<Blaze15SDK.Blaze.Redirector.ServerEndpointInfo> _endpoints = new(__typeInfos[2]);
    private TdfUInt32 _instanceId = new(__typeInfos[3]);
    private TdfInt32 _load = new(__typeInfos[4]);
    private TdfString _instanceName = new(__typeInfos[5]);
    private TdfBool _inService = new(__typeInfos[6]);
    private TdfEnum<Blaze15SDK.Blaze.Redirector.InstanceType> _instanceType = new(__typeInfos[7]);

    public ServerInstance()
    {
        __members = [ _clientTypes, _currentWorkingDirectory, _endpoints, _instanceId, _load, _instanceName, _inService, _instanceType ];
    }

    public override Tdf CreateNew() => new ServerInstance();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ServerInstance";
    public override string GetFullClassName() => "Blaze::GameManager::ServerInstance";

    public IList<Blaze15SDK.Blaze.ClientType> ClientTypes
    {
        get => _clientTypes.Value;
        set => _clientTypes.Value = value;
    }

    public string CurrentWorkingDirectory
    {
        get => _currentWorkingDirectory.Value;
        set => _currentWorkingDirectory.Value = value;
    }

    public IList<Blaze15SDK.Blaze.Redirector.ServerEndpointInfo> Endpoints
    {
        get => _endpoints.Value;
        set => _endpoints.Value = value;
    }

    public uint InstanceId
    {
        get => _instanceId.Value;
        set => _instanceId.Value = value;
    }

    public int Load
    {
        get => _load.Value;
        set => _load.Value = value;
    }

    public string InstanceName
    {
        get => _instanceName.Value;
        set => _instanceName.Value = value;
    }

    public bool InService
    {
        get => _inService.Value;
        set => _inService.Value = value;
    }

    public Blaze15SDK.Blaze.Redirector.InstanceType InstanceType
    {
        get => _instanceType.Value;
        set => _instanceType.Value = value;
    }

}
