namespace Assignment4;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        cardsImageList = new ImageList(components);
        hand1PictureBox = new PictureBox();
        dealButton = new Button();
        hand5PictureBox = new PictureBox();
        hand4PictureBox = new PictureBox();
        hand3PictureBox = new PictureBox();
        hand2PictureBox = new PictureBox();
        keep1CheckBox = new CheckBox();
        keep2CheckBox = new CheckBox();
        keep3CheckBox = new CheckBox();
        keep4CheckBox = new CheckBox();
        keep5CheckBox = new CheckBox();
        saveButton = new Button();
        loadButton = new Button();
        openFileDialog = new OpenFileDialog();
        saveFileDialog = new SaveFileDialog();
        showButton = new Button();
        ((System.ComponentModel.ISupportInitialize)hand1PictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)hand5PictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)hand4PictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)hand3PictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)hand2PictureBox).BeginInit();
        SuspendLayout();
        // 
        // cardsImageList
        // 
        cardsImageList.ColorDepth = ColorDepth.Depth32Bit;
        cardsImageList.ImageStream = (ImageListStreamer)resources.GetObject("cardsImageList.ImageStream");
        cardsImageList.TransparentColor = Color.Transparent;
        cardsImageList.Images.SetKeyName(0, "King of Clubs");
        cardsImageList.Images.SetKeyName(1, "Ace of Clubs");
        cardsImageList.Images.SetKeyName(2, "Two of Clubs");
        cardsImageList.Images.SetKeyName(3, "Three of Clubs");
        cardsImageList.Images.SetKeyName(4, "Four of Clubs");
        cardsImageList.Images.SetKeyName(5, "Five of Clubs");
        cardsImageList.Images.SetKeyName(6, "Six of Clubs");
        cardsImageList.Images.SetKeyName(7, "Seven of Clubs");
        cardsImageList.Images.SetKeyName(8, "Eight of Clubs");
        cardsImageList.Images.SetKeyName(9, "Nine of Clubs");
        cardsImageList.Images.SetKeyName(10, "Ten of Clubs");
        cardsImageList.Images.SetKeyName(11, "Jack of Clubs");
        cardsImageList.Images.SetKeyName(12, "Queen of Clubs");
        cardsImageList.Images.SetKeyName(13, "King of Diamonds");
        cardsImageList.Images.SetKeyName(14, "Ace of Diamonds");
        cardsImageList.Images.SetKeyName(15, "Two  of Diamonds");
        cardsImageList.Images.SetKeyName(16, "Three of Diamonds");
        cardsImageList.Images.SetKeyName(17, "Four of Diamonds");
        cardsImageList.Images.SetKeyName(18, "Five of Diamonds");
        cardsImageList.Images.SetKeyName(19, "Six of Diamonds");
        cardsImageList.Images.SetKeyName(20, "Seven of Diamonds");
        cardsImageList.Images.SetKeyName(21, "Eight of Diamonds");
        cardsImageList.Images.SetKeyName(22, "Nine of Diamonds");
        cardsImageList.Images.SetKeyName(23, "Ten of Diamonds");
        cardsImageList.Images.SetKeyName(24, "Jack of Diamonds");
        cardsImageList.Images.SetKeyName(25, "Queen of Diamonds");
        cardsImageList.Images.SetKeyName(26, "King of Hearts");
        cardsImageList.Images.SetKeyName(27, "Ace of Hearts");
        cardsImageList.Images.SetKeyName(28, "Two of Hearts");
        cardsImageList.Images.SetKeyName(29, "Three of Hearts");
        cardsImageList.Images.SetKeyName(30, "Four of Hearts");
        cardsImageList.Images.SetKeyName(31, "Five of Hearts");
        cardsImageList.Images.SetKeyName(32, "Six of Hearts");
        cardsImageList.Images.SetKeyName(33, "Seven of Hearts");
        cardsImageList.Images.SetKeyName(34, "Eight of Hearts");
        cardsImageList.Images.SetKeyName(35, "Nine of Hearts");
        cardsImageList.Images.SetKeyName(36, "Ten of Hearts");
        cardsImageList.Images.SetKeyName(37, "Jack of Hearts");
        cardsImageList.Images.SetKeyName(38, "Queen of Hearts");
        cardsImageList.Images.SetKeyName(39, "King of Spades");
        cardsImageList.Images.SetKeyName(40, "Ace of Spades");
        cardsImageList.Images.SetKeyName(41, "Two of Spades");
        cardsImageList.Images.SetKeyName(42, "Three of Spades");
        cardsImageList.Images.SetKeyName(43, "Four of Spades");
        cardsImageList.Images.SetKeyName(44, "Five of Spades");
        cardsImageList.Images.SetKeyName(45, "Six of Spades");
        cardsImageList.Images.SetKeyName(46, "Seven of Spades");
        cardsImageList.Images.SetKeyName(47, "Eight of Spades");
        cardsImageList.Images.SetKeyName(48, "Nine of Spades");
        cardsImageList.Images.SetKeyName(49, "Ten of Spades");
        cardsImageList.Images.SetKeyName(50, "Jack of Spades");
        cardsImageList.Images.SetKeyName(51, "Queen of Spades");
        // 
        // hand1PictureBox
        // 
        hand1PictureBox.Location = new Point(49, 143);
        hand1PictureBox.Margin = new Padding(3, 2, 3, 2);
        hand1PictureBox.Name = "hand1PictureBox";
        hand1PictureBox.Size = new Size(100, 145);
        hand1PictureBox.TabIndex = 2;
        hand1PictureBox.TabStop = false;
        hand1PictureBox.Click += hand1PictureBox_Click;
        // 
        // dealButton
        // 
        dealButton.Location = new Point(49, 29);
        dealButton.Margin = new Padding(3, 2, 3, 2);
        dealButton.Name = "dealButton";
        dealButton.Size = new Size(100, 50);
        dealButton.TabIndex = 0;
        dealButton.Text = "&Deal";
        dealButton.UseVisualStyleBackColor = true;
        dealButton.Click += dealButton_Click;
        // 
        // hand5PictureBox
        // 
        hand5PictureBox.Location = new Point(672, 143);
        hand5PictureBox.Margin = new Padding(3, 2, 3, 2);
        hand5PictureBox.Name = "hand5PictureBox";
        hand5PictureBox.Size = new Size(100, 145);
        hand5PictureBox.TabIndex = 6;
        hand5PictureBox.TabStop = false;
        hand5PictureBox.Click += hand5PictureBox_Click;
        // 
        // hand4PictureBox
        // 
        hand4PictureBox.Location = new Point(516, 143);
        hand4PictureBox.Margin = new Padding(3, 2, 3, 2);
        hand4PictureBox.Name = "hand4PictureBox";
        hand4PictureBox.Size = new Size(100, 145);
        hand4PictureBox.TabIndex = 7;
        hand4PictureBox.TabStop = false;
        hand4PictureBox.Click += hand4PictureBox_Click;
        // 
        // hand3PictureBox
        // 
        hand3PictureBox.Location = new Point(360, 143);
        hand3PictureBox.Margin = new Padding(3, 2, 3, 2);
        hand3PictureBox.Name = "hand3PictureBox";
        hand3PictureBox.Size = new Size(100, 145);
        hand3PictureBox.TabIndex = 8;
        hand3PictureBox.TabStop = false;
        hand3PictureBox.Click += hand3PictureBox_Click;
        // 
        // hand2PictureBox
        // 
        hand2PictureBox.Location = new Point(205, 143);
        hand2PictureBox.Margin = new Padding(3, 2, 3, 2);
        hand2PictureBox.Name = "hand2PictureBox";
        hand2PictureBox.Size = new Size(100, 145);
        hand2PictureBox.TabIndex = 9;
        hand2PictureBox.TabStop = false;
        hand2PictureBox.Click += hand2PictureBox_Click;
        // 
        // keep1CheckBox
        // 
        keep1CheckBox.AutoSize = true;
        keep1CheckBox.Location = new Point(49, 115);
        keep1CheckBox.Margin = new Padding(3, 2, 3, 2);
        keep1CheckBox.Name = "keep1CheckBox";
        keep1CheckBox.Size = new Size(61, 19);
        keep1CheckBox.TabIndex = 4;
        keep1CheckBox.Text = "Keep &1";
        keep1CheckBox.UseVisualStyleBackColor = true;
        // 
        // keep2CheckBox
        // 
        keep2CheckBox.AutoSize = true;
        keep2CheckBox.Location = new Point(205, 112);
        keep2CheckBox.Margin = new Padding(3, 2, 3, 2);
        keep2CheckBox.Name = "keep2CheckBox";
        keep2CheckBox.Size = new Size(61, 19);
        keep2CheckBox.TabIndex = 5;
        keep2CheckBox.Text = "Keep &2";
        keep2CheckBox.UseVisualStyleBackColor = true;
        // 
        // keep3CheckBox
        // 
        keep3CheckBox.AutoSize = true;
        keep3CheckBox.Location = new Point(360, 112);
        keep3CheckBox.Margin = new Padding(3, 2, 3, 2);
        keep3CheckBox.Name = "keep3CheckBox";
        keep3CheckBox.Size = new Size(61, 19);
        keep3CheckBox.TabIndex = 6;
        keep3CheckBox.Text = "Keep &3";
        keep3CheckBox.UseVisualStyleBackColor = true;
        // 
        // keep4CheckBox
        // 
        keep4CheckBox.AutoSize = true;
        keep4CheckBox.Location = new Point(516, 112);
        keep4CheckBox.Margin = new Padding(3, 2, 3, 2);
        keep4CheckBox.Name = "keep4CheckBox";
        keep4CheckBox.Size = new Size(61, 19);
        keep4CheckBox.TabIndex = 7;
        keep4CheckBox.Text = "Keep &4";
        keep4CheckBox.UseVisualStyleBackColor = true;
        // 
        // keep5CheckBox
        // 
        keep5CheckBox.AutoSize = true;
        keep5CheckBox.Location = new Point(672, 112);
        keep5CheckBox.Margin = new Padding(3, 2, 3, 2);
        keep5CheckBox.Name = "keep5CheckBox";
        keep5CheckBox.Size = new Size(61, 19);
        keep5CheckBox.TabIndex = 8;
        keep5CheckBox.Text = "Keep &5";
        keep5CheckBox.UseVisualStyleBackColor = true;
        // 
        // saveButton
        // 
        saveButton.Location = new Point(516, 29);
        saveButton.Margin = new Padding(3, 2, 3, 2);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(100, 50);
        saveButton.TabIndex = 2;
        saveButton.Text = "&Save Hand";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += saveButton_Click;
        // 
        // loadButton
        // 
        loadButton.Location = new Point(672, 29);
        loadButton.Margin = new Padding(3, 2, 3, 2);
        loadButton.Name = "loadButton";
        loadButton.Size = new Size(100, 50);
        loadButton.TabIndex = 3;
        loadButton.Text = "&Load Hand";
        loadButton.UseVisualStyleBackColor = true;
        loadButton.Click += loadButton_Click;
        // 
        // openFileDialog
        // 
        openFileDialog.FileName = "openFileDialog1";
        // 
        // showButton
        // 
        showButton.Location = new Point(360, 29);
        showButton.Name = "showButton";
        showButton.Size = new Size(100, 50);
        showButton.TabIndex = 10;
        showButton.Text = "S&how Deck";
        showButton.UseVisualStyleBackColor = true;
        showButton.Click += showButton_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(833, 358);
        Controls.Add(showButton);
        Controls.Add(loadButton);
        Controls.Add(saveButton);
        Controls.Add(keep5CheckBox);
        Controls.Add(keep4CheckBox);
        Controls.Add(keep3CheckBox);
        Controls.Add(keep2CheckBox);
        Controls.Add(keep1CheckBox);
        Controls.Add(hand2PictureBox);
        Controls.Add(hand3PictureBox);
        Controls.Add(hand4PictureBox);
        Controls.Add(hand5PictureBox);
        Controls.Add(dealButton);
        Controls.Add(hand1PictureBox);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(3, 2, 3, 2);
        MaximizeBox = false;
        Name = "MainForm";
        Text = "Poker Hand Simulator";
        Load += MainForm_Load;
        ((System.ComponentModel.ISupportInitialize)hand1PictureBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)hand5PictureBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)hand4PictureBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)hand3PictureBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)hand2PictureBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    public ImageList cardsImageList;
    private PictureBox hand1PictureBox;
    private Button dealButton;
    private PictureBox hand5PictureBox;
    private PictureBox hand4PictureBox;
    private PictureBox hand3PictureBox;
    private PictureBox hand2PictureBox;
    private CheckBox keep1CheckBox;
    private CheckBox keep2CheckBox;
    private CheckBox keep3CheckBox;
    private CheckBox keep4CheckBox;
    private CheckBox keep5CheckBox;
    private Button saveButton;
    private Button loadButton;
    private OpenFileDialog openFileDialog;
    private SaveFileDialog saveFileDialog;
    private Button showButton;
}
