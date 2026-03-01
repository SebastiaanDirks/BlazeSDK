using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class NotifyGameSettingsChange : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameSettings", "mGameSettings", 0x05451200, TdfType.Enum, 0, true), // attr
        new TdfMemberInfo("GameId", "mGameId", 0x1C910000, TdfType.UInt64, 1, true), // gid
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze15SDK.Blaze.GameManager.GameSettings> _gameSettings = new(__typeInfos[0]);
    private TdfUInt64 _gameId = new(__typeInfos[1]);

    public NotifyGameSettingsChange()
    {
        __members = [ _gameSettings, _gameId ];
    }

    public override Tdf CreateNew() => new NotifyGameSettingsChange();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyGameSettingsChange";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyGameSettingsChange";

    public Blaze15SDK.Blaze.GameManager.GameSettings GameSettings
    {
        get => _gameSettings.Value;
        set => _gameSettings.Value = value;
    }

    public ulong GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

}
