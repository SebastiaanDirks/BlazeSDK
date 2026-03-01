using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class GameSetupReason : Union
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("DatalessSetupContext", "datalessSetupContext", 0x10C4C300, TdfType.Struct, 0, true), // dlsc
        new TdfMemberInfo("IndirectJoinGameSetupContext", "indirectJoinGameSetupContext", 0x24A1D300, TdfType.Struct, 1, true), // ijgs
        new TdfMemberInfo("IndirectMatchmakingSetupContext", "indirectMatchmakingSetupContext", 0x24D4C300, TdfType.Struct, 2, true), // imsc
        new TdfMemberInfo("MatchmakingSetupContext", "matchmakingSetupContext", 0x34D4C300, TdfType.Struct, 3, true), // mmsc
        new TdfMemberInfo("ResetDedicatedServerSetupContext", "resetDedicatedServerSetupContext", 0x4844C300, TdfType.Struct, 4, true), // rdsc
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.GameManager.DatalessSetupContext?> _datalessSetupContext = new(__typeInfos[0]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.IndirectJoinGameSetupContext?> _indirectJoinGameSetupContext = new(__typeInfos[1]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.IndirectMatchmakingSetupContext?> _indirectMatchmakingSetupContext = new(__typeInfos[2]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.MatchmakingSetupContext?> _matchmakingSetupContext = new(__typeInfos[3]);
    private TdfStruct<Blaze15SDK.Blaze.GameManager.ResetDedicatedServerSetupContext?> _resetDedicatedServerSetupContext = new(__typeInfos[4]);

    public GameSetupReason()
    {
        __members = [ _datalessSetupContext, _indirectJoinGameSetupContext, _indirectMatchmakingSetupContext, _matchmakingSetupContext, _resetDedicatedServerSetupContext ];
    }

    public override Tdf CreateNew() => new GameSetupReason();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameSetupReason";
    public override string GetFullClassName() => "Blaze::GameManager::GameSetupReason";

    public override ITdfMember? GetActiveMember()
    {
        return ActiveIndex switch
        {
            0 => _datalessSetupContext,
            1 => _indirectJoinGameSetupContext,
            2 => _indirectMatchmakingSetupContext,
            3 => _matchmakingSetupContext,
            4 => _resetDedicatedServerSetupContext,
            _ => null
        };
    }

    public Blaze15SDK.Blaze.GameManager.DatalessSetupContext? DatalessSetupContext
    {
        get => _datalessSetupContext.Value;
        set { SwitchActiveIndex(0); _datalessSetupContext.Value = value; }
    }

    public Blaze15SDK.Blaze.GameManager.IndirectJoinGameSetupContext? IndirectJoinGameSetupContext
    {
        get => _indirectJoinGameSetupContext.Value;
        set { SwitchActiveIndex(1); _indirectJoinGameSetupContext.Value = value; }
    }

    public Blaze15SDK.Blaze.GameManager.IndirectMatchmakingSetupContext? IndirectMatchmakingSetupContext
    {
        get => _indirectMatchmakingSetupContext.Value;
        set { SwitchActiveIndex(2); _indirectMatchmakingSetupContext.Value = value; }
    }

    public Blaze15SDK.Blaze.GameManager.MatchmakingSetupContext? MatchmakingSetupContext
    {
        get => _matchmakingSetupContext.Value;
        set { SwitchActiveIndex(3); _matchmakingSetupContext.Value = value; }
    }

    public Blaze15SDK.Blaze.GameManager.ResetDedicatedServerSetupContext? ResetDedicatedServerSetupContext
    {
        get => _resetDedicatedServerSetupContext.Value;
        set { SwitchActiveIndex(4); _resetDedicatedServerSetupContext.Value = value; }
    }

}
