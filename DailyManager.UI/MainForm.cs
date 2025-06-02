using DailyManager.UI.Abstractions.Forms;
using System;

namespace DailyManager.UI
{
    internal sealed partial class MainForm : AppForm
    {
        private readonly IServiceProvider _serviceProvider;

        public MainForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            InitializeComponent();

            LockFields();

            button1.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (FieldsLocked)
            {
                UnlockFields();
                return;
            }
            LockFields();
            button1.Enabled = true;
        }
    }
}
