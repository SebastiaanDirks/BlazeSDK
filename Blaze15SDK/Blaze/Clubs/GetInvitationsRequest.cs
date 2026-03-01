using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Clubs;

public class GetInvitationsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x0CC24400, TdfType.UInt64, 0, true), // clid
        new TdfMemberInfo("InvitationsType", "mInvitationsType", 0x24E59400, TdfType.Enum, 1, true), // invt
        new TdfMemberInfo("SortType", "mSortType", 0x3933D400, TdfType.Enum, 2, true), // nsot
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _clubId = new(__typeInfos[0]);
    private TdfEnum<InvitationsType> _invitationsType = new(__typeInfos[1]);
    private TdfEnum<TimeSortType> _sortType = new(__typeInfos[2]);

    public GetInvitationsRequest()
    {
        __members = [ _clubId, _invitationsType, _sortType ];
    }

    public override Tdf CreateNew() => new GetInvitationsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetInvitationsRequest";
    public override string GetFullClassName() => "Blaze::Clubs::GetInvitationsRequest";

    public ulong ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public InvitationsType InvitationsType
    {
        get => _invitationsType.Value;
        set => _invitationsType.Value = value;
    }

    public TimeSortType SortType
    {
        get => _sortType.Value;
        set => _sortType.Value = value;
    }

}
