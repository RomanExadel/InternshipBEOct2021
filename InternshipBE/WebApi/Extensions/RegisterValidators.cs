using DAL.Entities;
using DAL.Interfaces;
using DAL.Validators;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.Extensions
{
    public static class RegisterValidators
    {
        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services.AddScoped<IValidator<Candidate>, CandidateValidator>();
            services.AddScoped<IValidator<User>, UserValidator>();
            services.AddScoped<IValidator<Feedback>, FeedbackValidator>();
            services.AddScoped<IValidator<Internship>, InternshipValidator>();
            services.AddScoped<IValidator<Evaluation>, EvaluationValidator>();
            services.AddScoped<IValidator<InterviewInvite>, InterviewInviteValidator>();
            services.AddScoped<IValidator<Team>, TeamValidator>();

            return services;
        }
    }
}
