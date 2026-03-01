using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze;

public class RateLimitInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RateLimitNextAvailable", "mRateLimitNextAvailable", 0x49438100, TdfType.Float, 0, true), // rtna
        new TdfMemberInfo("RateLimitTimePeriod", "mRateLimitTimePeriod", 0x49451000, TdfType.String, 1, true), // rttp
        new TdfMemberInfo("RateLimitLimit", "mRateLimitLimit", 0x49430900, TdfType.UInt16, 2, true), // rtli
        new TdfMemberInfo("RateLimitRemaining", "mRateLimitRemaining", 0x49448500, TdfType.UInt16, 3, true), // rtre
        new TdfMemberInfo("Context", "mContext", 0x0CE51800, TdfType.String, 4, true), // cntx
    ];
    private ITdfMember[] __members;

    private TdfFloat _rateLimitNextAvailable = new(__typeInfos[0]);
    private TdfString _rateLimitTimePeriod = new(__typeInfos[1]);
    private TdfUInt16 _rateLimitLimit = new(__typeInfos[2]);
    private TdfUInt16 _rateLimitRemaining = new(__typeInfos[3]);
    private TdfString _context = new(__typeInfos[4]);

    public RateLimitInfo()
    {
        __members = [
            _rateLimitNextAvailable,
            _rateLimitTimePeriod,
            _rateLimitLimit,
            _rateLimitRemaining,
            _context,
        ];
    }

    public override Tdf CreateNew() => new RateLimitInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RateLimitInfo";
    public override string GetFullClassName() => "Blaze::RateLimitInfo";

    public float RateLimitNextAvailable
    {
        get => _rateLimitNextAvailable.Value;
        set => _rateLimitNextAvailable.Value = value;
    }

    public string RateLimitTimePeriod
    {
        get => _rateLimitTimePeriod.Value;
        set => _rateLimitTimePeriod.Value = value;
    }

    public ushort RateLimitLimit
    {
        get => _rateLimitLimit.Value;
        set => _rateLimitLimit.Value = value;
    }

    public ushort RateLimitRemaining
    {
        get => _rateLimitRemaining.Value;
        set => _rateLimitRemaining.Value = value;
    }

    public string Context
    {
        get => _context.Value;
        set => _context.Value = value;
    }

}
