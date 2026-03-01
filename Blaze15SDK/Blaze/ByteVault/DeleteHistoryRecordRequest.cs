using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.ByteVault;

public class DeleteHistoryRecordRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("RecordAddress", "mRecordAddress", 0x04411200, TdfType.Struct, 0, true), // addr
        new TdfMemberInfo("AuthCredentials", "mAuthCredentials", 0x05550800, TdfType.Struct, 1, true), // auth
        new TdfMemberInfo("LastUpdateTime", "mLastUpdateTime", 0x3014D400, TdfType.Int64, 2, true), // last
    ];
    private ITdfMember[] __members;

    private TdfStruct<Blaze15SDK.Blaze.ByteVault.RecordAddress?> _recordAddress = new(__typeInfos[0]);
    private TdfStruct<Blaze15SDK.Blaze.ByteVault.AuthenticationCredentials?> _authCredentials = new(__typeInfos[1]);
    private TdfInt64 _lastUpdateTime = new(__typeInfos[2]);

    public DeleteHistoryRecordRequest()
    {
        __members = [ _recordAddress, _authCredentials, _lastUpdateTime ];
    }

    public override Tdf CreateNew() => new DeleteHistoryRecordRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "DeleteHistoryRecordRequest";
    public override string GetFullClassName() => "Blaze::ByteVault::DeleteHistoryRecordRequest";

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

}
