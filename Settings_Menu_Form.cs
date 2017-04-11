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
    public partial class Settings_Menu_Form : Form
    {
        public Settings_Menu_Form()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Main_Menu_Form frm = new Main_Menu_Form();
            frm.Show();
            this.Hide();
        }
    }
}
