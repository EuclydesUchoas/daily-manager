using DailyManager.Application.Features.TestAnnotations;
using DailyManager.Application.Meditator;
using DailyManager.Domain.Entities.TestAnnotations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace DailyManager.UI.Forms.TestAnnotations
{
    public partial class TestAnnotationListForm : AppForm
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ISender _sender;

        public TestAnnotationListForm(IServiceProvider serviceProvider, ISender sender)
        {
            _serviceProvider = serviceProvider;
            _sender = sender;
            
            InitializeComponent();
        }

        private void TestAnnotationListForm_Load(object sender, EventArgs e)
        {
            LoadTestAnnotations();

            //dataGridViewTestAnnotationList.EnableHeadersVisualStyles = false;
            //dataGridViewTestAnnotationList.ColumnHeadersDefaultCellStyle.SelectionBackColor = dataGridViewTestAnnotationList.ColumnHeadersDefaultCellStyle.BackColor;

            //dataGridViewTestAnnotationList.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromKnownColor(KnownColor.Control);
        }

        private async void LoadTestAnnotations()
        {
            var request = new GetAllTestAnnotationBasicRequest();

            var testAnnotations = await _sender.Send(request);

            dataGridViewTestAnnotationList.AutoGenerateColumns = false;
            dataGridViewTestAnnotationList.DataSource = testAnnotations;
        }

        private void DataGridViewTestAnnotationList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var testAnnotationBasic = dataGridViewTestAnnotationList.SelectedRows[0].DataBoundItem as TestAnnotationBasic;

            UpdateTestAnnotation(testAnnotationBasic);
        }

        private async void UpdateTestAnnotation(TestAnnotationBasic testAnnotationBasic)
        {
            if (testAnnotationBasic is null)
            {
                MessageBox.Show("Invalid selection. Please select a valid test annotation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (testAnnotationBasic.Id == Guid.Empty)
            {
                MessageBox.Show("Invalid test annotation ID. Please select a valid test annotation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var request = new GetTestAnnotationByIdRequest(testAnnotationBasic.Id);

            var testAnnotation = await _sender.Send(request);

            if (testAnnotation is null)
            {
                MessageBox.Show("Test annotation not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var registerTestAnnotationForm = _serviceProvider.GetRequiredService<RegisterTestAnnotationForm>();

            registerTestAnnotationForm.PrepareToUpdate(testAnnotation);
            registerTestAnnotationForm.ShowDialog(this);
        }

        private void CreateTestAnnotation()
        {
            var registerTestAnnotationForm = _serviceProvider.GetRequiredService<RegisterTestAnnotationForm>();

            registerTestAnnotationForm.PrepareToCreate();
            registerTestAnnotationForm.ShowDialog(this);
        }
    }
}
