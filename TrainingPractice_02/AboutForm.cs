using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
