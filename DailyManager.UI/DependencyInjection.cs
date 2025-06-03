using Microsoft.Extensions.DependencyInjection;

namespace DailyManager.UI
{
    internal static class DependencyInjection
    {
        internal static void RegisterUIServices(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.RegisterForms();
        }

        private static void RegisterForms(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddSingleton<MainForm>();
        }
    }
}
