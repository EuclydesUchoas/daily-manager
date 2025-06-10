using DailyManager.Application.Features.Companies;
using DailyManager.Domain.Entities.Companies;
namespace DailyManager.Application.Mappings.Companies
{
    public static class CompanyMap
    {
        public static Company ToDomain(this CreateCompanyRequest request)
        {
            return request != null ? new Company
            {
                CNPJ = request.CNPJ,
                Name = request.Name,
            } : new Company();
        }
    }
}
