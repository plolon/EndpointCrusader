using EndpointCrusader.BE.Application.Repositories;
using EndpointCrusader.BE.DAL.Factories;
using EndpointCrusader.BE.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace EndpointCrusader.BE.DAL.IoC
{
    public static class ServicesInstallationExtension
    {
        public static IServiceCollection ConfigureDALServices(this IServiceCollection services)
        {
            services.AddSingleton<DbConnectionFactory>();
            services.AddScoped<IEndpointConfigurationRepository, EndpointConfigurationRepository>();

            return services;
        }
    }
}
