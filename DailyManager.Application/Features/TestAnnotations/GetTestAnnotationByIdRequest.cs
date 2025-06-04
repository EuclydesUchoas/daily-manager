using DailyManager.Application.Meditator;
using DailyManager.Domain.Entities.TestAnnotations;
using System;

namespace DailyManager.Application.Features.TestAnnotations
{
    public sealed class GetTestAnnotationByIdRequest : IRequest<TestAnnotation>
    {
        public readonly Guid Id;

        public GetTestAnnotationByIdRequest(Guid id)
        {
            Id = id;
        }
    }
}
