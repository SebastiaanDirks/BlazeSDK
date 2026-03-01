using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Stats;

public class LeaderboardStatValuesRow : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Rank", "mRank", 0x48138B00, TdfType.Int32, 0, true), // rank
        new TdfMemberInfo("RankedStat", "mRankedStat", 0x49350100, TdfType.String, 1, true), // rsta
        new TdfMemberInfo("IsRawStats", "mIsRawStats", 0x49718700, TdfType.Bool, 2, true), // rwfg
        new TdfMemberInfo("OtherRawStats", "mOtherRawStats", 0x4973D400, TdfType.List, 3, true), // rwot
        new TdfMemberInfo("RankedRawStat", "mRankedRawStat", 0x4974D400, TdfType.Struct, 4, true), // rwst
        new TdfMemberInfo("OtherStats", "mOtherStats", 0x4D405400, TdfType.List, 5, true), // stat
        new TdfMemberInfo("Attribute", "mAttribute", 0x54151400, TdfType.UInt64, 6, true), // uatt
        new TdfMemberInfo("User", "mUser", 0x55315200, TdfType.Struct, 7, true), // user
    ];
    private ITdfMember[] __members;

    private TdfInt32 _rank = new(__typeInfos[0]);
    private TdfString _rankedStat = new(__typeInfos[1]);
    private TdfBool _isRawStats = new(__typeInfos[2]);
    private TdfList<Blaze15SDK.Blaze.Stats.StatRawValue> _otherRawStats = new(__typeInfos[3]);
    private TdfStruct<Blaze15SDK.Blaze.Stats.StatRawValue?> _rankedRawStat = new(__typeInfos[4]);
    private TdfList<string> _otherStats = new(__typeInfos[5]);
    private TdfUInt64 _attribute = new(__typeInfos[6]);
    private TdfStruct<Blaze15SDK.Blaze.CoreIdentification?> _user = new(__typeInfos[7]);

    public LeaderboardStatValuesRow()
    {
        __members = [ _rank, _rankedStat, _isRawStats, _otherRawStats, _rankedRawStat, _otherStats, _attribute, _user ];
    }

    public override Tdf CreateNew() => new LeaderboardStatValuesRow();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LeaderboardStatValuesRow";
    public override string GetFullClassName() => "Blaze::Stats::LeaderboardStatValuesRow";

    public int Rank
    {
        get => _rank.Value;
        set => _rank.Value = value;
    }

    public string RankedStat
    {
        get => _rankedStat.Value;
        set => _rankedStat.Value = value;
    }

    public bool IsRawStats
    {
        get => _isRawStats.Value;
        set => _isRawStats.Value = value;
    }

    public IList<Blaze15SDK.Blaze.Stats.StatRawValue> OtherRawStats
    {
        get => _otherRawStats.Value;
        set => _otherRawStats.Value = value;
    }

    public Blaze15SDK.Blaze.Stats.StatRawValue? RankedRawStat
    {
        get => _rankedRawStat.Value;
        set => _rankedRawStat.Value = value;
    }

    public IList<string> OtherStats
    {
        get => _otherStats.Value;
        set => _otherStats.Value = value;
    }

    public ulong Attribute
    {
        get => _attribute.Value;
        set => _attribute.Value = value;
    }

    public Blaze15SDK.Blaze.CoreIdentification? User
    {
        get => _user.Value;
        set => _user.Value = value;
    }

}
