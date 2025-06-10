using DailyManager.Application.Meditator;
using DailyManager.Domain.Entities.Companies;
using DailyManager.Domain.Repositories.Companies;
using System.Threading;
using System.Threading.Tasks;

namespace DailyManager.Application.Features.Companies
{
    public sealed class GetCompanyByIdRequestHandler : IRequestHandler<GetCompanyByIdRequest, Company>
    {
        private readonly ICompanyRepository _testAnnotationRepository;

        public GetCompanyByIdRequestHandler(
            ICompanyRepository testAnnotationRepository
            )
        {
            _testAnnotationRepository = testAnnotationRepository;
        }

        public async Task<Company> Handle(GetCompanyByIdRequest request, CancellationToken cancellationToken = default)
        {
            var testAnnotation = await _testAnnotationRepository.GetById(request.Id, cancellationToken);

            return testAnnotation;
        }
    }
}
