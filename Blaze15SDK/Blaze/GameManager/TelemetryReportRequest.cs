using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class TelemetryReportRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x1C910000, TdfType.UInt64, 0, true), // gid
        new TdfMemberInfo("LocalConnGroupId", "mLocalConnGroupId", 0x30324400, TdfType.UInt64, 1, true), // lcid
        new TdfMemberInfo("NetworkTopology", "mNetworkTopology", 0x3943D000, TdfType.Enum, 2, true), // ntop
        new TdfMemberInfo("TelemetryReports", "mTelemetryReports", 0x49051300, TdfType.List, 3, true), // rpts
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _gameId = new(__typeInfos[0]);
    private TdfUInt64 _localConnGroupId = new(__typeInfos[1]);
    private TdfEnum<Blaze15SDK.Blaze.GameNetworkTopology> _networkTopology = new(__typeInfos[2]);
    private TdfList<Blaze15SDK.Blaze.GameManager.TelemetryReport> _telemetryReports = new(__typeInfos[3]);

    public TelemetryReportRequest()
    {
        __members = [ _gameId, _localConnGroupId, _networkTopology, _telemetryReports ];
    }

    public override Tdf CreateNew() => new TelemetryReportRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "TelemetryReportRequest";
    public override string GetFullClassName() => "Blaze::GameManager::TelemetryReportRequest";

    public ulong GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public ulong LocalConnGroupId
    {
        get => _localConnGroupId.Value;
        set => _localConnGroupId.Value = value;
    }

    public Blaze15SDK.Blaze.GameNetworkTopology NetworkTopology
    {
        get => _networkTopology.Value;
        set => _networkTopology.Value = value;
    }

    public IList<Blaze15SDK.Blaze.GameManager.TelemetryReport> TelemetryReports
    {
        get => _telemetryReports.Value;
        set => _telemetryReports.Value = value;
    }

}
