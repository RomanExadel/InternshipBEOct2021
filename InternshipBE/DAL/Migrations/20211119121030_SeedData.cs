using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7cf6cfad-276e-4069-a7d3-7a682d3dd199", "78aace4e-09e2-4ef5-9be0-27b2122bc5e5", "Admin", "ADMIN" },
                    { "9b2868b9-a43e-4fba-817e-458ff2ddc1e1", "18778b2f-2ae7-4700-a4da-06ee8d6c7ae8", "Interviewer", "INTERVIEWER" },
                    { "295bc158-1d31-45bb-b8fb-c9157caaf3f0", "a91b9cee-81ee-46a4-b068-6554fa6fc8f8", "Hr", "HR" },
                    { "b4fe9845-70b8-41e1-adfa-8068da5455af", "2ea2ba7e-7310-42de-8a36-7e1eea567f52", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "RoleType", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9ef8d0ff-9fda-426c-9360-eb4b904295c0", 0, "3345d7a6-60bf-45f0-b50d-18a70ad224fd", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ALEXANDR", "AQAAAAEAACcQAAAAEPOGoTPdtEynkQQ0MOvFUHXo3r5nElQzVDOYok0cOfBizual/e10fT2DHZraCSGo2Q==", "+325659787", false, "PO", 4, "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Alexandr" },
                    { "6cb997df-ff64-4681-81b8-62d9c8a2c523", 0, "a774ef5d-5733-4a26-a128-0f27a4e7be7f", "user@example.com", false, true, null, "USER@EXAMPLE.COM", "DASHA", "AQAAAAEAACcQAAAAEIZ+fkK7JWTmPb9OsUuWuOm0qFNXClffwdpjEcPzy9ldst/clJnzeMdh/qBMLWgzcA==", "+325656787", false, "Front", 3, "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Dasha" },
                    { "3d7fdfd7-6211-494b-b7ab-caa25e9df7d2", 0, "391db676-3063-474d-8a6e-604c36087c3f", "max@gmail.com", false, true, null, "MAX@GMAIL.COM", "MAXIM", "AQAAAAEAACcQAAAAEDU0TnOyap+qotXkTMahuLBkLAZ7+8tuqOwokJgk9hCWHjEGpt59mkRQVKawPEncKA==", "+125656787", false, "Back", 2, "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Maxim" },
                    { "4018ba04-dd34-4fc0-904b-65c778d78674", 0, "fb87efef-3895-40ce-a475-3e3ad71cc189", "li@gmail.com", false, true, null, "LI@GMAIL.COM", "MASHA", "AQAAAAEAACcQAAAAEDlCnXOkNW4iQtvGvJXKbfS8KXQfU/O9lQZD+Z4MLlSjCfijAzchcyX5zGfRfmU6LA==", "+123656787", false, "BA", 1, "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Masha" }
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
                    { 4, new DateTime(2021, 11, 19, 12, 10, 29, 631, DateTimeKind.Utc).AddTicks(5891), "https://drive.google.com/uc?export=view&id=1t-eClTKmOY4asHZkT6y_vvJNR4SMzKbB", 0, 1, 30, "Angular/>NET", new DateTime(2021, 11, 19, 12, 10, 29, 631, DateTimeKind.Utc).AddTicks(5894), new DateTime(2021, 11, 19, 12, 10, 29, 631, DateTimeKind.Utc).AddTicks(5892), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 19, 12, 10, 29, 631, DateTimeKind.Utc).AddTicks(5889) },
                    { 3, new DateTime(2021, 11, 19, 12, 10, 29, 631, DateTimeKind.Utc).AddTicks(5884), "https://drive.google.com/uc?export=view&id=1kirFfIPPxUbgOFNGNAk4CL6jf_lEOSKc", 0, 1, 30, "GameDev", new DateTime(2021, 11, 19, 12, 10, 29, 631, DateTimeKind.Utc).AddTicks(5887), new DateTime(2021, 11, 19, 12, 10, 29, 631, DateTimeKind.Utc).AddTicks(5886), "OOP, Unity, C#, SQL", new DateTime(2021, 11, 19, 12, 10, 29, 631, DateTimeKind.Utc).AddTicks(5883) },
                    { 2, new DateTime(2021, 11, 19, 12, 10, 29, 631, DateTimeKind.Utc).AddTicks(5877), "https://drive.google.com/uc?export=view&id=1bvaKnWq0XEuldc4zry3qnrFtZoNRtW5R", 0, 0, 30, "QA Automation", new DateTime(2021, 11, 19, 12, 10, 29, 631, DateTimeKind.Utc).AddTicks(5880), new DateTime(2021, 11, 19, 12, 10, 29, 631, DateTimeKind.Utc).AddTicks(5879), "Any programming language, QA basics", new DateTime(2021, 11, 19, 12, 10, 29, 631, DateTimeKind.Utc).AddTicks(5872) },
                    { 1, new DateTime(2021, 11, 19, 12, 10, 29, 631, DateTimeKind.Utc).AddTicks(1549), "https://drive.google.com/uc?export=view&id=1tH7hcl7K2kM4HHC6QVXRdq0LPU8yZwd9", 0, 0, 50, "JS/>NET", new DateTime(2021, 11, 19, 12, 10, 29, 631, DateTimeKind.Utc).AddTicks(3740), new DateTime(2021, 11, 19, 12, 10, 29, 631, DateTimeKind.Utc).AddTicks(3177), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 19, 12, 10, 29, 631, DateTimeKind.Utc).AddTicks(946) }
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
                    { "295bc158-1d31-45bb-b8fb-c9157caaf3f0", "4018ba04-dd34-4fc0-904b-65c778d78674" },
                    { "9b2868b9-a43e-4fba-817e-458ff2ddc1e1", "3d7fdfd7-6211-494b-b7ab-caa25e9df7d2" },
                    { "b4fe9845-70b8-41e1-adfa-8068da5455af", "6cb997df-ff64-4681-81b8-62d9c8a2c523" },
                    { "7cf6cfad-276e-4069-a7d3-7a682d3dd199", "9ef8d0ff-9fda-426c-9360-eb4b904295c0" }
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
                values: new object[] { 1, new DateTime(2021, 11, 19, 12, 10, 29, 634, DateTimeKind.Utc).AddTicks(3898), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, null, true, "Snow", "-", "USA", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 19, 12, 10, 29, 634, DateTimeKind.Utc).AddTicks(9939), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "InternshipLanguage", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 19, 12, 10, 29, 635, DateTimeKind.Utc).AddTicks(1863), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, null, true, "Granger", "-", "UK", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 19, 12, 10, 29, 635, DateTimeKind.Utc).AddTicks(1870), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "FinalEvaluation", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 19, 12, 10, 29, 636, DateTimeKind.Utc).AddTicks(313), "Good knowledge of frameworks, oop, and db", 4, 1, "4018ba04-dd34-4fc0-904b-65c778d78674" },
                    { 2, 2, new DateTime(2021, 11, 19, 12, 10, 29, 636, DateTimeKind.Utc).AddTicks(1975), "Excellent candidate", 5, 2, "4018ba04-dd34-4fc0-904b-65c778d78674" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 19, 12, 10, 29, 637, DateTimeKind.Utc).AddTicks(8452), "4018ba04-dd34-4fc0-904b-65c778d78674" },
                    { 2, 2, new DateTime(2021, 11, 19, 12, 10, 29, 637, DateTimeKind.Utc).AddTicks(9023), "4018ba04-dd34-4fc0-904b-65c778d78674" }
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
                keyValues: new object[] { "9b2868b9-a43e-4fba-817e-458ff2ddc1e1", "3d7fdfd7-6211-494b-b7ab-caa25e9df7d2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "295bc158-1d31-45bb-b8fb-c9157caaf3f0", "4018ba04-dd34-4fc0-904b-65c778d78674" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b4fe9845-70b8-41e1-adfa-8068da5455af", "6cb997df-ff64-4681-81b8-62d9c8a2c523" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7cf6cfad-276e-4069-a7d3-7a682d3dd199", "9ef8d0ff-9fda-426c-9360-eb4b904295c0" });

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
                keyValue: "295bc158-1d31-45bb-b8fb-c9157caaf3f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7cf6cfad-276e-4069-a7d3-7a682d3dd199");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b2868b9-a43e-4fba-817e-458ff2ddc1e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4fe9845-70b8-41e1-adfa-8068da5455af");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d7fdfd7-6211-494b-b7ab-caa25e9df7d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6cb997df-ff64-4681-81b8-62d9c8a2c523");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ef8d0ff-9fda-426c-9360-eb4b904295c0");

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
                keyValue: "4018ba04-dd34-4fc0-904b-65c778d78674");

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
