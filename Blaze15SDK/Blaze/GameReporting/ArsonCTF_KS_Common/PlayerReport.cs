using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameReporting.ArsonCTF_KS_Common;

public class PlayerReport : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CustomReport", "customReport", 0x10549600, TdfType.Variable, 0, true), // derv
        new TdfMemberInfo("Deaths", "deaths", 0x10550800, TdfType.UInt16, 1, true), // deth
        new TdfMemberInfo("Kills", "kills", 0x2C930C00, TdfType.UInt16, 2, true), // kill
        new TdfMemberInfo("Weapon", "weapon", 0x5C540E00, TdfType.Int32, 3, true), // wepn
    ];
    private ITdfMember[] __members;

    private TdfVariable _customReport = new(__typeInfos[0]);
    private TdfUInt16 _deaths = new(__typeInfos[1]);
    private TdfUInt16 _kills = new(__typeInfos[2]);
    private TdfInt32 _weapon = new(__typeInfos[3]);

    public PlayerReport()
    {
        __members = [ _customReport, _deaths, _kills, _weapon ];
    }

    public override Tdf CreateNew() => new PlayerReport();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PlayerReport";
    public override string GetFullClassName() => "Blaze::GameReporting::ArsonCTF_KS_Common::PlayerReport";

    public object? CustomReport
    {
        get => _customReport.Value;
        set => _customReport.Value = value;
    }

    public ushort Deaths
    {
        get => _deaths.Value;
        set => _deaths.Value = value;
    }

    public ushort Kills
    {
        get => _kills.Value;
        set => _kills.Value = value;
    }

    public int Weapon
    {
        get => _weapon.Value;
        set => _weapon.Value = value;
    }

}
