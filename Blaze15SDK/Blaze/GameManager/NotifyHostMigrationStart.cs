using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class NotifyHostMigrationStart : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("NewHostConnectionSlotId", "mNewHostConnectionSlotId", 0x0D331400, TdfType.UInt8, 0, true), // cslt
        new TdfMemberInfo("GameId", "mGameId", 0x1C910000, TdfType.UInt64, 1, true), // gid
        new TdfMemberInfo("NewHostId", "mNewHostId", 0x20F4D400, TdfType.Int64, 2, true), // host
        new TdfMemberInfo("MigrationType", "mMigrationType", 0x40D24700, TdfType.Enum, 3, true), // pmig
        new TdfMemberInfo("NewHostSlotId", "mNewHostSlotId", 0x4CC3D400, TdfType.UInt8, 4, true), // slot
    ];
    private ITdfMember[] __members;

    private TdfUInt8 _newHostConnectionSlotId = new(__typeInfos[0]);
    private TdfUInt64 _gameId = new(__typeInfos[1]);
    private TdfInt64 _newHostId = new(__typeInfos[2]);
    private TdfEnum<Blaze15SDK.Blaze.GameManager.HostMigrationType> _migrationType = new(__typeInfos[3]);
    private TdfUInt8 _newHostSlotId = new(__typeInfos[4]);

    public NotifyHostMigrationStart()
    {
        __members = [ _newHostConnectionSlotId, _gameId, _newHostId, _migrationType, _newHostSlotId ];
    }

    public override Tdf CreateNew() => new NotifyHostMigrationStart();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyHostMigrationStart";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyHostMigrationStart";

    public byte NewHostConnectionSlotId
    {
        get => _newHostConnectionSlotId.Value;
        set => _newHostConnectionSlotId.Value = value;
    }

    public ulong GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public long NewHostId
    {
        get => _newHostId.Value;
        set => _newHostId.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.HostMigrationType MigrationType
    {
        get => _migrationType.Value;
        set => _migrationType.Value = value;
    }

    public byte NewHostSlotId
    {
        get => _newHostSlotId.Value;
        set => _newHostSlotId.Value = value;
    }

}
