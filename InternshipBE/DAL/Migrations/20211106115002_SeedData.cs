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
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211106115002_SeedData.cs
                    { "bb657f97-a307-4b1a-b4e6-d4998188c016", "229340ce-3c4e-410e-86ff-6af9c9ce1951", "Admin", "ADMIN" },
                    { "336d4223-7ab3-4645-8483-745111accb64", "e38938d1-1d3d-436a-914a-fd7dd0398d25", "Interviewer", "INTERVIEWER" },
                    { "20b10174-ca20-4deb-9947-35e50b135ea3", "39e55a08-cf06-4119-be9d-dc7f8d265002", "Hr", "HR" },
                    { "7189f2c9-a26c-4a0a-8ed7-46d01d0f34cb", "b395fe31-6c18-4e25-ac0c-8f0603f8eed7", "Manager", "MANAGER" }
=======
                    { "be137946-d526-4425-8767-f656188e4084", "216b22e9-8531-422c-bd86-c489f5d13d83", "Hr", "HR" },
                    { "552d9de1-fd99-4600-b196-2f95e4b650be", "4735008b-c148-4ebf-8d56-cfd6d093003e", "Interviewer", "INTERVIEWER" },
                    { "8597b9f8-e659-4aa7-a24c-a6c56f6ad60a", "aeb2101a-e77f-4000-9cf9-fbcbb9328e3e", "Manager", "MANAGER" },
                    { "378d39e1-e162-4df2-81a7-5f0c1079802b", "809f4e5e-cf18-4b2c-a0e1-d2cc0c3a833a", "Admin", "ADMIN" }
