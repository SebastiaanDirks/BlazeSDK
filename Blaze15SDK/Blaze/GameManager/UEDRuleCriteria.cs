using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class UEDRuleCriteria : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClientUEDSearchValue", "mClientUEDSearchValue", 0x0D604C00, TdfType.Int64, 0, true), // cval
        new TdfMemberInfo("OverrideUEDValue", "mOverrideUEDValue", 0x3D604C00, TdfType.Int64, 1, true), // oval
        new TdfMemberInfo("ThresholdName", "mThresholdName", 0x50830400, TdfType.String, 2, true), // thld
    ];
    private ITdfMember[] __members;

    private TdfInt64 _clientUEDSearchValue = new(__typeInfos[0]);
    private TdfInt64 _overrideUEDValue = new(__typeInfos[1]);
    private TdfString _thresholdName = new(__typeInfos[2]);

    public UEDRuleCriteria()
    {
        __members = [ _clientUEDSearchValue, _overrideUEDValue, _thresholdName ];
    }

    public override Tdf CreateNew() => new UEDRuleCriteria();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UEDRuleCriteria";
    public override string GetFullClassName() => "Blaze::GameManager::UEDRuleCriteria";

    public long ClientUEDSearchValue
    {
        get => _clientUEDSearchValue.Value;
        set => _clientUEDSearchValue.Value = value;
    }

    public long OverrideUEDValue
    {
        get => _overrideUEDValue.Value;
        set => _overrideUEDValue.Value = value;
    }

    public string ThresholdName
    {
        get => _thresholdName.Value;
        set => _thresholdName.Value = value;
    }

}
