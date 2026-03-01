using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.ByteVault;

public class RecordPayload : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Blob", "mBlob", 0x10150100, TdfType.Blob, 0, true), // data
        new TdfMemberInfo("ContentType", "mContentType", 0x34934500, TdfType.String, 1, true), // mime
    ];
    private ITdfMember[] __members;

    private TdfBlob _blob = new(__typeInfos[0]);
    private TdfString _contentType = new(__typeInfos[1]);

    public RecordPayload()
    {
        __members = [ _blob, _contentType ];
    }

    public override Tdf CreateNew() => new RecordPayload();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RecordPayload";
    public override string GetFullClassName() => "Blaze::ByteVault::RecordPayload";

    public byte[] Blob
    {
        get => _blob.Value;
        set => _blob.Value = value;
    }

    public string ContentType
    {
        get => _contentType.Value;
        set => _contentType.Value = value;
    }

}
