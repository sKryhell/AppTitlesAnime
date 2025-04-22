namespace AppTitlesAnime
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnShowTypes_Click(object sender, EventArgs e)
        {
            FormListTypes formListTypes = new FormListTypes();
            formListTypes.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGenres formGenres = new FormGenres();
            formGenres.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
