using System;

namespace DailyManager.Domain.Entities.Dailies
{
    public sealed class Daily : IEntity
    {
        public Guid Id { get; set; }

        public Guid CompanyId { get; set; }

        public DateTime Date { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
