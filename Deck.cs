using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace WindowsFormsApplication1
{
    public class Deck
    {
        Card[] card_array = null;
        String[] card_names = null;
        Stack<Card> deck = new Stack<Card>();

        public Deck()
        {
            card_array = buildCardArray();
            deck = buildDeck();
        }

        public Card[] buildCardArray()
        {
            // local path
            string startupPath = System.AppDomain.CurrentDomain.BaseDirectory;
            var pathItems = startupPath.Split(Path.DirectorySeparatorChar);
            string projectPath = String.Join(Path.DirectorySeparatorChar.ToString(), pathItems.Take(pathItems.Length - 3));
            string testFolderPath = projectPath + "\\Card Images\\";

            string[] card_names = Directory.GetFiles(testFolderPath, "*.png").Select(Path.GetFileName).ToArray();
            Card[] card_array = new Card[52];

            for (int i = 0; i < card_array.Length; i++)
            {
                card_array[i] = new Card();
            }

            for (int i = 0; i < card_names.Length; i++)
            {
                switch (card_names[i])
                {
                    case "2_of_clubs":
                        card_array[i].setFace(20);
                        card_array[i].setSuit(1);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "2_of_diamonds":
                        card_array[i].setFace(20);
                        card_array[i].setSuit(2);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "2_of_hearts":
                        card_array[i].setFace(20);
                        card_array[i].setSuit(3);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "2_of_spades":
                        card_array[i].setFace(20);
                        card_array[i].setSuit(4);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    // face card -- 3
                    case "3_of_clubs":
                        card_array[i].setFace(30);
                        card_array[i].setSuit(1);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "3_of_diamonds":
                        card_array[i].setFace(30);
                        card_array[i].setSuit(2);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "3_of_hearts":
                        card_array[i].setFace(30);
                        card_array[i].setSuit(3);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "3_of_spades":
                        card_array[i].setFace(30);
                        card_array[i].setSuit(4);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    // face card -- 4
                    case "4_of_clubs":
                        card_array[i].setFace(40);
                        card_array[i].setSuit(1);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "4_of_diamonds":
                        card_array[i].setFace(40);
                        card_array[i].setSuit(2);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "4_of_hearts":
                        card_array[i].setFace(40);
                        card_array[i].setSuit(3);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "4_of_spades":
                        card_array[i].setFace(40);
                        card_array[i].setSuit(4);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    // face card -- 5
                    case "5_of_clubs":
                        card_array[i].setFace(50);
                        card_array[i].setSuit(1);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "5_of_diamonds":
                        card_array[i].setFace(50);
                        card_array[i].setSuit(2);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "5_of_hearts":
                        card_array[i].setFace(50);
                        card_array[i].setSuit(3);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "5_of_spades":
                        card_array[i].setFace(50);
                        card_array[i].setSuit(4);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    // face card -- 6
                    case "6_of_clubs":
                        card_array[i].setFace(60);
                        card_array[i].setSuit(1);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "6_of_diamonds":
                        card_array[i].setFace(60);
                        card_array[i].setSuit(2);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "6_of_hearts":
                        card_array[i].setFace(60);
                        card_array[i].setSuit(3);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "6_of_spades":
                        card_array[i].setFace(60);
                        card_array[i].setSuit(4);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    // face card -- 7
                    case "7_of_clubs":
                        card_array[i].setFace(70);
                        card_array[i].setSuit(1);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "7_of_diamonds":
                        card_array[i].setFace(70);
                        card_array[i].setSuit(2);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "7_of_hearts":
                        card_array[i].setFace(70);
                        card_array[i].setSuit(3);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "7_of_spades":
                        card_array[i].setFace(70);
                        card_array[i].setSuit(4);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    // face card -- 8
                    case "8_of_clubs":
                        card_array[i].setFace(80);
                        card_array[i].setSuit(1);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "8_of_diamonds":
                        card_array[i].setFace(80);
                        card_array[i].setSuit(2);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "8_of_hearts":
                        card_array[i].setFace(80);
                        card_array[i].setSuit(3);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "8_of_spades":
                        card_array[i].setFace(80);
                        card_array[i].setSuit(4);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    // face card -- 9
                    case "9_of_clubs":
                        card_array[i].setFace(90);
                        card_array[i].setSuit(1);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "9_of_diamonds":
                        card_array[i].setFace(90);
                        card_array[i].setSuit(2);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "9_of_hearts":
                        card_array[i].setFace(90);
                        card_array[i].setSuit(3);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "9_of_spades":
                        card_array[i].setFace(90);
                        card_array[i].setSuit(4);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    // face card -- 10
                    case "10_of_clubs":
                        card_array[i].setFace(100);
                        card_array[i].setSuit(1);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "10_of_diamonds":
                        card_array[i].setFace(100);
                        card_array[i].setSuit(2);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "10_of_hearts":
                        card_array[i].setFace(100);
                        card_array[i].setSuit(3);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "10_of_spades":
                        card_array[i].setFace(100);
                        card_array[i].setSuit(4);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    // face card -- Jack
                    case "jack_of_clubs2":
                        card_array[i].setFace(110);
                        card_array[i].setSuit(1);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "jack_of_diamonds2":
                        card_array[i].setFace(110);
                        card_array[i].setSuit(2);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));

                        break;
                    case "jack_of_hearts2":
                        card_array[i].setFace(110);
                        card_array[i].setSuit(3);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "jack_of_spades2":
                        card_array[i].setFace(110);
                        card_array[i].setSuit(4);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    // face card -- Queen
                    case "queen_of_clubs2":
                        card_array[i].setFace(120);
                        card_array[i].setSuit(1);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "queen_of_diamonds2":
                        card_array[i].setFace(120);
                        card_array[i].setSuit(2);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "queen_of_hearts2":
                        card_array[i].setFace(120);
                        card_array[i].setSuit(3);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "queen_of_spades2":
                        card_array[i].setFace(120);
                        card_array[i].setSuit(4);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    // face card -- King
                    case "king_of_clubs2":
                        card_array[i].setFace(120);
                        card_array[i].setSuit(1);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "king_of_diamonds2":
                        card_array[i].setFace(120);
                        card_array[i].setSuit(2);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "king_of_hearts2":
                        card_array[i].setFace(120);
                        card_array[i].setSuit(3);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "king_of_spades2":
                        card_array[i].setFace(120);
                        card_array[i].setSuit(4);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    // face card -- Ace
                    case "ace_of_clubs":
                        card_array[i].setFace(120);
                        card_array[i].setSuit(1);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "ace_of_diamonds":
                        card_array[i].setFace(120);
                        card_array[i].setSuit(2);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "ace_of_hearts":
                        card_array[i].setFace(120);
                        card_array[i].setSuit(3);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    case "ace_of_spades":
                        card_array[i].setFace(120);
                        card_array[i].setSuit(4);
                        card_array[i].setImage(new Bitmap(testFolderPath + card_names[i]));
                        break;
                    default:
                        break;
                }
            }
            return card_array;
        }

        //return array of cards
        public Card[] getCardArray()
        {
            return card_array;
        }

        public Stack<Card> buildDeck()
        {
            Stack<Card> temp_stack = new Stack<Card>();
            foreach (Card c in card_array)
            {
                temp_stack.Push(c);
            }
            return temp_stack;
        }

        //return Stack of cards
        public Stack<Card> getDeck()
        {
            return deck;
        }
    }
}
