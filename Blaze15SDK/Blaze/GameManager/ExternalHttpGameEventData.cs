using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class ExternalHttpGameEventData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Error", "mError", 0x15248000, TdfType.String, 0, true), // err
        new TdfMemberInfo("GameId", "mGameId", 0x1C910000, TdfType.UInt64, 1, true), // gid
        new TdfMemberInfo("GameReportingId", "mGameReportingId", 0x1D224400, TdfType.UInt64, 2, true), // grid
        new TdfMemberInfo("GameRoster", "mGameRoster", 0x48F4D400, TdfType.List, 3, true), // rost
        new TdfMemberInfo("TournamentIdentification", "mTournamentIdentification", 0x50910000, TdfType.Struct, 4, true), // tid
    ];
    private ITdfMember[] __members;

    private TdfString _error = new(__typeInfos[0]);
    private TdfUInt64 _gameId = new(__typeInfos[1]);
    private TdfUInt64 _gameReportingId = new(__typeInfos[2]);
    private TdfList<Blaze15SDK.Blaze.GameManager.ExternalHttpGamePlayerEventData> _gameRoster = new(__typeInfos[3]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.TournamentIdentification?> _tournamentIdentification = new(__typeInfos[4]);

    public ExternalHttpGameEventData()
    {
        __members = [ _error, _gameId, _gameReportingId, _gameRoster, _tournamentIdentification ];
    }

    public override Tdf CreateNew() => new ExternalHttpGameEventData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ExternalHttpGameEventData";
    public override string GetFullClassName() => "Blaze::GameManager::ExternalHttpGameEventData";

    public string Error
    {
        get => _error.Value;
        set => _error.Value = value;
    }

    public ulong GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public ulong GameReportingId
    {
        get => _gameReportingId.Value;
        set => _gameReportingId.Value = value;
    }

    public IList<Blaze15SDK.Blaze.GameManager.ExternalHttpGamePlayerEventData> GameRoster
    {
        get => _gameRoster.Value;
        set => _gameRoster.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.TournamentIdentification? TournamentIdentification
    {
        get => _tournamentIdentification.Value;
        set => _tournamentIdentification.Value = value;
    }

}
