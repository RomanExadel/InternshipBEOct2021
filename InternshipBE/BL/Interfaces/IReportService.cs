using Shared.Enums;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IReportService
    {
        Task<string> GetCandidatesReportByInternshipIdAsync(int internshipId, ReportType reportType);
    }
}
