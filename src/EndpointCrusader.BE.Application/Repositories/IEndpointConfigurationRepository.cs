namespace EndpointCrusader.BE.Application.Repositories
{
    public interface IEndpointConfigurationRepository
    {
        Task<bool> CreateEndpointConfiguration(string model);
    }
}
