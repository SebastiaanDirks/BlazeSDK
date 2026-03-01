using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class ExpandedPingSiteRuleCriteria : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("LatencyCalcMethod", "mLatencyCalcMethod", 0x30334000, TdfType.Enum, 0, true), // lcm
        new TdfMemberInfo("PingSiteSelectionMethod", "mPingSiteSelectionMethod", 0x4134CD00, TdfType.Enum, 1, true), // pssm
        new TdfMemberInfo("PingSiteWhitelist", "mPingSiteWhitelist", 0x4135CC00, TdfType.List, 2, true), // pswl
        new TdfMemberInfo("SessionMatchCalcMethod", "mSessionMatchCalcMethod", 0x4CD0CD00, TdfType.Enum, 3, true), // smcm
        new TdfMemberInfo("RangeOffsetListName", "mRangeOffsetListName", 0x50830400, TdfType.String, 4, true), // thld
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze15SDK.Blaze.GameManager.LatencyCalcMethod> _latencyCalcMethod = new(__typeInfos[0]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.PingSiteSelectionMethod> _pingSiteSelectionMethod = new(__typeInfos[1]);
    private TdfList<string> _pingSiteWhitelist = new(__typeInfos[2]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.SessionMatchCalcMethod> _sessionMatchCalcMethod = new(__typeInfos[3]);
    private TdfString _rangeOffsetListName = new(__typeInfos[4]);

    public ExpandedPingSiteRuleCriteria()
    {
        __members = [ _latencyCalcMethod, _pingSiteSelectionMethod, _pingSiteWhitelist, _sessionMatchCalcMethod, _rangeOffsetListName ];
    }

    public override Tdf CreateNew() => new ExpandedPingSiteRuleCriteria();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ExpandedPingSiteRuleCriteria";
    public override string GetFullClassName() => "Blaze::GameManager::ExpandedPingSiteRuleCriteria";

    public Blaze15SDK.Blaze.GameManager.LatencyCalcMethod LatencyCalcMethod
    {
        get => _latencyCalcMethod.Value;
        set => _latencyCalcMethod.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.PingSiteSelectionMethod PingSiteSelectionMethod
    {
        get => _pingSiteSelectionMethod.Value;
        set => _pingSiteSelectionMethod.Value = value;
    }

    public IList<string> PingSiteWhitelist
    {
        get => _pingSiteWhitelist.Value;
        set => _pingSiteWhitelist.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.SessionMatchCalcMethod SessionMatchCalcMethod
    {
        get => _sessionMatchCalcMethod.Value;
        set => _sessionMatchCalcMethod.Value = value;
    }

    public string RangeOffsetListName
    {
        get => _rangeOffsetListName.Value;
        set => _rangeOffsetListName.Value = value;
    }

}
