using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Util;

public class LocalizeStringsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Locale", "mLocale", 0x30138700, TdfType.UInt32, 0, true), // lang
        new TdfMemberInfo("StringIds", "mStringIds", 0x31324400, TdfType.List, 1, true), // lsid
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _locale = new(__typeInfos[0]);
    private TdfList<string> _stringIds = new(__typeInfos[1]);

    public LocalizeStringsRequest()
    {
        __members = [ _locale, _stringIds ];
    }

    public override Tdf CreateNew() => new LocalizeStringsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LocalizeStringsRequest";
    public override string GetFullClassName() => "Blaze::GameManager::LocalizeStringsRequest";

    public uint Locale
    {
        get => _locale.Value;
        set => _locale.Value = value;
    }

    public IList<string> StringIds
    {
        get => _stringIds.Value;
        set => _stringIds.Value = value;
    }

}
