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
    /// Interaction logic for PlayerSettings.xaml
    /// </summary>
    public partial class PlayerSettings : Window
    {
		public event EventHandler PlayersUpdatedEvent;
		public List<string> playerNames;

		/// <summary>
		/// Window to gather player count and names
		/// </summary>
		/// <param name="maxNumOfPlayers">Maximum number of players to choose</param>
		public PlayerSettings(int maxNumOfPlayers)
        {		
            InitializeComponent();
			WindowStartupLocation = WindowStartupLocation.CenterOwner;

			List<int> numOfPlayers = new List<int>();

			for (int i = 2; i <= maxNumOfPlayers; i++)
			{
				numOfPlayers.Add(i);

				switch(i)
				{
					case 4:
						Player4Panel.Visibility = Visibility.Visible;
						goto case 3;
					case 3:
						Player3Panel.Visibility = Visibility.Visible;
						break;
				}
			}

			PlayerCountBox.ItemsSource = numOfPlayers;
			PlayerCountBox.SelectedIndex = maxNumOfPlayers - 1;
			playerNames = new List<string>();
        }

		/// <summary>
		/// Button click adds the player names to the list, 
		/// Invokes the PlayersUpdatedEvent for the outside world to know
		/// </summary>
		/// <param name="sender">Object that triggered the event</param>
		/// <param name="e">Event details</param>
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			playerNames.Add(txtPlayer1.Text);
			playerNames.Add(txtPlayer2.Text);
			playerNames.Add(txtPlayer3.Text);
			playerNames.Add(txtPlayer4.Text);

			PlayersUpdatedEvent.Invoke(playerNames, e);
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
