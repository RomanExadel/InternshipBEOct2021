using DAL.Entities;
using DAL.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL.Database
{
	public class ApplicationDbContext : IdentityDbContext<User>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		public ApplicationDbContext()
		{
		}

		public DbSet<Feedback> Feedbacks { get; set; }

		public DbSet<Evaluation> Evaluations { get; set; }

		public DbSet<Skill> Skills { get; set; }

		public DbSet<InterviewInvite> InterviewInvites { get; set; }

		public DbSet<Candidate> Candidates { get; set; }

		public DbSet<Internship> Internships { get; set; }

		public DbSet<InternshipStack> InternshipStacks { get; set; }

		public DbSet<Team> Teams { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.Seed();
		}
	}
}
