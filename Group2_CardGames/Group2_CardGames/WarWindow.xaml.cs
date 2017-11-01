using Group2_CardGames.Models;
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

namespace Group2_CardGames
{
	/// <summary>
	/// Interaction logic for WarWindow.xaml
	/// </summary>
	public partial class WarWindow : Window
	{
		private War warGame = new War();		
		
		public WarWindow(Player p1, Player p2)
		{
			InitializeComponent();
			warGame.SetPlayers(p1, p2);
			Player1NameBox.Text = p1.Name;
			Player2NameBox.Text = p2.Name;
			CardCollection deck = new CardCollection(true);
			p1.PlayerDeck.AddCards(deck.DrawCards(26));           
			p2.PlayerDeck.AddCards(deck.DrawCards(26));
			P2Left.Content = warGame.Players[1].PlayerDeck.Cards.Count();
			P1Left.Content = warGame.Players[0].PlayerDeck.Cards.Count();
		}

        private void NextTurn_Clicked(object sender, RoutedEventArgs e)
        {
            Card[] cards = warGame.PlayRound();

            p1_Card.Content = cards[0].ToString();
            P1Left.Content = warGame.Players[0].PlayerDeck.Cards.Count();

            p2_Card.Content = cards[1].ToString();
            P2Left.Content = warGame.Players[1].PlayerDeck.Cards.Count();

            if (warGame.CheckWin(out bool p1Win))
            {
                if (p1Win)
                {
                    MessageBox.Show($"congratulations {Player1NameBox} on a job well done", "Winner Winner Chicken Dinner", MessageBoxButton.OK);
                    
                }
                else
                {
                    MessageBox.Show($"congratulations {Player2NameBox} on a job well done", "Winner Winner Chicken Dinner", MessageBoxButton.OK);
                }
                Hide();
                Owner.Show();
            }
        }

        private void Clicked_Close(object sender, RoutedEventArgs e)
        {
            Hide();
            Owner.Show();
        }


		/// <summary>
		/// Help end application explicitly
		/// </summary>
		/// <param name="e">Event details</param>
		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);

			Application.Current.Shutdown();
		}
	}
}
