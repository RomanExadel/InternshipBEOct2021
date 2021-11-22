using BL.DTOs;
using BL.DTOs.CandidateDTOs;
using BL.Validators;
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
            services.AddTransient<FluentValidation.AbstractValidator<SkillDTO>, SkillDTOValidator>();
            services.AddTransient<FluentValidation.AbstractValidator<UserDTO>, UserDTOValidator>();
            services.AddTransient<FluentValidation.AbstractValidator<CountryDTO>, CountryDTOValidator>();
            services.AddTransient<FluentValidation.AbstractValidator<CandidateDTO>, CandidateDTOValidator>();
            services.AddTransient<FluentValidation.AbstractValidator<EvaluationDTO>, EvaluationDTOValidator>();
            services.AddTransient<FluentValidation.AbstractValidator<FeedbackDTO>, FeedbackDTOValidator>();
            services.AddTransient<FluentValidation.AbstractValidator<InternshipDTO>, InternshipDTOValidator>();
            services.AddTransient<FluentValidation.AbstractValidator<InternshipStackDTO>, InternshipStackDTOValidator>();

            return services;
        }
    }
}
