using DailyManager.Infrastructure;
using DailyManager.Infrastructure.Database;
using DailyManager.Infrastructure.Database.Context;
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
        internal static void Main()
        {
            // Cria o ServiceCollection
            var services = new ServiceCollection();

            // Registra os serviços necessários
            services.RegisterUIServices();
            services.RegisterInfrastructureServices();

            // Constrói o ServiceProvider
            var serviceProvider = services.BuildServiceProvider();            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            serviceProvider.EnsureDatabaseCreated();
            serviceProvider.RunMigrations(migrateUp: true);

            // Resolve o MainForm
            var mainForm = serviceProvider.GetRequiredService<MainForm>();

            Application.Run(mainForm);
        }
    }
}
