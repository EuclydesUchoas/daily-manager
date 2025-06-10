using DailyManager.Application.Meditator;

namespace DailyManager.Application.Features.Companies
{
    public sealed class CreateCompanyRequest : IRequest
    {
        public readonly string CNPJ;
        public readonly string Name;

        public CreateCompanyRequest(string cnpj, string name)
        {
            CNPJ = cnpj;
            Name = name;
        }
    }
}
