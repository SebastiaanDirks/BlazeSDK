using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class SetPlayerAttributesRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x1C910000, TdfType.UInt64, 0, true), // gid
        new TdfMemberInfo("PlayerId", "mPlayerId", 0x40910000, TdfType.Int64, 1, true), // pid
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _gameId = new(__typeInfos[0]);
    private TdfInt64 _playerId = new(__typeInfos[1]);

    public SetPlayerAttributesRequest()
    {
        __members = [ _gameId, _playerId ];
    }

    public override Tdf CreateNew() => new SetPlayerAttributesRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetPlayerAttributesRequest";
    public override string GetFullClassName() => "Blaze::GameManager::SetPlayerAttributesRequest";

    public ulong GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public long PlayerId
    {
        get => _playerId.Value;
        set => _playerId.Value = value;
    }

}
