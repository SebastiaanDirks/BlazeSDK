using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class PlayerJoinData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GroupId", "mGroupId", 0x09440C00, TdfType.ObjectId, 0, true), // btpl
        new TdfMemberInfo("DefaultRole", "mDefaultRole", 0x10648C00, TdfType.String, 1, true), // dfrl
        new TdfMemberInfo("GameEntryType", "mGameEntryType", 0x1C539400, TdfType.Enum, 2, true), // gent
        new TdfMemberInfo("PlayerDataList", "mPlayerDataList", 0x40C10C00, TdfType.List, 3, true), // pldl
        new TdfMemberInfo("DefaultSlotType", "mDefaultSlotType", 0x4CC3D400, TdfType.Enum, 4, true), // slot
        new TdfMemberInfo("DefaultTeamId", "mDefaultTeamId", 0x50910000, TdfType.UInt16, 5, true), // tid
        new TdfMemberInfo("DefaultTeamIndex", "mDefaultTeamIndex", 0x50911800, TdfType.UInt16, 6, true), // tidx
    ];
    private ITdfMember[] __members;

    private TdfObjectId _groupId = new(__typeInfos[0]);
    private TdfString _defaultRole = new(__typeInfos[1]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.GameEntryType> _gameEntryType = new(__typeInfos[2]);
    private TdfList<Blaze15SDK.Blaze.GameManager.PerPlayerJoinData> _playerDataList = new(__typeInfos[3]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.SlotType> _defaultSlotType = new(__typeInfos[4]);
    private TdfUInt16 _defaultTeamId = new(__typeInfos[5]);
    private TdfUInt16 _defaultTeamIndex = new(__typeInfos[6]);

    public PlayerJoinData()
    {
        __members = [ _groupId, _defaultRole, _gameEntryType, _playerDataList, _defaultSlotType, _defaultTeamId, _defaultTeamIndex ];
    }

    public override Tdf CreateNew() => new PlayerJoinData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PlayerJoinData";
    public override string GetFullClassName() => "Blaze::GameManager::PlayerJoinData";

    public ObjectId GroupId
    {
        get => _groupId.Value;
        set => _groupId.Value = value;
    }

    public string DefaultRole
    {
        get => _defaultRole.Value;
        set => _defaultRole.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.GameEntryType GameEntryType
    {
        get => _gameEntryType.Value;
        set => _gameEntryType.Value = value;
    }

    public IList<Blaze15SDK.Blaze.GameManager.PerPlayerJoinData> PlayerDataList
    {
        get => _playerDataList.Value;
        set => _playerDataList.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.SlotType DefaultSlotType
    {
        get => _defaultSlotType.Value;
        set => _defaultSlotType.Value = value;
    }

    public ushort DefaultTeamId
    {
        get => _defaultTeamId.Value;
        set => _defaultTeamId.Value = value;
    }

    public ushort DefaultTeamIndex
    {
        get => _defaultTeamIndex.Value;
        set => _defaultTeamIndex.Value = value;
    }

}
