using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Clubs;

public class ClubsCensusData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("NumOfClubsByDomain", "mNumOfClubsByDomain", 0x0C210000, TdfType.Map, 0, true), // cbd
        new TdfMemberInfo("NumOfClubMembersByDomain", "mNumOfClubMembersByDomain", 0x34210000, TdfType.Map, 1, true), // mbd
        new TdfMemberInfo("NumOfOnlineClubsByDomain", "mNumOfOnlineClubsByDomain", 0x3C310000, TdfType.Map, 2, true), // ocd
        new TdfMemberInfo("NumOfOnlineClubMembers", "mNumOfOnlineClubMembers", 0x3C334000, TdfType.UInt32, 3, true), // ocm
        new TdfMemberInfo("NumOfOnlineClubMembersByDomain", "mNumOfOnlineClubMembersByDomain", 0x3CD10000, TdfType.Map, 4, true), // omd
        new TdfMemberInfo("NumOfClubMembers", "mNumOfClubMembers", 0x50334000, TdfType.UInt32, 5, true), // tcm
        new TdfMemberInfo("NumOfClubs", "mNumOfClubs", 0x50E0C000, TdfType.UInt32, 6, true), // tnc
        new TdfMemberInfo("NumOfOnlineClubs", "mNumOfOnlineClubs", 0x50F0C000, TdfType.UInt32, 7, true), // toc
    ];
    private ITdfMember[] __members;

    private TdfMap<uint, uint> _numOfClubsByDomain = new(__typeInfos[0]);
    private TdfMap<uint, uint> _numOfClubMembersByDomain = new(__typeInfos[1]);
    private TdfMap<uint, uint> _numOfOnlineClubsByDomain = new(__typeInfos[2]);
    private TdfUInt32 _numOfOnlineClubMembers = new(__typeInfos[3]);
    private TdfMap<uint, uint> _numOfOnlineClubMembersByDomain = new(__typeInfos[4]);
    private TdfUInt32 _numOfClubMembers = new(__typeInfos[5]);
    private TdfUInt32 _numOfClubs = new(__typeInfos[6]);
    private TdfUInt32 _numOfOnlineClubs = new(__typeInfos[7]);

    public ClubsCensusData()
    {
        __members = [ _numOfClubsByDomain, _numOfClubMembersByDomain, _numOfOnlineClubsByDomain, _numOfOnlineClubMembers, _numOfOnlineClubMembersByDomain, _numOfClubMembers, _numOfClubs, _numOfOnlineClubs ];
    }

    public override Tdf CreateNew() => new ClubsCensusData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClubsCensusData";
    public override string GetFullClassName() => "Blaze::Clubs::ClubsCensusData";

    public IDictionary<uint, uint> NumOfClubsByDomain
    {
        get => _numOfClubsByDomain.Value;
        set => _numOfClubsByDomain.Value = value;
    }

    public IDictionary<uint, uint> NumOfClubMembersByDomain
    {
        get => _numOfClubMembersByDomain.Value;
        set => _numOfClubMembersByDomain.Value = value;
    }

    public IDictionary<uint, uint> NumOfOnlineClubsByDomain
    {
        get => _numOfOnlineClubsByDomain.Value;
        set => _numOfOnlineClubsByDomain.Value = value;
    }

    public uint NumOfOnlineClubMembers
    {
        get => _numOfOnlineClubMembers.Value;
        set => _numOfOnlineClubMembers.Value = value;
    }

    public IDictionary<uint, uint> NumOfOnlineClubMembersByDomain
    {
        get => _numOfOnlineClubMembersByDomain.Value;
        set => _numOfOnlineClubMembersByDomain.Value = value;
    }

    public uint NumOfClubMembers
    {
        get => _numOfClubMembers.Value;
        set => _numOfClubMembers.Value = value;
    }

    public uint NumOfClubs
    {
        get => _numOfClubs.Value;
        set => _numOfClubs.Value = value;
    }

    public uint NumOfOnlineClubs
    {
        get => _numOfOnlineClubs.Value;
        set => _numOfOnlineClubs.Value = value;
    }

}
