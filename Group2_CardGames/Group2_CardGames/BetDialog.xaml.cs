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
	/// Interaction logic for BetDialog.xaml
	/// </summary>
	public partial class BetDialog : Window
	{
		public int Bet { get; set; }
		public BetDialog()
		{
			InitializeComponent();
		}

		private void Close_Click(object sender, RoutedEventArgs e)
		{
			string s = Amount.Text;
			int res = 0;
			if (int.TryParse(s, out res))
			{
				res = int.Parse(s);
				Bet = res;
				this.Close();
			}
			else
			{
				Amount.Background = new SolidColorBrush(Colors.Orange);
			}

		}
	}
}
