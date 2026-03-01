using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameReporting;

public class ResultNotification : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CustomData", "customData", 0x10150100, TdfType.Variable, 0, true), // data
        new TdfMemberInfo("BlazeError", "blazeError", 0x1523D200, TdfType.Int32, 1, true), // eror
        new TdfMemberInfo("FinalResult", "finalResult", 0x18E30000, TdfType.Bool, 2, true), // fnl
        new TdfMemberInfo("GameHistoryId", "gameHistoryId", 0x1C824400, TdfType.UInt64, 3, true), // ghid
        new TdfMemberInfo("GameReportingId", "gameReportingId", 0x1D224400, TdfType.UInt64, 4, true), // grid
    ];
    private ITdfMember[] __members;

    private TdfVariable _customData = new(__typeInfos[0]);
    private TdfInt32 _blazeError = new(__typeInfos[1]);
    private TdfBool _finalResult = new(__typeInfos[2]);
    private TdfUInt64 _gameHistoryId = new(__typeInfos[3]);
    private TdfUInt64 _gameReportingId = new(__typeInfos[4]);

    public ResultNotification()
    {
        __members = [ _customData, _blazeError, _finalResult, _gameHistoryId, _gameReportingId ];
    }

    public override Tdf CreateNew() => new ResultNotification();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ResultNotification";
    public override string GetFullClassName() => "Blaze::GameReporting::ResultNotification";

    public object? CustomData
    {
        get => _customData.Value;
        set => _customData.Value = value;
    }

    public int BlazeError
    {
        get => _blazeError.Value;
        set => _blazeError.Value = value;
    }

    public bool FinalResult
    {
        get => _finalResult.Value;
        set => _finalResult.Value = value;
    }

    public ulong GameHistoryId
    {
        get => _gameHistoryId.Value;
        set => _gameHistoryId.Value = value;
    }

    public ulong GameReportingId
    {
        get => _gameReportingId.Value;
        set => _gameReportingId.Value = value;
    }

}
