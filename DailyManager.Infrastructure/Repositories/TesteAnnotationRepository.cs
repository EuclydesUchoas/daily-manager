using DailyManager.Domain.Entities.TestAnnotations;
using DailyManager.Domain.Repositories.TestAnnotations;
using DailyManager.Infrastructure.Database.Factory;
using Dapper;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DailyManager.Infrastructure.Repositories
{
    public sealed class TesteAnnotationRepository : ITestAnnotationRepository
    {
        private readonly IDatabaseFactory _databaseFactory;

        public TesteAnnotationRepository(IDatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
        }

        public async Task Create(TestAnnotation testAnnotation, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            using (var conn = _databaseFactory.GetDatabaseConnection())
            {
                const string sql = "INSERT INTO TestAnnotations (Name, Description, CreatedAt) VALUES (@Name, @Description, @CreatedAt)";

                await conn.ExecuteAsync(sql, testAnnotation);
            }
        }

        public async Task<IEnumerable<TestAnnotation>> GetAll(CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            using (var conn = _databaseFactory.GetDatabaseConnection())
            {
                const string sql = "SELECT * FROM TestAnnotations";

                var testAnnotations = await conn.QueryAsync<TestAnnotation>(sql, cancellationToken);

                return testAnnotations;
            }
        }

        public async Task<IEnumerable<TestAnnotationBasic>> GetAllBasic(CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            using (var conn = _databaseFactory.GetDatabaseConnection())
            {
                const string sql = "SELECT Id, Name, CreatedAt FROM TestAnnotations";

                var testAnnotations = await conn.QueryAsync<TestAnnotationBasic>(sql, cancellationToken);

                return testAnnotations;
            }
        }
    }
}
