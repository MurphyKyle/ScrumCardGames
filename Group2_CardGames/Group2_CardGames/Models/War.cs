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
			throw new NotImplementedException();
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
