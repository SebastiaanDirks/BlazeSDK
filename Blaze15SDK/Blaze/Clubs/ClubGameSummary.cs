using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Clubs;

public class ClubGameSummary : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Loss", "mLoss", 0x38C3D300, TdfType.UInt32, 0, true), // nlos
        new TdfMemberInfo("LastUpdateTime", "mLastUpdateTime", 0x38C55000, TdfType.UInt32, 1, true), // nlup
        new TdfMemberInfo("Tie", "mTie", 0x39424500, TdfType.UInt32, 2, true), // ntie
        new TdfMemberInfo("Win", "mWin", 0x39724E00, TdfType.UInt32, 3, true), // nwin
        new TdfMemberInfo("OppoClubId", "mOppoClubId", 0x3D024400, TdfType.UInt64, 4, true), // opid
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _loss = new(__typeInfos[0]);
    private TdfUInt32 _lastUpdateTime = new(__typeInfos[1]);
    private TdfUInt32 _tie = new(__typeInfos[2]);
    private TdfUInt32 _win = new(__typeInfos[3]);
    private TdfUInt64 _oppoClubId = new(__typeInfos[4]);

    public ClubGameSummary()
    {
        __members = [ _loss, _lastUpdateTime, _tie, _win, _oppoClubId ];
    }

    public override Tdf CreateNew() => new ClubGameSummary();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClubGameSummary";
    public override string GetFullClassName() => "Blaze::Clubs::ClubGameSummary";

    public uint Loss
    {
        get => _loss.Value;
        set => _loss.Value = value;
    }

    public uint LastUpdateTime
    {
        get => _lastUpdateTime.Value;
        set => _lastUpdateTime.Value = value;
    }

    public uint Tie
    {
        get => _tie.Value;
        set => _tie.Value = value;
    }

    public uint Win
    {
        get => _win.Value;
        set => _win.Value = value;
    }

    public ulong OppoClubId
    {
        get => _oppoClubId.Value;
        set => _oppoClubId.Value = value;
    }

}