>>>>>>> 6db81dc8b819b296d080d2e132deb999640b1b9d:InternshipBE/DAL/Migrations/20211105125451_SeedData.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BestContactTime", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "RoleType", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211106115002_SeedData.cs
                    { "3a8c6327-610c-46a0-bf2f-3fd7455fa3bb", 0, new DateTime(2021, 11, 6, 11, 50, 1, 85, DateTimeKind.Utc).AddTicks(1143), "7e2f53c0-254e-4de0-bec0-943daf6315d5", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ALEXANDR", "AQAAAAEAACcQAAAAEIvVh+D57nVvvM9VXzWLrT/8ph0a/jCu9GOwLACSuPw/NNOzYWCRmerRkWRAGHe18g==", "+325659787", false, "PO", 4, "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Alexandr" },
                    { "5e6598e7-2900-491c-ba9e-9cc453470b63", 0, new DateTime(2021, 11, 6, 11, 50, 1, 76, DateTimeKind.Utc).AddTicks(9711), "72f7a0cb-47ae-437f-9a57-6703af96a46a", "user@example.com", false, true, null, "USER@EXAMPLE.COM", "DASHA", "AQAAAAEAACcQAAAAEDahkVsD17amFWnNa2GebBUBBD/irKOlnh9NXlKL8sZq7EL5ToBp0OhEAHEaMWC1+g==", "+325656787", false, "Front", 3, "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Dasha" },
                    { "3f0c129e-6c9c-4f7e-abad-393f2dddad8d", 0, new DateTime(2021, 11, 6, 11, 50, 1, 68, DateTimeKind.Utc).AddTicks(8761), "29c3a715-4a59-42d8-a5b2-00b0b463a751", "max@gmail.com", false, true, null, "MAX@GMAIL.COM", "MAXIM", "AQAAAAEAACcQAAAAEG/sCX6+ui14DDs9U8rMt3iPhGpPCIRIohgjzeoQBwCP3VPIGGM/BCnmExaPqs24Sw==", "+125656787", false, "Back", 2, "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Maxim" },
                    { "5e5fca25-1ce8-43a9-b9a6-a335be62c7e8", 0, new DateTime(2021, 11, 6, 11, 50, 1, 51, DateTimeKind.Utc).AddTicks(9919), "1046d6ad-3e8a-4aff-a664-4af7c2890c69", "li@gmail.com", false, true, null, "LI@GMAIL.COM", "MASHA", "AQAAAAEAACcQAAAAEHtpv9JVSMibX8InjyIfnjzfS3hkzb1/4TXxDwRmKgvvDWW3YsQdswutz/w2ynJAiQ==", "+123656787", false, "BA", 1, "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Masha" }
=======
                    { "02be0f0a-a72f-4f22-999b-84aa4958b466", 0, new DateTime(2021, 11, 5, 12, 54, 50, 704, DateTimeKind.Utc).AddTicks(4259), "9a119fd9-e37a-4b75-b201-117364e5e069", "li@gmail.com", false, true, null, "LI@GMAIL.COM", "MASHA", "AQAAAAEAACcQAAAAECDYp8bJdgQaL3G4IKegc3VGs+MevORfAE9ACj5WqlFr3cY7fvhFGUdQ9+Tu8MHfRg==", "+123656787", false, "BA", 1, "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7", false, "Masha" },
                    { "3b7d01f5-238e-4c4d-987c-028e3bf7f159", 0, new DateTime(2021, 11, 5, 12, 54, 50, 723, DateTimeKind.Utc).AddTicks(1489), "67445591-a868-497a-b1d9-5fd70065619c", "max@gmail.com", false, true, null, "MAX@GMAIL.COM", "MAXIM", "AQAAAAEAACcQAAAAEFKtweMY44KsYuNftxwX7Azow9h9RxN3XDxdqgWFKicl17CZ94pH0nX3ZYFJjGae/Q==", "+125656787", false, "Back", 2, "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF", false, "Maxim" },
                    { "5b57ae45-417b-4fa2-b650-d968b202f4d6", 0, new DateTime(2021, 11, 5, 12, 54, 50, 731, DateTimeKind.Utc).AddTicks(7085), "4405186d-822f-4090-856a-021039aad67f", "user@example.com", false, true, null, "USER@EXAMPLE.COM", "DASHA", "AQAAAAEAACcQAAAAEHi1xRZ+Hny27YHoTJ75wMhBbMfrh1CTDKkgaH0eBfl3j+nI3sUS3067Sixwg+bchA==", "+325656787", false, "Front", 3, "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC", false, "Dasha" },
                    { "2df58414-c957-4959-a74c-2c15fefaddb7", 0, new DateTime(2021, 11, 5, 12, 54, 50, 740, DateTimeKind.Utc).AddTicks(4194), "6e1126ba-ca81-4ee9-b380-d94abcaaedcb", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ALEXANDR", "AQAAAAEAACcQAAAAEN2QEvTv3fPEiCblIx6uQlWHAtiUrFzPWCnngFLpiXeURRurSfY9H8Q9s7eNH1CJuQ==", "+325659787", false, "PO", 4, "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS", false, "Alexandr" }
>>>>>>> 6db81dc8b819b296d080d2e132deb999640b1b9d:InternshipBE/DAL/Migrations/20211105125451_SeedData.cs
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
                table: "Internships",
                columns: new[] { "Id", "EndDate", "ImageLink", "InternshipStatusType", "LanguageType", "MaxCandidateCount", "Name", "RegistrationFinishDate", "RegistrationStartDate", "Requirements", "StartDate" },
                values: new object[,]
                {
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211106115002_SeedData.cs
                    { 4, new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(9388), "image/link/2", 0, 1, 30, "Angular/>NET", new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(9391), new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(9391), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(9388) },
                    { 3, new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(9385), "image/link/2", 0, 1, 30, "GameDev", new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(9388), new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(9388), "OOP, Unity, C#, SQL", new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(9385) },
                    { 2, new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(9379), "image/link/2", 0, 0, 30, "QA Automation", new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(9382), new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(9382), "Any programming language, QA basics", new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(9379) },
                    { 1, new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(6058), "image/link/1", 0, 0, 50, "JS/>NET", new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(7910), new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(7513), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 6, 11, 50, 1, 94, DateTimeKind.Utc).AddTicks(5620) }
=======
                    { 1, new DateTime(2021, 11, 5, 12, 54, 50, 750, DateTimeKind.Utc).AddTicks(447), "image/link/1", 0, 0, 50, "JS/>NET", new DateTime(2021, 11, 5, 12, 54, 50, 750, DateTimeKind.Utc).AddTicks(1990), new DateTime(2021, 11, 5, 12, 54, 50, 750, DateTimeKind.Utc).AddTicks(1596), "OOP, JS, C#, .Net, Angular/React", new DateTime(2021, 11, 5, 12, 54, 50, 750, DateTimeKind.Utc).AddTicks(24) },
                    { 2, new DateTime(2021, 11, 5, 12, 54, 50, 750, DateTimeKind.Utc).AddTicks(4171), "image/link/2", 0, 0, 30, "QA Automation", new DateTime(2021, 11, 5, 12, 54, 50, 750, DateTimeKind.Utc).AddTicks(4174), new DateTime(2021, 11, 5, 12, 54, 50, 750, DateTimeKind.Utc).AddTicks(4171), "Any programming language, QA basics", new DateTime(2021, 11, 5, 12, 54, 50, 750, DateTimeKind.Utc).AddTicks(4168) }
>>>>>>> 6db81dc8b819b296d080d2e132deb999640b1b9d:InternshipBE/DAL/Migrations/20211105125451_SeedData.cs
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
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211106115002_SeedData.cs
                    { "20b10174-ca20-4deb-9947-35e50b135ea3", "5e5fca25-1ce8-43a9-b9a6-a335be62c7e8" },
                    { "336d4223-7ab3-4645-8483-745111accb64", "3f0c129e-6c9c-4f7e-abad-393f2dddad8d" },
                    { "7189f2c9-a26c-4a0a-8ed7-46d01d0f34cb", "5e6598e7-2900-491c-ba9e-9cc453470b63" },
                    { "bb657f97-a307-4b1a-b4e6-d4998188c016", "3a8c6327-610c-46a0-bf2f-3fd7455fa3bb" }
=======
                    { "be137946-d526-4425-8767-f656188e4084", "02be0f0a-a72f-4f22-999b-84aa4958b466" },
                    { "552d9de1-fd99-4600-b196-2f95e4b650be", "3b7d01f5-238e-4c4d-987c-028e3bf7f159" },
                    { "8597b9f8-e659-4aa7-a24c-a6c56f6ad60a", "5b57ae45-417b-4fa2-b650-d968b202f4d6" },
                    { "378d39e1-e162-4df2-81a7-5f0c1079802b", "2df58414-c957-4959-a74c-2c15fefaddb7" }
>>>>>>> 6db81dc8b819b296d080d2e132deb999640b1b9d:InternshipBE/DAL/Migrations/20211105125451_SeedData.cs
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
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211106115002_SeedData.cs
                values: new object[] { 1, new DateTime(2021, 11, 6, 11, 50, 1, 97, DateTimeKind.Utc).AddTicks(773), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, true, "Snow", "-", "Arizona", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 6, 11, 50, 1, 97, DateTimeKind.Utc).AddTicks(2931), "live:j.snow", 1, 0, 1, 4 });
