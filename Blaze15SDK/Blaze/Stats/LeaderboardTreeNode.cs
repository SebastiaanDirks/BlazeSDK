using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Stats;

public class LeaderboardTreeNode : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ChildCount", "mChildCount", 0x0C810300, TdfType.UInt32, 0, true), // chdc
        new TdfMemberInfo("FirstChild", "mFirstChild", 0x0C811300, TdfType.UInt32, 1, true), // chds
        new TdfMemberInfo("LastNode", "mLastNode", 0x3014D400, TdfType.Bool, 2, true), // last
        new TdfMemberInfo("NodeName", "mNodeName", 0x38134500, TdfType.String, 3, true), // name
        new TdfMemberInfo("NodeId", "mNodeId", 0x38424400, TdfType.UInt32, 4, true), // ndid
        new TdfMemberInfo("RootName", "mRootName", 0x49438D00, TdfType.String, 5, true), // rtnm
        new TdfMemberInfo("ShortDesc", "mShortDesc", 0x4C415300, TdfType.String, 6, true), // sdes
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _childCount = new(__typeInfos[0]);
    private TdfUInt32 _firstChild = new(__typeInfos[1]);
    private TdfBool _lastNode = new(__typeInfos[2]);
    private TdfString _nodeName = new(__typeInfos[3]);
    private TdfUInt32 _nodeId = new(__typeInfos[4]);
    private TdfString _rootName = new(__typeInfos[5]);
    private TdfString _shortDesc = new(__typeInfos[6]);

    public LeaderboardTreeNode()
    {
        __members = [ _childCount, _firstChild, _lastNode, _nodeName, _nodeId, _rootName, _shortDesc ];
    }

    public override Tdf CreateNew() => new LeaderboardTreeNode();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LeaderboardTreeNode";
    public override string GetFullClassName() => "Blaze::Stats::LeaderboardTreeNode";

    public uint ChildCount
    {
        get => _childCount.Value;
        set => _childCount.Value = value;
    }

    public uint FirstChild
    {
        get => _firstChild.Value;
        set => _firstChild.Value = value;
    }

    public bool LastNode
    {
        get => _lastNode.Value;
        set => _lastNode.Value = value;
    }

    public string NodeName
    {
        get => _nodeName.Value;
        set => _nodeName.Value = value;
    }

    public uint NodeId
    {
        get => _nodeId.Value;
        set => _nodeId.Value = value;
    }

    public string RootName
    {
        get => _rootName.Value;
        set => _rootName.Value = value;
    }

    public string ShortDesc
    {
        get => _shortDesc.Value;
        set => _shortDesc.Value = value;
    }

}
