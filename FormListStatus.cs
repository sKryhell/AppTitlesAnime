using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using AppContext = AppTitlesAnime.Models.AppContext;
using Status = AppTitlesAnime.Models.Status;

namespace AppTitlesAnime
{
    public partial class FormListStatuss : Form
    {
        private AppContext db;

        public FormListStatuss()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.AnimeTitles.Load();
            this.dataGridViewStatus.DataSource = this.db.Status.OrderBy(o => o.StatusName).ToList();

            //скрытие столбцов
            //dataGridViewStatuss.Columns["Id"].Visible = false;
            //dataGridViewStatuss.Columns["Ganre"].Visible = false;

            ////изменение названий заголовков столбцов
            //dataGridViewStatuss.Columns["StatusName"].HeaderText = "Жанры аниме";

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void BtnAddStatus_Click(object sender, EventArgs e)
        {
            FormAddStatus formAddStatus = new();
            DialogResult result = formAddStatus.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Status status = new()
            {
                StatusName = formAddStatus.textBoxStatusName.Text
            };

            db.Status.Add(status);
            db.SaveChanges();

            MessageBox.Show("Новый обьект добавлен");

            this.dataGridViewStatus.DataSource = this.db.Status.OrderBy(o => o.StatusName).ToList();
        }


        private void BtnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewStatus.SelectedRows.Count == 0)
                return;

            int index = dataGridViewStatus.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewStatus[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            Status status = db.Status.Find(id);

            FormAddStatus formStatusAdd = new();
            formStatusAdd.textBoxStatusName.Text = status.StatusName;

            DialogResult result = formStatusAdd.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            status.StatusName = formStatusAdd.textBoxStatusName.Text;

            db.SaveChanges();
            MessageBox.Show("Обьект обновлен");
            this.dataGridViewStatus.DataSource = this.db.Status.OrderBy(o => o.StatusName).ToList();
        }

        private void BtnDeleteStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewStatus.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show(
                "Вы уверены что хотите удалить обьект?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            int index = dataGridViewStatus.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewStatus[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            Status status = db.Status.Find(id);

            db.Status.Remove(status);
            db.SaveChanges();

            MessageBox.Show("Обьект удален");
            this.dataGridViewStatus.DataSource = this.db.Status.OrderBy(o => o.StatusName).ToList();
        }
    }
}
