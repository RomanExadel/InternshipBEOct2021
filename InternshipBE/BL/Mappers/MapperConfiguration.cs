using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BL.Mappers
{
    public static class MapperConfiguration
    {
        public static AutoMapper.MapperConfiguration GetConfig(params Profile[] profiles)
        {
            return new AutoMapper.MapperConfiguration(mc => Array.ForEach(profiles, profile => mc.AddProfile(profile)));
        }

        public static IServiceCollection AddAutoMapper(this IServiceCollection services, IMapper mapper)
        {
            services.AddSingleton(mapper);

            return services;
        }
    }
}
