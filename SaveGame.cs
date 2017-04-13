using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class SaveGame
    {
        private Deck deck;
        private RankHand rankHand;
        private GameState gameState;
        private Card[] pHand;
        private Card[] cHand;
        private decimal potValue, pMoney, cMoney;

        /*
         * Step 1: 
         *  Construct one of these when a "save button" is pressed, then use the added methods in Form1 to write this var to a file
         * Step 2:
         *  Setup logic to load file (may need to put getter methods in here to return the needed values to start a game)
         *  Something like,
         *      if (click load game)
         *          initialize vars with stuff from SaveGame
         *      else
         *          start a new game regular way    
         *           
         */

        public SaveGame(Deck oldDeck, RankHand oldRank, GameState oldGS, Card[] oldPHand, Card[] oldCHand, decimal oldPot, decimal oldPlayMoney, decimal oldCompMoney)
        {
            deck = oldDeck;
            rankHand = oldRank;
            gameState = oldGS;
            pHand = oldPHand;
            cHand = oldCHand;
            potValue = oldPot;
            pMoney = oldPlayMoney;
            cMoney = oldCompMoney;
        }

    }
}
