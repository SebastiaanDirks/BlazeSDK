using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Social.Friends;

public class CheckMuteStatusRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AuthCredentials", "mAuthCredentials", 0x05550800, TdfType.Struct, 0, true), // auth
        new TdfMemberInfo("Count", "mCount", 0x0CF39400, TdfType.Int32, 1, true), // cont
        new TdfMemberInfo("Ids", "mIds", 0x30911300, TdfType.List, 2, true), // lids
        new TdfMemberInfo("Names", "mNames", 0x38134500, TdfType.Bool, 3, true), // name
        new TdfMemberInfo("Start", "mStart", 0x4D449400, TdfType.Int32, 4, true), // strt
        new TdfMemberInfo("NucleusId", "mNucleusId", 0x54E24400, TdfType.Int64, 5, true), // unid
    ];
    private ITdfMember[] __members;

    private TdfStruct<AuthenticationCredentials?> _authCredentials = new(__typeInfos[0]);
    private TdfInt32 _count = new(__typeInfos[1]);
    private TdfList<long> _ids = new(__typeInfos[2]);
    private TdfBool _names = new(__typeInfos[3]);
    private TdfInt32 _start = new(__typeInfos[4]);
    private TdfInt64 _nucleusId = new(__typeInfos[5]);

    public CheckMuteStatusRequest()
    {
        __members = [ _authCredentials, _count, _ids, _names, _start, _nucleusId ];
    }

    public override Tdf CreateNew() => new CheckMuteStatusRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CheckMuteStatusRequest";
    public override string GetFullClassName() => "Blaze::Social::Friends::CheckMuteStatusRequest";

    public AuthenticationCredentials? AuthCredentials
    {
        get => _authCredentials.Value;
        set => _authCredentials.Value = value;
    }

    public int Count
    {
        get => _count.Value;
        set => _count.Value = value;
    }

    public IList<long> Ids
    {
        get => _ids.Value;
        set => _ids.Value = value;
    }

    public bool Names
    {
        get => _names.Value;
        set => _names.Value = value;
    }

    public int Start
    {
        get => _start.Value;
        set => _start.Value = value;
    }

    public long NucleusId
    {
        get => _nucleusId.Value;
        set => _nucleusId.Value = value;
    }

}
