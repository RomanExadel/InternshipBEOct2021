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
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211103154641_SeedData.cs
                    { "7c076e64-7368-44b4-a32e-2294279df973", "b231e667-c6d9-4e3e-8bbc-8ced8a6c760f", "Hr", "HR" },
                    { "1b60e198-fa28-417c-b842-f51802f0315b", "c0f577e6-a670-472e-84d4-fe624e7f99ea", "Interviewer", "INTERVIEWER" },
                    { "02317d2f-20b6-4892-9c18-8fac51bbd654", "40031a98-d2b1-4325-a42e-e4bf3f8ac3fb", "Manager", "MANAGER" },
                    { "637bc525-e34c-4451-b3da-a37d4b409691", "ffdc0dc2-217e-4efa-95c2-b6edb0ece3eb", "Admin", "ADMIN" }
=======
                    { "abcb08cb-16a5-4ea5-a7fe-8adddcf5704d", "8abb15cc-24a4-49bd-8405-750cd99efd03", "Hr", "HR" },
                    { "2776c323-3731-4f62-9e06-762f503dd32a", "4531ed4d-d5e8-4a2c-a67b-a607ef8137b1", "Interviewer", "INTERVIEWER" },
                    { "fb8cf41d-49de-4965-b3b3-648609cff7ed", "f93db7a6-7134-461f-beb1-0749fd049f98", "Manager", "MANAGER" },
                    { "dabce6c6-e061-4571-9c41-759105709566", "531fe6d1-3aeb-4ba1-a353-d9beeeea3ab5", "Admin", "ADMIN" }
