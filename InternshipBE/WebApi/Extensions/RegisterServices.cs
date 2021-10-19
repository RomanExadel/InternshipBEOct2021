using BL.Interfaces;
using BL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.Extensions
{
	public static class RegisterServices
	{
		public static void AddServices(this IServiceCollection services)
		{
			services.AddTransient<IUserService, UserService>();
		}
	}
}
