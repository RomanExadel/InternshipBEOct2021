using Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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

		public string ProfessionalCertificates { get; set; }

		public DateTime BestContactTime { get; set; }

		public int TestTaskEvaluation { get; set; }

        public CandidateStatusType StatusType { get; set; }

		public StackType StackType { get; set; }

		public EnglishLevelType EnglishLevelType { get; set; }

		public bool IsPlanningToJoin { get; set; }

		public DateTime RegistrationDate { get; set; }

		[ForeignKey("InternshipId")]
		public Internship Internship { get; set; }

		[ForeignKey("TeamId")]
		public virtual Team Team { get; set; }

		public ICollection<User> Users { get; set; }

		public int? InternshipId { get; set; }

		public int? TeamId { get; set; }

		public LanguageType? InternshipLanguage { get; set; }

		public ICollection<Feedback> Feedbacks { get; set; }
	}
}
