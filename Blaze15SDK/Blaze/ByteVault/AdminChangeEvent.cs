using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.ByteVault;

public class AdminChangeEvent : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AdminEmail", "mAdminEmail", 0x04434E00, TdfType.String, 0, true), // admn
        new TdfMemberInfo("After", "mAfter", 0x04651200, TdfType.Variable, 1, true), // aftr
        new TdfMemberInfo("Before", "mBefore", 0x08519200, TdfType.Variable, 2, true), // befr
        new TdfMemberInfo("CategoryName", "mCategoryName", 0x0C150000, TdfType.String, 3, true), // cat
        new TdfMemberInfo("Context", "mContext", 0x0D461400, TdfType.String, 4, true), // ctxt
        new TdfMemberInfo("AdminIp", "mAdminIp", 0x25000000, TdfType.String, 5, true), // ip
        new TdfMemberInfo("Timestamp", "mTimestamp", 0x50934500, TdfType.Int64, 6, true), // time
        new TdfMemberInfo("ActionType", "mActionType", 0x51940500, TdfType.Enum, 7, true), // type
    ];
    private ITdfMember[] __members;

    private TdfString _adminEmail = new(__typeInfos[0]);
    private TdfVariable _after = new(__typeInfos[1]);
    private TdfVariable _before = new(__typeInfos[2]);
    private TdfString _categoryName = new(__typeInfos[3]);
    private TdfString _context = new(__typeInfos[4]);
    private TdfString _adminIp = new(__typeInfos[5]);
    private TdfInt64 _timestamp = new(__typeInfos[6]);
    private TdfEnum<ActionType> _actionType = new(__typeInfos[7]);

    public AdminChangeEvent()
    {
        __members = [ _adminEmail, _after, _before, _categoryName, _context, _adminIp, _timestamp, _actionType ];
    }

    public override Tdf CreateNew() => new AdminChangeEvent();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "AdminChangeEvent";
    public override string GetFullClassName() => "Blaze::ByteVault::AdminChangeEvent";

    public string AdminEmail
    {
        get => _adminEmail.Value;
        set => _adminEmail.Value = value;
    }

    public object? After
    {
        get => _after.Value;
        set => _after.Value = value;
    }

    public object? Before
    {
        get => _before.Value;
        set => _before.Value = value;
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

    public string AdminIp
    {
        get => _adminIp.Value;
        set => _adminIp.Value = value;
    }

    public long Timestamp
    {
        get => _timestamp.Value;
        set => _timestamp.Value = value;
    }

    public ActionType ActionType
    {
        get => _actionType.Value;
        set => _actionType.Value = value;
    }

}
