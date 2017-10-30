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
        public void Clicked_playWar(object sender, RoutedEventArgs e)
        {
            this.Close();
            //open new xaml
        }

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
    }
}

