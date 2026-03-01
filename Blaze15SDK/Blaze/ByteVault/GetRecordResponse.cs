using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.ByteVault;

public class GetRecordResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Creation", "mCreation", 0x0D214100, TdfType.Int64, 0, true), // crea
        new TdfMemberInfo("Payload", "mPayload", 0x30F04400, TdfType.Struct, 1, true), // load
        new TdfMemberInfo("Location", "mLocation", 0x30F0C000, TdfType.String, 2, true), // loc
        new TdfMemberInfo("IsRemoteResource", "mIsRemoteResource", 0x48D3D400, TdfType.Bool, 3, true), // rmot
        new TdfMemberInfo("LastUpdate", "mLastUpdate", 0x55011400, TdfType.Int64, 4, true), // updt
    ];
    private ITdfMember[] __members;

    private TdfInt64 _creation = new(__typeInfos[0]);
    private TdfStruct<Blaze15SDK.Blaze.ByteVault.RecordPayload?> _payload = new(__typeInfos[1]);
    private TdfString _location = new(__typeInfos[2]);
    private TdfBool _isRemoteResource = new(__typeInfos[3]);
    private TdfInt64 _lastUpdate = new(__typeInfos[4]);

    public GetRecordResponse()
    {
        __members = [ _creation, _payload, _location, _isRemoteResource, _lastUpdate ];
    }

    public override Tdf CreateNew() => new GetRecordResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetRecordResponse";
    public override string GetFullClassName() => "Blaze::ByteVault::GetRecordResponse";

    public long Creation
    {
        get => _creation.Value;
        set => _creation.Value = value;
    }

    public Blaze15SDK.Blaze.ByteVault.RecordPayload? Payload
    {
        get => _payload.Value;
        set => _payload.Value = value;
    }

    public string Location
    {
        get => _location.Value;
        set => _location.Value = value;
    }

    public bool IsRemoteResource
    {
        get => _isRemoteResource.Value;
        set => _isRemoteResource.Value = value;
    }

    public long LastUpdate
    {
        get => _lastUpdate.Value;
        set => _lastUpdate.Value = value;
    }

}
