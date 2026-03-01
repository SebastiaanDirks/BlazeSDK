using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class NotifyHostedConnectivityAvailable : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("HostedConnectivityInfo", "mHostedConnectivityInfo", 0x0C34C900, TdfType.Struct, 0, true), // ccsi
        new TdfMemberInfo("GameId", "mGameId", 0x1C910000, TdfType.UInt64, 1, true), // gid
        new TdfMemberInfo("RemotePlayerId", "mRemotePlayerId", 0x40910000, TdfType.Int64, 2, true), // pid
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.GameManager.HostedConnectivityInfo?> _hostedConnectivityInfo = new(__typeInfos[0]);
    private TdfUInt64 _gameId = new(__typeInfos[1]);
    private TdfInt64 _remotePlayerId = new(__typeInfos[2]);

    public NotifyHostedConnectivityAvailable()
    {
        __members = [ _hostedConnectivityInfo, _gameId, _remotePlayerId ];
    }

    public override Tdf CreateNew() => new NotifyHostedConnectivityAvailable();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyHostedConnectivityAvailable";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyHostedConnectivityAvailable";

    public Blaze15SDK.Blaze.GameManager.HostedConnectivityInfo? HostedConnectivityInfo
    {
        get => _hostedConnectivityInfo.Value;
        set => _hostedConnectivityInfo.Value = value;
    }

    public ulong GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public long RemotePlayerId
    {
        get => _remotePlayerId.Value;
        set => _remotePlayerId.Value = value;
    }

}
