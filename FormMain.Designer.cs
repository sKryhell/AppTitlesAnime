namespace AppTitlesAnime
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnShowTypes = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnShowTypes
            // 
            btnShowTypes.AutoSize = true;
            btnShowTypes.Location = new Point(32, 12);
            btnShowTypes.Name = "btnShowTypes";
            btnShowTypes.Size = new Size(338, 49);
            btnShowTypes.TabIndex = 0;
            btnShowTypes.Text = "Отобразить список \"Типы аниме\"";
            btnShowTypes.UseVisualStyleBackColor = true;
            btnShowTypes.Click += btnShowTypes_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(32, 81);
            button1.Name = "button1";
            button1.Size = new Size(338, 49);
            button1.TabIndex = 1;
            button1.Text = "Отобразить список \"Жанры\"";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Segoe UI", 14F);
            button2.Location = new Point(32, 148);
            button2.Name = "button2";
            button2.Size = new Size(338, 49);
            button2.TabIndex = 2;
            button2.Text = "Отобразить список \"Статусы аниме\"";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 213);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnShowTypes);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormMain";
            Text = "Главная форма";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowTypes;
        private Button button1;
        private Button button2;
    }
}
