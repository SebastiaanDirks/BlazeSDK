using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameReporting.ArsonLeagueGameKeyscopes;

public class OffensiveAthlete : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Serves", "serves", 0x4C549600, TdfType.UInt16, 0, true), // serv
        new TdfMemberInfo("Team", "team", 0x50504D00, TdfType.UInt16, 1, true), // team
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _serves = new(__typeInfos[0]);
    private TdfUInt16 _team = new(__typeInfos[1]);

    public OffensiveAthlete()
    {
        __members = [ _serves, _team ];
    }

    public override Tdf CreateNew() => new OffensiveAthlete();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "OffensiveAthlete";
    public override string GetFullClassName() => "Blaze::GameReporting::ArsonLeagueGameKeyscopes::OffensiveAthlete";

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
