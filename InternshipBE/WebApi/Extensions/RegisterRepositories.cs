﻿using DAL.Entities;
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
			services.AddTransient<IGoogleSheetConfig, GoogleSheetConfig>();
			services.AddTransient<IGenericRepository<User>, GenericRepository<User>>();
			services.AddTransient<IUserRepository, UserRepository>();

			return services;
		}
	}
}
