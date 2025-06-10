using DailyManager.Application.Meditator;
using DailyManager.Domain.Entities.Companies;
using System;

namespace DailyManager.Application.Features.Companies
{
    public sealed class GetCompanyByIdRequest : IRequest<Company>
    {
        public readonly Guid Id;

        public GetCompanyByIdRequest(Guid id)
        {
            Id = id;
        }
    }
}
