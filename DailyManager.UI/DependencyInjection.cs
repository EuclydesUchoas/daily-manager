using Microsoft.Extensions.DependencyInjection;

namespace DailyManager.UI
{
    internal static class DependencyInjection
    {
        internal static void RegisterUIServices(this IServiceCollection services)
        {
            services.RegisterForms();
        }

        private static void RegisterForms(this IServiceCollection services)
        {
            services.AddSingleton<MainForm>();
        }
    }
}
