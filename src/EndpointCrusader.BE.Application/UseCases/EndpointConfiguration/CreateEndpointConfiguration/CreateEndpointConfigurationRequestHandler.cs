using EndpointCrusader.BE.Application.Repositories;
using MediatR;

namespace EndpointCrusader.BE.Application.UseCases.EndpointConfiguration.CreateEndpointConfiguration
{
    public class CreateEndpointConfigurationRequestHandler : IRequestHandler<CreateEndpointConfigurationRequest, int>
    {
        private readonly IEndpointConfigurationRepository _endpointConfigurationRepository;

        public CreateEndpointConfigurationRequestHandler(IEndpointConfigurationRepository endpointConfigurationRepository)
        {
            _endpointConfigurationRepository = endpointConfigurationRepository;
        }
        public async Task<int> Handle(CreateEndpointConfigurationRequest request, CancellationToken cancellationToken)
        {
            return await _endpointConfigurationRepository.CreateEndpointConfiguration(request);
        }
    }
}
