using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Util;

public class UserSettingsLoadRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Key", "mKey", 0x2C564000, TdfType.String, 0, true), // key
        new TdfMemberInfo("BlazeId", "mBlazeId", 0x54910000, TdfType.Int64, 1, true), // uid
    ];
    private ITdfMember[] __members;

    private TdfString _key = new(__typeInfos[0]);
    private TdfInt64 _blazeId = new(__typeInfos[1]);

    public UserSettingsLoadRequest()
    {
        __members = [ _key, _blazeId ];
    }

    public override Tdf CreateNew() => new UserSettingsLoadRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UserSettingsLoadRequest";
    public override string GetFullClassName() => "Blaze::GameManager::UserSettingsLoadRequest";

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
