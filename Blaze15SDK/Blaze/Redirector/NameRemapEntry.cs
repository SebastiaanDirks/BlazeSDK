using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Redirector;

public class NameRemapEntry : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DstPort", "mDstPort", 0x11049400, TdfType.UInt16, 0, true), // dprt
        new TdfMemberInfo("ServiceId", "mServiceId", 0x4C910000, TdfType.UInt32, 1, true), // sid
        new TdfMemberInfo("Hostname", "mHostname", 0x4C940000, TdfType.String, 2, true), // sip
        new TdfMemberInfo("SiteName", "mSiteName", 0x4C950500, TdfType.String, 3, true), // site
        new TdfMemberInfo("SrcPort", "mSrcPort", 0x4D049400, TdfType.UInt16, 4, true), // sprt
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _dstPort = new(__typeInfos[0]);
    private TdfUInt32 _serviceId = new(__typeInfos[1]);
    private TdfString _hostname = new(__typeInfos[2]);
    private TdfString _siteName = new(__typeInfos[3]);
    private TdfUInt16 _srcPort = new(__typeInfos[4]);

    public NameRemapEntry()
    {
        __members = [ _dstPort, _serviceId, _hostname, _siteName, _srcPort ];
    }

    public override Tdf CreateNew() => new NameRemapEntry();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NameRemapEntry";
    public override string GetFullClassName() => "Blaze::GameManager::NameRemapEntry";

    public ushort DstPort
    {
        get => _dstPort.Value;
        set => _dstPort.Value = value;
    }

    public uint ServiceId
    {
        get => _serviceId.Value;
        set => _serviceId.Value = value;
    }

    public string Hostname
    {
        get => _hostname.Value;
        set => _hostname.Value = value;
    }

    public string SiteName
    {
        get => _siteName.Value;
        set => _siteName.Value = value;
    }

    public ushort SrcPort
    {
        get => _srcPort.Value;
        set => _srcPort.Value = value;
    }

}
