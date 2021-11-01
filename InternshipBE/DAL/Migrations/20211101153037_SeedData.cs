using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BestContactTime", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3827e25d-8989-4881-9f25-807d14878c1b", 0, new DateTime(2021, 11, 1, 15, 30, 36, 758, DateTimeKind.Utc).AddTicks(8404), "d722e70d-72fc-4f08-8fdc-afec3cef3c4f", "li@gmail.com", false, true, null, "LI@GMAIL.COM", "MASHA", "AQAAAAEAACcQAAAAEFrfBeLl7wG60Syi2unYkVUM4kp/0A8RAZdc51M8e/5GokOv0qDZF+aGBSVaSV6vag==", "+123656787", false, "BA", "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Masha" },
                    { "5516d40a-40bf-482c-8575-34a18478ac89", 0, new DateTime(2021, 11, 1, 15, 30, 36, 758, DateTimeKind.Utc).AddTicks(9788), "2c39a495-1b10-49f9-926c-a40d078418ad", "max@gmail.com", false, true, null, "MAX@GMAIL.COM", "MAXIM", "AQAAAAEAACcQAAAAEA/2Sy0cS1B+wbGk2R/Llrp6iuFzZjbJGu1Egoj2MYPPMaowQUgECV4Teg/K5xy/fg==", "+125656787", false, "Back", "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Maxim" },
                    { "57f2fe4e-64af-40b4-a279-5af5f1db8a8a", 0, new DateTime(2021, 11, 1, 15, 30, 36, 758, DateTimeKind.Utc).AddTicks(9822), "09fb73b8-aab6-4ff4-a27b-4426a8b73570", "user@example.com", false, true, null, "USER@EXAMPLE.COM", "DASHA", "AQAAAAEAACcQAAAAEEVFxbsq/jnZ4avRoKtiCKb4QPzojCZDr6y9N3exNngtHExLdISgHDxhvprupVr9iQ==", "+325656787", false, "Front", "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Dasha" },
                    { "ff8a8331-c30a-4a6c-8860-0b49c533aa2c", 0, new DateTime(2021, 11, 1, 15, 30, 36, 758, DateTimeKind.Utc).AddTicks(9839), "66f70ef0-1083-48a6-9c14-d54557737744", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ALEXANDR", "AQAAAAEAACcQAAAAEK+m9ZBEt0HpxkxRafiiKjUsm1GShqzdyFWgzC1tGIApjSTzcLx49pKc1wIKrgN0tg==", "+325659787", false, "PO", "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Alexandr" }
                });

            migrationBuilder.InsertData(
                table: "Internships",
                columns: new[] { "Id", "EndDate", "LanguageType", "MaxCandidateCount", "Name", "RegistrationFinishDate", "RegistrationStartDate", "Requirements", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 1, 15, 30, 36, 761, DateTimeKind.Utc).AddTicks(4053), 0, 50, "JS/>NET", new DateTime(2021, 11, 1, 15, 30, 36, 761, DateTimeKind.Utc).AddTicks(6540), new DateTime(2021, 11, 1, 15, 30, 36, 761, DateTimeKind.Utc).AddTicks(5994), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 1, 15, 30, 36, 761, DateTimeKind.Utc).AddTicks(3283) },
                    { 2, new DateTime(2021, 11, 1, 15, 30, 36, 761, DateTimeKind.Utc).AddTicks(7558), 0, 30, "QA Automation", new DateTime(2021, 11, 1, 15, 30, 36, 761, DateTimeKind.Utc).AddTicks(7562), new DateTime(2021, 11, 1, 15, 30, 36, 761, DateTimeKind.Utc).AddTicks(7561), "Any programming language, QA basics", new DateTime(2021, 11, 1, 15, 30, 36, 761, DateTimeKind.Utc).AddTicks(7556) }
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
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 1, 15, 30, 36, 764, DateTimeKind.Utc).AddTicks(665), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, true, "Snow", "-", "Arizona", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 1, 15, 30, 36, 764, DateTimeKind.Utc).AddTicks(3770), "live:j.snow", 1, 0, null, 4 },
                    { 2, new DateTime(2021, 11, 1, 15, 30, 36, 764, DateTimeKind.Utc).AddTicks(4778), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, true, "Granger", "-", "London", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 1, 15, 30, 36, 764, DateTimeKind.Utc).AddTicks(4781), "live:h.granger", 5, 0, null, 4 }
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
                    { 1, 1, new DateTime(2021, 11, 1, 15, 30, 36, 765, DateTimeKind.Utc).AddTicks(4717), "Good knowledge of frameworks, oop, and db", 4, "3827e25d-8989-4881-9f25-807d14878c1b" },
                    { 2, 2, new DateTime(2021, 11, 1, 15, 30, 36, 765, DateTimeKind.Utc).AddTicks(7392), "Excellent candidate", 5, "3827e25d-8989-4881-9f25-807d14878c1b" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 1, 15, 30, 36, 768, DateTimeKind.Utc).AddTicks(3643), "3827e25d-8989-4881-9f25-807d14878c1b" },
                    { 2, 2, new DateTime(2021, 11, 1, 15, 30, 36, 768, DateTimeKind.Utc).AddTicks(4401), "3827e25d-8989-4881-9f25-807d14878c1b" }
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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5516d40a-40bf-482c-8575-34a18478ac89");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57f2fe4e-64af-40b4-a279-5af5f1db8a8a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff8a8331-c30a-4a6c-8860-0b49c533aa2c");

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
                keyValue: "3827e25d-8989-4881-9f25-807d14878c1b");

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
