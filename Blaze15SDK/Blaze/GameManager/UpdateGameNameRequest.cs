using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class UpdateGameNameRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("GameId", "mGameId", 0x1C910000, TdfType.UInt64, 0, true), // gid
        new TdfMemberInfo("GameName", "mGameName", 0x1CE04D00, TdfType.String, 1, true), // gnam
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _gameId = new(__typeInfos[0]);
    private TdfString _gameName = new(__typeInfos[1]);

    public UpdateGameNameRequest()
    {
        __members = [ _gameId, _gameName ];
    }

    public override Tdf CreateNew() => new UpdateGameNameRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateGameNameRequest";
    public override string GetFullClassName() => "Blaze::GameManager::UpdateGameNameRequest";

    public ulong GameId
    {
        get => _gameId.Value;
        set => _gameId.Value = value;
    }

    public string GameName
    {
        get => _gameName.Value;
        set => _gameName.Value = value;
    }

}