>>>>>>> e77c43a (Added new columns and data to internship table):InternshipBE/DAL/Migrations/20211103131620_SeedData.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BestContactTime", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211103154641_SeedData.cs
                    { "767b7e2b-e40f-40a4-98d6-44db0d40ec86", 0, new DateTime(2021, 11, 3, 15, 46, 38, 674, DateTimeKind.Utc).AddTicks(2943), "d88da7d8-a266-433c-ab1f-918bae24264c", "li@gmail.com", false, true, null, "LI@GMAIL.COM", "MASHA", "AQAAAAEAACcQAAAAEIUJt2+lx+KZDIlUWQ6lDl58Pz3vQ2uaUlEfY+W0ZJ2y+jcxRwZDOppS7mkj2ZJHxA==", "+123656787", false, "BA", "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Masha" },
                    { "052752e0-6905-4756-a476-4752b9cc293e", 0, new DateTime(2021, 11, 3, 15, 46, 38, 697, DateTimeKind.Utc).AddTicks(7660), "bd6fc438-237a-496d-9fcf-4735a6e4296a", "max@gmail.com", false, true, null, "MAX@GMAIL.COM", "MAXIM", "AQAAAAEAACcQAAAAEMfi64Q//xK5Jheabs0P9qjC6f9NDTj4lfDs8wVimaGvjD2ulEA6pURP95B3QKGXwQ==", "+125656787", false, "Back", "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Maxim" },
                    { "be8847a7-036b-41e2-b116-03c5558d93eb", 0, new DateTime(2021, 11, 3, 15, 46, 38, 713, DateTimeKind.Utc).AddTicks(5423), "52fc9af0-69d9-4a42-b0ae-c6703c3a382c", "user@example.com", false, true, null, "USER@EXAMPLE.COM", "DASHA", "AQAAAAEAACcQAAAAEMuhIL4vvMJztKV6CrBe6dHnQNQ16yVpKvrDh0kLlylNu4Nd5qBltO89GQsrhMIYAQ==", "+325656787", false, "Front", "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Dasha" },
                    { "4c8c58c5-008f-4fab-81b4-0f217a63987a", 0, new DateTime(2021, 11, 3, 15, 46, 38, 735, DateTimeKind.Utc).AddTicks(4018), "069a9003-07b7-41ab-984e-726cae031bb3", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ALEXANDR", "AQAAAAEAACcQAAAAEKnn7F1adtBX1AdpjXSz5Qk5zrV3kZdjRMXnULD+pJaWbGWXuI3Fvugvh8e3TVfh7Q==", "+325659787", false, "PO", "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Alexandr" }
=======
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
>>>>>>> e77c43a (Added new columns and data to internship table):InternshipBE/DAL/Migrations/20211103131620_SeedData.cs
                });

            migrationBuilder.InsertData(
                table: "Internships",
                columns: new[] { "Id", "EndDate", "ImageLink", "InternshipStatusType", "LanguageType", "MaxCandidateCount", "Name", "RegistrationFinishDate", "RegistrationStartDate", "Requirements", "StartDate" },
                values: new object[,]
                {
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211103154641_SeedData.cs
                    { 1, new DateTime(2021, 11, 3, 15, 46, 38, 762, DateTimeKind.Utc).AddTicks(2953), 0, 50, "JS/>NET", new DateTime(2021, 11, 3, 15, 46, 38, 762, DateTimeKind.Utc).AddTicks(5064), new DateTime(2021, 11, 3, 15, 46, 38, 762, DateTimeKind.Utc).AddTicks(4590), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 3, 15, 46, 38, 762, DateTimeKind.Utc).AddTicks(2224) },
                    { 2, new DateTime(2021, 11, 3, 15, 46, 38, 762, DateTimeKind.Utc).AddTicks(6197), 0, 30, "QA Automation", new DateTime(2021, 11, 3, 15, 46, 38, 762, DateTimeKind.Utc).AddTicks(6202), new DateTime(2021, 11, 3, 15, 46, 38, 762, DateTimeKind.Utc).AddTicks(6200), "Any programming language, QA basics", new DateTime(2021, 11, 3, 15, 46, 38, 762, DateTimeKind.Utc).AddTicks(6194) }
=======
                    { 1, new DateTime(2021, 11, 3, 13, 16, 19, 444, DateTimeKind.Utc).AddTicks(4485), "image/link/1", 0, 0, 50, "JS/>NET", new DateTime(2021, 11, 3, 13, 16, 19, 444, DateTimeKind.Utc).AddTicks(6871), new DateTime(2021, 11, 3, 13, 16, 19, 444, DateTimeKind.Utc).AddTicks(6260), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 3, 13, 16, 19, 444, DateTimeKind.Utc).AddTicks(3829) },
                    { 2, new DateTime(2021, 11, 3, 13, 16, 19, 444, DateTimeKind.Utc).AddTicks(9170), "image/link/2", 0, 0, 30, "QA Automation", new DateTime(2021, 11, 3, 13, 16, 19, 444, DateTimeKind.Utc).AddTicks(9174), new DateTime(2021, 11, 3, 13, 16, 19, 444, DateTimeKind.Utc).AddTicks(9172), "Any programming language, QA basics", new DateTime(2021, 11, 3, 13, 16, 19, 444, DateTimeKind.Utc).AddTicks(9168) }
>>>>>>> e77c43a (Added new columns and data to internship table):InternshipBE/DAL/Migrations/20211103131620_SeedData.cs
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
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211103154641_SeedData.cs
                    { "7c076e64-7368-44b4-a32e-2294279df973", "767b7e2b-e40f-40a4-98d6-44db0d40ec86" },
                    { "1b60e198-fa28-417c-b842-f51802f0315b", "052752e0-6905-4756-a476-4752b9cc293e" },
                    { "02317d2f-20b6-4892-9c18-8fac51bbd654", "be8847a7-036b-41e2-b116-03c5558d93eb" },
                    { "637bc525-e34c-4451-b3da-a37d4b409691", "4c8c58c5-008f-4fab-81b4-0f217a63987a" }
=======
                    { "abcb08cb-16a5-4ea5-a7fe-8adddcf5704d", "47a8c95e-0b04-4e41-a5af-8d76146d4e32" },
                    { "2776c323-3731-4f62-9e06-762f503dd32a", "e8030dac-ba98-4078-8214-a13c1e495ed2" },
                    { "fb8cf41d-49de-4965-b3b3-648609cff7ed", "920482cb-cf4e-4d20-bf12-60bf7ca518f9" },
                    { "dabce6c6-e061-4571-9c41-759105709566", "b9d907e7-2a87-4a15-81fa-089cb5ba2d49" }
