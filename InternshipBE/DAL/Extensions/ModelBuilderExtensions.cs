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
        private static readonly string _password = "Password";

        private static string[] _roleIds;
        private static string[] _userIds;
        private static int[] _internshipIds;
        private static int[] _teamIds;
        private static int[] _candidateIds;
        private static int[] _feedbackIds;
        private static int[] _skillIds;

        public static ModelBuilder Seed(this ModelBuilder builder)
        {
            builder.FillRoles()
                   .FillUsers()
                   .FillUserRoles()
                   .FillInternships()
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
                    Name = RoleType.Admin.ToString(),
                    NormalizedName = RoleType.Admin.ToString().ToUpper(),
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
            var userName1 = "Masha";
            var email1 = "li@gmail.com";
            var userName2 = "Maxim";
            var email2 = "max@gmail.com";
            var userName3 = "Dasha";
            var email3 = "user@example.com";
            var userName4 = "Alexandr";
            var email4 = "admin@gmail.com";

            var passwordHasher = new PasswordHasher<User>();

            var users = new User[]
            {
                new User
                {
                    Id = Guid.NewGuid().ToString(),
                    Position = "BA",
                    BestContactTime = DateTime.UtcNow,
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
                    Position = "Back",
                    BestContactTime = DateTime.UtcNow,
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
                    Position = "Front",
                    BestContactTime = DateTime.UtcNow,
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
                    Position = "PO",
                    BestContactTime = DateTime.UtcNow,
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
            var id = 1;

            var internships = new Internship[]
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

            _internshipIds = new int[internships.Length];

            for (int i = 0; i < internships.Length; i++)
            {
                _internshipIds[i] = internships[i].Id;
            }

            builder.Entity<Internship>().HasData(internships);

            return builder;
        }

        public static ModelBuilder FillTeams(this ModelBuilder builder)
        {
            var id = 1;

            var teams = new Team[]
            {
                new Team
                {
                    Id = id++,
                    InternshipId = _internshipIds[0],
                    Name = "Team 1 A",
                },
                new Team
                {
                    Id = id++,
                    InternshipId = _internshipIds[1],
                    Name = "Team 1 B",
                }
            };

            _teamIds = new int[teams.Length];

            for (int i = 0; i < teams.Length; i++)
            {
                _teamIds[i] = teams[i].Id;
            }

            builder.Entity<Team>().HasData(teams);

            return builder;
        }

        public static ModelBuilder FillInternshipStacks(this ModelBuilder builder)
        {
            var id = 1;

            var internshipStacks = new InternshipStack[]
            {
                new InternshipStack
                {
                    Id = id++,
                    InternshipId = _internshipIds[0],
                    TechnologyStackType = StackType.BackEnd
                },
                    new InternshipStack
                {
                    Id = id++,
                    InternshipId = _internshipIds[1],
                    TechnologyStackType = StackType.Testing
                }
            };

            builder.Entity<InternshipStack>().HasData(internshipStacks);

            return builder;
        }

        public static ModelBuilder FillCandidates(this ModelBuilder builder)
        {
            var id = 1;

            var candidates = new Candidate[]
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
                    InternshipId = _internshipIds[0],
                    TeamId = _teamIds[0]
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
                    InternshipId = _internshipIds[1],
                    TeamId = _teamIds[1]
                }
            };

            _candidateIds = new int[candidates.Length];

            for (int i = 0; i < candidates.Length; i++)
            {
                _candidateIds[i] = candidates[i].Id;
            }

            builder.Entity<Candidate>().HasData(candidates);

            return builder;
        }

        public static ModelBuilder FillFeedbacks(this ModelBuilder builder)
        {
            var id = 1;

            var feedbacks = new Feedback[]
            {
                new Feedback
                {
                    Id = id++,
                    CandidateId = _candidateIds[0],
                    EnglishLevelType = EnglishLevelType.C1,
                    Date = DateTime.UtcNow,
                    Description = "Good knowledge of frameworks, oop, and db",
                    UserId = _userIds[0],
                },
                new Feedback
                {
                    Id = id++,
                    CandidateId = _candidateIds[1],
                    EnglishLevelType = EnglishLevelType.C2,
                    Date = DateTime.UtcNow,
                    Description = "Excellent candidate",
                    UserId = _userIds[0],
                }
            };

            _feedbackIds = new int[feedbacks.Length];

            for (int i = 0; i < feedbacks.Length; i++)
            {
                _feedbackIds[i] = feedbacks[i].Id;
            }

            builder.Entity<Feedback>().HasData(feedbacks);

            return builder;
        }

        public static ModelBuilder FillSkills(this ModelBuilder builder)
        {
            var id = 1;

            var skills = new Skill[]
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

            _skillIds = new int[skills.Length];

            for (int i = 0; i < skills.Length; i++)
            {
                _skillIds[i] = skills[i].Id;
            }

            builder.Entity<Skill>().HasData(skills);

            return builder;
        }

        public static ModelBuilder FillEvaluations(this ModelBuilder builder)
        {
            var id = 1;

            var evaluations = new Evaluation[]
            {
                new Evaluation
                {
                    Id = id++,
                    FeedbackId = _feedbackIds[0],
                    SkillId = _skillIds[0],
                    Value = 4,
                },
                new Evaluation
                {
                    Id = id++,
                    FeedbackId = _feedbackIds[1],
                    SkillId = _skillIds[1],
                    Value = 4,
                }
            };

            builder.Entity<Evaluation>().HasData(evaluations);

            return builder;
        }

        public static ModelBuilder FillInterviewInvites(this ModelBuilder builder)
        {
            var id = 1;

            var interviewInvites = new InterviewInvite[]
            {
                new InterviewInvite
                {
                    Id = id++,
                    UserId = _userIds[0],
                    CandidateId = _candidateIds[0],
                    ContactDate = DateTime.UtcNow,
                },
                new InterviewInvite
                {
                    Id = id++,
                    UserId = _userIds[0],
                    CandidateId = _candidateIds[1],
                    ContactDate = DateTime.UtcNow,
                }
            };

            builder.Entity<InterviewInvite>().HasData(interviewInvites);

            return builder;
        }
    }
}
