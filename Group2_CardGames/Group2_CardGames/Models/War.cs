using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_CardGames.Models
{
	public class War : GameBase, IGameLogic
	{
		//players, moneyPool, roundCount

		public War()
		{
			Players = new Player[2];
		}

		public void SetPlayers(Player p1, Player p2)
		{
			Players[0] = p1;
			Players[1] = p2;
		}

		/// <summary>
		/// Not implemented as there is no betting in War
		/// </summary>f
		/// <param name="betAmount"></param>
		public void BetMoney(int betAmount)
		{
			throw new NotImplementedException();
		}

		public bool CheckWin()
		{
			bool winner = false;

			// if player1's card count is less than four
			if (Players[0].PlayerDeck.Cards.Count() < 4)
			{
				// player2 wins;
				winner = true;				
			}
			else if (Players[1].PlayerDeck.Cards.Count() < 4)
			{
				// player2 wins;
				winner = true;
			}
			return winner;
		}

		public void KickPlayer(Player player)
		{
			throw new NotImplementedException();
		}


		public void PlayRound()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Not implemented as there is no betting in War
		/// </summary>
		/// <returns></returns>
		public int WinMoney()
		{
			throw new NotImplementedException();
		}
	}
}
