using Dapper;
using FluentMigrator.Runner;
using FluentMigrator.Runner.Exceptions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace DailyManager.Infrastructure.Database.Factory
{
    internal sealed class DatabaseFactory : IDatabaseFactory
    {
        private readonly string _connectionString;
        private readonly string _dataSource;
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public DatabaseFactory(IServiceScopeFactory serviceScopeFactory)
        {
            string connectionString = DatabaseHelper.GetConnectionString();
            string dataSource = DatabaseHelper.GetDataSource();

            _connectionString = connectionString;
            _dataSource = dataSource;
            _serviceScopeFactory = serviceScopeFactory;

            CreateDatabaseDirectoryIfNotExists();
        }

        private void CreateDatabaseDirectoryIfNotExists()
        {
            if (!File.Exists(_dataSource))
            {
                var directory = Path.GetDirectoryName(_dataSource);
                if (!string.IsNullOrWhiteSpace(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
            }
        }

        public string GetConnectionString()
        {
            return _connectionString;
        }

        public IDbConnection GetDatabaseConnection()
        {
            return new SQLiteConnection(_connectionString);
        }

        public void RunMigrations(bool migrateUp = true)
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var runner = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();

                try
                {
                    if (migrateUp) runner.MigrateUp();
                    else runner.MigrateDown(0);
                }
                catch (Exception ex)
                {
                    if (!(ex is MissingMigrationsException))
                        throw;
                }
            }
        }

        public bool TestConnection()
        {
            try
            {
                using (var connection = GetDatabaseConnection())
                {
                    connection.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool TestDapper()
        {
            try
            {
                using (var connection = GetDatabaseConnection())
                {
                    var result = connection.QueryFirstOrDefault<int?>("SELECT 1");
                    return result.HasValue && result.Value is 1;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
