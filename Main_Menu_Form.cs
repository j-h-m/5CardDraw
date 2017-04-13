using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Main_Menu_Form : Form
    {

        public Main_Menu_Form()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void new_game_button_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Gameboard"];
            GameBoard brd = new GameBoard();
            brd.Show();

            if (fc != null)
            {
                fc.Close();
            }
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
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Application.OpenForms[i].Close();
            }
            this.Close();
            GC.Collect();
            Application.Exit();
        }

        private void settings_picture_Click(object sender, EventArgs e)
        {
            this.Hide();

            Settings_Menu_Form frm = new Settings_Menu_Form();
            frm.Show();
        }
    }
}
