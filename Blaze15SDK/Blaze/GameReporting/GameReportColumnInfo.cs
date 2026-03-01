using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameReporting;

public class GameReportColumnInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Key", "mKey", 0x0CB15900, TdfType.Struct, 0, true), // ckey
        new TdfMemberInfo("Type", "mType", 0x11465000, TdfType.Int32, 1, true), // dtyp
        new TdfMemberInfo("EntityType", "mEntityType", 0x15465000, TdfType.ObjectType, 2, true), // etyp
        new TdfMemberInfo("Format", "mFormat", 0x19235400, TdfType.String, 3, true), // frmt
        new TdfMemberInfo("Kind", "mKind", 0x2C938400, TdfType.String, 4, true), // kind
        new TdfMemberInfo("Desc", "mDesc", 0x3044C300, TdfType.String, 5, true), // ldsc
        new TdfMemberInfo("Metadata", "mMetadata", 0x34550100, TdfType.String, 6, true), // meta
        new TdfMemberInfo("ShortDesc", "mShortDesc", 0x4C44C300, TdfType.String, 7, true), // sdsc
        new TdfMemberInfo("UnknownValue", "mUnknownValue", 0x54E2D600, TdfType.String, 8, true), // unkv
    ];
    private ITdfMember[] __members;

    private TdfStruct<GameReportColumnKey?> _key = new(__typeInfos[0]);
    private TdfInt32 _type = new(__typeInfos[1]);
    private TdfObjectType _entityType = new(__typeInfos[2]);
    private TdfString _format = new(__typeInfos[3]);
    private TdfString _kind = new(__typeInfos[4]);
    private TdfString _desc = new(__typeInfos[5]);
    private TdfString _metadata = new(__typeInfos[6]);
    private TdfString _shortDesc = new(__typeInfos[7]);
    private TdfString _unknownValue = new(__typeInfos[8]);

    public GameReportColumnInfo()
    {
        __members = [ _key, _type, _entityType, _format, _kind, _desc, _metadata, _shortDesc, _unknownValue ];
    }

    public override Tdf CreateNew() => new GameReportColumnInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameReportColumnInfo";
    public override string GetFullClassName() => "Blaze::GameReporting::GameReportColumnInfo";

    public GameReportColumnKey? Key
    {
        get => _key.Value;
        set => _key.Value = value;
    }

    public int Type
    {
        get => _type.Value;
        set => _type.Value = value;
    }

    public ObjectType EntityType
    {
        get => _entityType.Value;
        set => _entityType.Value = value;
    }

    public string Format
    {
        get => _format.Value;
        set => _format.Value = value;
    }

    public string Kind
    {
        get => _kind.Value;
        set => _kind.Value = value;
    }

    public string Desc
    {
        get => _desc.Value;
        set => _desc.Value = value;
    }

    public string Metadata
    {
        get => _metadata.Value;
        set => _metadata.Value = value;
    }

    public string ShortDesc
    {
        get => _shortDesc.Value;
        set => _shortDesc.Value = value;
    }

    public string UnknownValue
    {
        get => _unknownValue.Value;
        set => _unknownValue.Value = value;
    }

}
