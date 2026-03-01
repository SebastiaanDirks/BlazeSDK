using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze15SDK.Blaze.GpsContentController;

public class FilePetitionRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AttributeMap", "attributeMap", 0x04E59000, TdfType.Map, 0, true), // anvp
        new TdfMemberInfo("ContentId", "mContentId", 0x0CF24400, TdfType.ObjectId, 1, true), // coid
        new TdfMemberInfo("ComplaintType", "mComplaintType", 0x0CF51900, TdfType.String, 2, true), // coty
        new TdfMemberInfo("ContentType", "mContentType", 0x40E0D400, TdfType.Enum, 3, true), // pnct
        new TdfMemberInfo("PetitionDetail", "mPetitionDetail", 0x41410500, TdfType.String, 4, true), // ptde
        new TdfMemberInfo("Subject", "mSubject", 0x4D508A00, TdfType.String, 5, true), // subj
        new TdfMemberInfo("TimeZone", "mTimeZone", 0x50D68F00, TdfType.String, 6, true), // tmzo
        new TdfMemberInfo("TargetUsers", "mTargetUsers", 0x5121D400, TdfType.List, 7, true), // trgt
    ];
    private ITdfMember[] __members;

    private TdfMap<string, string> _attributeMap = new(__typeInfos[0]);
    private TdfObjectId _contentId = new(__typeInfos[1]);
    private TdfString _complaintType = new(__typeInfos[2]);
    private TdfEnum<PetitionContentType> _contentType = new(__typeInfos[3]);
    private TdfString _petitionDetail = new(__typeInfos[4]);
    private TdfString _subject = new(__typeInfos[5]);
    private TdfString _timeZone = new(__typeInfos[6]);
    private TdfList<long> _targetUsers = new(__typeInfos[7]);

    public FilePetitionRequest()
    {
        __members = [
            _attributeMap,
            _contentId,
            _complaintType,
            _contentType,
            _petitionDetail,
            _subject,
            _timeZone,
            _targetUsers,
        ];
    }

    public override Tdf CreateNew() => new FilePetitionRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "FilePetitionRequest";
    public override string GetFullClassName() => "Blaze::GpsContentController::FilePetitionRequest";

    public IDictionary<string, string> AttributeMap
    {
        get => _attributeMap.Value;
        set => _attributeMap.Value = value;
    }

    public EATDF.Types.ObjectId ContentId
    {
        get => _contentId.Value;
        set => _contentId.Value = value;
    }

    public string ComplaintType
    {
        get => _complaintType.Value;
        set => _complaintType.Value = value;
    }

    public PetitionContentType ContentType
    {
        get => _contentType.Value;
        set => _contentType.Value = value;
    }

    public string PetitionDetail
    {
        get => _petitionDetail.Value;
        set => _petitionDetail.Value = value;
    }

    public string Subject
    {
        get => _subject.Value;
        set => _subject.Value = value;
    }

    public string TimeZone
    {
        get => _timeZone.Value;
        set => _timeZone.Value = value;
    }

    public IList<long> TargetUsers
    {
        get => _targetUsers.Value;
        set => _targetUsers.Value = value;
    }

}
