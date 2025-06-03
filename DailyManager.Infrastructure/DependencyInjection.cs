using DailyManager.Infrastructure.Database;
using DailyManager.Infrastructure.Database.Factory;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;

namespace DailyManager.Infrastructure
{
    public static class DependencyInjection
    {
        public static void RegisterInfrastructureServices(this IServiceCollection services)
        {
            services.AddSingleton<IDatabaseFactory, DatabaseFactory>();

            services.RegisterMigrationRunner();
        }

        private static void RegisterMigrationRunner(this IServiceCollection serviceDescriptors)
        {
            string connectionString = DatabaseHelper.GetConnectionString();

            serviceDescriptors.AddFluentMigratorCore()
                .ConfigureRunner(x => x
                    .AddSQLite()
                    .WithGlobalConnectionString(connectionString)
                    .ScanIn(typeof(DependencyInjection).Assembly).For.Migrations())
                .AddLogging(x => x.AddFluentMigratorConsole());
        }
    }
}
