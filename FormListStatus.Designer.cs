namespace AppTitlesAnime
{
    partial class FormListStatus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelFill = new Panel();
            dataGridViewStatuses = new DataGridView();
            flowLayoutPanelTop = new FlowLayoutPanel();
            btnAddStatus = new Button();
            btnUpdateStatus = new Button();
            btnDeleteStatus = new Button();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatuses).BeginInit();
            flowLayoutPanelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewStatuses);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 65);
            panelFill.Margin = new Padding(5, 5, 5, 5);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(934, 546);
            panelFill.TabIndex = 5;
            // 
            // dataGridViewStatuses
            // 
            dataGridViewStatuses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStatuses.BackgroundColor = Color.White;
            dataGridViewStatuses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStatuses.Dock = DockStyle.Fill;
            dataGridViewStatuses.Location = new Point(10, 10);
            dataGridViewStatuses.Margin = new Padding(5, 5, 5, 5);
            dataGridViewStatuses.Name = "dataGridViewStatuses";
            dataGridViewStatuses.ReadOnly = true;
            dataGridViewStatuses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStatuses.Size = new Size(914, 526);
            dataGridViewStatuses.TabIndex = 2;
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.Controls.Add(btnAddStatus);
            flowLayoutPanelTop.Controls.Add(btnUpdateStatus);
            flowLayoutPanelTop.Controls.Add(btnDeleteStatus);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Margin = new Padding(5, 5, 5, 5);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(934, 65);
            flowLayoutPanelTop.TabIndex = 4;
            // 
            // btnAddStatus
            // 
            btnAddStatus.AutoSize = true;
            btnAddStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddStatus.Location = new Point(15, 15);
            btnAddStatus.Margin = new Padding(5, 5, 5, 5);
            btnAddStatus.Name = "btnAddStatus";
            btnAddStatus.Size = new Size(106, 35);
            btnAddStatus.TabIndex = 0;
            btnAddStatus.Text = "Добавить";
            btnAddStatus.UseVisualStyleBackColor = true;
            btnAddStatus.Click += BtnAddStatus_Click;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.AutoSize = true;
            btnUpdateStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnUpdateStatus.Location = new Point(131, 15);
            btnUpdateStatus.Margin = new Padding(5, 5, 5, 5);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(151, 35);
            btnUpdateStatus.TabIndex = 1;
            btnUpdateStatus.Text = "Редактировать";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += BtnUpdateStatus_Click;
            // 
            // btnDeleteStatus
            // 
            btnDeleteStatus.AutoSize = true;
            btnDeleteStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDeleteStatus.Location = new Point(292, 15);
            btnDeleteStatus.Margin = new Padding(5, 5, 5, 5);
            btnDeleteStatus.Name = "btnDeleteStatus";
            btnDeleteStatus.Size = new Size(92, 35);
            btnDeleteStatus.TabIndex = 2;
            btnDeleteStatus.Text = "Удалить";
            btnDeleteStatus.UseVisualStyleBackColor = true;
            btnDeleteStatus.Click += BtnDeleteStatus_Click;
            // 
            // FormListStatus
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 611);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FormListStatus";
            Text = "Статус аниме";
            WindowState = FormWindowState.Maximized;
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatuses).EndInit();
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelFill;
        private DataGridView dataGridViewStatuses;
        private FlowLayoutPanel flowLayoutPanelTop;
        private Button btnAddStatus;
        private Button btnUpdateStatus;
        private Button btnDeleteStatus;
    }
}