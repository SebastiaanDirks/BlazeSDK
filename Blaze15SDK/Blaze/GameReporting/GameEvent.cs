using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameReporting;

public class GameEvent : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameEventData", "gameEventData", 0x10150100, TdfType.Variable, 0, true), // data
        new TdfMemberInfo("GameEventType", "gameEventType", 0x1CD15400, TdfType.UInt32, 1, true), // gmet
    ];
    private ITdfMember[] __members;

    private TdfVariable _gameEventData = new(__typeInfos[0]);
    private TdfUInt32 _gameEventType = new(__typeInfos[1]);

    public GameEvent()
    {
        __members = [ _gameEventData, _gameEventType ];
    }

    public override Tdf CreateNew() => new GameEvent();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameEvent";
    public override string GetFullClassName() => "Blaze::GameReporting::GameEvent";

    public object? GameEventData
    {
        get => _gameEventData.Value;
        set => _gameEventData.Value = value;
    }

    public uint GameEventType
    {
        get => _gameEventType.Value;
        set => _gameEventType.Value = value;
    }

}
