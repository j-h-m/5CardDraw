﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace WindowsFormsApplication1
{
    public class GameState
    {
       private Hand hand_ref = new Hand();
       public Computer forest = new Computer();
       public Player player = new Player();

        public void PlayerDeal(out Card[] player_hand, Deck myDeck)
        {

            string startupPath = System.AppDomain.CurrentDomain.BaseDirectory;
            var pathItems = startupPath.Split(Path.DirectorySeparatorChar);
            string projectPath = String.Join(Path.DirectorySeparatorChar.ToString(), pathItems.Take(pathItems.Length - 3));
            string cardback = projectPath + "\\Card Images\\back of card.png";

            player_hand = hand_ref.setnewHand(myDeck);
            hand_ref.sortHand(player_hand);
           

        }

        public void CompDeal(out Card[] comp_hand, Deck myDeck)
        {
            string startupPath = System.AppDomain.CurrentDomain.BaseDirectory;
            var pathItems = startupPath.Split(Path.DirectorySeparatorChar);
            string projectPath = String.Join(Path.DirectorySeparatorChar.ToString(), pathItems.Take(pathItems.Length - 3));
            string cardback = projectPath + "\\Card Images\\back of card.png";

            comp_hand = hand_ref.setcomputerHand(myDeck);
            hand_ref.sortHand(comp_hand);
        }

        public void PlayerDraw(int i, Card[] playerHand, Deck myDeck)
        {
           
            playerHand[i] = myDeck.getDeck().Pop();
           // hand_ref.sortHand(playerHand);
        }

        public void CompDraw(int i, Card[] compHand, Deck myDeck)
        {
            
            compHand[i] = myDeck.getDeck().Pop();
           // hand_ref.sortHand(compHand);
        }

        public decimal updatePot(decimal moneyPot, decimal playerBet, decimal compBet)
        {
            return moneyPot += playerBet + compBet;

        }
        public decimal resetPot()
        {
            return 0;
        }

        public bool BetIsValid(decimal MoneyInWallet, decimal MoneyToBet )
        {
            if (MoneyToBet > MoneyInWallet)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        

        
    }
}
