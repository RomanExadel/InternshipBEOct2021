namespace Shared.Models
{
    public class GetCandidatesByInternshipIdRequest
    {
        public int InternshipId { get; set; }

        public int ItemsCount { get; set; }

        public int PageNumber { get; set; }
    }
}
