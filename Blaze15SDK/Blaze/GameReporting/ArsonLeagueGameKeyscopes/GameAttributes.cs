using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameReporting.ArsonLeagueGameKeyscopes;

public class GameAttributes : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("LeagueId", "leagueId", 0x30504700, TdfType.UInt64, 0, true), // leag
        new TdfMemberInfo("MapId", "mapId", 0x34140000, TdfType.UInt16, 1, true), // map
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _leagueId = new(__typeInfos[0]);
    private TdfUInt16 _mapId = new(__typeInfos[1]);

    public GameAttributes()
    {
        __members = [ _leagueId, _mapId ];
    }

    public override Tdf CreateNew() => new GameAttributes();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameAttributes";
    public override string GetFullClassName() => "Blaze::GameReporting::ArsonLeagueGameKeyscopes::GameAttributes";

    public ulong LeagueId
    {
        get => _leagueId.Value;
        set => _leagueId.Value = value;
    }

    public ushort MapId
    {
        get => _mapId.Value;
        set => _mapId.Value = value;
    }

}
