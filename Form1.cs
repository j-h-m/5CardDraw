using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class GameBoard :Form
    {
        private Deck myDeck = new Deck();
        private Hand hand_ref = new Hand();
        private RankHand hand_rank = new RankHand();
        private Computer computerGuy = new Computer();
        private GameState game_state = new GameState();
        private int PbetClickCounter = 0;
        private int DrawClickCounter = 0;
        

        private int playerStartingAmount = 1000;
        private int compStartingAmount = 1000;
        private int moneyPotStartingAmount = 0;

        private Card[] player_hand = new Card[4];
        private Card[] comp_hand = new Card[4];

        public GameBoard()
        {
            InitializeComponent();

        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
        }

        private void FoldBtn_Click(object sender, EventArgs e)
        {
            FadeOut(this,100);
            this.Close();
            
        }

        private void DrawBtn_Click(object sender, EventArgs e)
        {
            if (PplayerCard1.Checked)
            {
             
                game_state.PlayerDraw(0, player_hand);
                PplayerCard1.Location = new Point(35, 44);
                PplayerCard1.FlatAppearance.BorderSize = 0;
                PplayerCard1.Checked = false;
                

            }
            if (PplayerCard2.Checked)
            {
                game_state.PlayerDraw(1, player_hand);
                PplayerCard2.Location = new Point(156, 44);
                PplayerCard2.FlatAppearance.BorderSize = 0;
                PplayerCard2.Checked = false;
                
            }
            if (PplayerCard3.Checked)
            {
                game_state.PlayerDraw(2, player_hand);
                PplayerCard3.Location = new Point(284, 44);            
                PplayerCard3.FlatAppearance.BorderSize = 0;
                PplayerCard3.Checked = false;
                
            }
            if (PplayerCard4.Checked)
            {
                game_state.PlayerDraw(3, player_hand);
                PplayerCard4.Location = new Point(408, 44);
                PplayerCard4.FlatAppearance.BorderSize = 0;
                PplayerCard4.Checked = false;
                
            }
            if (PplayerCard5.Checked)
            {
                game_state.PlayerDraw(4, player_hand);
                PplayerCard5.Location = new Point(536, 44);
                PplayerCard5.FlatAppearance.BorderSize = 0;
                PplayerCard5.Checked = false;
                
            }
            PplayerCard1.BackgroundImage = player_hand[0].getImage();
            PplayerCard2.BackgroundImage = player_hand[1].getImage();
            PplayerCard3.BackgroundImage = player_hand[2].getImage();
            PplayerCard4.BackgroundImage = player_hand[3].getImage();
            PplayerCard5.BackgroundImage = player_hand[4].getImage();
            int compDrawIndex=  computerGuy.Draw(comp_hand);

            if(compDrawIndex==234)
            {
                thinkLabel.Text = "Thinking...";
                thinkLabel.Visible = true;
                this.Update();
                System.Threading.Thread.Sleep(1000);
                PcomputerCard3.Checked = true;
                System.Threading.Thread.Sleep(1000);
                PcomputerCard4.Checked = true;
                System.Threading.Thread.Sleep(1000);
                PcomputerCard5.Checked = true;
                thinkLabel.Visible = false;
                DrawBtn.Enabled = false;
            }
            else if(compDrawIndex==034)
            {
                thinkLabel.Text = "Thinking...";
                thinkLabel.Visible = true;
                this.Update();
                System.Threading.Thread.Sleep(1000);
                PcomputerCard1.Checked = true;
                System.Threading.Thread.Sleep(1000);
                PcomputerCard4.Checked = true;
                System.Threading.Thread.Sleep(1000);
                PcomputerCard5.Checked = true;
                thinkLabel.Visible = false;
                DrawBtn.Enabled = false;
            }
            else if (compDrawIndex == 014)
            {
                thinkLabel.Text = "Thinking...";
                thinkLabel.Visible = true;
                this.Update();
                System.Threading.Thread.Sleep(1000);
                PcomputerCard1.Checked = true;
                System.Threading.Thread.Sleep(1000);
                PcomputerCard2.Checked = true;
                System.Threading.Thread.Sleep(1000);
                PcomputerCard5.Checked = true;
                thinkLabel.Visible = false;
                DrawBtn.Enabled = false;
            }
            else if (compDrawIndex == 012)
            {
                thinkLabel.Text = "Thinking...";
                thinkLabel.Visible = true;
                this.Update();
                System.Threading.Thread.Sleep(1000);
                PcomputerCard1.Checked = true;
                System.Threading.Thread.Sleep(1000);
                PcomputerCard2.Checked = true;
                System.Threading.Thread.Sleep(1000);
                PcomputerCard3.Checked = true;
                thinkLabel.Visible = false;
                DrawBtn.Enabled = false;
            }
            else if (compDrawIndex == 4)
            {
                thinkLabel.Text = "Thinking...";
                thinkLabel.Visible = true;
                this.Update();
                System.Threading.Thread.Sleep(1000);
                PcomputerCard5.Checked = true;
                System.Threading.Thread.Sleep(1000);
                thinkLabel.Visible = false;
                DrawBtn.Enabled = false;
            }
            else if (compDrawIndex == 2)
            {
                thinkLabel.Text = "Thinking...";
                thinkLabel.Visible = true;
                this.Update();
                System.Threading.Thread.Sleep(1000);
                PcomputerCard3.Checked = true;
                System.Threading.Thread.Sleep(1000);
                thinkLabel.Visible = false;
                DrawBtn.Enabled = false;
            }
            else if (compDrawIndex == 0)
            {
                thinkLabel.Text = "Thinking...";
                thinkLabel.Visible = true;
                this.Update();
                System.Threading.Thread.Sleep(1000);
                PcomputerCard1.Checked = true;
                System.Threading.Thread.Sleep(1000);
                thinkLabel.Visible = false;
                DrawBtn.Enabled = false;
            }
            else if (compDrawIndex == 14)
            {
                thinkLabel.Text = "Thinking...";
                thinkLabel.Visible = true;
                this.Update();
                System.Threading.Thread.Sleep(1000);
                PcomputerCard1.Checked = true;
                System.Threading.Thread.Sleep(1000);
                PcomputerCard5.Checked = true;
                System.Threading.Thread.Sleep(1000);
                thinkLabel.Visible = false;
                DrawBtn.Enabled = false;
            }

            else if (compDrawIndex == 1)
            {
                thinkLabel.Text = "Thinking...";
                thinkLabel.Visible = true;
                this.Update();
                System.Threading.Thread.Sleep(1000);
                PcomputerCard1.Checked = true;
                System.Threading.Thread.Sleep(1000);
                PcomputerCard2.Checked = true;
                System.Threading.Thread.Sleep(1000);
                thinkLabel.Visible = false;
                DrawBtn.Enabled = false;
            }
            else if (compDrawIndex == -1)
            {
                thinkLabel.Text = "Thinking...";
                thinkLabel.Visible = true;
                this.Update();
                System.Threading.Thread.Sleep(1000);
                PcomputerCard1.Checked = true;
                System.Threading.Thread.Sleep(1000);
                PcomputerCard3.Checked = true;
                System.Threading.Thread.Sleep(1000);
                thinkLabel.Visible = false;
                DrawBtn.Enabled = false;
            }
            if (PcomputerCard1.Checked)
            {
                
                PcomputerCard1.Location = new Point(42, 12);
                PcomputerCard1.FlatAppearance.BorderSize = 0;
                PcomputerCard1.Checked = false;
                
            }
            if (PcomputerCard2.Checked)
            {
                
                PcomputerCard2.Location = new Point(163, 12);
                PcomputerCard2.FlatAppearance.BorderSize = 0;
                PcomputerCard2.Checked = false;
                
            }
            if (PcomputerCard3.Checked)
            {
                
                PcomputerCard3.Location = new Point(291, 12);
                PcomputerCard3.FlatAppearance.BorderSize = 0;
                PcomputerCard3.Checked = false;
                
            }
            if (PcomputerCard4.Checked)
            {
               
                PcomputerCard4.Location = new Point(415, 12);
                PcomputerCard4.FlatAppearance.BorderSize = 0;
                PcomputerCard4.Checked = false;
                
            }
            if (PcomputerCard5.Checked)
            {
                
                PcomputerCard5.Location = new Point(539, 12);
                PcomputerCard5.FlatAppearance.BorderSize = 0;
                PcomputerCard5.Checked = false;
                
            }
            PcomputerCard1.BackgroundImage = comp_hand[0].getImage();
            PcomputerCard2.BackgroundImage = comp_hand[1].getImage();
            PcomputerCard3.BackgroundImage = comp_hand[2].getImage();
            PcomputerCard4.BackgroundImage = comp_hand[3].getImage();
            PcomputerCard5.BackgroundImage = comp_hand[4].getImage();

            CompPanel.Enabled = true;
            PlayerPanel.Enabled = false;
            DrawClickCounter = DrawClickCounter + 1;

            if (DrawClickCounter >= 1)
            {

                CompPanel.Enabled = false;
                PlayerBetPanel.Enabled = true;
                PlayerBetLabel.Visible = true;

               



            }


        }

        private void DealBtn_Click(object sender, EventArgs e)
        {
            //string startupPath = System.AppDomain.CurrentDomain.BaseDirectory;
            //var pathItems = startupPath.Split(Path.DirectorySeparatorChar);
            //string projectPath = String.Join(Path.DirectorySeparatorChar.ToString(), pathItems.Take(pathItems.Length - 3));
            //string cardback = projectPath + "\\Card Images\\back of card.png";

            //// test of Hand class
            //player_hand = hand_ref.getnewHand();
            //hand_ref.sortHand(player_hand);
            //comp_hand = hand_ref.getcomputerHand();
            //hand_ref.sortHand(comp_hand);

            /*PBplayerCard1.Image = player_hand[0].getImage();
            PBplayerCard2.Image = player_hand[1].getImage();
            PBplayerCard3.Image = player_hand[2].getImage();
            PBplayerCard4.Image = player_hand[3].getImage();
            PBplayerCard5.Image = player_hand[4].getImage();*/

            game_state.PlayerDeal(out player_hand);
            game_state.CompDeal(out comp_hand);


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


            PcomputerCard1.BackgroundImage = comp_hand[0].getImage();
            PcomputerCard2.BackgroundImage = comp_hand[1].getImage();
            PcomputerCard3.BackgroundImage = comp_hand[2].getImage();
            PcomputerCard4.BackgroundImage = comp_hand[3].getImage();
            PcomputerCard5.BackgroundImage = comp_hand[4].getImage();

            playerStartingAmount = playerStartingAmount - 2;
            playerMoney.Text = playerStartingAmount.ToString();
            compStartingAmount = compStartingAmount - 2;
            compMoney.Text = compStartingAmount.ToString();
            moneyPotStartingAmount = moneyPotStartingAmount + 4;
            moneyPot.Text = moneyPotStartingAmount.ToString();


            DealBtn.Enabled = false;
            DealBtn.BackColor = Color.Gray;
            FoldBtn.Enabled = true;
            FoldBtn.BackColor = Color.Transparent;
            PlayerBetPanel.Enabled = true;

            PlayerBetLabel.Visible = true;

        }

        private void PplayerCard1_CheckedChanged(object sender, EventArgs e)
        {
            if (PplayerCard1.Checked)
            {
                PplayerCard1.Location = new Point(35, 14);
                PplayerCard1.FlatAppearance.BorderColor = Color.Cyan;
                PplayerCard1.FlatAppearance.BorderSize = 2;

            }
            else
            {
                PplayerCard1.Location = new Point(35, 44);

                PplayerCard1.FlatAppearance.BorderSize = 0;
            }
        }

        private void PplayerCard2_CheckedChanged(object sender, EventArgs e)
        {
            if (PplayerCard2.Checked)
            {
                PplayerCard2.Location = new Point(156, 14);
                PplayerCard2.FlatAppearance.BorderColor = Color.Cyan;
                PplayerCard2.FlatAppearance.BorderSize = 2;

            }
            else
            {
                PplayerCard2.Location = new Point(156, 44);

                PplayerCard2.FlatAppearance.BorderSize = 0;
            }
        }

        private void PplayerCard3_CheckedChanged(object sender, EventArgs e)
        {
            if (PplayerCard3.Checked)
            {
                PplayerCard3.Location = new Point(284, 14);
                PplayerCard3.FlatAppearance.BorderColor = Color.Cyan;
                PplayerCard3.FlatAppearance.BorderSize = 2;

            }
            else
            {
                PplayerCard3.Location = new Point(284, 44);

                PplayerCard3.FlatAppearance.BorderSize = 0;
            }
        }

        private void PplayerCard4_CheckedChanged(object sender, EventArgs e)
        {
            if (PplayerCard4.Checked)
            {
                PplayerCard4.Location = new Point(408, 14);
                PplayerCard4.FlatAppearance.BorderColor = Color.Cyan;
                PplayerCard4.FlatAppearance.BorderSize = 2;

            }
            else
            {
                PplayerCard4.Location = new Point(408, 44);

                PplayerCard4.FlatAppearance.BorderSize = 0;
            }
        }

        private void PplayerCard5_CheckedChanged(object sender, EventArgs e)
        {
            if (PplayerCard5.Checked)
            {
                PplayerCard5.Location = new Point(536, 14);
                PplayerCard5.FlatAppearance.BorderColor = Color.Cyan;
                PplayerCard5.FlatAppearance.BorderSize = 2;

            }
            else
            {
                PplayerCard5.Location = new Point(536, 44);

                PplayerCard5.FlatAppearance.BorderSize = 0;
            }
        }

        private void PcomputerCard1_CheckedChanged(object sender, EventArgs e)
        {
            if (PcomputerCard1.Checked)
            {
                PcomputerCard1.Location = new Point(42, 42);
                PcomputerCard1.FlatAppearance.BorderColor = Color.Cyan;
                PcomputerCard1.FlatAppearance.BorderSize = 2;
            }
            else
            {
                PcomputerCard1.Location = new Point(42, 12);

                PcomputerCard1.FlatAppearance.BorderSize = 0;
            }
        }

        private void PcomputerCard2_CheckedChanged(object sender, EventArgs e)
        {
            if (PcomputerCard2.Checked)
            {
                PcomputerCard2.Location = new Point(163, 42);
                PcomputerCard2.FlatAppearance.BorderColor = Color.Cyan;
                PcomputerCard2.FlatAppearance.BorderSize = 2;
            }
            else
            {
                PcomputerCard2.Location = new Point(163, 12);

                PcomputerCard2.FlatAppearance.BorderSize = 0;
            }
        }

        private void PcomputerCard3_CheckedChanged(object sender, EventArgs e)
        {
            if (PcomputerCard3.Checked)
            {
                PcomputerCard3.Location = new Point(291, 42);
                PcomputerCard3.FlatAppearance.BorderColor = Color.Cyan;
                PcomputerCard3.FlatAppearance.BorderSize = 2;
            }
            else
            {

                PcomputerCard3.Location = new Point(291, 12);

                PcomputerCard3.FlatAppearance.BorderSize = 0;
            }
        }

        private void PcomputerCard4_CheckedChanged(object sender, EventArgs e)
        {
            if (PcomputerCard4.Checked)
            {
                PcomputerCard4.Location = new Point(415, 42);
                PcomputerCard4.FlatAppearance.BorderColor = Color.Cyan;
                PcomputerCard4.FlatAppearance.BorderSize = 2;
            }
            else
            {
                PcomputerCard4.Location = new Point(415, 12);

                PcomputerCard4.FlatAppearance.BorderSize = 0;

            }
        }

        private void PcomputerCard5_CheckedChanged(object sender, EventArgs e)
        {
            if (PcomputerCard5.Checked)
            {
                PcomputerCard5.Location = new Point(543, 42);
                PcomputerCard5.FlatAppearance.BorderColor = Color.Cyan;
                PcomputerCard5.FlatAppearance.BorderSize = 2;
            }
            else
            {
                PcomputerCard5.Location = new Point(543, 12);

                PcomputerCard5.FlatAppearance.BorderSize = 0;
            }
        }

        private void Winner_Click(object sender, EventArgs e)
        {



        }

        private void CompBetButton_Click(object sender, EventArgs e)
        {
            CompBetLabel.Visible = false;
            thinkLabel.Visible = false;
            compStartingAmount = compStartingAmount - (Convert.ToInt32(Math.Round(CompBet.Value, 0)));
            compMoney.Text = compStartingAmount.ToString();
            moneyPotStartingAmount = moneyPotStartingAmount + (Convert.ToInt32(Math.Round(CompBet.Value, 0)));
            moneyPot.Text = moneyPotStartingAmount.ToString();


            CompBetPanel.Enabled = false;
            PlayerPanel.Enabled = true;
            DrawBtn.Enabled = true;
            DrawBtn.BackColor = Color.Transparent;
        

           

        }

        private void PlayerBetButton_Click(object sender, EventArgs e)
        {

            PlayerBetLabel.Visible = false;
            CompBetLabel.Text = "Computer's Bet!";
            CompBetLabel.Visible = true;
            this.Update();
            System.Threading.Thread.Sleep(1000);
            thinkLabel.Text = "Thinking...";
            thinkLabel.Visible = true;
            this.Update();

            playerStartingAmount = playerStartingAmount - (Convert.ToInt32(Math.Round(PlayerBet.Value, 0)));
            playerMoney.Text = playerStartingAmount.ToString();
            moneyPotStartingAmount = moneyPotStartingAmount + (Convert.ToInt32(Math.Round(PlayerBet.Value, 0)));
            moneyPot.Text = moneyPotStartingAmount.ToString();

            PlayerBetPanel.Enabled = false;
            CompBetPanel.Enabled = true;
            PbetClickCounter = PbetClickCounter + 1;



            System.Threading.Thread.Sleep(3000);
            CompBet.Value = PlayerBet.Value + computerGuy.generateBet(hand_rank.evalHand(comp_hand));
            CompBetButton.PerformClick();
            if (PbetClickCounter >= 2)
            {
                showdown();
            }


        }

        private void compMoney_Click(object sender, EventArgs e)
        {

        }

        private void showdown()
        {
            
                PlayerBetLabel.Visible = false;
                int playerscore = hand_rank.evalHand(player_hand);
                int compscore = hand_rank.evalHand(comp_hand);

                if (playerscore > compscore)
                {
                    Winner.Text = "Player Wins";
                }
                else if (compscore > playerscore)
                {
                    Winner2.Text = "Computer Wins";
                }
                else
                {
                    Winner.Text = "Chuck Norris Wins";
                    Winner2.Text = "Chuck Norris Wins";
                }

                String Player_Hand_Type = "Nothing";
                if (playerscore >= 1000 & playerscore < 2000)
                {
                    Player_Hand_Type = "Pair";
                }
                else if (playerscore >= 2000 & playerscore < 3000)
                {
                    Player_Hand_Type = "2 Pairs";
                }
                else if (playerscore >= 3000 & playerscore < 4000)
                {
                    Player_Hand_Type = "3 of a Kind";
                }
                else if (playerscore >= 4000 & playerscore < 5000)
                {
                    Player_Hand_Type = "Straight";
                }
                else if (playerscore >= 5000 & playerscore < 6000)
                {
                    Player_Hand_Type = "Flush";
                }
                else if (playerscore >= 6000 & playerscore < 7000)
                {
                    Player_Hand_Type = "Full House";
                }
                else if (playerscore >= 7000 & playerscore < 8000)
                {
                    Player_Hand_Type = "Four of a Kind";
                }
                else if (playerscore >= 8000 & playerscore < 9000)
                {
                    Player_Hand_Type = "Straight Flush";
                }
                else if (playerscore >= 9000)
                {
                    Player_Hand_Type = "Royal Flush";
                }
                PlayerHandLabel.Text = ("Hand:  " + Player_Hand_Type + "\r\n" + "Score:  " + playerscore.ToString());

                String handType = "Nothing";
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
                this.Update();
            
        }

        private async void FadeOut(Form o, int interval = 80)
        {
            //Object is fully visible. Fade it out
            while (o.Opacity > 0.0)
            {
                await Task.Delay(interval);
                o.Opacity -= 0.05;
            }
            o.Opacity = 0; //make fully invisible       
        }

    }
}