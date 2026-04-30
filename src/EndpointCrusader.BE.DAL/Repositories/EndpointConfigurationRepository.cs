using Dapper;
using EndpointCrusader.BE.Application.Repositories;
using EndpointCrusader.BE.Application.UseCases.EndpointConfiguration.CreateEndpointConfiguration;
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
        public async Task<int> CreateEndpointConfiguration(CreateEndpointConfigurationRequest request)
        {
            using var connection = _connectionFactory.CreateDbConnection();
            connection.Open();

            var result = await connection.QuerySingleOrDefaultAsync<int?>(
                Resources.Resources.CreateEndpointConfiguration,
                GetCreateEndpointConfigurationParams(request),
                commandType: System.Data.CommandType.Text);

            return result ?? -1;
        }

        private DynamicParameters GetCreateEndpointConfigurationParams(CreateEndpointConfigurationRequest request)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Name", request.Name);
            parameters.Add("@Url", request.Url);
            return parameters;
        }
    }
}
