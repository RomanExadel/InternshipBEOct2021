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
                    { "4d8489dd-1665-469a-bfc9-d180306dec61", "1bd07d94-d2b6-4886-acba-040c9cd9ef7c", "Admin", "ADMIN" },
                    { "d8245358-084c-4b2a-9ac5-93ce9ac7ee5a", "d2f02083-6935-4ef6-ac45-615ca2bfcb49", "Interviewer", "INTERVIEWER" },
                    { "d237fa6d-7dd4-49ef-b037-449a3be0d4be", "2b73fb14-1a47-45dd-9470-ccb4b4bf4069", "Hr", "HR" },
                    { "9b46b5ac-ea22-4133-93b1-fa3f3fd05e5e", "082e642e-6a34-429f-b5d2-571ce9705a49", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "RoleType", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e94a91e0-a29f-4eb1-96ec-a47ab8fca1cb", 0, "505bf3b7-92f4-4e47-bbba-f3a235843f40", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ALEXANDR", "AQAAAAEAACcQAAAAEMeDawyigTNMJmrE2uWt+khPjoHtGoppPLps6l+oLFvPI8p62rTK3eOaZfTj5Q8Jcg==", "+325659787", false, "PO", 4, "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Alexandr" },
                    { "c909788f-f0f6-4819-9f81-96bd8090ea2a", 0, "ec56c3ca-74ea-46ad-9efc-2d8e1b0e437b", "user@example.com", false, true, null, "USER@EXAMPLE.COM", "DASHA", "AQAAAAEAACcQAAAAEJnL1BpH1iqS50//SQLkuqcQ6XLZe5+IJHeeWH5i1ISAnbBkqhuYLVU5vCb++tjQ+w==", "+325656787", false, "Front", 3, "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Dasha" },
                    { "f7971a57-baae-4f86-8b66-08ea4c16d555", 0, "6a37ed5c-5267-41e5-b62e-d8074d61b147", "max@gmail.com", false, true, null, "MAX@GMAIL.COM", "MAXIM", "AQAAAAEAACcQAAAAEOrCP6+GrWJZCBynpIyyuyj/PRM5lejMNQVk30YcXKaqcRgsP8cKdBfR70nklgOAvg==", "+125656787", false, "Back", 2, "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Maxim" },
                    { "17454760-ce69-406c-bcd2-5d712bc784a8", 0, "144073ed-df84-46d7-bebd-2680118dbdd5", "li@gmail.com", false, true, null, "LI@GMAIL.COM", "MASHA", "AQAAAAEAACcQAAAAEMrKV+H5lNFiEOFMcuTXeLAh1ACmqAuodobULeU6CUrwr3ROPPhg/OyNqTzJ1YN6pw==", "+123656787", false, "BA", 1, "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Masha" }
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
                columns: new[] { "Id", "EndDate", "ImageLink", "InternshipStatusType", "MaxCandidateCount", "Name", "RegistrationFinishDate", "RegistrationStartDate", "Requirements", "StartDate" },
                values: new object[,]
                {
                    { 4, new DateTime(2021, 11, 23, 17, 54, 29, 527, DateTimeKind.Utc).AddTicks(6314), "https://drive.google.com/uc?export=view&id=1t-eClTKmOY4asHZkT6y_vvJNR4SMzKbB", 0, 30, "Angular/>NET", new DateTime(2021, 11, 23, 17, 54, 29, 527, DateTimeKind.Utc).AddTicks(6316), new DateTime(2021, 11, 23, 17, 54, 29, 527, DateTimeKind.Utc).AddTicks(6315), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 23, 17, 54, 29, 527, DateTimeKind.Utc).AddTicks(6312) },
                    { 3, new DateTime(2021, 11, 23, 17, 54, 29, 527, DateTimeKind.Utc).AddTicks(6309), "https://drive.google.com/uc?export=view&id=1kirFfIPPxUbgOFNGNAk4CL6jf_lEOSKc", 0, 30, "GameDev", new DateTime(2021, 11, 23, 17, 54, 29, 527, DateTimeKind.Utc).AddTicks(6311), new DateTime(2021, 11, 23, 17, 54, 29, 527, DateTimeKind.Utc).AddTicks(6310), "OOP, Unity, C#, SQL", new DateTime(2021, 11, 23, 17, 54, 29, 527, DateTimeKind.Utc).AddTicks(6308) },
                    { 2, new DateTime(2021, 11, 23, 17, 54, 29, 527, DateTimeKind.Utc).AddTicks(6303), "https://drive.google.com/uc?export=view&id=1bvaKnWq0XEuldc4zry3qnrFtZoNRtW5R", 0, 30, "QA Automation", new DateTime(2021, 11, 23, 17, 54, 29, 527, DateTimeKind.Utc).AddTicks(6306), new DateTime(2021, 11, 23, 17, 54, 29, 527, DateTimeKind.Utc).AddTicks(6305), "Any programming language, QA basics", new DateTime(2021, 11, 23, 17, 54, 29, 527, DateTimeKind.Utc).AddTicks(6299) },
                    { 1, new DateTime(2021, 11, 23, 17, 54, 29, 527, DateTimeKind.Utc).AddTicks(3333), "https://drive.google.com/uc?export=view&id=1tH7hcl7K2kM4HHC6QVXRdq0LPU8yZwd9", 0, 50, "JS/>NET", new DateTime(2021, 11, 23, 17, 54, 29, 527, DateTimeKind.Utc).AddTicks(5352), new DateTime(2021, 11, 23, 17, 54, 29, 527, DateTimeKind.Utc).AddTicks(4981), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 23, 17, 54, 29, 527, DateTimeKind.Utc).AddTicks(2783) }
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
                    { "d237fa6d-7dd4-49ef-b037-449a3be0d4be", "17454760-ce69-406c-bcd2-5d712bc784a8" },
                    { "d8245358-084c-4b2a-9ac5-93ce9ac7ee5a", "f7971a57-baae-4f86-8b66-08ea4c16d555" },
                    { "9b46b5ac-ea22-4133-93b1-fa3f3fd05e5e", "c909788f-f0f6-4819-9f81-96bd8090ea2a" },
                    { "4d8489dd-1665-469a-bfc9-d180306dec61", "e94a91e0-a29f-4eb1-96ec-a47ab8fca1cb" }
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
                values: new object[] { 1, new DateTime(2021, 11, 23, 17, 54, 29, 537, DateTimeKind.Utc).AddTicks(8649), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, null, true, "Snow", "-", "USA", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 23, 17, 54, 29, 538, DateTimeKind.Utc).AddTicks(706), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "InternshipLanguage", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 23, 17, 54, 29, 538, DateTimeKind.Utc).AddTicks(1730), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, null, true, "Granger", "-", "UK", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 23, 17, 54, 29, 538, DateTimeKind.Utc).AddTicks(1735), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 23, 17, 54, 29, 538, DateTimeKind.Utc).AddTicks(6658), "Good knowledge of frameworks, oop, and db", 4, "17454760-ce69-406c-bcd2-5d712bc784a8" },
                    { 2, 2, new DateTime(2021, 11, 23, 17, 54, 29, 538, DateTimeKind.Utc).AddTicks(7642), "Excellent candidate", 5, "17454760-ce69-406c-bcd2-5d712bc784a8" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 23, 17, 54, 29, 544, DateTimeKind.Utc).AddTicks(7417), "17454760-ce69-406c-bcd2-5d712bc784a8" },
                    { 2, 2, new DateTime(2021, 11, 23, 17, 54, 29, 544, DateTimeKind.Utc).AddTicks(7797), "17454760-ce69-406c-bcd2-5d712bc784a8" }
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
                keyValues: new object[] { "d237fa6d-7dd4-49ef-b037-449a3be0d4be", "17454760-ce69-406c-bcd2-5d712bc784a8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9b46b5ac-ea22-4133-93b1-fa3f3fd05e5e", "c909788f-f0f6-4819-9f81-96bd8090ea2a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4d8489dd-1665-469a-bfc9-d180306dec61", "e94a91e0-a29f-4eb1-96ec-a47ab8fca1cb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d8245358-084c-4b2a-9ac5-93ce9ac7ee5a", "f7971a57-baae-4f86-8b66-08ea4c16d555" });

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
                keyValue: "4d8489dd-1665-469a-bfc9-d180306dec61");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b46b5ac-ea22-4133-93b1-fa3f3fd05e5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d237fa6d-7dd4-49ef-b037-449a3be0d4be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8245358-084c-4b2a-9ac5-93ce9ac7ee5a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c909788f-f0f6-4819-9f81-96bd8090ea2a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e94a91e0-a29f-4eb1-96ec-a47ab8fca1cb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7971a57-baae-4f86-8b66-08ea4c16d555");

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
                keyValue: "17454760-ce69-406c-bcd2-5d712bc784a8");

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
