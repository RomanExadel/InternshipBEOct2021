namespace BL.DTOs.InternshipDTOs
{
    public class GetInternshipDTO : InternshipDTO
    {
        public int Id { get; set; }

        public int CandidatesCount { get; set; }

        public int DeclinedCandidatesCount { get; set; }

        public int AcceptedCandidatesCount { get; set; }

        public int AbandonedCandidatesCount { get; set; }

        public int SuccessfullyFinishedCandidatesCount { get; set; }

        public int TeamsCount { get; set; }
    }
}
