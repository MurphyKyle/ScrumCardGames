using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_CardGames.Models
{
    public class Wallet
    {
        public int Money { get; set; }

        public Wallet(int money)
        {
            this.Money = money;
        }

        public int sendMoney(int money)
        {   
            return Money -= money;
        }
        public int receiveMoney(int money)
        {
            return Money += money;
        }
    }
}
