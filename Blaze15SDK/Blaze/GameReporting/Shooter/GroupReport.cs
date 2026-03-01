using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameReporting.Shooter;

public class GroupReport : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Stats", "stats", 0x05448200, TdfType.Map, 0, true), // atrb
        new TdfMemberInfo("PlayerReports", "playerReports", 0x40C65200, TdfType.Map, 1, true), // plyr
    ];
    private ITdfMember[] __members;

    private TdfMap<string, float> _stats = new(__typeInfos[0]);
    private TdfMap<long, EntityReport> _playerReports = new(__typeInfos[1]);

    public GroupReport()
    {
        __members = [ _stats, _playerReports ];
    }

    public override Tdf CreateNew() => new GroupReport();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GroupReport";
    public override string GetFullClassName() => "Blaze::GameReporting::Shooter::GroupReport";

    public IDictionary<string, float> Stats
    {
        get => _stats.Value;
        set => _stats.Value = value;
    }

    public IDictionary<long, EntityReport> PlayerReports
    {
        get => _playerReports.Value;
        set => _playerReports.Value = value;
    }

}
