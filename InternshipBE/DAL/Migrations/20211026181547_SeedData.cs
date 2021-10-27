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

            migrationBuilder.InsertData("AspNetUsers", new[] { "Id", "RoleType", "Login", "PasswordHash", "Position", "BestContactTime", "EmailConfirmed", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnabled", "AccessFailedCount" },
                new object[] { "3", (int)RoleType.Admin, "admin@gmail.com", hashPassword, "Product Owner", DateTime.Now, true, true, true, true, 1 });

            migrationBuilder.InsertData("AspNetUsers", new[] { "Id", "RoleType", "Login", "PasswordHash", "Position", "BestContactTime", "EmailConfirmed", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnabled", "AccessFailedCount" },
                new object[] { "2", (int)RoleType.Hr, "hr@gmail.com", hashPassword, "HR", DateTime.Now, true, true, true, true, 2 });

            migrationBuilder.InsertData("Candidates", new[] { "Id", "FirstName", "LastName", "Location", "Phone","Email", "Skype", "Education", "Links", "OtherInfo", "PrimarySkill",
                "CurrentJob", "ProfessionalCertificates", "BestContactTime", "TestTaskEvaluation", "StatusType", "StackType", "EnglishLevelType", "IsPlanningToJoin", "RegistationDate"},
                new object[] {1, "John", "Snow", "Arizona", "+123456789", "j.snow@gmail.com","live:j.snow", "Harvard University", "-","-","OOP, C#", "Student", "-", DateTime.Now,
                4, (int)StatusType.Awaiting, (int)StackType.BackEnd, (int)EnglishLevelType.C1, true, DateTime.Now});

            migrationBuilder.InsertData("Candidates", new[] { "Id", "FirstName", "LastName", "Location", "Phone","Email", "Skype", "Education", "Links", "OtherInfo", "PrimarySkill",
                "CurrentJob", "ProfessionalCertificates", "BestContactTime", "TestTaskEvaluation", "StatusType", "StackType", "EnglishLevelType", "IsPlanningToJoin", "RegistationDate"},
                new object[] { 2, "Hermione", "Granger", "London", "+2356416789", "h.granger@gmail.com","live:h.granger", "Hogwarts", "-","-","C++, QA basics", "Student", "-", DateTime.Now,
                4, (int)StatusType.Awaiting, (int)StackType.Testing, (int)EnglishLevelType.C2, true, DateTime.Now});

            migrationBuilder.InsertData("UserCandidates", new[] { "Id", "UserId", "CandidateId" }, new object[] { 1, 1, 1 });

            migrationBuilder.InsertData("UserCandidates", new[] { "Id", "UserId", "CandidateId" }, new object[] { 2, 2, 2 });

            migrationBuilder.InsertData("Feedbacks", new[] { "Id", "UserCandidateId", "EnglishLevelType", "Date", "Description" }, new object[] { 1, 1, (int)EnglishLevelType.C1, DateTime.Now, "Good knowledge of frameworks, oop, and db" });

            migrationBuilder.InsertData("Feedbacks", new[] { "Id", "UserCandidateId", "EnglishLevelType", "Date", "Description" }, new object[] { 2, 2, (int)EnglishLevelType.C2, DateTime.Now, "Excellent candidate" });

            migrationBuilder.InsertData("Skills", new[] { "Id", "StackType", "Name", "IsHardSkill" }, new object[] { 1, (int)StackType.BackEnd, "OOP", true });

            migrationBuilder.InsertData("Skills", new[] { "Id", "StackType", "Name", "IsHardSkill" }, new object[] { 2, (int)StackType.Testing, "Java", true });

            migrationBuilder.InsertData("Evaluations", new[] { "Id", "FeedbackId", "SkillId", "Value" }, new object[] { 1, 1, 1, 4 });

            migrationBuilder.InsertData("Evaluations", new[] { "Id", "FeedbackId", "SkillId", "Value" }, new object[] { 2, 2, 2, 4 });
          
            migrationBuilder.InsertData("Internships", new[] { "Id", "Name", "StartDate", "EndDate", "Requirements", "MaxCandidateCount", "RegistrationStartDate", "RegistrationFinishDate", "LanguageType" },
                new object[] { 1, "JS/>NET", DateTime.Now, DateTime.Now, "OOP, JS, C#, .Net, Angular/React", 50, DateTime.Now, DateTime.Now, (int)LanguageType.English });

            migrationBuilder.InsertData("Internships", new[] { "Id", "Name", "StartDate", "EndDate", "Requirements", "MaxCandidateCount", "RegistrationStartDate", "RegistrationFinishDate", "LanguageType" },
                new object[] { 2, "QA Automation", DateTime.Now, DateTime.Now, "Any programming language, QA basics", 30, DateTime.Now, DateTime.Now, (int)LanguageType.English});

            migrationBuilder.InsertData("InternshipStacks", new[] { "Id", "InternshipId", "TechnologyStackType" }, new object[] { 1, 1, (int)StackType.BackEnd });

            migrationBuilder.InsertData("InternshipStacks", new[] { "Id", "InternshipId", "TechnologyStackType" }, new object[] { 2, 2, (int)StackType.Testing});

            migrationBuilder.InsertData("InterviewInvites", new[] { "Id", "UserCandidateId", "ContactDate" }, new object[] { 1, 1, DateTime.Now });

            migrationBuilder.InsertData("InterviewInvites", new[] { "Id", "UserCandidateId", "ContactDate" }, new object[] { 2, 2, DateTime.Now });                               

            migrationBuilder.InsertData("UserInternships", new[] { "Id", "UserId", "InternshipId" }, new object[] { 1, 1, 1 });

            migrationBuilder.InsertData("UserInternships", new[] { "Id", "UserId", "InternshipId" }, new object[] { 2, 2, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}


