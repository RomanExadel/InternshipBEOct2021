using DAL.Entities;
using DAL.Interfaces;
using DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.Extensions
{
	public static class RegisterRepositories 
	{
		public static void LoadRepositories(IServiceCollection services)
		{
			services.AddTransient<IGenericRepository<User>, GenericRepository<User>>();
			services.AddTransient<IUserRepository, UserRepository>();
		}

	}
}
