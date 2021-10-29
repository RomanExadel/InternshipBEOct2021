using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;
using Shared.Enums;
using System;

namespace DAL.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("AspNetUsers",
                new[] { "Id", "RoleType", "Position", "BestContactTime", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash",
                    "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount" },
                new object[] { "3827e25d-8989-4881-9f25-807d14878c1b", (int)RoleType.Interviewer, "BA", DateTime.UtcNow, "Masha", "MASHA", "li@gmail.com", "LI@GMAIL.COM", false, "AQAAAAEAACcQAAAAEFrfBeLl7wG60Syi2unYkVUM4kp/0A8RAZdc51M8e/5GokOv0qDZF+aGBSVaSV6vag==",
                    "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", "d722e70d-72fc-4f08-8fdc-afec3cef3c4f", "+123656787", false, false, null, true, 0 });

            migrationBuilder.InsertData("AspNetUsers",
                new[] { "Id", "RoleType", "Position", "BestContactTime", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash",
                    "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount" },
                new object[] { "5516d40a-40bf-482c-8575-34a18478ac89", (int)RoleType.Hr, "Back", DateTime.UtcNow, "Maxim", "MAXIM", "max@gmail.com", "MAX@GMAIL.COM", false, "AQAAAAEAACcQAAAAEA/2Sy0cS1B+wbGk2R/Llrp6iuFzZjbJGu1Egoj2MYPPMaowQUgECV4Teg/K5xy/fg==",
                    "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", "2c39a495-1b10-49f9-926c-a40d078418ad", "+125656787", false, false, null, true, 0 });

            migrationBuilder.InsertData("AspNetUsers",
                new[] { "Id", "RoleType", "Position", "BestContactTime", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash",
                    "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount" },
                new object[] { "57f2fe4e-64af-40b4-a279-5af5f1db8a8a", (int)RoleType.Manager, "Front", DateTime.UtcNow, "Dasha", "DASHA", "user@example.com", "USER@EXAMPLE.COM", false, "AQAAAAEAACcQAAAAEEVFxbsq/jnZ4avRoKtiCKb4QPzojCZDr6y9N3exNngtHExLdISgHDxhvprupVr9iQ==",
                    "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", "09fb73b8-aab6-4ff4-a27b-4426a8b73570", "+325656787", false, false, null, true, 0 });

            migrationBuilder.InsertData("AspNetUsers",
                new[] { "Id", "RoleType", "Position", "BestContactTime", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash",
                    "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount" },
                new object[] { "ff8a8331-c30a-4a6c-8860-0b49c533aa2c", (int)RoleType.Admin, "PO", DateTime.UtcNow, "Alexandr", "ALEXANDR", "admin@gmail.com", "ADMIN@GMAIL.COM", false, "AQAAAAEAACcQAAAAEK+m9ZBEt0HpxkxRafiiKjUsm1GShqzdyFWgzC1tGIApjSTzcLx49pKc1wIKrgN0tg==",
                    "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", "66f70ef0-1083-48a6-9c14-d54557737744", "+325659787", false, false, null, true, 0 });

            migrationBuilder.InsertData("Internships", new[] { "Id", "Name", "StartDate", "EndDate", "Requirements", "MaxCandidateCount", "RegistrationStartDate", "RegistrationFinishDate", "LanguageType" },
                new object[] { 1, "JS/>NET", DateTime.Now, DateTime.Now, "OOP, JS, C#, .Net, Angular/React", 50, DateTime.Now, DateTime.Now, (int)LanguageType.English });

            migrationBuilder.InsertData("Internships", new[] { "Id", "Name", "StartDate", "EndDate", "Requirements", "MaxCandidateCount", "RegistrationStartDate", "RegistrationFinishDate", "LanguageType" },
                new object[] { 2, "QA Automation", DateTime.Now, DateTime.Now, "Any programming language, QA basics", 30, DateTime.Now, DateTime.Now, (int)LanguageType.English });

            //Requirements: IntershipId
            migrationBuilder.InsertData("Teams", new[] { "Id", "InternshipId", "Name", }, new object[] { 1, 1, "Team 1 A" });

            migrationBuilder.InsertData("Teams", new[] { "Id", "InternshipId", "Name", }, new object[] { 2, 2, "Team 1 B" });

            //Requirements: InternshipId
            migrationBuilder.InsertData("InternshipStacks", new[] { "Id", "InternshipId", "TechnologyStackType" }, new object[] { 1, 1, (int)StackType.BackEnd });

            migrationBuilder.InsertData("InternshipStacks", new[] { "Id", "InternshipId", "TechnologyStackType" }, new object[] { 2, 2, (int)StackType.Testing });

            //Requirements: IntershipId, TeamId
            migrationBuilder.InsertData("Candidates", new[] { "Id", "FirstName", "LastName", "Location", "Phone","Email", "Skype", "Education", "Links", "OtherInfo", "PrimarySkill",
                "CurrentJob", "ProfessionalCertificates", "BestContactTime", "TestTaskEvaluation", "StatusType", "StackType", "EnglishLevelType", "IsPlanningToJoin", "RegistationDate", "InternshipId", "TeamId" },
                new object[] {1, "John", "Snow", "Arizona", "+123456789", "j.snow@gmail.com","live:j.snow", "Harvard University", "-","-","OOP, C#", "Student", "-", DateTime.Now,
                4, (int)StatusType.New, (int)StackType.BackEnd, (int)EnglishLevelType.C1, true, DateTime.Now, 1, 1 });

            migrationBuilder.InsertData("Candidates", new[] { "Id", "FirstName", "LastName", "Location", "Phone","Email", "Skype", "Education", "Links", "OtherInfo", "PrimarySkill",
                "CurrentJob", "ProfessionalCertificates", "BestContactTime", "TestTaskEvaluation", "StatusType", "StackType", "EnglishLevelType", "IsPlanningToJoin", "RegistationDate", "InternshipId", "TeamId" },
                new object[] { 2, "Hermione", "Granger", "London", "+2356416789", "h.granger@gmail.com","live:h.granger", "Hogwarts", "-","-","C++, QA basics", "Student", "-", DateTime.Now,
                4, (int)StatusType.New, (int)StackType.Testing, (int)EnglishLevelType.C2, true, DateTime.Now, 2, 2 });

            //Requirements: CandidateId, UserId
            migrationBuilder.InsertData("Feedbacks", 
                new[] { "Id", "CandidateId", "EnglishLevelType", "Date", "Description", "UserId" }, 
                new object[] { 1, 1, (int)EnglishLevelType.C1, DateTime.Now, "Good knowledge of frameworks, oop, and db", "3827e25d-8989-4881-9f25-807d14878c1b" });

            migrationBuilder.InsertData("Feedbacks", 
                new[] { "Id", "CandidateId", "EnglishLevelType", "Date", "Description", "UserId" }, 
                new object[] { 2, 2, (int)EnglishLevelType.C2, DateTime.Now, "Excellent candidate", "3827e25d-8989-4881-9f25-807d14878c1b" });

            migrationBuilder.InsertData("Skills", 
                new[] { "Id", "StackType", "Name", "IsHardSkill" }, 
                new object[] { 1, (int)StackType.BackEnd, "OOP", true });

            migrationBuilder.InsertData("Skills", 
                new[] { "Id", "StackType", "Name", "IsHardSkill" }, 
                new object[] { 2, (int)StackType.Testing, "Java", true });

            //Requirements: FeedbackId, SkillId
            migrationBuilder.InsertData("Evaluations", 
                new[] { "Id", "FeedbackId", "SkillId", "Value" }, 
                new object[] { 1, 1, 1, 4 });

            migrationBuilder.InsertData("Evaluations", 
                new[] { "Id", "FeedbackId", "SkillId", "Value" }, 
                new object[] { 2, 2, 2, 4 });

            //Requirements: UserId, CandidateId
            migrationBuilder.InsertData("InterviewInvites", 
                new[] { "Id", "UserId", "CandidateId", "ContactDate" }, 
                new object[] { 1, "3827e25d-8989-4881-9f25-807d14878c1b", 1, DateTime.Now });

            migrationBuilder.InsertData("InterviewInvites", 
                new[] { "Id", "UserId", "CandidateId", "ContactDate" }, 
                new object[] { 2, "3827e25d-8989-4881-9f25-807d14878c1b", 2, DateTime.Now });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
