using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using AppContext = AppTitlesAnime.Models.AppContext;
using Genre = AppTitlesAnime.Models.Genre;

namespace AppTitlesAnime
{
    public partial class FormListGenres : Form
    {
        private AppContext db;

        public FormListGenres()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.AnimeTitles.Load();
            this.dataGridViewGenres.DataSource = this.db.Genres.OrderBy(o => o.GenreName).ToList();

            //скрытие столбцов
            //dataGridViewGenres.Columns["Id"].Visible = false;
            //dataGridViewGenres.Columns["Ganre"].Visible = false;

            ////изменение названий заголовков столбцов
            //dataGridViewGenres.Columns["GenreName"].HeaderText = "Жанры аниме";

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void BtnAddGenre_Click(object sender, EventArgs e)
        {
            FormAddGenre formAddGenre = new();
            DialogResult result = formAddGenre.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Genre genre = new()
            {
                GenreName = formAddGenre.textBoxGenreName.Text
            };

            db.Genres.Add(genre);
            db.SaveChanges();

            MessageBox.Show("Новый обьект добавлен");

            this.dataGridViewGenres.DataSource = this.db.Genres.OrderBy(o => o.GenreName).ToList();
        }


        private void BtnUpdateGenre_Click(object sender, EventArgs e)
        {
            if (dataGridViewGenres.SelectedRows.Count == 0)
                return;

            int index = dataGridViewGenres.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewGenres[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            Genre genre = db.Genres.Find(id);

            FormAddGenre formGenreAdd = new();
            formGenreAdd.textBoxGenreName.Text = genre.GenreName;

            DialogResult result = formGenreAdd.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            genre.GenreName = formGenreAdd.textBoxGenreName.Text;

            db.SaveChanges();
            MessageBox.Show("Обьект обновлен");
            this.dataGridViewGenres.DataSource = this.db.Genres.OrderBy(o => o.GenreName).ToList();
        }

        private void BtnDeleteGenre_Click(object sender, EventArgs e)
        {
            if (dataGridViewGenres.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show(
                "Вы уверены что хотите удалить обьект?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            int index = dataGridViewGenres.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewGenres[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            Genre genre = db.Genres.Find(id);

            db.Genres.Remove(genre);
            db.SaveChanges();

            MessageBox.Show("Обьект удален");
            this.dataGridViewGenres.DataSource = this.db.Genres.OrderBy(o => o.GenreName).ToList();
        }
    }
}
