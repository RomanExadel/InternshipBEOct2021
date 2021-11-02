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
                    { "8867931e-0935-4f1c-aae4-2e089b63e3d4", "5c767cca-8807-4f32-bdb9-7515fb0deef2", "Hr", "HR" },
                    { "91f58c84-edc3-40c3-ba3a-656ef4006b61", "c79c202b-b2fe-4393-bcd1-0e002fed6758", "Interviewer", "INTERVIEWER" },
                    { "732330ec-3d9a-4d5d-a827-6d0210a55057", "3f2a75fb-1b23-46e0-acf0-799215ed46fa", "Manager", "MANAGER" },
                    { "bac1ae0b-549d-4d56-95ed-073579fdac71", "51687882-6c7e-4118-b486-466ab4a6d83c", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BestContactTime", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1cf52911-1112-4822-8d68-f9de32ae9fdf", 0, new DateTime(2021, 11, 2, 11, 15, 42, 676, DateTimeKind.Utc).AddTicks(7441), "746a82b5-4e13-4320-85db-015a5bdf9b16", "li@gmail.com", false, true, null, "LI@GMAIL.COM", "MASHA", "AQAAAAEAACcQAAAAECR7kmzxweS45wFBKBtarvEYhQBfGVbwNC76r+eXhaXPlDWwYiZwTFnD7z+dJE1ktg==", "+123656787", false, "BA", "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Masha" },
                    { "f80b8098-7095-46d0-b611-7c8ee7b449f1", 0, new DateTime(2021, 11, 2, 11, 15, 42, 684, DateTimeKind.Utc).AddTicks(55), "ffede3a1-a7b3-4792-a19b-8c6968c7cb28", "max@gmail.com", false, true, null, "MAX@GMAIL.COM", "MAXIM", "AQAAAAEAACcQAAAAEJ6KtsM4FEdY1duyfO0LvartIpx/PCq1CsK46Ma0gjbvac001OXMVlkVfW9qVr/M2Q==", "+125656787", false, "Back", "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Maxim" },
                    { "57c6ea1b-b595-4ef2-863d-b98c4153e4e1", 0, new DateTime(2021, 11, 2, 11, 15, 42, 685, DateTimeKind.Utc).AddTicks(6080), "ea0434d3-55e3-4192-b9b9-d4f6e0b89aa5", "user@example.com", false, true, null, "USER@EXAMPLE.COM", "DASHA", "AQAAAAEAACcQAAAAENFXDbtYdxccZfx7kmv4/Mn6c6cujcY5UBhHajeMoe79ZtHjYMow3Th8nP7NT5D6uA==", "+325656787", false, "Front", "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Dasha" },
                    { "583f0989-76e0-412c-ab42-28cd38549341", 0, new DateTime(2021, 11, 2, 11, 15, 42, 687, DateTimeKind.Utc).AddTicks(1412), "0d1cb978-ee8a-4575-a33a-cf00a659a02a", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ALEXANDR", "AQAAAAEAACcQAAAAECaV2c6Jz6zsrzotKU6ilVjW0PMZZEkJzwcGgq8Qc3Bgr7oyLWRRyK1CGlRNTnS0YA==", "+325659787", false, "PO", "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Alexandr" }
                });

            migrationBuilder.InsertData(
                table: "Internships",
                columns: new[] { "Id", "EndDate", "LanguageType", "MaxCandidateCount", "Name", "RegistrationFinishDate", "RegistrationStartDate", "Requirements", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 2, 11, 15, 42, 690, DateTimeKind.Utc).AddTicks(1076), 0, 50, "JS/>NET", new DateTime(2021, 11, 2, 11, 15, 42, 690, DateTimeKind.Utc).AddTicks(3150), new DateTime(2021, 11, 2, 11, 15, 42, 690, DateTimeKind.Utc).AddTicks(2625), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 2, 11, 15, 42, 690, DateTimeKind.Utc).AddTicks(475) },
                    { 2, new DateTime(2021, 11, 2, 11, 15, 42, 690, DateTimeKind.Utc).AddTicks(4163), 0, 30, "QA Automation", new DateTime(2021, 11, 2, 11, 15, 42, 690, DateTimeKind.Utc).AddTicks(4167), new DateTime(2021, 11, 2, 11, 15, 42, 690, DateTimeKind.Utc).AddTicks(4166), "Any programming language, QA basics", new DateTime(2021, 11, 2, 11, 15, 42, 690, DateTimeKind.Utc).AddTicks(4161) }
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
                    { "8867931e-0935-4f1c-aae4-2e089b63e3d4", "1cf52911-1112-4822-8d68-f9de32ae9fdf" },
                    { "91f58c84-edc3-40c3-ba3a-656ef4006b61", "f80b8098-7095-46d0-b611-7c8ee7b449f1" },
                    { "732330ec-3d9a-4d5d-a827-6d0210a55057", "57c6ea1b-b595-4ef2-863d-b98c4153e4e1" },
                    { "bac1ae0b-549d-4d56-95ed-073579fdac71", "583f0989-76e0-412c-ab42-28cd38549341" }
                });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 2, 11, 15, 42, 692, DateTimeKind.Utc).AddTicks(7295), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, true, "Snow", "-", "Arizona", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 2, 11, 15, 42, 693, DateTimeKind.Utc).AddTicks(239), "live:j.snow", 1, 0, null, 4 },
                    { 2, new DateTime(2021, 11, 2, 11, 15, 42, 693, DateTimeKind.Utc).AddTicks(1231), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, true, "Granger", "-", "London", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 2, 11, 15, 42, 693, DateTimeKind.Utc).AddTicks(1236), "live:h.granger", 5, 0, null, 4 }
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
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 2, 11, 15, 42, 693, DateTimeKind.Utc).AddTicks(7808), "Good knowledge of frameworks, oop, and db", 4, "1cf52911-1112-4822-8d68-f9de32ae9fdf" },
                    { 2, 2, new DateTime(2021, 11, 2, 11, 15, 42, 693, DateTimeKind.Utc).AddTicks(9373), "Excellent candidate", 5, "1cf52911-1112-4822-8d68-f9de32ae9fdf" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 2, 11, 15, 42, 695, DateTimeKind.Utc).AddTicks(7553), "1cf52911-1112-4822-8d68-f9de32ae9fdf" },
                    { 2, 2, new DateTime(2021, 11, 2, 11, 15, 42, 695, DateTimeKind.Utc).AddTicks(8118), "1cf52911-1112-4822-8d68-f9de32ae9fdf" }
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
                keyValues: new object[] { "8867931e-0935-4f1c-aae4-2e089b63e3d4", "1cf52911-1112-4822-8d68-f9de32ae9fdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "732330ec-3d9a-4d5d-a827-6d0210a55057", "57c6ea1b-b595-4ef2-863d-b98c4153e4e1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bac1ae0b-549d-4d56-95ed-073579fdac71", "583f0989-76e0-412c-ab42-28cd38549341" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91f58c84-edc3-40c3-ba3a-656ef4006b61", "f80b8098-7095-46d0-b611-7c8ee7b449f1" });

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
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "732330ec-3d9a-4d5d-a827-6d0210a55057");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8867931e-0935-4f1c-aae4-2e089b63e3d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91f58c84-edc3-40c3-ba3a-656ef4006b61");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bac1ae0b-549d-4d56-95ed-073579fdac71");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57c6ea1b-b595-4ef2-863d-b98c4153e4e1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "583f0989-76e0-412c-ab42-28cd38549341");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f80b8098-7095-46d0-b611-7c8ee7b449f1");

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
                keyValue: "1cf52911-1112-4822-8d68-f9de32ae9fdf");

            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Candidates",
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
