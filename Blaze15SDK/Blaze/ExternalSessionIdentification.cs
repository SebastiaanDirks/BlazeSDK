using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze;

public class ExternalSessionIdentification : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Xone", "mXone", 0x60F38500, TdfType.Struct, 0, true), // xone
        new TdfMemberInfo("Ps4", "mPs4", 0x41350000, TdfType.Struct, 1, true), // ps4
        new TdfMemberInfo("Ps5", "mPs5", 0x41354000, TdfType.Struct, 2, true), // ps5
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.XboxOneExternalSessionIdentification?> _xone = new(__typeInfos[0]);
    private TdfStruct<Blaze15SDK.Blaze.Ps4ExternalSessionIdentification?> _ps4 = new(__typeInfos[1]);
    private TdfStruct<Blaze15SDK.Blaze.Ps5ExternalSessionIdentification?> _ps5 = new(__typeInfos[2]);

    public ExternalSessionIdentification()
    {
        __members = [
            _xone,
            _ps4,
            _ps5,
        ];
    }

    public override Tdf CreateNew() => new ExternalSessionIdentification();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ExternalSessionIdentification";
    public override string GetFullClassName() => "Blaze::ExternalSessionIdentification";

    public Blaze15SDK.Blaze.XboxOneExternalSessionIdentification? Xone
    {
        get => _xone.Value;
        set => _xone.Value = value;
    }

    public Blaze15SDK.Blaze.Ps4ExternalSessionIdentification? Ps4
    {
        get => _ps4.Value;
        set => _ps4.Value = value;
    }

    public Blaze15SDK.Blaze.Ps5ExternalSessionIdentification? Ps5
    {
        get => _ps5.Value;
        set => _ps5.Value = value;
    }

}
