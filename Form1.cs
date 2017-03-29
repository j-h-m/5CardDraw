using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class GameBoard : Form
    {
        
        Deck myDeck = new Deck();
        Hand hand_ref = new Hand();
    
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
            Card[] player_hand = hand_ref.getplayerHand();
            hand_ref.sortHand(player_hand);
            Card[] comp_hand = hand_ref.getcomputerHand();

            PBplayerCard1.Image = player_hand[0].getImage();
            PBplayerCard2.Image = player_hand[1].getImage();
            PBplayerCard3.Image = player_hand[2].getImage();
            PBplayerCard4.Image = player_hand[3].getImage();
            PBplayerCard5.Image = player_hand[4].getImage();

            ComputerCard1.Image = Image.FromFile(cardback);
            ComputerCard2.Image = Image.FromFile(cardback);
            ComputerCard3.Image = Image.FromFile(cardback);
            ComputerCard4.Image = Image.FromFile(cardback);
            ComputerCard5.Image = Image.FromFile(cardback);

            moneyPot.Text = "$2.00";
            playerMoney.Text = "$99.00";
            computerMoney.Text = "$99.00";

            DealBtn.Enabled = false;
            DealBtn.BackColor = Color.Gray;
        }
    }
}