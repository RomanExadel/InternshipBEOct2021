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
                    { "61dcd784-520d-4f08-b445-65dcfea91c30", "f1a360ce-eb14-4efa-a376-8d3965ce9f0e", "Admin", "ADMIN" },
                    { "e8801c92-a184-4a84-81f4-a3cfc83dba48", "a4cda7d2-6ab2-439a-8d9b-9d3db1505567", "Interviewer", "INTERVIEWER" },
                    { "a817d8fe-4e9d-444d-befa-d8eeed4f80f9", "da9c59ce-3085-4e8e-a5be-6d98222bcceb", "Hr", "HR" },
                    { "d77d5cab-e506-427f-a632-e32f9d53a181", "b6af4ab5-d46f-4eaf-b3fd-1f23d76c8b96", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BestContactTime", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "RoleType", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "182285b4-6a60-4eba-b51c-cfb2969397d2", 0, new DateTime(2021, 11, 6, 12, 16, 36, 636, DateTimeKind.Utc).AddTicks(6106), "257376c3-a6ba-4bc2-8b2d-3dc5b3172847", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ALEXANDR", "AQAAAAEAACcQAAAAEC41SMDWNehq8VRmqKdTSfOqlM2Qe9v4F54U06NjVZnBAO/ktyT02kbhHPOzfngUIA==", "+325659787", false, "PO", 4, "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Alexandr" },
                    { "93061e0e-71ff-41d4-bf98-2f565a1fca3d", 0, new DateTime(2021, 11, 6, 12, 16, 36, 628, DateTimeKind.Utc).AddTicks(4765), "654a14f2-5657-4d19-b1b2-2f854dafb8a6", "user@example.com", false, true, null, "USER@EXAMPLE.COM", "DASHA", "AQAAAAEAACcQAAAAEPiddTb5n/KRtV7cZiLQZNE+f5QuvFaECGciyiLhN3n7hA+8BhYZ3bqMNokgrVzmgA==", "+325656787", false, "Front", 3, "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Dasha" },
                    { "20cc0905-ae9f-4c09-8d66-566e1d05d8d5", 0, new DateTime(2021, 11, 6, 12, 16, 36, 620, DateTimeKind.Utc).AddTicks(3499), "71d2b3ca-e023-424e-bad6-944914a28038", "max@gmail.com", false, true, null, "MAX@GMAIL.COM", "MAXIM", "AQAAAAEAACcQAAAAEFvi59DRQ3nSPtDn/V0l2dxl5wgVUS09SRzcn6XPyQMwJzKjbszuVCvn6G7lALtF1Q==", "+125656787", false, "Back", 2, "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Maxim" },
                    { "51757e92-16d9-40af-b61d-d6df44cb339a", 0, new DateTime(2021, 11, 6, 12, 16, 36, 604, DateTimeKind.Utc).AddTicks(105), "ec686eab-6c09-4c7a-bdb2-7c75383c2731", "li@gmail.com", false, true, null, "LI@GMAIL.COM", "MASHA", "AQAAAAEAACcQAAAAEDejnBJIKHHR8XA1jAFZtkGPG/aYZtr47LT7I97mez7Nl1H9iONUN6XpX2LaDapdzw==", "+123656787", false, "BA", 1, "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Masha" }
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
                table: "Internships",
                columns: new[] { "Id", "EndDate", "ImageLink", "InternshipStatusType", "LanguageType", "MaxCandidateCount", "Name", "RegistrationFinishDate", "RegistrationStartDate", "Requirements", "StartDate" },
                values: new object[,]
                {
                    { 4, new DateTime(2021, 11, 6, 12, 16, 36, 646, DateTimeKind.Utc).AddTicks(3284), "image/link/2", 0, 1, 30, "Angular/>NET", new DateTime(2021, 11, 6, 12, 16, 36, 646, DateTimeKind.Utc).AddTicks(3284), new DateTime(2021, 11, 6, 12, 16, 36, 646, DateTimeKind.Utc).AddTicks(3284), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 6, 12, 16, 36, 646, DateTimeKind.Utc).AddTicks(3281) },
                    { 3, new DateTime(2021, 11, 6, 12, 16, 36, 646, DateTimeKind.Utc).AddTicks(3281), "image/link/2", 0, 1, 30, "GameDev", new DateTime(2021, 11, 6, 12, 16, 36, 646, DateTimeKind.Utc).AddTicks(3281), new DateTime(2021, 11, 6, 12, 16, 36, 646, DateTimeKind.Utc).AddTicks(3281), "OOP, Unity, C#, SQL", new DateTime(2021, 11, 6, 12, 16, 36, 646, DateTimeKind.Utc).AddTicks(3278) },
                    { 2, new DateTime(2021, 11, 6, 12, 16, 36, 646, DateTimeKind.Utc).AddTicks(3275), "image/link/2", 0, 0, 30, "QA Automation", new DateTime(2021, 11, 6, 12, 16, 36, 646, DateTimeKind.Utc).AddTicks(3278), new DateTime(2021, 11, 6, 12, 16, 36, 646, DateTimeKind.Utc).AddTicks(3278), "Any programming language, QA basics", new DateTime(2021, 11, 6, 12, 16, 36, 646, DateTimeKind.Utc).AddTicks(3275) },
                    { 1, new DateTime(2021, 11, 6, 12, 16, 36, 646, DateTimeKind.Utc).AddTicks(150), "image/link/1", 0, 0, 50, "JS/>NET", new DateTime(2021, 11, 6, 12, 16, 36, 646, DateTimeKind.Utc).AddTicks(1809), new DateTime(2021, 11, 6, 12, 16, 36, 646, DateTimeKind.Utc).AddTicks(1415), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 6, 12, 16, 36, 645, DateTimeKind.Utc).AddTicks(9581) }
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
                    { "a817d8fe-4e9d-444d-befa-d8eeed4f80f9", "51757e92-16d9-40af-b61d-d6df44cb339a" },
                    { "e8801c92-a184-4a84-81f4-a3cfc83dba48", "20cc0905-ae9f-4c09-8d66-566e1d05d8d5" },
                    { "d77d5cab-e506-427f-a632-e32f9d53a181", "93061e0e-71ff-41d4-bf98-2f565a1fca3d" },
                    { "61dcd784-520d-4f08-b445-65dcfea91c30", "182285b4-6a60-4eba-b51c-cfb2969397d2" }
                });

            migrationBuilder.InsertData(
                table: "InternshipStacks",
                columns: new[] { "Id", "InternshipId", "TechnologyStackType" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 5 }
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
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 1, new DateTime(2021, 11, 6, 12, 16, 36, 648, DateTimeKind.Utc).AddTicks(4658), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, true, "Snow", "-", "Arizona", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 6, 12, 16, 36, 648, DateTimeKind.Utc).AddTicks(6798), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 6, 12, 16, 36, 648, DateTimeKind.Utc).AddTicks(7985), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, true, "Granger", "-", "London", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 6, 12, 16, 36, 648, DateTimeKind.Utc).AddTicks(7988), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 6, 12, 16, 36, 649, DateTimeKind.Utc).AddTicks(2992), "Good knowledge of frameworks, oop, and db", 4, "51757e92-16d9-40af-b61d-d6df44cb339a" },
                    { 2, 2, new DateTime(2021, 11, 6, 12, 16, 36, 649, DateTimeKind.Utc).AddTicks(4132), "Excellent candidate", 5, "51757e92-16d9-40af-b61d-d6df44cb339a" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 6, 12, 16, 36, 650, DateTimeKind.Utc).AddTicks(6885), "51757e92-16d9-40af-b61d-d6df44cb339a" },
                    { 2, 2, new DateTime(2021, 11, 6, 12, 16, 36, 650, DateTimeKind.Utc).AddTicks(7288), "51757e92-16d9-40af-b61d-d6df44cb339a" }
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
                keyValues: new object[] { "61dcd784-520d-4f08-b445-65dcfea91c30", "182285b4-6a60-4eba-b51c-cfb2969397d2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e8801c92-a184-4a84-81f4-a3cfc83dba48", "20cc0905-ae9f-4c09-8d66-566e1d05d8d5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a817d8fe-4e9d-444d-befa-d8eeed4f80f9", "51757e92-16d9-40af-b61d-d6df44cb339a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d77d5cab-e506-427f-a632-e32f9d53a181", "93061e0e-71ff-41d4-bf98-2f565a1fca3d" });

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
                keyValue: "61dcd784-520d-4f08-b445-65dcfea91c30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a817d8fe-4e9d-444d-befa-d8eeed4f80f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d77d5cab-e506-427f-a632-e32f9d53a181");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8801c92-a184-4a84-81f4-a3cfc83dba48");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "182285b4-6a60-4eba-b51c-cfb2969397d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20cc0905-ae9f-4c09-8d66-566e1d05d8d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93061e0e-71ff-41d4-bf98-2f565a1fca3d");

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
                keyValue: "51757e92-16d9-40af-b61d-d6df44cb339a");

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
