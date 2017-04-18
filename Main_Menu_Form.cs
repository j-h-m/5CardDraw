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
    public partial class Main_Menu_Form:Form
    {
        SaveGame oldGame = null;

        public Main_Menu_Form()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void new_game_button_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Gameboard"];
            GameBoard brd = new GameBoard("no path");
            brd.Show();
            

            if (fc != null)
            {
                fc.Close();
            }
            this.Hide();
            brd.FormClosing += brdClosing;
        
        }

        private void brdClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void continue_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseForSave = new OpenFileDialog();

            if (browseForSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = browseForSave.FileName;
                try
                {
                    // set oldGame to game save file data
                    oldGame = readFromBinaryFile<SaveGame>(fileName);

                    // open gameboard, close menu
                    Form fc = Application.OpenForms["Gameboard"];
                    GameBoard brd = new GameBoard(oldGame.getFilePath());
                    brd.Show();
                    if (fc != null)
                    {
                        fc.Close();
                    }
                    this.Hide();
                    brd.FormClosing += brdClosing;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("You must choose a game save file!", "Error");
                }
            }
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

        private void Wait(int segundos)
        {
            if (segundos < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(segundos);
            while (DateTime.Now < _desired)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }

        // for loading game
        public T readFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
    }
}