>>>>>>> e77c43a (Added new columns and data to internship table):InternshipBE/DAL/Migrations/20211103131620_SeedData.cs
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
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211103154641_SeedData.cs
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 1, new DateTime(2021, 11, 3, 15, 46, 38, 765, DateTimeKind.Utc).AddTicks(9446), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, true, "Snow", "-", "Arizona", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 3, 15, 46, 38, 766, DateTimeKind.Utc).AddTicks(2574), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 3, 15, 46, 38, 766, DateTimeKind.Utc).AddTicks(4188), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, true, "Granger", "-", "London", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 3, 15, 46, 38, 766, DateTimeKind.Utc).AddTicks(4194), "live:h.granger", 5, 0, 2, 4 });
=======
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 1, new DateTime(2021, 11, 3, 13, 16, 19, 448, DateTimeKind.Utc).AddTicks(3502), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, true, "Snow", "-", "Arizona", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 3, 13, 16, 19, 448, DateTimeKind.Utc).AddTicks(6962), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 3, 13, 16, 19, 448, DateTimeKind.Utc).AddTicks(8766), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, true, "Granger", "-", "London", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 3, 13, 16, 19, 448, DateTimeKind.Utc).AddTicks(8770), "live:h.granger", 5, 0, 2, 4 });
>>>>>>> e77c43a (Added new columns and data to internship table):InternshipBE/DAL/Migrations/20211103131620_SeedData.cs

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "UserId" },
                values: new object[,]
                {
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211103154641_SeedData.cs
                    { 1, 1, new DateTime(2021, 11, 3, 15, 46, 38, 767, DateTimeKind.Utc).AddTicks(4097), "Good knowledge of frameworks, oop, and db", 4, "767b7e2b-e40f-40a4-98d6-44db0d40ec86" },
                    { 2, 2, new DateTime(2021, 11, 3, 15, 46, 38, 767, DateTimeKind.Utc).AddTicks(5705), "Excellent candidate", 5, "767b7e2b-e40f-40a4-98d6-44db0d40ec86" }
=======
                    { 1, 1, new DateTime(2021, 11, 3, 13, 16, 19, 449, DateTimeKind.Utc).AddTicks(6308), "Good knowledge of frameworks, oop, and db", 4, "47a8c95e-0b04-4e41-a5af-8d76146d4e32" },
                    { 2, 2, new DateTime(2021, 11, 3, 13, 16, 19, 449, DateTimeKind.Utc).AddTicks(8098), "Excellent candidate", 5, "47a8c95e-0b04-4e41-a5af-8d76146d4e32" }
>>>>>>> e77c43a (Added new columns and data to internship table):InternshipBE/DAL/Migrations/20211103131620_SeedData.cs
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211103154641_SeedData.cs
                    { 1, 1, new DateTime(2021, 11, 3, 15, 46, 38, 771, DateTimeKind.Utc).AddTicks(8016), "767b7e2b-e40f-40a4-98d6-44db0d40ec86" },
                    { 2, 2, new DateTime(2021, 11, 3, 15, 46, 38, 771, DateTimeKind.Utc).AddTicks(8879), "767b7e2b-e40f-40a4-98d6-44db0d40ec86" }
=======
                    { 1, 1, new DateTime(2021, 11, 3, 13, 16, 19, 451, DateTimeKind.Utc).AddTicks(9710), "47a8c95e-0b04-4e41-a5af-8d76146d4e32" },
                    { 2, 2, new DateTime(2021, 11, 3, 13, 16, 19, 452, DateTimeKind.Utc).AddTicks(367), "47a8c95e-0b04-4e41-a5af-8d76146d4e32" }
>>>>>>> e77c43a (Added new columns and data to internship table):InternshipBE/DAL/Migrations/20211103131620_SeedData.cs
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
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211103154641_SeedData.cs
                keyValues: new object[] { "1b60e198-fa28-417c-b842-f51802f0315b", "052752e0-6905-4756-a476-4752b9cc293e" });
=======
                keyValues: new object[] { "abcb08cb-16a5-4ea5-a7fe-8adddcf5704d", "47a8c95e-0b04-4e41-a5af-8d76146d4e32" });
