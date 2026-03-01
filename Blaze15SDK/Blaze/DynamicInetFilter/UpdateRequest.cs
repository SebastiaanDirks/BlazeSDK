using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.DynamicInetFilter;

public class UpdateRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Comment", "mComment", 0x0CF34D00, TdfType.String, 0, true), // comm
        new TdfMemberInfo("Group", "mGroup", 0x1D240000, TdfType.String, 1, true), // grp
        new TdfMemberInfo("Owner", "mOwner", 0x3D739200, TdfType.String, 2, true), // ownr
        new TdfMemberInfo("RowId", "mRowId", 0x48910000, TdfType.UInt32, 3, true), // rid
        new TdfMemberInfo("SubNet", "mSubNet", 0x4CE15400, TdfType.Struct, 4, true), // snet
    ];
    private ITdfMember[] __members;

    private TdfString _comment = new(__typeInfos[0]);
    private TdfString _group = new(__typeInfos[1]);
    private TdfString _owner = new(__typeInfos[2]);
    private TdfUInt32 _rowId = new(__typeInfos[3]);
    private TdfStruct<Blaze15SDK.Blaze.CidrBlock?> _subNet = new(__typeInfos[4]);

    public UpdateRequest()
    {
        __members = [
            _comment,
            _group,
            _owner,
            _rowId,
            _subNet,
        ];
    }

    public override Tdf CreateNew() => new UpdateRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "UpdateRequest";
    public override string GetFullClassName() => "Blaze::DynamicInetFilter::UpdateRequest";

    public string Comment
    {
        get => _comment.Value;
        set => _comment.Value = value;
    }

    public string Group
    {
        get => _group.Value;
        set => _group.Value = value;
    }

    public string Owner
    {
        get => _owner.Value;
        set => _owner.Value = value;
    }

    public uint RowId
    {
        get => _rowId.Value;
        set => _rowId.Value = value;
    }

    public Blaze15SDK.Blaze.CidrBlock? SubNet
    {
        get => _subNet.Value;
        set => _subNet.Value = value;
    }

}
