namespace TrainingPractice_02
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.StartGame_Button = new System.Windows.Forms.Button();
            this.AboutGame_Button = new System.Windows.Forms.Button();
            this.ExitGame_Button = new System.Windows.Forms.Button();
            this.LeaderBoardShow_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartGame_Button
            // 
            this.StartGame_Button.Location = new System.Drawing.Point(86, 62);
            this.StartGame_Button.Name = "StartGame_Button";
            this.StartGame_Button.Size = new System.Drawing.Size(168, 41);
            this.StartGame_Button.TabIndex = 0;
            this.StartGame_Button.Text = "Играть";
            this.StartGame_Button.UseVisualStyleBackColor = true;
            this.StartGame_Button.Click += new System.EventHandler(this.StartGame_Button_Click);
            // 
            // AboutGame_Button
            // 
            this.AboutGame_Button.Location = new System.Drawing.Point(86, 109);
            this.AboutGame_Button.Name = "AboutGame_Button";
            this.AboutGame_Button.Size = new System.Drawing.Size(168, 41);
            this.AboutGame_Button.TabIndex = 1;
            this.AboutGame_Button.Text = "О игре";
            this.AboutGame_Button.UseVisualStyleBackColor = true;
            this.AboutGame_Button.Click += new System.EventHandler(this.AboutGame_Button_Click);
            // 
            // ExitGame_Button
            // 
            this.ExitGame_Button.Location = new System.Drawing.Point(86, 203);
            this.ExitGame_Button.Name = "ExitGame_Button";
            this.ExitGame_Button.Size = new System.Drawing.Size(168, 41);
            this.ExitGame_Button.TabIndex = 2;
            this.ExitGame_Button.Text = "Выход";
            this.ExitGame_Button.UseVisualStyleBackColor = true;
            this.ExitGame_Button.Click += new System.EventHandler(this.ExitGame_Button_Click);
            // 
            // LeaderBoardShow_Button
            // 
            this.LeaderBoardShow_Button.Location = new System.Drawing.Point(86, 156);
            this.LeaderBoardShow_Button.Name = "LeaderBoardShow_Button";
            this.LeaderBoardShow_Button.Size = new System.Drawing.Size(168, 41);
            this.LeaderBoardShow_Button.TabIndex = 3;
            this.LeaderBoardShow_Button.Text = "История игр";
            this.LeaderBoardShow_Button.UseVisualStyleBackColor = true;
            this.LeaderBoardShow_Button.Click += new System.EventHandler(this.LeaderBoardShow_Button_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 290);
            this.Controls.Add(this.LeaderBoardShow_Button);
            this.Controls.Add(this.ExitGame_Button);
            this.Controls.Add(this.AboutGame_Button);
            this.Controls.Add(this.StartGame_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartGame_Button;
        private System.Windows.Forms.Button AboutGame_Button;
        private System.Windows.Forms.Button ExitGame_Button;
        private System.Windows.Forms.Button LeaderBoardShow_Button;
    }
}

