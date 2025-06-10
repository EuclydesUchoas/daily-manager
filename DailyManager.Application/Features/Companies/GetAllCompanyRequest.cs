using DailyManager.Application.Meditator;
using DailyManager.Domain.Entities.Companies;
using System.Collections.Generic;

namespace DailyManager.Application.Features.Companies
{
    public sealed class GetAllCompanyRequest : IRequest<IEnumerable<Company>>
    {

    }
}
