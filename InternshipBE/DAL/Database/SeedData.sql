--AspNetUserRoles
delete from AspNetUserRoles;

--AspnetRoles
update AspNetRoles set id = '0121176f-d2e2-4090-abd5-da9ca40121e4' where [Name] = 'Mentor';
update AspNetRoles set id = '20b6b1c8-b16b-409b-8a2c-26aecc364d41' where [Name] = 'Admin';
update AspNetRoles set id = 'bda1a2c8-6ad0-4a5f-b392-4dbad403d0a7' where [Name] = 'Interviewer';
update AspNetRoles set id = 'c0e95d91-ea52-408c-a6b7-dafddeb8905f' where [Name] = 'Manager';
update AspNetRoles set id = 'ee2ace92-5843-4e97-bc0e-14a8fc9900e5' where [Name] = 'Hr';

--Feadbacks
update Feedbacks set UserId = '15cef508-4e16-4b6c-9f26-e6418dd55685' where CandidateId = 1;
update Feedbacks set UserId = '15cef508-4e16-4b6c-9f26-e6418dd55685' where CandidateId = 2;

--InterviewInvites
update InterviewInvites set UserId = '15cef508-4e16-4b6c-9f26-e6418dd55685' where CandidateId = 1;
update InterviewInvites set UserId = '15cef508-4e16-4b6c-9f26-e6418dd55685' where CandidateId = 2;


--AspNetUsers
update AspNetUsers set id = '44c3d6f1-34a4-4df2-831a-ec5f045a0537' where RoleType = 4;
update AspNetUsers set id = 'f4d5ad27-f165-4c95-b2de-5dfe4b189561' where RoleType = 2;
update AspNetUsers set id = '15cef508-4e16-4b6c-9f26-e6418dd55685' where RoleType = 1;
update AspNetUsers set id = '81cd0f53-0f04-4079-8846-f490cf677d4a' where RoleType = 0;
update AspNetUsers set id = '74b9be8b-9eb5-4014-963d-03670de353aa' where RoleType = 3;

--AspNetUserRoles
insert into AspNetUserRoles values
('81cd0f53-0f04-4079-8846-f490cf677d4a', '0121176f-d2e2-4090-abd5-da9ca40121e4'),
('44c3d6f1-34a4-4df2-831a-ec5f045a0537', '20b6b1c8-b16b-409b-8a2c-26aecc364d41'),
('f4d5ad27-f165-4c95-b2de-5dfe4b189561', 'bda1a2c8-6ad0-4a5f-b392-4dbad403d0a7'),
('74b9be8b-9eb5-4014-963d-03670de353aa', 'c0e95d91-ea52-408c-a6b7-dafddeb8905f'),
('15cef508-4e16-4b6c-9f26-e6418dd55685', 'ee2ace92-5843-4e97-bc0e-14a8fc9900e5');

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
(1,'15cef508-4e16-4b6c-9f26-e6418dd55685'),
(2,'81cd0f53-0f04-4079-8846-f490cf677d4a'),
(3,'44c3d6f1-34a4-4df2-831a-ec5f045a0537'),
(4,'f4d5ad27-f165-4c95-b2de-5dfe4b189561'),
(1,'74b9be8b-9eb5-4014-963d-03670de353aa');

--TeamUser
insert into TeamUser values
(1,'f4d5ad27-f165-4c95-b2de-5dfe4b189561'),
(1,'81cd0f53-0f04-4079-8846-f490cf677d4a'),
(1,'74b9be8b-9eb5-4014-963d-03670de353aa'),
(2,'15cef508-4e16-4b6c-9f26-e6418dd55685'),
(2,'81cd0f53-0f04-4079-8846-f490cf677d4a'),
(2,'f4d5ad27-f165-4c95-b2de-5dfe4b189561'),
(2,'74b9be8b-9eb5-4014-963d-03670de353aa');

--CandidateUser
insert into CandidateUser values
(1,'f4d5ad27-f165-4c95-b2de-5dfe4b189561'),
(2,'f4d5ad27-f165-4c95-b2de-5dfe4b189561'),
(3,'f4d5ad27-f165-4c95-b2de-5dfe4b189561'),
(4,'f4d5ad27-f165-4c95-b2de-5dfe4b189561'),
(5,'f4d5ad27-f165-4c95-b2de-5dfe4b189561'),
(6,'81cd0f53-0f04-4079-8846-f490cf677d4a'),
(7,'81cd0f53-0f04-4079-8846-f490cf677d4a'),
(8,'81cd0f53-0f04-4079-8846-f490cf677d4a'),
(9,'81cd0f53-0f04-4079-8846-f490cf677d4a'),
(10,'81cd0f53-0f04-4079-8846-f490cf677d4a'),
(11,'44c3d6f1-34a4-4df2-831a-ec5f045a0537'),
(12,'44c3d6f1-34a4-4df2-831a-ec5f045a0537'),
(13,'44c3d6f1-34a4-4df2-831a-ec5f045a0537'),
(14,'44c3d6f1-34a4-4df2-831a-ec5f045a0537'),
(15,'15cef508-4e16-4b6c-9f26-e6418dd55685'),
(16,'15cef508-4e16-4b6c-9f26-e6418dd55685'),
(17,'74b9be8b-9eb5-4014-963d-03670de353aa'),
(18,'74b9be8b-9eb5-4014-963d-03670de353aa'),
(19,'74b9be8b-9eb5-4014-963d-03670de353aa'),
(20,'74b9be8b-9eb5-4014-963d-03670de353aa'),
(21,'74b9be8b-9eb5-4014-963d-03670de353aa'),
(22,'15cef508-4e16-4b6c-9f26-e6418dd55685'),
(23,'15cef508-4e16-4b6c-9f26-e6418dd55685');

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

--InternshipLanguage
insert into InternshipLanguages values
(1, 1),
(2, 1),
(2, 2),
(3, 2),
(3, 3),
(4, 4);