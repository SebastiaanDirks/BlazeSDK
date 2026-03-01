using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze;

public class TournamentSessionData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ScheduledStartTime", "mScheduledStartTime", 0x51350100, TdfType.String, 0, true), // tsta
        new TdfMemberInfo("ArbitrationTimeout", "mArbitrationTimeout", 0x05250F00, TdfType.TimeValue, 1, true), // arto
        new TdfMemberInfo("ForfeitTimeout", "mForfeitTimeout", 0x19250F00, TdfType.TimeValue, 2, true), // frto
        new TdfMemberInfo("TournamentDefinition", "mTournamentDefinition", 0x50414600, TdfType.String, 3, true), // tdef
    ];
    private ITdfMember[] __members;

    private TdfString _scheduledStartTime = new(__typeInfos[0]);
    private TdfTimeValue _arbitrationTimeout = new(__typeInfos[1]);
    private TdfTimeValue _forfeitTimeout = new(__typeInfos[2]);
    private TdfString _tournamentDefinition = new(__typeInfos[3]);

    public TournamentSessionData()
    {
        __members = [
            _scheduledStartTime,
            _arbitrationTimeout,
            _forfeitTimeout,
            _tournamentDefinition,
        ];
    }

    public override Tdf CreateNew() => new TournamentSessionData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "TournamentSessionData";
    public override string GetFullClassName() => "Blaze::TournamentSessionData";

    public string ScheduledStartTime
    {
        get => _scheduledStartTime.Value;
        set => _scheduledStartTime.Value = value;
    }

    public TimeValue ArbitrationTimeout
    {
        get => _arbitrationTimeout.Value;
        set => _arbitrationTimeout.Value = value;
    }

    public TimeValue ForfeitTimeout
    {
        get => _forfeitTimeout.Value;
        set => _forfeitTimeout.Value = value;
    }

    public string TournamentDefinition
    {
        get => _tournamentDefinition.Value;
        set => _tournamentDefinition.Value = value;
    }

}
