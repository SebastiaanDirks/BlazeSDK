using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.ByteVault;

public class GetCategoriesResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Categories", "mCategories", 0x3094D400, TdfType.List, 0, true), // list
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze15SDK.Blaze.ByteVault.Category> _categories = new(__typeInfos[0]);

    public GetCategoriesResponse()
    {
        __members = [ _categories ];
    }

    public override Tdf CreateNew() => new GetCategoriesResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetCategoriesResponse";
    public override string GetFullClassName() => "Blaze::ByteVault::GetCategoriesResponse";

    public IList<Blaze15SDK.Blaze.ByteVault.Category> Categories
    {
        get => _categories.Value;
        set => _categories.Value = value;
    }

}
