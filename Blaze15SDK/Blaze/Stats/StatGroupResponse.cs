using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Stats;

public class StatGroupResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CategoryName", "mCategoryName", 0x0CE04D00, TdfType.String, 0, true), // cnam
        new TdfMemberInfo("Desc", "mDesc", 0x1054C300, TdfType.String, 1, true), // desc
        new TdfMemberInfo("EntityType", "mEntityType", 0x15465000, TdfType.ObjectType, 2, true), // etyp
        new TdfMemberInfo("KeyScopeNameValueMap", "mKeyScopeNameValueMap", 0x2D354D00, TdfType.Map, 3, true), // ksum
        new TdfMemberInfo("Metadata", "mMetadata", 0x34550100, TdfType.String, 4, true), // meta
        new TdfMemberInfo("Name", "mName", 0x38134500, TdfType.String, 5, true), // name
        new TdfMemberInfo("StatDescs", "mStatDescs", 0x4D405400, TdfType.List, 6, true), // stat
    ];
    private ITdfMember[] __members;

    private TdfString _categoryName = new(__typeInfos[0]);
    private TdfString _desc = new(__typeInfos[1]);
    private TdfObjectType _entityType = new(__typeInfos[2]);
    private TdfMap<string, long> _keyScopeNameValueMap = new(__typeInfos[3]);
    private TdfString _metadata = new(__typeInfos[4]);
    private TdfString _name = new(__typeInfos[5]);
    private TdfList<Blaze15SDK.Blaze.Stats.StatDescSummary> _statDescs = new(__typeInfos[6]);

    public StatGroupResponse()
    {
        __members = [ _categoryName, _desc, _entityType, _keyScopeNameValueMap, _metadata, _name, _statDescs ];
    }

    public override Tdf CreateNew() => new StatGroupResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "StatGroupResponse";
    public override string GetFullClassName() => "Blaze::Stats::StatGroupResponse";

    public string CategoryName
    {
        get => _categoryName.Value;
        set => _categoryName.Value = value;
    }

    public string Desc
    {
        get => _desc.Value;
        set => _desc.Value = value;
    }

    public ObjectType EntityType
    {
        get => _entityType.Value;
        set => _entityType.Value = value;
    }

    public IDictionary<string, long> KeyScopeNameValueMap
    {
        get => _keyScopeNameValueMap.Value;
        set => _keyScopeNameValueMap.Value = value;
    }

    public string Metadata
    {
        get => _metadata.Value;
        set => _metadata.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public IList<Blaze15SDK.Blaze.Stats.StatDescSummary> StatDescs
    {
        get => _statDescs.Value;
        set => _statDescs.Value = value;
    }

}
