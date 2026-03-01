using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Social.Friends;

public class PagedListUser : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Entries", "mEntries", 0x14E51200, TdfType.List, 0, true), // entr
        new TdfMemberInfo("PagingInfo", "mPagingInfo", 0x40938600, TdfType.Struct, 1, true), // pinf
    ];
    private ITdfMember[] __members;

    private TdfList<User> _entries = new(__typeInfos[0]);
    private TdfStruct<PagingInfo?> _pagingInfo = new(__typeInfos[1]);

    public PagedListUser()
    {
        __members = [ _entries, _pagingInfo ];
    }

    public override Tdf CreateNew() => new PagedListUser();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PagedListUser";
    public override string GetFullClassName() => "Blaze::Social::Friends::PagedListUser";

    public IList<User> Entries
    {
        get => _entries.Value;
        set => _entries.Value = value;
    }

    public PagingInfo? PagingInfo
    {
        get => _pagingInfo.Value;
        set => _pagingInfo.Value = value;
    }

}
