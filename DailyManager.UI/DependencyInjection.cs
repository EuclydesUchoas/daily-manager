using DailyManager.UI.Forms;
using DailyManager.UI.Forms.TestAnnotations;
using Microsoft.Extensions.DependencyInjection;

namespace DailyManager.UI
{
    internal static class DependencyInjection
    {
        internal static IServiceCollection RegisterUIServices(this IServiceCollection services)
        {
            services.RegisterForms();

            return services;
        }

        private static IServiceCollection RegisterForms(this IServiceCollection services)
        {
            services.AddSingleton<MainForm>();
            services.AddSingleton<TestAnnotationListForm>();
            
            return services;
        }
    }
}
