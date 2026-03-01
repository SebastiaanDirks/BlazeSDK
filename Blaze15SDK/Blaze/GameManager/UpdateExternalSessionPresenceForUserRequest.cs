using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class UpdateExternalSessionPresenceForUserRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ChangedGame", "mChangedGame", 0x0C704D00, TdfType.Struct, 0, true), // cgam
        new TdfMemberInfo("ChangedGameId", "mChangedGameId", 0x0C724400, TdfType.UInt64, 1, true), // cgid
        new TdfMemberInfo("Change", "mChange", 0x0C838700, TdfType.Enum, 2, true), // chng
        new TdfMemberInfo("CurrentGames", "mCurrentGames", 0x1C10D400, TdfType.List, 3, true), // gact
        new TdfMemberInfo("OldPrimaryGameId", "mOldPrimaryGameId", 0x3C724400, TdfType.UInt64, 4, true), // ogid
        new TdfMemberInfo("UserIdentification", "mUserIdentification", 0x55315200, TdfType.Struct, 5, true), // user
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.GameManager.GameActivity?> _changedGame = new(__typeInfos[0]);
    private TdfUInt64 _changedGameId = new(__typeInfos[1]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.UpdateExternalSessionPresenceForUserReason> _change = new(__typeInfos[2]);
    private TdfList<Blaze15SDK.Blaze.GameManager.GameActivity> _currentGames = new(__typeInfos[3]);
    private TdfUInt64 _oldPrimaryGameId = new(__typeInfos[4]);
    private TdfStruct<Blaze15SDK.Blaze.UserIdentification?> _userIdentification = new(__typeInfos[5]);

    public UpdateExternalSessionPresenceForUserRequest()
    {
        __members = [ _changedGame, _changedGameId, _change, _currentGames, _oldPrimaryGameId, _userIdentification ];
    }

    public override Tdf CreateNew() => new UpdateExternalSessionPresenceForUserRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateExternalSessionPresenceForUserRequest";
    public override string GetFullClassName() => "Blaze::GameManager::UpdateExternalSessionPresenceForUserRequest";

    public Blaze15SDK.Blaze.GameManager.GameActivity? ChangedGame
    {
        get => _changedGame.Value;
        set => _changedGame.Value = value;
    }

    public ulong ChangedGameId
    {
        get => _changedGameId.Value;
        set => _changedGameId.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.UpdateExternalSessionPresenceForUserReason Change
    {
        get => _change.Value;
        set => _change.Value = value;
    }

    public IList<Blaze15SDK.Blaze.GameManager.GameActivity> CurrentGames
    {
        get => _currentGames.Value;
        set => _currentGames.Value = value;
    }

    public ulong OldPrimaryGameId
    {
        get => _oldPrimaryGameId.Value;
        set => _oldPrimaryGameId.Value = value;
    }

    public Blaze15SDK.Blaze.UserIdentification? UserIdentification
    {
        get => _userIdentification.Value;
        set => _userIdentification.Value = value;
    }

}
