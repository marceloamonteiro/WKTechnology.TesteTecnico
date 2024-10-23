using Microsoft.Extensions.DependencyInjection;

namespace WKTechnology.TesteTecnico.Mapper
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            services.AddAutoMapper(config =>
            {
                config.AddProfile(new EntityToModelProfile());
            });
        }
    }
}
