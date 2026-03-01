using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameReporting.ArsonCTF_Custom;

public class ResultNotification : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "gameId", 0x1CD24400, TdfType.UInt64, 0, true), // gmid
        new TdfMemberInfo("PlayerScores", "playerScores", 0x4C33D200, TdfType.Map, 1, true), // scor
        new TdfMemberInfo("Winners", "winners", 0x5C939000, TdfType.List, 2, true), // winp
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _gameId = new(__typeInfos[0]);
    private TdfMap<long, int> _playerScores = new(__typeInfos[1]);
    private TdfList<long> _winners = new(__typeInfos[2]);

    public ResultNotification()
    {
        __members = [ _gameId, _playerScores, _winners ];
    }

    public override Tdf CreateNew() => new ResultNotification();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ResultNotification";
    public override string GetFullClassName() => "Blaze::GameReporting::ArsonCTF_Custom::ResultNotification";

    public ulong GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public IDictionary<long, int> PlayerScores
    {
        get => _playerScores.Value;
        set => _playerScores.Value = value;
    }

    public IList<long> Winners
    {
        get => _winners.Value;
        set => _winners.Value = value;
    }

}
