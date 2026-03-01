using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameReporting.ArsonMultiStatUpdates;

public class PlayerReport : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "clubId", 0x0C910000, TdfType.UInt64, 0, true), // cid
        new TdfMemberInfo("Losses", "losses", 0x30F4D300, TdfType.UInt16, 1, true), // loss
        new TdfMemberInfo("Points", "points", 0x40E51300, TdfType.UInt16, 2, true), // pnts
        new TdfMemberInfo("Wins", "wins", 0x5C939300, TdfType.UInt16, 3, true), // wins
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _clubId = new(__typeInfos[0]);
    private TdfUInt16 _losses = new(__typeInfos[1]);
    private TdfUInt16 _points = new(__typeInfos[2]);
    private TdfUInt16 _wins = new(__typeInfos[3]);

    public PlayerReport()
    {
        __members = [ _clubId, _losses, _points, _wins ];
    }

    public override Tdf CreateNew() => new PlayerReport();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PlayerReport";
    public override string GetFullClassName() => "Blaze::GameReporting::ArsonMultiStatUpdates::PlayerReport";

    public ulong ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public ushort Losses
    {
        get => _losses.Value;
        set => _losses.Value = value;
    }

    public ushort Points
    {
        get => _points.Value;
        set => _points.Value = value;
    }

    public ushort Wins
    {
        get => _wins.Value;
        set => _wins.Value = value;
    }

}
