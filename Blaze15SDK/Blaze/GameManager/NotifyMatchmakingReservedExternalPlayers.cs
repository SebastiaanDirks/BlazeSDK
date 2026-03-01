using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class NotifyMatchmakingReservedExternalPlayers : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x1CD24400, TdfType.UInt64, 0, true), // gmid
        new TdfMemberInfo("JoinedReservedPlayerIdentifications", "mJoinedReservedPlayerIdentifications", 0x48524000, TdfType.List, 1, true), // rei
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _gameId = new(__typeInfos[0]);
    private TdfList<Blaze15SDK.Blaze.UserIdentification> _joinedReservedPlayerIdentifications = new(__typeInfos[1]);

    public NotifyMatchmakingReservedExternalPlayers()
    {
        __members = [ _gameId, _joinedReservedPlayerIdentifications ];
    }

    public override Tdf CreateNew() => new NotifyMatchmakingReservedExternalPlayers();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyMatchmakingReservedExternalPlayers";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyMatchmakingReservedExternalPlayers";

    public ulong GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public IList<Blaze15SDK.Blaze.UserIdentification> JoinedReservedPlayerIdentifications
    {
        get => _joinedReservedPlayerIdentifications.Value;
        set => _joinedReservedPlayerIdentifications.Value = value;
    }

}
