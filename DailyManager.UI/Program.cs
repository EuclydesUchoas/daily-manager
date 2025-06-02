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
            // Cria o ServiceCollection
            var services = new ServiceCollection();

            // Registra os serviços necessários
            services.RegisterUIServices();

            // Constrói o ServiceProvider
            var serviceProvider = services.BuildServiceProvider();            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Resolve o MainForm
            var mainForm = serviceProvider.GetRequiredService<MainForm>();

            Application.Run(mainForm);
        }
    }
}
