using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Association;

public class CheckListMembershipRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MemberBlazeId", "mMemberBlazeId", 0x08910000, TdfType.Int64, 0, true), // bid
        new TdfMemberInfo("OwnersBlazeIds", "mOwnersBlazeIds", 0x30224400, TdfType.Struct, 1, true), // lbid
        new TdfMemberInfo("ListIdentification", "mListIdentification", 0x30910000, TdfType.Struct, 2, true), // lid
    ];
    private ITdfMember[] __members;

    private TdfInt64 _memberBlazeId = new(__typeInfos[0]);
    private TdfStruct<Blaze15SDK.Blaze.Association.ListBlazeIds?> _ownersBlazeIds = new(__typeInfos[1]);
    private TdfStruct<Blaze15SDK.Blaze.Association.ListIdentification?> _listIdentification = new(__typeInfos[2]);

    public CheckListMembershipRequest()
    {
        __members = [ _memberBlazeId, _ownersBlazeIds, _listIdentification ];
    }

    public override Tdf CreateNew() => new CheckListMembershipRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CheckListMembershipRequest";
    public override string GetFullClassName() => "Blaze::Association::CheckListMembershipRequest";

    public long MemberBlazeId
    {
        get => _memberBlazeId.Value;
        set => _memberBlazeId.Value = value;
    }

    public Blaze15SDK.Blaze.Association.ListBlazeIds? OwnersBlazeIds
    {
        get => _ownersBlazeIds.Value;
        set => _ownersBlazeIds.Value = value;
    }

    public Blaze15SDK.Blaze.Association.ListIdentification? ListIdentification
    {
        get => _listIdentification.Value;
        set => _listIdentification.Value = value;
    }

}
