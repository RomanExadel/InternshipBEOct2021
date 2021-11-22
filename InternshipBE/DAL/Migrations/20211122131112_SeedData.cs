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
                    { "74e904f5-7806-4e48-8d16-8d3ebb1316b3", "0c60b3b3-ddc5-4bbe-a498-52efe6b9d3d0", "Mentor", "MENTOR" },
                    { "e832e6ab-dc33-4695-89f6-c164366b30d2", "85b0d482-678e-4bd6-8905-8331f49314a0", "Manager", "MANAGER" },
                    { "17110c59-3469-4327-a366-337633b1d530", "df68f62e-1018-465a-a1af-3dcba39331f2", "Interviewer", "INTERVIEWER" },
                    { "9738af26-70ec-4aad-a0c9-f82b33ecb92d", "b835a4b7-19b3-40de-9703-1a42f1e0868f", "Hr", "HR" },
                    { "a380e0b4-0b1a-4b19-962e-06d8b2023ece", "e392e33a-1841-4cc5-acd9-788293af74b6", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "RoleType", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "17eea19a-b6bd-4197-a717-3516d75b5e7f", 0, "4639bffc-54df-4404-a2f2-6d313f9171a9", "mentortest.team5@gmail.com", false, true, null, "MENTORTEST.TEAM5@GMAIL.COM", "BORIS BOBROV", "AQAAAAEAACcQAAAAEHV4nyy5rdbBjQeJk/i7H67MvGn+JRMutu2jdzdiZpaj+6bWICRSwcqIhYugy5hVbQ==", "+7777777777777777", false, "PO", 0, "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Boris Bobrov" },
                    { "ff603c3f-f514-430f-ab18-7227a55fde1e", 0, "ebc8e2ba-c944-42cb-805e-a8888865c438", "managertest.team5@gmail.com", false, true, null, "MANAGERTEST.TEAM5@GMAIL.COM", "ANN GREEN", "AQAAAAEAACcQAAAAEFCtFvdAzyT2kMAEfsTLqoyyMw+lrhZIxQxrAl3k+UNrD6RY0dM/wNajGjrmh6LWew==", "+325659787", false, "PO", 3, "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Ann Green" },
                    { "2e8015af-b014-4152-8678-3ffef70afb48", 0, "48d8d0f4-471e-4446-a878-444808a48436", "interviewer.team5@gmail.com", false, true, null, "INTERVIEWER.TEAM5@GMAIL.COM", "IVAN SIDOROV", "AQAAAAEAACcQAAAAEHeT4YYL+G3YKdCa4r4zVuXkJHDd98ynfJlrrsBfk42BLhvq4lrmtzhzkV2mk/zCOA==", "+325656787", false, "Front", 2, "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Ivan Sidorov" },
                    { "47494c24-6f37-4b8e-9a8a-521ca8bb14ea", 0, "2de37566-f271-476a-9393-1366ac257dce", "hrlily.team5@gmail.com", false, true, null, "HRLILY.TEAM5@GMAIL.COM", "LILY IVANOVA", "AQAAAAEAACcQAAAAEI0QROl7CqMXqqjXAZPMHfsa1jRf+UTp9TBE1/JHiMRqotLaOs4xpKCRAn4q7Ue8aA==", "+125656787", false, "Back", 1, "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Lily Ivanova" },
                    { "6b2d2cc9-d5dc-45be-bc01-05711cf8caec", 0, "4c89013f-9e9c-4500-9919-899c2cb6659a", "admntest.team5@gmail.com", false, true, null, "ADMNTEST.TEAM5@GMAIL.COM", "PETER PETROV", "AQAAAAEAACcQAAAAEPpMtIVd7UxdqUBntcJ3+DlH7Pa6jKS/4TF5wBdYf3FsldZloFSKH5Wd2W/RvBRYNQ==", "+123656787", false, "BA", 4, "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Peter Petrov" }
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
                    { 5, null, 4 },
                    { 3, null, 2 },
                    { 2, null, 1 },
                    { 1, null, 0 },
                    { 4, null, 3 },
                    { 6, null, 5 }
                });

            migrationBuilder.InsertData(
                table: "Internships",
                columns: new[] { "Id", "EndDate", "ImageLink", "InternshipStatusType", "LanguageType", "MaxCandidateCount", "Name", "RegistrationFinishDate", "RegistrationStartDate", "Requirements", "SpreadSheetId", "StartDate" },
                values: new object[,]
                {
                    { 4, new DateTime(2021, 11, 22, 13, 11, 9, 993, DateTimeKind.Utc).AddTicks(4144), "https://drive.google.com/uc?export=view&id=1t-eClTKmOY4asHZkT6y_vvJNR4SMzKbB", 0, 1, 30, "Angular/>NET", new DateTime(2021, 11, 22, 13, 11, 9, 993, DateTimeKind.Utc).AddTicks(4148), new DateTime(2021, 11, 22, 13, 11, 9, 993, DateTimeKind.Utc).AddTicks(4146), "OOP, JS, C#, .Net, Angular/React", null, new DateTime(2021, 11, 22, 13, 11, 9, 993, DateTimeKind.Utc).AddTicks(4142) },
                    { 3, new DateTime(2021, 11, 22, 13, 11, 9, 993, DateTimeKind.Utc).AddTicks(4136), "https://drive.google.com/uc?export=view&id=1kirFfIPPxUbgOFNGNAk4CL6jf_lEOSKc", 0, 1, 30, "GameDev", new DateTime(2021, 11, 22, 13, 11, 9, 993, DateTimeKind.Utc).AddTicks(4140), new DateTime(2021, 11, 22, 13, 11, 9, 993, DateTimeKind.Utc).AddTicks(4139), "OOP, Unity, C#, SQL", null, new DateTime(2021, 11, 22, 13, 11, 9, 993, DateTimeKind.Utc).AddTicks(4134) },
                    { 2, new DateTime(2021, 11, 22, 13, 11, 9, 993, DateTimeKind.Utc).AddTicks(4126), "https://drive.google.com/uc?export=view&id=1bvaKnWq0XEuldc4zry3qnrFtZoNRtW5R", 0, 0, 30, "QA Automation", new DateTime(2021, 11, 22, 13, 11, 9, 993, DateTimeKind.Utc).AddTicks(4130), new DateTime(2021, 11, 22, 13, 11, 9, 993, DateTimeKind.Utc).AddTicks(4128), "Any programming language, QA basics", null, new DateTime(2021, 11, 22, 13, 11, 9, 993, DateTimeKind.Utc).AddTicks(4120) },
                    { 1, new DateTime(2021, 11, 22, 13, 11, 9, 992, DateTimeKind.Utc).AddTicks(4505), "https://drive.google.com/uc?export=view&id=1tH7hcl7K2kM4HHC6QVXRdq0LPU8yZwd9", 0, 0, 50, "JS/>NET", new DateTime(2021, 11, 22, 13, 11, 9, 993, DateTimeKind.Utc).AddTicks(1543), new DateTime(2021, 11, 22, 13, 11, 9, 993, DateTimeKind.Utc).AddTicks(369), "OOP, JS, C#, .Net, Angular/React", null, new DateTime(2021, 11, 22, 13, 11, 9, 992, DateTimeKind.Utc).AddTicks(2308) }
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
                    { "9738af26-70ec-4aad-a0c9-f82b33ecb92d", "6b2d2cc9-d5dc-45be-bc01-05711cf8caec" },
                    { "17110c59-3469-4327-a366-337633b1d530", "47494c24-6f37-4b8e-9a8a-521ca8bb14ea" },
                    { "e832e6ab-dc33-4695-89f6-c164366b30d2", "2e8015af-b014-4152-8678-3ffef70afb48" },
                    { "a380e0b4-0b1a-4b19-962e-06d8b2023ece", "ff603c3f-f514-430f-ab18-7227a55fde1e" },
                    { "74e904f5-7806-4e48-8d16-8d3ebb1316b3", "17eea19a-b6bd-4197-a717-3516d75b5e7f" }
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
                values: new object[] { 1, new DateTime(2021, 11, 22, 13, 11, 10, 11, DateTimeKind.Utc).AddTicks(713), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, null, true, "Snow", "-", "USA", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 22, 13, 11, 10, 11, DateTimeKind.Utc).AddTicks(5015), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "InternshipLanguage", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 22, 13, 11, 10, 11, DateTimeKind.Utc).AddTicks(7143), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, null, true, "Granger", "-", "UK", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 22, 13, 11, 10, 11, DateTimeKind.Utc).AddTicks(7153), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "FinalEvaluation", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 22, 13, 11, 10, 14, DateTimeKind.Utc).AddTicks(7849), "Good knowledge of frameworks, oop, and db", 4, 1, "6b2d2cc9-d5dc-45be-bc01-05711cf8caec" },
                    { 2, 2, new DateTime(2021, 11, 22, 13, 11, 10, 15, DateTimeKind.Utc).AddTicks(1220), "Excellent candidate", 5, 2, "6b2d2cc9-d5dc-45be-bc01-05711cf8caec" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 22, 13, 11, 10, 22, DateTimeKind.Utc).AddTicks(2507), "6b2d2cc9-d5dc-45be-bc01-05711cf8caec" },
                    { 2, 2, new DateTime(2021, 11, 22, 13, 11, 10, 22, DateTimeKind.Utc).AddTicks(3209), "6b2d2cc9-d5dc-45be-bc01-05711cf8caec" }
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
                keyValues: new object[] { "74e904f5-7806-4e48-8d16-8d3ebb1316b3", "17eea19a-b6bd-4197-a717-3516d75b5e7f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e832e6ab-dc33-4695-89f6-c164366b30d2", "2e8015af-b014-4152-8678-3ffef70afb48" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "17110c59-3469-4327-a366-337633b1d530", "47494c24-6f37-4b8e-9a8a-521ca8bb14ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9738af26-70ec-4aad-a0c9-f82b33ecb92d", "6b2d2cc9-d5dc-45be-bc01-05711cf8caec" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a380e0b4-0b1a-4b19-962e-06d8b2023ece", "ff603c3f-f514-430f-ab18-7227a55fde1e" });

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
                keyValue: "17110c59-3469-4327-a366-337633b1d530");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74e904f5-7806-4e48-8d16-8d3ebb1316b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9738af26-70ec-4aad-a0c9-f82b33ecb92d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a380e0b4-0b1a-4b19-962e-06d8b2023ece");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e832e6ab-dc33-4695-89f6-c164366b30d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17eea19a-b6bd-4197-a717-3516d75b5e7f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e8015af-b014-4152-8678-3ffef70afb48");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47494c24-6f37-4b8e-9a8a-521ca8bb14ea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff603c3f-f514-430f-ab18-7227a55fde1e");

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
                keyValue: "6b2d2cc9-d5dc-45be-bc01-05711cf8caec");

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
