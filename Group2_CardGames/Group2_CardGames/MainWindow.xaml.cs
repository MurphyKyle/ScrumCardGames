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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Group2_CardGames
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			WindowStartupLocation = WindowStartupLocation.CenterScreen;			

		}


        public void Clicked_Open(object sender, RoutedEventArgs e)
        {

        }
        public void Clicked_Close(object sender, RoutedEventArgs e)
        {

        }
        public void Clicked_playBlackjack(object sender, RoutedEventArgs e)
        {
                this.Close();
                //open new xaml

        }
        public void Clicked_playPoker(object sender, RoutedEventArgs e)
        {
            this.Close();
            //open new xaml
        }

        public void Clicked_playGoFish(object sender, RoutedEventArgs e)
        {
            GoFishWindow gfw = new GoFishWindow();
			SwitchWindows(gfw);
			//open new xaml
		}

		/// <summary>
		/// Creates a new WarGame window and stands it up for playing
		/// </summary>
		/// <param name="sender">Object that triggered the event</param>
		/// <param name="e">Event details</param>
        public void Clicked_playWar(object sender, RoutedEventArgs e)
        {
			// get player data
			PlayerSettings settings = new PlayerSettings(3);
			SwitchWindows(settings);
			// open new xaml
			//WarWindow war = new WarWindow();
			//SwitchWindows(war);

        }

		/// <summary>
		/// Sets the Owner of the newWindow to "this" window and stands up the new window
		/// </summary>
		/// <param name="newWindow">The new window to be displayed</param>
		private void SwitchWindows(Window newWindow)
		{
			// maybe keep all of the windows we open, allowing users to go back to instances of the game.
			// example could be: play GoFish, back to main menu to save, then back to continue Gofish
			//WindowCollection col = new WindowCollection();
			newWindow.Owner = this;
			newWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
			Hide();
			newWindow.Show();
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

