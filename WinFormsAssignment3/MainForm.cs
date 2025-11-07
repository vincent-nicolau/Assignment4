using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace WinFormsAssignment3;

public partial class MainForm : Form
{
    private Deck deck;
    private Card[] hand = new Card[5];
    private const int NO_CARD = -1;

    public MainForm()
    {
        InitializeComponent();
        // create Deck after InitializeComponent so cardsImageList (created in Designer) is available
        deck = new Deck(cardsImageList);

        // initialize hand with sentinel cards so save/load won't hit nulls
        for (int i = 0; i < hand.Length; i++)
        {
            hand[i] = new Card(NO_CARD);
        }
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        // starting hand
        ReshuffleDeck();
        for (int i = 0; i < hand.Length; i++)
        {
            DealCard(i);
        }
        UpdateHandPics();
    }

    private void DealCard(int pos)
    {
        if (pos < 0)
        {
            return;
        }

        if (pos >= hand.Length)
        {
            return;
        }

        // use Deck.DealCard() and store the Card into the hand array
        Card dealt = deck.DealCard();
        hand[pos] = dealt;
    }

    private void ReshuffleDeck()
    {
        // repopulate and shuffle the deck
        deck.Shuffle();
    }

    private bool IsRedraw()
    {
        return keep1CheckBox.Checked ||
            keep2CheckBox.Checked ||
            keep3CheckBox.Checked ||
            keep4CheckBox.Checked ||
            keep5CheckBox.Checked;
    }

    private void dealButton_Click(object sender, EventArgs e)
    {
        // if we aren't redrawing reshuffle the deck to start fresh
        if (!IsRedraw())
        {
            ReshuffleDeck();
        }

        // deal out the cards
        if (!keep1CheckBox.Checked)
        {
            DealCard(0);
        }

        if (!keep2CheckBox.Checked)
        {
            DealCard(1);
        }

        if (!keep3CheckBox.Checked)
        {
            DealCard(2);
        }

        if (!keep4CheckBox.Checked)
        {
            DealCard(3);
        }

        if (!keep5CheckBox.Checked)
        {
            DealCard(4);
        }

        UpdateHandPics();
        ResetKeepCheckboxes();
    }

    private void ResetKeepCheckboxes()
    {
        keep1CheckBox.Checked = false;
        keep2CheckBox.Checked = false;
        keep3CheckBox.Checked = false;
        keep4CheckBox.Checked = false;
        keep5CheckBox.Checked = false;
    }

    private void UpdateHandPics()
    {
        hand1PictureBox.Image = null;
        if (hand[0] != null && (hand[0].Id > NO_CARD) && (hand[0].Id < cardsImageList.Images.Count))
        {
            hand1PictureBox.Image = cardsImageList.Images[hand[0].Id];
        }

        hand2PictureBox.Image = null;
        if (hand[1] != null && (hand[1].Id > NO_CARD) && (hand[1].Id < cardsImageList.Images.Count))
        {
            hand2PictureBox.Image = cardsImageList.Images[hand[1].Id];
        }

        hand3PictureBox.Image = null;
        if (hand[2] != null && (hand[2].Id > NO_CARD) && (hand[2].Id < cardsImageList.Images.Count))
        {
            hand3PictureBox.Image = cardsImageList.Images[hand[2].Id];
        }

        hand4PictureBox.Image = null;
        if (hand[3] != null && (hand[3].Id > NO_CARD) && (hand[3].Id < cardsImageList.Images.Count))
        {
            hand4PictureBox.Image = cardsImageList.Images[hand[3].Id];
        }

        hand5PictureBox.Image = null;
        if (hand[4] != null && (hand[4].Id > NO_CARD) && (hand[4].Id < cardsImageList.Images.Count))
        {
            hand5PictureBox.Image = cardsImageList.Images[hand[4].Id];
        }
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        // call Deck.SaveHand; Deck implementation manages dialogs
        deck.SaveHand(string.Empty, hand);
    }

    private void hand1PictureBox_Click(object sender, EventArgs e)
    {
        keep1CheckBox.Checked = !keep1CheckBox.Checked;
    }

    private void hand2PictureBox_Click(object sender, EventArgs e)
    {
        keep2CheckBox.Checked = !keep2CheckBox.Checked;
    }

    private void hand3PictureBox_Click(object sender, EventArgs e)
    {
        keep3CheckBox.Checked = !keep3CheckBox.Checked;
    }

    private void hand4PictureBox_Click(object sender, EventArgs e)
    {
        keep4CheckBox.Checked = !keep4CheckBox.Checked;
    }

    private void hand5PictureBox_Click(object sender, EventArgs e)
    {
        keep5CheckBox.Checked = !keep5CheckBox.Checked;
    }

    private void loadButton_Click(object sender, EventArgs e)
    {
        // call Deck.LoadHand; Deck implementation manages dialogs
        deck.LoadHand(string.Empty, hand);
        UpdateHandPics();
    }
}