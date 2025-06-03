using DailyManager.Infrastructure;
using DailyManager.Infrastructure.Database.Factory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

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
            var services = new ServiceCollection();

            services.RegisterUIServices();
            services.RegisterInfrastructureServices();

            var serviceProvider = services.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var databaseFactory = serviceProvider.GetRequiredService<IDatabaseFactory>();
            databaseFactory.RunMigrations(migrateUp: true);

            var mainForm = serviceProvider.GetRequiredService<MainForm>();

            Application.Run(mainForm);
        }
    }
}
