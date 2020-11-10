using System;
using System.IO;
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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void StartGame_Button_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.ShowDialog();
        }

        private void AboutGame_Button_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void ExitGame_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LeaderBoardShow_Button_Click(object sender, EventArgs e)
        {
            string path = "leaderboard.txt";
            string leaderBoard = File.ReadAllText(path);

            MessageBox.Show(leaderBoard, "Таблица попыток");
        }
    }
}
