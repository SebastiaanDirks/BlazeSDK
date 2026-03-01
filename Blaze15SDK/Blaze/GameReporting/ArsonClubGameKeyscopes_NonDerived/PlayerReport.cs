using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameReporting.ArsonClubGameKeyscopes_NonDerived;

public class PlayerReport : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "clubId", 0x0CC24400, TdfType.UInt64, 0, true), // clid
        new TdfMemberInfo("Clubregion", "clubregion", 0x0D214700, TdfType.UInt32, 1, true), // creg
        new TdfMemberInfo("Points", "points", 0x40E51300, TdfType.UInt16, 2, true), // pnts
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _clubId = new(__typeInfos[0]);
    private TdfUInt32 _clubregion = new(__typeInfos[1]);
    private TdfUInt16 _points = new(__typeInfos[2]);

    public PlayerReport()
    {
        __members = [ _clubId, _clubregion, _points ];
    }

    public override Tdf CreateNew() => new PlayerReport();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PlayerReport";
    public override string GetFullClassName() => "Blaze::GameReporting::ArsonClubGameKeyscopes_NonDerived::PlayerReport";

    public ulong ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public uint Clubregion
    {
        get => _clubregion.Value;
        set => _clubregion.Value = value;
    }

    public ushort Points
    {
        get => _points.Value;
        set => _points.Value = value;
    }

}
