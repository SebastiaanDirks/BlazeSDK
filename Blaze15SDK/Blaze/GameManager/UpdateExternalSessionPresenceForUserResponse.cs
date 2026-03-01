using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class UpdateExternalSessionPresenceForUserResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CurrentPrimarySession", "mCurrentPrimarySession", 0x15324400, TdfType.Struct, 0, true), // esid
        new TdfMemberInfo("CurrentPrimaryGameId", "mCurrentPrimaryGameId", 0x1C910000, TdfType.UInt64, 1, true), // gid
        new TdfMemberInfo("CurrentPrimary", "mCurrentPrimary", 0x41315300, TdfType.Struct, 2, true), // pses
        new TdfMemberInfo("BlazeId", "mBlazeId", 0x55314900, TdfType.Int64, 3, true), // usei
        new TdfMemberInfo("Updated", "mUpdated", 0x55315300, TdfType.Struct, 4, true), // uses
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.ExternalSessionIdentification?> _currentPrimarySession = new(__typeInfos[0]);
    private TdfUInt64 _currentPrimaryGameId = new(__typeInfos[1]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.UpdatedExternalSessionForUserResult?> _currentPrimary = new(__typeInfos[2]);
    private TdfInt64 _blazeId = new(__typeInfos[3]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.UpdatedExternalSessionForUserResult?> _updated = new(__typeInfos[4]);

    public UpdateExternalSessionPresenceForUserResponse()
    {
        __members = [ _currentPrimarySession, _currentPrimaryGameId, _currentPrimary, _blazeId, _updated ];
    }

    public override Tdf CreateNew() => new UpdateExternalSessionPresenceForUserResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateExternalSessionPresenceForUserResponse";
    public override string GetFullClassName() => "Blaze::GameManager::UpdateExternalSessionPresenceForUserResponse";

    public Blaze15SDK.Blaze.ExternalSessionIdentification? CurrentPrimarySession
    {
        get => _currentPrimarySession.Value;
        set => _currentPrimarySession.Value = value;
    }

    public ulong CurrentPrimaryGameId
    {
        get => _currentPrimaryGameId.Value;
        set => _currentPrimaryGameId.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.UpdatedExternalSessionForUserResult? CurrentPrimary
    {
        get => _currentPrimary.Value;
        set => _currentPrimary.Value = value;
    }

    public long BlazeId
    {
        get => _blazeId.Value;
        set => _blazeId.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.UpdatedExternalSessionForUserResult? Updated
    {
        get => _updated.Value;
        set => _updated.Value = value;
    }

}
