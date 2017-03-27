using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication1
{
    static class Shuffle
    {
        public static Image[] ShuffleCards<Image>(this Random rng, Image[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                Image temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
            return array;
        }
    }
}
