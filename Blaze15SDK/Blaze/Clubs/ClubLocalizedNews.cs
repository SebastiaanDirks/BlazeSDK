using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Clubs;

public class ClubLocalizedNews : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AssociateClubId", "mAssociateClubId", 0x0CC24400, TdfType.UInt64, 0, true), // clid
        new TdfMemberInfo("Text", "mText", 0x39461400, TdfType.String, 1, true), // ntxt
        new TdfMemberInfo("Flags", "mFlags", 0x39718C00, TdfType.Enum, 2, true), // nwfl
        new TdfMemberInfo("NewsId", "mNewsId", 0x39724400, TdfType.ObjectId, 3, true), // nwid
        new TdfMemberInfo("Type", "mType", 0x39751900, TdfType.Enum, 4, true), // nwty
        new TdfMemberInfo("Timestamp", "mTimestamp", 0x50D4D400, TdfType.UInt32, 5, true), // tmst
        new TdfMemberInfo("User", "mUser", 0x55315200, TdfType.Struct, 6, true), // user
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _associateClubId = new(__typeInfos[0]);
    private TdfString _text = new(__typeInfos[1]);
    private TdfEnum<ClubNewsFlags> _flags = new(__typeInfos[2]);
    private TdfObjectId _newsId = new(__typeInfos[3]);
    private TdfEnum<NewsType> _type = new(__typeInfos[4]);
    private TdfUInt32 _timestamp = new(__typeInfos[5]);
    private TdfStruct<Blaze15SDK.Blaze.CoreIdentification?> _user = new(__typeInfos[6]);

    public ClubLocalizedNews()
    {
        __members = [ _associateClubId, _text, _flags, _newsId, _type, _timestamp, _user ];
    }

    public override Tdf CreateNew() => new ClubLocalizedNews();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClubLocalizedNews";
    public override string GetFullClassName() => "Blaze::Clubs::ClubLocalizedNews";

    public ulong AssociateClubId
    {
        get => _associateClubId.Value;
        set => _associateClubId.Value = value;
    }

    public string Text
    {
        get => _text.Value;
        set => _text.Value = value;
    }

    public ClubNewsFlags Flags
    {
        get => _flags.Value;
        set => _flags.Value = value;
    }

    public ObjectId NewsId
    {
        get => _newsId.Value;
        set => _newsId.Value = value;
    }

    public NewsType Type
    {
        get => _type.Value;
        set => _type.Value = value;
    }

    public uint Timestamp
    {
        get => _timestamp.Value;
        set => _timestamp.Value = value;
    }

    public Blaze15SDK.Blaze.CoreIdentification? User
    {
        get => _user.Value;
        set => _user.Value = value;
    }

}
