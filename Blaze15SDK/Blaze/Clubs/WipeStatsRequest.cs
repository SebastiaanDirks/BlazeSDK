using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Clubs;

public class WipeStatsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x0CC24400, TdfType.UInt64, 0, true), // clid
        new TdfMemberInfo("WipeSet", "mWipeSet", 0x5C941300, TdfType.String, 1, true), // wips
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _clubId = new(__typeInfos[0]);
    private TdfString _wipeSet = new(__typeInfos[1]);

    public WipeStatsRequest()
    {
        __members = [ _clubId, _wipeSet ];
    }

    public override Tdf CreateNew() => new WipeStatsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "WipeStatsRequest";
    public override string GetFullClassName() => "Blaze::Clubs::WipeStatsRequest";

    public ulong ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public string WipeSet
    {
        get => _wipeSet.Value;
        set => _wipeSet.Value = value;
    }

}
