using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameReporting.ArsonCTF_NonDerived;

public class GameAttributes : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DurationSec", "durationSec", 0x11548000, TdfType.Float, 0, true), // dur
        new TdfMemberInfo("GameName", "gameName", 0x1CE04D00, TdfType.String, 1, true), // gnam
        new TdfMemberInfo("GameSettingsName", "gameSettingsName", 0x1D338100, TdfType.String, 2, true), // gsna
        new TdfMemberInfo("OpenToBrowsing", "openToBrowsing", 0x1D358100, TdfType.String, 3, true), // gsva
        new TdfMemberInfo("MapName", "mapName", 0x34140000, TdfType.String, 4, true), // map
        new TdfMemberInfo("ReplayTimes", "replayTimes", 0x50934500, TdfType.UInt32, 5, true), // time
    ];
    private ITdfMember[] __members;

    private TdfFloat _durationSec = new(__typeInfos[0]);
    private TdfString _gameName = new(__typeInfos[1]);
    private TdfString _gameSettingsName = new(__typeInfos[2]);
    private TdfString _openToBrowsing = new(__typeInfos[3]);
    private TdfString _mapName = new(__typeInfos[4]);
    private TdfUInt32 _replayTimes = new(__typeInfos[5]);

    public GameAttributes()
    {
        __members = [ _durationSec, _gameName, _gameSettingsName, _openToBrowsing, _mapName, _replayTimes ];
    }

    public override Tdf CreateNew() => new GameAttributes();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameAttributes";
    public override string GetFullClassName() => "Blaze::GameReporting::ArsonCTF_NonDerived::GameAttributes";

    public float DurationSec
    {
        get => _durationSec.Value;
        set => _durationSec.Value = value;
    }

    public string GameName
    {
        get => _gameName.Value;
        set => _gameName.Value = value;
    }

    public string GameSettingsName
    {
        get => _gameSettingsName.Value;
        set => _gameSettingsName.Value = value;
    }

    public string OpenToBrowsing
    {
        get => _openToBrowsing.Value;
        set => _openToBrowsing.Value = value;
    }

    public string MapName
    {
        get => _mapName.Value;
        set => _mapName.Value = value;
    }

    public uint ReplayTimes
    {
        get => _replayTimes.Value;
        set => _replayTimes.Value = value;
    }

}
