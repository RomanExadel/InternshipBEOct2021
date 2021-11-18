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
                    { "6389b06c-e9d8-450d-8e19-cf44c1962ea0", "5fff2eab-ccbf-4941-b658-8cddb235deb8", "Admin", "ADMIN" },
                    { "d8392f3f-0bd7-4924-92a2-a978eb6566a1", "67ca2ff3-981b-451a-a990-e1c87b4a2da6", "Interviewer", "INTERVIEWER" },
                    { "1fc232b3-70e8-4813-bbd3-50384143a997", "2754247c-b14e-4e82-aaea-2f4dfd7b5dd3", "Hr", "HR" },
                    { "cd9f2471-ed35-47fa-9aa0-df67b32d8f9f", "7f5e9fb6-02cb-4717-a08a-c175dece5d9c", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "RoleType", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "764276a5-faa4-4f0f-8f34-17080100f7a1", 0, "fc24b1ea-a759-478b-8ee3-b0aca82b5200", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ALEXANDR", "AQAAAAEAACcQAAAAEKzw14L60O61LOUmMosinkUsMkn8ga5U/NXZpfTBizrFfPyC2RhmCE23yRkHEQPD0g==", "+325659787", false, "PO", 4, "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Alexandr" },
                    { "a4a6cf02-7956-4f1f-8213-da293cb0cf75", 0, "131d85af-378f-4b03-92e9-7f565f20d7e6", "user@example.com", false, true, null, "USER@EXAMPLE.COM", "DASHA", "AQAAAAEAACcQAAAAEPtY14gHbGb9AKQMWXdHcuYqORBHqsjPQVylRpZWQ1x41z2sdizgCCoBkCUTAhupfg==", "+325656787", false, "Front", 3, "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Dasha" },
                    { "b94ed458-8043-4e6c-8591-c0b2c87409a1", 0, "a674f43e-edb4-4991-8c23-c88c388c598c", "max@gmail.com", false, true, null, "MAX@GMAIL.COM", "MAXIM", "AQAAAAEAACcQAAAAEA9dNHgkrlI6r73x0Z3osCR/JfoHwSZpum5VsMwPQhwkwxZGFG5pMrLPUZ321kec+A==", "+125656787", false, "Back", 2, "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Maxim" },
                    { "39f1ac7f-21e4-406f-b17b-dbc45c96a73c", 0, "02db80d0-1142-4baa-9b02-97face8a875f", "li@gmail.com", false, true, null, "LI@GMAIL.COM", "MASHA", "AQAAAAEAACcQAAAAELuUcFAJSuQTpgPqw5MG1IG8h2WVCkembl65p/gRPbPDnq2WyJigyBByUR+Z0TinYg==", "+123656787", false, "BA", 1, "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Masha" }
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
                    { 4, new DateTime(2021, 11, 18, 16, 6, 40, 921, DateTimeKind.Utc).AddTicks(2333), "https://drive.google.com/uc?export=view&id=1t-eClTKmOY4asHZkT6y_vvJNR4SMzKbB", 0, 1, 30, "Angular/>NET", new DateTime(2021, 11, 18, 16, 6, 40, 921, DateTimeKind.Utc).AddTicks(2333), new DateTime(2021, 11, 18, 16, 6, 40, 921, DateTimeKind.Utc).AddTicks(2333), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 18, 16, 6, 40, 921, DateTimeKind.Utc).AddTicks(2333) },
                    { 3, new DateTime(2021, 11, 18, 16, 6, 40, 921, DateTimeKind.Utc).AddTicks(2330), "https://drive.google.com/uc?export=view&id=1kirFfIPPxUbgOFNGNAk4CL6jf_lEOSKc", 0, 1, 30, "GameDev", new DateTime(2021, 11, 18, 16, 6, 40, 921, DateTimeKind.Utc).AddTicks(2330), new DateTime(2021, 11, 18, 16, 6, 40, 921, DateTimeKind.Utc).AddTicks(2330), "OOP, Unity, C#, SQL", new DateTime(2021, 11, 18, 16, 6, 40, 921, DateTimeKind.Utc).AddTicks(2330) },
                    { 2, new DateTime(2021, 11, 18, 16, 6, 40, 921, DateTimeKind.Utc).AddTicks(2324), "https://drive.google.com/uc?export=view&id=1bvaKnWq0XEuldc4zry3qnrFtZoNRtW5R", 0, 0, 30, "QA Automation", new DateTime(2021, 11, 18, 16, 6, 40, 921, DateTimeKind.Utc).AddTicks(2327), new DateTime(2021, 11, 18, 16, 6, 40, 921, DateTimeKind.Utc).AddTicks(2327), "Any programming language, QA basics", new DateTime(2021, 11, 18, 16, 6, 40, 921, DateTimeKind.Utc).AddTicks(2324) },
                    { 1, new DateTime(2021, 11, 18, 16, 6, 40, 920, DateTimeKind.Utc).AddTicks(9292), "https://drive.google.com/uc?export=view&id=1tH7hcl7K2kM4HHC6QVXRdq0LPU8yZwd9", 0, 0, 50, "JS/>NET", new DateTime(2021, 11, 18, 16, 6, 40, 921, DateTimeKind.Utc).AddTicks(843), new DateTime(2021, 11, 18, 16, 6, 40, 921, DateTimeKind.Utc).AddTicks(447), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 18, 16, 6, 40, 920, DateTimeKind.Utc).AddTicks(8857) }
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
                    { "1fc232b3-70e8-4813-bbd3-50384143a997", "39f1ac7f-21e4-406f-b17b-dbc45c96a73c" },
                    { "d8392f3f-0bd7-4924-92a2-a978eb6566a1", "b94ed458-8043-4e6c-8591-c0b2c87409a1" },
                    { "cd9f2471-ed35-47fa-9aa0-df67b32d8f9f", "a4a6cf02-7956-4f1f-8213-da293cb0cf75" },
                    { "6389b06c-e9d8-450d-8e19-cf44c1962ea0", "764276a5-faa4-4f0f-8f34-17080100f7a1" }
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
                values: new object[] { 1, new DateTime(2021, 11, 18, 16, 6, 40, 923, DateTimeKind.Utc).AddTicks(5247), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, true, "Snow", "-", "USA", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 18, 16, 6, 40, 923, DateTimeKind.Utc).AddTicks(7480), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 18, 16, 6, 40, 923, DateTimeKind.Utc).AddTicks(8676), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, true, "Granger", "-", "UK", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 18, 16, 6, 40, 923, DateTimeKind.Utc).AddTicks(8679), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 18, 16, 6, 40, 924, DateTimeKind.Utc).AddTicks(3525), "Good knowledge of frameworks, oop, and db", 4, "39f1ac7f-21e4-406f-b17b-dbc45c96a73c" },
                    { 2, 2, new DateTime(2021, 11, 18, 16, 6, 40, 924, DateTimeKind.Utc).AddTicks(4700), "Excellent candidate", 5, "39f1ac7f-21e4-406f-b17b-dbc45c96a73c" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 18, 16, 6, 40, 925, DateTimeKind.Utc).AddTicks(7515), "39f1ac7f-21e4-406f-b17b-dbc45c96a73c" },
                    { 2, 2, new DateTime(2021, 11, 18, 16, 6, 40, 925, DateTimeKind.Utc).AddTicks(7923), "39f1ac7f-21e4-406f-b17b-dbc45c96a73c" }
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
                keyValues: new object[] { "1fc232b3-70e8-4813-bbd3-50384143a997", "39f1ac7f-21e4-406f-b17b-dbc45c96a73c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6389b06c-e9d8-450d-8e19-cf44c1962ea0", "764276a5-faa4-4f0f-8f34-17080100f7a1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cd9f2471-ed35-47fa-9aa0-df67b32d8f9f", "a4a6cf02-7956-4f1f-8213-da293cb0cf75" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d8392f3f-0bd7-4924-92a2-a978eb6566a1", "b94ed458-8043-4e6c-8591-c0b2c87409a1" });

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
                keyValue: "1fc232b3-70e8-4813-bbd3-50384143a997");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6389b06c-e9d8-450d-8e19-cf44c1962ea0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd9f2471-ed35-47fa-9aa0-df67b32d8f9f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8392f3f-0bd7-4924-92a2-a978eb6566a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "764276a5-faa4-4f0f-8f34-17080100f7a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4a6cf02-7956-4f1f-8213-da293cb0cf75");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b94ed458-8043-4e6c-8591-c0b2c87409a1");

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
                keyValue: "39f1ac7f-21e4-406f-b17b-dbc45c96a73c");

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
