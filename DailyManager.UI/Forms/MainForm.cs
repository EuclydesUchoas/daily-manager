using DailyManager.UI.Forms.Companies;
using DailyManager.UI.Forms.Settings;
using DailyManager.UI.Forms.TestAnnotations;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DailyManager.UI.Forms
{
    public partial class MainForm : AppForm
    {
        private readonly IServiceProvider _serviceProvider;

        public MainForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            InitializeComponent();
        }

        // Daily

        private RegisterTestAnnotationForm _registerTestAnnotationForm;
        private void ButtonCreateDaily_Click(object sender, EventArgs e)
        {
            var registerTestAnnotationForm = _registerTestAnnotationForm ??
                (_registerTestAnnotationForm = _serviceProvider.GetRequiredService<RegisterTestAnnotationForm>());

            registerTestAnnotationForm.PrepareToCreate();

            registerTestAnnotationForm.ShowDialog(this);
        }

        private TestAnnotationListForm _testAnnotationListForm;
        private void ButtonDailyList_Click(object sender, EventArgs e)
        {
            var testAnnotationListForm = _testAnnotationListForm ??
                (_testAnnotationListForm = _serviceProvider.GetRequiredService<TestAnnotationListForm>());

            testAnnotationListForm.ShowDialog(this);
        }

        // Company

        private RegisterCompanyForm _registerCompanyForm;
        private void ButtonCreateCompany_Click(object sender, EventArgs e)
        {
            var registerCompanyForm = _registerCompanyForm ??
                (_registerCompanyForm = _serviceProvider.GetRequiredService<RegisterCompanyForm>());

            registerCompanyForm.PrepareToCreate();

            try
            {
                this.Hide();
                registerCompanyForm.ShowDialog(this);
            }
            finally
            {
                this.Show();
            }
        }


        private void ButtonCompanyList_Click(object sender, EventArgs e)
        {

        }

        // Settings

        private SettingsForm _settingsForm;
        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = _settingsForm ??
                (_settingsForm = _serviceProvider.GetRequiredService<SettingsForm>());

            settingsForm.ShowDialog(this);
        }
    }
}
