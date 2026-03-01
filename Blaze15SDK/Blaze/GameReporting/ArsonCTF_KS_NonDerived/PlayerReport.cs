using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameReporting.ArsonCTF_KS_NonDerived;

public class PlayerReport : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Deaths", "deaths", 0x10550800, TdfType.UInt16, 0, true), // deth
        new TdfMemberInfo("FlagsCaptured", "flagsCaptured", 0x18305000, TdfType.UInt32, 1, true), // fcap
        new TdfMemberInfo("Kills", "kills", 0x2C930C00, TdfType.UInt16, 2, true), // kill
        new TdfMemberInfo("ResultMap", "resultMap", 0x49335000, TdfType.Map, 3, true), // rsmp
        new TdfMemberInfo("Weapon", "weapon", 0x5C540E00, TdfType.Int32, 4, true), // wepn
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _deaths = new(__typeInfos[0]);
    private TdfUInt32 _flagsCaptured = new(__typeInfos[1]);
    private TdfUInt16 _kills = new(__typeInfos[2]);
    private TdfMap<string, ushort> _resultMap = new(__typeInfos[3]);
    private TdfInt32 _weapon = new(__typeInfos[4]);

    public PlayerReport()
    {
        __members = [ _deaths, _flagsCaptured, _kills, _resultMap, _weapon ];
    }

    public override Tdf CreateNew() => new PlayerReport();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PlayerReport";
    public override string GetFullClassName() => "Blaze::GameReporting::ArsonCTF_KS_NonDerived::PlayerReport";

    public ushort Deaths
    {
        get => _deaths.Value;
        set => _deaths.Value = value;
    }

    public uint FlagsCaptured
    {
        get => _flagsCaptured.Value;
        set => _flagsCaptured.Value = value;
    }

    public ushort Kills
    {
        get => _kills.Value;
        set => _kills.Value = value;
    }

    public IDictionary<string, ushort> ResultMap
    {
        get => _resultMap.Value;
        set => _resultMap.Value = value;
    }

    public int Weapon
    {
        get => _weapon.Value;
        set => _weapon.Value = value;
    }

}
