using AutoMapper;
using AutoMapper.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BL.Mappers
{
    public static class MapperConfigurationProvider
    {
        public static MapperConfigurationExpression Expression { get; }

        static MapperConfigurationProvider()
        {
            Expression = new MapperConfigurationExpression();

            Expression.AddMaps(Assembly.GetExecutingAssembly());
        }

        public static MapperConfiguration GetConfig()
        {
            var configuration = new MapperConfiguration(Expression);
            
            configuration.AssertConfigurationIsValid();

            return configuration;
        }

        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            services.AddSingleton(GetConfig().CreateMapper());

            return services;
        }
    }
}
