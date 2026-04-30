using EndpointCrusader.BE.Application.UseCases.EndpointConfiguration.CreateEndpointConfiguration;
using MediatR;

namespace EndpointCrusader.BE.WebApi.Extensions
{
    public static class EndpointConfigurationBuilderExtension
    {
        public static IEndpointRouteBuilder AddEndpointConfigurationEndpoints(this IEndpointRouteBuilder routes)
        {
            routes.MapPost("/endpoint", async (ISender sender, CreateEndpointConfigurationRequest request) =>
            {
                return await sender.Send(request);
            }).WithName("AddEndpoint")
            .Produces<int>(StatusCodes.Status200OK);

            return routes;
        }
    }
}
