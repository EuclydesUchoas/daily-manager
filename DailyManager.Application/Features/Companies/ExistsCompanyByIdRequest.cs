using DailyManager.Application.Meditator;
using System;

namespace DailyManager.Application.Features.Companies
{
    public sealed class ExistsCompanyByIdRequest : IRequest<bool>
    {
        public readonly Guid Id;

        public ExistsCompanyByIdRequest(Guid id)
        {
            Id = id;
        }
    }
}
