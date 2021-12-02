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
                    { "a1952cab-633b-45e1-bef5-7703198b8666", "0e89b2ea-c69f-4b21-ad96-49211c4b2ebf", "Mentor", "MENTOR" },
                    { "bb23c02a-13e8-483c-9ab4-5bea635e6730", "ea651cfd-f64d-40e9-9e79-81ae657fabfc", "Interviewer", "INTERVIEWER" },
                    { "525d104d-0b93-43eb-ab47-318e58fbb1ca", "7631b301-f507-439c-9e8f-1f2b1d0e8eb2", "Hr", "HR" },
                    { "8c39a209-2c5e-4b1d-bf1d-37a4adb2d2d3", "b4572c8a-155e-4063-a9e2-d23225101605", "Admin", "ADMIN" },
                    { "e94b2fff-503d-487a-ade1-843dc780c5b3", "4bb0f5f2-2224-4509-9aab-9f156e7f51f1", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "RoleType", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ec4d6094-4300-404f-b7c3-a837e3da843c", 0, "7081980e-5229-4f82-8d34-d46a06853827", "mentortest.team5@gmail.com", false, true, null, "MENTORTEST.TEAM5@GMAIL.COM", "BORIS BOBROV", "AQAAAAEAACcQAAAAEEFDNQvKjCrj4EmZ4WpdnX1Nv1p3vw8MxM6X6rILaJvt6ljAarGiuirnOZK0k2NEAQ==", "+7777777777777777", false, "Senior .NET/JS", 0, "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Boris Bobrov" },
                    { "4104e4f4-ce78-4a45-82f3-113df0811f03", 0, "e24770cc-91fd-4f50-b434-8234c6bd01e9", "managertest.team5@gmail.com", false, true, null, "MANAGERTEST.TEAM5@GMAIL.COM", "ANN GREEN", "AQAAAAEAACcQAAAAEKeVd57pOOpH3UfrQJkRw5JOcaG4e8CQW2OZihdnMkUmsQ333YMpsXH2bg2RSiSkdA==", "+325659787", false, "Deputy of Head of Education Center", 3, "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Ann Green" },
                    { "ed8a75f6-e5f6-4f95-8a48-af14f3034369", 0, "0452ae0b-66e3-4500-9e74-cad2a0e22896", "interviewer.team5@gmail.com", false, true, null, "INTERVIEWER.TEAM5@GMAIL.COM", "IVAN SIDOROV", "AQAAAAEAACcQAAAAEK5oVdXA4Ch9+QRdY48JssFwjnTcnmU1BzZzuIpM+Lzcyn8uebwwq9IluhNEDACISA==", "+325656787", false, "Senior .NET", 2, "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Ivan Sidorov" },
                    { "c7edb369-1f85-4056-9a33-33d1f976093c", 0, "2d2acba2-df4a-4ff1-a2df-d4466752a868", "hrlily.team5@gmail.com", false, true, null, "HRLILY.TEAM5@GMAIL.COM", "LILY IVANOVA", "AQAAAAEAACcQAAAAEAt+FZwb+HGZ/9XDZwbJqXka5+18BZOpIK+8d4mYSDUOfHFjU0aQsSx1pmBskBKErQ==", "+125656787", false, "Recruiter", 1, "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Lily Ivanova" },
                    { "d572ee4d-2e42-4c15-adda-70ddd4935684", 0, "5e4811a9-84e6-45fd-92b3-88e0c412dbb0", "admntest.team5@gmail.com", false, true, null, "ADMNTEST.TEAM5@GMAIL.COM", "PETER PETROV", "AQAAAAEAACcQAAAAEBOQBAlrFUhYjPywJbRGGmLGaKCI+23KPd+odSDLjBZvCz0TpzQFFnuHfyvNXtBLxQ==", "+123656787", false, "Head of Education Centre", 4, "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Peter Petrov" }
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
                    { 5, null, 4 },
                    { 3, null, 2 },
                    { 2, null, 1 },
                    { 1, null, 0 },
                    { 4, null, 3 },
                    { 6, null, 5 }
                });

            migrationBuilder.InsertData(
                table: "Internships",
                columns: new[] { "Id", "EndDate", "ImageLink", "InternshipStatusType", "MaxCandidateCount", "Name", "RegistrationFinishDate", "RegistrationStartDate", "Requirements", "SpreadSheetId", "StartDate" },
                values: new object[,]
                {
                    { 4, new DateTime(2021, 11, 30, 15, 47, 42, 940, DateTimeKind.Utc).AddTicks(5574), "https://drive.google.com/uc?export=view&id=1t-eClTKmOY4asHZkT6y_vvJNR4SMzKbB", 0, 30, "Angular/.NET", new DateTime(2021, 11, 30, 15, 47, 42, 940, DateTimeKind.Utc).AddTicks(5574), new DateTime(2021, 11, 30, 15, 47, 42, 940, DateTimeKind.Utc).AddTicks(5574), "OOP, JS, C#, .Net, Angular/React", "1RW1QxFSlyfGUnm0c-rGGr2_suo_MXrn1e_pUuLSV2tc", new DateTime(2021, 11, 30, 15, 47, 42, 940, DateTimeKind.Utc).AddTicks(5574) },
                    { 3, new DateTime(2021, 11, 30, 15, 47, 42, 940, DateTimeKind.Utc).AddTicks(5568), "https://drive.google.com/uc?export=view&id=1kirFfIPPxUbgOFNGNAk4CL6jf_lEOSKc", 0, 30, "GameDev", new DateTime(2021, 11, 30, 15, 47, 42, 940, DateTimeKind.Utc).AddTicks(5571), new DateTime(2021, 11, 30, 15, 47, 42, 940, DateTimeKind.Utc).AddTicks(5571), "OOP, Unity, C#, SQL", "1XSY0mwxSWPA1pXT4VteUoM4UTbuhn2LaqofeK6_7zuo", new DateTime(2021, 11, 30, 15, 47, 42, 940, DateTimeKind.Utc).AddTicks(5568) },
                    { 2, new DateTime(2021, 11, 30, 15, 47, 42, 940, DateTimeKind.Utc).AddTicks(5562), "https://drive.google.com/uc?export=view&id=1bvaKnWq0XEuldc4zry3qnrFtZoNRtW5R", 0, 30, "QA Automation", new DateTime(2021, 11, 30, 15, 47, 42, 940, DateTimeKind.Utc).AddTicks(5565), new DateTime(2021, 11, 30, 15, 47, 42, 940, DateTimeKind.Utc).AddTicks(5565), "Any programming language, QA basics", "1wdTLLMb8cWVQWpEfJafJCRL1eEF17kE1QQ1jYZGjw6A", new DateTime(2021, 11, 30, 15, 47, 42, 940, DateTimeKind.Utc).AddTicks(5562) },
                    { 1, new DateTime(2021, 11, 30, 15, 47, 42, 940, DateTimeKind.Utc).AddTicks(1917), "https://drive.google.com/uc?export=view&id=1tH7hcl7K2kM4HHC6QVXRdq0LPU8yZwd9", 0, 50, "JS/.NET", new DateTime(2021, 11, 30, 15, 47, 42, 940, DateTimeKind.Utc).AddTicks(3827), new DateTime(2021, 11, 30, 15, 47, 42, 940, DateTimeKind.Utc).AddTicks(3375), "OOP, JS, C#, .Net, Angular/React", "1nhQ98ChhQRfYQWQ2Rf6oyVpjyLetHq34V8muxMvwzSA", new DateTime(2021, 11, 30, 15, 47, 42, 940, DateTimeKind.Utc).AddTicks(1378) }
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
                    { "8c39a209-2c5e-4b1d-bf1d-37a4adb2d2d3", "d572ee4d-2e42-4c15-adda-70ddd4935684" },
                    { "525d104d-0b93-43eb-ab47-318e58fbb1ca", "c7edb369-1f85-4056-9a33-33d1f976093c" },
                    { "bb23c02a-13e8-483c-9ab4-5bea635e6730", "ed8a75f6-e5f6-4f95-8a48-af14f3034369" },
                    { "e94b2fff-503d-487a-ade1-843dc780c5b3", "4104e4f4-ce78-4a45-82f3-113df0811f03" },
                    { "a1952cab-633b-45e1-bef5-7703198b8666", "ec4d6094-4300-404f-b7c3-a837e3da843c" }
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
                values: new object[] { 1, new DateTime(2021, 11, 30, 15, 47, 42, 943, DateTimeKind.Utc).AddTicks(6348), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, null, true, "Snow", "-", "USA", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 30, 15, 47, 42, 944, DateTimeKind.Utc).AddTicks(1681), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "InternshipLanguage", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 30, 15, 47, 42, 944, DateTimeKind.Utc).AddTicks(3746), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, null, true, "Granger", "-", "UK", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 30, 15, 47, 42, 944, DateTimeKind.Utc).AddTicks(3749), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "FinalEvaluation", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 30, 15, 47, 42, 945, DateTimeKind.Utc).AddTicks(1452), "Good knowledge of frameworks, oop, and db", 4, 1, "d572ee4d-2e42-4c15-adda-70ddd4935684" },
                    { 2, 2, new DateTime(2021, 11, 30, 15, 47, 42, 945, DateTimeKind.Utc).AddTicks(2665), "Excellent candidate", 5, 2, "d572ee4d-2e42-4c15-adda-70ddd4935684" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 30, 15, 47, 42, 946, DateTimeKind.Utc).AddTicks(8388), "d572ee4d-2e42-4c15-adda-70ddd4935684" },
                    { 2, 2, new DateTime(2021, 11, 30, 15, 47, 42, 946, DateTimeKind.Utc).AddTicks(8863), "d572ee4d-2e42-4c15-adda-70ddd4935684" }
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
                keyValues: new object[] { "e94b2fff-503d-487a-ade1-843dc780c5b3", "4104e4f4-ce78-4a45-82f3-113df0811f03" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "525d104d-0b93-43eb-ab47-318e58fbb1ca", "c7edb369-1f85-4056-9a33-33d1f976093c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8c39a209-2c5e-4b1d-bf1d-37a4adb2d2d3", "d572ee4d-2e42-4c15-adda-70ddd4935684" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a1952cab-633b-45e1-bef5-7703198b8666", "ec4d6094-4300-404f-b7c3-a837e3da843c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb23c02a-13e8-483c-9ab4-5bea635e6730", "ed8a75f6-e5f6-4f95-8a48-af14f3034369" });

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
                keyValue: "525d104d-0b93-43eb-ab47-318e58fbb1ca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c39a209-2c5e-4b1d-bf1d-37a4adb2d2d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1952cab-633b-45e1-bef5-7703198b8666");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb23c02a-13e8-483c-9ab4-5bea635e6730");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e94b2fff-503d-487a-ade1-843dc780c5b3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4104e4f4-ce78-4a45-82f3-113df0811f03");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7edb369-1f85-4056-9a33-33d1f976093c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec4d6094-4300-404f-b7c3-a837e3da843c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed8a75f6-e5f6-4f95-8a48-af14f3034369");

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
                keyValue: "d572ee4d-2e42-4c15-adda-70ddd4935684");

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
