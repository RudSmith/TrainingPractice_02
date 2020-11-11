using System;
using System.Collections.Generic;
using System.Threading;
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
            InitButtonsList();
            InitButtonsTags();
            InitImageIds();
            InitLabelsWithGuessesCount();
            InitGameDurationTimer();
            ShuffleImages();
        }

        // Метод создаёт список из существующих на экране кнопок для удобной работы с ними
        private void InitButtonsList()
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
            
        }

        // Метод даёт каждой кнопке специальный тэг, чтобы каждый раз мы знали, с какой кнопкой работаем
        // Также, тэги кнопок будут помогать в индексации по массивам
        private void InitButtonsTags()
        {
            for (int buttonIter = 0; buttonIter < m_imagesCount; ++buttonIter)
            {
                m_buttons[buttonIter].Tag = new int();
                m_buttons[buttonIter].Tag = buttonIter;
            }
        }

        // Метод создаёт массив с номерами изображений (всего 12 пар)
        // Такой подход в будущем поможет нарастить производительность
        // То есть при выборе двух картинок для определения правильности ответа будут сравниваться не сами картинки попиксельно, а их идентификаторы
        private void InitImageIds()
        {
            m_imageIds = new int[m_imagesCount]
                       { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12 };
        }

        // Метод инициализирует лэйблы, которые отображают правильные и неправильные угадывания пользователя
        private void InitLabelsWithGuessesCount()
        {
            // В классе есть два приватных поля, которые отвечают за хранение ошибок и правильных ответов
            m_guessedPairsCount = 0;
            m_wrongGuessesCount = 0;

            RightGuessesLabel.Text = m_guessedPairsCount.ToString();
            WrongGuessesLabel.Text = m_wrongGuessesCount.ToString();
        }

        // Для подсчёта длительности игры понадобится таймер
        // Метод инициализирует этот таймер
        private void InitGameDurationTimer()
        {
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



        // Метод загружает backgroundImage кнопки по индексу картинки из ресурсов проекта
        private void LoadImageToButton(Button btn, int imageId)
        {
            // В качестве аргументов мы подаём кнопку и айди картинки, который в неё нужно загрузить
            // В следующем блоке switch-case по номеру определяется картинка, которая будет выставлена в backgroundImage кнопки
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
            this.Close();
            GameForm newGame = new GameForm();
            newGame.Show();
        }

        // Метод для выхода из игры
        private void ExitToMenu_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Метод назначен на каждую из существующих кнопок и нужен для отображения картинок и обработки правильности ответа пользователя
        private void CheckPlayersMove(Button btn)
        {
            // После нажатия на кнопку, загружаем картинку
            LoadImageToButton(btn, m_imageIds[Convert.ToInt32(btn.Tag)]);
            // Сразу же отрисовываем её
            btn.Update();

            // Если выбрана только первая картинка
            if (!m_isOneButtonClicked)
            {
                // Создаём массив, который будет хранить кнопки с картинками, открытые пользователем
                // Всего одновременно может быть открыто две кнопки с картинками
                m_currentPressedButtonsIds = new int[2] { 0, 0 };
                // Заносим в этот массив ранее созданный тэг для кнопки, которую нажал юзер
                m_currentPressedButtonsIds[0] = Convert.ToInt32(btn.Tag);
                // Приватное поле, которое следит за тем, открыта ли одна картинка из двух, помечаем значением true
                m_isOneButtonClicked = true;
            }
            // Если пользователь выбрал две картинки из двух
            else
            {
                // Ждём короткий промежуток времени, чтобы он успел увидеть открытую картинку
                Thread.Sleep(300);
                // Заносим номер кнопки, которую нажал пользователь
                m_currentPressedButtonsIds[1] = Convert.ToInt32(btn.Tag);

                // Если пользователь нажал на одну и ту же кнопку два раза, ничего не делаем, это не считается за правильный ответ
                if (m_currentPressedButtonsIds[0] == m_currentPressedButtonsIds[1])
                    return;

                // Если за кнопками записаны одинаковые идентификаторы картинок, пользователь правильно угадал пару
                // Напомню, что в массиве идентификаторов картинок идут попарно числа от 1 до 12 (1, 1, 2, 2, 3, 3.....)
                if (m_imageIds[m_currentPressedButtonsIds[0]] == m_imageIds[m_currentPressedButtonsIds[1]])
                {
                    // Отмечаем конец хода
                    m_isOneButtonClicked = false;

                    // Убираем с игрового поля угаданную пару
                    m_buttons[m_currentPressedButtonsIds[0]].Visible = false;
                    m_buttons[m_currentPressedButtonsIds[1]].Visible = false;

                    // Прибавляем пользователю один правильный ответ и отображаем это на экране в лэйбле
                    ++m_guessedPairsCount;
                    RightGuessesLabel.Text = m_guessedPairsCount.ToString();

                    // Проверяем, не угадал ли пользователь все пары картинок
                    if (m_guessedPairsCount == 12)
                    {
                        // Если угадал, отключаем таймер, выводим пользователю сообщение, что он выиграл, и заносим его игру в историю игр
                        GameDurationTimer.Enabled = false;
                        MessageBox.Show("Поздравляем, вы выиграли!");

                        // Здесь создаём форму, которая делает запись в таблицу с историей игр
                        LeaderBoardRecordForm leaderBoardRecordForm = new LeaderBoardRecordForm(m_gameDurationInSeconds);
                        leaderBoardRecordForm.ShowDialog();
                        Close();
                    }
                }
                // Если же пользователь неправильно угадал пару картинок 
                else
                {
                    // Инкрементируем приватное поле, считающее ошибки
                    ++m_wrongGuessesCount;
                    // Выводим его значение на экран
                    WrongGuessesLabel.Text = m_wrongGuessesCount.ToString();

                    // Отмечаем конец хода
                    m_isOneButtonClicked = false;

                    // Скрываем картинки, которые открыл пользователь, обращаясь к списку кнопок
                    m_buttons[m_currentPressedButtonsIds[0]].BackgroundImage = null;
                    m_buttons[m_currentPressedButtonsIds[1]].BackgroundImage = null;
                }
            }
        }

        // Метод обрабатывает тик таймера (он отрабатывает раз в секунду)
        private void GameDurationTimer_Tick(object sender, EventArgs e)
        {
            // Инкрементируем длительность игры
            ++m_gameDurationInSeconds;

            // Переводим секунды в мин : сек
            string minutes = (m_gameDurationInSeconds / 60).ToString();
            string seconds = (m_gameDurationInSeconds % 60).ToString();

            // Если значение минут или секунд меньше десяти, дописываем нолик вперёд
            if (Convert.ToInt32(minutes) < 10)
                minutes = "0" + minutes;

            if (Convert.ToInt32(seconds) < 10)
                seconds = "0" + seconds;

            // Выводим значение таймера на лэйбл
            GameDurationTimerLabel.Text = minutes.ToString() + " : " + seconds.ToString();

        }

        // Следующий метод обрабатывают нажатие каждой кнопки
        // Он преобразует тип object в тип Button и подаёт её в метод CheckPlayersMove, описанный ранее
        // Таким образом, пользователь делает ход
        private void ButtonClickEventHandler(object sender, EventArgs e)
        {
            CheckPlayersMove((Button)sender);
        }

        // Константа, обозначающая количество изображений
        private const int m_imagesCount = 24;
        // Массив с идентификаторами картинок
        private int[] m_imageIds;

        // Список кнопок для удобной работы с ними
        private List<Button> m_buttons;

        // Булева переменная, которая следит за тем, на какой стадии ход игрока: 
        // Он открыл одну картинку из двух (true), или же ни одной (false)
        private bool m_isOneButtonClicked;
        // Массив, хранящий номера нажатых кнопок на текущем ходу
        private int[] m_currentPressedButtonsIds;

        // Поле, хранящее количество угаданных пар
        private uint m_guessedPairsCount;
        // Поле, хранящее количество ошибок пользователя
        private uint m_wrongGuessesCount;

        // Длительность игры в секундах
        private uint m_gameDurationInSeconds;

    }
}
