using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.ByteVault;

public class PermissionsByAdminType : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PermissionsByAdminTypeMap", "mPermissionsByAdminTypeMap", 0x40548D00, TdfType.Map, 0, true), // perm
    ];
    private ITdfMember[] __members;

    private TdfMap<int, Blaze15SDK.Blaze.ByteVault.PermissionByActionType> _permissionsByAdminTypeMap = new(__typeInfos[0]);

    public PermissionsByAdminType()
    {
        __members = [ _permissionsByAdminTypeMap ];
    }

    public override Tdf CreateNew() => new PermissionsByAdminType();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PermissionsByAdminType";
    public override string GetFullClassName() => "Blaze::ByteVault::PermissionsByAdminType";

    public IDictionary<int, Blaze15SDK.Blaze.ByteVault.PermissionByActionType> PermissionsByAdminTypeMap
    {
        get => _permissionsByAdminTypeMap.Value;
        set => _permissionsByAdminTypeMap.Value = value;
    }

}
