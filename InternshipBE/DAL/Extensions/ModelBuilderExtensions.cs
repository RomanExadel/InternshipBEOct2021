using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Shared.Enums;
using System;
using System.Collections.Generic;

namespace DAL.Extensions
{
    public static class ModelBuilderExtensions
    {
        private static readonly string _password = "qwErtY2021";

        private static string[] _roleIds;
        private static string[] _userIds;

        public static ModelBuilder Seed(this ModelBuilder builder)
        {
            builder.FillRoles()
                   .FillUsers()
                   .FillUserRoles()
                   .FillInternships()
                   .FillCountries()
                   .FillTeams()
                   .FillInternshipStacks()
                   .FillCandidates()
                   .FillFeedbacks()
                   .FillSkills()
                   .FillEvaluations()
                   .FillInterviewInvites();

            return builder;
        }

        public static ModelBuilder FillRoles(this ModelBuilder builder)
        {
            var roles = new IdentityRole[]
            {
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = RoleType.Admin.ToString(),
                    NormalizedName = RoleType.Admin.ToString().ToUpper(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = RoleType.Hr.ToString(),
                    NormalizedName = RoleType.Hr.ToString().ToUpper(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = RoleType.Interviewer.ToString(),
                    NormalizedName = RoleType.Interviewer.ToString().ToUpper(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = RoleType.Manager.ToString(),
                    NormalizedName = RoleType.Manager.ToString().ToUpper(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                 new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = RoleType.Mentor.ToString(),
                    NormalizedName = RoleType.Mentor.ToString().ToUpper(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                }
            };

            _roleIds = new string[roles.Length];

            for (int i = 0; i < roles.Length; i++)
            {
                _roleIds[i] = roles[i].Id;
            }

            builder.Entity<IdentityRole>().HasData(roles);

            return builder;
        }

        public static ModelBuilder FillUsers(this ModelBuilder builder)
        {
            var userName1 = "Peter Petrov";
            var email1 = "admntest.team5@gmail.com";
            var userName2 = "Lily Ivanova";
            var email2 = "hrlily.team5@gmail.com";
            var userName3 = "Ivan Sidorov";
            var email3 = "interviewer.team5@gmail.com";
            var userName4 = "Ann Green";
            var email4 = "managertest.team5@gmail.com";
            var userName5 = "Boris Bobrov";
            var email5 = "mentortest.team5@gmail.com";

            var passwordHasher = new PasswordHasher<User>();

            var users = new User[]
            {
                new User
                {
                    Id = Guid.NewGuid().ToString(),
                    RoleType = RoleType.Admin,
                    Position = "BA",
                    UserName = userName1,
                    NormalizedUserName = userName1.ToUpper(),
                    Email = email1,
                    NormalizedEmail = email1.ToUpper(),
                    EmailConfirmed = false,
                    PasswordHash = passwordHasher.HashPassword(null, _password),
                    SecurityStamp = "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "+123656787",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0
                },
                new User
                {
                    Id = Guid.NewGuid().ToString(),
                    RoleType = RoleType.Hr,
                    Position = "Back",
                    UserName = userName2,
                    NormalizedUserName = userName2.ToUpper(),
                    Email = email2,
                    NormalizedEmail = email2.ToUpper(),
                    EmailConfirmed = false,
                    PasswordHash = passwordHasher.HashPassword(null, _password),
                    SecurityStamp = "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "+125656787",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0
                },
                new User
                {
                    Id = Guid.NewGuid().ToString(),
                    RoleType = RoleType.Interviewer,
                    Position = "Front",
                    UserName = userName3,
                    NormalizedUserName = userName3.ToUpper(),
                    Email = email3,
                    NormalizedEmail = email3.ToUpper(),
                    EmailConfirmed = false,
                    PasswordHash = passwordHasher.HashPassword(null, _password),
                    SecurityStamp = "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "+325656787",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0
                },
                new User
                {
                    Id = Guid.NewGuid().ToString(),
                    RoleType = RoleType.Manager,
                    Position = "PO",
                    UserName = userName4,
                    NormalizedUserName = userName4.ToUpper(),
                    Email = email4,
                    NormalizedEmail = email4.ToUpper(),
                    EmailConfirmed = false,
                    PasswordHash = passwordHasher.HashPassword(null, _password),
                    SecurityStamp = "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "+325659787",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0
                },
                new User
                {
                    Id = Guid.NewGuid().ToString(),
                    RoleType = RoleType.Mentor,
                    Position = "PO",
                    UserName = userName5,
                    NormalizedUserName = userName5.ToUpper(),
                    Email = email5,
                    NormalizedEmail = email5.ToUpper(),
                    EmailConfirmed = false,
                    PasswordHash = passwordHasher.HashPassword(null, _password),
                    SecurityStamp = "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "+7777777777777777",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0
                }
            };

            _userIds = new string[users.Length];

            for (int i = 0; i < users.Length; i++)
            {
                _userIds[i] = users[i].Id;
            }

            builder.Entity<User>().HasData(users);

            return builder;
        }

        public static ModelBuilder FillUserRoles(this ModelBuilder builder)
        {
            var userRoles = new List<IdentityUserRole<string>>();

            for (int i = 0; i < _roleIds.Length; i++)
            {
                userRoles.Add(new IdentityUserRole<string>
                {
                    UserId = _userIds[i],
                    RoleId = _roleIds[i],
                });
            }

            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);

            return builder;
        }

        public static ModelBuilder FillInternships(this ModelBuilder builder)
        {
            var internships = new Internship[]
            {
                new Internship
                {
                    Id = 1,
                    Name = "JS/.NET",
                    StartDate = DateTime.UtcNow,
                    EndDate = DateTime.UtcNow,
                    Requirements = "OOP, JS, C#, .Net, Angular/React",
                    MaxCandidateCount = 50,
                    RegistrationStartDate = DateTime.UtcNow,
                    RegistrationFinishDate = DateTime.UtcNow,
                    LanguageType = LanguageType.English,
                    InternshipStatusType = InternshipStatusType.Open,
                    ImageLink = "https://drive.google.com/uc?export=view&id=1tH7hcl7K2kM4HHC6QVXRdq0LPU8yZwd9",
                    SpreadSheetId = "1nhQ98ChhQRfYQWQ2Rf6oyVpjyLetHq34V8muxMvwzSA"
                },
                new Internship
                {
                    Id = 2,
                    Name = "QA Automation",
                    StartDate = DateTime.UtcNow,
                    EndDate = DateTime.UtcNow,
                    Requirements = "Any programming language, QA basics",
                    MaxCandidateCount = 30,
                    RegistrationStartDate = DateTime.UtcNow,
                    RegistrationFinishDate = DateTime.UtcNow,
                    LanguageType = LanguageType.English,
                    InternshipStatusType = InternshipStatusType.Open,
                    ImageLink = "https://drive.google.com/uc?export=view&id=1bvaKnWq0XEuldc4zry3qnrFtZoNRtW5R",
                    SpreadSheetId = "1wdTLLMb8cWVQWpEfJafJCRL1eEF17kE1QQ1jYZGjw6A"
                },
                new Internship
                {
                    Id = 3,
                    Name = "GameDev",
                    StartDate = DateTime.UtcNow,
                    EndDate = DateTime.UtcNow,
                    Requirements = "OOP, Unity, C#, SQL",
                    MaxCandidateCount = 30,
                    RegistrationStartDate = DateTime.UtcNow,
                    RegistrationFinishDate = DateTime.UtcNow,
                    LanguageType = LanguageType.Russian,
                    InternshipStatusType = InternshipStatusType.Open,
                    ImageLink = "https://drive.google.com/uc?export=view&id=1kirFfIPPxUbgOFNGNAk4CL6jf_lEOSKc",
                    SpreadSheetId = "1XSY0mwxSWPA1pXT4VteUoM4UTbuhn2LaqofeK6_7zuo"
                },
               new Internship
                {
                    Id = 4,
                    Name = "Angular/.NET",
                    StartDate = DateTime.UtcNow,
                    EndDate = DateTime.UtcNow,
                    Requirements = "OOP, JS, C#, .Net, Angular/React",
                    MaxCandidateCount = 30,
                    RegistrationStartDate = DateTime.UtcNow,
                    RegistrationFinishDate = DateTime.UtcNow,
                    LanguageType = LanguageType.Russian,
                    InternshipStatusType = InternshipStatusType.Open,
                    ImageLink = "https://drive.google.com/uc?export=view&id=1t-eClTKmOY4asHZkT6y_vvJNR4SMzKbB",
                    SpreadSheetId = "1RW1QxFSlyfGUnm0c-rGGr2_suo_MXrn1e_pUuLSV2tc"
                }
            };

            builder.Entity<Internship>().HasData(internships);

            return builder;
        }

        public static ModelBuilder FillCountries(this ModelBuilder builder)
        {
            var countries = new Country[]
            {
                new Country
                {
                    Id = 1,
                    Name = "Belarus"
                },
                new Country
                {
                    Id = 2,
                    Name = "Russia"
                },
                new Country
                {
                    Id = 3,
                    Name = "Ukraine"
                }
            };

            builder.Entity<Country>().HasData(countries);

            return builder;
        }

        public static ModelBuilder FillTeams(this ModelBuilder builder)
        {
            var teams = new Team[]
            {
                new Team
                {
                    Id = 1,
                    InternshipId = 1,
                    Name = "Team 1 A",
                },
                new Team
                {
                    Id = 2,
                    InternshipId = 2,
                    Name = "Team 1 B",
                }
            };

            builder.Entity<Team>().HasData(teams);

            return builder;
        }

        public static ModelBuilder FillInternshipStacks(this ModelBuilder builder)
        {
            var internshipStacks = new InternshipStack[]
            {
                new InternshipStack
                {
                    Id = 1,
                    TechnologyStackType = StackType.FrontEnd
                },
                new InternshipStack
                {
                    Id = 2,
                    TechnologyStackType = StackType.BackEnd
                },
                new InternshipStack
                {
                    Id = 3,
                    TechnologyStackType = StackType.FullStack
                },
                new InternshipStack
                {
                    Id = 4,
                    TechnologyStackType = StackType.BusinessAnalysis
                },
                new InternshipStack
                {
                    Id = 5,
                    TechnologyStackType = StackType.DevOps
                },
                new InternshipStack
                {
                    Id = 6,
                    TechnologyStackType = StackType.Testing
                }
            };

            builder.Entity<InternshipStack>().HasData(internshipStacks);

            return builder;
        }

        public static ModelBuilder FillCandidates(this ModelBuilder builder)
        {
            var candidates = new Candidate[]
            {
                new Candidate
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Snow",
                    Location = "USA",
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
                    StatusType = CandidateStatusType.New,
                    StackType = StackType.BackEnd,
                    EnglishLevelType = EnglishLevelType.C1,
                    IsPlanningToJoin = true,
                    RegistrationDate = DateTime.UtcNow,
                    InternshipId = 1,
                    TeamId = 1
                },
                new Candidate
                {
                    Id = 2,
                    FirstName = "Hermione",
                    LastName = "Granger",
                    Location = "UK",
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
                    StatusType = CandidateStatusType.New,
                    StackType = StackType.Testing,
                    EnglishLevelType = EnglishLevelType.C2,
                    IsPlanningToJoin = true,
                    RegistrationDate = DateTime.UtcNow,
                    InternshipId = 2,
                    TeamId = 2
                }
            };

            builder.Entity<Candidate>().HasData(candidates);

            return builder;
        }

        public static ModelBuilder FillFeedbacks(this ModelBuilder builder)
        {
            var feedbacks = new Feedback[]
            {
                new Feedback
                {
                    Id = 1,
                    CandidateId = 1,
                    FinalEvaluation = 1,
                    EnglishLevelType = EnglishLevelType.C1,
                    Date = DateTime.UtcNow,
                    Description = "Good knowledge of frameworks, oop, and db",
                    UserId = _userIds[0],
                },
                new Feedback
                {
                    Id = 2,
                    CandidateId = 2,
                    FinalEvaluation = 2,
                    EnglishLevelType = EnglishLevelType.C2,
                    Date = DateTime.UtcNow,
                    Description = "Excellent candidate",
                    UserId = _userIds[0],
                }
            };

            builder.Entity<Feedback>().HasData(feedbacks);

            return builder;
        }

        public static ModelBuilder FillSkills(this ModelBuilder builder)
        {
            var skills = new Skill[]
            {
                new Skill
                {
                    Id = 1,
                    StackType = StackType.BackEnd,
                    Name = "OOP",
                    IsHardSkill = true,
                },
                new Skill
                {
                    Id = 2,
                    StackType = StackType.Testing,
                    Name = "Java",
                    IsHardSkill = true,
                }
            };

            builder.Entity<Skill>().HasData(skills);

            return builder;
        }

        public static ModelBuilder FillEvaluations(this ModelBuilder builder)
        {
            var evaluations = new Evaluation[]
            {
                new Evaluation
                {
                    Id = 1,
                    FeedbackId = 1,
                    SkillId = 1,
                    Value = 4,
                },
                new Evaluation
                {
                    Id = 2,
                    FeedbackId = 2,
                    SkillId = 2,
                    Value = 4,
                }
            };

            builder.Entity<Evaluation>().HasData(evaluations);

            return builder;
        }

        public static ModelBuilder FillInterviewInvites(this ModelBuilder builder)
        {
            var interviewInvites = new InterviewInvite[]
            {
                new InterviewInvite
                {
                    Id = 1,
                    UserId = _userIds[0],
                    CandidateId = 1,
                    ContactDate = DateTime.UtcNow,
                },
                new InterviewInvite
                {
                    Id = 2,
                    UserId = _userIds[0],
                    CandidateId = 2,
                    ContactDate = DateTime.UtcNow,
                }
            };

            builder.Entity<InterviewInvite>().HasData(interviewInvites);

            return builder;
        }
    }
}
