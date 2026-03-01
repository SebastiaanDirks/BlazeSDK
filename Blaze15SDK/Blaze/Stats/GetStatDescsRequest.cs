using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Stats;

public class GetStatDescsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Category", "mCategory", 0x0C150000, TdfType.String, 0, true), // cat
        new TdfMemberInfo("StatNames", "mStatNames", 0x4D405400, TdfType.List, 1, true), // stat
    ];
    private ITdfMember[] __members;

    private TdfString _category = new(__typeInfos[0]);
    private TdfList<string> _statNames = new(__typeInfos[1]);

    public GetStatDescsRequest()
    {
        __members = [ _category, _statNames ];
    }

    public override Tdf CreateNew() => new GetStatDescsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetStatDescsRequest";
    public override string GetFullClassName() => "Blaze::Stats::GetStatDescsRequest";

    public string Category
    {
        get => _category.Value;
        set => _category.Value = value;
    }

    public IList<string> StatNames
    {
        get => _statNames.Value;
        set => _statNames.Value = value;
    }

}
