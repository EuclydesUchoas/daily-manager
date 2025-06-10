using DailyManager.Domain.Entities.Dailies;
using DailyManager.Domain.Repositories.Dailies;
using DailyManager.Infrastructure.Database.Factory;
using Dapper;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DailyManager.Infrastructure.Repositories.Companies
{
    public sealed class DailyRepository : IDailyRepository
    {
        private readonly IDatabaseFactory _databaseFactory;

        public DailyRepository(IDatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
        }

        public async Task Create(Daily daily, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            using (var conn = _databaseFactory.GetDatabaseConnection())
            {
                const string sql = "INSERT INTO Dailies (Id, CompanyId, Date, Title, Description, CreatedAt, UpdatedAt) VALUES (@Id, @CompanyId, @Date, @Title, @Description, @CreatedAt, @UpdatedAt)";

                await conn.ExecuteAsync(sql, daily);
            }
        }

        public async Task<Daily> GetById(Guid id, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            using (var conn = _databaseFactory.GetDatabaseConnection())
            {
                const string sql = "SELECT * FROM Dailies WHERE Id = @Id";

                var dailies = await conn.QueryFirstOrDefaultAsync<Daily>(sql, new { Id = id });

                return dailies;
            }
        }

        public async Task<IEnumerable<Daily>> GetAll(CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            using (var conn = _databaseFactory.GetDatabaseConnection())
            {
                const string sql = "SELECT * FROM Dailies";

                var dailies = await conn.QueryAsync<Daily>(sql);

                return dailies;
            }
        }
    }
}
