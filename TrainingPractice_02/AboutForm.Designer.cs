namespace TrainingPractice_02
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.AboutForm_Exit_Button = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AboutForm_Exit_Button
            // 
            this.AboutForm_Exit_Button.Location = new System.Drawing.Point(220, 162);
            this.AboutForm_Exit_Button.Name = "AboutForm_Exit_Button";
            this.AboutForm_Exit_Button.Size = new System.Drawing.Size(112, 46);
            this.AboutForm_Exit_Button.TabIndex = 0;
            this.AboutForm_Exit_Button.Text = "Выход в меню";
            this.AboutForm_Exit_Button.UseVisualStyleBackColor = true;
            this.AboutForm_Exit_Button.Click += new System.EventHandler(this.AboutForm_Exit_Button_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.Location = new System.Drawing.Point(12, 33);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(525, 110);
            this.InfoLabel.TabIndex = 1;
            this.InfoLabel.Text = resources.GetString("InfoLabel.Text");
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 244);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.AboutForm_Exit_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.Text = "О игре";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AboutForm_Exit_Button;
        private System.Windows.Forms.Label InfoLabel;
    }
}