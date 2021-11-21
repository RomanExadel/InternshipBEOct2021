--AspNetUsers
update AspNetUsers set id = '37e94a22-4763-4f05-abaf-f5336c304b7b' where RoleType = 4;
update AspNetUsers set id = '4bf0c15c-469a-4662-9d0b-a8b50148e13d' where RoleType = 2;
update AspNetUsers set id = 'ad5f8ed6-d54e-425d-b18a-ee1008936271' where RoleType = 1;
update AspNetUsers set id = 'c392c0e7-06ac-404c-9cb3-6830832eb0f3' where RoleType = 0;
update AspNetUsers set id = 'd1d80947-5b92-4527-b534-000264ddbd22' where RoleType = 3;

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
(1,'37e94a22-4763-4f05-abaf-f5336c304b7b'),
(2,'4bf0c15c-469a-4662-9d0b-a8b50148e13d'),
(3,'ad5f8ed6-d54e-425d-b18a-ee1008936271'),
(4,'d1d80947-5b92-4527-b534-000264ddbd22'),
(1,'c392c0e7-06ac-404c-9cb3-6830832eb0f3');

--TeamUser
insert into TeamUser values
(1,'37e94a22-4763-4f05-abaf-f5336c304b7b'),
(1,'4bf0c15c-469a-4662-9d0b-a8b50148e13d'),
(1,'c392c0e7-06ac-404c-9cb3-6830832eb0f3'),
(2,'ad5f8ed6-d54e-425d-b18a-ee1008936271'),
(2,'d1d80947-5b92-4527-b534-000264ddbd22'),
(2,'37e94a22-4763-4f05-abaf-f5336c304b7b'),
(2,'c392c0e7-06ac-404c-9cb3-6830832eb0f3');

--CandidateUser
insert into CandidateUser values
(1,'37e94a22-4763-4f05-abaf-f5336c304b7b'),
(2,'37e94a22-4763-4f05-abaf-f5336c304b7b'),
(3,'37e94a22-4763-4f05-abaf-f5336c304b7b'),
(4,'37e94a22-4763-4f05-abaf-f5336c304b7b'),
(5,'37e94a22-4763-4f05-abaf-f5336c304b7b'),
(6,'4bf0c15c-469a-4662-9d0b-a8b50148e13d'),
(7,'4bf0c15c-469a-4662-9d0b-a8b50148e13d'),
(8,'4bf0c15c-469a-4662-9d0b-a8b50148e13d'),
(9,'4bf0c15c-469a-4662-9d0b-a8b50148e13d'),
(10,'4bf0c15c-469a-4662-9d0b-a8b50148e13d'),
(11,'ad5f8ed6-d54e-425d-b18a-ee1008936271'),
(12,'ad5f8ed6-d54e-425d-b18a-ee1008936271'),
(13,'ad5f8ed6-d54e-425d-b18a-ee1008936271'),
(14,'ad5f8ed6-d54e-425d-b18a-ee1008936271'),
(15,'ad5f8ed6-d54e-425d-b18a-ee1008936271'),
(16,'ad5f8ed6-d54e-425d-b18a-ee1008936271'),
(17,'d1d80947-5b92-4527-b534-000264ddbd22'),
(18,'d1d80947-5b92-4527-b534-000264ddbd22'),
(19,'d1d80947-5b92-4527-b534-000264ddbd22'),
(20,'d1d80947-5b92-4527-b534-000264ddbd22'),
(21,'d1d80947-5b92-4527-b534-000264ddbd22'),
(22,'d1d80947-5b92-4527-b534-000264ddbd22'),
(23,'c392c0e7-06ac-404c-9cb3-6830832eb0f3'),
(24,'c392c0e7-06ac-404c-9cb3-6830832eb0f3'),
(25,'c392c0e7-06ac-404c-9cb3-6830832eb0f3'),
(26,'c392c0e7-06ac-404c-9cb3-6830832eb0f3'),
(27,'c392c0e7-06ac-404c-9cb3-6830832eb0f3'),
(28,'c392c0e7-06ac-404c-9cb3-6830832eb0f3'),
(29,'c392c0e7-06ac-404c-9cb3-6830832eb0f3'),
(30,'c392c0e7-06ac-404c-9cb3-6830832eb0f3'),
(31,'c392c0e7-06ac-404c-9cb3-6830832eb0f3'),
(32,'c392c0e7-06ac-404c-9cb3-6830832eb0f3'),
(33,'c392c0e7-06ac-404c-9cb3-6830832eb0f3');

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