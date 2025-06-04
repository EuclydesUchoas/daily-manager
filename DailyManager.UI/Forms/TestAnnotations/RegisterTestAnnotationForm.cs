using DailyManager.Application.Meditator;
using DailyManager.Domain.Entities.TestAnnotations;
using System;

namespace DailyManager.UI.Forms.TestAnnotations
{
    public partial class RegisterTestAnnotationForm : AppForm
    {
        private readonly ISender _sender;

        private TestAnnotation _data;

        public RegisterTestAnnotationForm(ISender sender)
        {
            _sender = sender;

            InitializeComponent();
        }

        public void PrepareToCreate()
        {
            _data = null;

            textBoxName.Text = string.Empty;
            richTextBoxDescription.Text = string.Empty;
        }

        public void PrepareToUpdate(TestAnnotation testAnnotation)
        {
            if (testAnnotation is null)
            {
                throw new ArgumentNullException(nameof(testAnnotation), "TestAnnotation cannot be null.");
            }

            if (testAnnotation.Id == Guid.Empty)
            {
                throw new ArgumentException("TestAnnotation must have a valid Id.", nameof(testAnnotation));
            }

            _data = testAnnotation;

            textBoxName.Text = testAnnotation.Name;
            richTextBoxDescription.Text = testAnnotation.Description;
        }
    }
}
