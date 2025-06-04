using System;
using System.Configuration;
using System.Data.Common;

namespace DailyManager.Infrastructure.Database
{
    internal static class DatabaseHelper
    {
        private static string _connectionString;
        private static string _dataSource;

        /// <summary>
        /// Get the database connection string from the configuration file.
        /// </summary>
        /// <returns>Connection string for the database.</returns>
        public static string GetConnectionString()
        {
            if (!string.IsNullOrWhiteSpace(_connectionString))
            {
                return _connectionString;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["databaseConnection"]?.ConnectionString ?? string.Empty;
            connectionString = Environment.ExpandEnvironmentVariables(connectionString);

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ConfigurationErrorsException("Database connection string is not configured.");
            }

            ParseConnectionString(connectionString);

            _connectionString = connectionString;

            return _connectionString;
        }

        /// <summary>
        /// Get the data source from the connection string.
        /// </summary>
        /// <returns>Data source for the database.</returns>
        public static string GetDataSource()
        {
            if (string.IsNullOrWhiteSpace(_dataSource))
            {
                GetConnectionString();
            }

            return _dataSource;
        }

        /// <summary>
        /// Parses the connection string and extracts the data source.
        /// Throws an exception if the 'DataSource' is missing or empty.
        /// </summary>
        private static void ParseConnectionString(string connectionString)
        {
            var builder = new DbConnectionStringBuilder()
            {
                ConnectionString = connectionString
            };

            if (!builder.TryGetValue("Data Source", out var dataSourceObj) 
                || !(dataSourceObj is string dataSource) 
                || string.IsNullOrWhiteSpace(dataSource))
            {
                throw new ConfigurationErrorsException("Database connection string is not configured correctly. 'DataSource' is missing.");
            }

            _dataSource = dataSource;

            /*var builder = new SQLiteConnectionStringBuilder(connectionString);

            string dataSource = builder.DataSource;

            if (string.IsNullOrWhiteSpace(dataSource))
            {
                throw new ConfigurationErrorsException("Database connection string is not configured correctly. 'DataSource' is missing.");
            }*/
        }
    }
}
