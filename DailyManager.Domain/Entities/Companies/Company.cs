using System;

namespace DailyManager.Domain.Entities.Companies
{
    public sealed class Company : IEntity
    {
        public Guid Id { get; set; }

        public string CNPJ { get; set; }

        public string Name { get; set; }
    }
}
