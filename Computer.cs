using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Computer:GameState
    {
        int computerBet;
        GameState gs = new GameState();
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

        public int Draw(Card[] handCards, Deck myDeck)
        {
            //Pair
            if (handCards[0].getFace() == handCards[1].getFace())
            {
                
                gs.CompDraw(2, handCards, myDeck);
                gs.CompDraw(3, handCards, myDeck);
                gs.CompDraw(4, handCards, myDeck);
                return 234;
            }
            else if (handCards[1].getFace() == handCards[2].getFace())
            {
                gs.CompDraw(0, handCards, myDeck);
                gs.CompDraw(3, handCards, myDeck);
                gs.CompDraw(4, handCards, myDeck);
                return 034;
            }
            else if (handCards[2].getFace() == handCards[3].getFace())
            {
                gs.CompDraw(0, handCards, myDeck);
                gs.CompDraw(1, handCards, myDeck);
                gs.CompDraw(4, handCards, myDeck);
                return 014;
            }
            else if (handCards[3].getFace() == handCards[4].getFace())
            {
                gs.CompDraw(0, handCards, myDeck);
                gs.CompDraw(1, handCards, myDeck);
                gs.CompDraw(2, handCards, myDeck);
                return 012;
            }
            //Two pair
            else if ((handCards[0].getFace() == handCards[1].getFace() && handCards[2].getFace() == handCards[3].getFace()))
            {
                gs.CompDraw(4, handCards, myDeck);
                return 4;
            }
            else if ((handCards[0].getFace() == handCards[1].getFace() && handCards[3].getFace() == handCards[4].getFace()))
            {
                gs.CompDraw(2, handCards, myDeck);
                return 2;
            }
            else if ((handCards[1].getFace() == handCards[2].getFace() && handCards[3].getFace() == handCards[4].getFace()))
            {
                gs.CompDraw(0, handCards, myDeck);
                return 0;
            }
            //Three of a kind
            else if ((handCards[0].getFace() == handCards[1].getFace() && handCards[0].getFace() == handCards[2].getFace()))
            {
                gs.CompDraw(3, handCards, myDeck);
                gs.CompDraw(4, handCards, myDeck);
                return 34;
         
            }
            else if ((handCards[1].getFace() == handCards[2].getFace() && handCards[1].getFace() == handCards[3].getFace()))
            {
                gs.CompDraw(0, handCards, myDeck);
                gs.CompDraw(4, handCards, myDeck);
                return 14;

            }
            else if ((handCards[2].getFace() == handCards[3].getFace() && handCards[2].getFace() == handCards[4].getFace()))
            {
                gs.CompDraw(0, handCards, myDeck);
                gs.CompDraw(1, handCards, myDeck);
                return 1;
            }
            return -1;
        }
    }
}
