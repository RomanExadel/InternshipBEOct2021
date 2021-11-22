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
                    { "7e193025-2d7a-4d50-9b76-60f599cdcc0d", "c995a6b1-939b-4776-8239-aa0373d913bf", "Mentor", "MENTOR" },
                    { "b1e6f441-0c0f-49aa-a7f4-7a9a18163025", "6cc7d3e5-8fa8-4b83-913c-5062689937a1", "Manager", "MANAGER" },
                    { "73ea48c8-d8d4-42df-bd24-42da39dac1bf", "c488fc22-318b-4d0b-9098-d417cad5b66f", "Interviewer", "INTERVIEWER" },
                    { "5113e7e9-630d-4170-b2fb-3a67502ceb38", "1afde359-8c02-4792-ac44-7f40852a3111", "Hr", "HR" },
                    { "81187ec7-a56c-4c73-b2d7-55c8c5370699", "bce67322-909e-430e-b530-96a718145414", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "RoleType", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "75e2119e-8010-4af3-9be5-0748970b575a", 0, "ab3370fc-1574-4505-8b12-6ded9743f345", "mentortest.team5@gmail.com", false, true, null, "MENTORTEST.TEAM5@GMAIL.COM", "BORIS BOBROV", "AQAAAAEAACcQAAAAEG5V+ED64yq5s1rMYzymEAdHjJZSFLtTZ/SWN1MHBDNh74M2VfRw+lLekq3JN5eMeA==", "+7777777777777777", false, "PO", 0, "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Boris Bobrov" },
                    { "ec85bfdd-4994-45b0-8d2d-4bd9b3fff715", 0, "6c7197bd-c423-475d-b7b8-17815e377609", "managertest.team5@gmail.com", false, true, null, "MANAGERTEST.TEAM5@GMAIL.COM", "ANN GREEN", "AQAAAAEAACcQAAAAEMJJCa9XALMNqq5xvjP8Bed6fgr3jhcFxK5GF+ABFADX2ePilHS6qM3KuJhrocxukA==", "+325659787", false, "PO", 3, "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Ann Green" },
                    { "37cba5fa-b370-4c92-aca1-6554070b44d2", 0, "0c8aa5ee-7280-40f7-b33a-b48be69e0b82", "interviewer.team5@gmail.com", false, true, null, "INTERVIEWER.TEAM5@GMAIL.COM", "IVAN SIDOROV", "AQAAAAEAACcQAAAAEPP8FdQCgg2WekfqTQSbhIp5mcsvGHBgLdjlq+CaI7MasH1dfVDZhBAx6biVVb56Nw==", "+325656787", false, "Front", 2, "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Ivan Sidorov" },
                    { "a607f6bb-88ca-471f-9f44-83606ca03755", 0, "3e211e2d-01d0-4ae4-a86f-48bbcedc86ac", "hrlily.team5@gmail.com", false, true, null, "HRLILY.TEAM5@GMAIL.COM", "LILY IVANOVA", "AQAAAAEAACcQAAAAEMdGh+kp8B6BeAMYbt7rg2Hnm/kNHZb5zKHZmTJxFv8FYJ2b810gkKYBZijJTlISWQ==", "+125656787", false, "Back", 1, "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Lily Ivanova" },
                    { "af412954-70f3-40bb-bcbb-8bea392d4b73", 0, "8be37633-8a5d-4601-a631-a69d3ec5a47b", "admntest.team5@gmail.com", false, true, null, "ADMNTEST.TEAM5@GMAIL.COM", "PETER PETROV", "AQAAAAEAACcQAAAAEIJq27A9f4B3yZIH1BBKYQA9Uy+7K4n89aY9PUE9VG2p5tMuT5XvyfnB9no80dpNUg==", "+123656787", false, "BA", 4, "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Peter Petrov" }
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
                    { 4, new DateTime(2021, 11, 22, 18, 57, 1, 722, DateTimeKind.Utc).AddTicks(5442), "https://drive.google.com/uc?export=view&id=1t-eClTKmOY4asHZkT6y_vvJNR4SMzKbB", 0, 1, 30, "Angular/.NET", new DateTime(2021, 11, 22, 18, 57, 1, 722, DateTimeKind.Utc).AddTicks(5447), new DateTime(2021, 11, 22, 18, 57, 1, 722, DateTimeKind.Utc).AddTicks(5444), "OOP, JS, C#, .Net, Angular/React", "1RW1QxFSlyfGUnm0c-rGGr2_suo_MXrn1e_pUuLSV2tc", new DateTime(2021, 11, 22, 18, 57, 1, 722, DateTimeKind.Utc).AddTicks(5441) },
                    { 3, new DateTime(2021, 11, 22, 18, 57, 1, 722, DateTimeKind.Utc).AddTicks(5425), "https://drive.google.com/uc?export=view&id=1kirFfIPPxUbgOFNGNAk4CL6jf_lEOSKc", 0, 1, 30, "GameDev", new DateTime(2021, 11, 22, 18, 57, 1, 722, DateTimeKind.Utc).AddTicks(5434), new DateTime(2021, 11, 22, 18, 57, 1, 722, DateTimeKind.Utc).AddTicks(5430), "OOP, Unity, C#, SQL", "1XSY0mwxSWPA1pXT4VteUoM4UTbuhn2LaqofeK6_7zuo", new DateTime(2021, 11, 22, 18, 57, 1, 722, DateTimeKind.Utc).AddTicks(5423) },
                    { 2, new DateTime(2021, 11, 22, 18, 57, 1, 722, DateTimeKind.Utc).AddTicks(5409), "https://drive.google.com/uc?export=view&id=1bvaKnWq0XEuldc4zry3qnrFtZoNRtW5R", 0, 0, 30, "QA Automation", new DateTime(2021, 11, 22, 18, 57, 1, 722, DateTimeKind.Utc).AddTicks(5414), new DateTime(2021, 11, 22, 18, 57, 1, 722, DateTimeKind.Utc).AddTicks(5411), "Any programming language, QA basics", "1wdTLLMb8cWVQWpEfJafJCRL1eEF17kE1QQ1jYZGjw6A", new DateTime(2021, 11, 22, 18, 57, 1, 722, DateTimeKind.Utc).AddTicks(5401) },
                    { 1, new DateTime(2021, 11, 22, 18, 57, 1, 721, DateTimeKind.Utc).AddTicks(8173), "https://drive.google.com/uc?export=view&id=1tH7hcl7K2kM4HHC6QVXRdq0LPU8yZwd9", 0, 0, 50, "JS/.NET", new DateTime(2021, 11, 22, 18, 57, 1, 722, DateTimeKind.Utc).AddTicks(1554), new DateTime(2021, 11, 22, 18, 57, 1, 722, DateTimeKind.Utc).AddTicks(703), "OOP, JS, C#, .Net, Angular/React", "1nhQ98ChhQRfYQWQ2Rf6oyVpjyLetHq34V8muxMvwzSA", new DateTime(2021, 11, 22, 18, 57, 1, 721, DateTimeKind.Utc).AddTicks(7212) }
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
                    { "5113e7e9-630d-4170-b2fb-3a67502ceb38", "af412954-70f3-40bb-bcbb-8bea392d4b73" },
                    { "73ea48c8-d8d4-42df-bd24-42da39dac1bf", "a607f6bb-88ca-471f-9f44-83606ca03755" },
                    { "b1e6f441-0c0f-49aa-a7f4-7a9a18163025", "37cba5fa-b370-4c92-aca1-6554070b44d2" },
                    { "81187ec7-a56c-4c73-b2d7-55c8c5370699", "ec85bfdd-4994-45b0-8d2d-4bd9b3fff715" },
                    { "7e193025-2d7a-4d50-9b76-60f599cdcc0d", "75e2119e-8010-4af3-9be5-0748970b575a" }
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
                values: new object[] { 1, new DateTime(2021, 11, 22, 18, 57, 1, 727, DateTimeKind.Utc).AddTicks(9202), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, null, true, "Snow", "-", "USA", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 22, 18, 57, 1, 728, DateTimeKind.Utc).AddTicks(3749), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "InternshipLanguage", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 22, 18, 57, 1, 728, DateTimeKind.Utc).AddTicks(6228), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, null, true, "Granger", "-", "UK", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 22, 18, 57, 1, 728, DateTimeKind.Utc).AddTicks(6241), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "FinalEvaluation", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 22, 18, 57, 1, 729, DateTimeKind.Utc).AddTicks(8519), "Good knowledge of frameworks, oop, and db", 4, 1, "af412954-70f3-40bb-bcbb-8bea392d4b73" },
                    { 2, 2, new DateTime(2021, 11, 22, 18, 57, 1, 730, DateTimeKind.Utc).AddTicks(497), "Excellent candidate", 5, 2, "af412954-70f3-40bb-bcbb-8bea392d4b73" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 22, 18, 57, 1, 737, DateTimeKind.Utc).AddTicks(6768), "af412954-70f3-40bb-bcbb-8bea392d4b73" },
                    { 2, 2, new DateTime(2021, 11, 22, 18, 57, 1, 737, DateTimeKind.Utc).AddTicks(8834), "af412954-70f3-40bb-bcbb-8bea392d4b73" }
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
                keyValues: new object[] { "b1e6f441-0c0f-49aa-a7f4-7a9a18163025", "37cba5fa-b370-4c92-aca1-6554070b44d2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7e193025-2d7a-4d50-9b76-60f599cdcc0d", "75e2119e-8010-4af3-9be5-0748970b575a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "73ea48c8-d8d4-42df-bd24-42da39dac1bf", "a607f6bb-88ca-471f-9f44-83606ca03755" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5113e7e9-630d-4170-b2fb-3a67502ceb38", "af412954-70f3-40bb-bcbb-8bea392d4b73" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "81187ec7-a56c-4c73-b2d7-55c8c5370699", "ec85bfdd-4994-45b0-8d2d-4bd9b3fff715" });

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
                keyValue: "5113e7e9-630d-4170-b2fb-3a67502ceb38");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ea48c8-d8d4-42df-bd24-42da39dac1bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e193025-2d7a-4d50-9b76-60f599cdcc0d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81187ec7-a56c-4c73-b2d7-55c8c5370699");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1e6f441-0c0f-49aa-a7f4-7a9a18163025");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37cba5fa-b370-4c92-aca1-6554070b44d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75e2119e-8010-4af3-9be5-0748970b575a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a607f6bb-88ca-471f-9f44-83606ca03755");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec85bfdd-4994-45b0-8d2d-4bd9b3fff715");

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
                keyValue: "af412954-70f3-40bb-bcbb-8bea392d4b73");

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
