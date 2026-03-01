using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.ByteVault;

public class UpsertContextRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AuthCredentials", "mAuthCredentials", 0x05550800, TdfType.Struct, 0, true), // auth
        new TdfMemberInfo("Context", "mContext", 0x0D461400, TdfType.String, 1, true), // ctxt
        new TdfMemberInfo("Description", "mDescription", 0x1054C300, TdfType.String, 2, true), // desc
        new TdfMemberInfo("Label", "mLabel", 0x30108C00, TdfType.String, 3, true), // labl
        new TdfMemberInfo("Version", "mVersion", 0x58549300, TdfType.UInt32, 4, true), // vers
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.ByteVault.AuthenticationCredentials?> _authCredentials = new(__typeInfos[0]);
    private TdfString _context = new(__typeInfos[1]);
    private TdfString _description = new(__typeInfos[2]);
    private TdfString _label = new(__typeInfos[3]);
    private TdfUInt32 _version = new(__typeInfos[4]);

    public UpsertContextRequest()
    {
        __members = [ _authCredentials, _context, _description, _label, _version ];
    }

    public override Tdf CreateNew() => new UpsertContextRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpsertContextRequest";
    public override string GetFullClassName() => "Blaze::ByteVault::UpsertContextRequest";

    public Blaze15SDK.Blaze.ByteVault.AuthenticationCredentials? AuthCredentials
    {
        get => _authCredentials.Value;
        set => _authCredentials.Value = value;
    }

    public string Context
    {
        get => _context.Value;
        set => _context.Value = value;
    }

    public string Description
    {
        get => _description.Value;
        set => _description.Value = value;
    }

    public string Label
    {
        get => _label.Value;
        set => _label.Value = value;
    }

    public uint Version
    {
        get => _version.Value;
        set => _version.Value = value;
    }

}
