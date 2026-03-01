using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Util;

public class ClientData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Country", "mCountry", 0x0D449900, TdfType.UInt32, 0, true), // ctry
        new TdfMemberInfo("IgnoreInactivityTimeout", "mIgnoreInactivityTimeout", 0x24950F00, TdfType.Bool, 1, true), // iito
        new TdfMemberInfo("Locale", "mLocale", 0x30138700, TdfType.UInt32, 2, true), // lang
        new TdfMemberInfo("ServiceName", "mServiceName", 0x4D60CE00, TdfType.String, 3, true), // svcn
        new TdfMemberInfo("ClientType", "mClientType", 0x51940500, TdfType.Enum, 4, true), // type
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _country = new(__typeInfos[0]);
    private TdfBool _ignoreInactivityTimeout = new(__typeInfos[1]);
    private TdfUInt32 _locale = new(__typeInfos[2]);
    private TdfString _serviceName = new(__typeInfos[3]);
    private TdfEnum<Blaze15SDK.Blaze.ClientType> _clientType = new(__typeInfos[4]);

    public ClientData()
    {
        __members = [ _country, _ignoreInactivityTimeout, _locale, _serviceName, _clientType ];
    }

    public override Tdf CreateNew() => new ClientData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClientData";
    public override string GetFullClassName() => "Blaze::GameManager::ClientData";

    public uint Country
    {
        get => _country.Value;
        set => _country.Value = value;
    }

    public bool IgnoreInactivityTimeout
    {
        get => _ignoreInactivityTimeout.Value;
        set => _ignoreInactivityTimeout.Value = value;
    }

    public uint Locale
    {
        get => _locale.Value;
        set => _locale.Value = value;
    }

    public string ServiceName
    {
        get => _serviceName.Value;
        set => _serviceName.Value = value;
    }

    public Blaze15SDK.Blaze.ClientType ClientType
    {
        get => _clientType.Value;
        set => _clientType.Value = value;
    }

}
