using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    public class GameState
    {

        private Deck myDeck = new Deck();
        private Hand hand_ref = new Hand();
        
       
        //private Card[] player_hand = new Card[4];
        //private Card[] comp_hand = new Card[4];

        public int PlayerWallet()
        {
            int x;
            try
            {
                using (TextReader reader = File.OpenText(@"C:\Users\grant\Source\Repos\5CardDraw\PlayerWallet.txt"))
                {
                      x = int.Parse(reader.ReadLine());
                }
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException ("File Not Found.", e);
            }

            return x;
            
        }

        public int CompWallet()
        {
            int x;
            try
            {
                using (TextReader reader = File.OpenText(@"C:\Users\grant\Source\Repos\5CardDraw\CompWallet.txt"))
                {
                     x = int.Parse(reader.ReadLine());
                }
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException("File Not Found.", e);
            }

            return x;
        }

        public void PlayerDeal(out Card[] player_hand)
        {

            string startupPath = System.AppDomain.CurrentDomain.BaseDirectory;
            var pathItems = startupPath.Split(Path.DirectorySeparatorChar);
            string projectPath = String.Join(Path.DirectorySeparatorChar.ToString(), pathItems.Take(pathItems.Length - 3));
            string cardback = projectPath + "\\Card Images\\back of card.png";

            // test of Hand class
            player_hand = hand_ref.getnewHand();
            hand_ref.sortHand(player_hand);
           

        }

        public void CompDeal(out Card[] comp_hand)
        {
            string startupPath = System.AppDomain.CurrentDomain.BaseDirectory;
            var pathItems = startupPath.Split(Path.DirectorySeparatorChar);
            string projectPath = String.Join(Path.DirectorySeparatorChar.ToString(), pathItems.Take(pathItems.Length - 3));
            string cardback = projectPath + "\\Card Images\\back of card.png";

            comp_hand = hand_ref.getcomputerHand();
            hand_ref.sortHand(comp_hand);
        }

        public void PlayerDraw(int i, Card[] playerHand)
        {
           
            playerHand[i] = myDeck.getDeck().Pop();
            hand_ref.sortHand(playerHand);
        }

        public void CompDraw(int i, Card[] compHand)
        {
            
            compHand[i] = myDeck.getDeck().Pop();
            hand_ref.sortHand(compHand);
        }

       
    }
}
