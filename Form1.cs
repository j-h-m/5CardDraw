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
                Winner2.Text = "Computer Wins";
            }
            else
            {
                Winner.Text = "Chuck Norris Wins";
                Winner2.Text = "Chuck Norris Wins";
            }


            /*PBplayerCard1.Image = player_hand[0].getImage();
            PBplayerCard2.Image = player_hand[1].getImage();
            PBplayerCard3.Image = player_hand[2].getImage();
            PBplayerCard4.Image = player_hand[3].getImage();
            PBplayerCard5.Image = player_hand[4].getImage();*/

            PplayerCard1.BackgroundImage = player_hand[0].getImage();
            PplayerCard2.BackgroundImage = player_hand[1].getImage();
            PplayerCard3.BackgroundImage = player_hand[2].getImage();
            PplayerCard4.BackgroundImage = player_hand[3].getImage();
            PplayerCard5.BackgroundImage = player_hand[4].getImage();

            /*ComputerCard1.Image = Image.FromFile(cardback);
            ComputerCard2.Image = Image.FromFile(cardback);
            ComputerCard3.Image = Image.FromFile(cardback);
            ComputerCard4.Image = Image.FromFile(cardback);
            ComputerCard5.Image = Image.FromFile(cardback);*/

            /*ComputerCard1.Image = comp_hand[0].getImage();
            ComputerCard2.Image = comp_hand[1].getImage();
            ComputerCard3.Image = comp_hand[2].getImage();
            ComputerCard4.Image = comp_hand[3].getImage();
            ComputerCard5.Image = comp_hand[4].getImage();*/

            PcomputerCard1.BackgroundImage = comp_hand[0].getImage();
            PcomputerCard2.BackgroundImage = comp_hand[1].getImage();
            PcomputerCard3.BackgroundImage = comp_hand[2].getImage();
            PcomputerCard4.BackgroundImage = comp_hand[3].getImage();
            PcomputerCard5.BackgroundImage = comp_hand[4].getImage();



            moneyPot.Text = "$2.00";
            playerMoney.Text = "$99.00";
            computerMoney.Text = "$99.00";
            

            DealBtn.Enabled = false;
            DealBtn.BackColor = Color.Gray;

            String handType = "Nothing";
            if (playerscore >= 1000 & playerscore < 2000)
            {
                handType = "Pair";
            }
            else if (playerscore >= 2000 & playerscore < 3000)
            {
                handType = "2 Pairs";
            }
            else if (playerscore >= 3000 & playerscore < 4000)
            {
                handType = "3 of a Kind";
            }
            else if (playerscore >= 4000 & playerscore < 5000)
            {
                handType = "Straight";
            }
            else if (playerscore >= 5000 & playerscore < 6000)
            {
                handType = "Flush";
            }
            else if (playerscore >= 6000 & playerscore < 7000)
            {
                handType = "Full House";
            }
            else if (playerscore >= 7000 & playerscore < 8000)
            {
                handType = "Four of a Kind";
            }
            else if (playerscore >= 8000 & playerscore < 9000)
            {
                handType = "Straight Flush";
            }
            else if (playerscore >= 9000)
            {
                handType = "Royal Flush";
            }
            PlayerHandLabel.Text = ("Hand:  " + handType + "\r\n" + "Score:  " + playerscore.ToString());

            
            if (compscore >= 1000 & compscore < 2000)
            {
                handType = "Pair";
            }
            else if (compscore >= 2000 & compscore < 3000)
            {
                handType = "2 Pairs";
            }
            else if (compscore >= 3000 & compscore < 4000)
            {
                handType = "3 of a Kind";
            }
            else if (compscore >= 4000 & compscore < 5000)
            {
                handType = "Straight";
            }
            else if (compscore >= 5000 & compscore < 6000)
            {
                handType = "Flush";
            }
            else if (compscore >= 6000 & compscore < 7000)
            {
                handType = "Full House";
            }
            else if (compscore >= 7000 & compscore < 8000)
            {
                handType = "Four of a Kind";
            }
            else if (compscore >= 8000 & compscore < 9000)
            {
                handType = "Straight Flush";
            }
            else if (compscore >= 9000)
            {
                handType = "Royal Flush";
            }
            CompHandLabel.Text = ("Hand:  " + handType + "\r\n" + "Score:  " + compscore.ToString());
            
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

        private void PplayerCard1_CheckedChanged(object sender, EventArgs e)
        {
            
                if (PplayerCard1.Checked)
                {
                PplayerCard1.Location = new Point(249, 430);
                PplayerCard1.FlatAppearance.BorderColor = Color.Cyan;
                PplayerCard1.FlatAppearance.BorderSize = 2;
                }
                else
                {
                PplayerCard1.Location = new Point(249, 460);
               
                PplayerCard1.FlatAppearance.BorderSize = 0;
                }
            
        }

        private void PplayerCard2_CheckedChanged(object sender, EventArgs e)
        {
            if (PplayerCard2.Checked)
            {
                PplayerCard2.Location = new Point(370, 430);
                PplayerCard2.FlatAppearance.BorderColor = Color.Cyan;
                PplayerCard2.FlatAppearance.BorderSize = 2;
            }
            else
            {
                PplayerCard2.Location = new Point(370, 460);
               
                PplayerCard2.FlatAppearance.BorderSize = 0;
            }
        }

        private void PplayerCard3_CheckedChanged(object sender, EventArgs e)
        {
            if (PplayerCard3.Checked)
            {
                PplayerCard3.Location = new Point(498, 430);
                PplayerCard3.FlatAppearance.BorderColor = Color.Cyan;
                PplayerCard3.FlatAppearance.BorderSize = 2;
            }
            else
            {
                PplayerCard3.Location = new Point(498, 460);
                
                PplayerCard3.FlatAppearance.BorderSize = 0;
            }
        }

        private void PplayerCard4_CheckedChanged(object sender, EventArgs e)
        {
            if (PplayerCard4.Checked)
            {
                PplayerCard4.Location = new Point(622, 430);
                PplayerCard4.FlatAppearance.BorderColor = Color.Cyan;
                PplayerCard4.FlatAppearance.BorderSize = 2;
            }
            else
            {
                PplayerCard4.Location = new Point(622, 460);
                
                PplayerCard4.FlatAppearance.BorderSize = 0;
            }
        }

        private void PplayerCard5_CheckedChanged(object sender, EventArgs e)
        {
            if (PplayerCard5.Checked)
            {
                PplayerCard5.Location = new Point(750, 430);
                PplayerCard5.FlatAppearance.BorderColor = Color.Cyan;
                PplayerCard5.FlatAppearance.BorderSize = 2;
            }
            else
            {
                PplayerCard5.Location = new Point(750, 460);
                
                PplayerCard5.FlatAppearance.BorderSize = 0;
            }
        }

        private void PcomputerCard1_CheckedChanged(object sender, EventArgs e)
        {
            if (PcomputerCard1.Checked)
            {
                PcomputerCard1.Location = new Point(249, 50);
                PcomputerCard1.FlatAppearance.BorderColor = Color.Cyan;
                PcomputerCard1.FlatAppearance.BorderSize = 2;
            }
            else
            {
                PcomputerCard1.Location = new Point(249, 20);
                
                PcomputerCard1.FlatAppearance.BorderSize = 0;
            }
        }

        private void PcomputerCard2_CheckedChanged(object sender, EventArgs e)
        {
            if (PcomputerCard2.Checked)
            {
                PcomputerCard2.Location = new Point(370, 50);
                PcomputerCard2.FlatAppearance.BorderColor = Color.Cyan;
                PcomputerCard2.FlatAppearance.BorderSize = 2;
            }
            else
            {
                PcomputerCard2.Location = new Point(370, 20);
               
                PcomputerCard2.FlatAppearance.BorderSize = 0;
            }
        }

        private void PcomputerCard3_CheckedChanged(object sender, EventArgs e)
        {
            if (PcomputerCard3.Checked)
            {
                PcomputerCard3.Location = new Point(498, 50);
                PcomputerCard3.FlatAppearance.BorderColor = Color.Cyan;
                PcomputerCard3.FlatAppearance.BorderSize = 2;
            }
            else
            {
                PcomputerCard3.Location = new Point(498, 20);
                
                PcomputerCard3.FlatAppearance.BorderSize = 0;
            }
        }

        private void PcomputerCard4_CheckedChanged(object sender, EventArgs e)
        {
            if (PcomputerCard4.Checked)
            {
                PcomputerCard4.Location = new Point(622, 50);
                PcomputerCard4.FlatAppearance.BorderColor = Color.Cyan;
                PcomputerCard4.FlatAppearance.BorderSize = 2;
            }
            else
            {
                PcomputerCard4.Location = new Point(622, 20);
                
                PcomputerCard4.FlatAppearance.BorderSize = 0;
            }
        }

        private void PcomputerCard5_CheckedChanged(object sender, EventArgs e)
        {
            if (PcomputerCard5.Checked)
            {
                PcomputerCard5.Location = new Point(750, 50);
                PcomputerCard5.FlatAppearance.BorderColor = Color.Cyan;
                PcomputerCard5.FlatAppearance.BorderSize = 2;
            }
            else
            {
                PcomputerCard5.Location = new Point(750, 20);
                
                PcomputerCard5.FlatAppearance.BorderSize = 0;
            }
        }
    }
}