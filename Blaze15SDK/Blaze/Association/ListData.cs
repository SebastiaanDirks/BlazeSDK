using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Association;

public class ListData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Id", "mId", 0x24400000, TdfType.UInt16, 0, true), // id
        new TdfMemberInfo("MutualAction", "mMutualAction", 0x35550100, TdfType.Bool, 1, true), // muta
        new TdfMemberInfo("Name", "mName", 0x38134500, TdfType.String, 2, true), // name
        new TdfMemberInfo("LoadOfflineUED", "mLoadOfflineUED", 0x3C618C00, TdfType.Bool, 3, true), // offl
        new TdfMemberInfo("PairId", "mPairId", 0x41224400, TdfType.UInt16, 4, true), // prid
        new TdfMemberInfo("Rollover", "mRollover", 0x48F30C00, TdfType.Bool, 5, true), // roll
        new TdfMemberInfo("Subscribe", "mSubscribe", 0x4C348900, TdfType.Bool, 6, true), // scri
        new TdfMemberInfo("MaxSize", "mMaxSize", 0x4C968500, TdfType.UInt32, 7, true), // size
    ];
    private ITdfMember[] __members;

    private TdfUInt16 _id = new(__typeInfos[0]);
    private TdfBool _mutualAction = new(__typeInfos[1]);
    private TdfString _name = new(__typeInfos[2]);
    private TdfBool _loadOfflineUED = new(__typeInfos[3]);
    private TdfUInt16 _pairId = new(__typeInfos[4]);
    private TdfBool _rollover = new(__typeInfos[5]);
    private TdfBool _subscribe = new(__typeInfos[6]);
    private TdfUInt32 _maxSize = new(__typeInfos[7]);

    public ListData()
    {
        __members = [ _id, _mutualAction, _name, _loadOfflineUED, _pairId, _rollover, _subscribe, _maxSize ];
    }

    public override Tdf CreateNew() => new ListData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListData";
    public override string GetFullClassName() => "Blaze::Association::ListData";

    public ushort Id
    {
        get => _id.Value;
        set => _id.Value = value;
    }

    public bool MutualAction
    {
        get => _mutualAction.Value;
        set => _mutualAction.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public bool LoadOfflineUED
    {
        get => _loadOfflineUED.Value;
        set => _loadOfflineUED.Value = value;
    }

    public ushort PairId
    {
        get => _pairId.Value;
        set => _pairId.Value = value;
    }

    public bool Rollover
    {
        get => _rollover.Value;
        set => _rollover.Value = value;
    }

    public bool Subscribe
    {
        get => _subscribe.Value;
        set => _subscribe.Value = value;
    }

    public uint MaxSize
    {
        get => _maxSize.Value;
        set => _maxSize.Value = value;
    }

}
