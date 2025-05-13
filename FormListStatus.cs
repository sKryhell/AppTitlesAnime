using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using AppContext = AppTitlesAnime.Models.AppContext;
using Status = AppTitlesAnime.Models.Status;

namespace AppTitlesAnime
{
    public partial class FormListStatus : Form
    {
        private AppContext db;
        private object dataGridViewStatus;

        public FormListStatus()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.AnimeTitles.Load();
            this.dataGridViewStatuses.DataSource = this.db.Statuses.OrderBy(o => o.StatusName).ToList();

            ////скрытие столбцов
            //dataGridViewStatus.Columns["Id"].Visible = false;
            //dataGridViewStatus.Columns["AnimeTitles"].Visible = false;

            ////изменение названий заголовков столбцов
            //dataGridViewStatus.Columns["StatusName"].HeaderText = "Типы аниме";

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

            db.Statuses.Add(status);
            db.SaveChanges();

            MessageBox.Show("Новый обьект добавлен");

            this.dataGridViewStatuses.DataSource = this.db.Statuses.OrderBy(o => o.StatusName).ToList();
        }


        private void BtnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewStatuses.SelectedRows.Count == 0)
                return;

            int index = dataGridViewStatuses.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewStatuses[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            Status status = db.Statuses.Find(id);

            FormAddStatus formStatusAdd = new();
            formStatusAdd.textBoxStatusName.Text = status.StatusName;

            DialogResult result = formStatusAdd.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            status.StatusName = formStatusAdd.textBoxStatusName.Text;

            db.SaveChanges();
            MessageBox.Show("Обьект обновлен");
            this.dataGridViewStatuses.DataSource = this.db.Statuses.OrderBy(o => o.StatusName).ToList();
        }

        private void BtnDeleteStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewStatuses.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show(
                "Вы уверены что хотите удалить обьект?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            int index = dataGridViewStatuses.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewStatuses[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            Status status = db.Statuses.Find(id);

            db.Statuses.Remove(status);
            db.SaveChanges();

            MessageBox.Show("Обьект удален");
            this.dataGridViewStatuses.DataSource = this.db.Statuses.OrderBy(o => o.StatusName).ToList();
        }

        private void FormListTypes_Load(object sender, EventArgs e)
        {

        }
    }
}
