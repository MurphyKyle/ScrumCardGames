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

        public void clicked_Open()
        {

        }
        public void clicked_Close()
        {

        }

        public void clicked_playBlackjack()
        {
                this.Close();
                //open new xaml

        }
        public void clicked_playPoker()
        {
            this.Close();
            //open new xaml
        }
        public void clicked_playGoFish()
        {
            this.Close();
            //open new xaml
        }
        public void clicked_playWar()
        {
            this.Close();
            //open new xaml
        }




    }
}
