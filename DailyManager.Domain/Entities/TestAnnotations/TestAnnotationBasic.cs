﻿using System;

namespace DailyManager.Domain.Entities.TestAnnotations
{
    public sealed class TestAnnotationBasic : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
