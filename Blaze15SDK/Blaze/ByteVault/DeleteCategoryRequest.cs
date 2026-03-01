using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.ByteVault;

public class DeleteCategoryRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AuthCredentials", "mAuthCredentials", 0x05550800, TdfType.Struct, 0, true), // auth
        new TdfMemberInfo("CategoryName", "mCategoryName", 0x0C150000, TdfType.String, 1, true), // cat
        new TdfMemberInfo("Context", "mContext", 0x0D461400, TdfType.String, 2, true), // ctxt
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.ByteVault.AuthenticationCredentials?> _authCredentials = new(__typeInfos[0]);
    private TdfString _categoryName = new(__typeInfos[1]);
    private TdfString _context = new(__typeInfos[2]);

    public DeleteCategoryRequest()
    {
        __members = [ _authCredentials, _categoryName, _context ];
    }

    public override Tdf CreateNew() => new DeleteCategoryRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "DeleteCategoryRequest";
    public override string GetFullClassName() => "Blaze::ByteVault::DeleteCategoryRequest";

    public Blaze15SDK.Blaze.ByteVault.AuthenticationCredentials? AuthCredentials
    {
        get => _authCredentials.Value;
        set => _authCredentials.Value = value;
    }

    public string CategoryName
    {
        get => _categoryName.Value;
        set => _categoryName.Value = value;
    }

    public string Context
    {
        get => _context.Value;
        set => _context.Value = value;
    }

}
