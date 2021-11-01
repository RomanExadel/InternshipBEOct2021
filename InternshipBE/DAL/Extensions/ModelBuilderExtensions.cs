using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Shared.Enums;
using System;

namespace DAL.Extensions
{
    public static class ModelBuilderExtensions
    {
        private static User[] _users;
        private static Internship[] _internships;
        private static Team[] _teams;
        private static InternshipStack[] _internshipStacks;
        private static Candidate[] _candidates;
        private static Feedback[] _feedbacks;
        private static Skill[] _skills;
        private static Evaluation[] _evaluations;
        private static InterviewInvite[] _interviewInvites;

        public static void Seed(this ModelBuilder builder)
        {
            builder.FillUsers();
            builder.FillInternships();
            builder.FillTeams();
            builder.FillInternshipStacks();
            builder.FillCandidates();
            builder.FillFeedbacks();
            builder.FillSkills();
            builder.FillEvaluations();
            builder.FillInterviewInvites();
        }

        public static void FillUsers(this ModelBuilder builder)
        {
            var userName1 = "Masha";
            var email1 = "li@gmail.com";
            var userName2 = "Maxim";
            var email2 = "max@gmail.com";
            var userName3 = "Dasha";
            var email3 = "user@example.com";
            var userName4 = "Alexandr";
            var email4 = "admin@gmail.com";

            _users = new User[]
            {
                new User
                {
                    Id = "3827e25d-8989-4881-9f25-807d14878c1b",
                    Position = "BA",
                    BestContactTime = DateTime.UtcNow,
                    UserName = userName1,
                    NormalizedUserName = userName1.ToUpper(),
                    Email = email1,
                    NormalizedEmail = email1.ToUpper(),
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAEAACcQAAAAEFrfBeLl7wG60Syi2unYkVUM4kp/0A8RAZdc51M8e/5GokOv0qDZF+aGBSVaSV6vag==",
                    SecurityStamp = "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7",
                    ConcurrencyStamp = "d722e70d-72fc-4f08-8fdc-afec3cef3c4f",
                    PhoneNumber = "+123656787",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0
                },
                new User
                {
                    Id = "5516d40a-40bf-482c-8575-34a18478ac89",
                    Position = "Back",
                    BestContactTime = DateTime.UtcNow,
                    UserName = userName2,
                    NormalizedUserName = userName2.ToUpper(),
                    Email = email2,
                    NormalizedEmail = email2.ToUpper(),
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAEAACcQAAAAEA/2Sy0cS1B+wbGk2R/Llrp6iuFzZjbJGu1Egoj2MYPPMaowQUgECV4Teg/K5xy/fg==",
                    SecurityStamp = "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF",
                    ConcurrencyStamp = "2c39a495-1b10-49f9-926c-a40d078418ad",
                    PhoneNumber = "+125656787",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0
                },
                new User
                {
                    Id = "57f2fe4e-64af-40b4-a279-5af5f1db8a8a",
                    Position = "Front",
                    BestContactTime = DateTime.UtcNow,
                    UserName = userName3,
                    NormalizedUserName = userName3.ToUpper(),
                    Email = email3,
                    NormalizedEmail = email3.ToUpper(),
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAEAACcQAAAAEEVFxbsq/jnZ4avRoKtiCKb4QPzojCZDr6y9N3exNngtHExLdISgHDxhvprupVr9iQ==",
                    SecurityStamp = "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC",
                    ConcurrencyStamp = "09fb73b8-aab6-4ff4-a27b-4426a8b73570",
                    PhoneNumber = "+325656787",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0
                },
                new User
                {
                    Id = "ff8a8331-c30a-4a6c-8860-0b49c533aa2c",
                    Position = "PO",
                    BestContactTime = DateTime.UtcNow,
                    UserName = userName4,
                    NormalizedUserName = userName4.ToUpper(),
                    Email = email4,
                    NormalizedEmail = email4.ToUpper(),
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAEAACcQAAAAEK+m9ZBEt0HpxkxRafiiKjUsm1GShqzdyFWgzC1tGIApjSTzcLx49pKc1wIKrgN0tg==",
                    SecurityStamp = "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS",
                    ConcurrencyStamp = "66f70ef0-1083-48a6-9c14-d54557737744",
                    PhoneNumber = "+325659787",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0
                }
            };

            builder.Entity<User>().HasData(_users);
        }

        public static void FillInternships(this ModelBuilder builder)
        {
            var id = 1;

            _internships = new Internship[]
            {
                new Internship
                {
                    Id = id++,
                    Name = "JS/>NET",
                    StartDate = DateTime.UtcNow,
                    EndDate = DateTime.UtcNow,
                    Requirements = "OOP, JS, C#, .Net, Angular/React",
                    MaxCandidateCount = 50,
                    RegistrationStartDate = DateTime.UtcNow,
                    RegistrationFinishDate = DateTime.UtcNow,
                    LanguageType = LanguageType.English
                },
                new Internship
                {
                    Id = id++,
                    Name = "QA Automation",
                    StartDate = DateTime.UtcNow,
                    EndDate = DateTime.UtcNow,
                    Requirements = "Any programming language, QA basics",
                    MaxCandidateCount = 30,
                    RegistrationStartDate = DateTime.UtcNow,
                    RegistrationFinishDate = DateTime.UtcNow,
                    LanguageType = LanguageType.English
                }
            };

            builder.Entity<Internship>().HasData(_internships);
        }

