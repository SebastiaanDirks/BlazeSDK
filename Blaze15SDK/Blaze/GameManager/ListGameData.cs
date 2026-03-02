using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class ListGameData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Game", "mGame", 0x9E1B6500, TdfType.Struct, 0, true), // Tag: GAME
        new TdfMemberInfo("GameRoster", "mGameRoster", 0xC32BF300, TdfType.List, 1, true), // Tag: PROS
        new TdfMemberInfo("QueueRoster", "mQueueRoster", 0xC72BF300, TdfType.List, 2, true), // Tag: QROS
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.GameManager.ReplicatedGameData?> _game = new(__typeInfos[0]);
    private TdfList<Blaze15SDK.Blaze.GameManager.ReplicatedGamePlayer> _gameRoster = new(__typeInfos[1]);
    private TdfList<Blaze15SDK.Blaze.GameManager.ReplicatedGamePlayer> _queueRoster = new(__typeInfos[2]);

    public ListGameData()
    {
        __members = [ _game, _gameRoster, _queueRoster ];
    }

    public override Tdf CreateNew() => new ListGameData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListGameData";
    public override string GetFullClassName() => "Blaze::GameManager::ListGameData";

    public Blaze15SDK.Blaze.GameManager.ReplicatedGameData? Game
    {
        get => _game.Value;
        set => _game.Value = value;
    }

    public IList<Blaze15SDK.Blaze.GameManager.ReplicatedGamePlayer> GameRoster
    {
        get => _gameRoster.Value;
        set => _gameRoster.Value = value;
    }

    public IList<Blaze15SDK.Blaze.GameManager.ReplicatedGamePlayer> QueueRoster
    {
        get => _queueRoster.Value;
        set => _queueRoster.Value = value;
    }

}
