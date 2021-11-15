using BL.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using WebApi.Models;
using static Shared.Constants.ExportFileSettings;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;
        private readonly IWebHostEnvironment _webHost;

        public ReportController(IReportService reportService, IWebHostEnvironment webHost)
        {
            _reportService = reportService;
            _webHost = webHost;
        }

        [HttpGet("getCandidatesReportByInternshipId")]
        public async Task<IActionResult> GetCandidatesReportByInternshipId([FromQuery] GetCandidatesReportByInternshipIdRequest request)
        {
            var filePath = await _reportService.GetCandidatesReportByInternshipIdAsync(request.InternshipId, request.ReportType);

            var physicalPath = Path.Combine(_webHost.ContentRootPath, filePath);

            return PhysicalFile(physicalPath, FILE_TYPE, FILE_NAME);
        }
    }
}
