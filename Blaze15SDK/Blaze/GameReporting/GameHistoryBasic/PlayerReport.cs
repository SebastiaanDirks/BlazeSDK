using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameReporting.GameHistoryBasic;

public class PlayerReport : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Deaths", "deaths", 0x10550800, TdfType.UInt16, 0, true), // deth
        new TdfMemberInfo("GlickoRd", "glickoRd", 0x1CC48400, TdfType.Int32, 1, true), // glrd
        new TdfMemberInfo("GlickoSkillPoints", "glickoSkillPoints", 0x1D341400, TdfType.Int32, 2, true), // gspt
        new TdfMemberInfo("Kills", "kills", 0x2C930C00, TdfType.UInt16, 3, true), // kill
        new TdfMemberInfo("Loser", "loser", 0x30F4D200, TdfType.Bool, 4, true), // losr
        new TdfMemberInfo("LobbySkillPoints", "lobbySkillPoints", 0x31341400, TdfType.Int32, 5, true), // lspt
        new TdfMemberInfo("Money", "money", 0x34F39900, TdfType.UInt32, 6, true), // mony
        new TdfMemberInfo("PlayerClass", "playerClass", 0x40331300, TdfType.Int32, 7, true), // pcls
        new TdfMemberInfo("Rank", "rank", 0x48138B00, TdfType.Int32, 8, true), // rank
        new TdfMemberInfo("LongestTimeAlive", "longestTimeAlive", 0x50131600, TdfType.UInt32, 9, true), // talv
        new TdfMemberInfo("WinnerByDNF", "winnerByDNF", 0x5C438600, TdfType.Bool, 10, true), // wdnf
        new TdfMemberInfo("Winner", "winner", 0x5C939200, TdfType.Bool, 11, true), // winr
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _deaths = new(__typeInfos[0]);
    private TdfInt32 _glickoRd = new(__typeInfos[1]);
    private TdfInt32 _glickoSkillPoints = new(__typeInfos[2]);
    private TdfUInt16 _kills = new(__typeInfos[3]);
    private TdfBool _loser = new(__typeInfos[4]);
    private TdfInt32 _lobbySkillPoints = new(__typeInfos[5]);
    private TdfUInt32 _money = new(__typeInfos[6]);
    private TdfInt32 _playerClass = new(__typeInfos[7]);
    private TdfInt32 _rank = new(__typeInfos[8]);
    private TdfUInt32 _longestTimeAlive = new(__typeInfos[9]);
    private TdfBool _winnerByDNF = new(__typeInfos[10]);
    private TdfBool _winner = new(__typeInfos[11]);

    public PlayerReport()
    {
        __members = [ _deaths, _glickoRd, _glickoSkillPoints, _kills, _loser, _lobbySkillPoints, _money, _playerClass, _rank, _longestTimeAlive, _winnerByDNF, _winner ];
    }

    public override Tdf CreateNew() => new PlayerReport();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PlayerReport";
    public override string GetFullClassName() => "Blaze::GameReporting::GameHistoryBasic::PlayerReport";

    public ushort Deaths
    {
        get => _deaths.Value;
        set => _deaths.Value = value;
    }

    public int GlickoRd
    {
        get => _glickoRd.Value;
        set => _glickoRd.Value = value;
    }

    public int GlickoSkillPoints
    {
        get => _glickoSkillPoints.Value;
        set => _glickoSkillPoints.Value = value;
    }

    public ushort Kills
    {
        get => _kills.Value;
        set => _kills.Value = value;
    }

    public bool Loser
    {
        get => _loser.Value;
        set => _loser.Value = value;
    }

    public int LobbySkillPoints
    {
        get => _lobbySkillPoints.Value;
        set => _lobbySkillPoints.Value = value;
    }

    public uint Money
    {
        get => _money.Value;
        set => _money.Value = value;
    }

    public int PlayerClass
    {
        get => _playerClass.Value;
        set => _playerClass.Value = value;
    }

    public int Rank
    {
        get => _rank.Value;
        set => _rank.Value = value;
    }

    public uint LongestTimeAlive
    {
        get => _longestTimeAlive.Value;
        set => _longestTimeAlive.Value = value;
    }

    public bool WinnerByDNF
    {
        get => _winnerByDNF.Value;
        set => _winnerByDNF.Value = value;
    }

    public bool Winner
    {
        get => _winner.Value;
        set => _winner.Value = value;
    }

}