>>>>>>> e77c43a (Added new columns and data to internship table):InternshipBE/DAL/Migrations/20211103131620_SeedData.cs

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211103154641_SeedData.cs
                keyValues: new object[] { "637bc525-e34c-4451-b3da-a37d4b409691", "4c8c58c5-008f-4fab-81b4-0f217a63987a" });
=======
                keyValues: new object[] { "fb8cf41d-49de-4965-b3b3-648609cff7ed", "920482cb-cf4e-4d20-bf12-60bf7ca518f9" });
>>>>>>> e77c43a (Added new columns and data to internship table):InternshipBE/DAL/Migrations/20211103131620_SeedData.cs

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211103154641_SeedData.cs
                keyValues: new object[] { "7c076e64-7368-44b4-a32e-2294279df973", "767b7e2b-e40f-40a4-98d6-44db0d40ec86" });
=======
                keyValues: new object[] { "dabce6c6-e061-4571-9c41-759105709566", "b9d907e7-2a87-4a15-81fa-089cb5ba2d49" });
>>>>>>> e77c43a (Added new columns and data to internship table):InternshipBE/DAL/Migrations/20211103131620_SeedData.cs

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211103154641_SeedData.cs
                keyValues: new object[] { "02317d2f-20b6-4892-9c18-8fac51bbd654", "be8847a7-036b-41e2-b116-03c5558d93eb" });
=======
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
>>>>>>> e77c43a (Added new columns and data to internship table):InternshipBE/DAL/Migrations/20211103131620_SeedData.cs

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
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211103154641_SeedData.cs
                keyValue: "02317d2f-20b6-4892-9c18-8fac51bbd654");
=======
                keyValue: "2776c323-3731-4f62-9e06-762f503dd32a");
>>>>>>> e77c43a (Added new columns and data to internship table):InternshipBE/DAL/Migrations/20211103131620_SeedData.cs

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211103154641_SeedData.cs
                keyValue: "1b60e198-fa28-417c-b842-f51802f0315b");
=======
                keyValue: "abcb08cb-16a5-4ea5-a7fe-8adddcf5704d");
>>>>>>> e77c43a (Added new columns and data to internship table):InternshipBE/DAL/Migrations/20211103131620_SeedData.cs

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211103154641_SeedData.cs
                keyValue: "637bc525-e34c-4451-b3da-a37d4b409691");
=======
                keyValue: "dabce6c6-e061-4571-9c41-759105709566");
>>>>>>> e77c43a (Added new columns and data to internship table):InternshipBE/DAL/Migrations/20211103131620_SeedData.cs

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211103154641_SeedData.cs
                keyValue: "7c076e64-7368-44b4-a32e-2294279df973");
=======
                keyValue: "fb8cf41d-49de-4965-b3b3-648609cff7ed");
>>>>>>> e77c43a (Added new columns and data to internship table):InternshipBE/DAL/Migrations/20211103131620_SeedData.cs

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211103154641_SeedData.cs
                keyValue: "052752e0-6905-4756-a476-4752b9cc293e");
=======
                keyValue: "920482cb-cf4e-4d20-bf12-60bf7ca518f9");
>>>>>>> e77c43a (Added new columns and data to internship table):InternshipBE/DAL/Migrations/20211103131620_SeedData.cs

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211103154641_SeedData.cs
                keyValue: "4c8c58c5-008f-4fab-81b4-0f217a63987a");
=======
                keyValue: "b9d907e7-2a87-4a15-81fa-089cb5ba2d49");
>>>>>>> e77c43a (Added new columns and data to internship table):InternshipBE/DAL/Migrations/20211103131620_SeedData.cs

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211103154641_SeedData.cs
                keyValue: "be8847a7-036b-41e2-b116-03c5558d93eb");
=======
                keyValue: "e8030dac-ba98-4078-8214-a13c1e495ed2");
>>>>>>> e77c43a (Added new columns and data to internship table):InternshipBE/DAL/Migrations/20211103131620_SeedData.cs

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
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211103154641_SeedData.cs
                keyValue: "767b7e2b-e40f-40a4-98d6-44db0d40ec86");
=======
                keyValue: "47a8c95e-0b04-4e41-a5af-8d76146d4e32");
>>>>>>> e77c43a (Added new columns and data to internship table):InternshipBE/DAL/Migrations/20211103131620_SeedData.cs

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
