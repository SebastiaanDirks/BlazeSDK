using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.ByteVault;

public class GetAdminRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AdminEmail", "mAdminEmail", 0x04434E00, TdfType.String, 0, true), // admn
        new TdfMemberInfo("AuthCredentials", "mAuthCredentials", 0x05550800, TdfType.Struct, 1, true), // auth
    ];
    private ITdfMember[] __members;

    private TdfString _adminEmail = new(__typeInfos[0]);
    private TdfStruct<Blaze15SDK.Blaze.ByteVault.AuthenticationCredentials?> _authCredentials = new(__typeInfos[1]);

    public GetAdminRequest()
    {
        __members = [ _adminEmail, _authCredentials ];
    }

    public override Tdf CreateNew() => new GetAdminRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetAdminRequest";
    public override string GetFullClassName() => "Blaze::ByteVault::GetAdminRequest";

    public string AdminEmail
    {
        get => _adminEmail.Value;
        set => _adminEmail.Value = value;
    }

    public Blaze15SDK.Blaze.ByteVault.AuthenticationCredentials? AuthCredentials
    {
        get => _authCredentials.Value;
        set => _authCredentials.Value = value;
    }

}
