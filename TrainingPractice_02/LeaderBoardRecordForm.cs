using System;
using System.IO;
using System.Windows.Forms;

namespace TrainingPractice_02
{
    public partial class LeaderBoardRecordForm : Form
    {
        // Конструктор формы
        public LeaderBoardRecordForm(uint gameDurationTime)
        {
            InitializeComponent();
            // В качестве параметра мы подавали время продолжительности игры
            // Записываем его в приватное поле
            m_gameDurationTime = gameDurationTime;
        }

        // Метод делает запись в историю игр
        private void MakeRecordingToLeaderBoardTable_Button_Click(object sender, EventArgs e)
        {
            // Если пользователь ввёл имя
            if (NameInput_TextBox.Text.Length != 0)
            {
                // Генерируем строку с именем и временем (24 - 31 строка)
                string minutes = (m_gameDurationTime / 60).ToString();
                string seconds = (m_gameDurationTime % 60).ToString();

                if (Convert.ToInt32(minutes) < 10)
                    minutes = "0" + minutes;
                if (Convert.ToInt32(seconds) < 10)
                    seconds = "0" + seconds;

                string path = "leaderboard.txt";
                // Заносим сгенерированную строку в leaderboard.txt
                File.AppendAllText(path, NameInput_TextBox.Text + " - " + minutes + " : " + seconds + '\n');

                Close();
            }
            else
            {
                // Если пользователь не ввёл имя, сообщаем ему об этом
                MessageBox.Show("Вы не ввели имя!");
            }
        }
        // Метод для пропуска занесения в историю игр
        private void SkipRecordingToLeaderBoard_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        // Длительность игры в секундах
        private uint m_gameDurationTime;

    }
}
