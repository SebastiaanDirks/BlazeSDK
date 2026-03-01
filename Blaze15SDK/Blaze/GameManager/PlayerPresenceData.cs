using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class PlayerPresenceData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("SlotType", "mSlotType", 0x4CC3D400, TdfType.Enum, 0, true), // slot
        new TdfMemberInfo("TeamIndex", "mTeamIndex", 0x50504D00, TdfType.UInt16, 1, true), // team
        new TdfMemberInfo("JoinedGameTimestamp", "mJoinedGameTimestamp", 0x50934500, TdfType.Int64, 2, true), // time
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze15SDK.Blaze.GameManager.SlotType> _slotType = new(__typeInfos[0]);
    private TdfUInt16 _teamIndex = new(__typeInfos[1]);
    private TdfInt64 _joinedGameTimestamp = new(__typeInfos[2]);

    public PlayerPresenceData()
    {
        __members = [ _slotType, _teamIndex, _joinedGameTimestamp ];
    }

    public override Tdf CreateNew() => new PlayerPresenceData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PlayerPresenceData";
    public override string GetFullClassName() => "Blaze::GameManager::PlayerPresenceData";

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

    public long JoinedGameTimestamp
    {
        get => _joinedGameTimestamp.Value;
        set => _joinedGameTimestamp.Value = value;
    }

}
