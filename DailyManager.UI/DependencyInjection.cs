using Microsoft.Extensions.DependencyInjection;

namespace DailyManager.UI
{
    internal static class DependencyInjection
    {
        public static void RegisterUIServices(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.RegisterForms();
        }

        private static void RegisterForms(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddSingleton<MainForm>();
        }
    }
}
