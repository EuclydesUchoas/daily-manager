using DailyManager.Application.Features.TestAnnotations;
using DailyManager.Application.Meditator;
using System;

namespace DailyManager.UI.Forms.TestAnnotations
{
    public partial class TestAnnotationListForm : AppForm
    {
        private readonly ISender _sender;

        public TestAnnotationListForm(ISender sender)
        {
            _sender = sender;
            
            InitializeComponent();
        }

        private void TestAnnotationListForm_Load(object sender, EventArgs e)
        {
            LoadTestAnnotations();
        }

        private async void LoadTestAnnotations()
        {
            var request = new GetAllTestAnnotationBasicRequest();

            var testAnnotations = await _sender.Send(request);

            dataGridViewTestAnnotationList.AutoGenerateColumns = false;
            dataGridViewTestAnnotationList.DataSource = testAnnotations;
        }
    }
}
