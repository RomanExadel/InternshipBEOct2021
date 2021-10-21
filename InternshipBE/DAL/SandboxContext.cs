using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    
    public class SandboxContext: DbContext
    {
        public SandboxContext(DbContextOptions<SandboxContext> options): base(options)
        { 
               
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<Evaluation> Evaluations { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<InterviewInvite> InterviewInvites { get; set; }

    }
}
