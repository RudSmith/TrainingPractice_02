using System;
using System.IO;
using System.Windows.Forms;

namespace TrainingPractice_02
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        // Нажатие на кнопку начала игры создаёт форму с игрой и показывает её
        private void StartGame_Button_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.Show();
        }

        // Нажатие на кнопку "о игре" создаёт форму с информацией о игре и показывает её
        private void AboutGame_Button_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        // Нажатие на кнопку показа истории игр
        private void LeaderBoardShow_Button_Click(object sender, EventArgs e)
        {
            // Записываем путь к файлу с результатами игр
            const string path = "leaderboard.txt";
            // Считываем в строку все данные из этого файла
            if (File.Exists(path))
            {
                string leaderBoard = File.ReadAllText(path);

                // Если файл существует, но пуст, выводим об этом сообщение
                if(leaderBoard.Length == 0)
                    MessageBox.Show("История пуста.");
                else
                    // Иначе, выводим историю игр
                    MessageBox.Show(leaderBoard, "История игр");
            }
            // Если файла не существует, также выводим сообщение
            else
            {
                MessageBox.Show("История пуста.");
            }
        }

        // Нажатие на кнопку выхода закрывает меню
        private void ExitGame_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
