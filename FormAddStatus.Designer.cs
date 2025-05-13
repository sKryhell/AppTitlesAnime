namespace AppTitlesAnime
{
    partial class FormAddStatus
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
            components = new System.ComponentModel.Container();
            panelFill = new Panel();
            textBoxStatusName = new TextBox();
            labelTypeName = new Label();
            flowLayoutPanelBottom = new FlowLayoutPanel();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            errorProvider = new ErrorProvider(components);
            panelFill.SuspendLayout();
            flowLayoutPanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.AutoSize = true;
            panelFill.Controls.Add(textBoxStatusName);
            panelFill.Controls.Add(labelTypeName);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Margin = new Padding(5);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(13);
            panelFill.Size = new Size(384, 76);
            panelFill.TabIndex = 4;
            // 
            // textBoxStatusName
            // 
            textBoxStatusName.Dock = DockStyle.Top;
            textBoxStatusName.Location = new Point(13, 28);
            textBoxStatusName.Name = "textBoxStatusName";
            textBoxStatusName.Size = new Size(358, 23);
            textBoxStatusName.TabIndex = 1;
            // 
            // labelTypeName
            // 
            labelTypeName.AutoSize = true;
            labelTypeName.Dock = DockStyle.Top;
            labelTypeName.Location = new Point(13, 13);
            labelTypeName.Margin = new Padding(5, 0, 5, 0);
            labelTypeName.Name = "labelTypeName";
            labelTypeName.Size = new Size(76, 15);
            labelTypeName.TabIndex = 0;
            labelTypeName.Text = "Жанр аниме";
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.AutoSize = true;
            flowLayoutPanelBottom.Controls.Add(btnSaveChanges);
            flowLayoutPanelBottom.Controls.Add(btnCancel);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            flowLayoutPanelBottom.Location = new Point(0, 76);
            flowLayoutPanelBottom.Margin = new Padding(5);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(15);
            flowLayoutPanelBottom.Size = new Size(384, 75);
            flowLayoutPanelBottom.TabIndex = 5;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.AutoSize = true;
            btnSaveChanges.DialogResult = DialogResult.OK;
            btnSaveChanges.Location = new Point(20, 20);
            btnSaveChanges.Margin = new Padding(5);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(175, 35);
            btnSaveChanges.TabIndex = 0;
            btnSaveChanges.Text = "Сохранить";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(205, 20);
            btnCancel.Margin = new Padding(5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(148, 35);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormAddStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 151);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelBottom);
            Name = "FormAddStatus";
            Text = "FormAddStatus";
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            flowLayoutPanelBottom.ResumeLayout(false);
            flowLayoutPanelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelFill;
        protected internal TextBox textBoxStatusName;
        private Label labelTypeName;
        private FlowLayoutPanel flowLayoutPanelBottom;
        private Button btnSaveChanges;
        private Button btnCancel;
        private ErrorProvider errorProvider;
    }
}