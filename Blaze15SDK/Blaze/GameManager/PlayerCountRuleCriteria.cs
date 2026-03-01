using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class PlayerCountRuleCriteria : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("IsSingleGroupMatch", "mIsSingleGroupMatch", 0x2534C700, TdfType.UInt8, 0, true), // issg
        new TdfMemberInfo("MaxPlayerCount", "mMaxPlayerCount", 0x40305000, TdfType.UInt16, 1, true), // pcap
        new TdfMemberInfo("DesiredPlayerCount", "mDesiredPlayerCount", 0x40339400, TdfType.UInt16, 2, true), // pcnt
        new TdfMemberInfo("MinPlayerCount", "mMinPlayerCount", 0x40D24E00, TdfType.UInt16, 3, true), // pmin
        new TdfMemberInfo("RangeOffsetListName", "mRangeOffsetListName", 0x50830400, TdfType.String, 4, true), // thld
    ];
    private ITdfMember[] __members;

    private TdfUInt8 _isSingleGroupMatch = new(__typeInfos[0]);
    private TdfUInt16 _maxPlayerCount = new(__typeInfos[1]);
    private TdfUInt16 _desiredPlayerCount = new(__typeInfos[2]);
    private TdfUInt16 _minPlayerCount = new(__typeInfos[3]);
    private TdfString _rangeOffsetListName = new(__typeInfos[4]);

    public PlayerCountRuleCriteria()
    {
        __members = [ _isSingleGroupMatch, _maxPlayerCount, _desiredPlayerCount, _minPlayerCount, _rangeOffsetListName ];
    }

    public override Tdf CreateNew() => new PlayerCountRuleCriteria();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PlayerCountRuleCriteria";
    public override string GetFullClassName() => "Blaze::GameManager::PlayerCountRuleCriteria";

    public byte IsSingleGroupMatch
    {
        get => _isSingleGroupMatch.Value;
        set => _isSingleGroupMatch.Value = value;
    }

    public ushort MaxPlayerCount
    {
        get => _maxPlayerCount.Value;
        set => _maxPlayerCount.Value = value;
    }

    public ushort DesiredPlayerCount
    {
        get => _desiredPlayerCount.Value;
        set => _desiredPlayerCount.Value = value;
    }

    public ushort MinPlayerCount
    {
        get => _minPlayerCount.Value;
        set => _minPlayerCount.Value = value;
    }

    public string RangeOffsetListName
    {
        get => _rangeOffsetListName.Value;
        set => _rangeOffsetListName.Value = value;
    }

}
