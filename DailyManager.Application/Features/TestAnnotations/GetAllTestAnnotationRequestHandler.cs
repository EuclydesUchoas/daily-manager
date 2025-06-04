using DailyManager.Application.Meditator;
using DailyManager.Domain.Entities.TestAnnotations;
using DailyManager.Domain.Repositories.TestAnnotations;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DailyManager.Application.Features.TestAnnotations
{
    public sealed class GetAllTestAnnotationRequestHandler : IRequestHandler<GetAllTestAnnotationRequest, IEnumerable<TestAnnotation>>
    {
        private readonly ITestAnnotationRepository _testAnnotationRepository;

        public GetAllTestAnnotationRequestHandler(
            ITestAnnotationRepository testAnnotationRepository
            )
        {
            _testAnnotationRepository = testAnnotationRepository;
        }

        public async Task<IEnumerable<TestAnnotation>> Handle(GetAllTestAnnotationRequest request, CancellationToken cancellationToken = default)
        {
            var testAnnotations = await _testAnnotationRepository.GetAll(cancellationToken);

            return testAnnotations;
        }
    }
}
