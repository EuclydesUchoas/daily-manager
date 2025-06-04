using DailyManager.Application.Exceptions;
using DailyManager.Application.Features.TestAnnotations;
using DailyManager.Application.Meditator;
using DailyManager.UI.Forms.TestAnnotations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace DailyManager.UI
{
    public partial class MainForm : AppForm
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ISender _sender;

        public MainForm(IServiceProvider serviceProvider, ISender sender)
        {
            _serviceProvider = serviceProvider;
            _sender = sender;

            InitializeComponent();
        }

        private void ClearFields()
        {
            textBoxName.Clear();
            textBoxDescription.Clear();
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            RegisterTestAnnotation();
        }

        private async void RegisterTestAnnotation()
        {
            var request = new CreateTestAnnotationRequest
            {
                Name = textBoxName.Text,
                Description = textBoxDescription.Text,
            };

            try
            {
                await _sender.Send(request);

                ClearFields();
            }
            catch (ValidationFailedException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while registering the annotation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            var testAnnotationListForm = _serviceProvider.GetRequiredService<TestAnnotationListForm>();

            testAnnotationListForm.ShowDialog(this);
        }
    }
}
