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
                    { "9e40e7b2-8878-40a9-82b2-a51e4e3a074a", "0be4c94a-1693-4526-9a04-140e6b640292", "Hr", "HR" },
                    { "66d7ea30-e758-439d-8be4-bef40a00f165", "a38d269d-e54d-44f4-ba28-0c57ed57a362", "Interviewer", "INTERVIEWER" },
                    { "13178c2c-b049-46dc-8e62-7765c1afc912", "d66fc8f7-0779-460f-b976-83f1378960c6", "Manager", "MANAGER" },
                    { "051bd651-a9b7-41dd-8877-4e4be6110975", "9e043c15-5768-4a4c-bccb-f39535f9a037", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BestContactTime", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "740d84a0-6dc6-47bf-a535-a3390e01c41d", 0, new DateTime(2021, 11, 4, 11, 45, 8, 133, DateTimeKind.Utc).AddTicks(3256), "a331cb54-07cf-48ec-ba44-7d7b4c95c9ee", "li@gmail.com", false, true, null, "LI@GMAIL.COM", "MASHA", "AQAAAAEAACcQAAAAEJPjaVw81vZF5mXfJz1aif2rIx3vPdezMyafZ5CQoNEoGfJaaX6KlvQ+G8I2i58D5g==", "+123656787", false, "BA", "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Masha" },
                    { "43a2a5bf-5727-455a-bf8d-4df0b30feacb", 0, new DateTime(2021, 11, 4, 11, 45, 8, 139, DateTimeKind.Utc).AddTicks(9157), "4ac7530b-4d38-47f8-9a34-b1c6ab42519b", "max@gmail.com", false, true, null, "MAX@GMAIL.COM", "MAXIM", "AQAAAAEAACcQAAAAEMgwsPqTa5MWnmRJ97Ehdj11Bst3GT0EiMWWAlnN68NWOpUAODHYSLLrOQlDknO8cA==", "+125656787", false, "Back", "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Maxim" },
                    { "86a2be45-f46f-457a-9f52-6a1bb50ba8d7", 0, new DateTime(2021, 11, 4, 11, 45, 8, 141, DateTimeKind.Utc).AddTicks(5406), "985fcf17-870d-4a0f-b438-c5d02fcbf88f", "user@example.com", false, true, null, "USER@EXAMPLE.COM", "DASHA", "AQAAAAEAACcQAAAAEOimy80QXNTkhKV9pIkPMpPGiqxTyGj7bt/LTEokCV3CJCahaYLhQXmzMyVIAweLzA==", "+325656787", false, "Front", "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Dasha" },
                    { "777835bd-fc5b-46ba-ab7d-8bc38fffa9ad", 0, new DateTime(2021, 11, 4, 11, 45, 8, 143, DateTimeKind.Utc).AddTicks(1291), "e8536d46-1339-4a22-8dc5-ceb0a8028d6e", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ALEXANDR", "AQAAAAEAACcQAAAAENuTAqbumxnRNNUkH5yWrQUsYzon8BdiPuDMxfLez8Y5cDc8mbQ4UQBKjvPjVJN+iQ==", "+325659787", false, "PO", "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Alexandr" }
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
                    { 1, new DateTime(2021, 11, 4, 11, 45, 8, 145, DateTimeKind.Utc).AddTicks(9301), "image/link/1", 0, 0, 50, "JS/>NET", new DateTime(2021, 11, 4, 11, 45, 8, 146, DateTimeKind.Utc).AddTicks(1700), new DateTime(2021, 11, 4, 11, 45, 8, 146, DateTimeKind.Utc).AddTicks(1094), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 4, 11, 45, 8, 145, DateTimeKind.Utc).AddTicks(8657) },
                    { 2, new DateTime(2021, 11, 4, 11, 45, 8, 146, DateTimeKind.Utc).AddTicks(3989), "image/link/2", 0, 0, 30, "QA Automation", new DateTime(2021, 11, 4, 11, 45, 8, 146, DateTimeKind.Utc).AddTicks(3992), new DateTime(2021, 11, 4, 11, 45, 8, 146, DateTimeKind.Utc).AddTicks(3991), "Any programming language, QA basics", new DateTime(2021, 11, 4, 11, 45, 8, 146, DateTimeKind.Utc).AddTicks(3985) }
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
                    { "9e40e7b2-8878-40a9-82b2-a51e4e3a074a", "740d84a0-6dc6-47bf-a535-a3390e01c41d" },
                    { "66d7ea30-e758-439d-8be4-bef40a00f165", "43a2a5bf-5727-455a-bf8d-4df0b30feacb" },
                    { "13178c2c-b049-46dc-8e62-7765c1afc912", "86a2be45-f46f-457a-9f52-6a1bb50ba8d7" },
                    { "051bd651-a9b7-41dd-8877-4e4be6110975", "777835bd-fc5b-46ba-ab7d-8bc38fffa9ad" }
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
                values: new object[] { 1, new DateTime(2021, 11, 4, 11, 45, 8, 151, DateTimeKind.Utc).AddTicks(6622), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, true, "Snow", "-", "Arizona", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 4, 11, 45, 8, 152, DateTimeKind.Utc).AddTicks(211), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 4, 11, 45, 8, 152, DateTimeKind.Utc).AddTicks(2083), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, true, "Granger", "-", "London", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 4, 11, 45, 8, 152, DateTimeKind.Utc).AddTicks(2088), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 4, 11, 45, 8, 152, DateTimeKind.Utc).AddTicks(8380), "Good knowledge of frameworks, oop, and db", 4, "740d84a0-6dc6-47bf-a535-a3390e01c41d" },
                    { 2, 2, new DateTime(2021, 11, 4, 11, 45, 8, 153, DateTimeKind.Utc).AddTicks(270), "Excellent candidate", 5, "740d84a0-6dc6-47bf-a535-a3390e01c41d" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 4, 11, 45, 8, 155, DateTimeKind.Utc).AddTicks(197), "740d84a0-6dc6-47bf-a535-a3390e01c41d" },
                    { 2, 2, new DateTime(2021, 11, 4, 11, 45, 8, 155, DateTimeKind.Utc).AddTicks(946), "740d84a0-6dc6-47bf-a535-a3390e01c41d" }
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
                keyValues: new object[] { "66d7ea30-e758-439d-8be4-bef40a00f165", "43a2a5bf-5727-455a-bf8d-4df0b30feacb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9e40e7b2-8878-40a9-82b2-a51e4e3a074a", "740d84a0-6dc6-47bf-a535-a3390e01c41d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "051bd651-a9b7-41dd-8877-4e4be6110975", "777835bd-fc5b-46ba-ab7d-8bc38fffa9ad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "13178c2c-b049-46dc-8e62-7765c1afc912", "86a2be45-f46f-457a-9f52-6a1bb50ba8d7" });

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
                keyValue: "051bd651-a9b7-41dd-8877-4e4be6110975");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13178c2c-b049-46dc-8e62-7765c1afc912");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66d7ea30-e758-439d-8be4-bef40a00f165");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e40e7b2-8878-40a9-82b2-a51e4e3a074a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43a2a5bf-5727-455a-bf8d-4df0b30feacb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "777835bd-fc5b-46ba-ab7d-8bc38fffa9ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86a2be45-f46f-457a-9f52-6a1bb50ba8d7");

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
                keyValue: "740d84a0-6dc6-47bf-a535-a3390e01c41d");

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
