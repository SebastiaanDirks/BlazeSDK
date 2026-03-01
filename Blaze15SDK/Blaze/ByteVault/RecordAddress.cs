using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.ByteVault;

public class RecordAddress : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CategoryName", "mCategoryName", 0x0C150000, TdfType.String, 0, true), // cat
        new TdfMemberInfo("Context", "mContext", 0x0D461400, TdfType.String, 1, true), // ctxt
        new TdfMemberInfo("Owner", "mOwner", 0x3D739200, TdfType.Struct, 2, true), // ownr
        new TdfMemberInfo("RecordName", "mRecordName", 0x4850C000, TdfType.String, 3, true), // rec
    ];
    private ITdfMember[] __members;

    private TdfString _categoryName = new(__typeInfos[0]);
    private TdfString _context = new(__typeInfos[1]);
    private TdfStruct<User?> _owner = new(__typeInfos[2]);
    private TdfString _recordName = new(__typeInfos[3]);

    public RecordAddress()
    {
        __members = [ _categoryName, _context, _owner, _recordName ];
    }

    public override Tdf CreateNew() => new RecordAddress();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RecordAddress";
    public override string GetFullClassName() => "Blaze::ByteVault::RecordAddress";

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

}
