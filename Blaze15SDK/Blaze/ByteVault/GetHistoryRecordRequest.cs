using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.ByteVault;

public class GetHistoryRecordRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RecordAddress", "mRecordAddress", 0x04411200, TdfType.Struct, 0, true), // addr
        new TdfMemberInfo("AuthCredentials", "mAuthCredentials", 0x05550800, TdfType.Struct, 1, true), // auth
        new TdfMemberInfo("LastUpdateTime", "mLastUpdateTime", 0x3014D400, TdfType.Int64, 2, true), // last
        new TdfMemberInfo("Subrecord", "mSubrecord", 0x4D509200, TdfType.String, 3, true), // subr
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.ByteVault.RecordAddress?> _recordAddress = new(__typeInfos[0]);
    private TdfStruct<Blaze15SDK.Blaze.ByteVault.AuthenticationCredentials?> _authCredentials = new(__typeInfos[1]);
    private TdfInt64 _lastUpdateTime = new(__typeInfos[2]);
    private TdfString _subrecord = new(__typeInfos[3]);

    public GetHistoryRecordRequest()
    {
        __members = [ _recordAddress, _authCredentials, _lastUpdateTime, _subrecord ];
    }

    public override Tdf CreateNew() => new GetHistoryRecordRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetHistoryRecordRequest";
    public override string GetFullClassName() => "Blaze::ByteVault::GetHistoryRecordRequest";

    public Blaze15SDK.Blaze.ByteVault.RecordAddress? RecordAddress
    {
        get => _recordAddress.Value;
        set => _recordAddress.Value = value;
    }

    public Blaze15SDK.Blaze.ByteVault.AuthenticationCredentials? AuthCredentials
    {
        get => _authCredentials.Value;
        set => _authCredentials.Value = value;
    }

    public long LastUpdateTime
    {
        get => _lastUpdateTime.Value;
        set => _lastUpdateTime.Value = value;
    }

    public string Subrecord
    {
        get => _subrecord.Value;
        set => _subrecord.Value = value;
    }

}
