using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_CardGames.Models
{
    public class Player
    {
        public Player(string name, Wallet playerWallet, bool isActive, bool isHousePlayer)
        {
            Name = name;
            PlayerWallet = playerWallet;
            this.isActive = isActive;
            this.isHousePlayer = isHousePlayer;
        }

        public string Name { get; set; }
        public Wallet PlayerWallet { get; set; }
        public bool isActive { get; set; }
        public bool isHousePlayer { get; set; }

        

    }
}
