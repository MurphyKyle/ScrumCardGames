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
		
		public WarWindow()
		{
			InitializeComponent();
		}

		private void Player2NameBox_LostFocus(object sender, RoutedEventArgs e)
		{

		}

		private void Player1NameBox_LostFocus(object sender, RoutedEventArgs e)
		{

		}
	}
}
