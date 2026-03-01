using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Social.Friends;

public class PagingInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Offset", "mOffset", 0x3C64D400, TdfType.Int32, 0, true), // ofst
        new TdfMemberInfo("Size", "mSize", 0x4C968500, TdfType.Int32, 1, true), // size
        new TdfMemberInfo("TotalSize", "mTotalSize", 0x5124DA00, TdfType.Int32, 2, true), // trsz
    ];
    private ITdfMember[] __members;

    private TdfInt32 _offset = new(__typeInfos[0]);
    private TdfInt32 _size = new(__typeInfos[1]);
    private TdfInt32 _totalSize = new(__typeInfos[2]);

    public PagingInfo()
    {
        __members = [ _offset, _size, _totalSize ];
    }

    public override Tdf CreateNew() => new PagingInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PagingInfo";
    public override string GetFullClassName() => "Blaze::Social::Friends::PagingInfo";

    public int Offset
    {
        get => _offset.Value;
        set => _offset.Value = value;
    }

    public int Size
    {
        get => _size.Value;
        set => _size.Value = value;
    }

    public int TotalSize
    {
        get => _totalSize.Value;
        set => _totalSize.Value = value;
    }

}
