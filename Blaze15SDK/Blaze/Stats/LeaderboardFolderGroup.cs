using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Stats;

public class LeaderboardFolderGroup : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("FolderDescriptors", "mFolderDescriptors", 0x18C11300, TdfType.List, 0, true), // flds
        new TdfMemberInfo("Metadata", "mMetadata", 0x34550100, TdfType.String, 1, true), // meta
        new TdfMemberInfo("Description", "mDescription", 0x3D711300, TdfType.String, 2, true), // owds
        new TdfMemberInfo("FolderId", "mFolderId", 0x3D724400, TdfType.UInt32, 3, true), // owid
        new TdfMemberInfo("Name", "mName", 0x3D738D00, TdfType.String, 4, true), // ownm
        new TdfMemberInfo("ParentId", "mParentId", 0x41224400, TdfType.UInt32, 5, true), // prid
        new TdfMemberInfo("ShortDesc", "mShortDesc", 0x4C415300, TdfType.String, 6, true), // sdes
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze15SDK.Blaze.Stats.FolderDescriptor> _folderDescriptors = new(__typeInfos[0]);
    private TdfString _metadata = new(__typeInfos[1]);
    private TdfString _description = new(__typeInfos[2]);
    private TdfUInt32 _folderId = new(__typeInfos[3]);
    private TdfString _name = new(__typeInfos[4]);
    private TdfUInt32 _parentId = new(__typeInfos[5]);
    private TdfString _shortDesc = new(__typeInfos[6]);

    public LeaderboardFolderGroup()
    {
        __members = [ _folderDescriptors, _metadata, _description, _folderId, _name, _parentId, _shortDesc ];
    }

    public override Tdf CreateNew() => new LeaderboardFolderGroup();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "LeaderboardFolderGroup";
    public override string GetFullClassName() => "Blaze::Stats::LeaderboardFolderGroup";

    public IList<Blaze15SDK.Blaze.Stats.FolderDescriptor> FolderDescriptors
    {
        get => _folderDescriptors.Value;
        set => _folderDescriptors.Value = value;
    }

    public string Metadata
    {
        get => _metadata.Value;
        set => _metadata.Value = value;
    }

    public string Description
    {
        get => _description.Value;
        set => _description.Value = value;
    }

    public uint FolderId
    {
        get => _folderId.Value;
        set => _folderId.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public uint ParentId
    {
        get => _parentId.Value;
        set => _parentId.Value = value;
    }

    public string ShortDesc
    {
        get => _shortDesc.Value;
        set => _shortDesc.Value = value;
    }

}
