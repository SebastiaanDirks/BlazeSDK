using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Association;

public class GetMemberHashResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BlazeId", "mBlazeId", 0x08910000, TdfType.Int64, 0, true), // bid
        new TdfMemberInfo("MemberHash", "mMemberHash", 0x2014C800, TdfType.UInt32, 1, true), // hash
        new TdfMemberInfo("ListType", "mListType", 0x51940500, TdfType.UInt16, 2, true), // type
    ];
    private ITdfMember[] __members;

    private TdfInt64 _blazeId = new(__typeInfos[0]);
    private TdfUInt32 _memberHash = new(__typeInfos[1]);
    private TdfUInt16 _listType = new(__typeInfos[2]);

    public GetMemberHashResponse()
    {
        __members = [ _blazeId, _memberHash, _listType ];
    }

    public override Tdf CreateNew() => new GetMemberHashResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetMemberHashResponse";
    public override string GetFullClassName() => "Blaze::Association::GetMemberHashResponse";

    public long BlazeId
    {
        get => _blazeId.Value;
        set => _blazeId.Value = value;
    }

    public uint MemberHash
    {
        get => _memberHash.Value;
        set => _memberHash.Value = value;
    }

    public ushort ListType
    {
        get => _listType.Value;
        set => _listType.Value = value;
    }

}
