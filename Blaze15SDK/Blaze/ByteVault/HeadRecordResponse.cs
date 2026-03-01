using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.ByteVault;

public class HeadRecordResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Creation", "mCreation", 0x0D214100, TdfType.Int64, 0, true), // crea
        new TdfMemberInfo("Location", "mLocation", 0x30F0C000, TdfType.String, 1, true), // loc
        new TdfMemberInfo("ContentType", "mContentType", 0x34934500, TdfType.String, 2, true), // mime
        new TdfMemberInfo("IsRemoteResource", "mIsRemoteResource", 0x48D3D400, TdfType.Bool, 3, true), // rmot
        new TdfMemberInfo("PayloadSize", "mPayloadSize", 0x4C968500, TdfType.UInt32, 4, true), // size
        new TdfMemberInfo("LastUpdate", "mLastUpdate", 0x55011400, TdfType.Int64, 5, true), // updt
    ];
    private ITdfMember[] __members;

    private TdfInt64 _creation = new(__typeInfos[0]);
    private TdfString _location = new(__typeInfos[1]);
    private TdfString _contentType = new(__typeInfos[2]);
    private TdfBool _isRemoteResource = new(__typeInfos[3]);
    private TdfUInt32 _payloadSize = new(__typeInfos[4]);
    private TdfInt64 _lastUpdate = new(__typeInfos[5]);

    public HeadRecordResponse()
    {
        __members = [ _creation, _location, _contentType, _isRemoteResource, _payloadSize, _lastUpdate ];
    }

    public override Tdf CreateNew() => new HeadRecordResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "HeadRecordResponse";
    public override string GetFullClassName() => "Blaze::ByteVault::HeadRecordResponse";

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