=======
                values: new object[] { 1, new DateTime(2021, 11, 5, 12, 54, 50, 752, DateTimeKind.Utc).AddTicks(9194), "Student", "Harvard University", "j.snow@gmail.com", 4, "John", 1, true, "Snow", "-", "Arizona", "-", "+123456789", "OOP, C#", "-", new DateTime(2021, 11, 5, 12, 54, 50, 753, DateTimeKind.Utc).AddTicks(1419), "live:j.snow", 1, 0, 1, 4 });
>>>>>>> 6db81dc8b819b296d080d2e132deb999640b1b9d:InternshipBE/DAL/Migrations/20211105125451_SeedData.cs

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BestContactTime", "CurrentJob", "Education", "Email", "EnglishLevelType", "FirstName", "InternshipId", "IsPlanningToJoin", "LastName", "Links", "Location", "OtherInfo", "Phone", "PrimarySkill", "ProfessionalCertificates", "RegistrationDate", "Skype", "StackType", "StatusType", "TeamId", "TestTaskEvaluation" },
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211106115002_SeedData.cs
                values: new object[] { 2, new DateTime(2021, 11, 6, 11, 50, 1, 97, DateTimeKind.Utc).AddTicks(4117), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, true, "Granger", "-", "London", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 6, 11, 50, 1, 97, DateTimeKind.Utc).AddTicks(4120), "live:h.granger", 5, 0, 2, 4 });
