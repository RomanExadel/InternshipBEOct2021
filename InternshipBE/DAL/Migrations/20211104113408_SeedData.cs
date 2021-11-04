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
                    { "ced29eb1-477a-46a9-8f19-61856525f989", "77321d09-c30a-4ec3-9ef2-ea7913661ea9", "Hr", "HR" },
                    { "71abc672-d385-44a9-bbf8-f5a382ce49c1", "e6f0fa43-051c-4619-8452-117cf185ca44", "Interviewer", "INTERVIEWER" },
                    { "0e33b9dd-5cd2-4d4b-acb3-5c5ec827432b", "18f38ebd-4b35-4c83-ae12-f6b3a9941dfd", "Manager", "MANAGER" },
                    { "70476c6b-db2e-421c-8c2c-2af2c2472628", "7a3b5384-e4e3-4ba9-981f-4600c366af7e", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BestContactTime", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6bfb5a16-52d2-4065-bc9a-778fda750b27", 0, new DateTime(2021, 11, 4, 11, 34, 7, 638, DateTimeKind.Utc).AddTicks(5741), "48a0cc92-d205-44ce-b37d-b8ec1c9178bc", "li@gmail.com", false, true, null, "LI@GMAIL.COM", "MASHA", "AQAAAAEAACcQAAAAEE/MYfDsQMKTU4/uG3uSZ8DIRON0dyxamHe+VL2RCpBUJpt1pHx9c6E10GWSWg33JQ==", "+123656787", false, "BA", "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Masha" },
                    { "06cb3098-fa7d-4b58-8b40-028c93389d69", 0, new DateTime(2021, 11, 4, 11, 34, 7, 646, DateTimeKind.Utc).AddTicks(8590), "539f5217-c62e-4446-8791-a4f0f856b34e", "max@gmail.com", false, true, null, "MAX@GMAIL.COM", "MAXIM", "AQAAAAEAACcQAAAAECUkYmnH/OHECg3n2MFmmZiteP59sdvva9g5ninPHGnzyQcWVAOCQBbUfjXNrGZcIg==", "+125656787", false, "Back", "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Maxim" },
                    { "04fd1df2-9c21-42d4-9004-62626dd56a0c", 0, new DateTime(2021, 11, 4, 11, 34, 7, 648, DateTimeKind.Utc).AddTicks(7832), "8fc95743-5998-4c08-95f4-bb4ebd6a3b71", "user@example.com", false, true, null, "USER@EXAMPLE.COM", "DASHA", "AQAAAAEAACcQAAAAEMO5ZppODXkjEoxCRld39ej05bgm7/lXUzBubSdscl3I+unghwG5iJLgU9D+A0TYlQ==", "+325656787", false, "Front", "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Dasha" },
                    { "6754eb6c-5ff3-4b73-9a5b-e19e2b64d42a", 0, new DateTime(2021, 11, 4, 11, 34, 7, 650, DateTimeKind.Utc).AddTicks(4480), "835e9c2b-536c-4d8e-bf7c-4a905f955ea0", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ALEXANDR", "AQAAAAEAACcQAAAAEE1TVcXht+2eOi6ALjEgbXv+QD4s4cIq3S+/9DVgabtTWhYVO9xxwu5k+1wQT1QyaQ==", "+325659787", false, "PO", "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Alexandr" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Belarus" },
                    { 2, "Russia" },
                    { 3, "Ukraine" }
                });

            migrationBuilder.InsertData(
                table: "Internships",
                columns: new[] { "Id", "EndDate", "ImageLink", "InternshipStatusType", "LanguageType", "MaxCandidateCount", "Name", "RegistrationFinishDate", "RegistrationStartDate", "Requirements", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 4, 11, 34, 7, 653, DateTimeKind.Utc).AddTicks(8502), "image/link/1", 0, 0, 50, "JS/>NET", new DateTime(2021, 11, 4, 11, 34, 7, 654, DateTimeKind.Utc).AddTicks(876), new DateTime(2021, 11, 4, 11, 34, 7, 654, DateTimeKind.Utc).AddTicks(264), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 4, 11, 34, 7, 653, DateTimeKind.Utc).AddTicks(7846) },
                    { 2, new DateTime(2021, 11, 4, 11, 34, 7, 654, DateTimeKind.Utc).AddTicks(3170), "image/link/2", 0, 0, 30, "QA Automation", new DateTime(2021, 11, 4, 11, 34, 7, 654, DateTimeKind.Utc).AddTicks(3173), new DateTime(2021, 11, 4, 11, 34, 7, 654, DateTimeKind.Utc).AddTicks(3172), "Any programming language, QA basics", new DateTime(2021, 11, 4, 11, 34, 7, 654, DateTimeKind.Utc).AddTicks(3167) }
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
                    { "ced29eb1-477a-46a9-8f19-61856525f989", "6bfb5a16-52d2-4065-bc9a-778fda750b27" },
                    { "71abc672-d385-44a9-bbf8-f5a382ce49c1", "06cb3098-fa7d-4b58-8b40-028c93389d69" },
                    { "0e33b9dd-5cd2-4d4b-acb3-5c5ec827432b", "04fd1df2-9c21-42d4-9004-62626dd56a0c" },
                    { "70476c6b-db2e-421c-8c2c-2af2c2472628", "6754eb6c-5ff3-4b73-9a5b-e19e2b64d42a" }
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
                values: new object[] { 1, new DateTime(2021, 11, 4, 11, 34, 7, 657, DateTimeKind.Utc).AddTicks(148), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, true, "Snow", "-", "Arizona", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 4, 11, 34, 7, 657, DateTimeKind.Utc).AddTicks(3724), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 4, 11, 34, 7, 657, DateTimeKind.Utc).AddTicks(5576), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, true, "Granger", "-", "London", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 4, 11, 34, 7, 657, DateTimeKind.Utc).AddTicks(5581), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 4, 11, 34, 7, 658, DateTimeKind.Utc).AddTicks(1272), "Good knowledge of frameworks, oop, and db", 4, "6bfb5a16-52d2-4065-bc9a-778fda750b27" },
                    { 2, 2, new DateTime(2021, 11, 4, 11, 34, 7, 658, DateTimeKind.Utc).AddTicks(3038), "Excellent candidate", 5, "6bfb5a16-52d2-4065-bc9a-778fda750b27" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 4, 11, 34, 7, 659, DateTimeKind.Utc).AddTicks(8722), "6bfb5a16-52d2-4065-bc9a-778fda750b27" },
                    { 2, 2, new DateTime(2021, 11, 4, 11, 34, 7, 659, DateTimeKind.Utc).AddTicks(9346), "6bfb5a16-52d2-4065-bc9a-778fda750b27" }
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
                keyValues: new object[] { "0e33b9dd-5cd2-4d4b-acb3-5c5ec827432b", "04fd1df2-9c21-42d4-9004-62626dd56a0c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "71abc672-d385-44a9-bbf8-f5a382ce49c1", "06cb3098-fa7d-4b58-8b40-028c93389d69" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "70476c6b-db2e-421c-8c2c-2af2c2472628", "6754eb6c-5ff3-4b73-9a5b-e19e2b64d42a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ced29eb1-477a-46a9-8f19-61856525f989", "6bfb5a16-52d2-4065-bc9a-778fda750b27" });

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
                keyValue: "0e33b9dd-5cd2-4d4b-acb3-5c5ec827432b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70476c6b-db2e-421c-8c2c-2af2c2472628");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71abc672-d385-44a9-bbf8-f5a382ce49c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ced29eb1-477a-46a9-8f19-61856525f989");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04fd1df2-9c21-42d4-9004-62626dd56a0c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06cb3098-fa7d-4b58-8b40-028c93389d69");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6754eb6c-5ff3-4b73-9a5b-e19e2b64d42a");

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
                keyValue: "6bfb5a16-52d2-4065-bc9a-778fda750b27");

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
