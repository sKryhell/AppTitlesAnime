namespace AppTitlesAnime
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnShowTypes_Click(object sender, EventArgs e)
        {
            FormListTypes formListTypes = new FormListTypes();
            formListTypes.Show();
        }
        private void BtnShowGenres_Click(object sender, EventArgs e)
        {
            FormListGenres formListGenre = new FormListGenres();
            formListGenre.Show();
        }

        private void ButtonShowStatus_Click(object sender, EventArgs e)
        {
            FormListStatus formListStatus = new FormListStatus();
            formListStatus.Show();
        }
    }
}
