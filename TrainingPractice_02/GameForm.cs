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
            Init();
            
            for(int i = 0; i < m_imagesCount; ++i)
            {
                LoadImageToButton(m_buttons[i], m_imageIds[i]);
            }
        }

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
                       { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12};

        }

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

        // Метод загружает backgroundImage по айди картинки из ресурсов проекта
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

        private void CheckButtons()
        {

        }

        const int m_imagesCount = 24;
        List<Button> m_buttons;
        int[] m_imageIds;
    }
}
