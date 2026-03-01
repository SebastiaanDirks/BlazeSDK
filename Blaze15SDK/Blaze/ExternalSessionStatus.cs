using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze;

public class ExternalSessionStatus : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("UnlocalizedValue", "mUnlocalizedValue", 0x54E30F00, TdfType.String, 0, true), // unlo
        new TdfMemberInfo("LangMap", "mLangMap", 0x30F0CC00, TdfType.Map, 1, true), // locl
    ];
    private ITdfMember[] __members;

    private TdfString _unlocalizedValue = new(__typeInfos[0]);
    private TdfMap<string, string> _langMap = new(__typeInfos[1]);

    public ExternalSessionStatus()
    {
        __members = [
            _unlocalizedValue,
            _langMap,
        ];
    }

    public override Tdf CreateNew() => new ExternalSessionStatus();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ExternalSessionStatus";
    public override string GetFullClassName() => "Blaze::ExternalSessionStatus";

    public string UnlocalizedValue
    {
        get => _unlocalizedValue.Value;
        set => _unlocalizedValue.Value = value;
    }

    public IDictionary<string, string> LangMap
    {
        get => _langMap.Value;
        set => _langMap.Value = value;
    }

}
