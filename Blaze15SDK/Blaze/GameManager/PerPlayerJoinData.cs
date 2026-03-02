using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class PerPlayerJoinData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EncryptedBlazeId", "mEncryptedBlazeId", 0x96E8F200, TdfType.String, 0, true), // Tag: ENCR
        new TdfMemberInfo("IsOptionalPlayer", "mIsOptionalPlayer", 0xA7297000, TdfType.Bool, 1, true), // Tag: IREP
        new TdfMemberInfo("Role", "mRole", 0xCACBAD00, TdfType.String, 2, true), // Tag: RLNM
        new TdfMemberInfo("Roles", "mRoles", 0xCACCF400, TdfType.List, 3, true), // Tag: RLST
        new TdfMemberInfo("SlotType", "mSlotType", 0xCECBF400, TdfType.Enum, 4, true), // Tag: SLOT
        new TdfMemberInfo("TeamId", "mTeamId", 0xD2990000, TdfType.UInt16, 5, true), // Tag: TID
        new TdfMemberInfo("TeamIndex", "mTeamIndex", 0xD2993800, TdfType.UInt16, 6, true), // Tag: TIDX
        new TdfMemberInfo("User", "mUser", 0xD73A6400, TdfType.Struct, 7, true), // Tag: USID
    ];
    private ITdfMember[] __members;

    private TdfString _encryptedBlazeId = new(__typeInfos[0]);
    private TdfBool _isOptionalPlayer = new(__typeInfos[1]);
    private TdfString _role = new(__typeInfos[2]);
    private TdfList<string> _roles = new(__typeInfos[3]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.SlotType> _slotType = new(__typeInfos[4]);
    private TdfUInt16 _teamId = new(__typeInfos[5]);
    private TdfUInt16 _teamIndex = new(__typeInfos[6]);
    private TdfStruct<Blaze15SDK.Blaze.UserIdentification?> _user = new(__typeInfos[7]);

    public PerPlayerJoinData()
    {
        __members = [ _encryptedBlazeId, _isOptionalPlayer, _role, _roles, _slotType, _teamId, _teamIndex, _user ];
    }

    public override Tdf CreateNew() => new PerPlayerJoinData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PerPlayerJoinData";
    public override string GetFullClassName() => "Blaze::GameManager::PerPlayerJoinData";

    public string EncryptedBlazeId
    {
        get => _encryptedBlazeId.Value;
        set => _encryptedBlazeId.Value = value;
    }

    public bool IsOptionalPlayer
    {
        get => _isOptionalPlayer.Value;
        set => _isOptionalPlayer.Value = value;
    }

    public string Role
    {
        get => _role.Value;
        set => _role.Value = value;
    }

    public IList<string> Roles
    {
        get => _roles.Value;
        set => _roles.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.SlotType SlotType
    {
        get => _slotType.Value;
        set => _slotType.Value = value;
    }

    public ushort TeamId
    {
        get => _teamId.Value;
        set => _teamId.Value = value;
    }

    public ushort TeamIndex
    {
        get => _teamIndex.Value;
        set => _teamIndex.Value = value;
    }

    public Blaze15SDK.Blaze.UserIdentification? User
    {
        get => _user.Value;
        set => _user.Value = value;
    }

}
