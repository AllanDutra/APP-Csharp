using AutoMapper;
using AP.Manager.Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace AP.Api.Configurations
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(
                typeof(NovoPokemonMappingProfile)
            );
        }
    }
}