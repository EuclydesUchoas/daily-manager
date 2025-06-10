using DailyManager.Domain.Entities.Companies;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DailyManager.Domain.Repositories.Companies
{
    public interface ICompanyRepository
    {
        Task Create(Company company, CancellationToken cancellationToken = default);

        Task<Company> GetById(Guid id, CancellationToken cancellationToken = default);
        Task<IEnumerable<Company>> GetAll(CancellationToken cancellationToken = default);

        Task<bool> ExistsById(Guid id, CancellationToken cancellationToken = default);
    }
}
