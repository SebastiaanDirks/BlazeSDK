using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Messaging;

public class PurgeMessageRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Flags", "mFlags", 0x18C04700, TdfType.Enum, 0, true), // flag
        new TdfMemberInfo("MessageId", "mMessageId", 0x34724400, TdfType.UInt64, 1, true), // mgid
        new TdfMemberInfo("StatusMask", "mStatusMask", 0x4CD4CB00, TdfType.UInt32, 2, true), // smsk
        new TdfMemberInfo("Source", "mSource", 0x4D20C500, TdfType.ObjectId, 3, true), // srce
        new TdfMemberInfo("Status", "mStatus", 0x4D405400, TdfType.UInt32, 4, true), // stat
        new TdfMemberInfo("Type", "mType", 0x51940500, TdfType.UInt32, 5, true), // type
    ];
    private ITdfMember[] __members;

    private TdfEnum<MatchFlags> _flags = new(__typeInfos[0]);
    private TdfUInt64 _messageId = new(__typeInfos[1]);
    private TdfUInt32 _statusMask = new(__typeInfos[2]);
    private TdfObjectId _source = new(__typeInfos[3]);
    private TdfUInt32 _status = new(__typeInfos[4]);
    private TdfUInt32 _type = new(__typeInfos[5]);

    public PurgeMessageRequest()
    {
        __members = [ _flags, _messageId, _statusMask, _source, _status, _type ];
    }

    public override Tdf CreateNew() => new PurgeMessageRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PurgeMessageRequest";
    public override string GetFullClassName() => "Blaze::Messaging::PurgeMessageRequest";

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

    public uint Type
    {
        get => _type.Value;
        set => _type.Value = value;
    }

}
