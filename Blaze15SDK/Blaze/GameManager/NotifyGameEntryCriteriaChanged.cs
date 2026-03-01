using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class NotifyGameEntryCriteriaChanged : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("EntryCriteriaMap", "mEntryCriteriaMap", 0x0D225400, TdfType.Map, 0, true), // crit
        new TdfMemberInfo("GameId", "mGameId", 0x1CD24400, TdfType.UInt64, 1, true), // gmid
        new TdfMemberInfo("RoleEntryCriteriaMap", "mRoleEntryCriteriaMap", 0x48349400, TdfType.Map, 2, true), // rcrt
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _entryCriteriaMap = new(__typeInfos[0]);
    private TdfUInt64 _gameId = new(__typeInfos[1]);
    private TdfMap<string, IDictionary<string, string>> _roleEntryCriteriaMap = new(__typeInfos[2]);

    public NotifyGameEntryCriteriaChanged()
    {
        __members = [ _entryCriteriaMap, _gameId, _roleEntryCriteriaMap ];
    }

    public override Tdf CreateNew() => new NotifyGameEntryCriteriaChanged();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "NotifyGameEntryCriteriaChanged";
    public override string GetFullClassName() => "Blaze::GameManager::NotifyGameEntryCriteriaChanged";

    public IDictionary<string, string> EntryCriteriaMap
    {
        get => _entryCriteriaMap.Value;
        set => _entryCriteriaMap.Value = value;
    }

    public ulong GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public IDictionary<string, IDictionary<string, string>> RoleEntryCriteriaMap
    {
        get => _roleEntryCriteriaMap.Value;
        set => _roleEntryCriteriaMap.Value = value;
    }

}
