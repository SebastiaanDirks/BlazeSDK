using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Association;

public class CheckListContainsMembersRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("OwnerBlazeId", "mOwnerBlazeId", 0x08910000, TdfType.Int64, 0, true), // bid
        new TdfMemberInfo("MembersBlazeIds", "mMembersBlazeIds", 0x30224400, TdfType.Struct, 1, true), // lbid
        new TdfMemberInfo("ListIdentification", "mListIdentification", 0x30910000, TdfType.Struct, 2, true), // lid
    ];
    private ITdfMember[] __members;

    private TdfInt64 _ownerBlazeId = new(__typeInfos[0]);
    private TdfStruct<Blaze15SDK.Blaze.Association.ListBlazeIds?> _membersBlazeIds = new(__typeInfos[1]);
    private TdfStruct<Blaze15SDK.Blaze.Association.ListIdentification?> _listIdentification = new(__typeInfos[2]);

    public CheckListContainsMembersRequest()
    {
        __members = [ _ownerBlazeId, _membersBlazeIds, _listIdentification ];
    }

    public override Tdf CreateNew() => new CheckListContainsMembersRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CheckListContainsMembersRequest";
    public override string GetFullClassName() => "Blaze::Association::CheckListContainsMembersRequest";

    public long OwnerBlazeId
    {
        get => _ownerBlazeId.Value;
        set => _ownerBlazeId.Value = value;
    }

    public Blaze15SDK.Blaze.Association.ListBlazeIds? MembersBlazeIds
    {
        get => _membersBlazeIds.Value;
        set => _membersBlazeIds.Value = value;
    }

    public Blaze15SDK.Blaze.Association.ListIdentification? ListIdentification
    {
        get => _listIdentification.Value;
        set => _listIdentification.Value = value;
    }

}
