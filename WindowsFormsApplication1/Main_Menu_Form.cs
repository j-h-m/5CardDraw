using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;


namespace WindowsFormsApplication2
{
    public partial class Main_Menu_Form : Form
    {
        public Main_Menu_Form()
        {
            InitializeComponent();
        }

        private void new_game_button_Click(object sender, EventArgs e)
        {
            GameBoard brd = new GameBoard();


            brd.Show();
            

            this.Hide();


        }

        private void continue_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statistics_button_Click(object sender, EventArgs e)
        {

        }

        private void exit_game_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settings_picture_Click(object sender, EventArgs e)
        {
            this.Hide();

            Settings_Menu_Form frm = new Settings_Menu_Form();
            frm.Show();
        }
    }
}
