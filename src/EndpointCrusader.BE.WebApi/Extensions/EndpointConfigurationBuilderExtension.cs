using EndpointCrusader.BE.Application.UseCases.EndpointConfiguration.CreateEndpointConfiguration;
using MediatR;

namespace EndpointCrusader.BE.WebApi.Extensions
{
    public static class EndpointConfigurationBuilderExtension 
    {
        public static IEndpointRouteBuilder AddEndpointConfigurationEndpoints(this IEndpointRouteBuilder routes)
        {
            routes.MapPost("/endpoint", async (ISender sender) =>
            {
                await sender.Send(new CreateEndpointConfigurationRequest());
                // mediator
            }).WithName("AddEndpoint")
            .Produces<bool>(StatusCodes.Status200OK);

            return routes;
        }
    }
}
