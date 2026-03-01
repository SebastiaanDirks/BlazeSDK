using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameReporting.IntegratedSample;

public class PlayerReport : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Hits", "hits", 0x20951300, TdfType.UInt16, 0, true), // hits
        new TdfMemberInfo("Loser", "loser", 0x30F4C500, TdfType.UInt16, 1, true), // lose
        new TdfMemberInfo("Misses", "misses", 0x3494D300, TdfType.UInt16, 2, true), // miss
        new TdfMemberInfo("Score", "score", 0x4C348000, TdfType.UInt16, 3, true), // scr
        new TdfMemberInfo("Torchings", "torchings", 0x5120C800, TdfType.UInt16, 4, true), // trch
        new TdfMemberInfo("Winner", "winner", 0x5C938000, TdfType.UInt16, 5, true), // win
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _hits = new(__typeInfos[0]);
    private TdfUInt16 _loser = new(__typeInfos[1]);
    private TdfUInt16 _misses = new(__typeInfos[2]);
    private TdfUInt16 _score = new(__typeInfos[3]);
    private TdfUInt16 _torchings = new(__typeInfos[4]);
    private TdfUInt16 _winner = new(__typeInfos[5]);

    public PlayerReport()
    {
        __members = [ _hits, _loser, _misses, _score, _torchings, _winner ];
    }

    public override Tdf CreateNew() => new PlayerReport();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PlayerReport";
    public override string GetFullClassName() => "Blaze::GameReporting::IntegratedSample::PlayerReport";

    public ushort Hits
    {
        get => _hits.Value;
        set => _hits.Value = value;
    }

    public ushort Loser
    {
        get => _loser.Value;
        set => _loser.Value = value;
    }

    public ushort Misses
    {
        get => _misses.Value;
        set => _misses.Value = value;
    }

    public ushort Score
    {
        get => _score.Value;
        set => _score.Value = value;
    }

    public ushort Torchings
    {
        get => _torchings.Value;
        set => _torchings.Value = value;
    }

    public ushort Winner
    {
        get => _winner.Value;
        set => _winner.Value = value;
    }

}
