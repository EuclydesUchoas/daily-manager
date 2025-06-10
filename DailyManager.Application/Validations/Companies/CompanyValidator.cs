using DailyManager.Domain.Entities.Companies;
using FluentValidation;

namespace DailyManager.Application.Validations.Companies
{
    public sealed class CompanyValidator : AbstractValidator<Company>
    {
        public CompanyValidator()
        {
            RuleFor(x => x.CNPJ)
                .NotEmpty().WithMessage("CNPJ is required.")
                .IsValidCNPJ().WithMessage("CNPJ is not valid.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");
        }
    }
}
