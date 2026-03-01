using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Redirector;

public class ServerAddressInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Address", "mAddress", 0x04411200, TdfType.Struct, 0, true), // addr
        new TdfMemberInfo("Type", "mType", 0x51940500, TdfType.Enum, 1, true), // type
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.Redirector.ServerAddress?> _address = new(__typeInfos[0]);
    private TdfEnum<Blaze15SDK.Blaze.Redirector.ServerAddressType> _type = new(__typeInfos[1]);

    public ServerAddressInfo()
    {
        __members = [ _address, _type ];
    }

    public override Tdf CreateNew() => new ServerAddressInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ServerAddressInfo";
    public override string GetFullClassName() => "Blaze::GameManager::ServerAddressInfo";

    public Blaze15SDK.Blaze.Redirector.ServerAddress? Address
    {
        get => _address.Value;
        set => _address.Value = value;
    }

    public Blaze15SDK.Blaze.Redirector.ServerAddressType Type
    {
        get => _type.Value;
        set => _type.Value = value;
    }

}
