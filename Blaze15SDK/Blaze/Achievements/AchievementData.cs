using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Achievements;

public class AchievementData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Cnt", "mCnt", 0x0CE50000, TdfType.UInt32, 0, true), // cnt
        new TdfMemberInfo("Tc", "mTc", 0x0D549400, TdfType.Int8, 1, true), // curt
        new TdfMemberInfo("Desc", "mDesc", 0x1054C300, TdfType.String, 2, true), // desc
        new TdfMemberInfo("D", "mD", 0x10558300, TdfType.String, 3, true), // devc
        new TdfMemberInfo("E", "mE", 0x15841900, TdfType.Int64, 4, true), // expy
        new TdfMemberInfo("Howto", "mHowto", 0x20F5D400, TdfType.String, 5, true), // howt
        new TdfMemberInfo("Icons", "mIcons", 0x2433CE00, TdfType.Map, 6, true), // icon
        new TdfMemberInfo("Img", "mImg", 0x24D1C000, TdfType.String, 7, true), // img
        new TdfMemberInfo("Name", "mName", 0x38134500, TdfType.String, 8, true), // name
        new TdfMemberInfo("Tn", "mTn", 0x38561400, TdfType.List, 9, true), // next
        new TdfMemberInfo("P", "mP", 0x4144C000, TdfType.Int64, 10, true), // pts
        new TdfMemberInfo("Requirements", "mRequirements", 0x48544C00, TdfType.List, 11, true), // reql
        new TdfMemberInfo("Rp", "mRp", 0x49051300, TdfType.Int64, 12, true), // rpts
        new TdfMemberInfo("S", "mS", 0x4D449400, TdfType.Int64, 13, true), // strt
        new TdfMemberInfo("U", "mU", 0x50934500, TdfType.Int64, 14, true), // time
        new TdfMemberInfo("Tt", "mTt", 0x50F51400, TdfType.Int8, 15, true), // tott
        new TdfMemberInfo("T", "mT", 0x51051300, TdfType.Int64, 16, true), // tpts
        new TdfMemberInfo("UserProgressPoints", "mUserProgressPoints", 0x55051300, TdfType.Int64, 17, true), // upts
        new TdfMemberInfo("Xpack", "mXpack", 0x61004300, TdfType.Struct, 18, true), // xpac
        new TdfMemberInfo("Xp", "mXp", 0x61051300, TdfType.Int64, 19, true), // xpts
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _cnt = new(__typeInfos[0]);
    private TdfInt8 _tc = new(__typeInfos[1]);
    private TdfString _desc = new(__typeInfos[2]);
    private TdfString _d = new(__typeInfos[3]);
    private TdfInt64 _e = new(__typeInfos[4]);
    private TdfString _howto = new(__typeInfos[5]);
    private TdfMap<uint, string> _icons = new(__typeInfos[6]);
    private TdfString _img = new(__typeInfos[7]);
    private TdfString _name = new(__typeInfos[8]);
    private TdfList<TieredAchievementData> _tn = new(__typeInfos[9]);
    private TdfInt64 _p = new(__typeInfos[10]);
    private TdfList<RequirementData> _requirements = new(__typeInfos[11]);
    private TdfInt64 _rp = new(__typeInfos[12]);
    private TdfInt64 _s = new(__typeInfos[13]);
    private TdfInt64 _u = new(__typeInfos[14]);
    private TdfInt8 _tt = new(__typeInfos[15]);
    private TdfInt64 _t = new(__typeInfos[16]);
    private TdfInt64 _userProgressPoints = new(__typeInfos[17]);
    private TdfStruct<ExpansionPackData?> _xpack = new(__typeInfos[18]);
    private TdfInt64 _xp = new(__typeInfos[19]);

    public AchievementData()
    {
        __members = [ _cnt, _tc, _desc, _d, _e, _howto, _icons, _img, _name, _tn, _p, _requirements, _rp, _s, _u, _tt, _t, _userProgressPoints, _xpack, _xp ];
    }

    public override Tdf CreateNew() => new AchievementData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "AchievementData";
    public override string GetFullClassName() => "Blaze::Achievements::AchievementData";

    public uint Cnt
    {
        get => _cnt.Value;
        set => _cnt.Value = value;
    }

    public sbyte Tc
    {
        get => _tc.Value;
        set => _tc.Value = value;
    }

    public string Desc
    {
        get => _desc.Value;
        set => _desc.Value = value;
    }

    public string D
    {
        get => _d.Value;
        set => _d.Value = value;
    }

    public long E
    {
        get => _e.Value;
        set => _e.Value = value;
    }

    public string Howto
    {
        get => _howto.Value;
        set => _howto.Value = value;
    }

    public IDictionary<uint, string> Icons
    {
        get => _icons.Value;
        set => _icons.Value = value;
    }

    public string Img
    {
        get => _img.Value;
        set => _img.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public IList<TieredAchievementData> Tn
    {
        get => _tn.Value;
        set => _tn.Value = value;
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

    public long Rp
    {
        get => _rp.Value;
        set => _rp.Value = value;
    }

    public long S
    {
        get => _s.Value;
        set => _s.Value = value;
    }

    public long U
    {
        get => _u.Value;
        set => _u.Value = value;
    }

    public sbyte Tt
    {
        get => _tt.Value;
        set => _tt.Value = value;
    }

    public long T
    {
        get => _t.Value;
        set => _t.Value = value;
    }

    public long UserProgressPoints
    {
        get => _userProgressPoints.Value;
        set => _userProgressPoints.Value = value;
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
