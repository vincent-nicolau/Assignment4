using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WinFormsAssignment3
{
    public class Deck
    {
        private List<Card> cards;
        public ImageList imageList;
        // return current count of cards
        public int Count => cards?.Count ?? 0;
        private const string HANDS_FOLDER = @"C:\Users\vincent\source\repos\2024 fall c sharp class\WinFormsAssignment3\WinFormsAssignment3\hands\";
        private const string DEFAULT_EXT = "txt";
        private SaveFileDialog saveFileDialog = new SaveFileDialog();
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        public Deck(ImageList cardsImageList)
        {
            imageList = cardsImageList;
            cards = new List<Card>();
        }

        public Card GetCard(int index)
        {
            if (index >= 0 && index < cards.Count)
            {
                return cards[index];
            }
            return Card.NO_CARD;
        }
        public void Shuffle()
        {
            cards.Clear();

            // load deck from image list (pass the associated image to Card)
            for (int i = 0; i < imageList.Images.Count; i++)
            {
                cards.Add(new Card(i, imageList.Images[i], imageList.Images.Keys[i].ToString()));
            }

            // shuffle it
            Random rng = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }

        public Card DealCard()
        {
            if (cards == null || cards.Count == 0)
            {
                return Card.NO_CARD;
            }

            Card dealtCard = cards[0];
            cards.RemoveAt(0);
            return dealtCard;
        }

        public bool SaveHand(string filename, Card[] hand)
        {
            saveFileDialog.InitialDirectory = HANDS_FOLDER;
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = DEFAULT_EXT;
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return true;
            }

            try
            {
                using (StreamWriter writer = new(saveFileDialog.FileName))
                {
                    // save the Id of each Card in the hand array
                    foreach (Card card in hand)
                    {
                        writer.WriteLine(card.Id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        public bool LoadHand(string filename, Card[] hand)
        {
            openFileDialog.InitialDirectory = HANDS_FOLDER;
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return false;
            }

            try
            {
                using (StreamReader reader = new(openFileDialog.FileName))
                {
                    for (int i = 0; i < hand.Length; i++)
                    {
                        string? line = reader.ReadLine();
                        if (int.TryParse(line, out int id))
                        {
                            // create a new Card with the read Id
                            hand[i] = new Card(id, imageList.Images[id], imageList.Images.Keys[i].ToString());
                        }
                        else
                        {
                            hand[i] = Card.NO_CARD;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }
        public void SwapCards(int index1, int index2)
        {
            if (index1 < 0 || index1 >= cards.Count || index2 < 0 || index2 >= cards.Count)
            {
                return;
            }
            Card temp = cards[index1];
            cards[index1] = cards[index2];
            cards[index2] = temp;
        }
    }
}
