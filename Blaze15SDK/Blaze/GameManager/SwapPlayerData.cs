using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class SwapPlayerData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlayerId", "mPlayerId", 0x40910000, TdfType.Int64, 0, true), // pid
        new TdfMemberInfo("RoleName", "mRoleName", 0x48F30500, TdfType.String, 1, true), // role
        new TdfMemberInfo("SlotType", "mSlotType", 0x4CC3D400, TdfType.Enum, 2, true), // slot
        new TdfMemberInfo("TeamIndex", "mTeamIndex", 0x50911800, TdfType.UInt16, 3, true), // tidx
    ];
    private ITdfMember[] __members;

    private TdfInt64 _playerId = new(__typeInfos[0]);
    private TdfString _roleName = new(__typeInfos[1]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.SlotType> _slotType = new(__typeInfos[2]);
    private TdfUInt16 _teamIndex = new(__typeInfos[3]);

    public SwapPlayerData()
    {
        __members = [ _playerId, _roleName, _slotType, _teamIndex ];
    }

    public override Tdf CreateNew() => new SwapPlayerData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SwapPlayerData";
    public override string GetFullClassName() => "Blaze::GameManager::SwapPlayerData";

    public long PlayerId
    {
        get => _playerId.Value;
        set => _playerId.Value = value;
    }

    public string RoleName
    {
        get => _roleName.Value;
        set => _roleName.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.SlotType SlotType
    {
        get => _slotType.Value;
        set => _slotType.Value = value;
    }

    public ushort TeamIndex
    {
        get => _teamIndex.Value;
        set => _teamIndex.Value = value;
    }

}
