using DailyManager.Application.Features.Dailies;
using DailyManager.Domain.Entities.Dailies;

namespace DailyManager.Application.Mappings.Dailies
{
    public static class DailyMap
    {
        public static Daily ToDomain(this CreateDailyRequest request)
        {
            return request != null ? new Daily
            {
                CompanyId = request.CompanyId,
                Date = request.Date,
                Title = request.Title,
                Description = request.Description,
            } : new Daily();
        }
    }
}
