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
            this.PBplayerCard1 = new System.Windows.Forms.PictureBox();
            this.PBplayerCard2 = new System.Windows.Forms.PictureBox();
            this.PBplayerCard3 = new System.Windows.Forms.PictureBox();
            this.PBplayerCard4 = new System.Windows.Forms.PictureBox();
            this.PBplayerCard5 = new System.Windows.Forms.PictureBox();
            this.ComputerCard1 = new System.Windows.Forms.PictureBox();
            this.ComputerCard2 = new System.Windows.Forms.PictureBox();
            this.ComputerCard3 = new System.Windows.Forms.PictureBox();
            this.ComputerCard4 = new System.Windows.Forms.PictureBox();
            this.ComputerCard5 = new System.Windows.Forms.PictureBox();
            this.computerMoney = new System.Windows.Forms.Label();
            this.playerMoney = new System.Windows.Forms.Label();
            this.Winner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jackpotpictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBplayerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBplayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBplayerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBplayerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBplayerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerCard5)).BeginInit();
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
            // PBplayerCard1
            // 
            this.PBplayerCard1.BackColor = System.Drawing.Color.Transparent;
            this.PBplayerCard1.Location = new System.Drawing.Point(230, 478);
            this.PBplayerCard1.Name = "PBplayerCard1";
            this.PBplayerCard1.Size = new System.Drawing.Size(100, 136);
            this.PBplayerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBplayerCard1.TabIndex = 14;
            this.PBplayerCard1.TabStop = false;
            // 
            // PBplayerCard2
            // 
            this.PBplayerCard2.BackColor = System.Drawing.Color.Transparent;
            this.PBplayerCard2.Location = new System.Drawing.Point(379, 478);
            this.PBplayerCard2.Name = "PBplayerCard2";
            this.PBplayerCard2.Size = new System.Drawing.Size(100, 136);
            this.PBplayerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBplayerCard2.TabIndex = 15;
            this.PBplayerCard2.TabStop = false;
            // 
            // PBplayerCard3
            // 
            this.PBplayerCard3.BackColor = System.Drawing.Color.Transparent;
            this.PBplayerCard3.Location = new System.Drawing.Point(517, 478);
            this.PBplayerCard3.Name = "PBplayerCard3";
            this.PBplayerCard3.Size = new System.Drawing.Size(100, 136);
            this.PBplayerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBplayerCard3.TabIndex = 16;
            this.PBplayerCard3.TabStop = false;
            // 
            // PBplayerCard4
            // 
            this.PBplayerCard4.BackColor = System.Drawing.Color.Transparent;
            this.PBplayerCard4.Location = new System.Drawing.Point(659, 478);
            this.PBplayerCard4.Name = "PBplayerCard4";
            this.PBplayerCard4.Size = new System.Drawing.Size(100, 136);
            this.PBplayerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBplayerCard4.TabIndex = 17;
            this.PBplayerCard4.TabStop = false;
            // 
            // PBplayerCard5
            // 
            this.PBplayerCard5.BackColor = System.Drawing.Color.Transparent;
            this.PBplayerCard5.Location = new System.Drawing.Point(805, 478);
            this.PBplayerCard5.Name = "PBplayerCard5";
            this.PBplayerCard5.Size = new System.Drawing.Size(100, 136);
            this.PBplayerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBplayerCard5.TabIndex = 18;
            this.PBplayerCard5.TabStop = false;
            // 
            // ComputerCard1
            // 
            this.ComputerCard1.BackColor = System.Drawing.Color.Transparent;
            this.ComputerCard1.Location = new System.Drawing.Point(230, 12);
            this.ComputerCard1.Name = "ComputerCard1";
            this.ComputerCard1.Size = new System.Drawing.Size(100, 136);
            this.ComputerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ComputerCard1.TabIndex = 19;
            this.ComputerCard1.TabStop = false;
            // 
            // ComputerCard2
            // 
            this.ComputerCard2.BackColor = System.Drawing.Color.Transparent;
            this.ComputerCard2.Location = new System.Drawing.Point(379, 12);
            this.ComputerCard2.Name = "ComputerCard2";
            this.ComputerCard2.Size = new System.Drawing.Size(100, 136);
            this.ComputerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ComputerCard2.TabIndex = 20;
            this.ComputerCard2.TabStop = false;
            // 
            // ComputerCard3
            // 
            this.ComputerCard3.BackColor = System.Drawing.Color.Transparent;
            this.ComputerCard3.Location = new System.Drawing.Point(517, 12);
            this.ComputerCard3.Name = "ComputerCard3";
            this.ComputerCard3.Size = new System.Drawing.Size(100, 136);
            this.ComputerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ComputerCard3.TabIndex = 21;
            this.ComputerCard3.TabStop = false;
            // 
            // ComputerCard4
            // 
            this.ComputerCard4.BackColor = System.Drawing.Color.Transparent;
            this.ComputerCard4.Location = new System.Drawing.Point(659, 9);
            this.ComputerCard4.Name = "ComputerCard4";
            this.ComputerCard4.Size = new System.Drawing.Size(100, 136);
            this.ComputerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ComputerCard4.TabIndex = 22;
            this.ComputerCard4.TabStop = false;
            // 
            // ComputerCard5
            // 
            this.ComputerCard5.BackColor = System.Drawing.Color.Transparent;
            this.ComputerCard5.Location = new System.Drawing.Point(805, 12);
            this.ComputerCard5.Name = "ComputerCard5";
            this.ComputerCard5.Size = new System.Drawing.Size(100, 136);
            this.ComputerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ComputerCard5.TabIndex = 23;
            this.ComputerCard5.TabStop = false;
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
            // Winner
            // 
            this.Winner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Winner.BackColor = System.Drawing.Color.MintCream;
            this.Winner.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winner.Location = new System.Drawing.Point(217, 276);
            this.Winner.Name = "Winner";
            this.Winner.Size = new System.Drawing.Size(180, 48);
            this.Winner.TabIndex = 26;
            this.Winner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1101, 626);
            this.Controls.Add(this.Winner);
            this.Controls.Add(this.playerMoney);
            this.Controls.Add(this.computerMoney);
            this.Controls.Add(this.ComputerCard5);
            this.Controls.Add(this.ComputerCard4);
            this.Controls.Add(this.ComputerCard3);
            this.Controls.Add(this.ComputerCard2);
            this.Controls.Add(this.ComputerCard1);
            this.Controls.Add(this.moneyPot);
            this.Controls.Add(this.PBplayerCard5);
            this.Controls.Add(this.PBplayerCard4);
            this.Controls.Add(this.PBplayerCard3);
            this.Controls.Add(this.PBplayerCard2);
            this.Controls.Add(this.PBplayerCard1);
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
            ((System.ComponentModel.ISupportInitialize)(this.PBplayerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBplayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBplayerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBplayerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBplayerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerCard5)).EndInit();
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
        private System.Windows.Forms.PictureBox PBplayerCard1;
        private System.Windows.Forms.PictureBox PBplayerCard2;
        private System.Windows.Forms.PictureBox PBplayerCard3;
        private System.Windows.Forms.PictureBox PBplayerCard4;
        private System.Windows.Forms.PictureBox PBplayerCard5;
        private System.Windows.Forms.PictureBox ComputerCard1;
        private System.Windows.Forms.PictureBox ComputerCard2;
        private System.Windows.Forms.PictureBox ComputerCard3;
        private System.Windows.Forms.PictureBox ComputerCard4;
        private System.Windows.Forms.PictureBox ComputerCard5;
        private System.Windows.Forms.Label computerMoney;
        private System.Windows.Forms.Label playerMoney;
        private System.Windows.Forms.Label Winner;
    }
}

