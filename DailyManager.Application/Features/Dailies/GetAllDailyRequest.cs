using DailyManager.Application.Meditator;
using DailyManager.Domain.Entities.Dailies;
using System.Collections.Generic;

namespace DailyManager.Application.Features.Dailies
{
    public sealed class GetAllDailyRequest : IRequest<IEnumerable<Daily>>
    {

    }
}
