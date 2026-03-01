using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Util;

public class UserSettingsSaveRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Data", "mData", 0x10150100, TdfType.String, 0, true), // data
        new TdfMemberInfo("Key", "mKey", 0x2C564000, TdfType.String, 1, true), // key
        new TdfMemberInfo("BlazeId", "mBlazeId", 0x54910000, TdfType.Int64, 2, true), // uid
    ];
    private ITdfMember[] __members;

    private TdfString _data = new(__typeInfos[0]);
    private TdfString _key = new(__typeInfos[1]);
    private TdfInt64 _blazeId = new(__typeInfos[2]);

    public UserSettingsSaveRequest()
    {
        __members = [ _data, _key, _blazeId ];
    }

    public override Tdf CreateNew() => new UserSettingsSaveRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UserSettingsSaveRequest";
    public override string GetFullClassName() => "Blaze::GameManager::UserSettingsSaveRequest";

    public string Data
    {
        get => _data.Value;
        set => _data.Value = value;
    }

    public string Key
    {
        get => _key.Value;
        set => _key.Value = value;
    }

    public long BlazeId
    {
        get => _blazeId.Value;
        set => _blazeId.Value = value;
    }

}
