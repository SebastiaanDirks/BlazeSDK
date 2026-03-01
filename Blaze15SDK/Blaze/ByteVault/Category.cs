using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.ByteVault;

public class Category : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CategoryName", "mCategoryName", 0x0C150000, TdfType.String, 0, true), // cat
        new TdfMemberInfo("Configuration", "mConfiguration", 0x0CF38600, TdfType.Struct, 1, true), // conf
        new TdfMemberInfo("CreationTime", "mCreationTime", 0x0D214100, TdfType.Int64, 2, true), // crea
        new TdfMemberInfo("DeletedRecordCountByName", "mDeletedRecordCountByName", 0x10339400, TdfType.Map, 3, true), // dcnt
        new TdfMemberInfo("Deleted", "mDeleted", 0x10530000, TdfType.Bool, 4, true), // del
        new TdfMemberInfo("Description", "mDescription", 0x1054C300, TdfType.String, 5, true), // desc
        new TdfMemberInfo("NumOfDeletedRecords", "mNumOfDeletedRecords", 0x10C51300, TdfType.Int64, 6, true), // dlts
        new TdfMemberInfo("RecordCountByName", "mRecordCountByName", 0x48339400, TdfType.Map, 7, true), // rcnt
        new TdfMemberInfo("NumOfRecords", "mNumOfRecords", 0x4850D300, TdfType.Int64, 8, true), // recs
        new TdfMemberInfo("TrustedSources", "mTrustedSources", 0x5124D400, TdfType.List, 9, true), // trst
        new TdfMemberInfo("LastUpdateTime", "mLastUpdateTime", 0x55011400, TdfType.Int64, 10, true), // updt
    ];
    private ITdfMember[] __members;

    private TdfString _categoryName = new(__typeInfos[0]);
    private TdfStruct<CategorySettings?> _configuration = new(__typeInfos[1]);
    private TdfInt64 _creationTime = new(__typeInfos[2]);
    private TdfMap<string, long> _deletedRecordCountByName = new(__typeInfos[3]);
    private TdfBool _deleted = new(__typeInfos[4]);
    private TdfString _description = new(__typeInfos[5]);
    private TdfInt64 _numOfDeletedRecords = new(__typeInfos[6]);
    private TdfMap<string, long> _recordCountByName = new(__typeInfos[7]);
    private TdfInt64 _numOfRecords = new(__typeInfos[8]);
    private TdfList<string> _trustedSources = new(__typeInfos[9]);
    private TdfInt64 _lastUpdateTime = new(__typeInfos[10]);

    public Category()
    {
        __members = [ _categoryName, _configuration, _creationTime, _deletedRecordCountByName, _deleted, _description, _numOfDeletedRecords, _recordCountByName, _numOfRecords, _trustedSources, _lastUpdateTime ];
    }

    public override Tdf CreateNew() => new Category();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "Category";
    public override string GetFullClassName() => "Blaze::ByteVault::Category";

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

    public IDictionary<string, long> DeletedRecordCountByName
    {
        get => _deletedRecordCountByName.Value;
        set => _deletedRecordCountByName.Value = value;
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

    public long NumOfDeletedRecords
    {
        get => _numOfDeletedRecords.Value;
        set => _numOfDeletedRecords.Value = value;
    }

    public IDictionary<string, long> RecordCountByName
    {
        get => _recordCountByName.Value;
        set => _recordCountByName.Value = value;
    }

    public long NumOfRecords
    {
        get => _numOfRecords.Value;
        set => _numOfRecords.Value = value;
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
