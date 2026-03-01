using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class NotifyGameCapacityChange : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("SlotCapacities", "mSlotCapacities", 0x0C140000, TdfType.List, 0, true), // cap
        new TdfMemberInfo("GameId", "mGameId", 0x1C910000, TdfType.UInt64, 1, true), // gid
        new TdfMemberInfo("LockedForPreferredJoins", "mLockedForPreferredJoins", 0x30640A00, TdfType.Bool, 2, true), // lfpj
        new TdfMemberInfo("RoleInformation", "mRoleInformation", 0x48E18F00, TdfType.Struct, 3, true), // rnfo
        new TdfMemberInfo("TeamRosters", "mTeamRosters", 0x5124D400, TdfType.List, 4, true), // trst
    ];
    private ITdfMember[] __members;

    private TdfList<ushort> _slotCapacities = new(__typeInfos[0]);
    private TdfUInt64 _gameId = new(__typeInfos[1]);
    private TdfBool _lockedForPreferredJoins = new(__typeInfos[2]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.RoleInformation?> _roleInformation = new(__typeInfos[3]);
    private TdfList<Blaze15SDK.Blaze.GameManager.TeamDetails> _teamRosters = new(__typeInfos[4]);

    public NotifyGameCapacityChange()
    {
        __members = [ _slotCapacities, _gameId, _lockedForPreferredJoins, _roleInformation, _teamRosters ];
    }

    public override Tdf CreateNew() => new NotifyGameCapacityChange();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyGameCapacityChange";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyGameCapacityChange";

    public IList<ushort> SlotCapacities
    {
        get => _slotCapacities.Value;
        set => _slotCapacities.Value = value;
    }

    public ulong GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public bool LockedForPreferredJoins
    {
        get => _lockedForPreferredJoins.Value;
        set => _lockedForPreferredJoins.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.RoleInformation? RoleInformation
    {
        get => _roleInformation.Value;
        set => _roleInformation.Value = value;
    }

    public IList<Blaze15SDK.Blaze.GameManager.TeamDetails> TeamRosters
    {
        get => _teamRosters.Value;
        set => _teamRosters.Value = value;
    }

}
