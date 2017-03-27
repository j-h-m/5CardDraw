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
        Hand myHand = new Hand();
    
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
            /* Do something with random logic to ensure identical cards aren't drawn
             * occasionally draws 4
             *  */
            
            //Makes dat path all dynamic n'shit
            string startupPath = System.AppDomain.CurrentDomain.BaseDirectory;
            var pathItems = startupPath.Split(Path.DirectorySeparatorChar);
            string projectPath = String.Join(Path.DirectorySeparatorChar.ToString(), pathItems.Take(pathItems.Length - 3));
            string testFolderPath = projectPath + "\\Card Images\\back of card.png";

            PBplayerCard1.Image = myHand.getplayerHand()[0];
            PBplayerCard2.Image = myHand.getplayerHand()[1];
            PBplayerCard3.Image = myHand.getplayerHand()[2];
            PBplayerCard4.Image = myHand.getplayerHand()[3];
            PBplayerCard5.Image = myHand.getplayerHand()[4];

            
            ComputerCard1.Image = Image.FromFile(testFolderPath);
            ComputerCard2.Image = Image.FromFile(testFolderPath);
            ComputerCard3.Image = Image.FromFile(testFolderPath);
            ComputerCard4.Image = Image.FromFile(testFolderPath);
            ComputerCard5.Image = Image.FromFile(testFolderPath);

            moneyPot.Text = "$2.00";
            playerMoney.Text = "$99.00";
            computerMoney.Text = "$99.00";

            DealBtn.Enabled = false;
            DealBtn.BackColor = Color.Gray;


        }
    }
}