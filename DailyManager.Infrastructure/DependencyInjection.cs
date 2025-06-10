using DailyManager.Domain.Repositories.TestAnnotations;
using DailyManager.Infrastructure.Database;
using DailyManager.Infrastructure.Database.Factory;
using DailyManager.Infrastructure.Repositories.TestAnnotations;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;

namespace DailyManager.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection services)
        {
            services.AddSingleton<IDatabaseFactory, DatabaseFactory>();

            services.RegisterRepositories();
            services.RegisterMigrationRunner();

            return services;
        }

        private static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddSingleton<ITestAnnotationRepository, TestAnnotationRepository>();

            return services;
        }

        private static IServiceCollection RegisterMigrationRunner(this IServiceCollection services)
        {
            string connectionString = DatabaseHelper.GetConnectionString();

            services.AddFluentMigratorCore()
                .ConfigureRunner(x => x
                    .AddSQLite()
                    .WithGlobalConnectionString(connectionString)
                    .ScanIn(typeof(DependencyInjection).Assembly).For.Migrations())
                .AddLogging(x => x.AddFluentMigratorConsole());

            return services;
        }
    }
}
