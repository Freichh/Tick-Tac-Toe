using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Tick_Tac_Toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBlock_winner.Text = ("Player 1's turn");
        }

        // start with player 1
        PlayTurn playTurn = PlayTurn.player1;

        // maak speelveld player 1 aan
        bool[,] playfield1 = new bool[3, 3];

        // maak speelveld player 2 aan
        bool[,] playfield2 = new bool[3, 3];

        // play state
        enum PlayTurn
        { player1, player2 }


        #region Buttons
        private void button_1_1_Click(object sender, RoutedEventArgs e)
        {
            switch (playTurn)
            {
                case PlayTurn.player1:
                    playfield1[0, 0] = true;
                    break;
                case PlayTurn.player2:
                    playfield2[0, 0] = true;
                    break;
                default:
                    break;
            }

            button_1_1.IsEnabled = false;
            Button b = ((Button)sender);
            ChooseAction(b);
            CheckWincon();
        }

        private void button_1_2_Click(object sender, RoutedEventArgs e)
        {
            switch (playTurn)
            {
                case PlayTurn.player1:
                    playfield1[0, 1] = true;
                    break;
                case PlayTurn.player2:
                    playfield2[0, 1] = true;
                    break;
                default:
                    break;
            }

            button_1_2.IsEnabled = false;
            Button b = ((Button)sender);
            ChooseAction(b);
            CheckWincon();
        }

        private void button_1_3_Click(object sender, RoutedEventArgs e)
        {
            switch (playTurn)
            {
                case PlayTurn.player1:
                    playfield1[0, 2] = true;
                    break;
                case PlayTurn.player2:
                    playfield2[0, 2] = true;
                    break;
                default:
                    break;
            }

            button_1_3.IsEnabled = false;
            Button b = ((Button)sender);
            ChooseAction(b);
            CheckWincon();
        }

        private void button_2_1_Click(object sender, RoutedEventArgs e)
        {
            switch (playTurn)
            {
                case PlayTurn.player1:
                    playfield1[1, 0] = true;
                    break;
                case PlayTurn.player2:
                    playfield2[1, 0] = true;
                    break;
                default:
                    break;
            }

            button_2_1.IsEnabled = false;
            Button b = ((Button)sender);
            ChooseAction(b);
            CheckWincon();
        }

        private void button_2_2_Click(object sender, RoutedEventArgs e)
        {
            switch (playTurn)
            {
                case PlayTurn.player1:
                    playfield1[1, 1] = true;
                    break;
                case PlayTurn.player2:
                    playfield2[1, 1] = true;
                    break;
                default:
                    break;
            }

            button_2_2.IsEnabled = false;
            Button b = ((Button)sender);
            ChooseAction(b);
            CheckWincon();
        }

        private void button_2_3_Click(object sender, RoutedEventArgs e)
        {
            switch (playTurn)
            {
                case PlayTurn.player1:
                    playfield1[1, 2] = true;
                    break;
                case PlayTurn.player2:
                    playfield2[1, 2] = true;
                    break;
                default:
                    break;
            }

            button_2_3.IsEnabled = false;
            Button b = ((Button)sender);
            ChooseAction(b);
            CheckWincon();
        }

        private void button_3_1_Click(object sender, RoutedEventArgs e)
        {
            switch (playTurn)
            {
                case PlayTurn.player1:
                    playfield1[2, 0] = true;
                    break;
                case PlayTurn.player2:
                    playfield2[2, 0] = true;
                    break;
                default:
                    break;
            }

            button_3_1.IsEnabled = false;
            Button b = ((Button)sender);
            ChooseAction(b);
            CheckWincon();
        }

        private void button_3_2_Click(object sender, RoutedEventArgs e)
        {
            switch (playTurn)
            {
                case PlayTurn.player1:
                    playfield1[2, 1] = true;
                    break;
                case PlayTurn.player2:
                    playfield2[2, 1] = true;
                    break;
                default:
                    break;
            }

            button_3_2.IsEnabled = false;
            Button b = ((Button)sender);
            ChooseAction(b);
            CheckWincon();
        }

        private void button_3_3_Click(object sender, RoutedEventArgs e)
        {
            switch (playTurn)
            {
                case PlayTurn.player1:
                    playfield1[2, 2] = true;
                    break;
                case PlayTurn.player2:
                    playfield2[2, 2] = true;
                    break;
                default:
                    break;
            }

            button_3_3.IsEnabled = false;
            Button b = ((Button)sender);
            ChooseAction(b);
            CheckWincon();
        }
        #endregion


        private void ChooseAction(Button b)
        {
            Random rand = new Random();
            int num = rand.Next(1, 4);

            switch (playTurn)
            {
                case PlayTurn.player1:
                    b.Content = FindResource("Round"+num);
                    playTurn = PlayTurn.player2;
                    textBlock_winner.Text = ("Player 2's turn");
                    break;
                case PlayTurn.player2:
                    b.Content = FindResource("Cross"+num);
                    playTurn = PlayTurn.player1;
                    textBlock_winner.Text = ("Player 1's turn");
                    break;
                default:
                    break;
            }
        }

        private void CheckWincon()
        {
            // wincon #1 - player 1
            if (playfield1[0, 0] && playfield1[0, 1] && playfield1[0, 2])
                Player1Wins();
            if (playfield1[1, 0] && playfield1[1, 1] && playfield1[1, 2])
                Player1Wins();
            if (playfield1[2, 0] && playfield1[2, 1] && playfield1[2, 2])
                Player1Wins();
            if (playfield1[0, 0] && playfield1[1, 0] && playfield1[2, 0])
                Player1Wins();
            if (playfield1[0, 1] && playfield1[1, 1] && playfield1[2, 1])
                Player1Wins();
            if (playfield1[0, 2] && playfield1[1, 2] && playfield1[2, 2])
                Player1Wins();
            if (playfield1[0, 0] && playfield1[1, 1] && playfield1[2, 2])
                Player1Wins();
            if (playfield1[2, 0] && playfield1[1, 1] && playfield1[0, 2])
                Player1Wins();

            // wincon #1 - player 2
            if (playfield2[0, 0] && playfield2[0, 1] && playfield2[0, 2])
                Player2Wins();
            if (playfield2[1, 0] && playfield2[1, 1] && playfield2[1, 2])
                Player2Wins();
            if (playfield2[2, 0] && playfield2[2, 1] && playfield2[2, 2])
                Player2Wins();
            if (playfield2[0, 0] && playfield2[1, 0] && playfield2[2, 0])
                Player2Wins();
            if (playfield2[0, 1] && playfield2[1, 1] && playfield2[2, 1])
                Player2Wins();
            if (playfield2[0, 2] && playfield2[1, 2] && playfield2[2, 2])
                Player2Wins();
            if (playfield2[0, 0] && playfield2[1, 1] && playfield2[2, 2])
                Player2Wins();
            if (playfield2[2, 0] && playfield2[1, 1] && playfield2[0, 2])
                Player2Wins();
        }

        private void Player1Wins()
        {
            textBlock_winner.Text = ("Player 1 wins!");
            textBlock_winner.Foreground = Brushes.LightGreen;
            innerGrid.IsEnabled = false;
        }

        private void Player2Wins()
        {
            textBlock_winner.Text = ("Player 2 wins!");
            textBlock_winner.Foreground = Brushes.LightGreen;
            innerGrid.IsEnabled = false;
        }

        private void button_reset_Click(object sender, RoutedEventArgs e)
        {
            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    playfield1[a, b] = false;
                    playfield2[a, b] = false;
                }
            }

            playTurn = PlayTurn.player1;

            textBlock_winner.Text = ("Player 1's turn");
            textBlock_winner.Foreground = Brushes.Black;
            
            innerGrid.IsEnabled = true;
            
            button_1_1.IsEnabled = true;
            button_1_1.Content = null;
            button_1_2.IsEnabled = true;
            button_1_2.Content = null;
            button_1_3.IsEnabled = true;
            button_1_3.Content = null;
            button_2_1.IsEnabled = true;
            button_2_1.Content = null;
            button_2_2.IsEnabled = true;
            button_2_2.Content = null;
            button_2_3.IsEnabled = true;
            button_2_3.Content = null;
            button_3_1.IsEnabled = true;
            button_3_1.Content = null;
            button_3_2.IsEnabled = true;
            button_3_2.Content = null;
            button_3_3.IsEnabled = true;
            button_3_3.Content = null;
        }
    
    }
}
