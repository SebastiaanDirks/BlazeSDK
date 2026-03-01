using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Clubs;

public class GetNewsRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ClubId", "mClubId", 0x0CC24400, TdfType.UInt64, 0, true), // clid
        new TdfMemberInfo("MaxResultCount", "mMaxResultCount", 0x34339400, TdfType.UInt32, 1, true), // mcnt
        new TdfMemberInfo("SortType", "mSortType", 0x3933D400, TdfType.Enum, 2, true), // nsot
        new TdfMemberInfo("OffSet", "mOffSet", 0x3C64D400, TdfType.UInt32, 3, true), // ofst
        new TdfMemberInfo("TypeFilters", "mTypeFilters", 0x50624C00, TdfType.List, 4, true), // tfil
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _clubId = new(__typeInfos[0]);
    private TdfUInt32 _maxResultCount = new(__typeInfos[1]);
    private TdfEnum<TimeSortType> _sortType = new(__typeInfos[2]);
    private TdfUInt32 _offSet = new(__typeInfos[3]);
    private TdfList<NewsType> _typeFilters = new(__typeInfos[4]);

    public GetNewsRequest()
    {
        __members = [ _clubId, _maxResultCount, _sortType, _offSet, _typeFilters ];
    }

    public override Tdf CreateNew() => new GetNewsRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetNewsRequest";
    public override string GetFullClassName() => "Blaze::Clubs::GetNewsRequest";

    public ulong ClubId
    {
        get => _clubId.Value;
        set => _clubId.Value = value;
    }

    public uint MaxResultCount
    {
        get => _maxResultCount.Value;
        set => _maxResultCount.Value = value;
    }

    public TimeSortType SortType
    {
        get => _sortType.Value;
        set => _sortType.Value = value;
    }

    public uint OffSet
    {
        get => _offSet.Value;
        set => _offSet.Value = value;
    }

    public IList<NewsType> TypeFilters
    {
        get => _typeFilters.Value;
        set => _typeFilters.Value = value;
    }

}
