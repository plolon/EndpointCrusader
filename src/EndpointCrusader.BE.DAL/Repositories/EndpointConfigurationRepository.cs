using EndpointCrusader.BE.Application.Repositories;
using EndpointCrusader.BE.DAL.Factories;

namespace EndpointCrusader.BE.DAL.Repositories
{
    public class EndpointConfigurationRepository : IEndpointConfigurationRepository
    {
        private readonly DbConnectionFactory _connectionFactory;

        public EndpointConfigurationRepository(DbConnectionFactory dbConnectionFactory)
        {
            _connectionFactory = dbConnectionFactory;
        }
        public async Task<bool> CreateEndpointConfiguration(string model)
        {
            using var connection = _connectionFactory.CreateDbConnection();
            return true;
        }
    }
}
