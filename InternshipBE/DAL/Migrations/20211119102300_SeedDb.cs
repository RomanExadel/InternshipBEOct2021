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
                    { "ffc86ef7-7d22-4c17-826a-8d54ce32ad6a", "68e4bd0c-a9a9-48b9-b9e0-c7f21355711d", "Admin", "ADMIN" },
                    { "02df9557-7088-4b4b-a64e-eb2da9518574", "953adbf5-7f0c-4901-907e-568aba79cead", "Interviewer", "INTERVIEWER" },
                    { "19b89a5b-1d5f-4269-a4fb-88a59a70f109", "cdbd92d0-a6d9-42e0-86a3-cc30e56dbce5", "Hr", "HR" },
                    { "b42fb4b7-7fc4-46db-b2e3-abd94bbd5bb3", "7d731034-af23-4663-991e-a5c83496c1c2", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "RoleType", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4f3e4b28-1a66-462d-93aa-853f7459474c", 0, "eb5c399b-520b-4276-aa22-d529fbc90aeb", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ALEXANDR", "AQAAAAEAACcQAAAAENcOyAsmlYBW+u2G5ywTobxwwN+ptyV1FJEV4TN2F70BW/DQsFEmdtBluYgqLe353Q==", "+325659787", false, "PO", 4, "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Alexandr" },
                    { "4fdd06ee-3a6f-4d63-9c90-57f77a902fa2", 0, "b23f2269-81cd-4c47-833c-01e938624077", "user@example.com", false, true, null, "USER@EXAMPLE.COM", "DASHA", "AQAAAAEAACcQAAAAEAaesonOh5wkqzGmFzaIe3zmOsXeKgvcElZFN6Mb+mIsS2gSVVvP0gKNL1EgyYJejw==", "+325656787", false, "Front", 3, "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Dasha" },
                    { "3af23481-bb15-4864-a18b-03e1742ded57", 0, "b35e9240-7988-4698-9f2d-468227cfc877", "max@gmail.com", false, true, null, "MAX@GMAIL.COM", "MAXIM", "AQAAAAEAACcQAAAAEETj8K353iMMUxI5jhyBTqgEsQoL5wy9WVAJ58E9XgK87rkqitxdeQJWjRkYFJAYDg==", "+125656787", false, "Back", 2, "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Maxim" },
                    { "0f55eb95-7bf2-42d2-8c3b-e65c4be9cdc2", 0, "483c2328-987e-49a1-a956-911fa1b4831e", "li@gmail.com", false, true, null, "LI@GMAIL.COM", "MASHA", "AQAAAAEAACcQAAAAEF+0jCrDfUBUNKaWkIMoPUg0yUxkFE/jI9zY71W5kq6O9u9fMnXqtZFJXDSPDRhX4Q==", "+123656787", false, "BA", 1, "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Masha" }
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
                columns: new[] { "Id", "EndDate", "ImageLink", "InternshipStatusType", "LanguageType", "MaxCandidateCount", "Name", "RegistrationFinishDate", "RegistrationStartDate", "Requirements", "StartDate" },
                values: new object[,]
                {
                    { 4, new DateTime(2021, 11, 19, 10, 23, 0, 82, DateTimeKind.Utc).AddTicks(9884), "https://drive.google.com/uc?export=view&id=1t-eClTKmOY4asHZkT6y_vvJNR4SMzKbB", 0, 1, 30, "Angular/>NET", new DateTime(2021, 11, 19, 10, 23, 0, 82, DateTimeKind.Utc).AddTicks(9886), new DateTime(2021, 11, 19, 10, 23, 0, 82, DateTimeKind.Utc).AddTicks(9885), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 19, 10, 23, 0, 82, DateTimeKind.Utc).AddTicks(9883) },
                    { 3, new DateTime(2021, 11, 19, 10, 23, 0, 82, DateTimeKind.Utc).AddTicks(9879), "https://drive.google.com/uc?export=view&id=1kirFfIPPxUbgOFNGNAk4CL6jf_lEOSKc", 0, 1, 30, "GameDev", new DateTime(2021, 11, 19, 10, 23, 0, 82, DateTimeKind.Utc).AddTicks(9881), new DateTime(2021, 11, 19, 10, 23, 0, 82, DateTimeKind.Utc).AddTicks(9880), "OOP, Unity, C#, SQL", new DateTime(2021, 11, 19, 10, 23, 0, 82, DateTimeKind.Utc).AddTicks(9878) },
                    { 2, new DateTime(2021, 11, 19, 10, 23, 0, 82, DateTimeKind.Utc).AddTicks(9873), "https://drive.google.com/uc?export=view&id=1bvaKnWq0XEuldc4zry3qnrFtZoNRtW5R", 0, 0, 30, "QA Automation", new DateTime(2021, 11, 19, 10, 23, 0, 82, DateTimeKind.Utc).AddTicks(9876), new DateTime(2021, 11, 19, 10, 23, 0, 82, DateTimeKind.Utc).AddTicks(9874), "Any programming language, QA basics", new DateTime(2021, 11, 19, 10, 23, 0, 82, DateTimeKind.Utc).AddTicks(9870) },
                    { 1, new DateTime(2021, 11, 19, 10, 23, 0, 82, DateTimeKind.Utc).AddTicks(7342), "https://drive.google.com/uc?export=view&id=1tH7hcl7K2kM4HHC6QVXRdq0LPU8yZwd9", 0, 0, 50, "JS/>NET", new DateTime(2021, 11, 19, 10, 23, 0, 82, DateTimeKind.Utc).AddTicks(8663), new DateTime(2021, 11, 19, 10, 23, 0, 82, DateTimeKind.Utc).AddTicks(8331), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 19, 10, 23, 0, 82, DateTimeKind.Utc).AddTicks(6849) }
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
                    { "19b89a5b-1d5f-4269-a4fb-88a59a70f109", "0f55eb95-7bf2-42d2-8c3b-e65c4be9cdc2" },
                    { "02df9557-7088-4b4b-a64e-eb2da9518574", "3af23481-bb15-4864-a18b-03e1742ded57" },
                    { "b42fb4b7-7fc4-46db-b2e3-abd94bbd5bb3", "4fdd06ee-3a6f-4d63-9c90-57f77a902fa2" },
                    { "ffc86ef7-7d22-4c17-826a-8d54ce32ad6a", "4f3e4b28-1a66-462d-93aa-853f7459474c" }
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
                values: new object[] { 1, new DateTime(2021, 11, 19, 10, 23, 0, 84, DateTimeKind.Utc).AddTicks(9689), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, null, true, "Snow", "-", "USA", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 19, 10, 23, 0, 85, DateTimeKind.Utc).AddTicks(1455), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "InternshipLanguage", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 19, 10, 23, 0, 85, DateTimeKind.Utc).AddTicks(2435), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, null, true, "Granger", "-", "UK", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 19, 10, 23, 0, 85, DateTimeKind.Utc).AddTicks(2439), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 19, 10, 23, 0, 85, DateTimeKind.Utc).AddTicks(6515), "Good knowledge of frameworks, oop, and db", 4, "0f55eb95-7bf2-42d2-8c3b-e65c4be9cdc2" },
                    { 2, 2, new DateTime(2021, 11, 19, 10, 23, 0, 85, DateTimeKind.Utc).AddTicks(7492), "Excellent candidate", 5, "0f55eb95-7bf2-42d2-8c3b-e65c4be9cdc2" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 19, 10, 23, 0, 86, DateTimeKind.Utc).AddTicks(8712), "0f55eb95-7bf2-42d2-8c3b-e65c4be9cdc2" },
                    { 2, 2, new DateTime(2021, 11, 19, 10, 23, 0, 86, DateTimeKind.Utc).AddTicks(9068), "0f55eb95-7bf2-42d2-8c3b-e65c4be9cdc2" }
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
                keyValues: new object[] { "19b89a5b-1d5f-4269-a4fb-88a59a70f109", "0f55eb95-7bf2-42d2-8c3b-e65c4be9cdc2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "02df9557-7088-4b4b-a64e-eb2da9518574", "3af23481-bb15-4864-a18b-03e1742ded57" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ffc86ef7-7d22-4c17-826a-8d54ce32ad6a", "4f3e4b28-1a66-462d-93aa-853f7459474c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b42fb4b7-7fc4-46db-b2e3-abd94bbd5bb3", "4fdd06ee-3a6f-4d63-9c90-57f77a902fa2" });

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
                keyValue: "02df9557-7088-4b4b-a64e-eb2da9518574");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19b89a5b-1d5f-4269-a4fb-88a59a70f109");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b42fb4b7-7fc4-46db-b2e3-abd94bbd5bb3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffc86ef7-7d22-4c17-826a-8d54ce32ad6a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3af23481-bb15-4864-a18b-03e1742ded57");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f3e4b28-1a66-462d-93aa-853f7459474c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fdd06ee-3a6f-4d63-9c90-57f77a902fa2");

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
                keyValue: "0f55eb95-7bf2-42d2-8c3b-e65c4be9cdc2");

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
