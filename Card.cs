using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    public class Card
    {
        Image[] card_array;
        private static Random rng = new Random();
        public Card()
        {
            card_array = setCard();
        }

        private Image[] setCard()
        {


            string startupPath = System.AppDomain.CurrentDomain.BaseDirectory;
            var pathItems = startupPath.Split(Path.DirectorySeparatorChar);
            string projectPath = String.Join(Path.DirectorySeparatorChar.ToString(), pathItems.Take(pathItems.Length - 3));
            string testFolderPath = projectPath + "\\Card Images\\";


            /// how can we make this portable? -- use only file path contained in project folder
            //string[] file_names= Directory.GetFiles(@"C:\Users\Robert\Source\Workspaces\Five Card Draw Group Four\Master\Game\Resources\", "*.png").Select(Path.GetFileName).ToArray();
            string[] file_names = Directory.GetFiles(testFolderPath, "*.png").Select(Path.GetFileName).ToArray();
            Image[] card_array = new Image[52];
            for (int i = 0; i < card_array.Length; i++)
            {
                if (!file_names[i].Equals("red_joker.png") && !file_names[i].Equals("black_joker.png"))
                {
                    card_array[i] = new Bitmap(testFolderPath + file_names[i]);
                }
            }
            return card_array;
        }

        public Image[] getCard()
        {
            return new Random().ShuffleCards(card_array);
        }

        public int random_number()
        {
            
            return rng.Next(0, 51);
            
        }




    }
}
