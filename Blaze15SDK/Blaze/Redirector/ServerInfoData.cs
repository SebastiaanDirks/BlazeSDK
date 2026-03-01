using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Redirector;

public class ServerInfoData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AddressRemaps", "mAddressRemaps", 0x04D05000, TdfType.List, 0, true), // amap
        new TdfMemberInfo("BuildTarget", "mBuildTarget", 0x0941D400, TdfType.String, 1, true), // btgt
        new TdfMemberInfo("BuildTime", "mBuildTime", 0x09424D00, TdfType.String, 2, true), // btim
        new TdfMemberInfo("ConfigVersion", "mConfigVersion", 0x0C759300, TdfType.String, 3, true), // cgvs
        new TdfMemberInfo("CompatibleClientVersions", "mCompatibleClientVersions", 0x0D615200, TdfType.List, 4, true), // cver
        new TdfMemberInfo("DepotLocation", "mDepotLocation", 0x10540F00, TdfType.String, 5, true), // depo
        new TdfMemberInfo("Instances", "mInstances", 0x24E4D400, TdfType.List, 6, true), // inst
        new TdfMemberInfo("IncompatibleClientVersions", "mIncompatibleClientVersions", 0x25615200, TdfType.List, 7, true), // iver
        new TdfMemberInfo("BuildLocation", "mBuildLocation", 0x30F0CE00, TdfType.String, 8, true), // locn
        new TdfMemberInfo("MasterInstance", "mMasterInstance", 0x35351200, TdfType.Struct, 9, true), // mstr
        new TdfMemberInfo("Name", "mName", 0x38134500, TdfType.String, 10, true), // name
        new TdfMemberInfo("NameRemaps", "mNameRemaps", 0x38D05000, TdfType.List, 11, true), // nmap
        new TdfMemberInfo("Platform", "mPlatform", 0x40C05400, TdfType.String, 12, true), // plat
        new TdfMemberInfo("ServiceNames", "mServiceNames", 0x4CE35300, TdfType.List, 13, true), // snms
        new TdfMemberInfo("DefaultServiceId", "mDefaultServiceId", 0x4D624400, TdfType.UInt32, 14, true), // svid
        new TdfMemberInfo("Version", "mVersion", 0x58549300, TdfType.String, 15, true), // vers
        new TdfMemberInfo("DefaultDnsAddress", "mDefaultDnsAddress", 0x60439300, TdfType.UInt32, 16, true), // xdns
        new TdfMemberInfo("AuxMasters", "mAuxMasters", 0x60D4D400, TdfType.List, 17, true), // xmst
        new TdfMemberInfo("AuxSlaves", "mAuxSlaves", 0x61331600, TdfType.List, 18, true), // xslv
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze15SDK.Blaze.Redirector.AddressRemapEntry> _addressRemaps = new(__typeInfos[0]);
    private TdfString _buildTarget = new(__typeInfos[1]);
    private TdfString _buildTime = new(__typeInfos[2]);
    private TdfString _configVersion = new(__typeInfos[3]);
    private TdfList<string> _compatibleClientVersions = new(__typeInfos[4]);
    private TdfString _depotLocation = new(__typeInfos[5]);
    private TdfList<Blaze15SDK.Blaze.Redirector.ServerInstance> _instances = new(__typeInfos[6]);
    private TdfList<string> _incompatibleClientVersions = new(__typeInfos[7]);
    private TdfString _buildLocation = new(__typeInfos[8]);
    private TdfStruct<Blaze15SDK.Blaze.Redirector.ServerInstance?> _masterInstance = new(__typeInfos[9]);
    private TdfString _name = new(__typeInfos[10]);
    private TdfList<Blaze15SDK.Blaze.Redirector.NameRemapEntry> _nameRemaps = new(__typeInfos[11]);
    private TdfString _platform = new(__typeInfos[12]);
    private TdfList<string> _serviceNames = new(__typeInfos[13]);
    private TdfUInt32 _defaultServiceId = new(__typeInfos[14]);
    private TdfString _version = new(__typeInfos[15]);
    private TdfUInt32 _defaultDnsAddress = new(__typeInfos[16]);
    private TdfList<Blaze15SDK.Blaze.Redirector.ServerInstance> _auxMasters = new(__typeInfos[17]);
    private TdfList<Blaze15SDK.Blaze.Redirector.ServerInstance> _auxSlaves = new(__typeInfos[18]);

    public ServerInfoData()
    {
        __members = [ _addressRemaps, _buildTarget, _buildTime, _configVersion, _compatibleClientVersions, _depotLocation, _instances, _incompatibleClientVersions, _buildLocation, _masterInstance, _name, _nameRemaps, _platform, _serviceNames, _defaultServiceId, _version, _defaultDnsAddress, _auxMasters, _auxSlaves ];
    }

    public override Tdf CreateNew() => new ServerInfoData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ServerInfoData";
    public override string GetFullClassName() => "Blaze::GameManager::ServerInfoData";

    public IList<Blaze15SDK.Blaze.Redirector.AddressRemapEntry> AddressRemaps
    {
        get => _addressRemaps.Value;
        set => _addressRemaps.Value = value;
    }

    public string BuildTarget
    {
        get => _buildTarget.Value;
        set => _buildTarget.Value = value;
    }

    public string BuildTime
    {
        get => _buildTime.Value;
        set => _buildTime.Value = value;
    }

    public string ConfigVersion
    {
        get => _configVersion.Value;
        set => _configVersion.Value = value;
    }

    public IList<string> CompatibleClientVersions
    {
        get => _compatibleClientVersions.Value;
        set => _compatibleClientVersions.Value = value;
    }

    public string DepotLocation
    {
        get => _depotLocation.Value;
        set => _depotLocation.Value = value;
    }

    public IList<Blaze15SDK.Blaze.Redirector.ServerInstance> Instances
    {
        get => _instances.Value;
        set => _instances.Value = value;
    }

    public IList<string> IncompatibleClientVersions
    {
        get => _incompatibleClientVersions.Value;
        set => _incompatibleClientVersions.Value = value;
    }

    public string BuildLocation
    {
        get => _buildLocation.Value;
        set => _buildLocation.Value = value;
    }

    public Blaze15SDK.Blaze.Redirector.ServerInstance? MasterInstance
    {
        get => _masterInstance.Value;
        set => _masterInstance.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public IList<Blaze15SDK.Blaze.Redirector.NameRemapEntry> NameRemaps
    {
        get => _nameRemaps.Value;
        set => _nameRemaps.Value = value;
    }

    public string Platform
    {
        get => _platform.Value;
        set => _platform.Value = value;
    }

    public IList<string> ServiceNames
    {
        get => _serviceNames.Value;
        set => _serviceNames.Value = value;
    }

    public uint DefaultServiceId
    {
        get => _defaultServiceId.Value;
        set => _defaultServiceId.Value = value;
    }

    public string Version
    {
        get => _version.Value;
        set => _version.Value = value;
    }

    public uint DefaultDnsAddress
    {
        get => _defaultDnsAddress.Value;
        set => _defaultDnsAddress.Value = value;
    }

    public IList<Blaze15SDK.Blaze.Redirector.ServerInstance> AuxMasters
    {
        get => _auxMasters.Value;
        set => _auxMasters.Value = value;
    }

    public IList<Blaze15SDK.Blaze.Redirector.ServerInstance> AuxSlaves
    {
        get => _auxSlaves.Value;
        set => _auxSlaves.Value = value;
    }

}
