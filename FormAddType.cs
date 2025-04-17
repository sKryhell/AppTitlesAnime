using System.ComponentModel;

namespace AppTitlesAnime
{
    public partial class FormAddType : Form
    {
        string msgError = "Поле не может быть пустым";
        public FormAddType()
        {
            InitializeComponent();
        }

        private void TextBoxTypeName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTypeName.Text))
            {
                errorProvider.SetError(textBoxTypeName, msgError);
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveChanges.Enabled = true;
            }
        }
        private void TextBoxTypeName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTypeName.Text))
            {
                errorProvider.SetError(textBoxTypeName, msgError);
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveChanges.Enabled = true;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

        }

        private void bnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
