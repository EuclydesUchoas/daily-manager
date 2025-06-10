using System;

namespace DailyManager.Domain.Entities.TestAnnotations
{
    public sealed class TestAnnotation : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
