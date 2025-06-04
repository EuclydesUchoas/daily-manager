using DailyManager.Application.Meditator;

namespace DailyManager.Application.Features.TestAnnotations
{
    public sealed class CreateTestAnnotationRequest : IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
