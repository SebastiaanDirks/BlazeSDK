using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameReporting.GameHistoryClubs_NonDerived;

public class Report : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("OffensiveAthletes", "offensiveAthletes", 0x05420C00, TdfType.Map, 0, true), // athl
        new TdfMemberInfo("ClubReports", "clubReports", 0x0CC54200, TdfType.Map, 1, true), // club
        new TdfMemberInfo("PlayerReports", "playerReports", 0x40C65200, TdfType.Map, 2, true), // plyr
    ];
    private ITdfMember[] __members;

    private TdfMap<long, OffensiveAthlete> _offensiveAthletes = new(__typeInfos[0]);
    private TdfMap<ulong, ClubReport> _clubReports = new(__typeInfos[1]);
    private TdfMap<long, PlayerReport> _playerReports = new(__typeInfos[2]);

    public Report()
    {
        __members = [ _offensiveAthletes, _clubReports, _playerReports ];
    }

    public override Tdf CreateNew() => new Report();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "Report";
    public override string GetFullClassName() => "Blaze::GameReporting::GameHistoryClubs_NonDerived::Report";

    public IDictionary<long, OffensiveAthlete> OffensiveAthletes
    {
        get => _offensiveAthletes.Value;
        set => _offensiveAthletes.Value = value;
    }

    public IDictionary<ulong, ClubReport> ClubReports
    {
        get => _clubReports.Value;
        set => _clubReports.Value = value;
    }

    public IDictionary<long, PlayerReport> PlayerReports
    {
        get => _playerReports.Value;
        set => _playerReports.Value = value;
    }

}
