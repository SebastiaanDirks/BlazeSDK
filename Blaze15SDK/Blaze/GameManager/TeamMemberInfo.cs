using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class TeamMemberInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlayerId", "mPlayerId", 0x40910000, TdfType.Int64, 0, true), // pid
        new TdfMemberInfo("PlayerRole", "mPlayerRole", 0x48F30500, TdfType.String, 1, true), // role
    ];
    private ITdfMember[] __members;

    private TdfInt64 _playerId = new(__typeInfos[0]);
    private TdfString _playerRole = new(__typeInfos[1]);

    public TeamMemberInfo()
    {
        __members = [ _playerId, _playerRole ];
    }

    public override Tdf CreateNew() => new TeamMemberInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "TeamMemberInfo";
    public override string GetFullClassName() => "Blaze::GameManager::TeamMemberInfo";

    public long PlayerId
    {
        get => _playerId.Value;
        set => _playerId.Value = value;
    }

    public string PlayerRole
    {
        get => _playerRole.Value;
        set => _playerRole.Value = value;
    }

}
