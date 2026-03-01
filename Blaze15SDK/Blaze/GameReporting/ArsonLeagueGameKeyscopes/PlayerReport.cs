using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameReporting.ArsonLeagueGameKeyscopes;

public class PlayerReport : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Losses", "losses", 0x30F4D300, TdfType.UInt16, 0, true), // loss
        new TdfMemberInfo("SeasonLevel", "seasonLevel", 0x4CC58C00, TdfType.UInt16, 1, true), // slvl
        new TdfMemberInfo("Wins", "wins", 0x5C939300, TdfType.UInt16, 2, true), // wins
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _losses = new(__typeInfos[0]);
    private TdfUInt16 _seasonLevel = new(__typeInfos[1]);
    private TdfUInt16 _wins = new(__typeInfos[2]);

    public PlayerReport()
    {
        __members = [ _losses, _seasonLevel, _wins ];
    }

    public override Tdf CreateNew() => new PlayerReport();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PlayerReport";
    public override string GetFullClassName() => "Blaze::GameReporting::ArsonLeagueGameKeyscopes::PlayerReport";

    public ushort Losses
    {
        get => _losses.Value;
        set => _losses.Value = value;
    }

    public ushort SeasonLevel
    {
        get => _seasonLevel.Value;
        set => _seasonLevel.Value = value;
    }

    public ushort Wins
    {
        get => _wins.Value;
        set => _wins.Value = value;
    }

}
