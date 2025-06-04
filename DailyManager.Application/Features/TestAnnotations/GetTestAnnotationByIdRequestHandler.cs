using DailyManager.Application.Meditator;
using DailyManager.Domain.Entities.TestAnnotations;
using DailyManager.Domain.Repositories.TestAnnotations;
using System.Threading;
using System.Threading.Tasks;

namespace DailyManager.Application.Features.TestAnnotations
{
    public sealed class GetTestAnnotationByIdRequestHandler : IRequestHandler<GetTestAnnotationByIdRequest, TestAnnotation>
    {
        private readonly ITestAnnotationRepository _testAnnotationRepository;

        public GetTestAnnotationByIdRequestHandler(
            ITestAnnotationRepository testAnnotationRepository
            )
        {
            _testAnnotationRepository = testAnnotationRepository;
        }

        public async Task<TestAnnotation> Handle(GetTestAnnotationByIdRequest request, CancellationToken cancellationToken = default)
        {
            var testAnnotation = await _testAnnotationRepository.GetById(request.Id, cancellationToken);

            return testAnnotation;
        }
    }
}
