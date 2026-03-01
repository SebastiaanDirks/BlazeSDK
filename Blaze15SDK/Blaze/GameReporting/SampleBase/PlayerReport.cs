using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameReporting.SampleBase;

public class PlayerReport : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Country", "country", 0x0D449900, TdfType.String, 0, true), // ctry
        new TdfMemberInfo("Deaths", "deaths", 0x10550800, TdfType.UInt16, 1, true), // deth
        new TdfMemberInfo("Kills", "kills", 0x2C930C00, TdfType.UInt16, 2, true), // kill
        new TdfMemberInfo("Money", "money", 0x34F39900, TdfType.UInt32, 3, true), // mony
        new TdfMemberInfo("LongestTimeAlive", "longestTimeAlive", 0x50131600, TdfType.UInt32, 4, true), // talv
    ];
    private ITdfMember[] __members;

    private TdfString _country = new(__typeInfos[0]);
    private TdfUInt16 _deaths = new(__typeInfos[1]);
    private TdfUInt16 _kills = new(__typeInfos[2]);
    private TdfUInt32 _money = new(__typeInfos[3]);
    private TdfUInt32 _longestTimeAlive = new(__typeInfos[4]);

    public PlayerReport()
    {
        __members = [ _country, _deaths, _kills, _money, _longestTimeAlive ];
    }

    public override Tdf CreateNew() => new PlayerReport();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PlayerReport";
    public override string GetFullClassName() => "Blaze::GameReporting::SampleBase::PlayerReport";

    public string Country
    {
        get => _country.Value;
        set => _country.Value = value;
    }

    public ushort Deaths
    {
        get => _deaths.Value;
        set => _deaths.Value = value;
    }

    public ushort Kills
    {
        get => _kills.Value;
        set => _kills.Value = value;
    }

    public uint Money
    {
        get => _money.Value;
        set => _money.Value = value;
    }

    public uint LongestTimeAlive
    {
        get => _longestTimeAlive.Value;
        set => _longestTimeAlive.Value = value;
    }

}
