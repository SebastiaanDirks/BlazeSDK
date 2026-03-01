using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameReporting.ArsonCTF_NonDerived;

public class PlayerReport : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Deaths", "deaths", 0x10550800, TdfType.Int32, 0, true), // deth
        new TdfMemberInfo("FlagsCaptured", "flagsCaptured", 0x18305000, TdfType.UInt32, 1, true), // fcap
        new TdfMemberInfo("Kills", "kills", 0x2C930C00, TdfType.Int32, 2, true), // kill
        new TdfMemberInfo("AccountLocale", "accountLocale", 0x30F0C000, TdfType.UInt32, 3, true), // loc
        new TdfMemberInfo("LeavingReason", "leavingReason", 0x48D48000, TdfType.UInt32, 4, true), // rmr
        new TdfMemberInfo("ResultMap", "resultMap", 0x49335000, TdfType.Map, 5, true), // rsmp
        new TdfMemberInfo("SkippedReport", "skippedReport", 0x4CB49000, TdfType.Variable, 6, true), // skrp
    ];
    private ITdfMember[] __members;

    private TdfInt32 _deaths = new(__typeInfos[0]);
    private TdfUInt32 _flagsCaptured = new(__typeInfos[1]);
    private TdfInt32 _kills = new(__typeInfos[2]);
    private TdfUInt32 _accountLocale = new(__typeInfos[3]);
    private TdfUInt32 _leavingReason = new(__typeInfos[4]);
    private TdfMap<string, ushort> _resultMap = new(__typeInfos[5]);
    private TdfVariable _skippedReport = new(__typeInfos[6]);

    public PlayerReport()
    {
        __members = [ _deaths, _flagsCaptured, _kills, _accountLocale, _leavingReason, _resultMap, _skippedReport ];
    }

    public override Tdf CreateNew() => new PlayerReport();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PlayerReport";
    public override string GetFullClassName() => "Blaze::GameReporting::ArsonCTF_NonDerived::PlayerReport";

    public int Deaths
    {
        get => _deaths.Value;
        set => _deaths.Value = value;
    }

    public uint FlagsCaptured
    {
        get => _flagsCaptured.Value;
        set => _flagsCaptured.Value = value;
    }

    public int Kills
    {
        get => _kills.Value;
        set => _kills.Value = value;
    }

    public uint AccountLocale
    {
        get => _accountLocale.Value;
        set => _accountLocale.Value = value;
    }

    public uint LeavingReason
    {
        get => _leavingReason.Value;
        set => _leavingReason.Value = value;
    }

    public IDictionary<string, ushort> ResultMap
    {
        get => _resultMap.Value;
        set => _resultMap.Value = value;
    }

    public object? SkippedReport
    {
        get => _skippedReport.Value;
        set => _skippedReport.Value = value;
    }

}
