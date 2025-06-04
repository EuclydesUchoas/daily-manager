using System;

namespace DailyManager.Domain.Entities.TestAnnotations
{
    public sealed class TestAnnotationBasic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
