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
    public partial class LeaderBoardRecordForm : Form
    {
        public LeaderBoardRecordForm(uint gameDurationTime)
        {
            InitializeComponent();
            m_gameDurationTime = gameDurationTime;
        }

        private void MakeRecordingToLeaderBoardTable_Button_Click(object sender, EventArgs e)
        {
            if (NameInput_TextBox.Text.Length != 0)
            {
                string minutes = (m_gameDurationTime / 60).ToString();
                string seconds = (m_gameDurationTime % 60).ToString();

                if (Convert.ToInt32(minutes) < 10)
                    minutes = "0" + minutes;
                if (Convert.ToInt32(seconds) < 10)
                    seconds = "0" + seconds;

                string path = "leaderboard.txt";

                File.AppendAllText(path, NameInput_TextBox.Text + " - " + minutes + " : " + seconds + '\n');

                Close();
            }
            else
            {
                MessageBox.Show("Вы не ввели имя!");
            }
        }

        private uint m_gameDurationTime;
    }
}
