using DailyManager.Domain.Entities.Companies;
using DailyManager.Domain.Repositories.Companies;
using DailyManager.Infrastructure.Database.Factory;
using Dapper;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DailyManager.Infrastructure.Repositories.Companies
{
    public sealed class CompanyRepository : ICompanyRepository
    {
        private readonly IDatabaseFactory _databaseFactory;

        public CompanyRepository(IDatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
        }

        public async Task Create(Company company, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            using (var conn = _databaseFactory.GetDatabaseConnection())
            {
                const string sql = "INSERT INTO Companies (Id, CNPJ, Name) VALUES (@Id, @CNPJ, @Name)";

                await conn.ExecuteAsync(sql, company);
            }
        }

        public async Task<Company> GetById(Guid id, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            using (var conn = _databaseFactory.GetDatabaseConnection())
            {
                const string sql = "SELECT * FROM Companies WHERE Id = @Id";

                var companies = await conn.QueryFirstOrDefaultAsync<Company>(sql, new { Id = id });

                return companies;
            }
        }

        public async Task<IEnumerable<Company>> GetAll(CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            using (var conn = _databaseFactory.GetDatabaseConnection())
            {
                const string sql = "SELECT * FROM Companies";

                var companies = await conn.QueryAsync<Company>(sql);

                return companies;
            }
        }
    }
}
