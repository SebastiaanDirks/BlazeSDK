using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Clubs;

public class GetMembersAsyncResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Count", "mCount", 0x0CF39400, TdfType.UInt32, 0, true), // cont
        new TdfMemberInfo("SequenceID", "mSequenceID", 0x4D124400, TdfType.UInt32, 1, true), // sqid
        new TdfMemberInfo("TotalCount", "mTotalCount", 0x5033CE00, TdfType.UInt32, 2, true), // tcon
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _count = new(__typeInfos[0]);
    private TdfUInt32 _sequenceID = new(__typeInfos[1]);
    private TdfUInt32 _totalCount = new(__typeInfos[2]);

    public GetMembersAsyncResponse()
    {
        __members = [ _count, _sequenceID, _totalCount ];
    }

    public override Tdf CreateNew() => new GetMembersAsyncResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetMembersAsyncResponse";
    public override string GetFullClassName() => "Blaze::Clubs::GetMembersAsyncResponse";

    public uint Count
    {
        get => _count.Value;
        set => _count.Value = value;
    }

    public uint SequenceID
    {
        get => _sequenceID.Value;
        set => _sequenceID.Value = value;
    }

    public uint TotalCount
    {
        get => _totalCount.Value;
        set => _totalCount.Value = value;
    }

}
