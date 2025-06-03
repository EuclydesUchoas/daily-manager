using DailyManager.Infrastructure.Database;
using DailyManager.Infrastructure.Database.Context;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;

namespace DailyManager.Infrastructure
{
    public static class DependencyInjection
    {
        public static void RegisterInfrastructureServices(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.RegisterContext();

            serviceDescriptors.RegisterMigrationRunner();
        }

        private static void RegisterContext(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddSingleton<AppDbContext>();
        }

        private static void RegisterMigrationRunner(this IServiceCollection serviceDescriptors)
        {
            string connectionString = DatabaseHelper.GetConnectionString();
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException("Connection string 'AppDbContext' is not configured in the application settings.");
            }

            serviceDescriptors.AddFluentMigratorCore()
                .ConfigureRunner(x => x
                    .AddSQLite()
                    .WithGlobalConnectionString(connectionString)
                    .ScanIn(typeof(DependencyInjection).Assembly).For.Migrations())
                .AddLogging(x => x.AddFluentMigratorConsole())
                .BuildServiceProvider(false);
        }
    }
}
