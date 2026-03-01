using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class JoinGameRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CommonGameData", "mCommonGameData", 0x0CD1C400, TdfType.Struct, 0, true), // cmgd
        new TdfMemberInfo("GameId", "mGameId", 0x1C910000, TdfType.UInt64, 1, true), // gid
        new TdfMemberInfo("JoinMethod", "mJoinMethod", 0x28D15400, TdfType.Enum, 2, true), // jmet
        new TdfMemberInfo("PlayerJoinData", "mPlayerJoinData", 0x40C28400, TdfType.Struct, 3, true), // pljd
        new TdfMemberInfo("RequestedSlotId", "mRequestedSlotId", 0x4CC24400, TdfType.UInt8, 4, true), // slid
        new TdfMemberInfo("User", "mUser", 0x55315200, TdfType.Struct, 5, true), // user
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.GameManager.CommonGameRequestData?> _commonGameData = new(__typeInfos[0]);
    private TdfUInt64 _gameId = new(__typeInfos[1]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.JoinMethod> _joinMethod = new(__typeInfos[2]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.PlayerJoinData?> _playerJoinData = new(__typeInfos[3]);
    private TdfUInt8 _requestedSlotId = new(__typeInfos[4]);
    private TdfStruct<Blaze15SDK.Blaze.UserIdentification?> _user = new(__typeInfos[5]);

    public JoinGameRequest()
    {
        __members = [ _commonGameData, _gameId, _joinMethod, _playerJoinData, _requestedSlotId, _user ];
    }

    public override Tdf CreateNew() => new JoinGameRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "JoinGameRequest";
    public override string GetFullClassName() => "Blaze::GameManager::JoinGameRequest";

    public Blaze15SDK.Blaze.GameManager.CommonGameRequestData? CommonGameData
    {
        get => _commonGameData.Value;
        set => _commonGameData.Value = value;
    }

    public ulong GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.JoinMethod JoinMethod
    {
        get => _joinMethod.Value;
        set => _joinMethod.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.PlayerJoinData? PlayerJoinData
    {
        get => _playerJoinData.Value;
        set => _playerJoinData.Value = value;
    }

    public byte RequestedSlotId
    {
        get => _requestedSlotId.Value;
        set => _requestedSlotId.Value = value;
    }

    public Blaze15SDK.Blaze.UserIdentification? User
    {
        get => _user.Value;
        set => _user.Value = value;
    }

}
