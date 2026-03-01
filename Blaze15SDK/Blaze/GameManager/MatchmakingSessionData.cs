using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class MatchmakingSessionData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("SessionDuration", "mSessionDuration", 0x11548000, TdfType.Int64, 0, true), // dur
        new TdfMemberInfo("DebugFreezeDecay", "mDebugFreezeDecay", 0x1923DA00, TdfType.Bool, 1, true), // froz
        new TdfMemberInfo("SessionMode", "mSessionMode", 0x34F10500, TdfType.Enum, 2, true), // mode
        new TdfMemberInfo("ExternalMmSessionTemplateName", "mExternalMmSessionTemplateName", 0x35350E00, TdfType.String, 3, true), // mstn
        new TdfMemberInfo("PseudoRequest", "mPseudoRequest", 0x41310F00, TdfType.Bool, 4, true), // psdo
        new TdfMemberInfo("StartingDecayAge", "mStartingDecayAge", 0x4C414300, TdfType.Int64, 5, true), // sdec
        new TdfMemberInfo("StartDelay", "mStartDelay", 0x4C414C00, TdfType.Int64, 6, true), // sdel
        new TdfMemberInfo("MatchSelf", "mMatchSelf", 0x4C530600, TdfType.Bool, 7, true), // self
    ];
    private ITdfMember[] __members;

    private TdfInt64 _sessionDuration = new(__typeInfos[0]);
    private TdfBool _debugFreezeDecay = new(__typeInfos[1]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.MatchmakingSessionMode> _sessionMode = new(__typeInfos[2]);
    private TdfString _externalMmSessionTemplateName = new(__typeInfos[3]);
    private TdfBool _pseudoRequest = new(__typeInfos[4]);
    private TdfInt64 _startingDecayAge = new(__typeInfos[5]);
    private TdfInt64 _startDelay = new(__typeInfos[6]);
    private TdfBool _matchSelf = new(__typeInfos[7]);

    public MatchmakingSessionData()
    {
        __members = [ _sessionDuration, _debugFreezeDecay, _sessionMode, _externalMmSessionTemplateName, _pseudoRequest, _startingDecayAge, _startDelay, _matchSelf ];
    }

    public override Tdf CreateNew() => new MatchmakingSessionData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "MatchmakingSessionData";
    public override string GetFullClassName() => "Blaze::GameManager::MatchmakingSessionData";

    public long SessionDuration
    {
        get => _sessionDuration.Value;
        set => _sessionDuration.Value = value;
    }

    public bool DebugFreezeDecay
    {
        get => _debugFreezeDecay.Value;
        set => _debugFreezeDecay.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.MatchmakingSessionMode SessionMode
    {
        get => _sessionMode.Value;
        set => _sessionMode.Value = value;
    }

    public string ExternalMmSessionTemplateName
    {
        get => _externalMmSessionTemplateName.Value;
        set => _externalMmSessionTemplateName.Value = value;
    }

    public bool PseudoRequest
    {
        get => _pseudoRequest.Value;
        set => _pseudoRequest.Value = value;
    }

    public long StartingDecayAge
    {
        get => _startingDecayAge.Value;
        set => _startingDecayAge.Value = value;
    }

    public long StartDelay
    {
        get => _startDelay.Value;
        set => _startDelay.Value = value;
    }

    public bool MatchSelf
    {
        get => _matchSelf.Value;
        set => _matchSelf.Value = value;
    }

}
