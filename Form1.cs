using System;
using System.Drawing;
using System.IO;
using System.Linq;
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

            if (playerscore > compscore)
            {
                Winnertxt.ForeColor = Color.Cyan;
                Winnertxt.Text = "Player Wins";
            }
            else if (compscore > playerscore)
            {
                Winnertxt.ForeColor = Color.Tomato;
                Winnertxt.Text = "Computer Wins";
            }
            else
            {
                Winnertxt.ForeColor = Color.Green;
                Winnertxt.Text = "Chuck Norris Wins";
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

            PComputerCard1.BackgroundImage = comp_hand[0].getImage();
            PComputerCard2.BackgroundImage = comp_hand[1].getImage();
            PComputerCard3.BackgroundImage = comp_hand[2].getImage();
            PComputerCard4.BackgroundImage = comp_hand[3].getImage();
            PComputerCard5.BackgroundImage = comp_hand[4].getImage();

            moneyPot.Text = "$2.00";
            playerMoney.Text = "$99.00";
            computerMoney.Text = "$99.00";

            DealBtn.Enabled = true;  //CHANGE BACK TO FALSE
            DealBtn.BackColor = Color.Gray;

            String handType = "Nothing";
            if (playerscore >= 1000 & playerscore < 1500)
            {
                handType = "Pair";
            }
            else if (playerscore >= 2000 & playerscore < 2500)
            {
                handType = "2 Pairs";
            }
            else if (playerscore >= 3000 & playerscore < 3500)
            {
                handType = "3 of a Kind";
            }
            else if (playerscore >= 4000 & playerscore < 4500)
            {
                handType = "Straight";
            }
            else if (playerscore >= 5000 & playerscore < 5500)
            {
                handType = "Flush";
            }
            else if (playerscore >= 6000 & playerscore < 6500)
            {
                handType = "Full House";
            }
            else if (playerscore >= 7000 & playerscore < 7500)
            {
                handType = "Four of a Kind";
            }
            else if (playerscore >= 8000 & playerscore < 8500)
            {
                handType = "Straight Flush";
            }
            else if (playerscore >= 9000)
            {
                handType = "Royal Flush";
            }
            MessageBox.Show("Player:  " + handType + " : " + playerscore.ToString());

            String handTypeComp = "Nothing";
            if (compscore >= 1000 & compscore < 1500)
            {
                handTypeComp = "Pair";
            }
            else if (compscore >= 2000 & compscore < 2500)
            {
                handTypeComp = "2 Pairs";
            }
            else if (compscore >= 3000 & compscore < 3500)
            {
                handTypeComp = "3 of a Kind";
            }
            else if (compscore >= 4000 & compscore < 4500)
            {
                handTypeComp = "Straight";
            }
            else if (compscore >= 5000 & compscore < 5500)
            {
                handTypeComp = "Flush";
            }
            else if (compscore >= 6000 & compscore < 6500)
            {
                handTypeComp = "Full House";
            }
            else if (compscore >= 7000 & compscore < 7500)
            {
                handTypeComp = "Four of a Kind";
            }
            else if (compscore >= 8000 & compscore < 8500)
            {
                handTypeComp = "Straight Flush";
            }
            else if (compscore >= 9000)
            {
                handTypeComp = "Royal Flush";
            }
            MessageBox.Show("Computer:  " + handTypeComp + " : " + compscore.ToString());
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
                PplayerCard1.Size = new System.Drawing.Size(83, 120);
                PplayerCard1.FlatAppearance.BorderColor = Color.Cyan;
                PplayerCard1.FlatAppearance.BorderSize = 5;
            }
            else
            {
                PplayerCard1.Size = new System.Drawing.Size(100, 145);
                PplayerCard1.FlatAppearance.BorderSize = 0;
            }
        }

        private void PplayerCard2_CheckedChanged(object sender, EventArgs e)
        {
            if (PplayerCard2.Checked)
            {
                PplayerCard2.Size = new System.Drawing.Size(83, 120);
                PplayerCard2.FlatAppearance.BorderColor = Color.Cyan;
                PplayerCard2.FlatAppearance.BorderSize = 5;
            }
            else
            {
                PplayerCard2.Size = new System.Drawing.Size(100, 145);
                PplayerCard2.FlatAppearance.BorderSize = 0;
            }
        }

        private void PplayerCard3_CheckedChanged(object sender, EventArgs e)
        {
            if (PplayerCard3.Checked)
            {
                PplayerCard3.Size = new System.Drawing.Size(83, 120);
                PplayerCard3.FlatAppearance.BorderColor = Color.Cyan;
                PplayerCard3.FlatAppearance.BorderSize = 5;
            }
            else
            {
                PplayerCard3.Size = new System.Drawing.Size(100, 145);
                PplayerCard3.FlatAppearance.BorderSize = 0;
            }
        }

        private void PplayerCard4_CheckedChanged(object sender, EventArgs e)
        {
            if (PplayerCard4.Checked)
            {
                PplayerCard4.Size = new System.Drawing.Size(83, 120);
                PplayerCard4.FlatAppearance.BorderColor = Color.Cyan;
                PplayerCard4.FlatAppearance.BorderSize = 5;
            }
            else
            {
                PplayerCard4.Size = new System.Drawing.Size(100, 145);
                PplayerCard4.FlatAppearance.BorderSize = 0;
            }
        }

        private void PplayerCard5_CheckedChanged(object sender, EventArgs e)
        {
            if (PplayerCard5.Checked)
            {
                PplayerCard5.Size = new System.Drawing.Size(83, 120);
                PplayerCard5.FlatAppearance.BorderColor = Color.Cyan;
                PplayerCard5.FlatAppearance.BorderSize = 5;
            }
            else
            {
                PplayerCard5.Size = new System.Drawing.Size(100, 145);
                PplayerCard5.FlatAppearance.BorderSize = 0;
            }
        }

        private void PComputerCard1_CheckedChanged(object sender, EventArgs e)
        {
            if (PComputerCard1.Checked)
            {
                PComputerCard1.Size = new System.Drawing.Size(83, 120);
                PComputerCard1.FlatAppearance.BorderColor = Color.Tomato;
                PComputerCard1.FlatAppearance.BorderSize = 5;
            }
            else
            {
                PComputerCard1.Size = new System.Drawing.Size(100, 145);
                PComputerCard1.FlatAppearance.BorderSize = 0;
            }
        }

        private void PComputerCard2_CheckedChanged(object sender, EventArgs e)
        {
            if (PComputerCard2.Checked)
            {
                PComputerCard2.Size = new System.Drawing.Size(83, 120);
                PComputerCard2.FlatAppearance.BorderColor = Color.Tomato;
                PComputerCard2.FlatAppearance.BorderSize = 5;
            }
            else
            {
                PComputerCard2.Size = new System.Drawing.Size(100, 145);
                PComputerCard2.FlatAppearance.BorderSize = 0;
            }
        }

        private void PComputerCard3_CheckedChanged(object sender, EventArgs e)
        {
            if (PComputerCard3.Checked)
            {
                PComputerCard3.Size = new System.Drawing.Size(83, 120);
                PComputerCard3.FlatAppearance.BorderColor = Color.Tomato;
                PComputerCard3.FlatAppearance.BorderSize = 5;
            }
            else
            {
                PComputerCard3.Size = new System.Drawing.Size(100, 145);
                PComputerCard3.FlatAppearance.BorderSize = 0;
            }
        }

        private void PComputerCard4_CheckedChanged(object sender, EventArgs e)
        {
            if (PComputerCard4.Checked)
            {
                PComputerCard4.Size = new System.Drawing.Size(83, 120);
                PComputerCard4.FlatAppearance.BorderColor = Color.Tomato;
                PComputerCard4.FlatAppearance.BorderSize = 5;
            }
            else
            {
                PComputerCard4.Size = new System.Drawing.Size(100, 145);
                PComputerCard4.FlatAppearance.BorderSize = 0;
            }
        }

        private void PComputerCard5_CheckedChanged(object sender, EventArgs e)
        {
            if (PComputerCard5.Checked)
            {
                PComputerCard5.Size = new System.Drawing.Size(83, 120);
                PComputerCard5.FlatAppearance.BorderColor = Color.Tomato;
                PComputerCard5.FlatAppearance.BorderSize = 5;
            }
            else
            {
                PComputerCard5.Size = new System.Drawing.Size(100, 145);
                PComputerCard5.FlatAppearance.BorderSize = 0;
            }
        }

        private void blinkTextbox(object sender, EventArgs e)
        {
            if (Winnertxt.BackColor == Color.Red) Winnertxt.BackColor = Color.White;
            else Winnertxt.BackColor = Color.Red;
        }
    }
}