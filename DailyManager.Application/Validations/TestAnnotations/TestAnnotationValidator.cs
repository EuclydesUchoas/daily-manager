using DailyManager.Domain.Entities.TestAnnotations;
using FluentValidation;

namespace DailyManager.Application.Validations.TestAnnotations
{
    public sealed class TestAnnotationValidator : AbstractValidator<TestAnnotation>
    {
        public TestAnnotationValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");

            RuleFor(x => x.Description)
                .MaximumLength(5000).WithMessage("Description must not exceed 5000 characters.");
        }
    }
}
