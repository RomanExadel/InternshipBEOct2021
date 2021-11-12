using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Shared.Enums;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace BL.Services
{
    public class ReportService : IReportService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReportService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> GetCandidatesReportByInternshipIdAsync(int internshipId, ReportType reportType)
        {
            var candidates = await _unitOfWork.Candidates.GetCandidatesByInternshipIdAsync(internshipId, reportType);

            var report = await GetReportByAllCandidatesAsync(candidates);

            return await GetPathReport(report);
        }

        private async Task<byte[]> GetReportByAllCandidatesAsync(List<Candidate> report)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var package = new ExcelPackage();

            var sheet = package.Workbook.Worksheets.Add("Candidate Report");

            sheet.Cells[1, 1, 2, 1].Style.Font.Bold = true;
            sheet.Cells[1, 1].Value = "Internship: ";
            sheet.Cells[1, 2].Value = $"{report[0].Internship.Name}";
            sheet.Cells[2, 1].Value = "Candidate count: ";
            sheet.Cells[2, 2].Value = $"{report.Count}";

            sheet.Cells[4, 1, 4, 3].LoadFromArrays(new object[][] { new[] { "FirstName", "LastName", "StatusType" } });

            int row = 5, column = 1;

            foreach (var item in report)
            {
                sheet.Cells[row, column].Value = item.FirstName;
                sheet.Cells[row, column + 1].Value = item.LastName;
                sheet.Cells[row, column + 2].Value = item.StatusType;
                row++;
            }

            sheet.Cells[1, 1, row, column + 2].AutoFitColumns();
            sheet.Column(2).Width = 14;
            sheet.Column(3).Width = 12;
            sheet.Cells[4, 1, 4, 3].Style.Font.Bold = true;
            sheet.Cells[4, 1, 4, 3].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            sheet.Protection.IsProtected = true;

            return await package.GetAsByteArrayAsync();
        }

        private async Task<string> GetPathReport(byte[] report)
        {
            var path = Path.GetFullPath("../Shared/Reports/");
            var fileName = $"{path}Report.xlsx";

            await File.WriteAllBytesAsync(fileName, report);

            return fileName;
        }
    }
}
