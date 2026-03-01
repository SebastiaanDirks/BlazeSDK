using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Util;

public class UserSettingsResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Data", "mData", 0x10150100, TdfType.String, 0, true), // data
        new TdfMemberInfo("Key", "mKey", 0x2C564000, TdfType.String, 1, true), // key
    ];
    private ITdfMember[] __members;

    private TdfString _data = new(__typeInfos[0]);
    private TdfString _key = new(__typeInfos[1]);

    public UserSettingsResponse()
    {
        __members = [ _data, _key ];
    }

    public override Tdf CreateNew() => new UserSettingsResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UserSettingsResponse";
    public override string GetFullClassName() => "Blaze::GameManager::UserSettingsResponse";

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

}
