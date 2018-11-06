using System;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace minesweeper
{
    public sealed partial class MainPage : Page
    {
        private string mineNumb="Mines left: 10";
        public static DispatcherTimer Timer= new DispatcherTimer();
        public static int countdown=0;
        public static bool RoundEnded = false;
        public Button[] arrayOfButtons = new Button[81];

        public MainPage()
        {
            InitializeComponent();
            MinePlacement();
            AddHandlers();

            Timer.Tick += Timer_Tick1;
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
        }

        public void MinePlacement()
        {
            int[] randomNumbers;
            randomNumbers = new int[10];
            int j = 0;
            bool duplicate = false;
          
            while (j < 10)
            {
                int mine = GenerateRandomNumber();
                for (int k = 0; k < j; k++)
                    if (mine == randomNumbers[k])
                        duplicate = true;
                    else duplicate = false;

                if (!duplicate)
                {
                    randomNumbers[j] = mine;
                    j++;
                }
            }

            arrayOfButtons[0] = button00;
            arrayOfButtons[1] = button01;
            arrayOfButtons[2] = button02;
            arrayOfButtons[3] = button03;
            arrayOfButtons[4] = button04;
            arrayOfButtons[5] = button05;
            arrayOfButtons[6] = button06;
            arrayOfButtons[7] = button07;
            arrayOfButtons[8] = button08;
            arrayOfButtons[9] = button09;
            arrayOfButtons[10] = button10;
            arrayOfButtons[11] = button11;
            arrayOfButtons[12] = button12;
            arrayOfButtons[13] = button13;
            arrayOfButtons[14] = button14;
            arrayOfButtons[15] = button15;
            arrayOfButtons[16] = button16;
            arrayOfButtons[17] = button17;
            arrayOfButtons[18] = button18;
            arrayOfButtons[19] = button19;
            arrayOfButtons[20] = button20;
            arrayOfButtons[21] = button21;
            arrayOfButtons[22] = button22;
            arrayOfButtons[23] = button23;
            arrayOfButtons[24] = button24;
            arrayOfButtons[25] = button25;
            arrayOfButtons[26] = button26;
            arrayOfButtons[27] = button27;
            arrayOfButtons[28] = button28;
            arrayOfButtons[29] = button29;
            arrayOfButtons[30] = button30;
            arrayOfButtons[31] = button31;
            arrayOfButtons[32] = button32;
            arrayOfButtons[33] = button33;
            arrayOfButtons[34] = button34;
            arrayOfButtons[35] = button35;
            arrayOfButtons[36] = button36;
            arrayOfButtons[37] = button37;
            arrayOfButtons[38] = button38;
            arrayOfButtons[39] = button39;
            arrayOfButtons[40] = button40;
            arrayOfButtons[41] = button41;
            arrayOfButtons[42] = button42;
            arrayOfButtons[43] = button43;
            arrayOfButtons[44] = button44;
            arrayOfButtons[45] = button45;
            arrayOfButtons[46] = button46;
            arrayOfButtons[47] = button47;
            arrayOfButtons[48] = button48;
            arrayOfButtons[49] = button49;
            arrayOfButtons[50] = button50;
            arrayOfButtons[51] = button51;
            arrayOfButtons[52] = button52;
            arrayOfButtons[53] = button53;
            arrayOfButtons[54] = button54;
            arrayOfButtons[55] = button55;
            arrayOfButtons[56] = button56;
            arrayOfButtons[57] = button57;
            arrayOfButtons[58] = button58;
            arrayOfButtons[59] = button59;
            arrayOfButtons[60] = button60;
            arrayOfButtons[61] = button61;
            arrayOfButtons[62] = button62;
            arrayOfButtons[63] = button63;
            arrayOfButtons[64] = button64;
            arrayOfButtons[65] = button65;
            arrayOfButtons[66] = button66;
            arrayOfButtons[67] = button67;
            arrayOfButtons[68] = button68;
            arrayOfButtons[69] = button69;
            arrayOfButtons[70] = button70;
            arrayOfButtons[71] = button71;
            arrayOfButtons[72] = button72;
            arrayOfButtons[73] = button73;
            arrayOfButtons[74] = button74;
            arrayOfButtons[75] = button75;
            arrayOfButtons[76] = button76;
            arrayOfButtons[77] = button77;
            arrayOfButtons[78] = button78;
            arrayOfButtons[79] = button79;
            arrayOfButtons[80] = button80;

            for (int i = 0; i < 10; i++)
            {
                string mineNumber = randomNumbers[i].ToString();
                int buttonNumber = randomNumbers[i];
                arrayOfButtons[buttonNumber].Content = "X";
            }

            for(int i=0; i<arrayOfButtons.Length; i++)
            {
                arrayOfButtons[i].FontSize = 0.1;
            }

            for (int i = 0; i < 81; i++)
            {
                if ((string)arrayOfButtons[i].Content != "X")
                {
                    int adjecentMines = 0;
                    if (i == 0)
                    {
                        if ((string)arrayOfButtons[1].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[9].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[10].Content == "X")
                            adjecentMines++;
                        string adjMines = adjecentMines.ToString();
                        arrayOfButtons[i].Content = adjMines;
                    }
                    else if (i == 8)
                    {
                        if ((string)arrayOfButtons[7].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[16].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[17].Content == "X")
                            adjecentMines++;
                        string adjMines = adjecentMines.ToString();
                        arrayOfButtons[i].Content = adjMines;
                    }
                    else if (i == 72)
                    {
                        if ((string)arrayOfButtons[63].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[64].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[73].Content == "X")
                            adjecentMines++;
                        string adjMines = adjecentMines.ToString();
                        arrayOfButtons[i].Content = adjMines;
                    }
                    else if (i == 80)
                    {
                        if ((string)arrayOfButtons[70].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[71].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[79].Content == "X")
                            adjecentMines++;
                        string adjMines = adjecentMines.ToString();
                        arrayOfButtons[i].Content = adjMines;
                    }
                    else if (i > 0 && i < 8)
                    {
                        if ((string)arrayOfButtons[i - 1].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[i + 1].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[i + 8].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[i + 9].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[i + 10].Content == "X")
                            adjecentMines++;
                        string adjMines = adjecentMines.ToString();
                        arrayOfButtons[i].Content = adjMines;
                    }
                    else if (i > 72 && i < 80)
                    {
                        if ((string)arrayOfButtons[i - 1].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[i + 1].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[i - 8].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[i - 9].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[i - 10].Content == "X")
                            adjecentMines++;
                        string adjMines = adjecentMines.ToString();
                        arrayOfButtons[i].Content = adjMines;
                    }
                    else if (i == 9 || i == 18 || i == 27 || i == 36 || i == 45 || i == 54 || i == 63)
                    {

                        if ((string)arrayOfButtons[i + 1].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[i - 8].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[i - 9].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[i + 9].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[i + 10].Content == "X")
                            adjecentMines++;
                        string adjMines = adjecentMines.ToString();
                        arrayOfButtons[i].Content = adjMines;

                    }
                    else if (i == 17 || i == 26 || i == 35 || i == 44 || i == 53 || i == 62 || i == 71)
                    {

                        if ((string)arrayOfButtons[i - 1].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[i - 9].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[i - 10].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[i + 8].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[i + 9].Content == "X")
                            adjecentMines++;
                        string adjMines = adjecentMines.ToString();
                        arrayOfButtons[i].Content = adjMines;

                    }
                    else if ((i > 9 && i < 17) || (i > 18 && i < 26) || (i > 27 && i < 35) || (i > 36 && i < 44) || (i > 45 && i < 53) || (i > 54 && i < 62) || (i > 63 && i < 71))
                    {
                        if ((string)arrayOfButtons[i - 1].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[i + 1].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[i + 8].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[i + 9].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[i + 10].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[i - 8].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[i - 9].Content == "X")
                            adjecentMines++;
                        if ((string)arrayOfButtons[i - 10].Content == "X")
                            adjecentMines++;
                        string adjMines = adjecentMines.ToString();
                        arrayOfButtons[i].Content = adjMines;
                    }
                }
            }
        }

        public void AddHandlers()
        {
            for (int i = 0; i < arrayOfButtons.Length; i++)
            {
                arrayOfButtons[i].Click += new RoutedEventHandler(Button_Click);
                arrayOfButtons[i].RightTapped += new RightTappedEventHandler(Right_Button_Click);
                arrayOfButtons[i].Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
            }
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            b.FontSize = 20;
            b.IsEnabled = false;
            winCondition();
            mineText();
            if ((string)b.Content == "0")
                openFields(b);
            else if ((string)b.Content == "X")
            {
                b.IsEnabled = true;
                b.FontSize = 20;
                Timer.Stop();
                b.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                var dialog = new MessageDialog("Game over! Are you ready for a new game?");
                dialog.Commands.Add(new UICommand { Label = "Ok", Id = 0 });
                dialog.Commands.Add(new UICommand { Label = "Cancel", Id = 1 });

                var res = await dialog.ShowAsync();

                if ((int)res.Id == 0)
                {
                    ClearFields();
                    MinePlacement();
                    mineText();
                    countdown = 0;
                    Timer.Start();
                }
                else if ((int)res.Id == 1)
                    showAll();
            }
        }
        private void Right_Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if (b.FontSize == 1)
            {
                b.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
                b.FontSize = 0.1;
            }             
            else
            {
                b.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                b.FontSize = 1;
            }
            mineText();
        }
      
        public void openFields(Button b)
        {
            var i = 0;
            for (int j = 0; j < arrayOfButtons.Length; j++)
            {
                if (b == arrayOfButtons[j])
                    i = j;
            }
            b.Content = "";
            if (i == 0)
            {
                arrayOfButtons[1].FontSize = 20;
                arrayOfButtons[9].FontSize = 20;
                arrayOfButtons[10].FontSize = 20;
                arrayOfButtons[1].IsEnabled = false;
                arrayOfButtons[9].IsEnabled = false;
                arrayOfButtons[10].IsEnabled = false;
                if ((string)arrayOfButtons[1].Content == "0")
                    openFields(arrayOfButtons[1]);
                if ((string)arrayOfButtons[9].Content == "0")
                    openFields(arrayOfButtons[9]);
                if ((string)arrayOfButtons[10].Content == "0")
                    openFields(arrayOfButtons[10]);
            }
            else if (i == 8)
            {
                arrayOfButtons[7].FontSize = 20;
                arrayOfButtons[16].FontSize = 20;
                arrayOfButtons[17].FontSize = 20;
                arrayOfButtons[7].IsEnabled = false;
                arrayOfButtons[16].IsEnabled = false;
                arrayOfButtons[17].IsEnabled = false;
                if ((string)arrayOfButtons[7].Content == "0")
                    openFields(arrayOfButtons[7]);
                if ((string)arrayOfButtons[16].Content == "0")
                    openFields(arrayOfButtons[16]);
                if ((string)arrayOfButtons[17].Content == "0")
                    openFields(arrayOfButtons[17]);
            }
            else if (i == 72)
            {
                arrayOfButtons[63].FontSize = 20;
                arrayOfButtons[64].FontSize = 20;
                arrayOfButtons[73].FontSize = 20;
                arrayOfButtons[63].IsEnabled = false;
                arrayOfButtons[64].IsEnabled = false;
                arrayOfButtons[73].IsEnabled = false;
                if ((string)arrayOfButtons[63].Content == "0")
                    openFields(arrayOfButtons[63]);
                if ((string)arrayOfButtons[64].Content == "0")
                    openFields(arrayOfButtons[64]);
                if ((string)arrayOfButtons[73].Content == "0")
                    openFields(arrayOfButtons[73]);
            }
            else if (i == 80)
            {
                arrayOfButtons[70].FontSize = 10;
                arrayOfButtons[71].FontSize = 10;
                arrayOfButtons[79].FontSize = 10;
                arrayOfButtons[70].IsEnabled = false;
                arrayOfButtons[71].IsEnabled = false;
                arrayOfButtons[79].IsEnabled = false;
                if ((string)arrayOfButtons[70].Content == "0")
                    openFields(arrayOfButtons[70]);
                if ((string)arrayOfButtons[71].Content == "0")
                    openFields(arrayOfButtons[71]);
                if ((string)arrayOfButtons[79].Content == "0")
                    openFields(arrayOfButtons[79]);
            }
            else if (i > 0 && i < 8)
            {
                arrayOfButtons[i - 1].FontSize = 20;
                arrayOfButtons[i + 1].FontSize = 20;
                arrayOfButtons[i + 8].FontSize = 20;
                arrayOfButtons[i + 9].FontSize = 20;
                arrayOfButtons[i + 10].FontSize = 20;
                arrayOfButtons[i - 1].IsEnabled = false;
                arrayOfButtons[i + 1].IsEnabled = false;
                arrayOfButtons[i + 8].IsEnabled = false;
                arrayOfButtons[i + 9].IsEnabled = false;
                arrayOfButtons[i + 10].IsEnabled = false;
                if ((string)arrayOfButtons[i - 1].Content == "0")
                    openFields(arrayOfButtons[i - 1]);
                if ((string)arrayOfButtons[i + 1].Content == "0")
                    openFields(arrayOfButtons[i + 1]);
                if ((string)arrayOfButtons[i + 8].Content == "0")
                    openFields(arrayOfButtons[i + 8]);
                if ((string)arrayOfButtons[i + 9].Content == "0")
                    openFields(arrayOfButtons[i + 9]);
                if ((string)arrayOfButtons[i + 10].Content == "0")
                    openFields(arrayOfButtons[i + 10]);

            }
            else if (i > 72 && i < 80)
            {
                arrayOfButtons[i - 1].FontSize = 20;
                arrayOfButtons[i + 1].FontSize = 20;
                arrayOfButtons[i - 8].FontSize = 20;
                arrayOfButtons[i - 9].FontSize = 20;
                arrayOfButtons[i - 10].FontSize = 20;
                arrayOfButtons[i - 1].IsEnabled = false;
                arrayOfButtons[i + 1].IsEnabled = false;
                arrayOfButtons[i - 8].IsEnabled = false;
                arrayOfButtons[i - 9].IsEnabled = false;
                arrayOfButtons[i - 10].IsEnabled = false;
                if ((string)arrayOfButtons[i - 1].Content == "0")
                    openFields(arrayOfButtons[i - 1]);
                if ((string)arrayOfButtons[i + 1].Content == "0")
                    openFields(arrayOfButtons[i + 1]);
                if ((string)arrayOfButtons[i - 8].Content == "0")
                    openFields(arrayOfButtons[i - 8]);
                if ((string)arrayOfButtons[i - 9].Content == "0")
                    openFields(arrayOfButtons[i - 9]);
                if ((string)arrayOfButtons[i - 10].Content == "0")
                    openFields(arrayOfButtons[i - 10]);
            }
            else if (i == 9 || i == 18 || i == 27 || i == 36 || i == 45 || i == 54 || i == 63)
            {
                arrayOfButtons[i - 9].FontSize = 20;
                arrayOfButtons[i - 8].FontSize = 20;
                arrayOfButtons[i + 1].FontSize = 20;
                arrayOfButtons[i + 9].FontSize = 20;
                arrayOfButtons[i + 10].FontSize = 20;
                arrayOfButtons[i - 9].IsEnabled = false;
                arrayOfButtons[i - 8].IsEnabled = false;
                arrayOfButtons[i + 1].IsEnabled = false;
                arrayOfButtons[i + 9].IsEnabled = false;
                arrayOfButtons[i + 10].IsEnabled = false;
                if ((string)arrayOfButtons[i - 9].Content == "0")
                    openFields(arrayOfButtons[i - 9]);
                if ((string)arrayOfButtons[i - 8].Content == "0")
                    openFields(arrayOfButtons[i - 8]);
                if ((string)arrayOfButtons[i + 1].Content == "0")
                    openFields(arrayOfButtons[i + 1]);
                if ((string)arrayOfButtons[i + 9].Content == "0")
                    openFields(arrayOfButtons[i + 9]);
                if ((string)arrayOfButtons[i + 10].Content == "0")
                    openFields(arrayOfButtons[i + 10]);
            }
            else if (i == 17 || i == 26 || i == 35 || i == 44 || i == 53 || i == 62 || i == 71)
            {
                arrayOfButtons[i - 10].FontSize = 20;
                arrayOfButtons[i - 9].FontSize = 20;
                arrayOfButtons[i - 1].FontSize = 20;
                arrayOfButtons[i + 8].FontSize = 20;
                arrayOfButtons[i + 9].FontSize = 20;
                arrayOfButtons[i - 10].IsEnabled = false;
                arrayOfButtons[i - 9].IsEnabled = false;
                arrayOfButtons[i - 1].IsEnabled = false;
                arrayOfButtons[i + 8].IsEnabled = false;
                arrayOfButtons[i + 9].IsEnabled = false;
                if ((string)arrayOfButtons[i - 1].Content == "0")
                    openFields(arrayOfButtons[i - 1]);
                if ((string)arrayOfButtons[i + 9].Content == "0")
                    openFields(arrayOfButtons[i + 9]);
                if ((string)arrayOfButtons[i + 8].Content == "0")
                    openFields(arrayOfButtons[i + 8]);
                if ((string)arrayOfButtons[i - 9].Content == "0")
                    openFields(arrayOfButtons[i - 9]);
                if ((string)arrayOfButtons[i - 10].Content == "0")
                    openFields(arrayOfButtons[i - 10]);

            }
            else if ((i > 9 && i < 17) || (i > 18 && i < 26) || (i > 27 && i < 35) || (i > 36 && i < 44) || (i > 45 && i < 53) || (i > 54 && i < 62) || (i > 63 && i < 71))
            {
                arrayOfButtons[i - 10].FontSize = 20;
                arrayOfButtons[i - 9].FontSize = 20;
                arrayOfButtons[i - 8].FontSize = 20;
                arrayOfButtons[i - 1].FontSize = 20;
                arrayOfButtons[i + 1].FontSize = 20;
                arrayOfButtons[i + 8].FontSize = 20;
                arrayOfButtons[i + 9].FontSize = 20;
                arrayOfButtons[i + 10].FontSize = 20;
                arrayOfButtons[i - 10].IsEnabled = false;
                arrayOfButtons[i - 9].IsEnabled = false;
                arrayOfButtons[i - 8].IsEnabled = false;
                arrayOfButtons[i - 1].IsEnabled = false;
                arrayOfButtons[i + 1].IsEnabled = false;
                arrayOfButtons[i + 8].IsEnabled = false;
                arrayOfButtons[i + 9].IsEnabled = false;
                arrayOfButtons[i + 10].IsEnabled = false;
                if ((string)arrayOfButtons[i - 1].Content == "0")
                    openFields(arrayOfButtons[i - 1]);
                if ((string)arrayOfButtons[i + 1].Content == "0")
                    openFields(arrayOfButtons[i + 1]);
                if ((string)arrayOfButtons[i - 8].Content == "0")
                    openFields(arrayOfButtons[i - 8]);
                if ((string)arrayOfButtons[i - 9].Content == "0")
                    openFields(arrayOfButtons[i - 9]);
                if ((string)arrayOfButtons[i - 10].Content == "0")
                    openFields(arrayOfButtons[i - 10]);
                if ((string)arrayOfButtons[i + 8].Content == "0")
                    openFields(arrayOfButtons[i + 8]);
                if ((string)arrayOfButtons[i + 9].Content == "0")
                    openFields(arrayOfButtons[i + 9]);
                if ((string)arrayOfButtons[i + 10].Content == "0")
                    openFields(arrayOfButtons[i + 10]);
            }
            mineText();
            winCondition();
        }

        public void ClearFields()
        {
            for (var i = 0; i < arrayOfButtons.Length; i++)
            {
                arrayOfButtons[i].Content = "";
                arrayOfButtons[i].IsEnabled = true;
                arrayOfButtons[i].FontSize = 10;
                arrayOfButtons[i].Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
            }
        }

        public int GenerateRandomNumber()
        {
            Random r = new Random();
            int rInt = r.Next(0, 80);
            return rInt;
        }

        public async void winCondition()
        {
            int count = 0;
            for (int i = 0; i < arrayOfButtons.Length; i++)
            {
                if (arrayOfButtons[i].IsEnabled == false)
                    count++;
            }

            if (count == 71)
            {
                showAll();
                var dialog = new MessageDialog("You won! Are you ready for a new game?");
                dialog.Commands.Add(new UICommand { Label = "Ok", Id = 0 });
                dialog.Commands.Add(new UICommand { Label = "Cancel", Id = 1 });
                var res = await dialog.ShowAsync();

                if ((int)res.Id == 0)
                {
                    ClearFields();
                    MinePlacement();
                    Timer.Start();
                }
            }
        }

        private void NewGame(object sender, RoutedEventArgs e)
        {
            ClearFields();
            MinePlacement();
            mineText();
            Timer.Start();
            countdown = 0;
        }

        public void mineText()
        {
            int count = 0;
            for (int i=0; i < arrayOfButtons.Length; i++)
            {
                if (arrayOfButtons[i].FontSize==1 && arrayOfButtons[i].IsEnabled!= false)
                    count++;             
            }           
            mineNumb = "Mines left" + " " + (10-count);
            mineInfo.Text = mineNumb;
        }

        private void showAll()
        {
           for (int i = 0; i < arrayOfButtons.Length; i++)
            {
                arrayOfButtons[i].FontSize = 20;
                arrayOfButtons[i].IsEnabled = false;
            }
            Timer.Stop();       
        }

        private void Timer_Tick1(object sender, object e)
        {
            countdown += 1;
            timerInfo.Text = "Timer: " + countdown;
        }   
    }   
    }