=======
                values: new object[] { 2, new DateTime(2021, 11, 5, 12, 54, 50, 753, DateTimeKind.Utc).AddTicks(2600), "Student", "Hogwarts", "h.granger@gmail.com", 5, "Hermione", 2, true, "Granger", "-", "London", "-", "+2356416789", "C++, QA basics", "-", new DateTime(2021, 11, 5, 12, 54, 50, 753, DateTimeKind.Utc).AddTicks(2603), "live:h.granger", 5, 0, 2, 4 });
>>>>>>> 6db81dc8b819b296d080d2e132deb999640b1b9d:InternshipBE/DAL/Migrations/20211105125451_SeedData.cs

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CandidateId", "Date", "Description", "EnglishLevelType", "UserId" },
                values: new object[,]
                {
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211106115002_SeedData.cs
                    { 1, 1, new DateTime(2021, 11, 6, 11, 50, 1, 97, DateTimeKind.Utc).AddTicks(8996), "Good knowledge of frameworks, oop, and db", 4, "5e5fca25-1ce8-43a9-b9a6-a335be62c7e8" },
                    { 2, 2, new DateTime(2021, 11, 6, 11, 50, 1, 98, DateTimeKind.Utc).AddTicks(192), "Excellent candidate", 5, "5e5fca25-1ce8-43a9-b9a6-a335be62c7e8" }
=======
                    { 1, 1, new DateTime(2021, 11, 5, 12, 54, 50, 753, DateTimeKind.Utc).AddTicks(7901), "Good knowledge of frameworks, oop, and db", 4, "02be0f0a-a72f-4f22-999b-84aa4958b466" },
                    { 2, 2, new DateTime(2021, 11, 5, 12, 54, 50, 753, DateTimeKind.Utc).AddTicks(9205), "Excellent candidate", 5, "02be0f0a-a72f-4f22-999b-84aa4958b466" }
>>>>>>> 6db81dc8b819b296d080d2e132deb999640b1b9d:InternshipBE/DAL/Migrations/20211105125451_SeedData.cs
                });

            migrationBuilder.InsertData(
                table: "InterviewInvites",
                columns: new[] { "Id", "CandidateId", "ContactDate", "UserId" },
                values: new object[,]
                {
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211106115002_SeedData.cs
                    { 1, 1, new DateTime(2021, 11, 6, 11, 50, 1, 99, DateTimeKind.Utc).AddTicks(2957), "5e5fca25-1ce8-43a9-b9a6-a335be62c7e8" },
                    { 2, 2, new DateTime(2021, 11, 6, 11, 50, 1, 99, DateTimeKind.Utc).AddTicks(3359), "5e5fca25-1ce8-43a9-b9a6-a335be62c7e8" }
=======
                    { 1, 1, new DateTime(2021, 11, 5, 12, 54, 50, 755, DateTimeKind.Utc).AddTicks(4930), "02be0f0a-a72f-4f22-999b-84aa4958b466" },
                    { 2, 2, new DateTime(2021, 11, 5, 12, 54, 50, 755, DateTimeKind.Utc).AddTicks(5335), "02be0f0a-a72f-4f22-999b-84aa4958b466" }
>>>>>>> 6db81dc8b819b296d080d2e132deb999640b1b9d:InternshipBE/DAL/Migrations/20211105125451_SeedData.cs
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
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211106115002_SeedData.cs
                keyValues: new object[] { "bb657f97-a307-4b1a-b4e6-d4998188c016", "3a8c6327-610c-46a0-bf2f-3fd7455fa3bb" });
=======
                keyValues: new object[] { "be137946-d526-4425-8767-f656188e4084", "02be0f0a-a72f-4f22-999b-84aa4958b466" });
>>>>>>> 6db81dc8b819b296d080d2e132deb999640b1b9d:InternshipBE/DAL/Migrations/20211105125451_SeedData.cs

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211106115002_SeedData.cs
                keyValues: new object[] { "336d4223-7ab3-4645-8483-745111accb64", "3f0c129e-6c9c-4f7e-abad-393f2dddad8d" });
=======
                keyValues: new object[] { "378d39e1-e162-4df2-81a7-5f0c1079802b", "2df58414-c957-4959-a74c-2c15fefaddb7" });
