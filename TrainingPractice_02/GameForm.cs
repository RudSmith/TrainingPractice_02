using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingPractice_02
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            Init();

        }

        // Метод инициализирует все ресурсы данного класса, а также случайным образом располагает картинки
        private void Init()
        {
            m_buttons = new List<Button>();
            m_buttons.Add(Image1Show_Button);
            m_buttons.Add(Image2Show_Button);
            m_buttons.Add(Image3Show_Button);
            m_buttons.Add(Image4Show_Button);
            m_buttons.Add(Image5Show_Button);
            m_buttons.Add(Image6Show_Button);
            m_buttons.Add(Image7Show_Button);
            m_buttons.Add(Image8Show_Button);
            m_buttons.Add(Image9Show_Button);
            m_buttons.Add(Image10Show_Button);
            m_buttons.Add(Image11Show_Button);
            m_buttons.Add(Image12Show_Button);
            m_buttons.Add(Image13Show_Button);
            m_buttons.Add(Image14Show_Button);
            m_buttons.Add(Image15Show_Button);
            m_buttons.Add(Image16Show_Button);
            m_buttons.Add(Image17Show_Button);
            m_buttons.Add(Image18Show_Button);
            m_buttons.Add(Image19Show_Button);
            m_buttons.Add(Image20Show_Button);
            m_buttons.Add(Image21Show_Button);
            m_buttons.Add(Image22Show_Button);
            m_buttons.Add(Image23Show_Button);
            m_buttons.Add(Image24Show_Button);

            m_imageIds = new int[m_imagesCount] 
                       { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12 };

            for(int buttonIter = 0; buttonIter < m_imagesCount; ++buttonIter)
            {
                m_buttons[buttonIter].Tag = new int();
                m_buttons[buttonIter].Tag = buttonIter;
            }

            ShuffleImages();

            m_guessedPairsCount = 0;
            m_wrongGuessesCount = 0;

            RightGuessesLabel.Text = m_guessedPairsCount.ToString();
            WrongGuessesLabel.Text = m_wrongGuessesCount.ToString();

            GameDurationTimer.Enabled = true;
            GameDurationTimerLabel.Text = "00 : 00";
        }

        // Метод перемешивает индексы картинок случайным образом
        private void ShuffleImages()
        {
            Random random = new Random();
            for(int i = 0; i < m_imagesCount; ++i)
            {
                int swapIndex1 = random.Next(m_imagesCount);
                int swapIndex2 = random.Next(m_imagesCount);

                int temp = m_imageIds[swapIndex1];
                m_imageIds[swapIndex1] = m_imageIds[swapIndex2];
                m_imageIds[swapIndex2] = temp;
            }
        }

        // Метод загружает backgroundImage по индексу картинки из ресурсов проекта
        private void LoadImageToButton(Button btn, int imageId)
        {
            switch(imageId)
            {
                case 1:
                    btn.BackgroundImage = TrainingPractice_02.Properties.Resources.Camera;
                    break;
                case 2:
                    btn.BackgroundImage = TrainingPractice_02.Properties.Resources.Car;
                    break;
                case 3:
                    btn.BackgroundImage = TrainingPractice_02.Properties.Resources.Eye;
                    break;
                case 4:
                    btn.BackgroundImage = TrainingPractice_02.Properties.Resources.Fist;
                    break;
                case 5:
                    btn.BackgroundImage = TrainingPractice_02.Properties.Resources.Hand;
                    break;
                case 6:
                    btn.BackgroundImage = TrainingPractice_02.Properties.Resources.Home;
                    break;
                case 7:
                    btn.BackgroundImage = TrainingPractice_02.Properties.Resources.Ninja;
                    break;
                case 8:
                    btn.BackgroundImage = TrainingPractice_02.Properties.Resources.Pentagram;
                    break;
                case 9:
                    btn.BackgroundImage = TrainingPractice_02.Properties.Resources.Plane;
                    break;
                case 10:
                    btn.BackgroundImage = TrainingPractice_02.Properties.Resources.Portfolio;
                    break;
                case 11:
                    btn.BackgroundImage = TrainingPractice_02.Properties.Resources.ShopCart;
                    break;
                case 12:
                    btn.BackgroundImage = TrainingPractice_02.Properties.Resources.StarWars;
                    break;
            }
        }

        // Метод начинает игру сначала
        private void Retry_Button_Click(object sender, EventArgs e)
        {
            GameForm newGame = new GameForm();
            Close();
            newGame.Show();
        }

        // Метод для выхода из игры
        private void ExitToMenu_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonClickHandle(Button btn)
        {
            LoadImageToButton(btn, m_imageIds[Convert.ToInt32(btn.Tag)]);
            btn.Update();

            if (!m_isOneButtonClicked)
            {
                m_currentPressedButtonsIds = new int[2] { 0, 0 };
                m_currentPressedButtonsIds[0] = Convert.ToInt32(btn.Tag);
                m_isOneButtonClicked = true;
            }
            else
            {
                Thread.Sleep(300);
                m_currentPressedButtonsIds[1] = Convert.ToInt32(btn.Tag);

                if (m_currentPressedButtonsIds[0] == m_currentPressedButtonsIds[1])
                    return;

                if (m_imageIds[m_currentPressedButtonsIds[0]] == m_imageIds[m_currentPressedButtonsIds[1]])
                {
                    m_buttons[m_currentPressedButtonsIds[0]].Visible = false;
                    m_buttons[m_currentPressedButtonsIds[1]].Visible = false;
                    ++m_guessedPairsCount;
                    RightGuessesLabel.Text = m_guessedPairsCount.ToString();

                    if (m_guessedPairsCount == 12)
                    {
                        GameDurationTimer.Enabled = false;
                        MessageBox.Show("Поздравляем, вы выиграли!");
                        LeaderBoardRecordForm leaderBoardRecordForm = new LeaderBoardRecordForm(m_gameDurationInSeconds);
                        leaderBoardRecordForm.Show();
                        Close();
                    }
                }
                else
                {
                    ++m_wrongGuessesCount;
                    WrongGuessesLabel.Text = m_wrongGuessesCount.ToString();
                }
                m_isOneButtonClicked = false;
                m_buttons[m_currentPressedButtonsIds[0]].BackgroundImage = null;
                m_buttons[m_currentPressedButtonsIds[1]].BackgroundImage = null;
            }
        }

        private void GameDurationTimer_Tick(object sender, EventArgs e)
        {
            ++m_gameDurationInSeconds;
            string minutes = (m_gameDurationInSeconds / 60).ToString();
            string seconds = (m_gameDurationInSeconds % 60).ToString();

            if (Convert.ToInt32(minutes) < 10)
                minutes = "0" + minutes;

            if (Convert.ToInt32(seconds) < 10)
                seconds = "0" + seconds;

            GameDurationTimerLabel.Text = minutes.ToString() + " : " + seconds.ToString();
        }

        private void Image1Show_Button_Click(object sender, EventArgs e)
        {
            ButtonClickHandle(Image1Show_Button);
        }

        private void Image2Show_Button_Click(object sender, EventArgs e)
        {
            ButtonClickHandle(Image2Show_Button);
        }

        private void Image3Show_Button_Click(object sender, EventArgs e)
        {
            ButtonClickHandle(Image3Show_Button);
        }

        private void Image4Show_Button_Click(object sender, EventArgs e)
        {
            ButtonClickHandle(Image4Show_Button);
        }

        private void Image5Show_Button_Click(object sender, EventArgs e)
        {
            ButtonClickHandle(Image5Show_Button);
        }

        private void Image6Show_Button_Click(object sender, EventArgs e)
        {
            ButtonClickHandle(Image6Show_Button);
        }

        private void Image7Show_Button_Click(object sender, EventArgs e)
        {
            ButtonClickHandle(Image7Show_Button);
        }

        private void Image8Show_Button_Click(object sender, EventArgs e)
        {
            ButtonClickHandle(Image8Show_Button);
        }

        private void Image9Show_Button_Click(object sender, EventArgs e)
        {
            ButtonClickHandle(Image9Show_Button);
        }

        private void Image10Show_Button_Click(object sender, EventArgs e)
        {
            ButtonClickHandle(Image10Show_Button);
        }

        private void Image11Show_Button_Click(object sender, EventArgs e)
        {
            ButtonClickHandle(Image11Show_Button);
        }

        private void Image12Show_Button_Click(object sender, EventArgs e)
        {
            ButtonClickHandle(Image12Show_Button);
        }

        private void Image13Show_Button_Click(object sender, EventArgs e)
        {
            ButtonClickHandle(Image13Show_Button);
        }

        private void Image14Show_Button_Click(object sender, EventArgs e)
        {
            ButtonClickHandle(Image14Show_Button);
        }

        private void Image15Show_Button_Click(object sender, EventArgs e)
        {
            ButtonClickHandle(Image15Show_Button);
        }

        private void Image16Show_Button_Click(object sender, EventArgs e)
        {
            ButtonClickHandle(Image16Show_Button);
        }

        private void Image17Show_Button_Click(object sender, EventArgs e)
        {
            ButtonClickHandle(Image17Show_Button);
        }

        private void Image18Show_Button_Click(object sender, EventArgs e)
        {
            ButtonClickHandle(Image18Show_Button);
        }

        private void Image19Show_Button_Click(object sender, EventArgs e)
        {
            ButtonClickHandle(Image19Show_Button);
        }

        private void Image20Show_Button_Click(object sender, EventArgs e)
        {
            ButtonClickHandle(Image20Show_Button);
        }

        private void Image21Show_Button_Click(object sender, EventArgs e)
        {
            ButtonClickHandle(Image21Show_Button);
        }

        private void Image22Show_Button_Click(object sender, EventArgs e)
        {
            ButtonClickHandle(Image22Show_Button);
        }

        private void Image23Show_Button_Click(object sender, EventArgs e)
        {
            ButtonClickHandle(Image23Show_Button);
        }

        private void Image24Show_Button_Click(object sender, EventArgs e)
        {
            ButtonClickHandle(Image24Show_Button);
        }


        private const int m_imagesCount = 24;
        private int[] m_imageIds;

        private List<Button> m_buttons;
        private bool m_isOneButtonClicked;
        private int[] m_currentPressedButtonsIds;

        private uint m_guessedPairsCount;
        private uint m_wrongGuessesCount;

        private uint m_gameDurationInSeconds;

    }
}
