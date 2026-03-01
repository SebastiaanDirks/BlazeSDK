using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Clubs;

public class CreateClubRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("TagList", "mTagList", 0x0CC50700, TdfType.List, 0, true), // cltg
        new TdfMemberInfo("Name", "mName", 0x0CE04D00, TdfType.String, 1, true), // cnam
        new TdfMemberInfo("ClubSettings", "mClubSettings", 0x0D315400, TdfType.Struct, 2, true), // cset
        new TdfMemberInfo("ClubDomainId", "mClubDomainId", 0x10D24400, TdfType.UInt32, 3, true), // dmid
    ];
    private ITdfMember[] __members;

    private TdfList<string> _tagList = new(__typeInfos[0]);
    private TdfString _name = new(__typeInfos[1]);
    private TdfStruct<ClubSettings?> _clubSettings = new(__typeInfos[2]);
    private TdfUInt32 _clubDomainId = new(__typeInfos[3]);

    public CreateClubRequest()
    {
        __members = [ _tagList, _name, _clubSettings, _clubDomainId ];
    }

    public override Tdf CreateNew() => new CreateClubRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CreateClubRequest";
    public override string GetFullClassName() => "Blaze::Clubs::CreateClubRequest";

    public IList<string> TagList
    {
        get => _tagList.Value;
        set => _tagList.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public ClubSettings? ClubSettings
    {
        get => _clubSettings.Value;
        set => _clubSettings.Value = value;
    }

    public uint ClubDomainId
    {
        get => _clubDomainId.Value;
        set => _clubDomainId.Value = value;
    }

}
