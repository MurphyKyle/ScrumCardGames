using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_CardGames.Models
{
	public class Blackjack : GameBase, IGameLogic
	{
		List<Player> players;

		public Blackjack()
		{
			players.Add(new Player("Dealer", 1000000000, new CardCollection));
		}

		public void BetMoney(int betAmount)
		{
			throw new NotImplementedException();
		}

		public bool CheckWin()
		{
			throw new NotImplementedException();
		}

		public void KickPlayer(Player player)
		{
			players.Remove(player);
		}

		public void PlayRound()
		{
			throw new NotImplementedException();
		}

		public int WinMoney()
		{
			throw new NotImplementedException();
		}
	}
}
