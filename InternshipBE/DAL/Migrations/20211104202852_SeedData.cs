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
                    { "7a15d9f5-f5a8-4b4b-9d54-dc04e1b0f951", "604b4f71-f0e4-46bb-92cc-fd852d79b7be", "Admin", "ADMIN" },
                    { "c7ae0ade-9487-4917-9b37-4545d537214d", "18c3a03f-f92c-4d09-994c-74f17a216a78", "Interviewer", "INTERVIEWER" },
                    { "d14a97d3-229a-4bee-97df-a763cf628f82", "070b4c11-24c2-44e7-a6cb-33f2e47edeb7", "Hr", "HR" },
                    { "1c2c6dfc-d04e-426a-a6f0-2bc47e9ca785", "e9f9a72e-56b3-4741-a3a4-05a243b1f045", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BestContactTime", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "15f6fb79-753e-4a49-97b9-b0f3fe538011", 0, new DateTime(2021, 11, 4, 20, 28, 50, 651, DateTimeKind.Utc).AddTicks(8630), "5073637e-ec53-4a93-98bd-1aa8ba5045fc", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ALEXANDR", "AQAAAAEAACcQAAAAEESPbgJHkDhGn9tMSVXvqH89PF4b4gvSUG6tiwYBHuUytR9ZBKefJIk+61Le0x5nfg==", "+325659787", false, "PO", "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Alexandr" },
                    { "9dc43feb-3c52-427b-9aba-63de17788863", 0, new DateTime(2021, 11, 4, 20, 28, 50, 625, DateTimeKind.Utc).AddTicks(3914), "dd7b66b8-a60d-4f95-b80f-21577d6d168f", "user@example.com", false, true, null, "USER@EXAMPLE.COM", "DASHA", "AQAAAAEAACcQAAAAEFniPUoRDm6efE4Iq6D707QTUQA1B7qkzDacSoZPKpeO4P+qMb6ZATALQQYgsciWDA==", "+325656787", false, "Front", "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Dasha" },
                    { "9847bb2a-6bcf-4a00-8092-8fb90616947c", 0, new DateTime(2021, 11, 4, 20, 28, 50, 612, DateTimeKind.Utc).AddTicks(4115), "c2e7d80b-421c-464c-b513-5690b07fa33f", "max@gmail.com", false, true, null, "MAX@GMAIL.COM", "MAXIM", "AQAAAAEAACcQAAAAEFNsBN9JDbHAFgC2Tm/eGiTkKUPu9VI9bS97CFNP/Zwd0ZvdSHy5RL+cVDFNOR3K6w==", "+125656787", false, "Back", "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Maxim" },
                    { "d10125fe-36f8-4a7a-8699-800303ca6e3d", 0, new DateTime(2021, 11, 4, 20, 28, 50, 590, DateTimeKind.Utc).AddTicks(6195), "f0b345a1-09ea-4f7a-9e12-be1ea0e00f79", "li@gmail.com", false, true, null, "LI@GMAIL.COM", "MASHA", "AQAAAAEAACcQAAAAELvvi2t/jsCtGIsAI2Fq2YriHPxIrQ7lAKelhV3PSUbbd7fNLv9rPJYrfWzKIx6jrQ==", "+123656787", false, "BA", "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Masha" }
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
                    { 4, new DateTime(2021, 11, 4, 20, 28, 50, 669, DateTimeKind.Utc).AddTicks(3557), "image/link/2", 0, 1, 30, "Angular/>NET", new DateTime(2021, 11, 4, 20, 28, 50, 669, DateTimeKind.Utc).AddTicks(3559), new DateTime(2021, 11, 4, 20, 28, 50, 669, DateTimeKind.Utc).AddTicks(3558), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 4, 20, 28, 50, 669, DateTimeKind.Utc).AddTicks(3556) },
                    { 3, new DateTime(2021, 11, 4, 20, 28, 50, 669, DateTimeKind.Utc).AddTicks(3551), "image/link/2", 0, 1, 30, "GameDev", new DateTime(2021, 11, 4, 20, 28, 50, 669, DateTimeKind.Utc).AddTicks(3554), new DateTime(2021, 11, 4, 20, 28, 50, 669, DateTimeKind.Utc).AddTicks(3553), "OOP, Unity, C#, SQL", new DateTime(2021, 11, 4, 20, 28, 50, 669, DateTimeKind.Utc).AddTicks(3550) },
                    { 2, new DateTime(2021, 11, 4, 20, 28, 50, 669, DateTimeKind.Utc).AddTicks(3544), "image/link/2", 0, 0, 30, "QA Automation", new DateTime(2021, 11, 4, 20, 28, 50, 669, DateTimeKind.Utc).AddTicks(3548), new DateTime(2021, 11, 4, 20, 28, 50, 669, DateTimeKind.Utc).AddTicks(3547), "Any programming language, QA basics", new DateTime(2021, 11, 4, 20, 28, 50, 669, DateTimeKind.Utc).AddTicks(3542) },
                    { 1, new DateTime(2021, 11, 4, 20, 28, 50, 669, DateTimeKind.Utc).AddTicks(758), "image/link/1", 0, 0, 50, "JS/>NET", new DateTime(2021, 11, 4, 20, 28, 50, 669, DateTimeKind.Utc).AddTicks(2201), new DateTime(2021, 11, 4, 20, 28, 50, 669, DateTimeKind.Utc).AddTicks(1835), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 4, 20, 28, 50, 669, DateTimeKind.Utc).AddTicks(307) }
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
                    { "d14a97d3-229a-4bee-97df-a763cf628f82", "d10125fe-36f8-4a7a-8699-800303ca6e3d" },
                    { "c7ae0ade-9487-4917-9b37-4545d537214d", "9847bb2a-6bcf-4a00-8092-8fb90616947c" },
                    { "1c2c6dfc-d04e-426a-a6f0-2bc47e9ca785", "9dc43feb-3c52-427b-9aba-63de17788863" },
                    { "7a15d9f5-f5a8-4b4b-9d54-dc04e1b0f951", "15f6fb79-753e-4a49-97b9-b0f3fe538011" }
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
                values: new object[] { 1, new DateTime(2021, 11, 4, 20, 28, 50, 671, DateTimeKind.Utc).AddTicks(6952), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, true, "Snow", "-", "Arizona", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 4, 20, 28, 50, 671, DateTimeKind.Utc).AddTicks(9947), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 4, 20, 28, 50, 672, DateTimeKind.Utc).AddTicks(2303), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, true, "Granger", "-", "London", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 4, 20, 28, 50, 672, DateTimeKind.Utc).AddTicks(2311), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 4, 20, 28, 50, 673, DateTimeKind.Utc).AddTicks(5742), "Good knowledge of frameworks, oop, and db", 4, "d10125fe-36f8-4a7a-8699-800303ca6e3d" },
                    { 2, 2, new DateTime(2021, 11, 4, 20, 28, 50, 673, DateTimeKind.Utc).AddTicks(7420), "Excellent candidate", 5, "d10125fe-36f8-4a7a-8699-800303ca6e3d" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 4, 20, 28, 50, 675, DateTimeKind.Utc).AddTicks(8083), "d10125fe-36f8-4a7a-8699-800303ca6e3d" },
                    { 2, 2, new DateTime(2021, 11, 4, 20, 28, 50, 675, DateTimeKind.Utc).AddTicks(8500), "d10125fe-36f8-4a7a-8699-800303ca6e3d" }
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
                keyValues: new object[] { "7a15d9f5-f5a8-4b4b-9d54-dc04e1b0f951", "15f6fb79-753e-4a49-97b9-b0f3fe538011" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c7ae0ade-9487-4917-9b37-4545d537214d", "9847bb2a-6bcf-4a00-8092-8fb90616947c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1c2c6dfc-d04e-426a-a6f0-2bc47e9ca785", "9dc43feb-3c52-427b-9aba-63de17788863" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d14a97d3-229a-4bee-97df-a763cf628f82", "d10125fe-36f8-4a7a-8699-800303ca6e3d" });

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
                keyValue: "1c2c6dfc-d04e-426a-a6f0-2bc47e9ca785");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a15d9f5-f5a8-4b4b-9d54-dc04e1b0f951");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7ae0ade-9487-4917-9b37-4545d537214d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d14a97d3-229a-4bee-97df-a763cf628f82");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15f6fb79-753e-4a49-97b9-b0f3fe538011");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9847bb2a-6bcf-4a00-8092-8fb90616947c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9dc43feb-3c52-427b-9aba-63de17788863");

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
                keyValue: "d10125fe-36f8-4a7a-8699-800303ca6e3d");

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
