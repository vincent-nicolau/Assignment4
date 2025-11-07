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
    internal class Deck
    {
        private List<Card> cards;
        private ImageList imageList;
        private const string HANDS_FOLDER = @"C:\Users\vincent\source\repos\2024 fall c sharp class\WinFormsAssignment3\WinFormsAssignment3\hands\";
        private const string DEFAULT_EXT = "txt";
        private const int NO_CARD = -1;
        private SaveFileDialog saveFileDialog = new SaveFileDialog();
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        public Deck(ImageList cardsImageList)
        {
            imageList = cardsImageList;
            cards = new List<Card>();
        }
        public void Shuffle()
        {
            cards.Clear();

            // load deck from image list
            for (int i = 0; i < imageList.Images.Count; i++)
            {
                cards.Add(new Card(i));
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
                return new Card(NO_CARD);
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
                            hand[i] = new Card(id);
                        }
                        else
                        {
                            // when parse fails or line is missing, use sentinel Id
                            hand[i] = new Card(NO_CARD);
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
    }
}
