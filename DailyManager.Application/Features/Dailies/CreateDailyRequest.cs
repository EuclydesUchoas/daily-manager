using DailyManager.Application.Meditator;
using System;

namespace DailyManager.Application.Features.Dailies
{
    public sealed class CreateDailyRequest : IRequest
    {
        public readonly Guid CompanyId;
        public readonly DateTime Date;
        public readonly string Title;
        public readonly string Description;

        public CreateDailyRequest(Guid companyId, DateTime date, string title, string description)
        {
            CompanyId = companyId;
            Date = date;
            Title = title;
            Description = description;
        }
    }
}
