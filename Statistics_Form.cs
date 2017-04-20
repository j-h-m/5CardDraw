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
    public partial class Statistics_Form : Form
    {

        Statistics stat = new Statistics();
        public Statistics_Form()
        {
            InitializeComponent();
            setGrid();
        }
        public void setGrid()
        {
            //Set the DataSource of DataGridView to the DataTable
           
            statGrid.DataSource =stat.getDataTable();
        }
       

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
