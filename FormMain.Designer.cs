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
            btnShowGenres = new Button();
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
            btnShowTypes.Click += BtnShowTypes_Click;
            // 
            // btnShowGenres
            // 
            btnShowGenres.AutoSize = true;
            btnShowGenres.Location = new Point(32, 76);
            btnShowGenres.Name = "btnShowGenres";
            btnShowGenres.Size = new Size(338, 49);
            btnShowGenres.TabIndex = 1;
            btnShowGenres.Text = "Отобразить список \"Жанр Аниме\"";
            btnShowGenres.UseVisualStyleBackColor = true;
            btnShowGenres.Click += BtnShowGenres_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Location = new Point(32, 145);
            button2.Name = "button2";
            button2.Size = new Size(338, 49);
            button2.TabIndex = 2;
            button2.Text = "Отобразить список \"Статус Аниме\"";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ButtonShowStatus_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 213);
            Controls.Add(button2);
            Controls.Add(btnShowGenres);
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
        private Button btnShowGenres;
        private Button button2;
    }
}
