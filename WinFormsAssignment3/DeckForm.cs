using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAssignment3
{
    public partial class DeckForm : Form
    {
        private Deck _deck;

        public DeckForm(Deck deck)
        {
            InitializeComponent();
            _deck = deck;
            UpdateDeck();
        }

        private void DeckForm_Load(object sender, EventArgs e)
        {
            UpdateDeck();
        }

        public void UpdateDeck()
        {
            lstDeck.Items.Clear();
            if (_deck == null) return;

            for (int i = 0; i < _deck.Count; i++)
            {
                lstDeck.Items.Add(_deck.GetCard(i));
            }
        }

        private void lstDeck_SelectedIndexChanged(object sender, EventArgs e)
        {
            Card? card = (Card?)lstDeck.SelectedItem;
            picSelectedCard.Image = card?.CardImage;
        }

        private void lblCards_Click(object sender, EventArgs e)
        {

        }
    }
}
