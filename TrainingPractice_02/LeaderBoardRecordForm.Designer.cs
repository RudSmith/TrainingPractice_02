namespace TrainingPractice_02
{
    partial class LeaderBoardRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaderBoardRecordForm));
            this.NameInput_TextBox = new System.Windows.Forms.TextBox();
            this.AskForName_Label = new System.Windows.Forms.Label();
            this.MakeRecordingToLeaderBoardTable_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameInput_TextBox
            // 
            this.NameInput_TextBox.Location = new System.Drawing.Point(158, 31);
            this.NameInput_TextBox.Name = "NameInput_TextBox";
            this.NameInput_TextBox.Size = new System.Drawing.Size(179, 22);
            this.NameInput_TextBox.TabIndex = 0;
            // 
            // AskForName_Label
            // 
            this.AskForName_Label.AutoSize = true;
            this.AskForName_Label.Location = new System.Drawing.Point(12, 34);
            this.AskForName_Label.Name = "AskForName_Label";
            this.AskForName_Label.Size = new System.Drawing.Size(130, 17);
            this.AskForName_Label.TabIndex = 1;
            this.AskForName_Label.Text = "Введите своё имя:";
            // 
            // MakeRecordingToLeaderBoardTable_Button
            // 
            this.MakeRecordingToLeaderBoardTable_Button.Location = new System.Drawing.Point(124, 92);
            this.MakeRecordingToLeaderBoardTable_Button.Name = "MakeRecordingToLeaderBoardTable_Button";
            this.MakeRecordingToLeaderBoardTable_Button.Size = new System.Drawing.Size(132, 52);
            this.MakeRecordingToLeaderBoardTable_Button.TabIndex = 2;
            this.MakeRecordingToLeaderBoardTable_Button.Text = "Готово";
            this.MakeRecordingToLeaderBoardTable_Button.UseVisualStyleBackColor = true;
            this.MakeRecordingToLeaderBoardTable_Button.Click += new System.EventHandler(this.MakeRecordingToLeaderBoardTable_Button_Click);
            // 
            // LeaderBoardRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 161);
            this.Controls.Add(this.MakeRecordingToLeaderBoardTable_Button);
            this.Controls.Add(this.AskForName_Label);
            this.Controls.Add(this.NameInput_TextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LeaderBoardRecordForm";
            this.Text = "Новая запись в таблице лидеров";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameInput_TextBox;
        private System.Windows.Forms.Label AskForName_Label;
        private System.Windows.Forms.Button MakeRecordingToLeaderBoardTable_Button;
    }
}