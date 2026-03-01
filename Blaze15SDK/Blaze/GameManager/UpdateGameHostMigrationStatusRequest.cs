using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class UpdateGameHostMigrationStatusRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x1C910000, TdfType.UInt64, 0, true), // gid
        new TdfMemberInfo("HostMigrationType", "mHostMigrationType", 0x35465000, TdfType.Enum, 1, true), // mtyp
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _gameId = new(__typeInfos[0]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.HostMigrationType> _hostMigrationType = new(__typeInfos[1]);

    public UpdateGameHostMigrationStatusRequest()
    {
        __members = [ _gameId, _hostMigrationType ];
    }

    public override Tdf CreateNew() => new UpdateGameHostMigrationStatusRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateGameHostMigrationStatusRequest";
    public override string GetFullClassName() => "Blaze::GameManager::UpdateGameHostMigrationStatusRequest";

    public ulong GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.HostMigrationType HostMigrationType
    {
        get => _hostMigrationType.Value;
        set => _hostMigrationType.Value = value;
    }

}
