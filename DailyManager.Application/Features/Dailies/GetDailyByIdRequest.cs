using DailyManager.Application.Meditator;
using DailyManager.Domain.Entities.Dailies;
using System;

namespace DailyManager.Application.Features.Dailies
{
    public sealed class GetDailyByIdRequest : IRequest<Daily>
    {
        public readonly Guid Id;

        public GetDailyByIdRequest(Guid id)
        {
            Id = id;
        }
    }
}
