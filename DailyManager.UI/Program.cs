using DailyManager.Application;
using DailyManager.Infrastructure;
using DailyManager.Infrastructure.Database.Factory;
using Microsoft.Extensions.DependencyInjection;
using System;
using WinForms = System.Windows.Forms;

namespace DailyManager.UI
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WinForms.Application.EnableVisualStyles();
            WinForms.Application.SetCompatibleTextRenderingDefault(false);

            var services = RegisterServices();

            var serviceProvider = services.BuildServiceProvider();

            ExecuteDatabaseFactory(serviceProvider);

            var mainForm = serviceProvider.GetRequiredService<MainForm>();

            WinForms.Application.Run(mainForm);
        }

        private static IServiceCollection RegisterServices()
        {
            var services = new ServiceCollection();

            services
                .RegisterApplicationServices()
                .RegisterInfrastructureServices()
                .RegisterUIServices();

            return services;
        }

        private static void ExecuteDatabaseFactory(IServiceProvider serviceProvider)
        {
            var databaseFactory = serviceProvider.GetRequiredService<IDatabaseFactory>();

            databaseFactory.TestConnection();
            databaseFactory.TestDapper();

            databaseFactory.RunMigrations(migrateUp: true);
        }
    }
}
