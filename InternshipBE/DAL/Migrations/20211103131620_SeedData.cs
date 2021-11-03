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
                    { "abcb08cb-16a5-4ea5-a7fe-8adddcf5704d", "8abb15cc-24a4-49bd-8405-750cd99efd03", "Hr", "HR" },
                    { "2776c323-3731-4f62-9e06-762f503dd32a", "4531ed4d-d5e8-4a2c-a67b-a607ef8137b1", "Interviewer", "INTERVIEWER" },
                    { "fb8cf41d-49de-4965-b3b3-648609cff7ed", "f93db7a6-7134-461f-beb1-0749fd049f98", "Manager", "MANAGER" },
                    { "dabce6c6-e061-4571-9c41-759105709566", "531fe6d1-3aeb-4ba1-a353-d9beeeea3ab5", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BestContactTime", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "47a8c95e-0b04-4e41-a5af-8d76146d4e32", 0, new DateTime(2021, 11, 3, 13, 16, 19, 430, DateTimeKind.Utc).AddTicks(2837), "446c9caf-927c-4c4d-877a-e671b4b45155", "li@gmail.com", false, true, null, "LI@GMAIL.COM", "MASHA", "AQAAAAEAACcQAAAAEJRmJSto7bjN0f753i6LAjgwsBDNTJxO2FUmqOzhh84CaB+TBTTsqYQ3kqdvmYoKeQ==", "+123656787", false, "BA", "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Masha" },
                    { "e8030dac-ba98-4078-8214-a13c1e495ed2", 0, new DateTime(2021, 11, 3, 13, 16, 19, 437, DateTimeKind.Utc).AddTicks(9457), "05e349b0-e215-488d-ae1e-15e79b4ddf54", "max@gmail.com", false, true, null, "MAX@GMAIL.COM", "MAXIM", "AQAAAAEAACcQAAAAEMHzgm0ESp2tzD0bIwoJHvOb4w8xy6UbS10awJOYg+1p7+y/aGc4Ukqsiu7PlfA1vQ==", "+125656787", false, "Back", "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Maxim" },
                    { "920482cb-cf4e-4d20-bf12-60bf7ca518f9", 0, new DateTime(2021, 11, 3, 13, 16, 19, 439, DateTimeKind.Utc).AddTicks(6216), "6c2ab4c0-0544-470b-982c-9cafdba49f9e", "user@example.com", false, true, null, "USER@EXAMPLE.COM", "DASHA", "AQAAAAEAACcQAAAAEOP6zmaLtZ1iXOJMWAPlKRz6aTj+d9vlahloyPhQS5Tf6Ld9vFlVsIpWaTKNumUmMA==", "+325656787", false, "Front", "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Dasha" },
                    { "b9d907e7-2a87-4a15-81fa-089cb5ba2d49", 0, new DateTime(2021, 11, 3, 13, 16, 19, 441, DateTimeKind.Utc).AddTicks(2681), "bbd32173-cf2e-419c-af46-40f06a9589ae", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ALEXANDR", "AQAAAAEAACcQAAAAEN8hIGZCVfsfVxpf/e9HsEAvTwFR+KIalnMV/HeAA8RBUprw48sY+rg5pha6RNB8sg==", "+325659787", false, "PO", "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Alexandr" }
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
                    { 1, new DateTime(2021, 11, 3, 13, 16, 19, 444, DateTimeKind.Utc).AddTicks(4485), "image/link/1", 0, 0, 50, "JS/>NET", new DateTime(2021, 11, 3, 13, 16, 19, 444, DateTimeKind.Utc).AddTicks(6871), new DateTime(2021, 11, 3, 13, 16, 19, 444, DateTimeKind.Utc).AddTicks(6260), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 3, 13, 16, 19, 444, DateTimeKind.Utc).AddTicks(3829) },
                    { 2, new DateTime(2021, 11, 3, 13, 16, 19, 444, DateTimeKind.Utc).AddTicks(9170), "image/link/2", 0, 0, 30, "QA Automation", new DateTime(2021, 11, 3, 13, 16, 19, 444, DateTimeKind.Utc).AddTicks(9174), new DateTime(2021, 11, 3, 13, 16, 19, 444, DateTimeKind.Utc).AddTicks(9172), "Any programming language, QA basics", new DateTime(2021, 11, 3, 13, 16, 19, 444, DateTimeKind.Utc).AddTicks(9168) }
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
                    { "abcb08cb-16a5-4ea5-a7fe-8adddcf5704d", "47a8c95e-0b04-4e41-a5af-8d76146d4e32" },
                    { "2776c323-3731-4f62-9e06-762f503dd32a", "e8030dac-ba98-4078-8214-a13c1e495ed2" },
                    { "fb8cf41d-49de-4965-b3b3-648609cff7ed", "920482cb-cf4e-4d20-bf12-60bf7ca518f9" },
                    { "dabce6c6-e061-4571-9c41-759105709566", "b9d907e7-2a87-4a15-81fa-089cb5ba2d49" }
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
                values: new object[] { 1, new DateTime(2021, 11, 3, 13, 16, 19, 448, DateTimeKind.Utc).AddTicks(3502), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, true, "Snow", "-", "Arizona", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 3, 13, 16, 19, 448, DateTimeKind.Utc).AddTicks(6962), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 3, 13, 16, 19, 448, DateTimeKind.Utc).AddTicks(8766), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, true, "Granger", "-", "London", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 3, 13, 16, 19, 448, DateTimeKind.Utc).AddTicks(8770), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 3, 13, 16, 19, 449, DateTimeKind.Utc).AddTicks(6308), "Good knowledge of frameworks, oop, and db", 4, "47a8c95e-0b04-4e41-a5af-8d76146d4e32" },
                    { 2, 2, new DateTime(2021, 11, 3, 13, 16, 19, 449, DateTimeKind.Utc).AddTicks(8098), "Excellent candidate", 5, "47a8c95e-0b04-4e41-a5af-8d76146d4e32" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 3, 13, 16, 19, 451, DateTimeKind.Utc).AddTicks(9710), "47a8c95e-0b04-4e41-a5af-8d76146d4e32" },
                    { 2, 2, new DateTime(2021, 11, 3, 13, 16, 19, 452, DateTimeKind.Utc).AddTicks(367), "47a8c95e-0b04-4e41-a5af-8d76146d4e32" }
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
                keyValues: new object[] { "abcb08cb-16a5-4ea5-a7fe-8adddcf5704d", "47a8c95e-0b04-4e41-a5af-8d76146d4e32" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb8cf41d-49de-4965-b3b3-648609cff7ed", "920482cb-cf4e-4d20-bf12-60bf7ca518f9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dabce6c6-e061-4571-9c41-759105709566", "b9d907e7-2a87-4a15-81fa-089cb5ba2d49" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2776c323-3731-4f62-9e06-762f503dd32a", "e8030dac-ba98-4078-8214-a13c1e495ed2" });

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
                keyValue: "2776c323-3731-4f62-9e06-762f503dd32a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abcb08cb-16a5-4ea5-a7fe-8adddcf5704d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dabce6c6-e061-4571-9c41-759105709566");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb8cf41d-49de-4965-b3b3-648609cff7ed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "920482cb-cf4e-4d20-bf12-60bf7ca518f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9d907e7-2a87-4a15-81fa-089cb5ba2d49");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8030dac-ba98-4078-8214-a13c1e495ed2");

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
                keyValue: "47a8c95e-0b04-4e41-a5af-8d76146d4e32");

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
