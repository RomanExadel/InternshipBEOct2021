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
                    { "282c2199-ac74-4bc8-8b90-945aa2a1f0ff", "b883af6c-a826-417c-a8b2-35b40a7e9631", "Mentor", "MENTOR" },
                    { "826aa514-028e-443c-9584-9e9964b84977", "4f3cb6b2-a845-44cc-af2c-acccf2732044", "Interviewer", "INTERVIEWER" },
                    { "5267d6f8-9168-4ee5-91d6-3bfc1a852d54", "adb77ec9-d5e6-4376-9a1b-a589b91ca73d", "Hr", "HR" },
                    { "a0789363-0314-45ec-bc61-64320010f9c3", "b6fd9dde-e869-4c50-b960-dde5ca032e32", "Admin", "ADMIN" },
                    { "bfee4ac5-5ace-4d9c-9f8a-769de49ba691", "d4ad5e21-248a-4a0d-8806-df31a7219f8b", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "RoleType", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "81cd0f53-0f04-4079-8846-f490cf677d4a", 0, "5cb26faf-83e8-46f7-b312-7f84b2298405", "mentortest.team5@gmail.com", false, true, null, "MENTORTEST.TEAM5@GMAIL.COM", "BORIS BOBROV", "AQAAAAEAACcQAAAAEES/MYvLumaIdZn7FELYFdn1AN8zkm7Tw+HZd3XFDME+a8BW67xLOvfEKUx9p+CmFw==", "+7777777777777777", false, "PO", 0, "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Boris Bobrov" },
                    { "74b9be8b-9eb5-4014-963d-03670de353aa", 0, "cfb77adc-0f10-4399-bf1b-84d3982eeebe", "managertest.team5@gmail.com", false, true, null, "MANAGERTEST.TEAM5@GMAIL.COM", "ANN GREEN", "AQAAAAEAACcQAAAAEBtI0hFC2KsMVWztgmcM1Mb8/Z/SY1iWIwHeyLGjq5K/X6rpyt/1v5o1Kbl3Jz5A7A==", "+325659787", false, "PO", 3, "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Ann Green" },
                    { "f4d5ad27-f165-4c95-b2de-5dfe4b189561", 0, "4a9b40df-8217-43e5-94e4-46754449415f", "interviewer.team5@gmail.com", false, true, null, "INTERVIEWER.TEAM5@GMAIL.COM", "IVAN SIDOROV", "AQAAAAEAACcQAAAAEO5HqL7NzsVHFCNoRaYe/9EmLRh74aawDNSBmtaOMjfQvO2al1KmeFiw62ijZNtkCw==", "+325656787", false, "Front", 2, "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Ivan Sidorov" },
                    { "15cef508-4e16-4b6c-9f26-e6418dd55685", 0, "abe92e0d-9340-4c7e-9f34-cc572844bab1", "hrlily.team5@gmail.com", false, true, null, "HRLILY.TEAM5@GMAIL.COM", "LILY IVANOVA", "AQAAAAEAACcQAAAAED1stZLde8WMh5DcRSvPCT/UF3zx3Uy/zfmR5RkY2D8043Acw6/3fZ2FdCwBzwxa+A==", "+125656787", false, "Back", 1, "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Lily Ivanova" },
                    { "44c3d6f1-34a4-4df2-831a-ec5f045a0537", 0, "31cbb3c8-6321-4cfa-9b0b-ac616bf83fdd", "admntest.team5@gmail.com", false, true, null, "ADMNTEST.TEAM5@GMAIL.COM", "PETER PETROV", "AQAAAAEAACcQAAAAELyfpkVuM6So8axHFrEEEWwLafg/uwrv+zGfmciGnnSDpO4BtqDI5u363xaW6h1GeA==", "+123656787", false, "BA", 4, "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Peter Petrov" }
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
                columns: new[] { "Id", "EndDate", "ImageLink", "InternshipStatusType", "LanguageType", "MaxCandidateCount", "Name", "RegistrationFinishDate", "RegistrationStartDate", "Requirements", "SpreadSheetId", "StartDate" },
                values: new object[,]
                {
                    { 4, new DateTime(2021, 11, 24, 15, 40, 36, 269, DateTimeKind.Utc).AddTicks(5820), "https://drive.google.com/uc?export=view&id=1t-eClTKmOY4asHZkT6y_vvJNR4SMzKbB", 0, 1, 30, "Angular/.NET", new DateTime(2021, 11, 24, 15, 40, 36, 269, DateTimeKind.Utc).AddTicks(5823), new DateTime(2021, 11, 24, 15, 40, 36, 269, DateTimeKind.Utc).AddTicks(5820), "OOP, JS, C#, .Net, Angular/React", "1RW1QxFSlyfGUnm0c-rGGr2_suo_MXrn1e_pUuLSV2tc", new DateTime(2021, 11, 24, 15, 40, 36, 269, DateTimeKind.Utc).AddTicks(5820) },
                    { 3, new DateTime(2021, 11, 24, 15, 40, 36, 269, DateTimeKind.Utc).AddTicks(5817), "https://drive.google.com/uc?export=view&id=1kirFfIPPxUbgOFNGNAk4CL6jf_lEOSKc", 0, 1, 30, "GameDev", new DateTime(2021, 11, 24, 15, 40, 36, 269, DateTimeKind.Utc).AddTicks(5817), new DateTime(2021, 11, 24, 15, 40, 36, 269, DateTimeKind.Utc).AddTicks(5817), "OOP, Unity, C#, SQL", "1XSY0mwxSWPA1pXT4VteUoM4UTbuhn2LaqofeK6_7zuo", new DateTime(2021, 11, 24, 15, 40, 36, 269, DateTimeKind.Utc).AddTicks(5817) },
                    { 2, new DateTime(2021, 11, 24, 15, 40, 36, 269, DateTimeKind.Utc).AddTicks(5811), "https://drive.google.com/uc?export=view&id=1bvaKnWq0XEuldc4zry3qnrFtZoNRtW5R", 0, 0, 30, "QA Automation", new DateTime(2021, 11, 24, 15, 40, 36, 269, DateTimeKind.Utc).AddTicks(5814), new DateTime(2021, 11, 24, 15, 40, 36, 269, DateTimeKind.Utc).AddTicks(5814), "Any programming language, QA basics", "1wdTLLMb8cWVQWpEfJafJCRL1eEF17kE1QQ1jYZGjw6A", new DateTime(2021, 11, 24, 15, 40, 36, 269, DateTimeKind.Utc).AddTicks(5811) },
                    { 1, new DateTime(2021, 11, 24, 15, 40, 36, 269, DateTimeKind.Utc).AddTicks(2353), "https://drive.google.com/uc?export=view&id=1tH7hcl7K2kM4HHC6QVXRdq0LPU8yZwd9", 0, 0, 50, "JS/.NET", new DateTime(2021, 11, 24, 15, 40, 36, 269, DateTimeKind.Utc).AddTicks(3916), new DateTime(2021, 11, 24, 15, 40, 36, 269, DateTimeKind.Utc).AddTicks(3519), "OOP, JS, C#, .Net, Angular/React", "1nhQ98ChhQRfYQWQ2Rf6oyVpjyLetHq34V8muxMvwzSA", new DateTime(2021, 11, 24, 15, 40, 36, 269, DateTimeKind.Utc).AddTicks(1858) }
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
                    { "a0789363-0314-45ec-bc61-64320010f9c3", "44c3d6f1-34a4-4df2-831a-ec5f045a0537" },
                    { "5267d6f8-9168-4ee5-91d6-3bfc1a852d54", "15cef508-4e16-4b6c-9f26-e6418dd55685" },
                    { "826aa514-028e-443c-9584-9e9964b84977", "f4d5ad27-f165-4c95-b2de-5dfe4b189561" },
                    { "bfee4ac5-5ace-4d9c-9f8a-769de49ba691", "74b9be8b-9eb5-4014-963d-03670de353aa" },
                    { "282c2199-ac74-4bc8-8b90-945aa2a1f0ff", "81cd0f53-0f04-4079-8846-f490cf677d4a" }
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
                values: new object[] { 1, new DateTime(2021, 11, 24, 15, 40, 36, 271, DateTimeKind.Utc).AddTicks(7943), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, null, true, "Snow", "-", "USA", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 24, 15, 40, 36, 272, DateTimeKind.Utc).AddTicks(86), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "InternshipLanguage", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 24, 15, 40, 36, 272, DateTimeKind.Utc).AddTicks(1258), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, null, true, "Granger", "-", "UK", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 24, 15, 40, 36, 272, DateTimeKind.Utc).AddTicks(1261), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "FinalEvaluation", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 24, 15, 40, 36, 272, DateTimeKind.Utc).AddTicks(6441), "Good knowledge of frameworks, oop, and db", 4, 1, "44c3d6f1-34a4-4df2-831a-ec5f045a0537" },
                    { 2, 2, new DateTime(2021, 11, 24, 15, 40, 36, 272, DateTimeKind.Utc).AddTicks(7592), "Excellent candidate", 5, 2, "44c3d6f1-34a4-4df2-831a-ec5f045a0537" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 24, 15, 40, 36, 274, DateTimeKind.Utc).AddTicks(270), "44c3d6f1-34a4-4df2-831a-ec5f045a0537" },
                    { 2, 2, new DateTime(2021, 11, 24, 15, 40, 36, 274, DateTimeKind.Utc).AddTicks(666), "44c3d6f1-34a4-4df2-831a-ec5f045a0537" }
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
                keyValues: new object[] { "5267d6f8-9168-4ee5-91d6-3bfc1a852d54", "15cef508-4e16-4b6c-9f26-e6418dd55685" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a0789363-0314-45ec-bc61-64320010f9c3", "44c3d6f1-34a4-4df2-831a-ec5f045a0537" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bfee4ac5-5ace-4d9c-9f8a-769de49ba691", "74b9be8b-9eb5-4014-963d-03670de353aa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "282c2199-ac74-4bc8-8b90-945aa2a1f0ff", "81cd0f53-0f04-4079-8846-f490cf677d4a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "826aa514-028e-443c-9584-9e9964b84977", "f4d5ad27-f165-4c95-b2de-5dfe4b189561" });

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
                keyValue: "282c2199-ac74-4bc8-8b90-945aa2a1f0ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5267d6f8-9168-4ee5-91d6-3bfc1a852d54");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "826aa514-028e-443c-9584-9e9964b84977");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0789363-0314-45ec-bc61-64320010f9c3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfee4ac5-5ace-4d9c-9f8a-769de49ba691");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15cef508-4e16-4b6c-9f26-e6418dd55685");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74b9be8b-9eb5-4014-963d-03670de353aa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81cd0f53-0f04-4079-8846-f490cf677d4a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4d5ad27-f165-4c95-b2de-5dfe4b189561");

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
                keyValue: "44c3d6f1-34a4-4df2-831a-ec5f045a0537");

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
