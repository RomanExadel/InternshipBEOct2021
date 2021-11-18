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
                    { "6fae81b4-7c58-44cf-9a31-c2454ce98283", "7ed64f20-699b-4940-bb51-73c33fa492ef", "Admin", "ADMIN" },
                    { "51ae656e-ca29-42e2-a639-06e1e6bb8443", "dfb80d9e-1aa8-4d10-8c8b-0234dcdcf58c", "Interviewer", "INTERVIEWER" },
                    { "3ec26d6f-99c8-4b47-8247-4193e6403e2a", "f9b42900-3edc-4c14-9ea0-53cd15e1b1e4", "Hr", "HR" },
                    { "b93162a7-7a16-4c2b-872b-0106444cbbc3", "da3dffa5-923a-42d6-b95e-007ab3382f55", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "RoleType", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a4f8a920-c29e-4b7f-8dc8-5164bde5bf78", 0, "dd59b706-080a-4d9a-9af8-46910457e85c", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ALEXANDR", "AQAAAAEAACcQAAAAEJBFcG3s/0X7aD29Y3Y0Ei3AXDvfxYVEGUc8/IKJttJmaClSixXyuaFPkaKw+9elmQ==", "+325659787", false, "PO", 4, "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Alexandr" },
                    { "f92f8a61-5ddd-4e2b-8226-2fe2b53869f7", 0, "59c21d0d-9b8d-46cc-a31d-5369cb103381", "user@example.com", false, true, null, "USER@EXAMPLE.COM", "DASHA", "AQAAAAEAACcQAAAAEO51w21Ahsz67NlygVd0wvKPrjllZbuEPBk9XqxaU3Pw85Fdm6qkEPqw511Ulf5jcg==", "+325656787", false, "Front", 3, "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Dasha" },
                    { "80ca2ca5-7b81-4ffd-aaa6-7ac71f6078ba", 0, "610d2b70-947e-4973-b8f3-0a41a4f9ff69", "max@gmail.com", false, true, null, "MAX@GMAIL.COM", "MAXIM", "AQAAAAEAACcQAAAAEHERjUNTwVhyAN9IqcUMpUxulpd1jmfJwMDZN6n67q/56cu5crizhEU2b4MU2qYQqQ==", "+125656787", false, "Back", 2, "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Maxim" },
                    { "cacb6ec0-d46a-4560-8ae1-e7e813e48435", 0, "8f0909c6-6abe-4bbe-b7f9-e5eb32f9cbe0", "li@gmail.com", false, true, null, "LI@GMAIL.COM", "MASHA", "AQAAAAEAACcQAAAAEAlczfPSZ1tg5vaxky0aj09emZ8AyP43EtlgZ7h9lx/hgEwPiGHxlMYqIuWOBwjTTQ==", "+123656787", false, "BA", 1, "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Masha" }
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
                    { 3, 2 },
                    { 4, 3 },
                    { 1, 0 },
                    { 6, 5 },
                    { 2, 1 },
                    { 5, 4 }
                });

            migrationBuilder.InsertData(
                table: "Internships",
                columns: new[] { "Id", "EndDate", "ImageLink", "InternshipStatusType", "LanguageType", "MaxCandidateCount", "Name", "RegistrationFinishDate", "RegistrationStartDate", "Requirements", "StartDate" },
                values: new object[,]
                {
                    { 4, new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(6956), "https://drive.google.com/file/d/1t-eClTKmOY4asHZkT6y_vvJNR4SMzKbB/view?usp=sharing", 0, 1, 30, "Angular/>NET", new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(6958), new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(6957), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(6955) },
                    { 3, new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(6951), "https://drive.google.com/file/d/1kirFfIPPxUbgOFNGNAk4CL6jf_lEOSKc/view?usp=sharing", 0, 1, 30, "GameDev", new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(6953), new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(6952), "OOP, Unity, C#, SQL", new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(6950) },
                    { 2, new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(6945), "https://drive.google.com/file/d/1bvaKnWq0XEuldc4zry3qnrFtZoNRtW5R/view?usp=sharing", 0, 0, 30, "QA Automation", new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(6948), new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(6947), "Any programming language, QA basics", new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(6942) },
                    { 1, new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(4364), "https://drive.google.com/file/d/1tH7hcl7K2kM4HHC6QVXRdq0LPU8yZwd9/view?usp=sharing", 0, 0, 50, "JS/>NET", new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(5671), new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(5338), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(3949) }
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
                    { "3ec26d6f-99c8-4b47-8247-4193e6403e2a", "cacb6ec0-d46a-4560-8ae1-e7e813e48435" },
                    { "51ae656e-ca29-42e2-a639-06e1e6bb8443", "80ca2ca5-7b81-4ffd-aaa6-7ac71f6078ba" },
                    { "b93162a7-7a16-4c2b-872b-0106444cbbc3", "f92f8a61-5ddd-4e2b-8226-2fe2b53869f7" },
                    { "6fae81b4-7c58-44cf-9a31-c2454ce98283", "a4f8a920-c29e-4b7f-8dc8-5164bde5bf78" }
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
                values: new object[] { 1, new DateTime(2021, 11, 18, 12, 39, 58, 396, DateTimeKind.Utc).AddTicks(6471), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, null, true, "Snow", "-", "Arizona", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 18, 12, 39, 58, 396, DateTimeKind.Utc).AddTicks(8246), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "InternshipLanguage", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 18, 12, 39, 58, 396, DateTimeKind.Utc).AddTicks(9223), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, null, true, "Granger", "-", "London", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 18, 12, 39, 58, 396, DateTimeKind.Utc).AddTicks(9228), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 18, 12, 39, 58, 397, DateTimeKind.Utc).AddTicks(3368), "Good knowledge of frameworks, oop, and db", 4, "cacb6ec0-d46a-4560-8ae1-e7e813e48435" },
                    { 2, 2, new DateTime(2021, 11, 18, 12, 39, 58, 397, DateTimeKind.Utc).AddTicks(4353), "Excellent candidate", 5, "cacb6ec0-d46a-4560-8ae1-e7e813e48435" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 18, 12, 39, 58, 398, DateTimeKind.Utc).AddTicks(7841), "cacb6ec0-d46a-4560-8ae1-e7e813e48435" },
                    { 2, 2, new DateTime(2021, 11, 18, 12, 39, 58, 398, DateTimeKind.Utc).AddTicks(8237), "cacb6ec0-d46a-4560-8ae1-e7e813e48435" }
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
                keyValues: new object[] { "51ae656e-ca29-42e2-a639-06e1e6bb8443", "80ca2ca5-7b81-4ffd-aaa6-7ac71f6078ba" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6fae81b4-7c58-44cf-9a31-c2454ce98283", "a4f8a920-c29e-4b7f-8dc8-5164bde5bf78" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3ec26d6f-99c8-4b47-8247-4193e6403e2a", "cacb6ec0-d46a-4560-8ae1-e7e813e48435" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b93162a7-7a16-4c2b-872b-0106444cbbc3", "f92f8a61-5ddd-4e2b-8226-2fe2b53869f7" });

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
                keyValue: "3ec26d6f-99c8-4b47-8247-4193e6403e2a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51ae656e-ca29-42e2-a639-06e1e6bb8443");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fae81b4-7c58-44cf-9a31-c2454ce98283");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b93162a7-7a16-4c2b-872b-0106444cbbc3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80ca2ca5-7b81-4ffd-aaa6-7ac71f6078ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4f8a920-c29e-4b7f-8dc8-5164bde5bf78");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f92f8a61-5ddd-4e2b-8226-2fe2b53869f7");

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
                keyValue: "cacb6ec0-d46a-4560-8ae1-e7e813e48435");

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
