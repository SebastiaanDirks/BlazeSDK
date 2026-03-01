using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameReporting.ArsonClubGameKeyscopes_NonDerived;

public class OffensiveAthlete : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Hits", "hits", 0x20951300, TdfType.UInt16, 0, true), // hits
        new TdfMemberInfo("PlayerId", "playerId", 0x40910000, TdfType.Int64, 1, true), // pid
        new TdfMemberInfo("Serves", "serves", 0x4C549600, TdfType.UInt16, 2, true), // serv
        new TdfMemberInfo("Team", "team", 0x50504D00, TdfType.UInt16, 3, true), // team
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _hits = new(__typeInfos[0]);
    private TdfInt64 _playerId = new(__typeInfos[1]);
    private TdfUInt16 _serves = new(__typeInfos[2]);
    private TdfUInt16 _team = new(__typeInfos[3]);

    public OffensiveAthlete()
    {
        __members = [ _hits, _playerId, _serves, _team ];
    }

    public override Tdf CreateNew() => new OffensiveAthlete();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "OffensiveAthlete";
    public override string GetFullClassName() => "Blaze::GameReporting::ArsonClubGameKeyscopes_NonDerived::OffensiveAthlete";

    public ushort Hits
    {
        get => _hits.Value;
        set => _hits.Value = value;
    }

    public long PlayerId
    {
        get => _playerId.Value;
        set => _playerId.Value = value;
    }

    public ushort Serves
    {
        get => _serves.Value;
        set => _serves.Value = value;
    }

    public ushort Team
    {
        get => _team.Value;
        set => _team.Value = value;
    }

}
