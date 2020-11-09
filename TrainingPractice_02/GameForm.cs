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
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void Init()
        {

        }

        private void ShuffleImages()
        {

        }

        private void Retry_Button_Click(object sender, EventArgs e)
        {
            GameForm newGame = new GameForm();
            Close();
            newGame.Show();
        }

        private void ExitToMenu_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckButtonClick()
        {

        }
    }
}
