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
            var password = "Password1";
            var userHasher = new PasswordHasher<User>();
            var hashPassword = userHasher.HashPassword(null, password);

            migrationBuilder.InsertData("AspNetUsers",
                new[] { "Id", "RoleType", "Position", "BestContactTime", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash",
                    "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount" },
                new object[] { "3", (int)RoleType.Admin, "Product Owner", DateTime.Now, "username3", "USERNAME3", "admin@gmail.com", "ADMIN@GMAIL.COM", false, hashPassword,
                    "Hash", "Hash", "+123456788", false, false, null, false, 0 });

            migrationBuilder.InsertData("AspNetUsers",
                new[] { "Id", "RoleType", "Position", "BestContactTime", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash",
                    "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount" },
                new object[] { "2", (int)RoleType.Hr, "HR", DateTime.Now, "username2", "USERNAME2", "hr@gmail.com", "HR@GMAIL.COM", false, hashPassword,
                    "Hash", "Hash", "+123456787", false, false, null, false, 0 });

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
                new object[] { 1, 1, (int)EnglishLevelType.C1, DateTime.Now, "Good knowledge of frameworks, oop, and db", "2" });

            migrationBuilder.InsertData("Feedbacks", 
                new[] { "Id", "CandidateId", "EnglishLevelType", "Date", "Description", "UserId" }, 
                new object[] { 2, 2, (int)EnglishLevelType.C2, DateTime.Now, "Excellent candidate", "2" });

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
                new object[] { 1, "2", 1, DateTime.Now });

            migrationBuilder.InsertData("InterviewInvites", 
                new[] { "Id", "UserId", "CandidateId", "ContactDate" }, 
                new object[] { 2, "2", 2, DateTime.Now });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
