using FluentMigrator.Runner;
using FluentMigrator.Runner.Exceptions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Data.Common;
using System.Data.SQLite;

namespace DailyManager.Infrastructure.Database.Factory
{
    internal sealed class DatabaseFactory : IDatabaseFactory
    {
        private readonly string _connectionString;
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public DatabaseFactory(IServiceScopeFactory serviceScopeFactory)
        {
            _connectionString = DatabaseHelper.GetConnectionString();
            _serviceScopeFactory = serviceScopeFactory;
        }

        public string GetConnectionString()
        {
            return _connectionString;
        }

        public DbConnection GetDatabaseConnection()
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
    }
}
