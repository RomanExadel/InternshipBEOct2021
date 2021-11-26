using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Shared.Enums;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using static Shared.Constants.ExportFileOffsets;
using static Shared.Constants.ExportFileColumnNames;
using System;

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

        private async Task<byte[]> GetReportByAllCandidatesAsync(List<Candidate> candidates)
        {
            if (candidates == null && candidates.Count == 0)
                throw new ArgumentNullException(nameof(candidates), "candidates is null");

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var package = new ExcelPackage();

            var sheet = package.Workbook.Worksheets.Add("Candidate Report");

            sheet.Cells[STYLE_RANGE_OFFSET].Style.Font.Bold = true;
            sheet.Cells[INTERNSHIP_NAME_ROW_OFFSET, INTERNSHIP_NAME_COLUMN_OFFSET].Value = "Internship: ";
            sheet.Cells[INTERNSHIP_VALUE_OFFSET].Value = $"{candidates[0].Internship.Name}";
            sheet.Cells[CANDIDATE_COUNT_NAME_OFFSET].Value = "Candidate count: ";
            sheet.Cells[CANDIDATE_COUNT_VALUE_OFFSET].Value = $"{candidates.Count}";
            sheet.Cells[NAME_DATE_REPORT_OFFSET].Value = "Report creation date:";
            sheet.Cells[DATE_REPORT_OFFSET].Value = $"{DateTime.UtcNow.ToShortDateString()}";

            sheet.Cells[STYLE_RANGE_ARRAY_NAME_OFFSET].LoadFromArrays(new object[][]
            {
                new[] 
                { 
                    COLUMN_NAME_FIRSTNAME, COLUMN_NAME_LASTNAME, COLUMN_NAME_LOCATION,COLUMN_NAME_DATE_REGISTRATION,
                     COLUMN_NAME_INTERNSHIP_LANGUAGE, COLUMN_NAME_STACK, COLUMN_NAME_ENGLISH_LVL,
                    COLUMN_NAME_PHONE, COLUMN_NAME_EMAIL, COLUMN_NAME_SKYPE, COLUMN_NAME_STATUSTYPE
                }
            });

            int row = 6, column = 1;

            foreach (var item in candidates)
            {
                sheet.Cells[row, column].Value = item.FirstName;
                sheet.Cells[row, column + 1].Value = item.LastName;
                sheet.Cells[row, column + 3].Value = item.RegistrationDate.ToShortDateString();
                sheet.Cells[row, column + 2].Value = item.Location;
                sheet.Cells[row, column + 4].Value = item.InternshipLanguage;
                sheet.Cells[row, column + 5].Value = item.StackType;
                sheet.Cells[row, column + 6].Value = item.EnglishLevelType;
                sheet.Cells[row, column + 7].Value = item.Phone;
                sheet.Cells[row, column + 8].Value = item.Email;
                sheet.Cells[row, column + 9].Value = item.Skype;
                sheet.Cells[row, column + 10].Value = item.StatusType;
                row++;
            }

            sheet.Cells[INTERNSHIP_NAME_ROW_OFFSET, INTERNSHIP_NAME_COLUMN_OFFSET, row, column + 10].AutoFitColumns();
            sheet.Column(2).Width = 14;
            sheet.Column(3).Width = 12;
            sheet.Cells[STYLE_RANGE_ARRAY_NAME_OFFSET].Style.Font.Bold = true;
            sheet.Cells[STYLE_RANGE_ARRAY_NAME_OFFSET].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            sheet.Cells[STYLE_RANGE_ARRAY_NAME_OFFSET].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;            
            sheet.Protection.IsProtected = true;

            return await package.GetAsByteArrayAsync();
        }

        private async Task<string> GetPathReport(byte[] report)
        {
            var path = AppContext.BaseDirectory;

            var fullPath = $"{path}Report.xlsx";

            await File.WriteAllBytesAsync(fullPath, report);

            return fullPath;
        }
    }
}
