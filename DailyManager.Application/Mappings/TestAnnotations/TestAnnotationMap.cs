using DailyManager.Application.Features.TestAnnotations;
using DailyManager.Domain.Entities.TestAnnotations;

namespace DailyManager.Application.Mappings.TestAnnotations
{
    public static class TestAnnotationMap
    {
        public static TestAnnotation ToDomain(this CreateTestAnnotationRequest request)
        {
            return request != null ? new TestAnnotation
            {
                Name = request.Name,
                Description = request.Description,
            } : new TestAnnotation();
        }
    }
}
