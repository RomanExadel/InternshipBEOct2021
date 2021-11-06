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
                    { "bb657f97-a307-4b1a-b4e6-d4998188c016", "229340ce-3c4e-410e-86ff-6af9c9ce1951", "Admin", "ADMIN" },
                    { "336d4223-7ab3-4645-8483-745111accb64", "e38938d1-1d3d-436a-914a-fd7dd0398d25", "Interviewer", "INTERVIEWER" },
                    { "20b10174-ca20-4deb-9947-35e50b135ea3", "39e55a08-cf06-4119-be9d-dc7f8d265002", "Hr", "HR" },
                    { "7189f2c9-a26c-4a0a-8ed7-46d01d0f34cb", "b395fe31-6c18-4e25-ac0c-8f0603f8eed7", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BestContactTime", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "RoleType", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3a8c6327-610c-46a0-bf2f-3fd7455fa3bb", 0, new DateTime(2021, 11, 6, 11, 50, 1, 85, DateTimeKind.Utc).AddTicks(1143), "7e2f53c0-254e-4de0-bec0-943daf6315d5", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ALEXANDR", "AQAAAAEAACcQAAAAEIvVh+D57nVvvM9VXzWLrT/8ph0a/jCu9GOwLACSuPw/NNOzYWCRmerRkWRAGHe18g==", "+325659787", false, "PO", 4, "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Alexandr" },
                    { "5e6598e7-2900-491c-ba9e-9cc453470b63", 0, new DateTime(2021, 11, 6, 11, 50, 1, 76, DateTimeKind.Utc).AddTicks(9711), "72f7a0cb-47ae-437f-9a57-6703af96a46a", "user@example.com", false, true, null, "USER@EXAMPLE.COM", "DASHA", "AQAAAAEAACcQAAAAEDahkVsD17amFWnNa2GebBUBBD/irKOlnh9NXlKL8sZq7EL5ToBp0OhEAHEaMWC1+g==", "+325656787", false, "Front", 3, "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Dasha" },
                    { "3f0c129e-6c9c-4f7e-abad-393f2dddad8d", 0, new DateTime(2021, 11, 6, 11, 50, 1, 68, DateTimeKind.Utc).AddTicks(8761), "29c3a715-4a59-42d8-a5b2-00b0b463a751", "max@gmail.com", false, true, null, "MAX@GMAIL.COM", "MAXIM", "AQAAAAEAACcQAAAAEG/sCX6+ui14DDs9U8rMt3iPhGpPCIRIohgjzeoQBwCP3VPIGGM/BCnmExaPqs24Sw==", "+125656787", false, "Back", 2, "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Maxim" },
                    { "5e5fca25-1ce8-43a9-b9a6-a335be62c7e8", 0, new DateTime(2021, 11, 6, 11, 50, 1, 51, DateTimeKind.Utc).AddTicks(9919), "1046d6ad-3e8a-4aff-a664-4af7c2890c69", "li@gmail.com", false, true, null, "LI@GMAIL.COM", "MASHA", "AQAAAAEAACcQAAAAEHtpv9JVSMibX8InjyIfnjzfS3hkzb1/4TXxDwRmKgvvDWW3YsQdswutz/w2ynJAiQ==", "+123656787", false, "BA", 1, "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Masha" }
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
                table: "Internships",
                columns: new[] { "Id", "EndDate", "ImageLink", "InternshipStatusType", "LanguageType", "MaxCandidateCount", "Name", "RegistrationFinishDate", "RegistrationStartDate", "Requirements", "StartDate" },
                values: new object[,]
                {
                    { 4, new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(9388), "image/link/2", 0, 1, 30, "Angular/>NET", new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(9391), new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(9391), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(9388) },
                    { 3, new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(9385), "image/link/2", 0, 1, 30, "GameDev", new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(9388), new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(9388), "OOP, Unity, C#, SQL", new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(9385) },
                    { 2, new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(9379), "image/link/2", 0, 0, 30, "QA Automation", new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(9382), new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(9382), "Any programming language, QA basics", new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(9379) },
                    { 1, new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(6058), "image/link/1", 0, 0, 50, "JS/>NET", new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(7910), new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(7513), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(5620) }
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
                    { "20b10174-ca20-4deb-9947-35e50b135ea3", "5e5fca25-1ce8-43a9-b9a6-a335be62c7e8" },
                    { "336d4223-7ab3-4645-8483-745111accb64", "3f0c129e-6c9c-4f7e-abad-393f2dddad8d" },
                    { "7189f2c9-a26c-4a0a-8ed7-46d01d0f34cb", "5e6598e7-2900-491c-ba9e-9cc453470b63" },
                    { "bb657f97-a307-4b1a-b4e6-d4998188c016", "3a8c6327-610c-46a0-bf2f-3fd7455fa3bb" }
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
                values: new object[] { 1, new DateTime(2021, 11, 6, 11, 50, 1, 97, DateTimeKind.Utc).AddTicks(773), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, true, "Snow", "-", "Arizona", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 6, 11, 50, 1, 97, DateTimeKind.Utc).AddTicks(2931), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 6, 11, 50, 1, 97, DateTimeKind.Utc).AddTicks(4117), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, true, "Granger", "-", "London", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 6, 11, 50, 1, 97, DateTimeKind.Utc).AddTicks(4120), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 6, 11, 50, 1, 97, DateTimeKind.Utc).AddTicks(8996), "Good knowledge of frameworks, oop, and db", 4, "5e5fca25-1ce8-43a9-b9a6-a335be62c7e8" },
                    { 2, 2, new DateTime(2021, 11, 6, 11, 50, 1, 98, DateTimeKind.Utc).AddTicks(192), "Excellent candidate", 5, "5e5fca25-1ce8-43a9-b9a6-a335be62c7e8" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 6, 11, 50, 1, 99, DateTimeKind.Utc).AddTicks(2957), "5e5fca25-1ce8-43a9-b9a6-a335be62c7e8" },
                    { 2, 2, new DateTime(2021, 11, 6, 11, 50, 1, 99, DateTimeKind.Utc).AddTicks(3359), "5e5fca25-1ce8-43a9-b9a6-a335be62c7e8" }
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
                keyValues: new object[] { "bb657f97-a307-4b1a-b4e6-d4998188c016", "3a8c6327-610c-46a0-bf2f-3fd7455fa3bb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "336d4223-7ab3-4645-8483-745111accb64", "3f0c129e-6c9c-4f7e-abad-393f2dddad8d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "20b10174-ca20-4deb-9947-35e50b135ea3", "5e5fca25-1ce8-43a9-b9a6-a335be62c7e8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7189f2c9-a26c-4a0a-8ed7-46d01d0f34cb", "5e6598e7-2900-491c-ba9e-9cc453470b63" });

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
                keyValue: "20b10174-ca20-4deb-9947-35e50b135ea3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "336d4223-7ab3-4645-8483-745111accb64");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7189f2c9-a26c-4a0a-8ed7-46d01d0f34cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb657f97-a307-4b1a-b4e6-d4998188c016");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a8c6327-610c-46a0-bf2f-3fd7455fa3bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f0c129e-6c9c-4f7e-abad-393f2dddad8d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e6598e7-2900-491c-ba9e-9cc453470b63");

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
                keyValue: "5e5fca25-1ce8-43a9-b9a6-a335be62c7e8");

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
