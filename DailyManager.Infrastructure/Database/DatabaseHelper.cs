using DailyManager.Infrastructure.Database.Context;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DailyManager.Infrastructure.Database
{
    public static class DatabaseHelper
    {
        public static string GetConnectionString()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AppDbContext"]?.ConnectionString;
            return connectionString;
        }

        public static void EnsureDatabaseCreated(this AppDbContext appDbContext)
        {
            appDbContext.Database.CreateIfNotExists();
        }

        public static void EnsureDatabaseCreated(this IServiceProvider serviceProvider)
        {
            var appDbContext = serviceProvider.GetRequiredService<AppDbContext>();
            appDbContext.Database.CreateIfNotExists();
        }

        public static void RunMigrations(this IServiceProvider serviceProvider, bool migrateUp = true)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var runner = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();

                if (migrateUp) runner.MigrateUp();
                else runner.MigrateDown(0);
            }
        }
    }
}
