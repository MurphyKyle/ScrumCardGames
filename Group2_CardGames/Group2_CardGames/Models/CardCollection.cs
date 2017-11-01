using Group2_CardGames.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Group2_CardGames.Models
{
	public class CardCollection
	{
		public List<Card> Cards { get; set; } = new List<Card>();

		public CardCollection(bool createDeck = false)
		{
			if (createDeck)
			{
				ResetDeck();

			}
		}

		public CardCollection(Card[] c)
		{
			Cards.AddRange(c);
		}

		public void Shuffle()
		{
			int count = Cards.Count();
			List<Card> output = Cards;
			byte[] b = new byte[5];
			RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
			provider.GetBytes(b);
			int seed = b[0] * b[1] * b[2] * b[3] * b[4];
			Random rnd = new Random(seed);
			int g;
			for (int i = 0; i < count - 2; i++)
			{
				g = rnd.Next(i, count);
				Card x = output[i];
				output[i] = output[g];
				output[g] = x;
			}
			Cards = output;
		}

		public void DrawCard(ref CardCollection c)
		{
			if (c == null)
			{
				throw new ArgumentNullException(nameof(c) + "Where be the cards?!");
			}

			AddCard(c.Cards[0]);
			c.Cards.RemoveAt(0);
		}

		public Card DrawSingleCard()
		{
			Card c = Cards[0];
			Cards.RemoveAt(0);
			return c;
		}

		public CardCollection DrawCards(int numOfCards)
		{
			CardCollection cards = new CardCollection();

			for (int i = 0; i < numOfCards; i++)
			{
				cards.AddCard(DrawSingleCard());
			}

			return cards;
		}

		public void ResetDeck()
		{
			BuildNewDeck();
			Shuffle();
		}

		public void ClearCards()
		{
			this.Cards.Clear();
		}

		public void AddCards(Card[] c)
		{
			this.Cards.AddRange(c);
		}

		public void AddCards(CardCollection cards)
		{
			Cards.AddRange(cards.Cards);
		}

		public void AddCards(List<Card> cards)
		{
			Cards.AddRange(cards);
		}

		public void AddCard(Card c)
		{
			this.Cards.Add(c);
		}

		private void BuildNewDeck()
		{
			Cards.Clear();

			foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
			{
				foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
				{
					Cards.Add(new Card(suit, value));
				}
			}
		}

		public override string ToString()
		{
			string s = "";
			foreach (Card c in Cards)
			{
				s += c.ToString() + " ";
			}
			return s;
		}
	}
}
		 