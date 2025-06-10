using DailyManager.Application.Meditator;
using DailyManager.Domain.Repositories.Companies;
using System.Threading;
using System.Threading.Tasks;

namespace DailyManager.Application.Features.Companies
{
    public sealed class ExistsCompanyByIdRequestHandler : IRequestHandler<ExistsCompanyByIdRequest, bool>
    {
        private readonly ICompanyRepository _companyRepository;

        public ExistsCompanyByIdRequestHandler(
            ICompanyRepository companyRepository
            )
        {
            _companyRepository = companyRepository;
        }

        public async Task<bool> Handle(ExistsCompanyByIdRequest request, CancellationToken cancellationToken = default)
        {
            var exists = await _companyRepository.ExistsById(request.Id, cancellationToken);

            return exists;
        }
    }
}
