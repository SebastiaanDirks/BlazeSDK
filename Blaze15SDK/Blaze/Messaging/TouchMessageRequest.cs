using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Messaging;

public class TouchMessageRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Flags", "mFlags", 0x18C04700, TdfType.Enum, 0, true), // flag
        new TdfMemberInfo("MessageId", "mMessageId", 0x34724400, TdfType.UInt64, 1, true), // mgid
        new TdfMemberInfo("StatusMask", "mStatusMask", 0x4CD4CB00, TdfType.UInt32, 2, true), // smsk
        new TdfMemberInfo("Source", "mSource", 0x4D20C500, TdfType.ObjectId, 3, true), // srce
        new TdfMemberInfo("Status", "mStatus", 0x4D405400, TdfType.UInt32, 4, true), // stat
        new TdfMemberInfo("Target", "mTarget", 0x50148700, TdfType.ObjectId, 5, true), // targ
        new TdfMemberInfo("TouchStatusMask", "mTouchStatusMask", 0x50D4CB00, TdfType.UInt32, 6, true), // tmsk
        new TdfMemberInfo("TouchStatus", "mTouchStatus", 0x51350100, TdfType.UInt32, 7, true), // tsta
        new TdfMemberInfo("Type", "mType", 0x51940500, TdfType.UInt32, 8, true), // type
    ];
    private ITdfMember[] __members;

    private TdfEnum<MatchFlags> _flags = new(__typeInfos[0]);
    private TdfUInt64 _messageId = new(__typeInfos[1]);
    private TdfUInt32 _statusMask = new(__typeInfos[2]);
    private TdfObjectId _source = new(__typeInfos[3]);
    private TdfUInt32 _status = new(__typeInfos[4]);
    private TdfObjectId _target = new(__typeInfos[5]);
    private TdfUInt32 _touchStatusMask = new(__typeInfos[6]);
    private TdfUInt32 _touchStatus = new(__typeInfos[7]);
    private TdfUInt32 _type = new(__typeInfos[8]);

    public TouchMessageRequest()
    {
        __members = [ _flags, _messageId, _statusMask, _source, _status, _target, _touchStatusMask, _touchStatus, _type ];
    }

    public override Tdf CreateNew() => new TouchMessageRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "TouchMessageRequest";
    public override string GetFullClassName() => "Blaze::Messaging::TouchMessageRequest";

    public MatchFlags Flags
    {
        get => _flags.Value;
        set => _flags.Value = value;
    }

    public ulong MessageId
    {
        get => _messageId.Value;
        set => _messageId.Value = value;
    }

    public uint StatusMask
    {
        get => _statusMask.Value;
        set => _statusMask.Value = value;
    }

    public ObjectId Source
    {
        get => _source.Value;
        set => _source.Value = value;
    }

    public uint Status
    {
        get => _status.Value;
        set => _status.Value = value;
    }

    public ObjectId Target
    {
        get => _target.Value;
        set => _target.Value = value;
    }

    public uint TouchStatusMask
    {
        get => _touchStatusMask.Value;
        set => _touchStatusMask.Value = value;
    }

    public uint TouchStatus
    {
        get => _touchStatus.Value;
        set => _touchStatus.Value = value;
    }

    public uint Type
    {
        get => _type.Value;
        set => _type.Value = value;
    }

}
