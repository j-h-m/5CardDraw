using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;


namespace WindowsFormsApplication1
{
    class Hand : Deck
    {
        Image[] playerHand = new Image[5];
        Image[] computerHand = new Image[5];
        
        Deck myDeck = new Deck();
        
       
        
        
        public Hand()
        {
            playerHand = setplayerHand();
            computerHand = setcomputerHand();
            
        }

        public Image[] setplayerHand()
        {

             
            for (int i=0; i<5; i++)
            {
                playerHand[i]=(myDeck.getDeck().Pop());
            }
            return playerHand;
        }
        public Image[] setcomputerHand()
        {
            for (int i = 0; i < 5; i++)
            {
                computerHand[i]=(myDeck.getDeck().Pop());
            }
            return computerHand;
        }

        public Image[] getplayerHand()
        {
            return playerHand;
        }

        public Image[] getcomputerHand()
        {
            return computerHand;
        }

    }
}
