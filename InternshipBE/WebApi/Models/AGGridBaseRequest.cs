using BL.DTOs.CandidateDTOs;

namespace WebApi.Models
{
    public class AGGridBaseRequest
    {
        public int PageSize { get; set; }

        public int PageNumber { get; set; }

        public string SortBy { get; set; }

        public bool Desc { get; set; }

        public CandidateFilterModelDTO FilterBy { get; set; }

    }
}
