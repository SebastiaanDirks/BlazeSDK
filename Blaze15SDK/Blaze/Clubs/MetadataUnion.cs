using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Clubs;

public class MetadataUnion : Union
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MetadataString", "mMetadataString", 0x34551300, TdfType.String, 0, false), // mets
        new TdfMemberInfo("MetadataBlob", "mMetadataBlob", 0x34550200, TdfType.Blob, 1, false), // metb
    ];

    private TdfString _metadataString = new(__typeInfos[0]);
    private TdfBlob _metadataBlob = new(__typeInfos[1]);

    public override ITdfMember? GetActiveMember()
    {
        return ActiveIndex switch
        {
            0 => _metadataString,
            1 => _metadataBlob,
            _ => null
        };
    }
    public override Tdf CreateNew() => new MetadataUnion();
    public override string GetClassName() => "MetadataUnion";
    public override string GetFullClassName() => "Blaze::Clubs::MetadataUnion";

    public string MetadataString
    {
        get => _metadataString.Value;
        set
        {
            SwitchActiveIndex(0);
            _metadataString.Value = value;
        }
    }

    public byte[] MetadataBlob
    {
        get => _metadataBlob.Value;
        set
        {
            SwitchActiveIndex(1);
            _metadataBlob.Value = value;
        }
    }

}
