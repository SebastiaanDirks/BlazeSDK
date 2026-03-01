using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class NotifyPlayerRemoved : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlayerRemovedTitleContext", "mPlayerRemovedTitleContext", 0x0CE51800, TdfType.UInt16, 0, true), // cntx
        new TdfMemberInfo("GameId", "mGameId", 0x1C910000, TdfType.UInt64, 1, true), // gid
        new TdfMemberInfo("LockedForPreferredJoins", "mLockedForPreferredJoins", 0x30640A00, TdfType.Bool, 2, true), // lfpj
        new TdfMemberInfo("PlayerId", "mPlayerId", 0x40910000, TdfType.Int64, 3, true), // pid
        new TdfMemberInfo("PlayerRemovedReason", "mPlayerRemovedReason", 0x48505300, TdfType.Enum, 4, true), // reas
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _playerRemovedTitleContext = new(__typeInfos[0]);
    private TdfUInt64 _gameId = new(__typeInfos[1]);
    private TdfBool _lockedForPreferredJoins = new(__typeInfos[2]);
    private TdfInt64 _playerId = new(__typeInfos[3]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.PlayerRemovedReason> _playerRemovedReason = new(__typeInfos[4]);

    public NotifyPlayerRemoved()
    {
        __members = [ _playerRemovedTitleContext, _gameId, _lockedForPreferredJoins, _playerId, _playerRemovedReason ];
    }

    public override Tdf CreateNew() => new NotifyPlayerRemoved();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyPlayerRemoved";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyPlayerRemoved";

    public ushort PlayerRemovedTitleContext
    {
        get => _playerRemovedTitleContext.Value;
        set => _playerRemovedTitleContext.Value = value;
    }

    public ulong GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public bool LockedForPreferredJoins
    {
        get => _lockedForPreferredJoins.Value;
        set => _lockedForPreferredJoins.Value = value;
    }

    public long PlayerId
    {
        get => _playerId.Value;
        set => _playerId.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.PlayerRemovedReason PlayerRemovedReason
    {
        get => _playerRemovedReason.Value;
        set => _playerRemovedReason.Value = value;
    }

}
