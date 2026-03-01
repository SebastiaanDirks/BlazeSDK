using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.ByteVault;

public class CategoryHistory : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CategoryName", "mCategoryName", 0x0C150000, TdfType.String, 0, true), // cat
        new TdfMemberInfo("Configuration", "mConfiguration", 0x0CF38600, TdfType.Struct, 1, true), // conf
        new TdfMemberInfo("CreationTime", "mCreationTime", 0x0D214100, TdfType.Int64, 2, true), // crea
        new TdfMemberInfo("Deleted", "mDeleted", 0x10530000, TdfType.Bool, 3, true), // del
        new TdfMemberInfo("Description", "mDescription", 0x1054C300, TdfType.String, 4, true), // desc
        new TdfMemberInfo("TrustedSources", "mTrustedSources", 0x5124D400, TdfType.List, 5, true), // trst
        new TdfMemberInfo("LastUpdateTime", "mLastUpdateTime", 0x55011400, TdfType.Int64, 6, true), // updt
    ];
    private ITdfMember[] __members;

    private TdfString _categoryName = new(__typeInfos[0]);
    private TdfStruct<CategorySettings?> _configuration = new(__typeInfos[1]);
    private TdfInt64 _creationTime = new(__typeInfos[2]);
    private TdfBool _deleted = new(__typeInfos[3]);
    private TdfString _description = new(__typeInfos[4]);
    private TdfList<string> _trustedSources = new(__typeInfos[5]);
    private TdfInt64 _lastUpdateTime = new(__typeInfos[6]);

    public CategoryHistory()
    {
        __members = [ _categoryName, _configuration, _creationTime, _deleted, _description, _trustedSources, _lastUpdateTime ];
    }

    public override Tdf CreateNew() => new CategoryHistory();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CategoryHistory";
    public override string GetFullClassName() => "Blaze::ByteVault::CategoryHistory";

    public string CategoryName
    {
        get => _categoryName.Value;
        set => _categoryName.Value = value;
    }

    public CategorySettings? Configuration
    {
        get => _configuration.Value;
        set => _configuration.Value = value;
    }

    public long CreationTime
    {
        get => _creationTime.Value;
        set => _creationTime.Value = value;
    }

    public bool Deleted
    {
        get => _deleted.Value;
        set => _deleted.Value = value;
    }

    public string Description
    {
        get => _description.Value;
        set => _description.Value = value;
    }

    public IList<string> TrustedSources
    {
        get => _trustedSources.Value;
        set => _trustedSources.Value = value;
    }

    public long LastUpdateTime
    {
        get => _lastUpdateTime.Value;
        set => _lastUpdateTime.Value = value;
    }

}
