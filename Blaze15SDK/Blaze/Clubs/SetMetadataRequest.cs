using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Clubs;

public class SetMetadataRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x0CC24400, TdfType.UInt64, 0, true), // clid
        new TdfMemberInfo("MetaData", "mMetaData", 0x34550400, TdfType.String, 1, true), // metd
        new TdfMemberInfo("MetaDataUnion", "mMetaDataUnion", 0x35411500, TdfType.Struct, 2, true), // mtdu
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _clubId = new(__typeInfos[0]);
    private TdfString _metaData = new(__typeInfos[1]);
    private TdfStruct<MetadataUnion?> _metaDataUnion = new(__typeInfos[2]);

    public SetMetadataRequest()
    {
        __members = [ _clubId, _metaData, _metaDataUnion ];
    }

    public override Tdf CreateNew() => new SetMetadataRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetMetadataRequest";
    public override string GetFullClassName() => "Blaze::Clubs::SetMetadataRequest";

    public ulong ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public string MetaData
    {
        get => _metaData.Value;
        set => _metaData.Value = value;
    }

    public MetadataUnion? MetaDataUnion
    {
        get => _metaDataUnion.Value;
        set => _metaDataUnion.Value = value;
    }

}
