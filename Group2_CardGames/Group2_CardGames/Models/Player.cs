using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Group2_CardGames.Models
{
    public class Player
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; }
        public Wallet PlayerWallet { get; set; }
        public CardCollection PlayerDeck { get; set; }
        public bool isActive { get; set; }
        public bool isHousePlayer { get; set; }
        private static int score;

        public static int Score
        {
            get { return score; }
            set
            {
                score = value;
             }
        }


        public Player(string name, Wallet playerWallet, CardCollection playerDeck, bool isActive, bool isHousePlayer,int score)
        {
            Name = name;
            PlayerWallet = playerWallet;
            PlayerDeck = playerDeck;
            this.isActive = isActive;
            this.isHousePlayer = isHousePlayer;
        }

        //protected void ChangeField([CallerMemberName] string field = null)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(field));
        //    }
        //}

    }
}
