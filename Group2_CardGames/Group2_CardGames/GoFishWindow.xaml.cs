using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Group2_CardGames.Enums;
using Group2_CardGames.Models;

namespace Group2_CardGames
{
    /// <summary>
    /// Interaction logic for GoFishWindow.xaml
    /// </summary>
    /// 
    public partial class GoFishWindow : Window
    {
        public int numOfPlayers;
        public Player[] playerArray;
        public Card[] cardArray;
        public CardCollection cardCollection;

        public GoFishWindow()
        {
            InitializeComponent();


         }

        private void GoFishNumOfPlayerBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (GoFishNumOfPlayerBox.SelectedIndex)
            {
                case 0:
                    numOfPlayers = 2;
                    playerArray = new Player[2];
                    Player1NameTextBox.Visibility = Visibility.Visible;
                    Player2NameTextBox.Visibility = Visibility.Visible;
                    break;
                case 1:
                    numOfPlayers = 3;
                    playerArray = new Player[3];

                    Player1NameTextBox.Visibility = Visibility.Visible;
                    Player2NameTextBox.Visibility = Visibility.Visible;
                    Player3NameTextBox.Visibility = Visibility.Visible;
                    break;
                case 2:
                    numOfPlayers = 4;
                    playerArray = new Player[4];

                    Player1NameTextBox.Visibility = Visibility.Visible;
                    Player2NameTextBox.Visibility = Visibility.Visible;
                    Player3NameTextBox.Visibility = Visibility.Visible;
                    Player4NameTextBox.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void EnterNameButton_Click(object sender, RoutedEventArgs e)
        {
            switch (GoFishNumOfPlayerBox.SelectedIndex)
            {
                case 0:
                    numOfPlayers = 2;
                    playerArray = new Player[2];

                    break;
            }



        }
    }
}
