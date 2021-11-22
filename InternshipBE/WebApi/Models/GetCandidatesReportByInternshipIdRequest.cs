using Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class GetCandidatesReportByInternshipIdRequest
    {
        [Required(ErrorMessage = "InternshipId is required")]
        public int InternshipId { get; set; }

        [Required(ErrorMessage = "ReportType is required")]
        public ReportType ReportType { get; set; }
    }
}
