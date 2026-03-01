using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Messaging;

public class ClientMessage : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AttrMap", "mAttrMap", 0x05451200, TdfType.Map, 0, true), // attr
        new TdfMemberInfo("Flags", "mFlags", 0x18C04700, TdfType.Enum, 1, true), // flag
        new TdfMemberInfo("Status", "mStatus", 0x4D405400, TdfType.UInt32, 2, true), // stat
        new TdfMemberInfo("Tag", "mTag", 0x5011C000, TdfType.UInt32, 3, true), // tag
        new TdfMemberInfo("TargetIds", "mTargetIds", 0x50911300, TdfType.List, 4, true), // tids
        new TdfMemberInfo("TargetType", "mTargetType", 0x51465000, TdfType.ObjectType, 5, true), // ttyp
        new TdfMemberInfo("Type", "mType", 0x51940500, TdfType.UInt32, 6, true), // type
    ];
    private ITdfMember[] __members;

    private TdfMap<uint, string> _attrMap = new(__typeInfos[0]);
    private TdfEnum<MessageFlags> _flags = new(__typeInfos[1]);
    private TdfUInt32 _status = new(__typeInfos[2]);
    private TdfUInt32 _tag = new(__typeInfos[3]);
    private TdfList<long> _targetIds = new(__typeInfos[4]);
    private TdfObjectType _targetType = new(__typeInfos[5]);
    private TdfUInt32 _type = new(__typeInfos[6]);

    public ClientMessage()
    {
        __members = [ _attrMap, _flags, _status, _tag, _targetIds, _targetType, _type ];
    }

    public override Tdf CreateNew() => new ClientMessage();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClientMessage";
    public override string GetFullClassName() => "Blaze::Messaging::ClientMessage";

    public IDictionary<uint, string> AttrMap
    {
        get => _attrMap.Value;
        set => _attrMap.Value = value;
    }

    public MessageFlags Flags
    {
        get => _flags.Value;
        set => _flags.Value = value;
    }

    public uint Status
    {
        get => _status.Value;
        set => _status.Value = value;
    }

    public uint Tag
    {
        get => _tag.Value;
        set => _tag.Value = value;
    }

    public IList<long> TargetIds
    {
        get => _targetIds.Value;
        set => _targetIds.Value = value;
    }

    public ObjectType TargetType
    {
        get => _targetType.Value;
        set => _targetType.Value = value;
    }

    public uint Type
    {
        get => _type.Value;
        set => _type.Value = value;
    }

}
