using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTitlesAnime
{
    public partial class FormAddType : Form
    {
        public FormAddType()
        {
            InitializeComponent();
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {

        }

        private ErrorProvider GetErrorProvider(ErrorProvider errorProvider)
        {
            return errorProvider;
        }

        private void textBoxTypeName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTypeName.Text))
            {
                errorProvider.SetError(textBoxTypeName, "Полу не может быть пустым");
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveChanges.Enabled = false;
            }
        }
        private void textBoxTypeName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTypeName.Text))
            {
                errorProvider.SetError(textBoxTypeName, "Полу не может быть пустым");
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveChanges.Enabled = false;
            }
        }

        private void FormAddType_Load(object sender, EventArgs e)
        {

        }
    }
}
