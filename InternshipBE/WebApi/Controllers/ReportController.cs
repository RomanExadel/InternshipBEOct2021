﻿using BL.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using WebApi.Models;

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
            var fileName = await _reportService.GetCandidatesReportByInternshipIdAsync(request.InternshipId, request.ReportType);

            string file_path = Path.Combine(_webHost.ContentRootPath, fileName);
            string file_type = "application/xlsx";


            return PhysicalFile(file_path, file_type, fileName);
        }
    }
}