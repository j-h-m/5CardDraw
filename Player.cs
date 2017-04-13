using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
  public  class Player
    {
        decimal playerMoney=100;
        public Player()
        {
            
        }

        public decimal getPlayerMoney()
        {
            return playerMoney;
        }
        public decimal updatePlayerMoneyBET(decimal pbet, decimal currMoney)
        {
            currMoney = currMoney - pbet;
            return currMoney;
        }
    }
}
