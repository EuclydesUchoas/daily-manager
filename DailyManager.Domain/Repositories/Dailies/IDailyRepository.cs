using DailyManager.Domain.Entities.Dailies;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DailyManager.Domain.Repositories.Dailies
{
    public interface IDailyRepository
    {
        Task Create(Daily daily, CancellationToken cancellationToken = default);

        Task<Daily> GetById(Guid id, CancellationToken cancellationToken = default);
        Task<IEnumerable<Daily>> GetAll(CancellationToken cancellationToken = default);
    }
}
