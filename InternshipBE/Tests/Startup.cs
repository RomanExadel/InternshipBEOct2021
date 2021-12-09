using BL.Interfaces;
using BL.Mapping;
using BL.Services;
using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Repositories;
using DAL.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Tests
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=InternshipBE;Trusted_Connection=True;"));

            services.AddScoped<IUnitOfWork, EFUnitOfWork>();

            services.AddScoped<IValidator<Candidate>, CandidateValidator>();
            services.AddScoped<IValidator<User>, UserValidator>();
            services.AddScoped<IValidator<Feedback>, FeedbackValidator>();
            services.AddScoped<IValidator<Internship>, InternshipValidator>();
            services.AddScoped<IValidator<Evaluation>, EvaluationValidator>();
            services.AddScoped<IValidator<InterviewInvite>, InterviewInviteValidator>();
            services.AddScoped<IValidator<Team>, TeamValidator>();

            services.AddScoped<ISkillService, SkillService>();

            services.AddAutoMapper();
        }
    }
}