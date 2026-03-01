using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Redirector;

public class InstanceRemoveInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("InstanceId", "mInstanceId", 0x24910000, TdfType.Int32, 0, true), // iid
        new TdfMemberInfo("InstanceName", "mInstanceName", 0x24E04D00, TdfType.String, 1, true), // inam
        new TdfMemberInfo("ServiceName", "mServiceName", 0x4CE04D00, TdfType.String, 2, true), // snam
        new TdfMemberInfo("ServiceNames", "mServiceNames", 0x4CE35300, TdfType.List, 3, true), // snms
        new TdfMemberInfo("Type", "mType", 0x51940500, TdfType.Enum, 4, true), // type
    ];
    private ITdfMember[] __members;

    private TdfInt32 _instanceId = new(__typeInfos[0]);
    private TdfString _instanceName = new(__typeInfos[1]);
    private TdfString _serviceName = new(__typeInfos[2]);
    private TdfList<string> _serviceNames = new(__typeInfos[3]);
    private TdfEnum<Blaze15SDK.Blaze.Redirector.InstanceType> _type = new(__typeInfos[4]);

    public InstanceRemoveInfo()
    {
        __members = [ _instanceId, _instanceName, _serviceName, _serviceNames, _type ];
    }

    public override Tdf CreateNew() => new InstanceRemoveInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "InstanceRemoveInfo";
    public override string GetFullClassName() => "Blaze::GameManager::InstanceRemoveInfo";

    public int InstanceId
    {
        get => _instanceId.Value;
        set => _instanceId.Value = value;
    }

    public string InstanceName
    {
        get => _instanceName.Value;
        set => _instanceName.Value = value;
    }

    public string ServiceName
    {
        get => _serviceName.Value;
        set => _serviceName.Value = value;
    }

    public IList<string> ServiceNames
    {
        get => _serviceNames.Value;
        set => _serviceNames.Value = value;
    }

    public Blaze15SDK.Blaze.Redirector.InstanceType Type
    {
        get => _type.Value;
        set => _type.Value = value;
    }

}
