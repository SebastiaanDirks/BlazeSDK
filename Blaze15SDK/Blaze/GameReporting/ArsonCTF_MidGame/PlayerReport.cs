using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameReporting.ArsonCTF_MidGame;

public class PlayerReport : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("FlagsCaptured", "flagsCaptured", 0x18305000, TdfType.UInt32, 0, true), // fcap
        new TdfMemberInfo("Kills", "kills", 0x2C930C00, TdfType.UInt16, 1, true), // kill
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _flagsCaptured = new(__typeInfos[0]);
    private TdfUInt16 _kills = new(__typeInfos[1]);

    public PlayerReport()
    {
        __members = [ _flagsCaptured, _kills ];
    }

    public override Tdf CreateNew() => new PlayerReport();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PlayerReport";
    public override string GetFullClassName() => "Blaze::GameReporting::ArsonCTF_MidGame::PlayerReport";

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

}