        public static void FillTeams(this ModelBuilder builder)
        {
            var id = 1;

            _teams = new Team[]
            {
                new Team
                {
                    Id = id++,
                    InternshipId = _internships[0].Id,
                    Name = "Team 1 A",
                },
                new Team
                {
                    Id = id++,
                    InternshipId = _internships[1].Id,
                    Name = "Team 1 B",
                }
            };

            builder.Entity<Team>().HasData(_teams);
        }

        public static void FillInternshipStacks(this ModelBuilder builder)
        {
            var id = 1;

            _internshipStacks = new InternshipStack[]
            {
                new InternshipStack
                {
                    Id = id++,
                    InternshipId = _internships[0].Id,
                    TechnologyStackType = StackType.BackEnd
                },
                    new InternshipStack
                {
                    Id = id++,
                    InternshipId = _internships[1].Id,
                    TechnologyStackType = StackType.Testing
                }
            };

            builder.Entity<InternshipStack>().HasData(_internshipStacks);
        }

        public static void FillCandidates(this ModelBuilder builder)
        {
            var id = 1;

            _candidates = new Candidate[]
            {
                new Candidate
                {
                    Id = id++,
                    FirstName = "John",
                    LastName = "Snow",
                    Location = "Arizona",
                    Phone = "+123456789",
                    Email = "j.snow@gmail.com",
                    Skype = "live:j.snow",
                    Education = "Harvard University",
                    Links = "-",
                    OtherInfo = "-",
                    PrimarySkill = "OOP, C#",
                    CurrentJob = "Student",
                    ProfessionalCertificates = "-",
                    BestContactTime = DateTime.UtcNow,
                    TestTaskEvaluation = 4,
                    StatusType = StatusType.New,
                    StackType = StackType.BackEnd,
                    EnglishLevelType = EnglishLevelType.C1,
                    IsPlanningToJoin = true,
                    RegistationDate = DateTime.UtcNow,
                    InternshipId = _internships[0].Id,
                    //TeamId = _teams[0].Id // Почему-то создаётся доп. таблица TeamUser
                },
                new Candidate
                {
                    Id = id++,
                    FirstName = "Hermione",
                    LastName = "Granger",
                    Location = "London",
                    Phone = "+2356416789",
                    Email = "h.granger@gmail.com",
                    Skype = "live:h.granger",
                    Education = "Hogwarts",
                    Links = "-",
                    OtherInfo = "-",
                    PrimarySkill = "C++, QA basics",
                    CurrentJob = "Student",
                    ProfessionalCertificates = "-",
                    BestContactTime = DateTime.UtcNow,
                    TestTaskEvaluation = 4,
                    StatusType = StatusType.New,
                    StackType = StackType.Testing,
                    EnglishLevelType = EnglishLevelType.C2,
                    IsPlanningToJoin = true,
                    RegistationDate = DateTime.UtcNow,
                    InternshipId = _internships[1].Id,
                    //TeamId = _teams[1].Id // Почему-то создаётся доп. таблица TeamUser
                }
            };

            builder.Entity<Candidate>().HasData(_candidates);
        }

        public static void FillFeedbacks(this ModelBuilder builder)
        {
            var id = 1;

            _feedbacks = new Feedback[]
            {
                new Feedback
                {
                    Id = id++,
                    CandidateId = _candidates[0].Id,
                    EnglishLevelType = EnglishLevelType.C1,
                    Date = DateTime.UtcNow,
                    Description = "Good knowledge of frameworks, oop, and db",
                    UserId = _users[0].Id,
                },
                new Feedback
                {
                    Id = id++,
                    CandidateId = _candidates[1].Id,
                    EnglishLevelType = EnglishLevelType.C2,
                    Date = DateTime.UtcNow,
                    Description = "Excellent candidate",
                    UserId = _users[0].Id,
                }
            };

            builder.Entity<Feedback>().HasData(_feedbacks);
        }

        public static void FillSkills(this ModelBuilder builder)
        {
            var id = 1;

            _skills = new Skill[]
            {
                new Skill
                {
                    Id = id++,
                    StackType = StackType.BackEnd,
                    Name = "OOP",
                    IsHardSkill = true,
                },
                new Skill
                {
                    Id = id++,
                    StackType = StackType.Testing,
                    Name = "Java",
                    IsHardSkill = true,
                }
            };

            builder.Entity<Skill>().HasData(_skills);
        }

        public static void FillEvaluations(this ModelBuilder builder)
        {
            var id = 1;

            _evaluations = new Evaluation[]
            {
                new Evaluation
                {
                    Id = id++,
                    FeedbackId = _feedbacks[0].Id,
                    SkillId = _skills[0].Id,
                    Value = 4,
                },
                new Evaluation
                {
                    Id = id++,
                    FeedbackId = _feedbacks[1].Id,
                    SkillId = _skills[1].Id,
                    Value = 4,
                }
            };

            builder.Entity<Evaluation>().HasData(_evaluations);
        }

        public static void FillInterviewInvites(this ModelBuilder builder)
        {
            var id = 1;

            _interviewInvites = new InterviewInvite[]
            {
                new InterviewInvite
                {
                    Id = id++,
                    UserId = _users[0].Id,
                    CandidateId = _candidates[0].Id,
                    ContactDate = DateTime.UtcNow,
                },
                new InterviewInvite
                {
                    Id = id++,
                    UserId = _users[0].Id,
                    CandidateId = _candidates[1].Id,
                    ContactDate = DateTime.UtcNow,
                }
            };

            builder.Entity<InterviewInvite>().HasData(_interviewInvites);
        }
    }
}
