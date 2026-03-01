using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Social.Friends;

public class User : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DisplayName", "mDisplayName", 0x11038D00, TdfType.String, 0, true), // dpnm
        new TdfMemberInfo("DateTime", "mDateTime", 0x11450D00, TdfType.String, 1, true), // dttm
        new TdfMemberInfo("FriendType", "mFriendType", 0x19465000, TdfType.String, 2, true), // ftyp
        new TdfMemberInfo("Favorite", "mFavorite", 0x19649400, TdfType.Bool, 3, true), // fvrt
        new TdfMemberInfo("PersonaId", "mPersonaId", 0x40E24400, TdfType.Int64, 4, true), // pnid
        new TdfMemberInfo("Source", "mSource", 0x4CF48300, TdfType.String, 5, true), // sorc
        new TdfMemberInfo("Timestamp", "mTimestamp", 0x50D4D400, TdfType.Int64, 6, true), // tmst
        new TdfMemberInfo("UserId", "mUserId", 0x54E24400, TdfType.Int64, 7, true), // unid
    ];
    private ITdfMember[] __members;

    private TdfString _displayName = new(__typeInfos[0]);
    private TdfString _dateTime = new(__typeInfos[1]);
    private TdfString _friendType = new(__typeInfos[2]);
    private TdfBool _favorite = new(__typeInfos[3]);
    private TdfInt64 _personaId = new(__typeInfos[4]);
    private TdfString _source = new(__typeInfos[5]);
    private TdfInt64 _timestamp = new(__typeInfos[6]);
    private TdfInt64 _userId = new(__typeInfos[7]);

    public User()
    {
        __members = [ _displayName, _dateTime, _friendType, _favorite, _personaId, _source, _timestamp, _userId ];
    }

    public override Tdf CreateNew() => new User();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "User";
    public override string GetFullClassName() => "Blaze::Social::Friends::User";

    public string DisplayName
    {
        get => _displayName.Value;
        set => _displayName.Value = value;
    }

    public string DateTime
    {
        get => _dateTime.Value;
        set => _dateTime.Value = value;
    }

    public string FriendType
    {
        get => _friendType.Value;
        set => _friendType.Value = value;
    }

    public bool Favorite
    {
        get => _favorite.Value;
        set => _favorite.Value = value;
    }

    public long PersonaId
    {
        get => _personaId.Value;
        set => _personaId.Value = value;
    }

    public string Source
    {
        get => _source.Value;
        set => _source.Value = value;
    }

    public long Timestamp
    {
        get => _timestamp.Value;
        set => _timestamp.Value = value;
    }

    public long UserId
    {
        get => _userId.Value;
        set => _userId.Value = value;
    }

}
