using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.ByteVault;

public class CategorySettings : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AllRecordsEditable", "mAllRecordsEditable", 0x04C30500, TdfType.Bool, 0, true), // alle
        new TdfMemberInfo("EditableRecordNames", "mEditableRecordNames", 0x14425400, TdfType.List, 1, true), // edit
        new TdfMemberInfo("GlobalPermission", "mGlobalPermission", 0x1D048D00, TdfType.Struct, 2, true), // gprm
        new TdfMemberInfo("History", "mHistory", 0x2094D400, TdfType.Struct, 3, true), // hist
        new TdfMemberInfo("AccessPermission", "mAccessPermission", 0x40548D00, TdfType.Struct, 4, true), // perm
        new TdfMemberInfo("MaxRecordsPerUser", "mMaxRecordsPerUser", 0x48339400, TdfType.UInt64, 5, true), // rcnt
        new TdfMemberInfo("MaxRecordPayloadSize", "mMaxRecordPayloadSize", 0x49325A00, TdfType.UInt64, 6, true), // rsiz
        new TdfMemberInfo("Version", "mVersion", 0x58549300, TdfType.UInt32, 7, true), // vers
    ];
    private ITdfMember[] __members;

    private TdfBool _allRecordsEditable = new(__typeInfos[0]);
    private TdfList<string> _editableRecordNames = new(__typeInfos[1]);
    private TdfStruct<AccessPermission?> _globalPermission = new(__typeInfos[2]);
    private TdfStruct<History?> _history = new(__typeInfos[3]);
    private TdfStruct<AccessPermission?> _accessPermission = new(__typeInfos[4]);
    private TdfUInt64 _maxRecordsPerUser = new(__typeInfos[5]);
    private TdfUInt64 _maxRecordPayloadSize = new(__typeInfos[6]);
    private TdfUInt32 _version = new(__typeInfos[7]);

    public CategorySettings()
    {
        __members = [ _allRecordsEditable, _editableRecordNames, _globalPermission, _history, _accessPermission, _maxRecordsPerUser, _maxRecordPayloadSize, _version ];
    }

    public override Tdf CreateNew() => new CategorySettings();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CategorySettings";
    public override string GetFullClassName() => "Blaze::ByteVault::CategorySettings";

    public bool AllRecordsEditable
    {
        get => _allRecordsEditable.Value;
        set => _allRecordsEditable.Value = value;
    }

    public IList<string> EditableRecordNames
    {
        get => _editableRecordNames.Value;
        set => _editableRecordNames.Value = value;
    }

    public AccessPermission? GlobalPermission
    {
        get => _globalPermission.Value;
        set => _globalPermission.Value = value;
    }

    public History? HistorySettings
    {
        get => _history.Value;
        set => _history.Value = value;
    }

    public AccessPermission? AccessPermissionSettings
    {
        get => _accessPermission.Value;
        set => _accessPermission.Value = value;
    }

    public ulong MaxRecordsPerUser
    {
        get => _maxRecordsPerUser.Value;
        set => _maxRecordsPerUser.Value = value;
    }

    public ulong MaxRecordPayloadSize
    {
        get => _maxRecordPayloadSize.Value;
        set => _maxRecordPayloadSize.Value = value;
    }

    public uint Version
    {
        get => _version.Value;
        set => _version.Value = value;
    }

}
