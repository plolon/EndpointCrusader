using EndpointCrusader.BE.Application.UseCases.EndpointConfiguration.CreateEndpointConfiguration;

namespace EndpointCrusader.BE.Application.Repositories
{
    public interface IEndpointConfigurationRepository
    {
        Task<int> CreateEndpointConfiguration(CreateEndpointConfigurationRequest request);
    }
}
