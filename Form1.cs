using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class GameBoard : Form
    {

        private Deck myDeck = new Deck();
        private Hand hand_ref = new Hand();
        private RankHand hand_rank = new RankHand();



        public GameBoard()
        {
            InitializeComponent();
        }
       
        private void GameBoard_Load(object sender, EventArgs e)
        {

        }
        
        private void FoldBtn_Click(object sender, EventArgs e)
        {

        }

        private void DrawBtn_Click(object sender, EventArgs e)
        {



        }

        private void DealBtn_Click(object sender, EventArgs e)
        {
            string startupPath = System.AppDomain.CurrentDomain.BaseDirectory;
            var pathItems = startupPath.Split(Path.DirectorySeparatorChar);
            string projectPath = String.Join(Path.DirectorySeparatorChar.ToString(), pathItems.Take(pathItems.Length - 3));
            string cardback = projectPath + "\\Card Images\\back of card.png";

            // test of Hand class
            Card[] player_hand = hand_ref.getnewHand();
            hand_ref.sortHand(player_hand);
            Card[] comp_hand = hand_ref.getcomputerHand();
            hand_ref.sortHand(comp_hand);
            
            int playerscore = hand_rank.evalHand(player_hand);
            int compscore = hand_rank.evalHand(comp_hand);

            if(playerscore > compscore)
            {
                Winner.Text = "Player Wins";
            }
            else if(compscore > playerscore)
            {
                Winner.Text = "Computer Wins";
            }
            else
            {
                Winner.Text = "Chuck Norris Wins";
            }


            PBplayerCard1.Image = player_hand[0].getImage();
            PBplayerCard2.Image = player_hand[1].getImage();
            PBplayerCard3.Image = player_hand[2].getImage();
            PBplayerCard4.Image = player_hand[3].getImage();
            PBplayerCard5.Image = player_hand[4].getImage();

            /*ComputerCard1.Image = Image.FromFile(cardback);
            ComputerCard2.Image = Image.FromFile(cardback);
            ComputerCard3.Image = Image.FromFile(cardback);
            ComputerCard4.Image = Image.FromFile(cardback);
            ComputerCard5.Image = Image.FromFile(cardback);*/

            ComputerCard1.Image = comp_hand[0].getImage();
            ComputerCard2.Image = comp_hand[1].getImage();
            ComputerCard3.Image = comp_hand[2].getImage();
            ComputerCard4.Image = comp_hand[3].getImage();
            ComputerCard5.Image = comp_hand[4].getImage();



            moneyPot.Text = "$2.00";
            playerMoney.Text = "$99.00";
            computerMoney.Text = "$99.00";
            

            DealBtn.Enabled = false;
            DealBtn.BackColor = Color.Gray;


            //TRIAL



            //TRIAL

            //RankHand eval_player_hand = new RankHand(player_hand);
            //RankHand eval_comp_hand = new RankHand(comp_hand);

            //HandType player_hand_rank = eval_player_hand.EvaluateHand();
            //HandType comp_hand_rank = eval_comp_hand.EvaluateHand();

            //if (player_hand_rank > comp_hand_rank)
            //{
            //    Winner.Text = "Player Wins";
            //}
            //else if (comp_hand_rank > player_hand_rank)
            //{
            //    Winner.Text = "Computer Wins";
            //}
            //else
            //{
            //    Winner.Text = "Draw";
            //}
        }
    }
}