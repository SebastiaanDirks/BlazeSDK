using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Achievements;

public class AuxiliaryAuthentication : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("ApiVersion", "mApiVersion", 0x05024000, TdfType.Int32, 0, true), // api
        new TdfMemberInfo("AuthToken", "mAuthToken", 0x0543CB00, TdfType.String, 1, true), // atok
        new TdfMemberInfo("TrustedAuthToken", "mTrustedAuthToken", 0x05450B00, TdfType.String, 2, true), // attk
        new TdfMemberInfo("UserPassword", "mUserPassword", 0x21408100, TdfType.String, 3, true), // htba
        new TdfMemberInfo("Signature", "mSignature", 0x4C91CE00, TdfType.String, 4, true), // sign
        new TdfMemberInfo("SecretKey", "mSecretKey", 0x4CB15900, TdfType.String, 5, true), // skey
        new TdfMemberInfo("Timestamp", "mTimestamp", 0x50934500, TdfType.Int64, 6, true), // time
        new TdfMemberInfo("User", "mUser", 0x55315200, TdfType.Struct, 7, true), // user
    ];
    private ITdfMember[] __members;

    private TdfInt32 _apiVersion = new(__typeInfos[0]);
    private TdfString _authToken = new(__typeInfos[1]);
    private TdfString _trustedAuthToken = new(__typeInfos[2]);
    private TdfString _userPassword = new(__typeInfos[3]);
    private TdfString _signature = new(__typeInfos[4]);
    private TdfString _secretKey = new(__typeInfos[5]);
    private TdfInt64 _timestamp = new(__typeInfos[6]);
    private TdfStruct<User?> _user = new(__typeInfos[7]);

    public AuxiliaryAuthentication()
    {
        __members = [ _apiVersion, _authToken, _trustedAuthToken, _userPassword, _signature, _secretKey, _timestamp, _user ];
    }

    public override Tdf CreateNew() => new AuxiliaryAuthentication();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "AuxiliaryAuthentication";
    public override string GetFullClassName() => "Blaze::Achievements::AuxiliaryAuthentication";

    public int ApiVersion
    {
        get => _apiVersion.Value;
        set => _apiVersion.Value = value;
    }

    public string AuthToken
    {
        get => _authToken.Value;
        set => _authToken.Value = value;
    }

    public string TrustedAuthToken
    {
        get => _trustedAuthToken.Value;
        set => _trustedAuthToken.Value = value;
    }

    public string UserPassword
    {
        get => _userPassword.Value;
        set => _userPassword.Value = value;
    }

    public string Signature
    {
        get => _signature.Value;
        set => _signature.Value = value;
    }

    public string SecretKey
    {
        get => _secretKey.Value;
        set => _secretKey.Value = value;
    }

    public long Timestamp
    {
        get => _timestamp.Value;
        set => _timestamp.Value = value;
    }

    public User? User
    {
        get => _user.Value;
        set => _user.Value = value;
    }

}
