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
                    { "7465a125-1ef3-4814-8fdb-243248b89f36", "238d284f-5d6f-4560-a050-9c7f781662a9", "Hr", "HR" },
                    { "dbd36f01-9675-4e77-a0d2-e67f8d288527", "e5434104-d8bf-4831-9b6d-b5641ebf50b7", "Interviewer", "INTERVIEWER" },
                    { "5cb8c2c6-f5b6-4ead-b879-63b6fd65d8a1", "237def9a-d5bd-47de-9106-f4f5e57cb5a4", "Manager", "MANAGER" },
                    { "c4a07625-f2ef-4404-ab0e-de3db4740a72", "9141e59b-e60c-4080-818a-7f379f786666", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BestContactTime", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "340c69bd-e274-45f2-b35d-35d9c8af8fb3", 0, new DateTime(2021, 11, 3, 13, 45, 40, 960, DateTimeKind.Utc).AddTicks(6147), "dd65b866-88ba-4704-8448-a228b47060fc", "li@gmail.com", false, true, null, "LI@GMAIL.COM", "MASHA", "AQAAAAEAACcQAAAAEG5nB/EUEAt6707jUOK08THqltBxoKMVDtrN5HiuN7LKrUaugAlU87OMEaijVgzCrw==", "+123656787", false, "BA", "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Masha" },
                    { "ff611c6b-f9e6-4c22-aa22-b935acb7b2e8", 0, new DateTime(2021, 11, 3, 13, 45, 40, 968, DateTimeKind.Utc).AddTicks(6324), "8cf53e8e-0d3f-4968-a3c1-ee5c856ef4e1", "max@gmail.com", false, true, null, "MAX@GMAIL.COM", "MAXIM", "AQAAAAEAACcQAAAAEHWZGosdUmw1q/LAdM8WCaSXNnOH3JTJakkNFA36DwNgsNwMY7kL9dw8vVDSGazpPA==", "+125656787", false, "Back", "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Maxim" },
                    { "c6354bed-37a3-4171-988b-94f5a4d661df", 0, new DateTime(2021, 11, 3, 13, 45, 40, 970, DateTimeKind.Utc).AddTicks(4156), "dde32aec-ae06-46d0-ba41-c1b0fe7d2015", "user@example.com", false, true, null, "USER@EXAMPLE.COM", "DASHA", "AQAAAAEAACcQAAAAECRveTY3oTDoOm8hubZLX0cEcK7w0jOQukHHFGNwPyP1tyCMlg0Ary9Aw+mfYIVQZw==", "+325656787", false, "Front", "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Dasha" },
                    { "6614e1ea-64ec-4caa-8c7c-9ea9356de022", 0, new DateTime(2021, 11, 3, 13, 45, 40, 972, DateTimeKind.Utc).AddTicks(588), "b403659a-2c31-4cd8-9cfc-753b43c5f08b", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ALEXANDR", "AQAAAAEAACcQAAAAEBMsqV/FqRsJn5lx8jXHzsBXSyZQ0IiYhpovB08Zko/AJWuhY+bddwOWbfYlxR3ayw==", "+325659787", false, "PO", "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Alexandr" }
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
                    { 1, new DateTime(2021, 11, 3, 13, 45, 40, 974, DateTimeKind.Utc).AddTicks(6105), "image/link/1", 0, 0, 50, "JS/>NET", new DateTime(2021, 11, 3, 13, 45, 40, 974, DateTimeKind.Utc).AddTicks(8156), new DateTime(2021, 11, 3, 13, 45, 40, 974, DateTimeKind.Utc).AddTicks(7632), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 3, 13, 45, 40, 974, DateTimeKind.Utc).AddTicks(5531) },
                    { 2, new DateTime(2021, 11, 3, 13, 45, 40, 975, DateTimeKind.Utc).AddTicks(381), "image/link/2", 0, 0, 30, "QA Automation", new DateTime(2021, 11, 3, 13, 45, 40, 975, DateTimeKind.Utc).AddTicks(384), new DateTime(2021, 11, 3, 13, 45, 40, 975, DateTimeKind.Utc).AddTicks(383), "Any programming language, QA basics", new DateTime(2021, 11, 3, 13, 45, 40, 975, DateTimeKind.Utc).AddTicks(379) }
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
                    { "7465a125-1ef3-4814-8fdb-243248b89f36", "340c69bd-e274-45f2-b35d-35d9c8af8fb3" },
                    { "dbd36f01-9675-4e77-a0d2-e67f8d288527", "ff611c6b-f9e6-4c22-aa22-b935acb7b2e8" },
                    { "5cb8c2c6-f5b6-4ead-b879-63b6fd65d8a1", "c6354bed-37a3-4171-988b-94f5a4d661df" },
                    { "c4a07625-f2ef-4404-ab0e-de3db4740a72", "6614e1ea-64ec-4caa-8c7c-9ea9356de022" }
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
                values: new object[] { 1, new DateTime(2021, 11, 3, 13, 45, 40, 977, DateTimeKind.Utc).AddTicks(7645), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, true, "Snow", "-", "Arizona", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 3, 13, 45, 40, 978, DateTimeKind.Utc).AddTicks(667), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 3, 13, 45, 40, 978, DateTimeKind.Utc).AddTicks(2227), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, true, "Granger", "-", "London", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 3, 13, 45, 40, 978, DateTimeKind.Utc).AddTicks(2231), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 3, 13, 45, 40, 978, DateTimeKind.Utc).AddTicks(8543), "Good knowledge of frameworks, oop, and db", 4, "340c69bd-e274-45f2-b35d-35d9c8af8fb3" },
                    { 2, 2, new DateTime(2021, 11, 3, 13, 45, 40, 979, DateTimeKind.Utc).AddTicks(54), "Excellent candidate", 5, "340c69bd-e274-45f2-b35d-35d9c8af8fb3" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 3, 13, 45, 40, 980, DateTimeKind.Utc).AddTicks(5463), "340c69bd-e274-45f2-b35d-35d9c8af8fb3" },
                    { 2, 2, new DateTime(2021, 11, 3, 13, 45, 40, 980, DateTimeKind.Utc).AddTicks(6016), "340c69bd-e274-45f2-b35d-35d9c8af8fb3" }
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
                keyValues: new object[] { "7465a125-1ef3-4814-8fdb-243248b89f36", "340c69bd-e274-45f2-b35d-35d9c8af8fb3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c4a07625-f2ef-4404-ab0e-de3db4740a72", "6614e1ea-64ec-4caa-8c7c-9ea9356de022" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5cb8c2c6-f5b6-4ead-b879-63b6fd65d8a1", "c6354bed-37a3-4171-988b-94f5a4d661df" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dbd36f01-9675-4e77-a0d2-e67f8d288527", "ff611c6b-f9e6-4c22-aa22-b935acb7b2e8" });

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
                keyValue: "5cb8c2c6-f5b6-4ead-b879-63b6fd65d8a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7465a125-1ef3-4814-8fdb-243248b89f36");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4a07625-f2ef-4404-ab0e-de3db4740a72");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbd36f01-9675-4e77-a0d2-e67f8d288527");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6614e1ea-64ec-4caa-8c7c-9ea9356de022");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6354bed-37a3-4171-988b-94f5a4d661df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff611c6b-f9e6-4c22-aa22-b935acb7b2e8");

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
                keyValue: "340c69bd-e274-45f2-b35d-35d9c8af8fb3");

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
