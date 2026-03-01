using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameReporting.ArsonLeagueGameKeyscopes;

public class Report : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DefensiveAthleteReports", "defensiveAthleteReports", 0x10519300, TdfType.Map, 0, true), // defs
        new TdfMemberInfo("GameAttrs", "gameAttrs", 0x1C134500, TdfType.Struct, 1, true), // game
        new TdfMemberInfo("OffensiveAthleteReports", "offensiveAthleteReports", 0x3C619300, TdfType.Map, 2, true), // offs
        new TdfMemberInfo("PlayerReports", "playerReports", 0x40C65200, TdfType.Map, 3, true), // plyr
    ];
    private ITdfMember[] __members;

    private TdfMap<long, DefensiveAthlete> _defensiveAthleteReports = new(__typeInfos[0]);
    private TdfStruct<GameAttributes?> _gameAttrs = new(__typeInfos[1]);
    private TdfMap<long, OffensiveAthlete> _offensiveAthleteReports = new(__typeInfos[2]);
    private TdfMap<long, PlayerReport> _playerReports = new(__typeInfos[3]);

    public Report()
    {
        __members = [ _defensiveAthleteReports, _gameAttrs, _offensiveAthleteReports, _playerReports ];
    }

    public override Tdf CreateNew() => new Report();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "Report";
    public override string GetFullClassName() => "Blaze::GameReporting::ArsonLeagueGameKeyscopes::Report";

    public IDictionary<long, DefensiveAthlete> DefensiveAthleteReports
    {
        get => _defensiveAthleteReports.Value;
        set => _defensiveAthleteReports.Value = value;
    }

    public GameAttributes? GameAttrs
    {
        get => _gameAttrs.Value;
        set => _gameAttrs.Value = value;
    }

    public IDictionary<long, OffensiveAthlete> OffensiveAthleteReports
    {
        get => _offensiveAthleteReports.Value;
        set => _offensiveAthleteReports.Value = value;
    }

    public IDictionary<long, PlayerReport> PlayerReports
    {
        get => _playerReports.Value;
        set => _playerReports.Value = value;
    }

}
