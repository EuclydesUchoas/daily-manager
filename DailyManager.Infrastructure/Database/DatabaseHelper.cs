using System.Configuration;

namespace DailyManager.Infrastructure.Database
{
    internal static class DatabaseHelper
    {
        private static string _connectionString;

        /// <summary>
        /// Get the database connection string from the configuration file.
        /// </summary>
        /// <returns>Connection string for the database.</returns>
        public static string GetConnectionString()
        {
            if (!string.IsNullOrWhiteSpace(_connectionString))
                return _connectionString;

            string connectionString = ConfigurationManager.ConnectionStrings["databaseConnection"]?.ConnectionString;
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ConfigurationErrorsException("Database connection string is not configured.");
            }

            _connectionString = connectionString;

            return _connectionString;
        }
    }
}
