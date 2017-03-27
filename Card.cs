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
        Image image = null;
        int suit = 0;
        int face = 0;

        public Card()
        {
            // no args constructor
        }

        public Image getImage()
        {
            return image;
        }

        public void setImage(Image image)
        {
            this.image = image;
        }

        public int getFace()
        {
            return this.face;
        }

        public void setFace(int face)
        {
            this.face = face;
        }

        public int getSuit()
        {
            return this.suit;
        }

        public void setSuit(int suit)
        {
            this.suit = suit;
        }
    }
}
