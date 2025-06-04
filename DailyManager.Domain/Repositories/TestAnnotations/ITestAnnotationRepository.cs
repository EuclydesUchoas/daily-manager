using DailyManager.Domain.Entities.TestAnnotations;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DailyManager.Domain.Repositories.TestAnnotations
{
    public interface ITestAnnotationRepository
    {
        Task Create(TestAnnotation testAnnotation, CancellationToken cancellationToken = default);
        Task<IEnumerable<TestAnnotation>> GetAll(CancellationToken cancellationToken = default);
        Task<IEnumerable<TestAnnotationBasic>> GetAllBasic(CancellationToken cancellationToken = default);
    }
}
