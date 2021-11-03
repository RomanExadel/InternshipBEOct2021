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
                    { "7c076e64-7368-44b4-a32e-2294279df973", "b231e667-c6d9-4e3e-8bbc-8ced8a6c760f", "Hr", "HR" },
                    { "1b60e198-fa28-417c-b842-f51802f0315b", "c0f577e6-a670-472e-84d4-fe624e7f99ea", "Interviewer", "INTERVIEWER" },
                    { "02317d2f-20b6-4892-9c18-8fac51bbd654", "40031a98-d2b1-4325-a42e-e4bf3f8ac3fb", "Manager", "MANAGER" },
                    { "637bc525-e34c-4451-b3da-a37d4b409691", "ffdc0dc2-217e-4efa-95c2-b6edb0ece3eb", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BestContactTime", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "767b7e2b-e40f-40a4-98d6-44db0d40ec86", 0, new DateTime(2021, 11, 3, 15, 46, 38, 674, DateTimeKind.Utc).AddTicks(2943), "d88da7d8-a266-433c-ab1f-918bae24264c", "li@gmail.com", false, true, null, "LI@GMAIL.COM", "MASHA", "AQAAAAEAACcQAAAAEIUJt2+lx+KZDIlUWQ6lDl58Pz3vQ2uaUlEfY+W0ZJ2y+jcxRwZDOppS7mkj2ZJHxA==", "+123656787", false, "BA", "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Masha" },
                    { "052752e0-6905-4756-a476-4752b9cc293e", 0, new DateTime(2021, 11, 3, 15, 46, 38, 697, DateTimeKind.Utc).AddTicks(7660), "bd6fc438-237a-496d-9fcf-4735a6e4296a", "max@gmail.com", false, true, null, "MAX@GMAIL.COM", "MAXIM", "AQAAAAEAACcQAAAAEMfi64Q//xK5Jheabs0P9qjC6f9NDTj4lfDs8wVimaGvjD2ulEA6pURP95B3QKGXwQ==", "+125656787", false, "Back", "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Maxim" },
                    { "be8847a7-036b-41e2-b116-03c5558d93eb", 0, new DateTime(2021, 11, 3, 15, 46, 38, 713, DateTimeKind.Utc).AddTicks(5423), "52fc9af0-69d9-4a42-b0ae-c6703c3a382c", "user@example.com", false, true, null, "USER@EXAMPLE.COM", "DASHA", "AQAAAAEAACcQAAAAEMuhIL4vvMJztKV6CrBe6dHnQNQ16yVpKvrDh0kLlylNu4Nd5qBltO89GQsrhMIYAQ==", "+325656787", false, "Front", "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Dasha" },
                    { "4c8c58c5-008f-4fab-81b4-0f217a63987a", 0, new DateTime(2021, 11, 3, 15, 46, 38, 735, DateTimeKind.Utc).AddTicks(4018), "069a9003-07b7-41ab-984e-726cae031bb3", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ALEXANDR", "AQAAAAEAACcQAAAAEKnn7F1adtBX1AdpjXSz5Qk5zrV3kZdjRMXnULD+pJaWbGWXuI3Fvugvh8e3TVfh7Q==", "+325659787", false, "PO", "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Alexandr" }
                });

            migrationBuilder.InsertData(
                table: "Internships",
                columns: new[] { "Id", "EndDate", "LanguageType", "MaxCandidateCount", "Name", "RegistrationFinishDate", "RegistrationStartDate", "Requirements", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 3, 15, 46, 38, 762, DateTimeKind.Utc).AddTicks(2953), 0, 50, "JS/>NET", new DateTime(2021, 11, 3, 15, 46, 38, 762, DateTimeKind.Utc).AddTicks(5064), new DateTime(2021, 11, 3, 15, 46, 38, 762, DateTimeKind.Utc).AddTicks(4590), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 3, 15, 46, 38, 762, DateTimeKind.Utc).AddTicks(2224) },
                    { 2, new DateTime(2021, 11, 3, 15, 46, 38, 762, DateTimeKind.Utc).AddTicks(6197), 0, 30, "QA Automation", new DateTime(2021, 11, 3, 15, 46, 38, 762, DateTimeKind.Utc).AddTicks(6202), new DateTime(2021, 11, 3, 15, 46, 38, 762, DateTimeKind.Utc).AddTicks(6200), "Any programming language, QA basics", new DateTime(2021, 11, 3, 15, 46, 38, 762, DateTimeKind.Utc).AddTicks(6194) }
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
                    { "7c076e64-7368-44b4-a32e-2294279df973", "767b7e2b-e40f-40a4-98d6-44db0d40ec86" },
                    { "1b60e198-fa28-417c-b842-f51802f0315b", "052752e0-6905-4756-a476-4752b9cc293e" },
                    { "02317d2f-20b6-4892-9c18-8fac51bbd654", "be8847a7-036b-41e2-b116-03c5558d93eb" },
                    { "637bc525-e34c-4451-b3da-a37d4b409691", "4c8c58c5-008f-4fab-81b4-0f217a63987a" }
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
                values: new object[] { 1, new DateTime(2021, 11, 3, 15, 46, 38, 765, DateTimeKind.Utc).AddTicks(9446), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, true, "Snow", "-", "Arizona", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 3, 15, 46, 38, 766, DateTimeKind.Utc).AddTicks(2574), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 3, 15, 46, 38, 766, DateTimeKind.Utc).AddTicks(4188), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, true, "Granger", "-", "London", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 3, 15, 46, 38, 766, DateTimeKind.Utc).AddTicks(4194), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 3, 15, 46, 38, 767, DateTimeKind.Utc).AddTicks(4097), "Good knowledge of frameworks, oop, and db", 4, "767b7e2b-e40f-40a4-98d6-44db0d40ec86" },
                    { 2, 2, new DateTime(2021, 11, 3, 15, 46, 38, 767, DateTimeKind.Utc).AddTicks(5705), "Excellent candidate", 5, "767b7e2b-e40f-40a4-98d6-44db0d40ec86" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 3, 15, 46, 38, 771, DateTimeKind.Utc).AddTicks(8016), "767b7e2b-e40f-40a4-98d6-44db0d40ec86" },
                    { 2, 2, new DateTime(2021, 11, 3, 15, 46, 38, 771, DateTimeKind.Utc).AddTicks(8879), "767b7e2b-e40f-40a4-98d6-44db0d40ec86" }
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
                keyValues: new object[] { "1b60e198-fa28-417c-b842-f51802f0315b", "052752e0-6905-4756-a476-4752b9cc293e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "637bc525-e34c-4451-b3da-a37d4b409691", "4c8c58c5-008f-4fab-81b4-0f217a63987a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7c076e64-7368-44b4-a32e-2294279df973", "767b7e2b-e40f-40a4-98d6-44db0d40ec86" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "02317d2f-20b6-4892-9c18-8fac51bbd654", "be8847a7-036b-41e2-b116-03c5558d93eb" });

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
                keyValue: "02317d2f-20b6-4892-9c18-8fac51bbd654");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b60e198-fa28-417c-b842-f51802f0315b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "637bc525-e34c-4451-b3da-a37d4b409691");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c076e64-7368-44b4-a32e-2294279df973");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "052752e0-6905-4756-a476-4752b9cc293e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c8c58c5-008f-4fab-81b4-0f217a63987a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be8847a7-036b-41e2-b116-03c5558d93eb");

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
                keyValue: "767b7e2b-e40f-40a4-98d6-44db0d40ec86");

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
