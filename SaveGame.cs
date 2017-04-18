using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    [Serializable]
    class SaveGame
    {
        private Deck deck;
        private decimal pMoney, cMoney;
        private string filePath;

        public SaveGame(Deck oldDeck, decimal oldPlayMoney, decimal oldCompMoney, string saveFile)
        {
            deck = oldDeck;
            pMoney = oldPlayMoney;
            cMoney = oldCompMoney;
            filePath = saveFile;
        }

        public Deck getSavedDeck()
        {
            return deck;
        }

        public decimal getSavedPlayerMoney()
        {
            return pMoney;
        }

        public decimal getSavedComputerMoney()
        {
            return cMoney;
        }

        public string getFilePath()
        {
            return filePath;
        }
    }
}
