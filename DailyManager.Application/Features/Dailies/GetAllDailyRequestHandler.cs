using DailyManager.Application.Meditator;
using DailyManager.Domain.Entities.Dailies;
using DailyManager.Domain.Repositories.Dailies;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DailyManager.Application.Features.Dailies
{
    public sealed class GetAllDailyRequestHandler : IRequestHandler<GetAllDailyRequest, IEnumerable<Daily>>
    {
        private readonly IDailyRepository _dailyRepository;

        public GetAllDailyRequestHandler(
            IDailyRepository dailyRepository
            )
        {
            _dailyRepository = dailyRepository;
        }

        public async Task<IEnumerable<Daily>> Handle(GetAllDailyRequest request, CancellationToken cancellationToken = default)
        {
            var dailies = await _dailyRepository.GetAll(cancellationToken);

            return dailies;
        }
    }
}
