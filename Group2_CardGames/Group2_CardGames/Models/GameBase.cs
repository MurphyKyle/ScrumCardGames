using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_CardGames.Models
{
	public class GameBase
	{
		private Player[] players = new Player[4];
		private int moneyPool = 0;
		private int roundCount = 0;
	}
}
