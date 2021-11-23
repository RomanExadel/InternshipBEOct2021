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
            services.AddTransient<IValidator<Candidate>, CandidateValidator>();
            services.AddTransient<IValidator<User>, UserValidator>();
            services.AddTransient<IValidator<Feedback>, FeedbackValidator>();
            services.AddTransient<IValidator<Internship>, InternshipValidator>();

            return services;
        }
    }
}
