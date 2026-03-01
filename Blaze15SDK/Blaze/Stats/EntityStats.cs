using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Stats;

public class EntityStats : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EntityId", "mEntityId", 0x14910000, TdfType.UInt64, 0, true), // eid
        new TdfMemberInfo("EntityType", "mEntityType", 0x15465000, TdfType.ObjectType, 1, true), // etyp
        new TdfMemberInfo("PeriodOffset", "mPeriodOffset", 0x40F18600, TdfType.Int32, 2, true), // poff
        new TdfMemberInfo("StatValues", "mStatValues", 0x4D405400, TdfType.List, 3, true), // stat
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _entityId = new(__typeInfos[0]);
    private TdfObjectType _entityType = new(__typeInfos[1]);
    private TdfInt32 _periodOffset = new(__typeInfos[2]);
    private TdfList<string> _statValues = new(__typeInfos[3]);

    public EntityStats()
    {
        __members = [ _entityId, _entityType, _periodOffset, _statValues ];
    }

    public override Tdf CreateNew() => new EntityStats();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "EntityStats";
    public override string GetFullClassName() => "Blaze::Stats::EntityStats";

    public ulong EntityId
    {
        get => _entityId.Value;
        set => _entityId.Value = value;
    }

    public ObjectType EntityType
    {
        get => _entityType.Value;
        set => _entityType.Value = value;
    }

    public int PeriodOffset
    {
        get => _periodOffset.Value;
        set => _periodOffset.Value = value;
    }

    public IList<string> StatValues
    {
        get => _statValues.Value;
        set => _statValues.Value = value;
    }

}
