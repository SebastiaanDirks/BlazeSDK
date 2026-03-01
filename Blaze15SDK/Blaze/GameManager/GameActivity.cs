using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class GameActivity : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("SessionIdentification", "mSessionIdentification", 0x15324400, TdfType.Struct, 0, true), // esid
        new TdfMemberInfo("ExternalSessionName", "mExternalSessionName", 0x15338D00, TdfType.String, 1, true), // esnm
        new TdfMemberInfo("GameType", "mGameType", 0x1C751900, TdfType.Enum, 2, true), // ggty
        new TdfMemberInfo("GameId", "mGameId", 0x1C910000, TdfType.UInt64, 3, true), // gid
        new TdfMemberInfo("Player", "mPlayer", 0x40C65200, TdfType.Struct, 4, true), // plyr
        new TdfMemberInfo("PresenceMode", "mPresenceMode", 0x41215300, TdfType.Enum, 5, true), // pres
        new TdfMemberInfo("PlayerState", "mPlayerState", 0x41350100, TdfType.Enum, 6, true), // psta
        new TdfMemberInfo("ExternalSessionTemplateName", "mExternalSessionTemplateName", 0x4D434E00, TdfType.String, 7, true), // stmn
        new TdfMemberInfo("JoinedGameTimestamp", "mJoinedGameTimestamp", 0x50934500, TdfType.Int64, 8, true), // time
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.ExternalSessionIdentification?> _sessionIdentification = new(__typeInfos[0]);
    private TdfString _externalSessionName = new(__typeInfos[1]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.GameType> _gameType = new(__typeInfos[2]);
    private TdfUInt64 _gameId = new(__typeInfos[3]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.PlayerPresenceData?> _player = new(__typeInfos[4]);
    private TdfEnum<Blaze15SDK.Blaze.PresenceMode> _presenceMode = new(__typeInfos[5]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.PlayerState> _playerState = new(__typeInfos[6]);
    private TdfString _externalSessionTemplateName = new(__typeInfos[7]);
    private TdfInt64 _joinedGameTimestamp = new(__typeInfos[8]);

    public GameActivity()
    {
        __members = [ _sessionIdentification, _externalSessionName, _gameType, _gameId, _player, _presenceMode, _playerState, _externalSessionTemplateName, _joinedGameTimestamp ];
    }

    public override Tdf CreateNew() => new GameActivity();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameActivity";
    public override string GetFullClassName() => "Blaze::GameManager::GameActivity";

    public Blaze15SDK.Blaze.ExternalSessionIdentification? SessionIdentification
    {
        get => _sessionIdentification.Value;
        set => _sessionIdentification.Value = value;
    }

    public string ExternalSessionName
    {
        get => _externalSessionName.Value;
        set => _externalSessionName.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.GameType GameType
    {
        get => _gameType.Value;
        set => _gameType.Value = value;
    }

    public ulong GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.PlayerPresenceData? Player
    {
        get => _player.Value;
        set => _player.Value = value;
    }

    public Blaze15SDK.Blaze.PresenceMode PresenceMode
    {
        get => _presenceMode.Value;
        set => _presenceMode.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.PlayerState PlayerState
    {
        get => _playerState.Value;
        set => _playerState.Value = value;
    }

    public string ExternalSessionTemplateName
    {
        get => _externalSessionTemplateName.Value;
        set => _externalSessionTemplateName.Value = value;
    }

    public long JoinedGameTimestamp
    {
        get => _joinedGameTimestamp.Value;
        set => _joinedGameTimestamp.Value = value;
    }

}
