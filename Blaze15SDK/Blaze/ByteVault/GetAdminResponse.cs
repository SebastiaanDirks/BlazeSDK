using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.ByteVault;

public class GetAdminResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AdminTypeListByContextMap", "mAdminTypeListByContextMap", 0x34140000, TdfType.Map, 0, true), // map
        new TdfMemberInfo("PermissionsByAdminTypeMap", "mPermissionsByAdminTypeMap", 0x40548D00, TdfType.Map, 1, true), // perm
    ];
    private ITdfMember[] __members;

    private TdfMap<string, IList<int>> _adminTypeListByContextMap = new(__typeInfos[0]);
    private TdfMap<int, Blaze15SDK.Blaze.ByteVault.PermissionByActionType> _permissionsByAdminTypeMap = new(__typeInfos[1]);

    public GetAdminResponse()
    {
        __members = [ _adminTypeListByContextMap, _permissionsByAdminTypeMap ];
    }

    public override Tdf CreateNew() => new GetAdminResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetAdminResponse";
    public override string GetFullClassName() => "Blaze::ByteVault::GetAdminResponse";

    public IDictionary<string, IList<int>> AdminTypeListByContextMap
    {
        get => _adminTypeListByContextMap.Value;
        set => _adminTypeListByContextMap.Value = value;
    }

    public IDictionary<int, Blaze15SDK.Blaze.ByteVault.PermissionByActionType> PermissionsByAdminTypeMap
    {
        get => _permissionsByAdminTypeMap.Value;
        set => _permissionsByAdminTypeMap.Value = value;
    }

}
