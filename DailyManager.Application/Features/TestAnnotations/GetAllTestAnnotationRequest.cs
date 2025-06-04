using DailyManager.Application.Meditator;
using DailyManager.Domain.Entities.TestAnnotations;
using System.Collections.Generic;

namespace DailyManager.Application.Features.TestAnnotations
{
    public sealed class GetAllTestAnnotationRequest : IRequest<IEnumerable<TestAnnotation>>
    {

    }
}
