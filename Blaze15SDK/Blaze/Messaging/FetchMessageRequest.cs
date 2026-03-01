using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Messaging;

public class FetchMessageRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Flags", "mFlags", 0x18C04700, TdfType.Enum, 0, true), // flag
        new TdfMemberInfo("MessageId", "mMessageId", 0x34724400, TdfType.UInt64, 1, true), // mgid
        new TdfMemberInfo("PageIndex", "mPageIndex", 0x40911800, TdfType.UInt32, 2, true), // pidx
        new TdfMemberInfo("PageSize", "mPageSize", 0x41325A00, TdfType.UInt32, 3, true), // psiz
        new TdfMemberInfo("StatusMask", "mStatusMask", 0x4CD4CB00, TdfType.UInt32, 4, true), // smsk
        new TdfMemberInfo("OrderBy", "mOrderBy", 0x4CF49400, TdfType.Enum, 5, true), // sort
        new TdfMemberInfo("Source", "mSource", 0x4D20C500, TdfType.ObjectId, 6, true), // srce
        new TdfMemberInfo("Status", "mStatus", 0x4D405400, TdfType.UInt32, 7, true), // stat
        new TdfMemberInfo("Target", "mTarget", 0x50148700, TdfType.ObjectId, 8, true), // targ
        new TdfMemberInfo("Type", "mType", 0x51940500, TdfType.UInt32, 9, true), // type
        new TdfMemberInfo("TypeList", "mTypeList", 0x51940C00, TdfType.List, 10, true), // typl
    ];
    private ITdfMember[] __members;

    private TdfEnum<MatchFlags> _flags = new(__typeInfos[0]);
    private TdfUInt64 _messageId = new(__typeInfos[1]);
    private TdfUInt32 _pageIndex = new(__typeInfos[2]);
    private TdfUInt32 _pageSize = new(__typeInfos[3]);
    private TdfUInt32 _statusMask = new(__typeInfos[4]);
    private TdfEnum<MessageOrder> _orderBy = new(__typeInfos[5]);
    private TdfObjectId _source = new(__typeInfos[6]);
    private TdfUInt32 _status = new(__typeInfos[7]);
    private TdfObjectId _target = new(__typeInfos[8]);
    private TdfUInt32 _type = new(__typeInfos[9]);
    private TdfList<uint> _typeList = new(__typeInfos[10]);

    public FetchMessageRequest()
    {
        __members = [ _flags, _messageId, _pageIndex, _pageSize, _statusMask, _orderBy, _source, _status, _target, _type, _typeList ];
    }

    public override Tdf CreateNew() => new FetchMessageRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FetchMessageRequest";
    public override string GetFullClassName() => "Blaze::Messaging::FetchMessageRequest";

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

    public uint PageIndex
    {
        get => _pageIndex.Value;
        set => _pageIndex.Value = value;
    }

    public uint PageSize
    {
        get => _pageSize.Value;
        set => _pageSize.Value = value;
    }

    public uint StatusMask
    {
        get => _statusMask.Value;
        set => _statusMask.Value = value;
    }

    public MessageOrder OrderBy
    {
        get => _orderBy.Value;
        set => _orderBy.Value = value;
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

    public uint Type
    {
        get => _type.Value;
        set => _type.Value = value;
    }

    public IList<uint> TypeList
    {
        get => _typeList.Value;
        set => _typeList.Value = value;
    }

}
