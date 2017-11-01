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
		}

		//private void Settings_PlayersUpdatedEvent(object sender, EventArgs e)
		//{
		//	Player p1 = new Player(((List<string>)sender)[0], null, new CardCollection(), true, false);

		//	Player p2 = new Player(((List<string>)sender)[1], null, new CardCollection(), true, false);

		//}
	}
}
