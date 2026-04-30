using MediatR;

namespace EndpointCrusader.BE.Application.UseCases.EndpointConfiguration.CreateEndpointConfiguration
{
    public class CreateEndpointConfigurationRequest : IRequest<int>
    {
        public string Url { get; set; }
        public string Name { get; set; }
    }
}
