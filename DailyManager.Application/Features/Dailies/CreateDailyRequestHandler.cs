using DailyManager.Application.Exceptions;
using DailyManager.Application.Features.Companies;
using DailyManager.Application.Mappings.Dailies;
using DailyManager.Application.Meditator;
using DailyManager.Application.Models;
using DailyManager.Application.Validations.Dailies;
using DailyManager.Domain.Repositories.Dailies;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DailyManager.Application.Features.Dailies
{
    public sealed class CreateDailyRequestHandler : IRequestHandler<CreateDailyRequest>
    {
        private readonly IDailyRepository _dailyRepository;
        private readonly DailyValidator _dailyValidator;
        private readonly ISender _sender;

        public CreateDailyRequestHandler(
            IDailyRepository dailyRepository,
            DailyValidator dailyValidator,
            ISender sender
            )
        {
            _dailyRepository = dailyRepository;
            _dailyValidator = dailyValidator;
            _sender = sender;
        }

        public async Task Handle(CreateDailyRequest request, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var daily = request.ToDomain();

            var result = await _dailyValidator.ValidateAsync(daily);
            ValidationFailedException.ThrowIfValidationResultIsNotValid(result);

            var requestExistsCompany = new ExistsCompanyByIdRequest(daily.CompanyId);
            var existsCompany = await _sender.Send(requestExistsCompany, cancellationToken);

            if (!existsCompany)
            {
                var errorModel = new ValidationErrorModel(nameof(daily.CompanyId), "Company does not exists.");
                throw new ValidationFailedException(errorModel);
            }

            daily.Id = Guid.NewGuid();

            await _dailyRepository.Create(daily, cancellationToken);
        }
    }
}
