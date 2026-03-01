using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Clubs;

public class ChangeClubStringsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Description", "mDescription", 0x0C44C300, TdfType.String, 0, true), // cdsc
        new TdfMemberInfo("ClubId", "mClubId", 0x0CC24400, TdfType.UInt64, 1, true), // clid
        new TdfMemberInfo("Name", "mName", 0x0CE04D00, TdfType.String, 2, true), // cnam
        new TdfMemberInfo("NonUniqueName", "mNonUniqueName", 0x39544E00, TdfType.String, 3, true), // nuqn
    ];
    private ITdfMember[] __members;

    private TdfString _description = new(__typeInfos[0]);
    private TdfUInt64 _clubId = new(__typeInfos[1]);
    private TdfString _name = new(__typeInfos[2]);
    private TdfString _nonUniqueName = new(__typeInfos[3]);

    public ChangeClubStringsRequest()
    {
        __members = [ _description, _clubId, _name, _nonUniqueName ];
    }

    public override Tdf CreateNew() => new ChangeClubStringsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ChangeClubStringsRequest";
    public override string GetFullClassName() => "Blaze::Clubs::ChangeClubStringsRequest";

    public string Description
    {
        get => _description.Value;
        set => _description.Value = value;
    }

    public ulong ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public string NonUniqueName
    {
        get => _nonUniqueName.Value;
        set => _nonUniqueName.Value = value;
    }

}
