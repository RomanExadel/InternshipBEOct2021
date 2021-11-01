using System.Collections.Generic;

namespace DAL.Entities
{
    public class Team
    {
        public int Id { get; set; }

        public int InternshipId { get; set; }

        public string Name { get; set; }

        public Internship Internship { get; set; }

        public ICollection<User> Users { get; set; }

        public ICollection<Candidate> Candidates { get; set; }
    }
}
