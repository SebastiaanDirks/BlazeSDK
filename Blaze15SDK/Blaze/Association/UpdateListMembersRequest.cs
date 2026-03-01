using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Association;

public class UpdateListMembersRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AttributesMask", "mAttributesMask", 0x05434B00, TdfType.Enum, 0, true), // atmk
        new TdfMemberInfo("BlazeId", "mBlazeId", 0x08910000, TdfType.Int64, 1, true), // bid
        new TdfMemberInfo("ListMemberIdVector", "mListMemberIdVector", 0x08910C00, TdfType.List, 2, true), // bidl
        new TdfMemberInfo("MemberHash", "mMemberHash", 0x2014C800, TdfType.UInt32, 3, true), // hash
        new TdfMemberInfo("ListIdentification", "mListIdentification", 0x30910000, TdfType.Struct, 4, true), // lid
        new TdfMemberInfo("ValidateDelete", "validateDelete", 0x58130400, TdfType.Bool, 5, true), // vald
    ];
    private ITdfMember[] __members;

    private TdfEnum<Blaze15SDK.Blaze.Association.ListMemberAttributes> _attributesMask = new(__typeInfos[0]);
    private TdfInt64 _blazeId = new(__typeInfos[1]);
    private TdfList<Blaze15SDK.Blaze.Association.ListMemberId> _listMemberIdVector = new(__typeInfos[2]);
    private TdfUInt32 _memberHash = new(__typeInfos[3]);
    private TdfStruct<Blaze15SDK.Blaze.Association.ListIdentification?> _listIdentification = new(__typeInfos[4]);
    private TdfBool _validateDelete = new(__typeInfos[5]);

    public UpdateListMembersRequest()
    {
        __members = [ _attributesMask, _blazeId, _listMemberIdVector, _memberHash, _listIdentification, _validateDelete ];
    }

    public override Tdf CreateNew() => new UpdateListMembersRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateListMembersRequest";
    public override string GetFullClassName() => "Blaze::Association::UpdateListMembersRequest";

    public Blaze15SDK.Blaze.Association.ListMemberAttributes AttributesMask
    {
        get => _attributesMask.Value;
        set => _attributesMask.Value = value;
    }

    public long BlazeId
    {
        get => _blazeId.Value;
        set => _blazeId.Value = value;
    }

    public IList<Blaze15SDK.Blaze.Association.ListMemberId> ListMemberIdVector
    {
        get => _listMemberIdVector.Value;
        set => _listMemberIdVector.Value = value;
    }

    public uint MemberHash
    {
        get => _memberHash.Value;
        set => _memberHash.Value = value;
    }

    public Blaze15SDK.Blaze.Association.ListIdentification? ListIdentification
    {
        get => _listIdentification.Value;
        set => _listIdentification.Value = value;
    }

    public bool ValidateDelete
    {
        get => _validateDelete.Value;
        set => _validateDelete.Value = value;
    }

}
