using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Clubs;

public class MemberOnlineStatusClass : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MemberOnlineStatus", "mMemberOnlineStatus", 0x34F4D400, TdfType.Enum, 0, true), // most
        new TdfMemberInfo("MembershipStatus", "mMembershipStatus", 0x3534D400, TdfType.Enum, 1, true), // msst
    ];
    private ITdfMember[] __members;

    private TdfEnum<MemberOnlineStatus> _memberOnlineStatus = new(__typeInfos[0]);
    private TdfEnum<MembershipStatus> _membershipStatus = new(__typeInfos[1]);

    public MemberOnlineStatusClass()
    {
        __members = [ _memberOnlineStatus, _membershipStatus ];
    }

    public override Tdf CreateNew() => new MemberOnlineStatusClass();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "MemberOnlineStatusClass";
    public override string GetFullClassName() => "Blaze::Clubs::MemberOnlineStatusClass";

    public MemberOnlineStatus MemberOnlineStatus
    {
        get => _memberOnlineStatus.Value;
        set => _memberOnlineStatus.Value = value;
    }

    public MembershipStatus MembershipStatus
    {
        get => _membershipStatus.Value;
        set => _membershipStatus.Value = value;
    }

}
