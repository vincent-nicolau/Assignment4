namespace Assignment4
{
    partial class DeckForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCards = new Label();
            lstDeck = new ListBox();
            picSelectedCard = new PictureBox();
            btnUp = new Button();
            btnDown = new Button();
            ((System.ComponentModel.ISupportInitialize)picSelectedCard).BeginInit();
            SuspendLayout();
            // 
            // lblCards
            // 
            lblCards.AutoSize = true;
            lblCards.Location = new Point(30, 32);
            lblCards.Name = "lblCards";
            lblCards.Size = new Size(37, 15);
            lblCards.TabIndex = 0;
            lblCards.Text = "&Cards";
            lblCards.Click += lblCards_Click;
            // 
            // lstDeck
            // 
            lstDeck.FormattingEnabled = true;
            lstDeck.ItemHeight = 15;
            lstDeck.Location = new Point(30, 50);
            lstDeck.Name = "lstDeck";
            lstDeck.Size = new Size(225, 319);
            lstDeck.TabIndex = 1;
            lstDeck.SelectedIndexChanged += lstDeck_SelectedIndexChanged;
            // 
            // picSelectedCard
            // 
            picSelectedCard.Location = new Point(320, 190);
            picSelectedCard.Name = "picSelectedCard";
            picSelectedCard.Size = new Size(100, 145);
            picSelectedCard.TabIndex = 2;
            picSelectedCard.TabStop = false;
            // 
            // btnUp
            // 
            btnUp.Location = new Point(320, 50);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(100, 40);
            btnUp.TabIndex = 3;
            btnUp.Text = "&Up";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // btnDown
            // 
            btnDown.Location = new Point(320, 119);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(100, 40);
            btnDown.TabIndex = 4;
            btnDown.Text = "&Down";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += btnDown_Click;
            // 
            // DeckForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 413);
            Controls.Add(btnDown);
            Controls.Add(btnUp);
            Controls.Add(picSelectedCard);
            Controls.Add(lstDeck);
            Controls.Add(lblCards);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeckForm";
            Text = "Deck";
            ((System.ComponentModel.ISupportInitialize)picSelectedCard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCards;
        private ListBox lstDeck;
        private PictureBox picSelectedCard;
        private Button btnUp;
        private Button btnDown;
    }
}