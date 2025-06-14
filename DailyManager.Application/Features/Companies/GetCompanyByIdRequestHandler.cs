﻿using DailyManager.Application.Meditator;
using DailyManager.Domain.Entities.Companies;
using DailyManager.Domain.Repositories.Companies;
using System.Threading;
using System.Threading.Tasks;

namespace DailyManager.Application.Features.Companies
{
    public sealed class GetCompanyByIdRequestHandler : IRequestHandler<GetCompanyByIdRequest, Company>
    {
        private readonly ICompanyRepository _companyRepository;

        public GetCompanyByIdRequestHandler(
            ICompanyRepository companyRepository
            )
        {
            _companyRepository = companyRepository;
        }

        public async Task<Company> Handle(GetCompanyByIdRequest request, CancellationToken cancellationToken = default)
        {
            var company = await _companyRepository.GetById(request.Id, cancellationToken);

            return company;
        }
    }
}
