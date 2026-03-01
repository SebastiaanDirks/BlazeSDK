using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Achievements;

public class UserHistoryData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("A", "mA", 0x04824400, TdfType.String, 0, true), // ahid
        new TdfMemberInfo("C", "mC", 0x0CE50000, TdfType.UInt32, 1, true), // cnt
        new TdfMemberInfo("D", "mD", 0x10558300, TdfType.String, 2, true), // devc
        new TdfMemberInfo("G", "mG", 0x4123C400, TdfType.String, 3, true), // prod
        new TdfMemberInfo("P", "mP", 0x4144C000, TdfType.Int64, 4, true), // pts
        new TdfMemberInfo("Requirements", "mRequirements", 0x48544C00, TdfType.List, 5, true), // reql
        new TdfMemberInfo("R", "mR", 0x48558000, TdfType.String, 6, true), // rev
        new TdfMemberInfo("Rp", "mRp", 0x49051300, TdfType.Int64, 7, true), // rpts
        new TdfMemberInfo("Ti", "mTi", 0x50915200, TdfType.Int8, 8, true), // tier
        new TdfMemberInfo("T", "mT", 0x50934500, TdfType.Int64, 9, true), // time
        new TdfMemberInfo("Xpack", "mXpack", 0x61004300, TdfType.Struct, 10, true), // xpac
        new TdfMemberInfo("Xp", "mXp", 0x61051300, TdfType.Int64, 11, true), // xpts
    ];
    private ITdfMember[] __members;

    private TdfString _a = new(__typeInfos[0]);
    private TdfUInt32 _c = new(__typeInfos[1]);
    private TdfString _d = new(__typeInfos[2]);
    private TdfString _g = new(__typeInfos[3]);
    private TdfInt64 _p = new(__typeInfos[4]);
    private TdfList<RequirementData> _requirements = new(__typeInfos[5]);
    private TdfString _r = new(__typeInfos[6]);
    private TdfInt64 _rp = new(__typeInfos[7]);
    private TdfInt8 _ti = new(__typeInfos[8]);
    private TdfInt64 _t = new(__typeInfos[9]);
    private TdfStruct<ExpansionPackData?> _xpack = new(__typeInfos[10]);
    private TdfInt64 _xp = new(__typeInfos[11]);

    public UserHistoryData()
    {
        __members = [ _a, _c, _d, _g, _p, _requirements, _r, _rp, _ti, _t, _xpack, _xp ];
    }

    public override Tdf CreateNew() => new UserHistoryData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UserHistoryData";
    public override string GetFullClassName() => "Blaze::Achievements::UserHistoryData";

    public string A
    {
        get => _a.Value;
        set => _a.Value = value;
    }

    public uint C
    {
        get => _c.Value;
        set => _c.Value = value;
    }

    public string D
    {
        get => _d.Value;
        set => _d.Value = value;
    }

    public string G
    {
        get => _g.Value;
        set => _g.Value = value;
    }

    public long P
    {
        get => _p.Value;
        set => _p.Value = value;
    }

    public IList<RequirementData> Requirements
    {
        get => _requirements.Value;
        set => _requirements.Value = value;
    }

    public string R
    {
        get => _r.Value;
        set => _r.Value = value;
    }

    public long Rp
    {
        get => _rp.Value;
        set => _rp.Value = value;
    }

    public sbyte Ti
    {
        get => _ti.Value;
        set => _ti.Value = value;
    }

    public long T
    {
        get => _t.Value;
        set => _t.Value = value;
    }

    public ExpansionPackData? Xpack
    {
        get => _xpack.Value;
        set => _xpack.Value = value;
    }

    public long Xp
    {
        get => _xp.Value;
        set => _xp.Value = value;
    }

}
