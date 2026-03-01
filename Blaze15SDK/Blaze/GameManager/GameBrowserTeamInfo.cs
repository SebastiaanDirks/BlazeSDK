using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class GameBrowserTeamInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RoleSizeMap", "mRoleSizeMap", 0x48D05000, TdfType.Map, 0, true), // rmap
        new TdfMemberInfo("TeamId", "mTeamId", 0x50910000, TdfType.UInt16, 1, true), // tid
        new TdfMemberInfo("TeamSize", "mTeamSize", 0x51368500, TdfType.UInt16, 2, true), // tsze
    ];
    private ITdfMember[] __members;

    private TdfMap<string, ushort> _roleSizeMap = new(__typeInfos[0]);
    private TdfUInt16 _teamId = new(__typeInfos[1]);
    private TdfUInt16 _teamSize = new(__typeInfos[2]);

    public GameBrowserTeamInfo()
    {
        __members = [ _roleSizeMap, _teamId, _teamSize ];
    }

    public override Tdf CreateNew() => new GameBrowserTeamInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameBrowserTeamInfo";
    public override string GetFullClassName() => "Blaze::GameManager::GameBrowserTeamInfo";

    public IDictionary<string, ushort> RoleSizeMap
    {
        get => _roleSizeMap.Value;
        set => _roleSizeMap.Value = value;
    }

    public ushort TeamId
    {
        get => _teamId.Value;
        set => _teamId.Value = value;
    }

    public ushort TeamSize
    {
        get => _teamSize.Value;
        set => _teamSize.Value = value;
    }

}
