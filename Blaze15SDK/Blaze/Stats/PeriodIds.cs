using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Stats;

public class PeriodIds : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DailyBuffer", "mDailyBuffer", 0x10254600, TdfType.Int32, 0, true), // dbuf
        new TdfMemberInfo("DailyHour", "mDailyHour", 0x1083D500, TdfType.Int32, 1, true), // dhou
        new TdfMemberInfo("CurrentDailyPeriodId", "mCurrentDailyPeriodId", 0x10C64000, TdfType.Int32, 2, true), // dly
        new TdfMemberInfo("DailyRetention", "mDailyRetention", 0x11215400, TdfType.Int32, 3, true), // dret
        new TdfMemberInfo("MonthlyBuffer", "mMonthlyBuffer", 0x34254600, TdfType.Int32, 4, true), // mbuf
        new TdfMemberInfo("MonthlyDay", "mMonthlyDay", 0x34405900, TdfType.Int32, 5, true), // mday
        new TdfMemberInfo("MonthlyHour", "mMonthlyHour", 0x3483D500, TdfType.Int32, 6, true), // mhou
        new TdfMemberInfo("CurrentMonthlyPeriodId", "mCurrentMonthlyPeriodId", 0x34C64000, TdfType.Int32, 7, true), // mly
        new TdfMemberInfo("MonthlyRetention", "mMonthlyRetention", 0x35215400, TdfType.Int32, 8, true), // mret
        new TdfMemberInfo("WeeklyBuffer", "mWeeklyBuffer", 0x5C254600, TdfType.Int32, 9, true), // wbuf
        new TdfMemberInfo("WeeklyDay", "mWeeklyDay", 0x5C405900, TdfType.Int32, 10, true), // wday
        new TdfMemberInfo("WeeklyHour", "mWeeklyHour", 0x5C83D500, TdfType.Int32, 11, true), // whou
        new TdfMemberInfo("CurrentWeeklyPeriodId", "mCurrentWeeklyPeriodId", 0x5CC64000, TdfType.Int32, 12, true), // wly
        new TdfMemberInfo("WeeklyRetention", "mWeeklyRetention", 0x5D215400, TdfType.Int32, 13, true), // wret
    ];
    private ITdfMember[] __members;

    private TdfInt32 _dailyBuffer = new(__typeInfos[0]);
    private TdfInt32 _dailyHour = new(__typeInfos[1]);
    private TdfInt32 _currentDailyPeriodId = new(__typeInfos[2]);
    private TdfInt32 _dailyRetention = new(__typeInfos[3]);
    private TdfInt32 _monthlyBuffer = new(__typeInfos[4]);
    private TdfInt32 _monthlyDay = new(__typeInfos[5]);
    private TdfInt32 _monthlyHour = new(__typeInfos[6]);
    private TdfInt32 _currentMonthlyPeriodId = new(__typeInfos[7]);
    private TdfInt32 _monthlyRetention = new(__typeInfos[8]);
    private TdfInt32 _weeklyBuffer = new(__typeInfos[9]);
    private TdfInt32 _weeklyDay = new(__typeInfos[10]);
    private TdfInt32 _weeklyHour = new(__typeInfos[11]);
    private TdfInt32 _currentWeeklyPeriodId = new(__typeInfos[12]);
    private TdfInt32 _weeklyRetention = new(__typeInfos[13]);

    public PeriodIds()
    {
        __members = [ _dailyBuffer, _dailyHour, _currentDailyPeriodId, _dailyRetention, _monthlyBuffer, _monthlyDay, _monthlyHour, _currentMonthlyPeriodId, _monthlyRetention, _weeklyBuffer, _weeklyDay, _weeklyHour, _currentWeeklyPeriodId, _weeklyRetention ];
    }

    public override Tdf CreateNew() => new PeriodIds();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PeriodIds";
    public override string GetFullClassName() => "Blaze::Stats::PeriodIds";

    public int DailyBuffer
    {
        get => _dailyBuffer.Value;
        set => _dailyBuffer.Value = value;
    }

    public int DailyHour
    {
        get => _dailyHour.Value;
        set => _dailyHour.Value = value;
    }

    public int CurrentDailyPeriodId
    {
        get => _currentDailyPeriodId.Value;
        set => _currentDailyPeriodId.Value = value;
    }

    public int DailyRetention
    {
        get => _dailyRetention.Value;
        set => _dailyRetention.Value = value;
    }

    public int MonthlyBuffer
    {
        get => _monthlyBuffer.Value;
        set => _monthlyBuffer.Value = value;
    }

    public int MonthlyDay
    {
        get => _monthlyDay.Value;
        set => _monthlyDay.Value = value;
    }

    public int MonthlyHour
    {
        get => _monthlyHour.Value;
        set => _monthlyHour.Value = value;
    }

    public int CurrentMonthlyPeriodId
    {
        get => _currentMonthlyPeriodId.Value;
        set => _currentMonthlyPeriodId.Value = value;
    }

    public int MonthlyRetention
    {
        get => _monthlyRetention.Value;
        set => _monthlyRetention.Value = value;
    }

    public int WeeklyBuffer
    {
        get => _weeklyBuffer.Value;
        set => _weeklyBuffer.Value = value;
    }

    public int WeeklyDay
    {
        get => _weeklyDay.Value;
        set => _weeklyDay.Value = value;
    }

    public int WeeklyHour
    {
        get => _weeklyHour.Value;
        set => _weeklyHour.Value = value;
    }

    public int CurrentWeeklyPeriodId
    {
        get => _currentWeeklyPeriodId.Value;
        set => _currentWeeklyPeriodId.Value = value;
    }

    public int WeeklyRetention
    {
        get => _weeklyRetention.Value;
        set => _weeklyRetention.Value = value;
    }

}
