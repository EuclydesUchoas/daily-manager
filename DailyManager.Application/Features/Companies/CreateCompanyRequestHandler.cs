using DailyManager.Application.Exceptions;
using DailyManager.Application.Mappings.Companies;
using DailyManager.Application.Meditator;
using DailyManager.Application.Validations.Companies;
using DailyManager.Domain.Repositories.Companies;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DailyManager.Application.Features.Companies
{
    public sealed class CreateCompanyRequestHandler : IRequestHandler<CreateCompanyRequest>
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly CompanyValidator _companyValidator;

        public CreateCompanyRequestHandler(
            ICompanyRepository companyRepository, 
            CompanyValidator companyValidator
            )
        {
            _companyRepository = companyRepository;
            _companyValidator = companyValidator;
        }

        public async Task Handle(CreateCompanyRequest request, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var company = request.ToDomain();

            var result = await _companyValidator.ValidateAsync(company);
            ValidationFailedException.ThrowIfValidationResultIsNotValid(result);

            company.Id = Guid.NewGuid();

            await _companyRepository.Create(company, cancellationToken);
        }
    }
}
