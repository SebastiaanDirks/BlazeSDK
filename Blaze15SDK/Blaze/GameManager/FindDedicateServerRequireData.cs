using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class FindDedicateServerRequireData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MinFitThresholdValue", "mMinFitThresholdValue", 0xD28B2400, TdfType.Float, 0, true), // Tag: THLD
    ];
    private ITdfMember[] __members;

    private TdfFloat _minFitThresholdValue = new(__typeInfos[0]);

    public FindDedicateServerRequireData()
    {
        __members = [ _minFitThresholdValue ];
    }

    public override Tdf CreateNew() => new FindDedicateServerRequireData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FindDedicateServerRequireData";
    public override string GetFullClassName() => "Blaze::GameManager::FindDedicateServerRequireData";

    public float MinFitThresholdValue
    {
        get => _minFitThresholdValue.Value;
        set => _minFitThresholdValue.Value = value;
    }

}
