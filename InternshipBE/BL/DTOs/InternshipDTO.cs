using DAL.Entities;
using Shared.Enums;
using System;
using System.Collections.Generic;

namespace BL.DTOs
{
    public class InternshipDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Requirements { get; set; }

        public int MaxCandidateCount { get; set; }

        public DateTime RegistrationStartDate { get; set; }

        public DateTime RegistrationFinishDate { get; set; }

        public LanguageType LanguageType { get; set; }

<<<<<<< HEAD
<<<<<<< HEAD
        public List<CandidateDTO> Candidate { get; set; }

        public List<InternshipStackDTO> InternshipStack { get; set; }

        public List<UserDTO> User { get; set; }

        public List<TeamDTO> Team { get; set; }
=======
        public ICollection<Candidate> Candidate { get; set; }
=======
        public List<CandidateDTO> Candidate { get; set; }
>>>>>>> 92d55f7 (Change ICollection to List and Entities to DTO. Make InternshipStackDTO and UserInternshipDTO)

        public List<InternshipStackDTO> InternshipStack { get; set; }

<<<<<<< HEAD
        public ICollection<UserInternship> UserInternship { get; set; }
>>>>>>> 6b6dd06 (Implement Internship service and controller. Implement API for Create, Update, Get one and Get all internships.)
=======
        public List<UserInternshipDTO> UserInternship { get; set; }
>>>>>>> 92d55f7 (Change ICollection to List and Entities to DTO. Make InternshipStackDTO and UserInternshipDTO)
    }
}
