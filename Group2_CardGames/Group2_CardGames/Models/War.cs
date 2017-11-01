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

		public bool CheckWin(out bool p1Win)
		{
            p1Win = false;
			bool winner = false;

			// if player1's card count is less than four
			if (Players[0].PlayerDeck.Cards.Count() < 4)
			{
                // player2 wins;
                p1Win = false;
				winner = true;				
			}
			else if (Players[1].PlayerDeck.Cards.Count() < 4)
			{
                // player1 wins;
                p1Win = true;
				winner = true;
			}
			return winner;
		}

		public void KickPlayer(Player player)
		{
			throw new NotImplementedException();
		}


		public Card[] PlayRound()
		{
            List<Card> cards = new List<Card>();
            Boolean whileTrue = true;

            do
            {
                Card c1 = Players[0].PlayerDeck.DrawSingleCard();
                Card c2 = Players[1].PlayerDeck.DrawSingleCard();

                cards.Add(c1);
                cards.Add(c2);

                Enums.CardValue cv1 = c1.GetValue();
                Enums.CardValue cv2 = c2.GetValue();

				int s1 = (int)cv1;
				int s2 = (int)cv2;

                if (s1 > s2)
                {
                    Players[0].PlayerDeck.AddCards(cards);
                    whileTrue = false;
                }
                else if (s2 > s1)
                {
                    Players[1].PlayerDeck.AddCards(cards);
                    whileTrue = false;
                }
            } while (whileTrue);

            Card[] toPrint = { cards.Last(), cards[cards.Count - 1] };

            return toPrint;
		}



		/// <summary>
		/// Not implemented as there is no betting in War
		/// </summary>
		/// <returns></returns>
		public int WinMoney()
		{
			throw new NotImplementedException();
		}

        void IGameLogic.BetMoney(int betAmount)
        {
            throw new NotImplementedException();
        }

        int IGameLogic.WinMoney()
        {
            throw new NotImplementedException();
        }

        bool IGameLogic.CheckWin()
        {
            throw new NotImplementedException();
        }

        void IGameLogic.PlayRound()
        {
            throw new NotImplementedException();
        }

        void IGameLogic.KickPlayer(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
