using BL.Interfaces;
using BL.Services;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Repositories;
using DAL.Validators;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.Extensions
{
    public static class RegisterServices
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IGoogleSheetService, GoogleSheetService>();
            services.AddTransient<ICandidateService, CandidateService>();
            services.AddTransient<IUnitOfWork, EFUnitOfWork>();
            services.AddTransient<IInternshipService, InternshipService>();
            services.AddTransient<IFeedbackService, FeedbackService>();
            services.AddTransient<IEvaluationService, EvaluationService>();
            services.AddTransient<ISkillService, SkillService>();
            services.AddTransient<IBestContactTimeService, BestContactTimeService>();
            services.AddTransient<IGoogleCalendarService, GoogleCalendarService>();
            services.AddTransient<IInternshipStackService, InternshipStackService>();
            services.AddTransient<ILocationService, LocationService>();
            services.AddTransient<IReportService, ReportService>();
            services.AddTransient<IValidator<Candidate>, CandidateValidator>();
            services.AddTransient<IValidator<User>, UserValidator>();
            services.AddTransient<IValidator<Feedback>, FeedbackValidator>();
            services.AddTransient<IValidator<Internship>, InternshipValidator>();

            return services;
        }
    }
}
