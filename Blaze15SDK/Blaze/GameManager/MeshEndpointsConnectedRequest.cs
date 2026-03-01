using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class MeshEndpointsConnectedRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PlayerNetConnectionFlags", "mPlayerNetConnectionFlags", 0x18C1D300, TdfType.Enum, 0, true), // flgs
        new TdfMemberInfo("GameId", "mGameId", 0x1C910000, TdfType.UInt64, 1, true), // gid
        new TdfMemberInfo("QosInfo", "mQosInfo", 0x44F4C900, TdfType.Struct, 2, true), // qosi
        new TdfMemberInfo("TargetGroupId", "mTargetGroupId", 0x5031C000, TdfType.ObjectId, 3, true), // tcg
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze15SDK.Blaze.GameManager.PlayerNetConnectionFlags> _playerNetConnectionFlags = new(__typeInfos[0]);
    private TdfUInt64 _gameId = new(__typeInfos[1]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.MeshConnectionQosInfo?> _qosInfo = new(__typeInfos[2]);
    private TdfObjectId _targetGroupId = new(__typeInfos[3]);

    public MeshEndpointsConnectedRequest()
    {
        __members = [ _playerNetConnectionFlags, _gameId, _qosInfo, _targetGroupId ];
    }

    public override Tdf CreateNew() => new MeshEndpointsConnectedRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "MeshEndpointsConnectedRequest";
    public override string GetFullClassName() => "Blaze::GameManager::MeshEndpointsConnectedRequest";

    public Blaze15SDK.Blaze.GameManager.PlayerNetConnectionFlags PlayerNetConnectionFlags
    {
        get => _playerNetConnectionFlags.Value;
        set => _playerNetConnectionFlags.Value = value;
    }

    public ulong GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.MeshConnectionQosInfo? QosInfo
    {
        get => _qosInfo.Value;
        set => _qosInfo.Value = value;
    }

    public ObjectId TargetGroupId
    {
        get => _targetGroupId.Value;
        set => _targetGroupId.Value = value;
    }

}
