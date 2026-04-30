using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace EndpointCrusader.BE.Application.IoC
{
    public static class ServicesInstallationExtension
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR( configuration => configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            return services;
        }
    }
}
