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

        private SettingsForm _settingsForm;
        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = _settingsForm ??
                (_settingsForm = _serviceProvider.GetRequiredService<SettingsForm>());

            settingsForm.ShowDialog(this);
        }
    }
}
