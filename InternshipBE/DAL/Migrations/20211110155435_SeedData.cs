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
                    { "bd4df129-4537-4fef-b6cb-66bd75adca97", "0c871c6e-bfa5-455e-ab13-2589766b7a2c", "Admin", "ADMIN" },
                    { "c11429c1-c3ef-46eb-b3d2-11db5c81dc02", "4524f403-7759-4fce-a498-61283f9147d1", "Interviewer", "INTERVIEWER" },
                    { "b3018285-4880-41a7-bfdd-b3a781f6be90", "136fe9c0-d7f6-4e02-b29b-33a149738ca5", "Hr", "HR" },
                    { "d5ee3c24-aa34-4dbd-afc8-c8383b21b1f7", "69703144-067b-4a5c-976b-26e2b50e1d48", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "RoleType", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "86ae18cb-6041-4fb2-9ac8-26721f73afc4", 0, "038eefcb-3c67-44fc-8b91-f5de97538836", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ALEXANDR", "AQAAAAEAACcQAAAAEHll1VJRz3t6qEJPoaIeml8k8BdjLaiKE+eMa1fJN0JNpaOb2uA7wGth/5hL3PbjTg==", "+325659787", false, "PO", 4, "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Alexandr" },
                    { "1703ac8d-fea6-47b2-825a-535a83ea7f18", 0, "39e44cf0-c1f0-47fe-b34f-ff3cf37cf55f", "user@example.com", false, true, null, "USER@EXAMPLE.COM", "DASHA", "AQAAAAEAACcQAAAAEOiqLaSGF0ApYqKKm/hFGGrtrUbRnQFbcZlbha78nbtCGGQpBiftBAyYf9b/b3jRHQ==", "+325656787", false, "Front", 3, "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Dasha" },
                    { "51cc826e-5592-48df-9fe2-963a3bda36d6", 0, "616bd0b2-f77b-4be7-801b-e4ed44f67cc7", "max@gmail.com", false, true, null, "MAX@GMAIL.COM", "MAXIM", "AQAAAAEAACcQAAAAEHlyxG5AQAEBgMmBgciCQ8bbj9laEyOdjK+BdmKUclTN5w9JJFCf/9FSU7osWvVvgA==", "+125656787", false, "Back", 2, "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Maxim" },
                    { "0cfb5c57-b58b-432b-9b03-2d5e945f1e2e", 0, "d15b1e4f-9e1e-45ee-b568-373039f91981", "li@gmail.com", false, true, null, "LI@GMAIL.COM", "MASHA", "AQAAAAEAACcQAAAAECurHPpEX5uoVeH2zb3zhYwBAXUyoW//HTTltCvAUql2bMFSwfWCqFdzfHH0+RIhmQ==", "+123656787", false, "BA", 1, "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Masha" }
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
                    { 4, new DateTime(2021, 11, 10, 15, 54, 34, 517, DateTimeKind.Utc).AddTicks(2411), "image/link/2", 0, 1, 30, "Angular/>NET", new DateTime(2021, 11, 10, 15, 54, 34, 517, DateTimeKind.Utc).AddTicks(2414), new DateTime(2021, 11, 10, 15, 54, 34, 517, DateTimeKind.Utc).AddTicks(2413), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 10, 15, 54, 34, 517, DateTimeKind.Utc).AddTicks(2410) },
                    { 3, new DateTime(2021, 11, 10, 15, 54, 34, 517, DateTimeKind.Utc).AddTicks(2404), "image/link/2", 0, 1, 30, "GameDev", new DateTime(2021, 11, 10, 15, 54, 34, 517, DateTimeKind.Utc).AddTicks(2407), new DateTime(2021, 11, 10, 15, 54, 34, 517, DateTimeKind.Utc).AddTicks(2406), "OOP, Unity, C#, SQL", new DateTime(2021, 11, 10, 15, 54, 34, 517, DateTimeKind.Utc).AddTicks(2402) },
                    { 2, new DateTime(2021, 11, 10, 15, 54, 34, 517, DateTimeKind.Utc).AddTicks(2310), "image/link/2", 0, 0, 30, "QA Automation", new DateTime(2021, 11, 10, 15, 54, 34, 517, DateTimeKind.Utc).AddTicks(2315), new DateTime(2021, 11, 10, 15, 54, 34, 517, DateTimeKind.Utc).AddTicks(2313), "Any programming language, QA basics", new DateTime(2021, 11, 10, 15, 54, 34, 517, DateTimeKind.Utc).AddTicks(2306) },
                    { 1, new DateTime(2021, 11, 10, 15, 54, 34, 516, DateTimeKind.Utc).AddTicks(7942), "image/link/1", 0, 0, 50, "JS/>NET", new DateTime(2021, 11, 10, 15, 54, 34, 517, DateTimeKind.Utc).AddTicks(86), new DateTime(2021, 11, 10, 15, 54, 34, 516, DateTimeKind.Utc).AddTicks(9555), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 10, 15, 54, 34, 516, DateTimeKind.Utc).AddTicks(7257) }
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
                    { "b3018285-4880-41a7-bfdd-b3a781f6be90", "0cfb5c57-b58b-432b-9b03-2d5e945f1e2e" },
                    { "c11429c1-c3ef-46eb-b3d2-11db5c81dc02", "51cc826e-5592-48df-9fe2-963a3bda36d6" },
                    { "d5ee3c24-aa34-4dbd-afc8-c8383b21b1f7", "1703ac8d-fea6-47b2-825a-535a83ea7f18" },
                    { "bd4df129-4537-4fef-b6cb-66bd75adca97", "86ae18cb-6041-4fb2-9ac8-26721f73afc4" }
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
                values: new object[] { 1, new DateTime(2021, 11, 10, 15, 54, 34, 520, DateTimeKind.Utc).AddTicks(4595), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, true, "Snow", "-", "Arizona", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 10, 15, 54, 34, 520, DateTimeKind.Utc).AddTicks(7601), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 10, 15, 54, 34, 520, DateTimeKind.Utc).AddTicks(9215), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, true, "Granger", "-", "London", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 10, 15, 54, 34, 520, DateTimeKind.Utc).AddTicks(9221), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 10, 15, 54, 34, 521, DateTimeKind.Utc).AddTicks(8155), "Good knowledge of frameworks, oop, and db", 4, "0cfb5c57-b58b-432b-9b03-2d5e945f1e2e" },
                    { 2, 2, new DateTime(2021, 11, 10, 15, 54, 34, 521, DateTimeKind.Utc).AddTicks(9720), "Excellent candidate", 5, "0cfb5c57-b58b-432b-9b03-2d5e945f1e2e" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 10, 15, 54, 34, 524, DateTimeKind.Utc).AddTicks(8975), "0cfb5c57-b58b-432b-9b03-2d5e945f1e2e" },
                    { 2, 2, new DateTime(2021, 11, 10, 15, 54, 34, 524, DateTimeKind.Utc).AddTicks(9557), "0cfb5c57-b58b-432b-9b03-2d5e945f1e2e" }
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
                keyValues: new object[] { "b3018285-4880-41a7-bfdd-b3a781f6be90", "0cfb5c57-b58b-432b-9b03-2d5e945f1e2e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d5ee3c24-aa34-4dbd-afc8-c8383b21b1f7", "1703ac8d-fea6-47b2-825a-535a83ea7f18" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c11429c1-c3ef-46eb-b3d2-11db5c81dc02", "51cc826e-5592-48df-9fe2-963a3bda36d6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd4df129-4537-4fef-b6cb-66bd75adca97", "86ae18cb-6041-4fb2-9ac8-26721f73afc4" });

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
                keyValue: "b3018285-4880-41a7-bfdd-b3a781f6be90");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd4df129-4537-4fef-b6cb-66bd75adca97");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c11429c1-c3ef-46eb-b3d2-11db5c81dc02");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5ee3c24-aa34-4dbd-afc8-c8383b21b1f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1703ac8d-fea6-47b2-825a-535a83ea7f18");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51cc826e-5592-48df-9fe2-963a3bda36d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86ae18cb-6041-4fb2-9ac8-26721f73afc4");

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
                keyValue: "0cfb5c57-b58b-432b-9b03-2d5e945f1e2e");

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
