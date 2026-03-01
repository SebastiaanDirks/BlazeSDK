using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameReporting;

public class GameReportType : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameReportName", "mGameReportName", 0x1D438100, TdfType.String, 0, true), // gtna
        new TdfMemberInfo("HistoryTables", "mHistoryTables", 0x2094D400, TdfType.List, 1, true), // hist
    ];
    private ITdfMember[] __members;

    private TdfString _gameReportName = new(__typeInfos[0]);
    private TdfList<TableData> _historyTables = new(__typeInfos[1]);

    public GameReportType()
    {
        __members = [ _gameReportName, _historyTables ];
    }

    public override Tdf CreateNew() => new GameReportType();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameReportType";
    public override string GetFullClassName() => "Blaze::GameReporting::GameReportType";

    public string GameReportName
    {
        get => _gameReportName.Value;
        set => _gameReportName.Value = value;
    }

    public IList<TableData> HistoryTables
    {
        get => _historyTables.Value;
        set => _historyTables.Value = value;
    }

}
