using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Util;

public class PostAuthResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("TelemetryServer", "mTelemetryServer", 0x50530500, TdfType.Struct, 0, true), // tele
        new TdfMemberInfo("TickerServer", "mTickerServer", 0x5090CB00, TdfType.Struct, 1, true), // tick
        new TdfMemberInfo("UserOptions", "mUserOptions", 0x5523D000, TdfType.Struct, 2, true), // urop
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.Util.GetTelemetryServerResponse?> _telemetryServer = new(__typeInfos[0]);
    private TdfStruct<Blaze15SDK.Blaze.Util.GetTickerServerResponse?> _tickerServer = new(__typeInfos[1]);
    private TdfStruct<Blaze15SDK.Blaze.Util.UserOptions?> _userOptions = new(__typeInfos[2]);

    public PostAuthResponse()
    {
        __members = [ _telemetryServer, _tickerServer, _userOptions ];
    }

    public override Tdf CreateNew() => new PostAuthResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PostAuthResponse";
    public override string GetFullClassName() => "Blaze::GameManager::PostAuthResponse";

    public Blaze15SDK.Blaze.Util.GetTelemetryServerResponse? TelemetryServer
    {
        get => _telemetryServer.Value;
        set => _telemetryServer.Value = value;
    }

    public Blaze15SDK.Blaze.Util.GetTickerServerResponse? TickerServer
    {
        get => _tickerServer.Value;
        set => _tickerServer.Value = value;
    }

    public Blaze15SDK.Blaze.Util.UserOptions? UserOptions
    {
        get => _userOptions.Value;
        set => _userOptions.Value = value;
    }

}
