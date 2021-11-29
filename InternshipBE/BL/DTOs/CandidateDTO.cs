using Shared.Models;
using System;
using System.Collections.Generic;

namespace BL.DTOs
{
    public class CandidateDTO : AGGridSearch
    {
        public int Id { get; set; }

        public DateTime RegistrationDate { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Location { get; set; }

        public string Phone { get; set; }

        public string Skype { get; set; }

        public string StackType { get; set; }

        public string EnglishLevelType { get; set; }

        public string Education { get; set; }

        public string Links { get; set; }

        public string OtherInfo { get; set; }
        
        public string PrimarySkill { get; set; }

        public string CurrentJob { get; set; }

        public string ProfessionalCertificates { get; set; }

        public bool IsPlanningToJoin { get; set; }

        public int TestTaskEvaluation { get; set; }

        public string StatusType { get; set; }

        public DateTime BestContactTime { get; set; }

        public int InternshipId { get; set; }

        public string InternshipName { get; set; }

        public int? TeamId { get; set; }

        public List<UserDTO> Users { get; set; }

        public string LanguageType { get; set; }
    }
}
