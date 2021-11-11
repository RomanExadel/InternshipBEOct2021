using DAL.Entities;
using DAL.Interfaces;
using DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Shared.Config;
using Shared.Config.Interfaces;

namespace WebApi.Extensions
{
    public static class RegisterRepositories
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IGoogleConfig, GoogleConfig>();
            services.AddTransient<ICalendarEventsConfig, CalendarEventsConfig>();
            services.AddTransient<IGenericRepository<User>, GenericRepository<User>>();
            services.AddTransient<IGenericRepository<Candidate>, GenericRepository<Candidate>>();
            services.AddTransient<ICandidateRepository, CandidateRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IInternshipRepository, InternshipRepository>();
            services.AddTransient<IFeedbackRepository, FeedbackRepository>();
            services.AddTransient<ILocationRepository, LocationRepository>();
	public static class RegisterRepositories
	{
		public static IServiceCollection AddRepositories(this IServiceCollection services)
		{
			services.AddTransient<IGoogleConfig, GoogleConfig>();
			services.AddTransient<ICalendarEventsConfig, CalendarEventsConfig>();
			services.AddTransient<IGenericRepository<User>, GenericRepository<User>>();
			services.AddTransient<IGenericRepository<Candidate>, GenericRepository<Candidate>>();
			services.AddTransient<ICandidateRepository, CandidateRepository>();
			services.AddTransient<IUserRepository, UserRepository>();
			services.AddTransient<IInternshipRepository , InternshipRepository>();
			services.AddTransient<IFeedbackRepository, FeedbackRepository>();
			services.AddTransient<IInternshipStackRepository, InternshipStackRepository>();

            return services;
        }
    }
}
