using BL.Interfaces;
using BL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.Extensions
{
	public static class RegisterServices
	{
		public static IServiceCollection AddServices(this IServiceCollection services)
		{
			services.AddTransient<IUserService, UserService>();
			services.AddTransient<IGoogleSheetService, GoogleSheetService>();

			return services;
		}
	}
}
