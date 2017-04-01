namespace WindowsFormsApplication1
{
    partial class GameBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoard));
            this.computerLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.FoldBtn = new System.Windows.Forms.Button();
            this.jackpotpictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.moneyPot = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.DeckLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DealBtn = new System.Windows.Forms.Button();
            this.DrawBtn = new System.Windows.Forms.Button();
            this.computerMoney = new System.Windows.Forms.Label();
            this.playerMoney = new System.Windows.Forms.Label();
            this.PplayerCard1 = new System.Windows.Forms.CheckBox();
            this.PplayerCard2 = new System.Windows.Forms.CheckBox();
            this.PplayerCard3 = new System.Windows.Forms.CheckBox();
            this.PplayerCard4 = new System.Windows.Forms.CheckBox();
            this.PplayerCard5 = new System.Windows.Forms.CheckBox();
            this.PComputerCard1 = new System.Windows.Forms.CheckBox();
            this.PComputerCard2 = new System.Windows.Forms.CheckBox();
            this.PComputerCard3 = new System.Windows.Forms.CheckBox();
            this.PComputerCard4 = new System.Windows.Forms.CheckBox();
            this.PComputerCard5 = new System.Windows.Forms.CheckBox();
            this.Winnertxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jackpotpictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // computerLabel
            // 
            this.computerLabel.AutoSize = true;
            this.computerLabel.BackColor = System.Drawing.Color.Transparent;
            this.computerLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerLabel.ForeColor = System.Drawing.Color.White;
            this.computerLabel.Location = new System.Drawing.Point(12, 9);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(115, 25);
            this.computerLabel.TabIndex = 0;
            this.computerLabel.Text = "Computer";
            // 
            // playerLabel
            // 
            this.playerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playerLabel.AutoSize = true;
            this.playerLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.playerLabel.Location = new System.Drawing.Point(12, 589);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(95, 25);
            this.playerLabel.TabIndex = 1;
            this.playerLabel.Text = "Player 1";
            // 
            // FoldBtn
            // 
            this.FoldBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FoldBtn.BackColor = System.Drawing.Color.Transparent;
            this.FoldBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FoldBtn.BackgroundImage")));
            this.FoldBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FoldBtn.FlatAppearance.BorderSize = 0;
            this.FoldBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FoldBtn.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoldBtn.Location = new System.Drawing.Point(983, 37);
            this.FoldBtn.Name = "FoldBtn";
            this.FoldBtn.Size = new System.Drawing.Size(94, 128);
            this.FoldBtn.TabIndex = 2;
            this.FoldBtn.UseVisualStyleBackColor = false;
            this.FoldBtn.Click += new System.EventHandler(this.FoldBtn_Click);
            // 
            // jackpotpictureBox1
            // 
            this.jackpotpictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jackpotpictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.jackpotpictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.treasure;
            this.jackpotpictureBox1.Location = new System.Drawing.Point(488, 245);
            this.jackpotpictureBox1.Name = "jackpotpictureBox1";
            this.jackpotpictureBox1.Size = new System.Drawing.Size(129, 121);
            this.jackpotpictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jackpotpictureBox1.TabIndex = 3;
            this.jackpotpictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.poker_chips1;
            this.pictureBox1.Location = new System.Drawing.Point(17, 478);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.poker_chips1;
            this.pictureBox2.Location = new System.Drawing.Point(22, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(467, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pot Value:";
            // 
            // moneyPot
            // 
            this.moneyPot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moneyPot.BackColor = System.Drawing.Color.MintCream;
            this.moneyPot.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyPot.Location = new System.Drawing.Point(514, 293);
            this.moneyPot.Name = "moneyPot";
            this.moneyPot.Size = new System.Drawing.Size(69, 15);
            this.moneyPot.TabIndex = 7;
            this.moneyPot.Text = "$0";
            this.moneyPot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources.back_of_card;
            this.pictureBox3.Location = new System.Drawing.Point(469, 394);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = global::WindowsFormsApplication1.Properties.Resources.back_of_card;
            this.pictureBox4.Location = new System.Drawing.Point(583, 394);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // DeckLabel
            // 
            this.DeckLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeckLabel.AutoSize = true;
            this.DeckLabel.BackColor = System.Drawing.Color.Transparent;
            this.DeckLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeckLabel.ForeColor = System.Drawing.Color.White;
            this.DeckLabel.Location = new System.Drawing.Point(467, 369);
            this.DeckLabel.Name = "DeckLabel";
            this.DeckLabel.Size = new System.Drawing.Size(48, 22);
            this.DeckLabel.TabIndex = 10;
            this.DeckLabel.Text = "Deck";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(567, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Burn Pile";
            // 
            // DealBtn
            // 
            this.DealBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DealBtn.BackColor = System.Drawing.Color.Transparent;
            this.DealBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DealBtn.BackgroundImage")));
            this.DealBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DealBtn.FlatAppearance.BorderSize = 0;
            this.DealBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DealBtn.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealBtn.ForeColor = System.Drawing.Color.Transparent;
            this.DealBtn.Location = new System.Drawing.Point(983, 256);
            this.DealBtn.Name = "DealBtn";
            this.DealBtn.Size = new System.Drawing.Size(94, 135);
            this.DealBtn.TabIndex = 12;
            this.DealBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DealBtn.UseVisualStyleBackColor = false;
            this.DealBtn.Click += new System.EventHandler(this.DealBtn_Click);
            // 
            // DrawBtn
            // 
            this.DrawBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawBtn.BackColor = System.Drawing.Color.Transparent;
            this.DrawBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DrawBtn.BackgroundImage")));
            this.DrawBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DrawBtn.FlatAppearance.BorderSize = 0;
            this.DrawBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrawBtn.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawBtn.ForeColor = System.Drawing.Color.Black;
            this.DrawBtn.Location = new System.Drawing.Point(952, 494);
            this.DrawBtn.Name = "DrawBtn";
            this.DrawBtn.Size = new System.Drawing.Size(125, 94);
            this.DrawBtn.TabIndex = 13;
            this.DrawBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DrawBtn.UseVisualStyleBackColor = false;
            this.DrawBtn.Click += new System.EventHandler(this.DrawBtn_Click);
            // 
            // computerMoney
            // 
            this.computerMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.computerMoney.AutoSize = true;
            this.computerMoney.BackColor = System.Drawing.Color.MintCream;
            this.computerMoney.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerMoney.Location = new System.Drawing.Point(32, 130);
            this.computerMoney.Name = "computerMoney";
            this.computerMoney.Size = new System.Drawing.Size(61, 15);
            this.computerMoney.TabIndex = 24;
            this.computerMoney.Text = "$100";
            // 
            // playerMoney
            // 
            this.playerMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerMoney.AutoSize = true;
            this.playerMoney.BackColor = System.Drawing.Color.MintCream;
            this.playerMoney.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerMoney.Location = new System.Drawing.Point(32, 447);
            this.playerMoney.Name = "playerMoney";
            this.playerMoney.Size = new System.Drawing.Size(61, 15);
            this.playerMoney.TabIndex = 25;
            this.playerMoney.Text = "$100";
            // 
            // PplayerCard1
            // 
            this.PplayerCard1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PplayerCard1.Appearance = System.Windows.Forms.Appearance.Button;
            this.PplayerCard1.BackColor = System.Drawing.Color.Transparent;
            this.PplayerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PplayerCard1.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.PplayerCard1.FlatAppearance.BorderSize = 0;
            this.PplayerCard1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.PplayerCard1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PplayerCard1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PplayerCard1.Location = new System.Drawing.Point(230, 478);
            this.PplayerCard1.Name = "PplayerCard1";
            this.PplayerCard1.Size = new System.Drawing.Size(100, 145);
            this.PplayerCard1.TabIndex = 27;
            this.PplayerCard1.UseVisualStyleBackColor = false;
            this.PplayerCard1.CheckedChanged += new System.EventHandler(this.PplayerCard1_CheckedChanged);
            // 
            // PplayerCard2
            // 
            this.PplayerCard2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PplayerCard2.Appearance = System.Windows.Forms.Appearance.Button;
            this.PplayerCard2.BackColor = System.Drawing.Color.Transparent;
            this.PplayerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PplayerCard2.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.PplayerCard2.FlatAppearance.BorderSize = 0;
            this.PplayerCard2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.PplayerCard2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PplayerCard2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PplayerCard2.Location = new System.Drawing.Point(379, 478);
            this.PplayerCard2.Name = "PplayerCard2";
            this.PplayerCard2.Size = new System.Drawing.Size(100, 145);
            this.PplayerCard2.TabIndex = 28;
            this.PplayerCard2.UseVisualStyleBackColor = false;
            this.PplayerCard2.CheckedChanged += new System.EventHandler(this.PplayerCard2_CheckedChanged);
            // 
            // PplayerCard3
            // 
            this.PplayerCard3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PplayerCard3.Appearance = System.Windows.Forms.Appearance.Button;
            this.PplayerCard3.BackColor = System.Drawing.Color.Transparent;
            this.PplayerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PplayerCard3.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.PplayerCard3.FlatAppearance.BorderSize = 0;
            this.PplayerCard3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.PplayerCard3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PplayerCard3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PplayerCard3.Location = new System.Drawing.Point(517, 478);
            this.PplayerCard3.Name = "PplayerCard3";
            this.PplayerCard3.Size = new System.Drawing.Size(100, 145);
            this.PplayerCard3.TabIndex = 29;
            this.PplayerCard3.UseVisualStyleBackColor = false;
            this.PplayerCard3.CheckedChanged += new System.EventHandler(this.PplayerCard3_CheckedChanged);
            // 
            // PplayerCard4
            // 
            this.PplayerCard4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PplayerCard4.Appearance = System.Windows.Forms.Appearance.Button;
            this.PplayerCard4.BackColor = System.Drawing.Color.Transparent;
            this.PplayerCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PplayerCard4.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.PplayerCard4.FlatAppearance.BorderSize = 0;
            this.PplayerCard4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.PplayerCard4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PplayerCard4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PplayerCard4.Location = new System.Drawing.Point(659, 478);
            this.PplayerCard4.Name = "PplayerCard4";
            this.PplayerCard4.Size = new System.Drawing.Size(100, 145);
            this.PplayerCard4.TabIndex = 30;
            this.PplayerCard4.UseVisualStyleBackColor = false;
            this.PplayerCard4.CheckedChanged += new System.EventHandler(this.PplayerCard4_CheckedChanged);
            // 
            // PplayerCard5
            // 
            this.PplayerCard5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PplayerCard5.Appearance = System.Windows.Forms.Appearance.Button;
            this.PplayerCard5.BackColor = System.Drawing.Color.Transparent;
            this.PplayerCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PplayerCard5.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.PplayerCard5.FlatAppearance.BorderSize = 0;
            this.PplayerCard5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.PplayerCard5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PplayerCard5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PplayerCard5.Location = new System.Drawing.Point(805, 478);
            this.PplayerCard5.Name = "PplayerCard5";
            this.PplayerCard5.Size = new System.Drawing.Size(100, 145);
            this.PplayerCard5.TabIndex = 31;
            this.PplayerCard5.UseVisualStyleBackColor = false;
            this.PplayerCard5.CheckedChanged += new System.EventHandler(this.PplayerCard5_CheckedChanged);
            // 
            // PComputerCard1
            // 
            this.PComputerCard1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PComputerCard1.Appearance = System.Windows.Forms.Appearance.Button;
            this.PComputerCard1.BackColor = System.Drawing.Color.Transparent;
            this.PComputerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PComputerCard1.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.PComputerCard1.FlatAppearance.BorderSize = 0;
            this.PComputerCard1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.PComputerCard1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PComputerCard1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PComputerCard1.Location = new System.Drawing.Point(230, 12);
            this.PComputerCard1.Name = "PComputerCard1";
            this.PComputerCard1.Size = new System.Drawing.Size(100, 145);
            this.PComputerCard1.TabIndex = 32;
            this.PComputerCard1.UseVisualStyleBackColor = false;
            this.PComputerCard1.CheckedChanged += new System.EventHandler(this.PComputerCard1_CheckedChanged);
            // 
            // PComputerCard2
            // 
            this.PComputerCard2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PComputerCard2.Appearance = System.Windows.Forms.Appearance.Button;
            this.PComputerCard2.BackColor = System.Drawing.Color.Transparent;
            this.PComputerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PComputerCard2.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.PComputerCard2.FlatAppearance.BorderSize = 0;
            this.PComputerCard2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.PComputerCard2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PComputerCard2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PComputerCard2.Location = new System.Drawing.Point(379, 12);
            this.PComputerCard2.Name = "PComputerCard2";
            this.PComputerCard2.Size = new System.Drawing.Size(100, 145);
            this.PComputerCard2.TabIndex = 33;
            this.PComputerCard2.UseVisualStyleBackColor = false;
            this.PComputerCard2.CheckedChanged += new System.EventHandler(this.PComputerCard2_CheckedChanged);
            // 
            // PComputerCard3
            // 
            this.PComputerCard3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PComputerCard3.Appearance = System.Windows.Forms.Appearance.Button;
            this.PComputerCard3.BackColor = System.Drawing.Color.Transparent;
            this.PComputerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PComputerCard3.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.PComputerCard3.FlatAppearance.BorderSize = 0;
            this.PComputerCard3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.PComputerCard3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PComputerCard3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PComputerCard3.Location = new System.Drawing.Point(517, 12);
            this.PComputerCard3.Name = "PComputerCard3";
            this.PComputerCard3.Size = new System.Drawing.Size(100, 145);
            this.PComputerCard3.TabIndex = 34;
            this.PComputerCard3.UseVisualStyleBackColor = false;
            this.PComputerCard3.CheckedChanged += new System.EventHandler(this.PComputerCard3_CheckedChanged);
            // 
            // PComputerCard4
            // 
            this.PComputerCard4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PComputerCard4.Appearance = System.Windows.Forms.Appearance.Button;
            this.PComputerCard4.BackColor = System.Drawing.Color.Transparent;
            this.PComputerCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PComputerCard4.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.PComputerCard4.FlatAppearance.BorderSize = 0;
            this.PComputerCard4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.PComputerCard4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PComputerCard4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PComputerCard4.Location = new System.Drawing.Point(659, 12);
            this.PComputerCard4.Name = "PComputerCard4";
            this.PComputerCard4.Size = new System.Drawing.Size(100, 145);
            this.PComputerCard4.TabIndex = 35;
            this.PComputerCard4.UseVisualStyleBackColor = false;
            this.PComputerCard4.CheckedChanged += new System.EventHandler(this.PComputerCard4_CheckedChanged);
            // 
            // PComputerCard5
            // 
            this.PComputerCard5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PComputerCard5.Appearance = System.Windows.Forms.Appearance.Button;
            this.PComputerCard5.BackColor = System.Drawing.Color.Transparent;
            this.PComputerCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PComputerCard5.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.PComputerCard5.FlatAppearance.BorderSize = 0;
            this.PComputerCard5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.PComputerCard5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PComputerCard5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PComputerCard5.Location = new System.Drawing.Point(805, 12);
            this.PComputerCard5.Name = "PComputerCard5";
            this.PComputerCard5.Size = new System.Drawing.Size(100, 145);
            this.PComputerCard5.TabIndex = 36;
            this.PComputerCard5.UseVisualStyleBackColor = false;
            this.PComputerCard5.CheckedChanged += new System.EventHandler(this.PComputerCard5_CheckedChanged);
            // 
            // Winnertxt
            // 
            this.Winnertxt.AutoSize = true;
            this.Winnertxt.BackColor = System.Drawing.Color.Transparent;
            this.Winnertxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Winnertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winnertxt.ForeColor = System.Drawing.Color.Turquoise;
            this.Winnertxt.Location = new System.Drawing.Point(408, 160);
            this.Winnertxt.Name = "Winnertxt";
            this.Winnertxt.Size = new System.Drawing.Size(0, 46);
            this.Winnertxt.TabIndex = 37;
            this.Winnertxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1101, 626);
            this.Controls.Add(this.Winnertxt);
            this.Controls.Add(this.PComputerCard5);
            this.Controls.Add(this.PComputerCard4);
            this.Controls.Add(this.PComputerCard3);
            this.Controls.Add(this.PComputerCard2);
            this.Controls.Add(this.PComputerCard1);
            this.Controls.Add(this.PplayerCard5);
            this.Controls.Add(this.PplayerCard4);
            this.Controls.Add(this.PplayerCard3);
            this.Controls.Add(this.PplayerCard2);
            this.Controls.Add(this.PplayerCard1);
            this.Controls.Add(this.playerMoney);
            this.Controls.Add(this.computerMoney);
            this.Controls.Add(this.moneyPot);
            this.Controls.Add(this.DrawBtn);
            this.Controls.Add(this.DealBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeckLabel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.jackpotpictureBox1);
            this.Controls.Add(this.FoldBtn);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.computerLabel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "GameBoard";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.GameBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jackpotpictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Button FoldBtn;
        private System.Windows.Forms.PictureBox jackpotpictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label moneyPot;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label DeckLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DealBtn;
        private System.Windows.Forms.Button DrawBtn;
        private System.Windows.Forms.Label computerMoney;
        private System.Windows.Forms.Label playerMoney;
        private System.Windows.Forms.CheckBox PplayerCard1;
        private System.Windows.Forms.CheckBox PplayerCard2;
        private System.Windows.Forms.CheckBox PplayerCard3;
        private System.Windows.Forms.CheckBox PplayerCard4;
        private System.Windows.Forms.CheckBox PplayerCard5;
        private System.Windows.Forms.CheckBox PComputerCard1;
        private System.Windows.Forms.CheckBox PComputerCard2;
        private System.Windows.Forms.CheckBox PComputerCard3;
        private System.Windows.Forms.CheckBox PComputerCard4;
        private System.Windows.Forms.CheckBox PComputerCard5;
        private System.Windows.Forms.Label Winnertxt;
    }
}

