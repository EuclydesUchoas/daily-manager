using System.Windows.Forms;

namespace DailyManager.UI.Abstractions.Forms
{
    internal class AppForm : Form
    {
        protected bool FieldsLocked { get; private set; }

        internal void LockFields()
        {
            LockOrUnlockFields(true);
            FieldsLocked = true;
        }

        internal void UnlockFields()
        {
            LockOrUnlockFields(false);
            FieldsLocked = false;
        }

        private void LockOrUnlockFields(bool lockFields)
        {
            foreach (Control control in Controls)
            {
                switch (control)
                {
                    case TextBox textBox:
                        textBox.ReadOnly = lockFields;
                        break;
                    case ComboBox comboBox:
                        comboBox.Enabled = !lockFields;
                        break;
                    default:
                        control.Enabled = !lockFields;
                        break;
                }
            }
        }
    }
}
