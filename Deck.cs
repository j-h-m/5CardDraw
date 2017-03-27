using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace WindowsFormsApplication1
{
    public class Deck : Card
    {
        Stack<Image> playingDeck= new Stack<Image>();
        

        public Deck()
        {
            playingDeck = setDeck();
        }

        public Stack<Image> setDeck()
        {

            Image[] tmpCardArray;
            Card myCard = new Card();
           
            tmpCardArray = myCard.getCard();
           
           

            for (int i = 0; i < tmpCardArray.Length; i++)
            {
                Image currentImage = tmpCardArray[i];
                
               playingDeck.Push(currentImage);
            }

            return playingDeck;
        }

        public Stack<Image> getDeck()
        {
            return playingDeck;
        }

      
    }
}
