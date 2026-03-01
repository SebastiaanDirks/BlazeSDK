using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class UEDRuleStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MaxUEDAccepted", "mMaxUEDAccepted", 0x04D05800, TdfType.Int64, 0, true), // amax
        new TdfMemberInfo("MinUEDAccepted", "mMinUEDAccepted", 0x04D24E00, TdfType.Int64, 1, true), // amin
        new TdfMemberInfo("MyUEDValue", "mMyUEDValue", 0x35514400, TdfType.Int64, 2, true), // mued
        new TdfMemberInfo("RuleName", "mRuleName", 0x38134500, TdfType.String, 3, true), // name
    ];
    private ITdfMember[] __members;

    private TdfInt64 _maxUEDAccepted = new(__typeInfos[0]);
    private TdfInt64 _minUEDAccepted = new(__typeInfos[1]);
    private TdfInt64 _myUEDValue = new(__typeInfos[2]);
    private TdfString _ruleName = new(__typeInfos[3]);

    public UEDRuleStatus()
    {
        __members = [ _maxUEDAccepted, _minUEDAccepted, _myUEDValue, _ruleName ];
    }

    public override Tdf CreateNew() => new UEDRuleStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UEDRuleStatus";
    public override string GetFullClassName() => "Blaze::GameManager::UEDRuleStatus";

    public long MaxUEDAccepted
    {
        get => _maxUEDAccepted.Value;
        set => _maxUEDAccepted.Value = value;
    }

    public long MinUEDAccepted
    {
        get => _minUEDAccepted.Value;
        set => _minUEDAccepted.Value = value;
    }

    public long MyUEDValue
    {
        get => _myUEDValue.Value;
        set => _myUEDValue.Value = value;
    }

    public string RuleName
    {
        get => _ruleName.Value;
        set => _ruleName.Value = value;
    }

}
