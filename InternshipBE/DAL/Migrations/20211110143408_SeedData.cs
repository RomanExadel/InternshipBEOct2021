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
                    { "eb49e95c-ce3a-48ce-824a-2a199b3cfbd4", "6b4c6a29-565e-4eb4-86ca-06316eb691f4", "Hr", "HR" },
                    { "50a6e86d-af6f-4967-b6c4-14bca2572205", "35a7aa9d-a172-4aba-92b9-cbd34d42ab36", "Interviewer", "INTERVIEWER" },
                    { "3d354216-43b5-4a59-a860-f11082284bfa", "26c594fb-f706-408b-a91c-02f3fe631bca", "Manager", "MANAGER" },
                    { "26e331db-5902-4a22-b22e-3e319c028ced", "4bc5e961-ebd0-4a7b-bf57-376dd805278c", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "17b2fc5c-ac76-465d-9c35-a0177ba6d6d4", 0, "5a497407-47ec-4ab4-beaa-4d5d0b18227e", "li@gmail.com", false, true, null, "LI@GMAIL.COM", "MASHA", "AQAAAAEAACcQAAAAELjGP2Pghc/fSlpUV8hWre495OGlqThO5bA44OpM+VoNn81z7Axx28TvE3HtCbGihg==", "+123656787", false, "BA", "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Masha" },
                    { "7c9a86ee-08d2-429f-9664-afab9139486b", 0, "d9aa7323-da01-4064-aa87-c631fc54a824", "max@gmail.com", false, true, null, "MAX@GMAIL.COM", "MAXIM", "AQAAAAEAACcQAAAAEEwEvHG67zEDRQM1c04uwINXw0a9f8ComjH92taznS7LE7PdrbLsvojwwrN8FMO++w==", "+125656787", false, "Back", "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Maxim" },
                    { "60ac1156-df1b-4c3c-879b-98ea0fd0ca99", 0, "33e6c305-75eb-4440-bb41-310000b31c80", "user@example.com", false, true, null, "USER@EXAMPLE.COM", "DASHA", "AQAAAAEAACcQAAAAEAmEtZwnIbT+VS5ZOY8dn0wEmnwFaLBBhowkMWXnbrQ1931+TL9hklgVKTBpl35PJQ==", "+325656787", false, "Front", "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Dasha" },
                    { "be4ef230-657e-4ffd-b2a0-9d61023197be", 0, "be758914-0157-4147-a8fe-bcdb11afbcb7", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ALEXANDR", "AQAAAAEAACcQAAAAEGp/LnKdcQkExoIshwUO4/5oKMVoNmXDOLRiGdMllfzV+swellI7/DWAhMQV+lfgdA==", "+325659787", false, "PO", "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Alexandr" }
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
                    { 1, new DateTime(2021, 11, 10, 14, 34, 6, 164, DateTimeKind.Utc).AddTicks(7774), "image/link/1", 0, 0, 50, "JS/>NET", new DateTime(2021, 11, 10, 14, 34, 6, 164, DateTimeKind.Utc).AddTicks(9369), new DateTime(2021, 11, 10, 14, 34, 6, 164, DateTimeKind.Utc).AddTicks(8935), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 10, 14, 34, 6, 164, DateTimeKind.Utc).AddTicks(7307) },
                    { 2, new DateTime(2021, 11, 10, 14, 34, 6, 165, DateTimeKind.Utc).AddTicks(899), "image/link/2", 0, 0, 30, "QA Automation", new DateTime(2021, 11, 10, 14, 34, 6, 165, DateTimeKind.Utc).AddTicks(903), new DateTime(2021, 11, 10, 14, 34, 6, 165, DateTimeKind.Utc).AddTicks(901), "Any programming language, QA basics", new DateTime(2021, 11, 10, 14, 34, 6, 165, DateTimeKind.Utc).AddTicks(896) }
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
                    { "eb49e95c-ce3a-48ce-824a-2a199b3cfbd4", "17b2fc5c-ac76-465d-9c35-a0177ba6d6d4" },
                    { "50a6e86d-af6f-4967-b6c4-14bca2572205", "7c9a86ee-08d2-429f-9664-afab9139486b" },
                    { "3d354216-43b5-4a59-a860-f11082284bfa", "60ac1156-df1b-4c3c-879b-98ea0fd0ca99" },
                    { "26e331db-5902-4a22-b22e-3e319c028ced", "be4ef230-657e-4ffd-b2a0-9d61023197be" }
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
                values: new object[] { 1, new DateTime(2021, 11, 10, 14, 34, 6, 168, DateTimeKind.Utc).AddTicks(4462), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, true, "Snow", "-", "Arizona", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 10, 14, 34, 6, 168, DateTimeKind.Utc).AddTicks(7450), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 10, 14, 34, 6, 168, DateTimeKind.Utc).AddTicks(9046), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, true, "Granger", "-", "London", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 10, 14, 34, 6, 168, DateTimeKind.Utc).AddTicks(9052), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 10, 14, 34, 6, 169, DateTimeKind.Utc).AddTicks(7305), "Good knowledge of frameworks, oop, and db", 4, "17b2fc5c-ac76-465d-9c35-a0177ba6d6d4" },
                    { 2, 2, new DateTime(2021, 11, 10, 14, 34, 6, 169, DateTimeKind.Utc).AddTicks(8886), "Excellent candidate", 5, "17b2fc5c-ac76-465d-9c35-a0177ba6d6d4" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 10, 14, 34, 6, 172, DateTimeKind.Utc).AddTicks(7142), "17b2fc5c-ac76-465d-9c35-a0177ba6d6d4" },
                    { 2, 2, new DateTime(2021, 11, 10, 14, 34, 6, 172, DateTimeKind.Utc).AddTicks(7855), "17b2fc5c-ac76-465d-9c35-a0177ba6d6d4" }
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
                keyValues: new object[] { "eb49e95c-ce3a-48ce-824a-2a199b3cfbd4", "17b2fc5c-ac76-465d-9c35-a0177ba6d6d4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3d354216-43b5-4a59-a860-f11082284bfa", "60ac1156-df1b-4c3c-879b-98ea0fd0ca99" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "50a6e86d-af6f-4967-b6c4-14bca2572205", "7c9a86ee-08d2-429f-9664-afab9139486b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "26e331db-5902-4a22-b22e-3e319c028ced", "be4ef230-657e-4ffd-b2a0-9d61023197be" });

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
                keyValue: "26e331db-5902-4a22-b22e-3e319c028ced");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d354216-43b5-4a59-a860-f11082284bfa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50a6e86d-af6f-4967-b6c4-14bca2572205");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb49e95c-ce3a-48ce-824a-2a199b3cfbd4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "60ac1156-df1b-4c3c-879b-98ea0fd0ca99");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c9a86ee-08d2-429f-9664-afab9139486b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be4ef230-657e-4ffd-b2a0-9d61023197be");

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
                keyValue: "17b2fc5c-ac76-465d-9c35-a0177ba6d6d4");

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
