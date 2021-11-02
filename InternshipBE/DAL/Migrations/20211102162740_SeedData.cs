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
                    { "33b99e1b-aedd-4b41-952e-08e5c095accd", "89170099-db73-417c-abae-a1c27d2a1ffb", "Hr", "HR" },
                    { "0461feba-77e1-448b-8700-1d3930ab9023", "94c81584-b0cc-47e2-a04d-1be50b5fb10a", "Interviewer", "INTERVIEWER" },
                    { "1ecb5fb7-3e02-4cbd-a113-8fac0242e4f5", "f98a5990-e6d5-4f18-bfcc-e84521778f8e", "Manager", "MANAGER" },
                    { "eaa8cfc6-7797-4562-bcbf-d0d62f80f519", "eda58c22-1400-4f0a-b844-9e5e73bbdf83", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BestContactTime", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0026e1ac-2952-4397-97fd-b649e6aaef3f", 0, new DateTime(2021, 11, 2, 16, 27, 39, 315, DateTimeKind.Utc).AddTicks(345), "ced339a8-fcb3-47a5-8215-93c71305372f", "li@gmail.com", false, true, null, "LI@GMAIL.COM", "MASHA", "AQAAAAEAACcQAAAAECPQnjAJaU33jEzwaoDrZkvnahjBouBeWjdJEqRhgXLOkxo38K7faXhXA6S29Ap/Aw==", "+123656787", false, "BA", "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Masha" },
                    { "f22177ba-9857-469c-862c-c2e3c280c6e0", 0, new DateTime(2021, 11, 2, 16, 27, 39, 319, DateTimeKind.Utc).AddTicks(8854), "713ff061-d0d0-4d17-83cf-5d4255c4add3", "max@gmail.com", false, true, null, "MAX@GMAIL.COM", "MAXIM", "AQAAAAEAACcQAAAAEEkmnbGqrEpBGDK6q4gijAuqa9oaQpmioY6SgjGEEF6I4EKISu1GFseTRYBcF0groQ==", "+125656787", false, "Back", "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Maxim" },
                    { "47e7131f-074e-4d74-9df8-a6ee691f9e26", 0, new DateTime(2021, 11, 2, 16, 27, 39, 321, DateTimeKind.Utc).AddTicks(2970), "90250f18-d9b6-4115-8ac0-8b7e3915b811", "user@example.com", false, true, null, "USER@EXAMPLE.COM", "DASHA", "AQAAAAEAACcQAAAAEGb09L4LSYJcTaQxhkQJd6v0nV7OX8FvOxowLqm5heqTSEEp/FV+zzvWJQvt92p8zQ==", "+325656787", false, "Front", "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Dasha" },
                    { "c38aa7d9-03b2-4df8-bce0-741b0ddd2f04", 0, new DateTime(2021, 11, 2, 16, 27, 39, 322, DateTimeKind.Utc).AddTicks(6117), "77c4bb42-1a1a-4cae-b519-5205b957e707", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ALEXANDR", "AQAAAAEAACcQAAAAEKpWCdovEVi8eyu99coFtqyFBVXVLgx4Eyvd4g8KuSvLSLEyk8SyEirPV6kYrupDtg==", "+325659787", false, "PO", "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Alexandr" }
                });

            migrationBuilder.InsertData(
                table: "Internships",
                columns: new[] { "Id", "EndDate", "LanguageType", "MaxCandidateCount", "Name", "RegistrationFinishDate", "RegistrationStartDate", "Requirements", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 2, 16, 27, 39, 325, DateTimeKind.Utc).AddTicks(7753), 0, 50, "JS/>NET", new DateTime(2021, 11, 2, 16, 27, 39, 326, DateTimeKind.Utc).AddTicks(495), new DateTime(2021, 11, 2, 16, 27, 39, 325, DateTimeKind.Utc).AddTicks(9791), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 2, 16, 27, 39, 325, DateTimeKind.Utc).AddTicks(6988) },
                    { 2, new DateTime(2021, 11, 2, 16, 27, 39, 326, DateTimeKind.Utc).AddTicks(1787), 0, 30, "QA Automation", new DateTime(2021, 11, 2, 16, 27, 39, 326, DateTimeKind.Utc).AddTicks(1791), new DateTime(2021, 11, 2, 16, 27, 39, 326, DateTimeKind.Utc).AddTicks(1789), "Any programming language, QA basics", new DateTime(2021, 11, 2, 16, 27, 39, 326, DateTimeKind.Utc).AddTicks(1783) }
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
                    { "33b99e1b-aedd-4b41-952e-08e5c095accd", "0026e1ac-2952-4397-97fd-b649e6aaef3f" },
                    { "0461feba-77e1-448b-8700-1d3930ab9023", "f22177ba-9857-469c-862c-c2e3c280c6e0" },
                    { "1ecb5fb7-3e02-4cbd-a113-8fac0242e4f5", "47e7131f-074e-4d74-9df8-a6ee691f9e26" },
                    { "eaa8cfc6-7797-4562-bcbf-d0d62f80f519", "c38aa7d9-03b2-4df8-bce0-741b0ddd2f04" }
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
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 1, new DateTime(2021, 11, 2, 16, 27, 39, 328, DateTimeKind.Utc).AddTicks(9914), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, true, "Snow", "-", "Arizona", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 2, 16, 27, 39, 329, DateTimeKind.Utc).AddTicks(3668), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 2, 16, 27, 39, 329, DateTimeKind.Utc).AddTicks(5810), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, true, "Granger", "-", "London", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 2, 16, 27, 39, 329, DateTimeKind.Utc).AddTicks(5820), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 2, 16, 27, 39, 332, DateTimeKind.Utc).AddTicks(5777), "Good knowledge of frameworks, oop, and db", 4, "0026e1ac-2952-4397-97fd-b649e6aaef3f" },
                    { 2, 2, new DateTime(2021, 11, 2, 16, 27, 39, 332, DateTimeKind.Utc).AddTicks(8014), "Excellent candidate", 5, "0026e1ac-2952-4397-97fd-b649e6aaef3f" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 2, 16, 27, 39, 336, DateTimeKind.Utc).AddTicks(9761), "0026e1ac-2952-4397-97fd-b649e6aaef3f" },
                    { 2, 2, new DateTime(2021, 11, 2, 16, 27, 39, 337, DateTimeKind.Utc).AddTicks(729), "0026e1ac-2952-4397-97fd-b649e6aaef3f" }
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
                keyValues: new object[] { "33b99e1b-aedd-4b41-952e-08e5c095accd", "0026e1ac-2952-4397-97fd-b649e6aaef3f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1ecb5fb7-3e02-4cbd-a113-8fac0242e4f5", "47e7131f-074e-4d74-9df8-a6ee691f9e26" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "eaa8cfc6-7797-4562-bcbf-d0d62f80f519", "c38aa7d9-03b2-4df8-bce0-741b0ddd2f04" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0461feba-77e1-448b-8700-1d3930ab9023", "f22177ba-9857-469c-862c-c2e3c280c6e0" });

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
                keyValue: "0461feba-77e1-448b-8700-1d3930ab9023");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ecb5fb7-3e02-4cbd-a113-8fac0242e4f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33b99e1b-aedd-4b41-952e-08e5c095accd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eaa8cfc6-7797-4562-bcbf-d0d62f80f519");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47e7131f-074e-4d74-9df8-a6ee691f9e26");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c38aa7d9-03b2-4df8-bce0-741b0ddd2f04");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f22177ba-9857-469c-862c-c2e3c280c6e0");

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
                keyValue: "0026e1ac-2952-4397-97fd-b649e6aaef3f");

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
