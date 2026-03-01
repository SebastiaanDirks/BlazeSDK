using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class NotifyGameSetup : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameData", "mGameData", 0x1C134500, TdfType.Struct, 0, true), // game
        new TdfMemberInfo("IsLockableForPreferredJoins", "mIsLockableForPreferredJoins", 0x30640A00, TdfType.Bool, 1, true), // lfpj
        new TdfMemberInfo("GameRoster", "mGameRoster", 0x4123D300, TdfType.List, 2, true), // pros
        new TdfMemberInfo("QosSettings", "mQosSettings", 0x44F4D300, TdfType.Struct, 3, true), // qoss
        new TdfMemberInfo("PerformQosValidation", "mPerformQosValidation", 0x44F4D600, TdfType.Bool, 4, true), // qosv
        new TdfMemberInfo("GameQueue", "mGameQueue", 0x45515500, TdfType.List, 5, true), // queu
        new TdfMemberInfo("GameSetupReason", "gameSetupReason", 0x48505300, TdfType.Struct, 6, true), // reas
        new TdfMemberInfo("QosTelemetryInterval", "mQosTelemetryInterval", 0x50530D00, TdfType.Int64, 7, true), // telm
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.GameManager.ReplicatedGameData?> _gameData = new(__typeInfos[0]);
    private TdfBool _isLockableForPreferredJoins = new(__typeInfos[1]);
    private TdfList<Blaze15SDK.Blaze.GameManager.ReplicatedGamePlayer> _gameRoster = new(__typeInfos[2]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.QosSettings?> _qosSettings = new(__typeInfos[3]);
    private TdfBool _performQosValidation = new(__typeInfos[4]);
    private TdfList<Blaze15SDK.Blaze.GameManager.ReplicatedGamePlayer> _gameQueue = new(__typeInfos[5]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.GameSetupReason?> _gameSetupReason = new(__typeInfos[6]);
    private TdfInt64 _qosTelemetryInterval = new(__typeInfos[7]);

    public NotifyGameSetup()
    {
        __members = [ _gameData, _isLockableForPreferredJoins, _gameRoster, _qosSettings, _performQosValidation, _gameQueue, _gameSetupReason, _qosTelemetryInterval ];
    }

    public override Tdf CreateNew() => new NotifyGameSetup();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyGameSetup";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyGameSetup";

    public Blaze15SDK.Blaze.GameManager.ReplicatedGameData? GameData
    {
        get => _gameData.Value;
        set => _gameData.Value = value;
    }

    public bool IsLockableForPreferredJoins
    {
        get => _isLockableForPreferredJoins.Value;
        set => _isLockableForPreferredJoins.Value = value;
    }

    public IList<Blaze15SDK.Blaze.GameManager.ReplicatedGamePlayer> GameRoster
    {
        get => _gameRoster.Value;
        set => _gameRoster.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.QosSettings? QosSettings
    {
        get => _qosSettings.Value;
        set => _qosSettings.Value = value;
    }

    public bool PerformQosValidation
    {
        get => _performQosValidation.Value;
        set => _performQosValidation.Value = value;
    }

    public IList<Blaze15SDK.Blaze.GameManager.ReplicatedGamePlayer> GameQueue
    {
        get => _gameQueue.Value;
        set => _gameQueue.Value = value;
    }

    public Blaze15SDK.Blaze.GameManager.GameSetupReason? GameSetupReason
    {
        get => _gameSetupReason.Value;
        set => _gameSetupReason.Value = value;
    }

    public long QosTelemetryInterval
    {
        get => _qosTelemetryInterval.Value;
        set => _qosTelemetryInterval.Value = value;
    }

}
