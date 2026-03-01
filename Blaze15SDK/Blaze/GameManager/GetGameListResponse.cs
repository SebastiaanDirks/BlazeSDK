using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GameManager;

public class GetGameListResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ListId", "mListId", 0x1CC24400, TdfType.UInt64, 0, true), // glid
        new TdfMemberInfo("IsSnapshotList", "mIsSnapshotList", 0x1CD31400, TdfType.Bool, 1, true), // gmlt
        new TdfMemberInfo("ListCapacity", "mListCapacity", 0x30305000, TdfType.UInt32, 2, true), // lcap
        new TdfMemberInfo("MaxPossibleFitScore", "mMaxPossibleFitScore", 0x34160600, TdfType.UInt32, 3, true), // maxf
        new TdfMemberInfo("NumberOfGamesToBeDownloaded", "mNumberOfGamesToBeDownloaded", 0x38710000, TdfType.UInt32, 4, true), // ngd
        new TdfMemberInfo("MaxUpdateInterval", "mMaxUpdateInterval", 0x55024E00, TdfType.Int64, 5, true), // upin
    ];
    private ITdfMember[] __members;

    private TdfUInt64 _listId = new(__typeInfos[0]);
    private TdfBool _isSnapshotList = new(__typeInfos[1]);
    private TdfUInt32 _listCapacity = new(__typeInfos[2]);
    private TdfUInt32 _maxPossibleFitScore = new(__typeInfos[3]);
    private TdfUInt32 _numberOfGamesToBeDownloaded = new(__typeInfos[4]);
    private TdfInt64 _maxUpdateInterval = new(__typeInfos[5]);

    public GetGameListResponse()
    {
        __members = [ _listId, _isSnapshotList, _listCapacity, _maxPossibleFitScore, _numberOfGamesToBeDownloaded, _maxUpdateInterval ];
    }

    public override Tdf CreateNew() => new GetGameListResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetGameListResponse";
    public override string GetFullClassName() => "Blaze::GameManager::GetGameListResponse";

    public ulong ListId
    {
        get => _listId.Value;
        set => _listId.Value = value;
    }

    public bool IsSnapshotList
    {
        get => _isSnapshotList.Value;
        set => _isSnapshotList.Value = value;
    }

    public uint ListCapacity
    {
        get => _listCapacity.Value;
        set => _listCapacity.Value = value;
    }

    public uint MaxPossibleFitScore
    {
        get => _maxPossibleFitScore.Value;
        set => _maxPossibleFitScore.Value = value;
    }

    public uint NumberOfGamesToBeDownloaded
    {
        get => _numberOfGamesToBeDownloaded.Value;
        set => _numberOfGamesToBeDownloaded.Value = value;
    }

    public long MaxUpdateInterval
    {
        get => _maxUpdateInterval.Value;
        set => _maxUpdateInterval.Value = value;
    }

}
