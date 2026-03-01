using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class AddQueuedPlayerToGameRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x1C910000, TdfType.UInt64, 0, true), // gid
        new TdfMemberInfo("OverridePlayerRole", "mOverridePlayerRole", 0x3D648400, TdfType.Bool, 1, true), // ovrd
        new TdfMemberInfo("PlayerId", "mPlayerId", 0x40910000, TdfType.Int64, 2, true), // pid
        new TdfMemberInfo("PlayerRole", "mPlayerRole", 0x48F30500, TdfType.String, 3, true), // role
        new TdfMemberInfo("PlayerTeamIndex", "mPlayerTeamIndex", 0x50911800, TdfType.UInt16, 4, true), // tidx
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _gameId = new(__typeInfos[0]);
    private TdfBool _overridePlayerRole = new(__typeInfos[1]);
    private TdfInt64 _playerId = new(__typeInfos[2]);
    private TdfString _playerRole = new(__typeInfos[3]);
    private TdfUInt16 _playerTeamIndex = new(__typeInfos[4]);

    public AddQueuedPlayerToGameRequest()
    {
        __members = [ _gameId, _overridePlayerRole, _playerId, _playerRole, _playerTeamIndex ];
    }

    public override Tdf CreateNew() => new AddQueuedPlayerToGameRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "AddQueuedPlayerToGameRequest";
    public override string GetFullClassName() => "Blaze::GameManager::AddQueuedPlayerToGameRequest";

    public ulong GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public bool OverridePlayerRole
    {
        get => _overridePlayerRole.Value;
        set => _overridePlayerRole.Value = value;
    }

    public long PlayerId
    {
        get => _playerId.Value;
        set => _playerId.Value = value;
    }

    public string PlayerRole
    {
        get => _playerRole.Value;
        set => _playerRole.Value = value;
    }

    public ushort PlayerTeamIndex
    {
        get => _playerTeamIndex.Value;
        set => _playerTeamIndex.Value = value;
    }

}
