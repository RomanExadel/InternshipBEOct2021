using DAL.Entities.Filtering;
using Shared.Models;

namespace WebApi.Models
{
    public class AGGridCandidatesFilter : AGGridBaseRequest
    {
        public CandidateFilterModel<string> CandidatesFilterBy { get; set; }

        public bool Asc { get; set; }

        public string SortBy { get; set; }
    }
}
