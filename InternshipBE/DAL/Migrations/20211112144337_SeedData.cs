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
                    { "5d7716da-f63a-419e-9f81-53c012a541d4", "680929d4-db26-4930-9f6b-bc16c64d3b3c", "Admin", "ADMIN" },
                    { "81133071-ab4c-460b-8b78-f120cf7d5676", "77cb610d-13a1-467d-84f5-6d941896463f", "Interviewer", "INTERVIEWER" },
                    { "b2751d8a-2350-4993-8751-5fb0668c1916", "3b225d74-3ce9-478a-b5e1-61f16deaca8b", "Hr", "HR" },
                    { "af99cfb5-3931-46ed-8d4a-93bda59aba43", "b04c024c-6f07-4980-a6b4-6e597bfe64c8", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "RoleType", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c13c6fc1-e9f8-4c9a-9c9f-7dd9c4c3f85c", 0, "a7f5abf9-8132-49b2-9c5d-3ff3a5d93012", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ALEXANDR", "AQAAAAEAACcQAAAAEOWgjLU3X10TNpDVhLYIkuJ0Eq64VkdlRRZAoSqeXLnSj+dBkze2lO2co0tSb7JI6g==", "+325659787", false, "PO", 4, "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Alexandr" },
                    { "b6603211-f331-4f38-a846-41804075c226", 0, "96ee6ae0-526f-4c7d-8c61-06cf35fab818", "user@example.com", false, true, null, "USER@EXAMPLE.COM", "DASHA", "AQAAAAEAACcQAAAAEM3k9mh/OkqNhAuqQNZ5B+cj/HrnsPAr0TMiTZ1q76EJBVTlak15CtVLf1Hh99pQ+w==", "+325656787", false, "Front", 3, "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Dasha" },
                    { "b1b72736-53e4-41e3-874f-ee180adddd8b", 0, "a8b47c1b-f3f5-40bd-b4fa-984b5bcc0486", "max@gmail.com", false, true, null, "MAX@GMAIL.COM", "MAXIM", "AQAAAAEAACcQAAAAEAwpHbd9uYUVkdJm7Hz4CPInnB+OTiR2id15tNI7ILW53BhQlhDJj9MVMW6RYz2yGA==", "+125656787", false, "Back", 2, "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Maxim" },
                    { "7c78aaf2-138c-4199-8168-ff0c0312ace6", 0, "51ece1b8-16e3-4bd5-8221-41d2f944fc0a", "li@gmail.com", false, true, null, "LI@GMAIL.COM", "MASHA", "AQAAAAEAACcQAAAAELHVdcE2PUqSKt28fk8DWgYiXreNbQifAdHFQN5yEe3fCio+LKgoEFtHrd2te1H8kw==", "+123656787", false, "BA", 1, "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Masha" }
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
                columns: new[] { "Id", "TechnologyStackType" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 }
                });

            migrationBuilder.InsertData(
                table: "Internships",
                columns: new[] { "Id", "EndDate", "ImageLink", "InternshipStatusType", "LanguageType", "MaxCandidateCount", "Name", "RegistrationFinishDate", "RegistrationStartDate", "Requirements", "StartDate" },
                values: new object[,]
                {
                    { 4, new DateTime(2021, 11, 12, 14, 43, 36, 264, DateTimeKind.Utc).AddTicks(6182), "https://drive.google.com/file/d/1t-eClTKmOY4asHZkT6y_vvJNR4SMzKbB/view?usp=sharing", 0, 1, 30, "Angular/>NET", new DateTime(2021, 11, 12, 14, 43, 36, 264, DateTimeKind.Utc).AddTicks(6184), new DateTime(2021, 11, 12, 14, 43, 36, 264, DateTimeKind.Utc).AddTicks(6183), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 12, 14, 43, 36, 264, DateTimeKind.Utc).AddTicks(6181) },
                    { 3, new DateTime(2021, 11, 12, 14, 43, 36, 264, DateTimeKind.Utc).AddTicks(6178), "https://drive.google.com/file/d/1kirFfIPPxUbgOFNGNAk4CL6jf_lEOSKc/view?usp=sharing", 0, 1, 30, "GameDev", new DateTime(2021, 11, 12, 14, 43, 36, 264, DateTimeKind.Utc).AddTicks(6180), new DateTime(2021, 11, 12, 14, 43, 36, 264, DateTimeKind.Utc).AddTicks(6179), "OOP, Unity, C#, SQL", new DateTime(2021, 11, 12, 14, 43, 36, 264, DateTimeKind.Utc).AddTicks(6177) },
                    { 2, new DateTime(2021, 11, 12, 14, 43, 36, 264, DateTimeKind.Utc).AddTicks(6172), "https://drive.google.com/file/d/1bvaKnWq0XEuldc4zry3qnrFtZoNRtW5R/view?usp=sharing", 0, 0, 30, "QA Automation", new DateTime(2021, 11, 12, 14, 43, 36, 264, DateTimeKind.Utc).AddTicks(6175), new DateTime(2021, 11, 12, 14, 43, 36, 264, DateTimeKind.Utc).AddTicks(6173), "Any programming language, QA basics", new DateTime(2021, 11, 12, 14, 43, 36, 264, DateTimeKind.Utc).AddTicks(6169) },
                    { 1, new DateTime(2021, 11, 12, 14, 43, 36, 264, DateTimeKind.Utc).AddTicks(2235), "https://drive.google.com/file/d/1tH7hcl7K2kM4HHC6QVXRdq0LPU8yZwd9/view?usp=sharing", 0, 0, 50, "JS/>NET", new DateTime(2021, 11, 12, 14, 43, 36, 264, DateTimeKind.Utc).AddTicks(4234), new DateTime(2021, 11, 12, 14, 43, 36, 264, DateTimeKind.Utc).AddTicks(3723), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 12, 14, 43, 36, 264, DateTimeKind.Utc).AddTicks(1680) }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "IsHardSkill", "Name", "StackType" },
                values: new object[,]
                {
                    { 2, true, "Java", 5 },
                    { 1, true, "OOP", 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b2751d8a-2350-4993-8751-5fb0668c1916", "7c78aaf2-138c-4199-8168-ff0c0312ace6" },
                    { "81133071-ab4c-460b-8b78-f120cf7d5676", "b1b72736-53e4-41e3-874f-ee180adddd8b" },
                    { "af99cfb5-3931-46ed-8d4a-93bda59aba43", "b6603211-f331-4f38-a846-41804075c226" },
                    { "5d7716da-f63a-419e-9f81-53c012a541d4", "c13c6fc1-e9f8-4c9a-9c9f-7dd9c4c3f85c" }
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
                values: new object[] { 1, new DateTime(2021, 11, 12, 14, 43, 36, 266, DateTimeKind.Utc).AddTicks(8440), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, true, "Snow", "-", "Arizona", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 12, 14, 43, 36, 267, DateTimeKind.Utc).AddTicks(1390), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 12, 14, 43, 36, 267, DateTimeKind.Utc).AddTicks(2961), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, true, "Granger", "-", "London", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 12, 14, 43, 36, 267, DateTimeKind.Utc).AddTicks(2965), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 12, 14, 43, 36, 267, DateTimeKind.Utc).AddTicks(7872), "Good knowledge of frameworks, oop, and db", 4, "7c78aaf2-138c-4199-8168-ff0c0312ace6" },
                    { 2, 2, new DateTime(2021, 11, 12, 14, 43, 36, 267, DateTimeKind.Utc).AddTicks(9334), "Excellent candidate", 5, "7c78aaf2-138c-4199-8168-ff0c0312ace6" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 12, 14, 43, 36, 269, DateTimeKind.Utc).AddTicks(2648), "7c78aaf2-138c-4199-8168-ff0c0312ace6" },
                    { 2, 2, new DateTime(2021, 11, 12, 14, 43, 36, 269, DateTimeKind.Utc).AddTicks(3180), "7c78aaf2-138c-4199-8168-ff0c0312ace6" }
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
                keyValues: new object[] { "b2751d8a-2350-4993-8751-5fb0668c1916", "7c78aaf2-138c-4199-8168-ff0c0312ace6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "81133071-ab4c-460b-8b78-f120cf7d5676", "b1b72736-53e4-41e3-874f-ee180adddd8b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "af99cfb5-3931-46ed-8d4a-93bda59aba43", "b6603211-f331-4f38-a846-41804075c226" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5d7716da-f63a-419e-9f81-53c012a541d4", "c13c6fc1-e9f8-4c9a-9c9f-7dd9c4c3f85c" });

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
                keyValue: "5d7716da-f63a-419e-9f81-53c012a541d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81133071-ab4c-460b-8b78-f120cf7d5676");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af99cfb5-3931-46ed-8d4a-93bda59aba43");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2751d8a-2350-4993-8751-5fb0668c1916");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b72736-53e4-41e3-874f-ee180adddd8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6603211-f331-4f38-a846-41804075c226");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c13c6fc1-e9f8-4c9a-9c9f-7dd9c4c3f85c");

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
                keyValue: "7c78aaf2-138c-4199-8168-ff0c0312ace6");

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
