using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.ByteVault;

public class Context : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RecordCountByCategory", "mRecordCountByCategory", 0x04339400, TdfType.Map, 0, true), // acnt
        new TdfMemberInfo("DataAdmins", "mDataAdmins", 0x0C110D00, TdfType.List, 1, true), // cadm
        new TdfMemberInfo("CreationTime", "mCreationTime", 0x0D214100, TdfType.Int64, 2, true), // crea
        new TdfMemberInfo("DevAdmins", "mDevAdmins", 0x10110D00, TdfType.List, 3, true), // dadm
        new TdfMemberInfo("DeletedRecordCountByCategory", "mDeletedRecordCountByCategory", 0x10339400, TdfType.Map, 4, true), // dcnt
        new TdfMemberInfo("Deleted", "mDeleted", 0x10530000, TdfType.Bool, 5, true), // del
        new TdfMemberInfo("Description", "mDescription", 0x1054C300, TdfType.String, 6, true), // desc
        new TdfMemberInfo("NumOfDeletedRecords", "mNumOfDeletedRecords", 0x10C51300, TdfType.Int64, 7, true), // dlts
        new TdfMemberInfo("Label", "mLabel", 0x30108C00, TdfType.String, 8, true), // labl
        new TdfMemberInfo("Name", "mName", 0x38134500, TdfType.String, 9, true), // name
        new TdfMemberInfo("RecordNamesCountByCategory", "mRecordNamesCountByCategory", 0x48339400, TdfType.Map, 10, true), // rcnt
        new TdfMemberInfo("NumOfRecords", "mNumOfRecords", 0x4850D300, TdfType.Int64, 11, true), // recs
        new TdfMemberInfo("LastUpdateTime", "mLastUpdateTime", 0x55011400, TdfType.Int64, 12, true), // updt
        new TdfMemberInfo("Version", "mVersion", 0x58549300, TdfType.UInt32, 13, true), // vers
    ];
    private ITdfMember[] __members;

    private TdfMap<string, long> _recordCountByCategory = new(__typeInfos[0]);
    private TdfList<string> _dataAdmins = new(__typeInfos[1]);
    private TdfInt64 _creationTime = new(__typeInfos[2]);
    private TdfList<string> _devAdmins = new(__typeInfos[3]);
    private TdfMap<string, long> _deletedRecordCountByCategory = new(__typeInfos[4]);
    private TdfBool _deleted = new(__typeInfos[5]);
    private TdfString _description = new(__typeInfos[6]);
    private TdfInt64 _numOfDeletedRecords = new(__typeInfos[7]);
    private TdfString _label = new(__typeInfos[8]);
    private TdfString _name = new(__typeInfos[9]);
    private TdfMap<string, long> _recordNamesCountByCategory = new(__typeInfos[10]);
    private TdfInt64 _numOfRecords = new(__typeInfos[11]);
    private TdfInt64 _lastUpdateTime = new(__typeInfos[12]);
    private TdfUInt32 _version = new(__typeInfos[13]);

    public Context()
    {
        __members = [ _recordCountByCategory, _dataAdmins, _creationTime, _devAdmins, _deletedRecordCountByCategory, _deleted, _description, _numOfDeletedRecords, _label, _name, _recordNamesCountByCategory, _numOfRecords, _lastUpdateTime, _version ];
    }

    public override Tdf CreateNew() => new Context();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "Context";
    public override string GetFullClassName() => "Blaze::ByteVault::Context";

    public IDictionary<string, long> RecordCountByCategory
    {
        get => _recordCountByCategory.Value;
        set => _recordCountByCategory.Value = value;
    }

    public IList<string> DataAdmins
    {
        get => _dataAdmins.Value;
        set => _dataAdmins.Value = value;
    }

    public long CreationTime
    {
        get => _creationTime.Value;
        set => _creationTime.Value = value;
    }

    public IList<string> DevAdmins
    {
        get => _devAdmins.Value;
        set => _devAdmins.Value = value;
    }

    public IDictionary<string, long> DeletedRecordCountByCategory
    {
        get => _deletedRecordCountByCategory.Value;
        set => _deletedRecordCountByCategory.Value = value;
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

    public string Label
    {
        get => _label.Value;
        set => _label.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public IDictionary<string, long> RecordNamesCountByCategory
    {
        get => _recordNamesCountByCategory.Value;
        set => _recordNamesCountByCategory.Value = value;
    }

    public long NumOfRecords
    {
        get => _numOfRecords.Value;
        set => _numOfRecords.Value = value;
    }

    public long LastUpdateTime
    {
        get => _lastUpdateTime.Value;
        set => _lastUpdateTime.Value = value;
    }

    public uint Version
    {
        get => _version.Value;
        set => _version.Value = value;
    }

}
