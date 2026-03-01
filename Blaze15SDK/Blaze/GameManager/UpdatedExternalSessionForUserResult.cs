using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class UpdatedExternalSessionForUserResult : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Activity", "mActivity", 0x5410D400, TdfType.Map, 0, true), // uact
        new TdfMemberInfo("GameId", "mGameId", 0x54724400, TdfType.UInt64, 1, true), // ugid
        new TdfMemberInfo("Session", "mSession", 0x55324400, TdfType.Struct, 2, true), // usid
    ];
    private ITdfMember[] __members;

    private TdfMap<Blaze15SDK.Blaze.ExternalSessionActivityType, bool> _activity = new(__typeInfos[0]);
    private TdfUInt64 _gameId = new(__typeInfos[1]);
    private TdfStruct<Blaze15SDK.Blaze.ExternalSessionIdentification?> _session = new(__typeInfos[2]);

    public UpdatedExternalSessionForUserResult()
    {
        __members = [ _activity, _gameId, _session ];
    }

    public override Tdf CreateNew() => new UpdatedExternalSessionForUserResult();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdatedExternalSessionForUserResult";
    public override string GetFullClassName() => "Blaze::GameManager::UpdatedExternalSessionForUserResult";

    public IDictionary<Blaze15SDK.Blaze.ExternalSessionActivityType, bool> Activity
    {
        get => _activity.Value;
        set => _activity.Value = value;
    }

    public ulong GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public Blaze15SDK.Blaze.ExternalSessionIdentification? Session
    {
        get => _session.Value;
        set => _session.Value = value;
    }

}
