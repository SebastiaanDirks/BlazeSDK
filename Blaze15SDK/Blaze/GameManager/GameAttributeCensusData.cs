using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class GameAttributeCensusData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("NumOfGames", "mNumOfGames", 0x38F18700, TdfType.UInt32, 0, true), // nofg
        new TdfMemberInfo("NumOfPlayers", "mNumOfPlayers", 0x38F19000, TdfType.UInt32, 1, true), // nofp
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _numOfGames = new(__typeInfos[0]);
    private TdfUInt32 _numOfPlayers = new(__typeInfos[1]);

    public GameAttributeCensusData()
    {
        __members = [ _numOfGames, _numOfPlayers ];
    }

    public override Tdf CreateNew() => new GameAttributeCensusData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameAttributeCensusData";
    public override string GetFullClassName() => "Blaze::GameManager::GameAttributeCensusData";

    public uint NumOfGames
    {
        get => _numOfGames.Value;
        set => _numOfGames.Value = value;
    }

    public uint NumOfPlayers
    {
        get => _numOfPlayers.Value;
        set => _numOfPlayers.Value = value;
    }

}
