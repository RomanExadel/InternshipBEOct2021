namespace WebApi.Models
{
    public class GetCandidatesByInternshipIdRequest : AGGridBaseRequest
    {
        public int InternshipId { get; set; }
    }
}
