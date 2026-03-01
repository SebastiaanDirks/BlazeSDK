using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameReporting.GameHistoryBasic;

public class Report : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CustomReports", "mCustomReports", 0x0D54D400, TdfType.Variable, 0, true), // cust
        new TdfMemberInfo("GameAttrs", "gameAttrs", 0x1C134500, TdfType.Struct, 1, true), // game
        new TdfMemberInfo("PlayerReports", "playerReports", 0x40C65200, TdfType.Map, 2, true), // plyr
    ];
    private ITdfMember[] __members;

    private TdfVariable _customReports = new(__typeInfos[0]);
    private TdfStruct<GameAttributes?> _gameAttrs = new(__typeInfos[1]);
    private TdfMap<long, PlayerReport> _playerReports = new(__typeInfos[2]);

    public Report()
    {
        __members = [ _customReports, _gameAttrs, _playerReports ];
    }

    public override Tdf CreateNew() => new Report();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "Report";
    public override string GetFullClassName() => "Blaze::GameReporting::GameHistoryBasic::Report";

    public object? CustomReports
    {
        get => _customReports.Value;
        set => _customReports.Value = value;
    }

    public GameAttributes? GameAttrs
    {
        get => _gameAttrs.Value;
        set => _gameAttrs.Value = value;
    }

    public IDictionary<long, PlayerReport> PlayerReports
    {
        get => _playerReports.Value;
        set => _playerReports.Value = value;
    }

}
