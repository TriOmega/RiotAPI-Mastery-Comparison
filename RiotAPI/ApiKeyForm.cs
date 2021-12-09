using System;
using System.Windows.Forms;

namespace RiotAPI
{
    public partial class ApiKeyForm : Form
    {
        public string APIKeyText
        {
            get => apiKeyInputTextBox.Text;
            set => apiKeyInputTextBox.Text = value;
        }

        public ApiKeyForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !string.IsNullOrWhiteSpace(APIKeyText);
        }

        private void apiKeyInputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
            }
            else if (e.KeyData == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
