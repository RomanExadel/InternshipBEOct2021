--AspNetUsers
update AspNetUsers set id = 'af412954-70f3-40bb-bcbb-8bea392d4b73' where RoleType = 4;
update AspNetUsers set id = '37cba5fa-b370-4c92-aca1-6554070b44d2' where RoleType = 2;
update AspNetUsers set id = 'a607f6bb-88ca-471f-9f44-83606ca03755' where RoleType = 1;
update AspNetUsers set id = '75e2119e-8010-4af3-9be5-0748970b575a' where RoleType = 0;
update AspNetUsers set id = 'ec85bfdd-4994-45b0-8d2d-4bd9b3fff715' where RoleType = 3;

--Candidates
update Candidates set InternshipLanguage = 0 where InternshipId = 1;
update Candidates set InternshipLanguage = 1 where InternshipId = 2;
update Candidates set InternshipLanguage = 2 where InternshipId = 3;
update Candidates set InternshipLanguage = 3 where InternshipId = 4;

--InternshipStacks
update InternshipStacks set InternshipId = 1 where Id = 1;
update InternshipStacks set InternshipId = 1 where Id = 2;
update InternshipStacks set InternshipId = 2 where Id = 3;
update InternshipStacks set InternshipId = 2 where Id = 4;
update InternshipStacks set InternshipId = 3 where Id = 5;
update InternshipStacks set InternshipId = 4 where Id = 6;

--CountryInternship
insert into CountryInternship values
(1,1),
(4,1),
(2,2),
(3,2),
(2,3),
(3,3),
(1,4),
(4,4);

--InternshipUser
insert into InternshipUser values
(1,'37cba5fa-b370-4c92-aca1-6554070b44d2'),
(2,'75e2119e-8010-4af3-9be5-0748970b575a'),
(3,'a607f6bb-88ca-471f-9f44-83606ca03755'),
(4,'af412954-70f3-40bb-bcbb-8bea392d4b73'),
(1,'ec85bfdd-4994-45b0-8d2d-4bd9b3fff715');

--TeamUser
insert into TeamUser values
(1,'37cba5fa-b370-4c92-aca1-6554070b44d2'),
(1,'75e2119e-8010-4af3-9be5-0748970b575a'),
(1,'ec85bfdd-4994-45b0-8d2d-4bd9b3fff715'),
(2,'a607f6bb-88ca-471f-9f44-83606ca03755'),
(2,'af412954-70f3-40bb-bcbb-8bea392d4b73'),
(2,'37cba5fa-b370-4c92-aca1-6554070b44d2'),
(2,'ec85bfdd-4994-45b0-8d2d-4bd9b3fff715');

--CandidateUser
insert into CandidateUser values
(1,'37cba5fa-b370-4c92-aca1-6554070b44d2'),
(2,'37cba5fa-b370-4c92-aca1-6554070b44d2'),
(3,'37cba5fa-b370-4c92-aca1-6554070b44d2'),
(4,'37cba5fa-b370-4c92-aca1-6554070b44d2'),
(5,'37cba5fa-b370-4c92-aca1-6554070b44d2'),
(6,'75e2119e-8010-4af3-9be5-0748970b575a'),
(7,'75e2119e-8010-4af3-9be5-0748970b575a'),
(8,'75e2119e-8010-4af3-9be5-0748970b575a'),
(9,'75e2119e-8010-4af3-9be5-0748970b575a'),
(10,'75e2119e-8010-4af3-9be5-0748970b575a'),
(11,'a607f6bb-88ca-471f-9f44-83606ca03755'),
(12,'a607f6bb-88ca-471f-9f44-83606ca03755'),
(13,'a607f6bb-88ca-471f-9f44-83606ca03755'),
(14,'a607f6bb-88ca-471f-9f44-83606ca03755'),
(15,'a607f6bb-88ca-471f-9f44-83606ca03755'),
(16,'a607f6bb-88ca-471f-9f44-83606ca03755'),
(17,'af412954-70f3-40bb-bcbb-8bea392d4b73'),
(18,'af412954-70f3-40bb-bcbb-8bea392d4b73'),
(19,'af412954-70f3-40bb-bcbb-8bea392d4b73'),
(20,'af412954-70f3-40bb-bcbb-8bea392d4b73'),
(21,'af412954-70f3-40bb-bcbb-8bea392d4b73'),
(22,'af412954-70f3-40bb-bcbb-8bea392d4b73'),
(23,'ec85bfdd-4994-45b0-8d2d-4bd9b3fff715'),
(24,'ec85bfdd-4994-45b0-8d2d-4bd9b3fff715'),
(25,'ec85bfdd-4994-45b0-8d2d-4bd9b3fff715'),
(26,'ec85bfdd-4994-45b0-8d2d-4bd9b3fff715'),
(27,'ec85bfdd-4994-45b0-8d2d-4bd9b3fff715'),
(28,'ec85bfdd-4994-45b0-8d2d-4bd9b3fff715'),
(29,'ec85bfdd-4994-45b0-8d2d-4bd9b3fff715'),
(30,'ec85bfdd-4994-45b0-8d2d-4bd9b3fff715'),
(31,'ec85bfdd-4994-45b0-8d2d-4bd9b3fff715'),
(32,'ec85bfdd-4994-45b0-8d2d-4bd9b3fff715'),
(33,'ec85bfdd-4994-45b0-8d2d-4bd9b3fff715');

--Teams
insert into Teams(InternshipId, [Name]) values(3,'Team 1 C');
insert into Teams(InternshipId, [Name]) values(4,'Team 1 B');

--Skills
insert into Skills(StackType, [Name], IsHardSkill) values
(0,'JS(ES6+)', 1),
(2,'C#', 1),
(3,'R', 1),
(4,'Python', 1),
(5,'Postman', 1),
(0,'HTML', 1),
(0,'CSS', 1),
(0,'React', 1),
(0,'Angular/Vue', 1),
(0,'Redux', 1),
(0,'MobX', 1),
(0,'Electron', 1),
(0,'TypeScript', 1),
(1,'EF Core', 1),
(1,'SQL/T-SQL', 1),
(1,'ASP.NET Core', 1),
(1,'MongoDB', 1),
(1,'MS SQL Server', 1),
(1,'PostgreSql', 1),
(1,'RabbitMQ/Kafka', 1),
(1,'Redis/Memchached', 1),
(2,'TypeScript', 1),
(2,'REST API', 1),
(3,'BDD/TDD', 1),
(3,'DFD', 1),
(4,'Docker', 1),
(4,'Kubernetes', 1),
(4,'CI/CD', 1),
(5,'BDD/TDD', 1),
(5,'Multitasking', 1);