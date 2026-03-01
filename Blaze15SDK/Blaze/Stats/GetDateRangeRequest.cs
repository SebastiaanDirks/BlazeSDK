using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Stats;

public class GetDateRangeRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Category", "mCategory", 0x0C150000, TdfType.String, 0, true), // cat
        new TdfMemberInfo("PeriodOffset", "mPeriodOffset", 0x40F18600, TdfType.Int32, 1, true), // poff
        new TdfMemberInfo("PeriodId", "mPeriodId", 0x41224400, TdfType.Int32, 2, true), // prid
        new TdfMemberInfo("PeriodType", "mPeriodType", 0x41465000, TdfType.Int32, 3, true), // ptyp
    ];
    private ITdfMember[] __members;

    private TdfString _category = new(__typeInfos[0]);
    private TdfInt32 _periodOffset = new(__typeInfos[1]);
    private TdfInt32 _periodId = new(__typeInfos[2]);
    private TdfInt32 _periodType = new(__typeInfos[3]);

    public GetDateRangeRequest()
    {
        __members = [ _category, _periodOffset, _periodId, _periodType ];
    }

    public override Tdf CreateNew() => new GetDateRangeRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetDateRangeRequest";
    public override string GetFullClassName() => "Blaze::Stats::GetDateRangeRequest";

    public string Category
    {
        get => _category.Value;
        set => _category.Value = value;
    }

    public int PeriodOffset
    {
        get => _periodOffset.Value;
        set => _periodOffset.Value = value;
    }

    public int PeriodId
    {
        get => _periodId.Value;
        set => _periodId.Value = value;
    }

    public int PeriodType
    {
        get => _periodType.Value;
        set => _periodType.Value = value;
    }

}
