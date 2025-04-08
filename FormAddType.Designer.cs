namespace AppTitlesAnime
{
    partial class FormAddType
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
            flowLayoutPanelBottom = new FlowLayoutPanel();
            btnSaveChanges = new Button();
            bnCancel = new Button();
            panelFill = new Panel();
            textBoxTypeName = new TextBox();
            labelTypeName = new Label();
            flowLayoutPanelBottom.SuspendLayout();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.Controls.Add(btnSaveChanges);
            flowLayoutPanelBottom.Controls.Add(bnCancel);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.Location = new Point(0, 315);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Size = new Size(708, 100);
            flowLayoutPanelBottom.TabIndex = 1;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.AutoSize = true;
            btnSaveChanges.Location = new Point(3, 3);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(115, 35);
            btnSaveChanges.TabIndex = 0;
            btnSaveChanges.Text = "Сохранить";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // bnCancel
            // 
            bnCancel.AutoSize = true;
            bnCancel.Location = new Point(124, 3);
            bnCancel.Name = "bnCancel";
            bnCancel.Size = new Size(107, 35);
            bnCancel.TabIndex = 1;
            bnCancel.Text = "Отменить";
            bnCancel.UseVisualStyleBackColor = true;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(textBoxTypeName);
            panelFill.Controls.Add(labelTypeName);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(708, 315);
            panelFill.TabIndex = 2;
            // 
            // textBoxTypeName
            // 
            textBoxTypeName.Dock = DockStyle.Top;
            textBoxTypeName.Location = new Point(10, 35);
            textBoxTypeName.Name = "textBoxTypeName";
            textBoxTypeName.Size = new Size(688, 33);
            textBoxTypeName.TabIndex = 1;
            // 
            // labelTypeName
            // 
            labelTypeName.AutoSize = true;
            labelTypeName.Dock = DockStyle.Top;
            labelTypeName.Location = new Point(10, 10);
            labelTypeName.Name = "labelTypeName";
            labelTypeName.Size = new Size(104, 25);
            labelTypeName.TabIndex = 0;
            labelTypeName.Text = "Тип аниме";
            // 
            // FormAddType
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 415);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelBottom);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormAddType";
            Text = "Информация о типе аниме";
            flowLayoutPanelBottom.ResumeLayout(false);
            flowLayoutPanelBottom.PerformLayout();
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanelBottom;
        private Panel panelFill;
        private Button btnSaveChanges;
        private Button bnCancel;
        private TextBox textBoxTypeName;
        private Label labelTypeName;
    }
}