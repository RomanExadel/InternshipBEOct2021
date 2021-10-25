namespace DAL.Entities
{
    public class UserInternship
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int InternshipId { get; set; }

        public User User { get; set; }

        public Internship Internship { get; set; }
    }
}
