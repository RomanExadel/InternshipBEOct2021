using Shared.Enums;
using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class Candidate
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Location { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Skype { get; set; }

        public string Education { get; set; }

        public string Links { get; set; }

        public string OtherInfo { get; set; }

        public string PrimarySkill { get; set; }

        public string CurrentJob { get; set; }

        public string ProfessionalCertificates  { get; set; }

        public DateTime BestContactTime { get; set; }

        public int TestTaskEvaluation { get; set; }

        public Status Status { get; set; }

        public Stack Stack { get; set; }

        public EnglishLevel EnglishLevel { get; set; } 
        
        public bool IsPlanningToJoin { get; set; }

        public DateTime RegistationDate { get; set; }

        public Internship Internship { get; set; }

        public ICollection<UserCandidate> UserCandidate { get; set; }
    }
}
