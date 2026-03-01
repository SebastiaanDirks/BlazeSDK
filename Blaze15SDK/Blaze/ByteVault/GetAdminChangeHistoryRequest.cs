using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.ByteVault;

public class GetAdminChangeHistoryRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AdminEmail", "mAdminEmail", 0x04434E00, TdfType.String, 0, true), // admn
        new TdfMemberInfo("AuthCredentials", "mAuthCredentials", 0x05550800, TdfType.Struct, 1, true), // auth
        new TdfMemberInfo("CategoryName", "mCategoryName", 0x0C150000, TdfType.String, 2, true), // cat
        new TdfMemberInfo("Context", "mContext", 0x0D461400, TdfType.String, 3, true), // ctxt
        new TdfMemberInfo("EndDate", "mEndDate", 0x14E10000, TdfType.Int64, 4, true), // end
        new TdfMemberInfo("MaxResultCount", "mMaxResultCount", 0x35848300, TdfType.UInt32, 5, true), // mxrc
        new TdfMemberInfo("Offset", "mOffset", 0x3C619300, TdfType.UInt32, 6, true), // offs
        new TdfMemberInfo("RecordName", "mRecordName", 0x4850C000, TdfType.String, 7, true), // rec
        new TdfMemberInfo("StartDate", "mStartDate", 0x4D449400, TdfType.Int64, 8, true), // strt
        new TdfMemberInfo("Action", "mAction", 0x51940500, TdfType.Enum, 9, true), // type
    ];
    private ITdfMember[] __members;

    private TdfString _adminEmail = new(__typeInfos[0]);
    private TdfStruct<Blaze15SDK.Blaze.ByteVault.AuthenticationCredentials?> _authCredentials = new(__typeInfos[1]);
    private TdfString _categoryName = new(__typeInfos[2]);
    private TdfString _context = new(__typeInfos[3]);
    private TdfInt64 _endDate = new(__typeInfos[4]);
    private TdfUInt32 _maxResultCount = new(__typeInfos[5]);
    private TdfUInt32 _offset = new(__typeInfos[6]);
    private TdfString _recordName = new(__typeInfos[7]);
    private TdfInt64 _startDate = new(__typeInfos[8]);
    private TdfEnum<ActionType> _action = new(__typeInfos[9]);

    public GetAdminChangeHistoryRequest()
    {
        __members = [ _adminEmail, _authCredentials, _categoryName, _context, _endDate, _maxResultCount, _offset, _recordName, _startDate, _action ];
    }

    public override Tdf CreateNew() => new GetAdminChangeHistoryRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetAdminChangeHistoryRequest";
    public override string GetFullClassName() => "Blaze::ByteVault::GetAdminChangeHistoryRequest";

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

    public long EndDate
    {
        get => _endDate.Value;
        set => _endDate.Value = value;
    }

    public uint MaxResultCount
    {
        get => _maxResultCount.Value;
        set => _maxResultCount.Value = value;
    }

    public uint Offset
    {
        get => _offset.Value;
        set => _offset.Value = value;
    }

    public string RecordName
    {
        get => _recordName.Value;
        set => _recordName.Value = value;
    }

    public long StartDate
    {
        get => _startDate.Value;
        set => _startDate.Value = value;
    }

    public ActionType Action
    {
        get => _action.Value;
        set => _action.Value = value;
    }

}
