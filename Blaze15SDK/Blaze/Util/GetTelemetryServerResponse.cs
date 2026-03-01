using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.Util;

public class GetTelemetryServerResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Address", "mAddress", 0x04449300, TdfType.String, 0, true), // adrs
        new TdfMemberInfo("IsAnonymous", "mIsAnonymous", 0x04E3CE00, TdfType.Bool, 1, true), // anon
        new TdfMemberInfo("Key2", "mKey2", 0x08B15900, TdfType.Blob, 2, true), // bkey
        new TdfMemberInfo("Country", "mCountry", 0x0D449900, TdfType.UInt32, 3, true), // ctry
        new TdfMemberInfo("Disable", "mDisable", 0x1094C100, TdfType.String, 4, true), // disa
        new TdfMemberInfo("EnableDisconnectTelemetry", "mEnableDisconnectTelemetry", 0x1440D400, TdfType.Bool, 5, true), // edct
        new TdfMemberInfo("Filter", "mFilter", 0x18931400, TdfType.String, 6, true), // filt
        new TdfMemberInfo("Locale", "mLocale", 0x30F0C000, TdfType.UInt32, 7, true), // loc
        new TdfMemberInfo("Underage", "mUnderage", 0x34939200, TdfType.Bool, 8, true), // minr
        new TdfMemberInfo("NoToggleOk", "mNoToggleOk", 0x38F3CB00, TdfType.String, 9, true), // nook
        new TdfMemberInfo("PinEnvironment", "mPinEnvironment", 0x40539600, TdfType.String, 10, true), // penv
        new TdfMemberInfo("Port", "mPort", 0x40F49400, TdfType.UInt32, 11, true), // port
        new TdfMemberInfo("PinUrl", "mPinUrl", 0x41548C00, TdfType.String, 12, true), // purl
        new TdfMemberInfo("SendDelay", "mSendDelay", 0x4C431900, TdfType.UInt32, 13, true), // sdly
        new TdfMemberInfo("SessionID", "mSessionID", 0x4C54D300, TdfType.String, 14, true), // sess
        new TdfMemberInfo("Key", "mKey", 0x4CB15900, TdfType.String, 15, true), // skey
        new TdfMemberInfo("SendPercentage", "mSendPercentage", 0x4D00D400, TdfType.UInt32, 16, true), // spct
        new TdfMemberInfo("UseServerTime", "mUseServerTime", 0x4D424D00, TdfType.String, 17, true), // stim
        new TdfMemberInfo("TelemetryServiceName", "mTelemetryServiceName", 0x4D638D00, TdfType.String, 18, true), // svnm
    ];
    private ITdfMember[] __members;

    private TdfString _address = new(__typeInfos[0]);
    private TdfBool _isAnonymous = new(__typeInfos[1]);
    private TdfBlob _key2 = new(__typeInfos[2]);
    private TdfUInt32 _country = new(__typeInfos[3]);
    private TdfString _disable = new(__typeInfos[4]);
    private TdfBool _enableDisconnectTelemetry = new(__typeInfos[5]);
    private TdfString _filter = new(__typeInfos[6]);
    private TdfUInt32 _locale = new(__typeInfos[7]);
    private TdfBool _underage = new(__typeInfos[8]);
    private TdfString _noToggleOk = new(__typeInfos[9]);
    private TdfString _pinEnvironment = new(__typeInfos[10]);
    private TdfUInt32 _port = new(__typeInfos[11]);
    private TdfString _pinUrl = new(__typeInfos[12]);
    private TdfUInt32 _sendDelay = new(__typeInfos[13]);
    private TdfString _sessionID = new(__typeInfos[14]);
    private TdfString _key = new(__typeInfos[15]);
    private TdfUInt32 _sendPercentage = new(__typeInfos[16]);
    private TdfString _useServerTime = new(__typeInfos[17]);
    private TdfString _telemetryServiceName = new(__typeInfos[18]);

    public GetTelemetryServerResponse()
    {
        __members = [ _address, _isAnonymous, _key2, _country, _disable, _enableDisconnectTelemetry, _filter, _locale, _underage, _noToggleOk, _pinEnvironment, _port, _pinUrl, _sendDelay, _sessionID, _key, _sendPercentage, _useServerTime, _telemetryServiceName ];
    }

    public override Tdf CreateNew() => new GetTelemetryServerResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetTelemetryServerResponse";
    public override string GetFullClassName() => "Blaze::GameManager::GetTelemetryServerResponse";

    public string Address
    {
        get => _address.Value;
        set => _address.Value = value;
    }

    public bool IsAnonymous
    {
        get => _isAnonymous.Value;
        set => _isAnonymous.Value = value;
    }

    public byte[] Key2
    {
        get => _key2.Value;
        set => _key2.Value = value;
    }

    public uint Country
    {
        get => _country.Value;
        set => _country.Value = value;
    }

    public string Disable
    {
        get => _disable.Value;
        set => _disable.Value = value;
    }

    public bool EnableDisconnectTelemetry
    {
        get => _enableDisconnectTelemetry.Value;
        set => _enableDisconnectTelemetry.Value = value;
    }

    public string Filter
    {
        get => _filter.Value;
        set => _filter.Value = value;
    }

    public uint Locale
    {
        get => _locale.Value;
        set => _locale.Value = value;
    }

    public bool Underage
    {
        get => _underage.Value;
        set => _underage.Value = value;
    }

    public string NoToggleOk
    {
        get => _noToggleOk.Value;
        set => _noToggleOk.Value = value;
    }

    public string PinEnvironment
    {
        get => _pinEnvironment.Value;
        set => _pinEnvironment.Value = value;
    }

    public uint Port
    {
        get => _port.Value;
        set => _port.Value = value;
    }

    public string PinUrl
    {
        get => _pinUrl.Value;
        set => _pinUrl.Value = value;
    }

    public uint SendDelay
    {
        get => _sendDelay.Value;
        set => _sendDelay.Value = value;
    }

    public string SessionID
    {
        get => _sessionID.Value;
        set => _sessionID.Value = value;
    }

    public string Key
    {
        get => _key.Value;
        set => _key.Value = value;
    }

    public uint SendPercentage
    {
        get => _sendPercentage.Value;
        set => _sendPercentage.Value = value;
    }

    public string UseServerTime
    {
        get => _useServerTime.Value;
        set => _useServerTime.Value = value;
    }

    public string TelemetryServiceName
    {
        get => _telemetryServiceName.Value;
        set => _telemetryServiceName.Value = value;
    }

}
