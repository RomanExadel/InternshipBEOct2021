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
                    { "35aee5d6-b86a-420a-b9b3-5d37d8218570", "4bf0fa13-3260-4395-964b-4d5bed4a0978", "Mentor", "MENTOR" },
                    { "bdc6ca7b-fd7a-4aba-9e1c-fe16fab275f2", "2110d16c-7993-487e-9b7c-f5496f7dd5d9", "Manager", "MANAGER" },
                    { "7639c76a-aaa4-441b-9588-4f8988d4468d", "f9a5af22-4676-4144-a855-21c22e5f5d09", "Interviewer", "INTERVIEWER" },
                    { "aba6b4e3-c0c0-4a8a-a1af-61e98cbf2e66", "6b734a92-941e-4402-9fce-cbadd328ecad", "Hr", "HR" },
                    { "38591ffa-0b3d-4e25-9f84-3f752c864767", "a426bc53-c338-4659-9968-4036ed705575", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "RoleType", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c392c0e7-06ac-404c-9cb3-6830832eb0f3", 0, "9994245f-0ea8-4073-845c-71f1de952b4f", "mentortest.team5@gmail.com", false, true, null, "MENTORTEST.TEAM5@GMAIL.COM", "BORIS BOBROV", "AQAAAAEAACcQAAAAEGBIXnPaHdJ4cJutFxi4zCfX/egEyHz49PoGCmcn6Jw1Kbjc6IB29kdlycvm9aPmnQ==", "+7777777777777777", false, "PO", 0, "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Boris Bobrov" },
                    { "d1d80947-5b92-4527-b534-000264ddbd22", 0, "b74423cf-6655-4dd2-b35c-eeb5129384c3", "managertest.team5@gmail.com", false, true, null, "MANAGERTEST.TEAM5@GMAIL.COM", "ANN GREEN", "AQAAAAEAACcQAAAAEJoCclKITEHjqlLvQlVUSmRU32EMUOSt6dF8sY83Hxpd8wBxCwcp7xwqGg57QtKWTg==", "+325659787", false, "PO", 3, "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Ann Green" },
                    { "4bf0c15c-469a-4662-9d0b-a8b50148e13d", 0, "5a4d9fdc-31d4-43bb-868e-ac7968121417", "interviewer.team5@gmail.com", false, true, null, "INTERVIEWER.TEAM5@GMAIL.COM", "IVAN SIDOROV", "AQAAAAEAACcQAAAAED/VYsO1QiIGExFZRkL/gS5xxolgo/ldqBIAC/pgNO9dLBkdb4fHrjr/CjULsUI65A==", "+325656787", false, "Front", 2, "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Ivan Sidorov" },
                    { "ad5f8ed6-d54e-425d-b18a-ee1008936271", 0, "546cd546-98b7-4090-a6a1-e2c3d3c8ff18", "hrlily.team5@gmail.com", false, true, null, "HRLILY.TEAM5@GMAIL.COM", "LILY IVANOVA", "AQAAAAEAACcQAAAAENyrANTxWbzNaz/okTZPHW/2V7maYPGU+wdFyY+e2X2yvwbcuB6XfgYP3jya4S0CYA==", "+125656787", false, "Back", 1, "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Lily Ivanova" },
                    { "37e94a22-4763-4f05-abaf-f5336c304b7b", 0, "097d1285-bee2-43e1-9b30-99bfb5ed71c9", "admntest.team5@gmail.com", false, true, null, "ADMNTEST.TEAM5@GMAIL.COM", "PETER PETROV", "AQAAAAEAACcQAAAAEHzALnYzzQJG1c5rnMIx0s2KpQCPsRblwYK9vp7ymlG8TLPWV4tJupvq8WkstrO2Tg==", "+123656787", false, "BA", 4, "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Peter Petrov" }
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
                    { 4, new DateTime(2021, 11, 20, 21, 41, 44, 627, DateTimeKind.Utc).AddTicks(671), "https://drive.google.com/uc?export=view&id=1t-eClTKmOY4asHZkT6y_vvJNR4SMzKbB", 0, 1, 30, "Angular/>NET", new DateTime(2021, 11, 20, 21, 41, 44, 627, DateTimeKind.Utc).AddTicks(678), new DateTime(2021, 11, 20, 21, 41, 44, 627, DateTimeKind.Utc).AddTicks(677), "OOP, JS, C#, .Net, Angular/React", null, new DateTime(2021, 11, 20, 21, 41, 44, 627, DateTimeKind.Utc).AddTicks(667) },
                    { 3, new DateTime(2021, 11, 20, 21, 41, 44, 627, DateTimeKind.Utc).AddTicks(658), "https://drive.google.com/uc?export=view&id=1kirFfIPPxUbgOFNGNAk4CL6jf_lEOSKc", 0, 1, 30, "GameDev", new DateTime(2021, 11, 20, 21, 41, 44, 627, DateTimeKind.Utc).AddTicks(665), new DateTime(2021, 11, 20, 21, 41, 44, 627, DateTimeKind.Utc).AddTicks(663), "OOP, Unity, C#, SQL", null, new DateTime(2021, 11, 20, 21, 41, 44, 627, DateTimeKind.Utc).AddTicks(654) },
                    { 2, new DateTime(2021, 11, 20, 21, 41, 44, 627, DateTimeKind.Utc).AddTicks(642), "https://drive.google.com/uc?export=view&id=1bvaKnWq0XEuldc4zry3qnrFtZoNRtW5R", 0, 0, 30, "QA Automation", new DateTime(2021, 11, 20, 21, 41, 44, 627, DateTimeKind.Utc).AddTicks(651), new DateTime(2021, 11, 20, 21, 41, 44, 627, DateTimeKind.Utc).AddTicks(649), "Any programming language, QA basics", null, new DateTime(2021, 11, 20, 21, 41, 44, 627, DateTimeKind.Utc).AddTicks(636) },
                    { 1, new DateTime(2021, 11, 20, 21, 41, 44, 625, DateTimeKind.Utc).AddTicks(8711), "https://drive.google.com/uc?export=view&id=1tH7hcl7K2kM4HHC6QVXRdq0LPU8yZwd9", 0, 0, 50, "JS/>NET", new DateTime(2021, 11, 20, 21, 41, 44, 626, DateTimeKind.Utc).AddTicks(7683), new DateTime(2021, 11, 20, 21, 41, 44, 626, DateTimeKind.Utc).AddTicks(6208), "OOP, JS, C#, .Net, Angular/React", null, new DateTime(2021, 11, 20, 21, 41, 44, 625, DateTimeKind.Utc).AddTicks(7859) }
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
                    { "aba6b4e3-c0c0-4a8a-a1af-61e98cbf2e66", "37e94a22-4763-4f05-abaf-f5336c304b7b" },
                    { "7639c76a-aaa4-441b-9588-4f8988d4468d", "ad5f8ed6-d54e-425d-b18a-ee1008936271" },
                    { "bdc6ca7b-fd7a-4aba-9e1c-fe16fab275f2", "4bf0c15c-469a-4662-9d0b-a8b50148e13d" },
                    { "38591ffa-0b3d-4e25-9f84-3f752c864767", "d1d80947-5b92-4527-b534-000264ddbd22" },
                    { "35aee5d6-b86a-420a-b9b3-5d37d8218570", "c392c0e7-06ac-404c-9cb3-6830832eb0f3" }
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
                values: new object[] { 1, new DateTime(2021, 11, 20, 21, 41, 44, 634, DateTimeKind.Utc).AddTicks(2491), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, null, true, "Snow", "-", "USA", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 20, 21, 41, 44, 634, DateTimeKind.Utc).AddTicks(8213), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "InternshipLanguage", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 20, 21, 41, 44, 635, DateTimeKind.Utc).AddTicks(625), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, null, true, "Granger", "-", "UK", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 20, 21, 41, 44, 635, DateTimeKind.Utc).AddTicks(641), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 20, 21, 41, 44, 636, DateTimeKind.Utc).AddTicks(2078), "Good knowledge of frameworks, oop, and db", 4, "37e94a22-4763-4f05-abaf-f5336c304b7b" },
                    { 2, 2, new DateTime(2021, 11, 20, 21, 41, 44, 636, DateTimeKind.Utc).AddTicks(4795), "Excellent candidate", 5, "37e94a22-4763-4f05-abaf-f5336c304b7b" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 20, 21, 41, 44, 639, DateTimeKind.Utc).AddTicks(2013), "37e94a22-4763-4f05-abaf-f5336c304b7b" },
                    { 2, 2, new DateTime(2021, 11, 20, 21, 41, 44, 639, DateTimeKind.Utc).AddTicks(2832), "37e94a22-4763-4f05-abaf-f5336c304b7b" }
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
                keyValues: new object[] { "aba6b4e3-c0c0-4a8a-a1af-61e98cbf2e66", "37e94a22-4763-4f05-abaf-f5336c304b7b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bdc6ca7b-fd7a-4aba-9e1c-fe16fab275f2", "4bf0c15c-469a-4662-9d0b-a8b50148e13d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7639c76a-aaa4-441b-9588-4f8988d4468d", "ad5f8ed6-d54e-425d-b18a-ee1008936271" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "35aee5d6-b86a-420a-b9b3-5d37d8218570", "c392c0e7-06ac-404c-9cb3-6830832eb0f3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "38591ffa-0b3d-4e25-9f84-3f752c864767", "d1d80947-5b92-4527-b534-000264ddbd22" });

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
                keyValue: "35aee5d6-b86a-420a-b9b3-5d37d8218570");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38591ffa-0b3d-4e25-9f84-3f752c864767");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7639c76a-aaa4-441b-9588-4f8988d4468d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aba6b4e3-c0c0-4a8a-a1af-61e98cbf2e66");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bdc6ca7b-fd7a-4aba-9e1c-fe16fab275f2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4bf0c15c-469a-4662-9d0b-a8b50148e13d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad5f8ed6-d54e-425d-b18a-ee1008936271");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c392c0e7-06ac-404c-9cb3-6830832eb0f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1d80947-5b92-4527-b534-000264ddbd22");

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
                keyValue: "37e94a22-4763-4f05-abaf-f5336c304b7b");

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
