using DailyManager.Application.Exceptions;
using DailyManager.Application.Mappings.TestAnnotations;
using DailyManager.Application.Meditator;
using DailyManager.Application.Validations.TestAnnotations;
using DailyManager.Domain.Repositories.TestAnnotations;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DailyManager.Application.Features.TestAnnotations
{
    public sealed class CreateTestAnnotationRequestHandler : IRequestHandler<CreateTestAnnotationRequest>
    {
        private readonly ITestAnnotationRepository _testAnnotationRepository;
        private readonly TestAnnotationValidator _testAnnotationValidator;

        public CreateTestAnnotationRequestHandler(
            ITestAnnotationRepository testAnnotationRepository, 
            TestAnnotationValidator testAnnotationValidator
            )
        {
            _testAnnotationRepository = testAnnotationRepository;
            _testAnnotationValidator = testAnnotationValidator;
        }

        public async Task Handle(CreateTestAnnotationRequest request, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var testAnnotation = request.ToDomain();

            var result = await _testAnnotationValidator.ValidateAsync(testAnnotation);

            ValidationFailedException.ThrowIfValidationResultIsNotValid(result);

            testAnnotation.CreatedAt = DateTime.UtcNow;

            await _testAnnotationRepository.Create(testAnnotation, cancellationToken);
        }
    }
}
