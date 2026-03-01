using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameReporting;

public class GameReport : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Report", "report", 0x1C134500, TdfType.Variable, 0, true), // game
        new TdfMemberInfo("GameReportingId", "gameReportingId", 0x1D224400, TdfType.UInt64, 1, true), // grid
        new TdfMemberInfo("GameReportName", "gameReportName", 0x1D465000, TdfType.String, 2, true), // gtyp
        new TdfMemberInfo("OfflineParticipantList", "offlineParticipantList", 0x40149400, TdfType.List, 3, true), // part
    ];
    private ITdfMember[] __members;

    private TdfVariable _report = new(__typeInfos[0]);
    private TdfUInt64 _gameReportingId = new(__typeInfos[1]);
    private TdfString _gameReportName = new(__typeInfos[2]);
    private TdfList<long> _offlineParticipantList = new(__typeInfos[3]);

    public GameReport()
    {
        __members = [ _report, _gameReportingId, _gameReportName, _offlineParticipantList ];
    }

    public override Tdf CreateNew() => new GameReport();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameReport";
    public override string GetFullClassName() => "Blaze::GameReporting::GameReport";

    public object? Report
    {
        get => _report.Value;
        set => _report.Value = value;
    }

    public ulong GameReportingId
    {
        get => _gameReportingId.Value;
        set => _gameReportingId.Value = value;
    }

    public string GameReportName
    {
        get => _gameReportName.Value;
        set => _gameReportName.Value = value;
    }

    public IList<long> OfflineParticipantList
    {
        get => _offlineParticipantList.Value;
        set => _offlineParticipantList.Value = value;
    }

}
