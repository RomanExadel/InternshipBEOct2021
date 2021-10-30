using AutoMapper;
using AutoMapper.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BL.Mapping
{
    public static class MapperConfigurationProvider
    {
        public static MapperConfigurationExpression MapperConfigurationExpression { get; }

        static MapperConfigurationProvider()
        {
            MapperConfigurationExpression = new MapperConfigurationExpression();

            MapperConfigurationExpression.AddMaps(Assembly.GetExecutingAssembly());
        }

        public static MapperConfiguration GetConfig()
        {
            var configuration = new MapperConfiguration(MapperConfigurationExpression);

            configuration.AssertConfigurationIsValid();

            return configuration;
        }

        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            var mapper = GetConfig().CreateMapper();

            return services.AddSingleton(mapper);
        }
    }
}
