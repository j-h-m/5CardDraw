using System;

namespace WindowsFormsApplication1
{
    public class Hand
    {
        private Card[] newHand = new Card[5];
        private Card[] computerHand = new Card[5];
        private Deck myDeck = new Deck();

        public Hand()
        {
            newHand = setnewHand();
            computerHand = setcomputerHand();
        }

        public Card[] setnewHand()
        {
            for (int i = 0; i < 5; i++)
            {
                newHand[i] = (myDeck.getDeck().Pop());
            }
            return newHand;
        }

        public Card[] setcomputerHand()
        {
            for (int i = 0; i < 5; i++)
            {
                computerHand[i] = (myDeck.getDeck().Pop());
            }
            return computerHand;
        }

        public Card[] getnewHand()
        {
            return newHand;
        }

        public Card[] getcomputerHand()
        {
            return computerHand;
        }

        public void sortHand(Card[] array)
        {
            Array.Sort(array, delegate (Card c1, Card c2)
            {
                return c1.getFace().CompareTo(c2.getFace());
            });
        }
    }
}