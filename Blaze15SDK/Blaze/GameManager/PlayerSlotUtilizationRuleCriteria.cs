using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class PlayerSlotUtilizationRuleCriteria : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DesiredPercentFull", "mDesiredPercentFull", 0x1054D000, TdfType.UInt8, 0, true), // desp
        new TdfMemberInfo("MaxPercentFull", "mMaxPercentFull", 0x34161000, TdfType.UInt8, 1, true), // maxp
        new TdfMemberInfo("MinPercentFull", "mMinPercentFull", 0x34939000, TdfType.UInt8, 2, true), // minp
        new TdfMemberInfo("RangeOffsetListName", "mRangeOffsetListName", 0x50830400, TdfType.String, 3, true), // thld
    ];
    private ITdfMember[] __members;

    private TdfUInt8 _desiredPercentFull = new(__typeInfos[0]);
    private TdfUInt8 _maxPercentFull = new(__typeInfos[1]);
    private TdfUInt8 _minPercentFull = new(__typeInfos[2]);
    private TdfString _rangeOffsetListName = new(__typeInfos[3]);

    public PlayerSlotUtilizationRuleCriteria()
    {
        __members = [ _desiredPercentFull, _maxPercentFull, _minPercentFull, _rangeOffsetListName ];
    }

    public override Tdf CreateNew() => new PlayerSlotUtilizationRuleCriteria();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PlayerSlotUtilizationRuleCriteria";
    public override string GetFullClassName() => "Blaze::GameManager::PlayerSlotUtilizationRuleCriteria";

    public byte DesiredPercentFull
    {
        get => _desiredPercentFull.Value;
        set => _desiredPercentFull.Value = value;
    }

    public byte MaxPercentFull
    {
        get => _maxPercentFull.Value;
        set => _maxPercentFull.Value = value;
    }

    public byte MinPercentFull
    {
        get => _minPercentFull.Value;
        set => _minPercentFull.Value = value;
    }

    public string RangeOffsetListName
    {
        get => _rangeOffsetListName.Value;
        set => _rangeOffsetListName.Value = value;
    }

}
