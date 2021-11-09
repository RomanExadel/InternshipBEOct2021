using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class asdasfaf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Internships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Requirements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxCandidateCount = table.Column<int>(type: "int", nullable: false),
                    RegistrationStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationFinishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LanguageType = table.Column<int>(type: "int", nullable: false),
                    InternshipStatusType = table.Column<int>(type: "int", nullable: false),
                    ImageLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Internships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StackType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsHardSkill = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BestContactTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BestContactTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BestContactTimes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CountryInternship",
                columns: table => new
                {
                    CountriesId = table.Column<int>(type: "int", nullable: false),
                    InternshipsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryInternship", x => new { x.CountriesId, x.InternshipsId });
                    table.ForeignKey(
                        name: "FK_CountryInternship_Countries_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryInternship_Internships_InternshipsId",
                        column: x => x.InternshipsId,
                        principalTable: "Internships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InternshipStacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InternshipId = table.Column<int>(type: "int", nullable: false),
                    TechnologyStackType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternshipStacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InternshipStacks_Internships_InternshipId",
                        column: x => x.InternshipId,
                        principalTable: "Internships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InternshipUser",
                columns: table => new
                {
                    InternshipsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternshipUser", x => new { x.InternshipsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_InternshipUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InternshipUser_Internships_InternshipsId",
                        column: x => x.InternshipsId,
                        principalTable: "Internships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InternshipId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Internships_InternshipId",
                        column: x => x.InternshipId,
                        principalTable: "Internships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Links = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimarySkill = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentJob = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfessionalCertificates = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BestContactTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TestTaskEvaluation = table.Column<int>(type: "int", nullable: false),
                    StatusType = table.Column<int>(type: "int", nullable: false),
                    StackType = table.Column<int>(type: "int", nullable: false),
                    EnglishLevelType = table.Column<int>(type: "int", nullable: false),
                    IsPlanningToJoin = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InternshipId = table.Column<int>(type: "int", nullable: true),
                    TeamId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidates_Internships_InternshipId",
                        column: x => x.InternshipId,
                        principalTable: "Internships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Candidates_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeamUser",
                columns: table => new
                {
                    TeamsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamUser", x => new { x.TeamsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_TeamUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamUser_Teams_TeamsId",
                        column: x => x.TeamsId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CandidateUser",
                columns: table => new
                {
                    CandidatesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateUser", x => new { x.CandidatesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_CandidateUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidateUser_Candidates_CandidatesId",
                        column: x => x.CandidatesId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    EnglishLevelType = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InterviewInvites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    ContactDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewInvites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InterviewInvites_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InterviewInvites_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evaluations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeedbackId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evaluations_Feedbacks_FeedbackId",
                        column: x => x.FeedbackId,
                        principalTable: "Feedbacks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evaluations_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08d27e61-af58-4582-8102-47c3712cdd7d", "e2ed214b-fc50-469d-b0a9-f4b3672a9415", "Hr", "HR" },
                    { "00afa624-b115-4c6d-ba1b-864c643d22a5", "e52abb9e-9589-4d4e-8340-a5242ee17405", "Interviewer", "INTERVIEWER" },
                    { "db22ea51-0b4a-474d-84b9-77e5b0a04e09", "fa543938-3688-4b7a-b0eb-caa868b8d911", "Manager", "MANAGER" },
                    { "b785125f-cb6c-4bc4-8450-9dbc06346184", "3407d270-a989-4011-94d0-377f8e6783c9", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "82bfa642-c39f-4b79-ac2f-e6101edc0aae", 0, "083d56d3-1913-498a-b063-3b9cc1c3d6e2", "li@gmail.com", false, true, null, "LI@GMAIL.COM", "MASHA", "AQAAAAEAACcQAAAAELsnJb5Tqz3MqbAiholeFVKCZP3yyK8wYc31ZJoo8aIO8BcYD48wJ4oh3cEfCBjNlw==", "+123656787", false, "BA", "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Masha" },
                    { "b4218e31-3cc1-4e72-8723-eba129530c18", 0, "831e34e4-e474-4435-9dcf-cb5a1a20c539", "max@gmail.com", false, true, null, "MAX@GMAIL.COM", "MAXIM", "AQAAAAEAACcQAAAAEPdAqAzXVIdpVJZ6Ndr7jRWO9oLLcvok6Dp9q/XR8EBj/bZwo8uO49bFuBaUG6QH0A==", "+125656787", false, "Back", "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Maxim" },
                    { "34cf4002-2193-429b-8808-e716645a0666", 0, "3f56f163-aa1d-4844-9f34-0ad7fde0154c", "user@example.com", false, true, null, "USER@EXAMPLE.COM", "DASHA", "AQAAAAEAACcQAAAAELEkGE3JXvnytaoWGce/A/JFLix9lv3UUNUd0TppoMlQtUoQpEy1MOWT1H9T2AwcXg==", "+325656787", false, "Front", "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Dasha" },
                    { "beab8d34-6b8b-4162-915b-7ccc7311fdc6", 0, "7b37dc5c-2d42-4aec-976c-870ce8f3ede2", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ALEXANDR", "AQAAAAEAACcQAAAAEMV6zdUbHNPhXeyoxp64c8zmr7DrdRDWODdOk7dPrvtIBJUgGQaY7wRc5gj50+p2eQ==", "+325659787", false, "PO", "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Alexandr" }
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
                    { 1, new DateTime(2021, 11, 9, 11, 33, 43, 451, DateTimeKind.Utc).AddTicks(5480), "image/link/1", 0, 0, 50, "JS/>NET", new DateTime(2021, 11, 9, 11, 33, 43, 451, DateTimeKind.Utc).AddTicks(7062), new DateTime(2021, 11, 9, 11, 33, 43, 451, DateTimeKind.Utc).AddTicks(6603), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 9, 11, 33, 43, 451, DateTimeKind.Utc).AddTicks(5014) },
                    { 2, new DateTime(2021, 11, 9, 11, 33, 43, 451, DateTimeKind.Utc).AddTicks(8517), "image/link/2", 0, 0, 30, "QA Automation", new DateTime(2021, 11, 9, 11, 33, 43, 451, DateTimeKind.Utc).AddTicks(8521), new DateTime(2021, 11, 9, 11, 33, 43, 451, DateTimeKind.Utc).AddTicks(8520), "Any programming language, QA basics", new DateTime(2021, 11, 9, 11, 33, 43, 451, DateTimeKind.Utc).AddTicks(8514) }
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
                    { "08d27e61-af58-4582-8102-47c3712cdd7d", "82bfa642-c39f-4b79-ac2f-e6101edc0aae" },
                    { "00afa624-b115-4c6d-ba1b-864c643d22a5", "b4218e31-3cc1-4e72-8723-eba129530c18" },
                    { "db22ea51-0b4a-474d-84b9-77e5b0a04e09", "34cf4002-2193-429b-8808-e716645a0666" },
                    { "b785125f-cb6c-4bc4-8450-9dbc06346184", "beab8d34-6b8b-4162-915b-7ccc7311fdc6" }
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
                values: new object[] { 1, new DateTime(2021, 11, 9, 11, 33, 43, 454, DateTimeKind.Utc).AddTicks(1266), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, true, "Snow", "-", "Arizona", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 9, 11, 33, 43, 454, DateTimeKind.Utc).AddTicks(3356), "live:j.snow", 1, 0, 1, 4 });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
                values: new object[] { 2, new DateTime(2021, 11, 9, 11, 33, 43, 454, DateTimeKind.Utc).AddTicks(4496), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, true, "Granger", "-", "London", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 9, 11, 33, 43, 454, DateTimeKind.Utc).AddTicks(4501), "live:h.granger", 5, 0, 2, 4 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 9, 11, 33, 43, 454, DateTimeKind.Utc).AddTicks(9729), "Good knowledge of frameworks, oop, and db", 4, "82bfa642-c39f-4b79-ac2f-e6101edc0aae" },
                    { 2, 2, new DateTime(2021, 11, 9, 11, 33, 43, 455, DateTimeKind.Utc).AddTicks(884), "Excellent candidate", 5, "82bfa642-c39f-4b79-ac2f-e6101edc0aae" }
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 11, 9, 11, 33, 43, 456, DateTimeKind.Utc).AddTicks(5715), "82bfa642-c39f-4b79-ac2f-e6101edc0aae" },
                    { 2, 2, new DateTime(2021, 11, 9, 11, 33, 43, 456, DateTimeKind.Utc).AddTicks(6140), "82bfa642-c39f-4b79-ac2f-e6101edc0aae" }
                });

            migrationBuilder.InsertData(
                table: "Evaluations",
                columns: new[] { "Id", "FeedbackId", "SkillId", "Value" },
                values: new object[] { 1, 1, 1, 4 });

            migrationBuilder.InsertData(
                table: "Evaluations",
                columns: new[] { "Id", "FeedbackId", "SkillId", "Value" },
                values: new object[] { 2, 2, 2, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BestContactTimes_UserId",
                table: "BestContactTimes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_InternshipId",
                table: "Candidates",
                column: "InternshipId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_TeamId",
                table: "Candidates",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateUser_UsersId",
                table: "CandidateUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryInternship_InternshipsId",
                table: "CountryInternship",
                column: "InternshipsId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluations_FeedbackId",
                table: "Evaluations",
                column: "FeedbackId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluations_SkillId",
                table: "Evaluations",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_CandidateId",
                table: "Feedbacks",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_UserId",
                table: "Feedbacks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_InternshipStacks_InternshipId",
                table: "InternshipStacks",
                column: "InternshipId");

            migrationBuilder.CreateIndex(
                name: "IX_InternshipUser_UsersId",
                table: "InternshipUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewInvites_CandidateId",
                table: "InterviewInvites",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewInvites_UserId",
                table: "InterviewInvites",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_InternshipId",
                table: "Teams",
                column: "InternshipId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamUser_UsersId",
                table: "TeamUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BestContactTimes");

            migrationBuilder.DropTable(
                name: "CandidateUser");

            migrationBuilder.DropTable(
                name: "CountryInternship");

            migrationBuilder.DropTable(
                name: "Evaluations");

            migrationBuilder.DropTable(
                name: "InternshipStacks");

            migrationBuilder.DropTable(
                name: "InternshipUser");

            migrationBuilder.DropTable(
                name: "InterviewInvites");

            migrationBuilder.DropTable(
                name: "TeamUser");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Candidates");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Internships");
        }
    }
}
