using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Data;

namespace EndpointCrusader.BE.DAL.Factories
{
    public class DbConnectionFactory
    {
        private readonly string _connectionString;
        private readonly ILogger<DbConnectionFactory> _logger;

        public DbConnectionFactory(IConfiguration configuration, ILogger<DbConnectionFactory> logger)
        {
            _logger = logger;
            _connectionString = configuration.GetConnectionString("DefaultConnection")
                            ?? throw new ArgumentNullException(nameof(_connectionString), "Connection string 'DefaultConnection' not found.");

            _logger.LogInformation("Connection String: {ConnectionString}", _connectionString);
        }

        public IDbConnection CreateDbConnection()
        {
            _logger.LogInformation("Creating connection with: {ConnectionString}", _connectionString);
            return new SqlConnection(_connectionString);
        }
    }
}
