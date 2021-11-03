using System.Collections.Generic;

namespace DAL.Entities
{
    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Internship> Internships { get; set; }
    }
}
