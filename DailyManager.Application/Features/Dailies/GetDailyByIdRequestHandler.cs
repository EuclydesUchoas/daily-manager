using DailyManager.Application.Meditator;
using DailyManager.Domain.Entities.Dailies;
using DailyManager.Domain.Repositories.Dailies;
using System.Threading;
using System.Threading.Tasks;

namespace DailyManager.Application.Features.Dailies
{
    public sealed class GetDailyByIdRequestHandler : IRequestHandler<GetDailyByIdRequest, Daily>
    {
        private readonly IDailyRepository _dailyRepository;

        public GetDailyByIdRequestHandler(
            IDailyRepository dailyRepository
            )
        {
            _dailyRepository = dailyRepository;
        }

        public async Task<Daily> Handle(GetDailyByIdRequest request, CancellationToken cancellationToken = default)
        {
            var daily = await _dailyRepository.GetById(request.Id, cancellationToken);

            return daily;
        }
    }
}
