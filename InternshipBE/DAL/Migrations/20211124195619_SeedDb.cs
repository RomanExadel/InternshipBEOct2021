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
                    { "0121176f-d2e2-4090-abd5-da9ca40121e4", "ca6628ec-d9cf-481b-bcca-cc015c78fd60", "Mentor", "MENTOR" },
                    { "bda1a2c8-6ad0-4a5f-b392-4dbad403d0a7", "e69c7291-43ce-4962-a784-d156c3088c66", "Interviewer", "INTERVIEWER" },
                    { "ee2ace92-5843-4e97-bc0e-14a8fc9900e5", "c50c00ed-bdad-45aa-b7a9-8fdefc590e6c", "Hr", "HR" },
                    { "20b6b1c8-b16b-409b-8a2c-26aecc364d41", "f3eeaed9-dd09-4651-adb9-f8c6fbf4803c", "Admin", "ADMIN" },
                    { "c0e95d91-ea52-408c-a6b7-dafddeb8905f", "2bc3e406-6dc8-4440-a1cb-79f31b305803", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "RoleType", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "dcfc677b-5f92-4d57-a402-9d3d393a25e5", 0, "1fc2412a-9e7a-4272-be4e-5820c2a1b496", "mentortest.team5@gmail.com", false, true, null, "MENTORTEST.TEAM5@GMAIL.COM", "BORIS BOBROV", "AQAAAAEAACcQAAAAEMV5YnUGt6QwGHae76yB86midCWn6D+NHO6q8if9CS9TgJbIjJdL5ojCfvx4z1qekg==", "+7777777777777777", false, "PO", 0, "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Boris Bobrov" },
                    { "c954b51c-b952-4edc-b630-75dd3428d222", 0, "e8f0ca3e-bb92-47f4-b22b-3df24b818b56", "managertest.team5@gmail.com", false, true, null, "MANAGERTEST.TEAM5@GMAIL.COM", "ANN GREEN", "AQAAAAEAACcQAAAAEGqSOb+spuLkeK2IuQCRXIL6pYw6o1SGVxPhRrEYvqyOBYkQFtTgKJ+KffA4m6ZzSQ==", "+325659787", false, "PO", 3, "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Ann Green" },
                    { "5b3ea31f-2605-4a30-9473-e567e0b5c271", 0, "e97dd20f-e39c-444a-9796-b65b53a1228d", "interviewer.team5@gmail.com", false, true, null, "INTERVIEWER.TEAM5@GMAIL.COM", "IVAN SIDOROV", "AQAAAAEAACcQAAAAENc7bpYR1H/HcCs92DElgBbxY3I6BrLTFtPwP7o1kPzZ+9CMdVZoi0YR0BS2CWlRuA==", "+325656787", false, "Front", 2, "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Ivan Sidorov" },
                    { "17d0191c-25c2-42a0-be3b-4c1d70e6854e", 0, "f9e010c7-deb0-4251-bacb-d18341ef8141", "hrlily.team5@gmail.com", false, true, null, "HRLILY.TEAM5@GMAIL.COM", "LILY IVANOVA", "AQAAAAEAACcQAAAAEFOvZZGIW/s0cZSl3DrtWvpe0igoamUBd/tf1mHVRW/IgFFHrasKIg4w5ecDZaWF1A==", "+125656787", false, "Back", 1, "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Lily Ivanova" },
                    { "9d2b7cbf-e60e-485a-a083-ad82ed7c277a", 0, "b2331ab4-8355-47a7-bbe9-5ebd0e76f2a9", "admntest.team5@gmail.com", false, true, null, "ADMNTEST.TEAM5@GMAIL.COM", "PETER PETROV", "AQAAAAEAACcQAAAAEFlsXl46ORgSFxejSNhlJonHWT5xIUgw/wUT6+x9f/uIJId/L+q6xCLLKTmbiMShcw==", "+123656787", false, "BA", 4, "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Peter Petrov" }
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
                columns: new[] { "Id", "EndDate", "ImageLink", "InternshipStatusType", "MaxCandidateCount", "Name", "RegistrationFinishDate", "RegistrationStartDate", "Requirements", "SpreadSheetId", "StartDate" },
                values: new object[,]
                {
                    { 4, new DateTime(2021, 11, 24, 19, 56, 18, 189, DateTimeKind.Utc).AddTicks(4070), "https://drive.google.com/uc?export=view&id=1t-eClTKmOY4asHZkT6y_vvJNR4SMzKbB", 0, 30, "Angular/.NET", new DateTime(2021, 11, 24, 19, 56, 18, 189, DateTimeKind.Utc).AddTicks(4072), new DateTime(2021, 11, 24, 19, 56, 18, 189, DateTimeKind.Utc).AddTicks(4071), "OOP, JS, C#, .Net, Angular/React", "1RW1QxFSlyfGUnm0c-rGGr2_suo_MXrn1e_pUuLSV2tc", new DateTime(2021, 11, 24, 19, 56, 18, 189, DateTimeKind.Utc).AddTicks(4069) },
                    { 3, new DateTime(2021, 11, 24, 19, 56, 18, 189, DateTimeKind.Utc).AddTicks(4066), "https://drive.google.com/uc?export=view&id=1kirFfIPPxUbgOFNGNAk4CL6jf_lEOSKc", 0, 30, "GameDev", new DateTime(2021, 11, 24, 19, 56, 18, 189, DateTimeKind.Utc).AddTicks(4068), new DateTime(2021, 11, 24, 19, 56, 18, 189, DateTimeKind.Utc).AddTicks(4067), "OOP, Unity, C#, SQL", "1XSY0mwxSWPA1pXT4VteUoM4UTbuhn2LaqofeK6_7zuo", new DateTime(2021, 11, 24, 19, 56, 18, 189, DateTimeKind.Utc).AddTicks(4065) },
                    { 2, new DateTime(2021, 11, 24, 19, 56, 18, 189, DateTimeKind.Utc).AddTicks(4059), "https://drive.google.com/uc?export=view&id=1bvaKnWq0XEuldc4zry3qnrFtZoNRtW5R", 0, 30, "QA Automation", new DateTime(2021, 11, 24, 19, 56, 18, 189, DateTimeKind.Utc).AddTicks(4062), new DateTime(2021, 11, 24, 19, 56, 18, 189, DateTimeKind.Utc).AddTicks(4061), "Any programming language, QA basics", "1wdTLLMb8cWVQWpEfJafJCRL1eEF17kE1QQ1jYZGjw6A", new DateTime(2021, 11, 24, 19, 56, 18, 189, DateTimeKind.Utc).AddTicks(4056) },
                    { 1, new DateTime(2021, 11, 24, 19, 56, 18, 189, DateTimeKind.Utc).AddTicks(1636), "https://drive.google.com/uc?export=view&id=1tH7hcl7K2kM4HHC6QVXRdq0LPU8yZwd9", 0, 50, "JS/.NET", new DateTime(2021, 11, 24, 19, 56, 18, 189, DateTimeKind.Utc).AddTicks(2892), new DateTime(2021, 11, 24, 19, 56, 18, 189, DateTimeKind.Utc).AddTicks(2569), "OOP, JS, C#, .Net, Angular/React", "1nhQ98ChhQRfYQWQ2Rf6oyVpjyLetHq34V8muxMvwzSA", new DateTime(2021, 11, 24, 19, 56, 18, 189, DateTimeKind.Utc).AddTicks(1235) }
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
                    { "20b6b1c8-b16b-409b-8a2c-26aecc364d41", "9d2b7cbf-e60e-485a-a083-ad82ed7c277a" },
                    { "ee2ace92-5843-4e97-bc0e-14a8fc9900e5", "17d0191c-25c2-42a0-be3b-4c1d70e6854e" },
                    { "bda1a2c8-6ad0-4a5f-b392-4dbad403d0a7", "5b3ea31f-2605-4a30-9473-e567e0b5c271" },
                    { "c0e95d91-ea52-408c-a6b7-dafddeb8905f", "c954b51c-b952-4edc-b630-75dd3428d222" },
                    { "0121176f-d2e2-4090-abd5-da9ca40121e4", "dcfc677b-5f92-4d57-a402-9d3d393a25e5" }
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
                values: new object[] { 1, new DateTime(2021, 11, 24, 19, 56, 18, 191, DateTimeKind.Utc).AddTicks(7836), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, null, true, "Snow", "-", "USA", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 24, 19, 56, 18, 192, DateTimeKind.Utc).AddTicks(7), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "InternshipLanguage", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 24, 19, 56, 18, 192, DateTimeKind.Utc).AddTicks(1144), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, null, true, "Granger", "-", "UK", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 24, 19, 56, 18, 192, DateTimeKind.Utc).AddTicks(1148), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "FinalEvaluation", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 24, 19, 56, 18, 192, DateTimeKind.Utc).AddTicks(6347), "Good knowledge of frameworks, oop, and db", 4, 1, "9d2b7cbf-e60e-485a-a083-ad82ed7c277a" },
                    { 2, 2, new DateTime(2021, 11, 24, 19, 56, 18, 192, DateTimeKind.Utc).AddTicks(7304), "Excellent candidate", 5, 2, "9d2b7cbf-e60e-485a-a083-ad82ed7c277a" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 24, 19, 56, 18, 193, DateTimeKind.Utc).AddTicks(8680), "9d2b7cbf-e60e-485a-a083-ad82ed7c277a" },
                    { 2, 2, new DateTime(2021, 11, 24, 19, 56, 18, 193, DateTimeKind.Utc).AddTicks(9047), "9d2b7cbf-e60e-485a-a083-ad82ed7c277a" }
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
                keyValues: new object[] { "ee2ace92-5843-4e97-bc0e-14a8fc9900e5", "17d0191c-25c2-42a0-be3b-4c1d70e6854e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bda1a2c8-6ad0-4a5f-b392-4dbad403d0a7", "5b3ea31f-2605-4a30-9473-e567e0b5c271" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "20b6b1c8-b16b-409b-8a2c-26aecc364d41", "9d2b7cbf-e60e-485a-a083-ad82ed7c277a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c0e95d91-ea52-408c-a6b7-dafddeb8905f", "c954b51c-b952-4edc-b630-75dd3428d222" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0121176f-d2e2-4090-abd5-da9ca40121e4", "dcfc677b-5f92-4d57-a402-9d3d393a25e5" });

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
                keyValue: "0121176f-d2e2-4090-abd5-da9ca40121e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20b6b1c8-b16b-409b-8a2c-26aecc364d41");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bda1a2c8-6ad0-4a5f-b392-4dbad403d0a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0e95d91-ea52-408c-a6b7-dafddeb8905f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee2ace92-5843-4e97-bc0e-14a8fc9900e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17d0191c-25c2-42a0-be3b-4c1d70e6854e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b3ea31f-2605-4a30-9473-e567e0b5c271");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c954b51c-b952-4edc-b630-75dd3428d222");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dcfc677b-5f92-4d57-a402-9d3d393a25e5");

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
                keyValue: "9d2b7cbf-e60e-485a-a083-ad82ed7c277a");

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
