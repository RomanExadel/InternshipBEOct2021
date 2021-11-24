namespace WebApi.Models
{
    public class GetCandidatesByInternshipIdRequest : AGGridCandidatesFilter
    {
        public int InternshipId { get; set; }
    }
}
