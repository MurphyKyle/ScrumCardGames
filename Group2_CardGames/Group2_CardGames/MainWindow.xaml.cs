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
		}


        public void clicked_Open(object sender, RoutedEventArgs e)
        {

        }
        public void clicked_Close(object sender, RoutedEventArgs e)
        {

        }

        public void clicked_playBlackjack(object sender, RoutedEventArgs e)
        {
                this.Close();
                //open new xaml

        }
        public void clicked_playPoker(object sender, RoutedEventArgs e)
        {
            this.Close();
            //open new xaml
        }
        public void clicked_playGoFish(object sender, RoutedEventArgs e)
        {
            GoFishWindow gfw = new GoFishWindow();
            this.Close();
            gfw.Show();
            //open new xaml
        }
        public void clicked_playWar(object sender, RoutedEventArgs e)
        {
            this.Close();
            //open new xaml
        }
    }
}
