using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class SeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0b731dd5-1fd4-492d-93a2-2255feda1760", "5f3074e4-186b-4b9a-8d9b-cd12b5fa367f", "Admin", "ADMIN" },
                    { "c3e7b270-90be-455d-8670-d7700376d439", "c3e11335-e233-4698-a6c2-b306726e7045", "Interviewer", "INTERVIEWER" },
                    { "55d43182-1e39-43ec-ad5f-ca26779f1b57", "b026e5c6-196e-4b55-9c5f-296af9431515", "Hr", "HR" },
                    { "ddf1abd2-d031-4cfd-8fd4-d52a9f145364", "7c309dfb-427f-4956-a6d6-b3dbc42e4312", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "RoleType", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1b8ba634-1e07-4ccc-b2ff-f9fb55eb1235", 0, "3f8c1ea2-cd84-4a19-9dc7-61731d09c480", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ALEXANDR", "AQAAAAEAACcQAAAAEHlFwWRf+dOW1cnG34tMZpyIOxfM5X+oo9ykVgaP1kT8SAXAMrPZNSH9n673kn7Onw==", "+325659787", false, "PO", 4, "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Alexandr" },
                    { "486beeab-f5e9-4b28-ad60-581a9922dd1f", 0, "13b7dad8-3747-4b52-83f5-691c420c6aee", "user@example.com", false, true, null, "USER@EXAMPLE.COM", "DASHA", "AQAAAAEAACcQAAAAEBxbkOnArAuMVc1wOLhStNJX5uVi9/nWPeJIZ3Ul56SdmAeXddbpMLHkK2zZVpJbcw==", "+325656787", false, "Front", 3, "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Dasha" },
                    { "e473f291-3797-4568-b22d-be1b9e563259", 0, "97b9665f-d665-4e09-9982-a580eb1011ac", "max@gmail.com", false, true, null, "MAX@GMAIL.COM", "MAXIM", "AQAAAAEAACcQAAAAEHYU5rXMGtjFQNZCehrJzlZp22gMB8uAT76nvFrZ+oydSJpyTc7KT+IvUphQOVkdjA==", "+125656787", false, "Back", 2, "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Maxim" },
                    { "102ba048-ee9e-4475-86de-28de390b4fd2", 0, "8cf5a5c9-fa84-401d-834e-f0858f35a8b9", "li@gmail.com", false, true, null, "LI@GMAIL.COM", "MASHA", "AQAAAAEAACcQAAAAEMjWSehBK+fHDwz72HK3A0Dr0TELOegBmFUOoEXFKsoGMz8URcxJ+ZAED2Db2aVC8Q==", "+123656787", false, "BA", 1, "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Masha" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Belarus" },
                    { 3, "Ukraine" },
                    { 2, "Russia" }
                });

            migrationBuilder.InsertData(
                table: "InternshipStacks",
                columns: new[] { "Id", "InternshipId", "TechnologyStackType" },
                values: new object[,]
                {
                    { 3, null, 2 },
                    { 4, null, 3 },
                    { 1, null, 0 },
                    { 6, null, 5 },
                    { 2, null, 1 },
                    { 5, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Internships",
                columns: new[] { "Id", "EndDate", "ImageLink", "InternshipStatusType", "LanguageType", "MaxCandidateCount", "Name", "RegistrationFinishDate", "RegistrationStartDate", "Requirements", "StartDate" },
                values: new object[,]
                {
                    { 4, new DateTime(2021, 11, 19, 9, 50, 27, 693, DateTimeKind.Utc).AddTicks(505), "https://drive.google.com/uc?export=view&id=1t-eClTKmOY4asHZkT6y_vvJNR4SMzKbB", 0, 1, 30, "Angular/>NET", new DateTime(2021, 11, 19, 9, 50, 27, 693, DateTimeKind.Utc).AddTicks(507), new DateTime(2021, 11, 19, 9, 50, 27, 693, DateTimeKind.Utc).AddTicks(506), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 19, 9, 50, 27, 693, DateTimeKind.Utc).AddTicks(504) },
                    { 3, new DateTime(2021, 11, 19, 9, 50, 27, 693, DateTimeKind.Utc).AddTicks(500), "https://drive.google.com/uc?export=view&id=1kirFfIPPxUbgOFNGNAk4CL6jf_lEOSKc", 0, 1, 30, "GameDev", new DateTime(2021, 11, 19, 9, 50, 27, 693, DateTimeKind.Utc).AddTicks(502), new DateTime(2021, 11, 19, 9, 50, 27, 693, DateTimeKind.Utc).AddTicks(501), "OOP, Unity, C#, SQL", new DateTime(2021, 11, 19, 9, 50, 27, 693, DateTimeKind.Utc).AddTicks(499) },
                    { 2, new DateTime(2021, 11, 19, 9, 50, 27, 693, DateTimeKind.Utc).AddTicks(494), "https://drive.google.com/uc?export=view&id=1bvaKnWq0XEuldc4zry3qnrFtZoNRtW5R", 0, 0, 30, "QA Automation", new DateTime(2021, 11, 19, 9, 50, 27, 693, DateTimeKind.Utc).AddTicks(496), new DateTime(2021, 11, 19, 9, 50, 27, 693, DateTimeKind.Utc).AddTicks(495), "Any programming language, QA basics", new DateTime(2021, 11, 19, 9, 50, 27, 693, DateTimeKind.Utc).AddTicks(491) },
                    { 1, new DateTime(2021, 11, 19, 9, 50, 27, 692, DateTimeKind.Utc).AddTicks(7919), "https://drive.google.com/uc?export=view&id=1tH7hcl7K2kM4HHC6QVXRdq0LPU8yZwd9", 0, 0, 50, "JS/>NET", new DateTime(2021, 11, 19, 9, 50, 27, 692, DateTimeKind.Utc).AddTicks(9287), new DateTime(2021, 11, 19, 9, 50, 27, 692, DateTimeKind.Utc).AddTicks(8952), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 19, 9, 50, 27, 692, DateTimeKind.Utc).AddTicks(7390) }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "IsHardSkill", "Name", "StackType" },
                values: new object[,]
                {
                    { 1, true, "OOP", 1 },
                    { 2, true, "Java", 5 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "55d43182-1e39-43ec-ad5f-ca26779f1b57", "102ba048-ee9e-4475-86de-28de390b4fd2" },
                    { "c3e7b270-90be-455d-8670-d7700376d439", "e473f291-3797-4568-b22d-be1b9e563259" },
                    { "ddf1abd2-d031-4cfd-8fd4-d52a9f145364", "486beeab-f5e9-4b28-ad60-581a9922dd1f" },
                    { "0b731dd5-1fd4-492d-93a2-2255feda1760", "1b8ba634-1e07-4ccc-b2ff-f9fb55eb1235" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "InternshipId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Team 1 A" },
                    { 2, 2, "Team 1 B" }
                });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "InternshipLanguage", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 1, new DateTime(2021, 11, 19, 9, 50, 27, 695, DateTimeKind.Utc).AddTicks(652), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, null, true, "Snow", "-", "USA", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 19, 9, 50, 27, 695, DateTimeKind.Utc).AddTicks(2478), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "InternshipLanguage", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 19, 9, 50, 27, 695, DateTimeKind.Utc).AddTicks(3402), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, null, true, "Granger", "-", "UK", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 19, 9, 50, 27, 695, DateTimeKind.Utc).AddTicks(3407), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 19, 9, 50, 27, 695, DateTimeKind.Utc).AddTicks(7234), "Good knowledge of frameworks, oop, and db", 4, "102ba048-ee9e-4475-86de-28de390b4fd2" },
                    { 2, 2, new DateTime(2021, 11, 19, 9, 50, 27, 695, DateTimeKind.Utc).AddTicks(8172), "Excellent candidate", 5, "102ba048-ee9e-4475-86de-28de390b4fd2" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 19, 9, 50, 27, 697, DateTimeKind.Utc).AddTicks(126), "102ba048-ee9e-4475-86de-28de390b4fd2" },
                    { 2, 2, new DateTime(2021, 11, 19, 9, 50, 27, 697, DateTimeKind.Utc).AddTicks(617), "102ba048-ee9e-4475-86de-28de390b4fd2" }
                });

            migrationBuilder.InsertData(
                table: "Evaluations",
                columns: new[] { "Id", "FeedbackId", "SkillId", "Value" },
                values: new object[] { 1, 1, 1, 4 });

            migrationBuilder.InsertData(
                table: "Evaluations",
                columns: new[] { "Id", "FeedbackId", "SkillId", "Value" },
                values: new object[] { 2, 2, 2, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "55d43182-1e39-43ec-ad5f-ca26779f1b57", "102ba048-ee9e-4475-86de-28de390b4fd2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0b731dd5-1fd4-492d-93a2-2255feda1760", "1b8ba634-1e07-4ccc-b2ff-f9fb55eb1235" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ddf1abd2-d031-4cfd-8fd4-d52a9f145364", "486beeab-f5e9-4b28-ad60-581a9922dd1f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3e7b270-90be-455d-8670-d7700376d439", "e473f291-3797-4568-b22d-be1b9e563259" });

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Evaluations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InternshipStacks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InternshipStacks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InternshipStacks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InternshipStacks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InternshipStacks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "InternshipStacks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Internships",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Internships",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InterviewInvites",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InterviewInvites",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b731dd5-1fd4-492d-93a2-2255feda1760");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55d43182-1e39-43ec-ad5f-ca26779f1b57");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3e7b270-90be-455d-8670-d7700376d439");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddf1abd2-d031-4cfd-8fd4-d52a9f145364");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b8ba634-1e07-4ccc-b2ff-f9fb55eb1235");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "486beeab-f5e9-4b28-ad60-581a9922dd1f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e473f291-3797-4568-b22d-be1b9e563259");

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102ba048-ee9e-4475-86de-28de390b4fd2");

            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Internships",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Internships",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
