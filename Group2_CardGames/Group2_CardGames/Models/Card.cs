using Group2_CardGames.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_CardGames.Models
{
	public class Card
	{
		private CardSuit Suit { get; set; }
		private CardValue Value { get; set; }

		public Card(CardSuit suit, CardValue value)
		{
			this.Suit = suit;
			this.Value = value;
		}

		public Card(string value, string suit)
		{
			CardSuit s;
			CardValue v;
			if (Enum.TryParse<CardSuit>(suit,out s))
			{
				Suit = (CardSuit)Enum.Parse(typeof(CardSuit), suit);
			}
			else
			{
				return;
			}
			if (Enum.TryParse<CardValue>(value, out v))
			{
				Value = (CardValue)Enum.Parse(typeof(CardValue), value);
			}
			else
			{
				return;
			}
		}

		public override string ToString()
		{
			return Suit.ToString() + Value.ToString();
		}

        public CardSuit GetSuit()
        {
            return Suit;

        }
        public CardValue getValue()
        {
            return Value;
        }
	}
}
