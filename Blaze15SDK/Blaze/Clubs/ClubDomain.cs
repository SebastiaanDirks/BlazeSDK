using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Clubs;

public class ClubDomain : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AllowMemberToRetrievePassword", "mAllowMemberToRetrievePassword", 0x04D49000, TdfType.Bool, 0, true), // amrp
        new TdfMemberInfo("ClubDomainId", "mClubDomainId", 0x10D24400, TdfType.UInt32, 1, true), // dmid
        new TdfMemberInfo("DomainName", "mDomainName", 0x10E04D00, TdfType.String, 2, true), // dnam
        new TdfMemberInfo("TrackMembershipInUED", "mTrackMembershipInUED", 0x11514400, TdfType.Bool, 3, true), // dued
        new TdfMemberInfo("MaxGMsPerClub", "mMaxGMsPerClub", 0x1181CD00, TdfType.UInt16, 4, true), // dxgm
        new TdfMemberInfo("MaxInactiveDaysPerClub", "mMaxInactiveDaysPerClub", 0x11824100, TdfType.UInt16, 5, true), // dxia
        new TdfMemberInfo("MaxInvitationsPerUserOrClub", "mMaxInvitationsPerUserOrClub", 0x11825600, TdfType.UInt16, 6, true), // dxiv
        new TdfMemberInfo("MaxMembersPerClub", "mMaxMembersPerClub", 0x11834200, TdfType.UInt32, 7, true), // dxmb
        new TdfMemberInfo("MaxMembershipsPerUser", "mMaxMembershipsPerUser", 0x11835300, TdfType.UInt16, 8, true), // dxms
        new TdfMemberInfo("MaxNewsItemsPerClub", "mMaxNewsItemsPerClub", 0x11839700, TdfType.UInt16, 9, true), // dxnw
        new TdfMemberInfo("ClubJumpingInterval", "mClubJumpingInterval", 0x28951600, TdfType.TimeValue, 10, true), // jitv
    ];
    private ITdfMember[] __members;

    private TdfBool _allowMemberToRetrievePassword = new(__typeInfos[0]);
    private TdfUInt32 _clubDomainId = new(__typeInfos[1]);
    private TdfString _domainName = new(__typeInfos[2]);
    private TdfBool _trackMembershipInUED = new(__typeInfos[3]);
    private TdfUInt16 _maxGMsPerClub = new(__typeInfos[4]);
    private TdfUInt16 _maxInactiveDaysPerClub = new(__typeInfos[5]);
    private TdfUInt16 _maxInvitationsPerUserOrClub = new(__typeInfos[6]);
    private TdfUInt32 _maxMembersPerClub = new(__typeInfos[7]);
    private TdfUInt16 _maxMembershipsPerUser = new(__typeInfos[8]);
    private TdfUInt16 _maxNewsItemsPerClub = new(__typeInfos[9]);
    private TdfTimeValue _clubJumpingInterval = new(__typeInfos[10]);

    public ClubDomain()
    {
        __members = [
            _allowMemberToRetrievePassword,
            _clubDomainId,
            _domainName,
            _trackMembershipInUED,
            _maxGMsPerClub,
            _maxInactiveDaysPerClub,
            _maxInvitationsPerUserOrClub,
            _maxMembersPerClub,
            _maxMembershipsPerUser,
            _maxNewsItemsPerClub,
            _clubJumpingInterval,
        ];
    }

    public override Tdf CreateNew() => new ClubDomain();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClubDomain";
    public override string GetFullClassName() => "Blaze::Clubs::ClubDomain";

    public bool AllowMemberToRetrievePassword
    {
        get => _allowMemberToRetrievePassword.Value;
        set => _allowMemberToRetrievePassword.Value = value;
    }

    public uint ClubDomainId
    {
        get => _clubDomainId.Value;
        set => _clubDomainId.Value = value;
    }

    public string DomainName
    {
        get => _domainName.Value;
        set => _domainName.Value = value;
    }

    public bool TrackMembershipInUED
    {
        get => _trackMembershipInUED.Value;
        set => _trackMembershipInUED.Value = value;
    }

    public ushort MaxGMsPerClub
    {
        get => _maxGMsPerClub.Value;
        set => _maxGMsPerClub.Value = value;
    }

    public ushort MaxInactiveDaysPerClub
    {
        get => _maxInactiveDaysPerClub.Value;
        set => _maxInactiveDaysPerClub.Value = value;
    }

    public ushort MaxInvitationsPerUserOrClub
    {
        get => _maxInvitationsPerUserOrClub.Value;
        set => _maxInvitationsPerUserOrClub.Value = value;
    }

    public uint MaxMembersPerClub
    {
        get => _maxMembersPerClub.Value;
        set => _maxMembersPerClub.Value = value;
    }

    public ushort MaxMembershipsPerUser
    {
        get => _maxMembershipsPerUser.Value;
        set => _maxMembershipsPerUser.Value = value;
    }

    public ushort MaxNewsItemsPerClub
    {
        get => _maxNewsItemsPerClub.Value;
        set => _maxNewsItemsPerClub.Value = value;
    }

    public TimeValue ClubJumpingInterval
    {
        get => _clubJumpingInterval.Value;
        set => _clubJumpingInterval.Value = value;
    }

}
