using DailyManager.Application.Exceptions;
using DailyManager.Application.Features.Companies;
using DailyManager.Application.Meditator;
using DailyManager.Domain.Entities.Companies;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyManager.UI.Forms.Companies
{
    public partial class RegisterCompanyForm : AppForm
    {
        private readonly ISender _sender;

        private Company _company;

        public RegisterCompanyForm(ISender sender)
        {
            _sender = sender;

            InitializeComponent();
        }

        public void PrepareToCreate()
        {
            _company = null;

            maskedTextBoxCNPJ.Clear();
            textBoxName.Clear();
        }

        public void PrepareToUpdate(Company company)
        {
            if (_company == null || _company.Id == Guid.Empty)
            {
                throw new InvalidOperationException("Company is not valid.");
            }

            _company = company;

            maskedTextBoxCNPJ.Text = _company.CNPJ;
            textBoxName.Text = _company.Name;
        }        

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_company == null)
                {
                    CreateCompany().GetAwaiter().GetResult();
                    this.Close();
                    
                    return;
                }

                UpdateCompany().GetAwaiter().GetResult();
                this.Close();
            }
            catch (ValidationFailedException ex)
            {
                MessageBox.Show(this, ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CreateCompany()
        {
            var request = new CreateCompanyRequest(
                maskedTextBoxCNPJ.Text,
                textBoxName.Text
                );

            await _sender.Send(request);
        }

        private async Task UpdateCompany()
        {
            /*var request = new UpdateCompanyRequest(
                _company.Id,
                maskedTextBoxCNPJ.Text,
                textBoxName.Text
                );

            await _sender.Send(request);*/
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
