using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;


namespace WindowsFormsApplication1
{
    public class Hand
    {
        Card[] playerHand = new Card[5];
        Card[] computerHand = new Card[5];
        Deck myDeck = new Deck();

        public Hand()
        {
            playerHand = setplayerHand();
            computerHand = setcomputerHand();
        }

        public Card[] setplayerHand()
        {
            for (int i = 0; i < 5; i++)
            {
                playerHand[i] = (myDeck.getDeck().Pop());
            }
            return playerHand;
        }
        public Card[] setcomputerHand()
        {
            for (int i = 0; i < 5; i++)
            {
                computerHand[i] = (myDeck.getDeck().Pop());
            }
            return computerHand;
        }

        public Card[] getplayerHand()
        {
            return playerHand;
        }

        public Card[] getcomputerHand()
        {
            return computerHand;
        }
    }
}
