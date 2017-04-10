using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Computer : Hand
    {
        int computerBet;
        public Computer()
        {

        }

        public int generateBet(int compScore)
        {

            if (compScore >= 1000 & compScore < 2000)
            {
                computerBet = 10;
            }
            else if (compScore >= 2000 & compScore < 3000)
            {
                computerBet = 20;
            }
            else if (compScore >= 3000 & compScore < 4000)
            {
                computerBet = 30;
            }
            else if (compScore >= 4000 & compScore < 5000)
            {
                computerBet = 40;
            }
            else if (compScore >= 5000 & compScore < 6000)
            {
                computerBet = 50;
            }
            else if (compScore >= 6000 & compScore < 7000)
            {
                computerBet = 60;
            }
            else if (compScore >= 7000 & compScore < 8000)
            {
                computerBet = 70;
            }
            else if (compScore >= 8000 & compScore < 9000)
            {
                computerBet = 80;
            }
            else if (compScore >= 9000)
            {
                computerBet = 90;
            }
            else
            {
                computerBet = 0;
            }
            return computerBet;
        }
    }
}
