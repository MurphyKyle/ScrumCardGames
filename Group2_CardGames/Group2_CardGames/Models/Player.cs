using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_CardGames.Models
{
    public class Player
    {

        public string Name { get; set; }
        public Wallet PlayerWallet { get; set; }
        public CardCollection PlayerDeck { get; set; }
        public bool isActive { get; set; }
        public bool isHousePlayer { get; set; }
        public Player(string name, Wallet playerWallet, CardCollection playerDeck, bool isActive, bool isHousePlayer)
        {
            Name = name;
            PlayerWallet = playerWallet;
            PlayerDeck = playerDeck;
            this.isActive = isActive;
            this.isHousePlayer = isHousePlayer;
        }

        

    }
}
