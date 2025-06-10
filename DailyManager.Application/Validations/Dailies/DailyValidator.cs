using DailyManager.Domain.Entities.Dailies;
using FluentValidation;
using System;

namespace DailyManager.Application.Validations.Dailies
{
    public sealed class DailyValidator : AbstractValidator<Daily>
    {
        public DailyValidator()
        {
            RuleFor(x => x.CompanyId)
                .NotEmpty().WithMessage("Company is required.");

            RuleFor(x => x.Date)
                .NotEmpty().WithMessage("Date is required.")
                .ExclusiveBetween(new DateTime(2000, 1, 1), new DateTime(3000, 1, 1))
                .WithMessage("Date must be between January 1, 2000 and January 1, 3000.");

            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title is required.")
                .MaximumLength(100).WithMessage("Title must not exceed 100 characters.");

            RuleFor(x => x.Description)
                .MaximumLength(10000).WithMessage("Description must not exceed 10,000 characters.")
                .When(x => !string.IsNullOrEmpty(x.Description));
        }
    }
}
