using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class SetPresenceModeRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x1C910000, TdfType.UInt64, 0, true), // gid
        new TdfMemberInfo("PresenceMode", "mPresenceMode", 0x41215300, TdfType.Enum, 1, true), // pres
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _gameId = new(__typeInfos[0]);
    private TdfEnum<Blaze15SDK.Blaze.PresenceMode> _presenceMode = new(__typeInfos[1]);

    public SetPresenceModeRequest()
    {
        __members = [ _gameId, _presenceMode ];
    }

    public override Tdf CreateNew() => new SetPresenceModeRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "SetPresenceModeRequest";
    public override string GetFullClassName() => "Blaze::GameManager::SetPresenceModeRequest";

    public ulong GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public Blaze15SDK.Blaze.PresenceMode PresenceMode
    {
        get => _presenceMode.Value;
        set => _presenceMode.Value = value;
    }

}
