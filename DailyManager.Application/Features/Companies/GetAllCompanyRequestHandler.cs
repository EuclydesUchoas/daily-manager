using DailyManager.Application.Meditator;
using DailyManager.Domain.Entities.Companies;
using DailyManager.Domain.Repositories.Companies;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DailyManager.Application.Features.Companies
{
    public sealed class GetAllCompanyRequestHandler : IRequestHandler<GetAllCompanyRequest, IEnumerable<Company>>
    {
        private readonly ICompanyRepository _companyRepository;

        public GetAllCompanyRequestHandler(
            ICompanyRepository companyRepository
            )
        {
            _companyRepository = companyRepository;
        }

        public async Task<IEnumerable<Company>> Handle(GetAllCompanyRequest request, CancellationToken cancellationToken = default)
        {
            var companies = await _companyRepository.GetAll(cancellationToken);

            return companies;
        }
    }
}
