using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class UpdateAdminListRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x1C910000, TdfType.UInt64, 0, true), // gid
        new TdfMemberInfo("AdminPlayerId", "mAdminPlayerId", 0x40910000, TdfType.Int64, 1, true), // pid
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _gameId = new(__typeInfos[0]);
    private TdfInt64 _adminPlayerId = new(__typeInfos[1]);

    public UpdateAdminListRequest()
    {
        __members = [ _gameId, _adminPlayerId ];
    }

    public override Tdf CreateNew() => new UpdateAdminListRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateAdminListRequest";
    public override string GetFullClassName() => "Blaze::GameManager::UpdateAdminListRequest";

    public ulong GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public long AdminPlayerId
    {
        get => _adminPlayerId.Value;
        set => _adminPlayerId.Value = value;
    }

}
