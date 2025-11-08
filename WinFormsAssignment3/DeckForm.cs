using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
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

        private void btnUp_Click(object sender, EventArgs e)
        {
            int newIndex;
            if (_deck == null) return;
            // can only move up if an item is selected and it's not already the first item
            if (lstDeck.SelectedIndex > 0 && lstDeck.SelectedIndex < _deck.Count)
            {
                _deck.SwapCards(lstDeck.SelectedIndex, lstDeck.SelectedIndex - 1);
                newIndex = lstDeck.SelectedIndex - 1;
                UpdateDeck();
                lstDeck.SetSelected(newIndex, true);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int newIndex;
            if (_deck == null) return;
            // can only move down if an item is selected and it's not the last item
            if (lstDeck.SelectedIndex >= 0 && lstDeck.SelectedIndex < _deck.Count - 1)
            {
                _deck.SwapCards(lstDeck.SelectedIndex, lstDeck.SelectedIndex + 1);
                newIndex = lstDeck.SelectedIndex + 1;
                UpdateDeck();
                lstDeck.SetSelected(newIndex, true);
            }
        }
    }
}
