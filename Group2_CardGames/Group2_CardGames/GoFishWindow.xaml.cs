﻿﻿using System;
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
using System.ComponentModel;
using System.Runtime.CompilerServices;

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
        public Wallet wallet = new Wallet(0);

        public int PlayerOneScore { get; set; } = 3;


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
                    EnterNameButton.Visibility = Visibility.Visible;
                      break;
                case 1:
                    numOfPlayers = 3;
                    playerArray = new Player[3];

                    Player1NameTextBox.Visibility = Visibility.Visible;
                    Player2NameTextBox.Visibility = Visibility.Visible;
                    Player3NameTextBox.Visibility = Visibility.Visible;
                    EnterNameButton.Visibility = Visibility.Visible;

                    break;
                case 2:
                    numOfPlayers = 4;
                    playerArray = new Player[4];

                    Player1NameTextBox.Visibility = Visibility.Visible;
                    Player2NameTextBox.Visibility = Visibility.Visible;
                    Player3NameTextBox.Visibility = Visibility.Visible;
                    Player4NameTextBox.Visibility = Visibility.Visible;
                    EnterNameButton.Visibility = Visibility.Visible;

                    break;
            }
        }

        private void EnterNameButton_Click(object sender, RoutedEventArgs e)
        {
            switch (GoFishNumOfPlayerBox.SelectedIndex)
            {
                case 0:
                  
                    playerArray[0] = new Player(Player1NameTextBox.Text, wallet, cardCollection, true, false, 0);
                    playerArray[1] = new Player(Player2NameTextBox.Text, wallet, cardCollection, true, false, 0);
                    NumberOfPlayersGrid.Visibility = Visibility.Collapsed;
                    GoFishGameGrid.Visibility = Visibility.Visible;
                    break;
                case 1:

                    playerArray[0] = new Player(Player1NameTextBox.Text, wallet, cardCollection, true, false, 0);
                    playerArray[1] = new Player(Player2NameTextBox.Text, wallet, cardCollection, true, false, 0);
                    playerArray[2] = new Player(Player3NameTextBox.Text, wallet, cardCollection, true, false, 0);
                    NumberOfPlayersGrid.Visibility = Visibility.Collapsed;
                    GoFishGameGrid.Visibility = Visibility.Visible;
                    break;
                case 2:

                    playerArray[0] = new Player(Player1NameTextBox.Text, wallet, cardCollection, true, false, 0);
                    playerArray[1] = new Player(Player2NameTextBox.Text, wallet, cardCollection, true, false, 0);
                    playerArray[2] = new Player(Player3NameTextBox.Text, wallet, cardCollection, true, false, 0);
                    playerArray[3] = new Player(Player4NameTextBox.Text, wallet, cardCollection, true, false, 0);
                    NumberOfPlayersGrid.Visibility = Visibility.Collapsed;
                    GoFishGameGrid.Visibility = Visibility.Visible;
                    break;

            }



        }

		private void Clicked_BackBtn(object sender, RoutedEventArgs e)
		{
			Hide();
			Owner.Visibility = Visibility.Visible;
		}
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }
    }
}