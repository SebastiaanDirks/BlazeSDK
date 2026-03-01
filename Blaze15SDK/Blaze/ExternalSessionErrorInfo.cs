using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze;

public class ExternalSessionErrorInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RateLimitInfo", "mRateLimitInfo", 0x48150500, TdfType.Struct, 0, true), // rate
        new TdfMemberInfo("Code", "mCode", 0x0CF10500, TdfType.Int32, 1, true), // code
        new TdfMemberInfo("Message", "mMessage", 0x3454C700, TdfType.String, 2, true), // mesg
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.RateLimitInfo?> _rateLimitInfo = new(__typeInfos[0]);
    private TdfInt32 _code = new(__typeInfos[1]);
    private TdfString _message = new(__typeInfos[2]);

    public ExternalSessionErrorInfo()
    {
        __members = [
            _rateLimitInfo,
            _code,
            _message,
        ];
    }

    public override Tdf CreateNew() => new ExternalSessionErrorInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ExternalSessionErrorInfo";
    public override string GetFullClassName() => "Blaze::ExternalSessionErrorInfo";

    public Blaze15SDK.Blaze.RateLimitInfo? RateLimitInfo
    {
        get => _rateLimitInfo.Value;
        set => _rateLimitInfo.Value = value;
    }

    public int Code
    {
        get => _code.Value;
        set => _code.Value = value;
    }

    public string Message
    {
        get => _message.Value;
        set => _message.Value = value;
    }

}