>>>>>>> 6db81dc8b819b296d080d2e132deb999640b1b9d:InternshipBE/DAL/Migrations/20211105125451_SeedData.cs

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211106115002_SeedData.cs
                keyValues: new object[] { "20b10174-ca20-4deb-9947-35e50b135ea3", "5e5fca25-1ce8-43a9-b9a6-a335be62c7e8" });
=======
                keyValues: new object[] { "552d9de1-fd99-4600-b196-2f95e4b650be", "3b7d01f5-238e-4c4d-987c-028e3bf7f159" });
>>>>>>> 6db81dc8b819b296d080d2e132deb999640b1b9d:InternshipBE/DAL/Migrations/20211105125451_SeedData.cs

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211106115002_SeedData.cs
                keyValues: new object[] { "7189f2c9-a26c-4a0a-8ed7-46d01d0f34cb", "5e6598e7-2900-491c-ba9e-9cc453470b63" });
=======
                keyValues: new object[] { "8597b9f8-e659-4aa7-a24c-a6c56f6ad60a", "5b57ae45-417b-4fa2-b650-d968b202f4d6" });
>>>>>>> 6db81dc8b819b296d080d2e132deb999640b1b9d:InternshipBE/DAL/Migrations/20211105125451_SeedData.cs

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
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211106115002_SeedData.cs
                keyValue: "20b10174-ca20-4deb-9947-35e50b135ea3");
=======
                keyValue: "378d39e1-e162-4df2-81a7-5f0c1079802b");
>>>>>>> 6db81dc8b819b296d080d2e132deb999640b1b9d:InternshipBE/DAL/Migrations/20211105125451_SeedData.cs

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211106115002_SeedData.cs
                keyValue: "336d4223-7ab3-4645-8483-745111accb64");
=======
                keyValue: "552d9de1-fd99-4600-b196-2f95e4b650be");
>>>>>>> 6db81dc8b819b296d080d2e132deb999640b1b9d:InternshipBE/DAL/Migrations/20211105125451_SeedData.cs

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211106115002_SeedData.cs
                keyValue: "7189f2c9-a26c-4a0a-8ed7-46d01d0f34cb");
=======
                keyValue: "8597b9f8-e659-4aa7-a24c-a6c56f6ad60a");
>>>>>>> 6db81dc8b819b296d080d2e132deb999640b1b9d:InternshipBE/DAL/Migrations/20211105125451_SeedData.cs

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211106115002_SeedData.cs
                keyValue: "bb657f97-a307-4b1a-b4e6-d4998188c016");
=======
                keyValue: "be137946-d526-4425-8767-f656188e4084");
>>>>>>> 6db81dc8b819b296d080d2e132deb999640b1b9d:InternshipBE/DAL/Migrations/20211105125451_SeedData.cs

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211106115002_SeedData.cs
                keyValue: "3a8c6327-610c-46a0-bf2f-3fd7455fa3bb");
=======
                keyValue: "2df58414-c957-4959-a74c-2c15fefaddb7");
>>>>>>> 6db81dc8b819b296d080d2e132deb999640b1b9d:InternshipBE/DAL/Migrations/20211105125451_SeedData.cs

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211106115002_SeedData.cs
                keyValue: "3f0c129e-6c9c-4f7e-abad-393f2dddad8d");
=======
                keyValue: "3b7d01f5-238e-4c4d-987c-028e3bf7f159");
>>>>>>> 6db81dc8b819b296d080d2e132deb999640b1b9d:InternshipBE/DAL/Migrations/20211105125451_SeedData.cs

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211106115002_SeedData.cs
                keyValue: "5e6598e7-2900-491c-ba9e-9cc453470b63");
=======
                keyValue: "5b57ae45-417b-4fa2-b650-d968b202f4d6");
>>>>>>> 6db81dc8b819b296d080d2e132deb999640b1b9d:InternshipBE/DAL/Migrations/20211105125451_SeedData.cs

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
<<<<<<< HEAD:InternshipBE/DAL/Migrations/20211106115002_SeedData.cs
                keyValue: "5e5fca25-1ce8-43a9-b9a6-a335be62c7e8");
=======
                keyValue: "02be0f0a-a72f-4f22-999b-84aa4958b466");
>>>>>>> 6db81dc8b819b296d080d2e132deb999640b1b9d:InternshipBE/DAL/Migrations/20211105125451_SeedData.cs

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
