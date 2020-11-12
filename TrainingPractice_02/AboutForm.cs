using System;
using System.Windows.Forms;

namespace TrainingPractice_02
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        // Нажатие на кнопку "в меню" закрывает форму
        private void AboutForm_Exit_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
