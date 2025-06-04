using DailyManager.Application.Meditator;
using DailyManager.Domain.Entities.TestAnnotations;
using DailyManager.Domain.Repositories.TestAnnotations;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DailyManager.Application.Features.TestAnnotations
{
    public sealed class GetAllTestAnnotationBasicRequestHandler : IRequestHandler<GetAllTestAnnotationBasicRequest, IEnumerable<TestAnnotationBasic>>
    {
        private readonly ITestAnnotationRepository _testAnnotationRepository;

        public GetAllTestAnnotationBasicRequestHandler(
            ITestAnnotationRepository testAnnotationRepository
            )
        {
            _testAnnotationRepository = testAnnotationRepository;
        }

        public async Task<IEnumerable<TestAnnotationBasic>> Handle(GetAllTestAnnotationBasicRequest request, CancellationToken cancellationToken = default)
        {
            var testAnnotations = await _testAnnotationRepository.GetAllBasic(cancellationToken);

            return testAnnotations;
        }
    }
}
