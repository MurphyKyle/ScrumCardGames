using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_CardGames.Models
{
	/// <summary>
	/// Contains three datamembers: Player[] players, int moneyPool, int roundCount
	/// </summary>
	public class GameBase
	{
		public Player[] Players { get; set; } = new Player[4];
		public int MoneyPool { get; set; }
		public int RoundCount { get; set; }
	}
}
