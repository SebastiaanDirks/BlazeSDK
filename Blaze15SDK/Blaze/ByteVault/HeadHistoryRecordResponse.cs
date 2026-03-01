using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.ByteVault;

public class HeadHistoryRecordResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Archived", "mArchived", 0x0520C800, TdfType.Bool, 0, true), // arch
        new TdfMemberInfo("Creation", "mCreation", 0x0D214100, TdfType.Int64, 1, true), // crea
        new TdfMemberInfo("Location", "mLocation", 0x30F0C000, TdfType.String, 2, true), // loc
        new TdfMemberInfo("ContentType", "mContentType", 0x34934500, TdfType.String, 3, true), // mime
        new TdfMemberInfo("IsRemoteResource", "mIsRemoteResource", 0x48D3D400, TdfType.Bool, 4, true), // rmot
        new TdfMemberInfo("PayloadSize", "mPayloadSize", 0x4C968500, TdfType.UInt32, 5, true), // size
        new TdfMemberInfo("LastUpdate", "mLastUpdate", 0x55011400, TdfType.Int64, 6, true), // updt
    ];
    private ITdfMember[] __members;

    private TdfBool _archived = new(__typeInfos[0]);
    private TdfInt64 _creation = new(__typeInfos[1]);
    private TdfString _location = new(__typeInfos[2]);
    private TdfString _contentType = new(__typeInfos[3]);
    private TdfBool _isRemoteResource = new(__typeInfos[4]);
    private TdfUInt32 _payloadSize = new(__typeInfos[5]);
    private TdfInt64 _lastUpdate = new(__typeInfos[6]);

    public HeadHistoryRecordResponse()
    {
        __members = [ _archived, _creation, _location, _contentType, _isRemoteResource, _payloadSize, _lastUpdate ];
    }

    public override Tdf CreateNew() => new HeadHistoryRecordResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "HeadHistoryRecordResponse";
    public override string GetFullClassName() => "Blaze::ByteVault::HeadHistoryRecordResponse";

    public bool Archived
    {
        get => _archived.Value;
        set => _archived.Value = value;
    }

    public long Creation
    {
        get => _creation.Value;
        set => _creation.Value = value;
    }

    public string Location
    {
        get => _location.Value;
        set => _location.Value = value;
    }

    public string ContentType
    {
        get => _contentType.Value;
        set => _contentType.Value = value;
    }

    public bool IsRemoteResource
    {
        get => _isRemoteResource.Value;
        set => _isRemoteResource.Value = value;
    }

    public uint PayloadSize
    {
        get => _payloadSize.Value;
        set => _payloadSize.Value = value;
    }

    public long LastUpdate
    {
        get => _lastUpdate.Value;
        set => _lastUpdate.Value = value;
    }

}
