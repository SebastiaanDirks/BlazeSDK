using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Association;

public class ListInfo : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("BlazeObjId", "mBlazeObjId", 0x08F24400, TdfType.ObjectId, 0, true), // boid
        new TdfMemberInfo("StatusFlags", "mStatusFlags", 0x18C1D300, TdfType.Enum, 1, true), // flgs
        new TdfMemberInfo("Id", "mId", 0x30910000, TdfType.Struct, 2, true), // lid
        new TdfMemberInfo("MaxSize", "mMaxSize", 0x30D4C000, TdfType.UInt32, 3, true), // lms
        new TdfMemberInfo("PairName", "mPairName", 0x40E04D00, TdfType.String, 4, true), // pnam
        new TdfMemberInfo("PairId", "mPairId", 0x41224400, TdfType.UInt16, 5, true), // prid
        new TdfMemberInfo("PairMaxSize", "mPairMaxSize", 0x41235300, TdfType.UInt32, 6, true), // prms
    ];
    private ITdfMember[] __members;

    private TdfObjectId _blazeObjId = new(__typeInfos[0]);
    private TdfEnum<Blaze15SDK.Blaze.Association.ListStatusFlags> _statusFlags = new(__typeInfos[1]);
    private TdfStruct<Blaze15SDK.Blaze.Association.ListIdentification?> _id = new(__typeInfos[2]);
    private TdfUInt32 _maxSize = new(__typeInfos[3]);
    private TdfString _pairName = new(__typeInfos[4]);
    private TdfUInt16 _pairId = new(__typeInfos[5]);
    private TdfUInt32 _pairMaxSize = new(__typeInfos[6]);

    public ListInfo()
    {
        __members = [ _blazeObjId, _statusFlags, _id, _maxSize, _pairName, _pairId, _pairMaxSize ];
    }

    public override Tdf CreateNew() => new ListInfo();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ListInfo";
    public override string GetFullClassName() => "Blaze::Association::ListInfo";

    public ObjectId BlazeObjId
    {
        get => _blazeObjId.Value;
        set => _blazeObjId.Value = value;
    }

    public Blaze15SDK.Blaze.Association.ListStatusFlags StatusFlags
    {
        get => _statusFlags.Value;
        set => _statusFlags.Value = value;
    }

    public Blaze15SDK.Blaze.Association.ListIdentification? Id
    {
        get => _id.Value;
        set => _id.Value = value;
    }

    public uint MaxSize
    {
        get => _maxSize.Value;
        set => _maxSize.Value = value;
    }

    public string PairName
    {
        get => _pairName.Value;
        set => _pairName.Value = value;
    }

    public ushort PairId
    {
        get => _pairId.Value;
        set => _pairId.Value = value;
    }

    public uint PairMaxSize
    {
        get => _pairMaxSize.Value;
        set => _pairMaxSize.Value = value;
    }

}
