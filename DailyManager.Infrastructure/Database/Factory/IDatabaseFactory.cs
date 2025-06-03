using System.Data.Common;

namespace DailyManager.Infrastructure.Database.Factory
{
    public interface IDatabaseFactory
    {
        /// <summary>
        /// Gets the connection string for the database.
        /// </summary>
        /// <returns>A connection string.</returns>
        string GetConnectionString();

        /// <summary>
        /// Gets a database connection.
        /// </summary>
        /// <returns>A database connection.</returns>
        DbConnection GetDatabaseConnection();

        /// <summary>
        /// Runs database migrations.
        /// </summary>
        /// <param name="migrateUp">If true, runs migrations up; if false, rolls back all migrations.</param>
        void RunMigrations(bool migrateUp = true);
    }
}
