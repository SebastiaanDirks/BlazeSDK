using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class EjectHostRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x1C910000, TdfType.UInt64, 0, true), // gid
        new TdfMemberInfo("ReplaceHost", "mReplaceHost", 0x48540800, TdfType.Bool, 1, true), // reph
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _gameId = new(__typeInfos[0]);
    private TdfBool _replaceHost = new(__typeInfos[1]);

    public EjectHostRequest()
    {
        __members = [ _gameId, _replaceHost ];
    }

    public override Tdf CreateNew() => new EjectHostRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "EjectHostRequest";
    public override string GetFullClassName() => "Blaze::GameManager::EjectHostRequest";

    public ulong GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public bool ReplaceHost
    {
        get => _replaceHost.Value;
        set => _replaceHost.Value = value;
    }

}
