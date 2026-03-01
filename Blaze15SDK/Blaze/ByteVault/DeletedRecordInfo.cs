using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.ByteVault;

public class DeletedRecordInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CreationTime", "mCreationTime", 0x0D214100, TdfType.Int64, 0, true), // crea
        new TdfMemberInfo("DeletedTime", "mDeletedTime", 0x10531400, TdfType.Int64, 1, true), // delt
        new TdfMemberInfo("Owner", "mOwner", 0x3D739200, TdfType.Struct, 2, true), // ownr
        new TdfMemberInfo("RecordName", "mRecordName", 0x4850C000, TdfType.String, 3, true), // rec
        new TdfMemberInfo("LastUpdateTime", "mLastUpdateTime", 0x55011400, TdfType.Int64, 4, true), // updt
    ];
    private ITdfMember[] __members;

    private TdfInt64 _creationTime = new(__typeInfos[0]);
    private TdfInt64 _deletedTime = new(__typeInfos[1]);
    private TdfStruct<User?> _owner = new(__typeInfos[2]);
    private TdfString _recordName = new(__typeInfos[3]);
    private TdfInt64 _lastUpdateTime = new(__typeInfos[4]);

    public DeletedRecordInfo()
    {
        __members = [ _creationTime, _deletedTime, _owner, _recordName, _lastUpdateTime ];
    }

    public override Tdf CreateNew() => new DeletedRecordInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "DeletedRecordInfo";
    public override string GetFullClassName() => "Blaze::ByteVault::DeletedRecordInfo";

    public long CreationTime
    {
        get => _creationTime.Value;
        set => _creationTime.Value = value;
    }

    public long DeletedTime
    {
        get => _deletedTime.Value;
        set => _deletedTime.Value = value;
    }

    public User? Owner
    {
        get => _owner.Value;
        set => _owner.Value = value;
    }

    public string RecordName
    {
        get => _recordName.Value;
        set => _recordName.Value = value;
    }

    public long LastUpdateTime
    {
        get => _lastUpdateTime.Value;
        set => _lastUpdateTime.Value = value;
    }

}
