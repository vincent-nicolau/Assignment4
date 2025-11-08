using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace Assignment4;

public partial class MainForm : Form
{
    public Deck deck;
    private Card[] hand = new Card[5];
    private const int NO_CARD = -1;
    private DeckForm? deckForm;

    public MainForm()
    {
        InitializeComponent();
        // create Deck after InitializeComponent so cardsImageList (created in Designer) is available
        deck = new Deck(cardsImageList);

        // initialize hand with sentinel cards so save/load won't hit nulls
        for (int i = 0; i < hand.Length; i++)
        {
            hand[i] = Card.NO_CARD;
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
        deckForm?.UpdateDeck();
        hand[pos] = dealt;
    }

    private void ReshuffleDeck()
    {
        // repopulate and shuffle the deck
        deck.Shuffle();
        deckForm?.UpdateDeck();
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
    }

    private void UpdateHandPics()
    {
        hand1PictureBox.Image = hand[0].CardImage;
        hand2PictureBox.Image = hand[1].CardImage;
        hand3PictureBox.Image = hand[2].CardImage;
        hand4PictureBox.Image = hand[3].CardImage;
        hand5PictureBox.Image = hand[4].CardImage;
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
        deckForm?.UpdateDeck();
        UpdateHandPics();
    }

    private void showButton_Click(object sender, EventArgs e)
    {
        if (deckForm == null || deckForm.IsDisposed)
        {
            DeckForm deckForm = new DeckForm(deck);
            deckForm.ShowDialog(this);
        }
        try
        {
            if (!deckForm.Visible)
            {
                deckForm.Show(this);
            }
            else
            {
                deckForm.Activate();
            }
            deckForm.UpdateDeck();
        } catch (NullReferenceException)
        {

        }
    }
}