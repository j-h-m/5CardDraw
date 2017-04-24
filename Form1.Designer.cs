using System;
using System.Windows.Forms;

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
            this.moneyPot = new System.Windows.Forms.Label();
            this.DealBtn = new System.Windows.Forms.Button();
            this.DrawBtn = new System.Windows.Forms.Button();
            this.compMoney = new System.Windows.Forms.Label();
            this.playerMoney = new System.Windows.Forms.Label();
            this.Winner = new System.Windows.Forms.Label();
            this.PplayerCard1 = new System.Windows.Forms.CheckBox();
            this.PplayerCard2 = new System.Windows.Forms.CheckBox();
            this.PplayerCard3 = new System.Windows.Forms.CheckBox();
            this.PplayerCard4 = new System.Windows.Forms.CheckBox();
            this.PplayerCard5 = new System.Windows.Forms.CheckBox();
            this.PcomputerCard5 = new System.Windows.Forms.CheckBox();
            this.PcomputerCard4 = new System.Windows.Forms.CheckBox();
            this.PcomputerCard3 = new System.Windows.Forms.CheckBox();
            this.PcomputerCard2 = new System.Windows.Forms.CheckBox();
            this.PcomputerCard1 = new System.Windows.Forms.CheckBox();
            this.Winner2 = new System.Windows.Forms.Label();
            this.PlayerHandLabel = new System.Windows.Forms.Label();
            this.CompHandLabel = new System.Windows.Forms.Label();
            this.PlayerBet = new System.Windows.Forms.NumericUpDown();
            this.CompBet = new System.Windows.Forms.NumericUpDown();
            this.PlayerBetButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CompPanel = new System.Windows.Forms.Panel();
            this.PlayerPanel = new System.Windows.Forms.Panel();
            this.PlayerBetPanel = new System.Windows.Forms.Panel();
            this.CompBetPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.CompBetButton = new System.Windows.Forms.Button();
            this.CompBetLabel = new System.Windows.Forms.Label();
            this.PlayerBetLabel = new System.Windows.Forms.Label();
            this.thinkLabel = new System.Windows.Forms.Label();
            this.continueBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.forrest = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.Help = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompBet)).BeginInit();
            this.CompPanel.SuspendLayout();
            this.PlayerPanel.SuspendLayout();
            this.PlayerBetPanel.SuspendLayout();
            this.CompBetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forrest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // computerLabel
            // 
            this.computerLabel.AutoSize = true;
            this.computerLabel.BackColor = System.Drawing.Color.Transparent;
            this.computerLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerLabel.ForeColor = System.Drawing.Color.White;
            this.computerLabel.Location = new System.Drawing.Point(114, 163);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(86, 25);
            this.computerLabel.TabIndex = 0;
            this.computerLabel.Text = "Forrest";
            // 
            // playerLabel
            // 
            this.playerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playerLabel.AutoSize = true;
            this.playerLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.playerLabel.Location = new System.Drawing.Point(122, 0);
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
            this.FoldBtn.Enabled = false;
            this.FoldBtn.FlatAppearance.BorderSize = 0;
            this.FoldBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FoldBtn.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoldBtn.Location = new System.Drawing.Point(922, 379);
            this.FoldBtn.Name = "FoldBtn";
            this.FoldBtn.Size = new System.Drawing.Size(156, 67);
            this.FoldBtn.TabIndex = 2;
            this.FoldBtn.UseVisualStyleBackColor = false;
            this.FoldBtn.Click += new System.EventHandler(this.FoldBtn_Click);
            // 
            // moneyPot
            // 
            this.moneyPot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moneyPot.BackColor = System.Drawing.Color.Transparent;
            this.moneyPot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moneyPot.Font = new System.Drawing.Font("Digital-7", 51.74999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyPot.ForeColor = System.Drawing.Color.Yellow;
            this.moneyPot.Location = new System.Drawing.Point(453, 284);
            this.moneyPot.Margin = new System.Windows.Forms.Padding(0);
            this.moneyPot.Name = "moneyPot";
            this.moneyPot.Size = new System.Drawing.Size(243, 65);
            this.moneyPot.TabIndex = 7;
            this.moneyPot.Text = "000,000";
            this.moneyPot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.DealBtn.Location = new System.Drawing.Point(922, 465);
            this.DealBtn.Name = "DealBtn";
            this.DealBtn.Size = new System.Drawing.Size(167, 70);
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
            this.DrawBtn.Enabled = false;
            this.DrawBtn.FlatAppearance.BorderSize = 0;
            this.DrawBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrawBtn.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawBtn.ForeColor = System.Drawing.Color.Black;
            this.DrawBtn.Location = new System.Drawing.Point(923, 544);
            this.DrawBtn.Name = "DrawBtn";
            this.DrawBtn.Size = new System.Drawing.Size(155, 76);
            this.DrawBtn.TabIndex = 13;
            this.DrawBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DrawBtn.UseVisualStyleBackColor = false;
            this.DrawBtn.Click += new System.EventHandler(this.DrawBtn_Click);
            // 
            // compMoney
            // 
            this.compMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.compMoney.BackColor = System.Drawing.Color.Transparent;
            this.compMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compMoney.Font = new System.Drawing.Font("Digital-7", 36.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compMoney.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.compMoney.Location = new System.Drawing.Point(14, 4);
            this.compMoney.Name = "compMoney";
            this.compMoney.Size = new System.Drawing.Size(168, 49);
            this.compMoney.TabIndex = 24;
            this.compMoney.Text = "000,000";
            this.compMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.compMoney.Click += new System.EventHandler(this.compMoney_Click);
            // 
            // playerMoney
            // 
            this.playerMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerMoney.BackColor = System.Drawing.Color.Transparent;
            this.playerMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playerMoney.Font = new System.Drawing.Font("Digital-7", 36.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerMoney.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerMoney.Location = new System.Drawing.Point(11, 143);
            this.playerMoney.Name = "playerMoney";
            this.playerMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playerMoney.Size = new System.Drawing.Size(171, 51);
            this.playerMoney.TabIndex = 25;
            this.playerMoney.Text = "000,000";
            this.playerMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Winner
            // 
            this.Winner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Winner.BackColor = System.Drawing.Color.Transparent;
            this.Winner.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Winner.Location = new System.Drawing.Point(279, 276);
            this.Winner.Name = "Winner";
            this.Winner.Size = new System.Drawing.Size(180, 57);
            this.Winner.TabIndex = 26;
            this.Winner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Winner.Click += new System.EventHandler(this.Winner_Click);
            // 
            // PplayerCard1
            // 
            this.PplayerCard1.Appearance = System.Windows.Forms.Appearance.Button;
            this.PplayerCard1.AutoSize = true;
            this.PplayerCard1.BackColor = System.Drawing.Color.Transparent;
            this.PplayerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PplayerCard1.FlatAppearance.BorderSize = 0;
            this.PplayerCard1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PplayerCard1.Location = new System.Drawing.Point(35, 44);
            this.PplayerCard1.MinimumSize = new System.Drawing.Size(100, 145);
            this.PplayerCard1.Name = "PplayerCard1";
            this.PplayerCard1.Size = new System.Drawing.Size(100, 145);
            this.PplayerCard1.TabIndex = 27;
            this.PplayerCard1.UseVisualStyleBackColor = false;
            this.PplayerCard1.CheckedChanged += new System.EventHandler(this.PplayerCard1_CheckedChanged);
            // 
            // PplayerCard2
            // 
            this.PplayerCard2.Appearance = System.Windows.Forms.Appearance.Button;
            this.PplayerCard2.AutoSize = true;
            this.PplayerCard2.BackColor = System.Drawing.Color.Transparent;
            this.PplayerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PplayerCard2.FlatAppearance.BorderSize = 0;
            this.PplayerCard2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PplayerCard2.Location = new System.Drawing.Point(156, 44);
            this.PplayerCard2.MinimumSize = new System.Drawing.Size(100, 145);
            this.PplayerCard2.Name = "PplayerCard2";
            this.PplayerCard2.Size = new System.Drawing.Size(100, 145);
            this.PplayerCard2.TabIndex = 28;
            this.PplayerCard2.UseVisualStyleBackColor = false;
            this.PplayerCard2.CheckedChanged += new System.EventHandler(this.PplayerCard2_CheckedChanged);
            // 
            // PplayerCard3
            // 
            this.PplayerCard3.Appearance = System.Windows.Forms.Appearance.Button;
            this.PplayerCard3.AutoSize = true;
            this.PplayerCard3.BackColor = System.Drawing.Color.Transparent;
            this.PplayerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PplayerCard3.FlatAppearance.BorderSize = 0;
            this.PplayerCard3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PplayerCard3.Location = new System.Drawing.Point(284, 44);
            this.PplayerCard3.MinimumSize = new System.Drawing.Size(100, 145);
            this.PplayerCard3.Name = "PplayerCard3";
            this.PplayerCard3.Size = new System.Drawing.Size(100, 145);
            this.PplayerCard3.TabIndex = 29;
            this.PplayerCard3.UseVisualStyleBackColor = false;
            this.PplayerCard3.CheckedChanged += new System.EventHandler(this.PplayerCard3_CheckedChanged);
            // 
            // PplayerCard4
            // 
            this.PplayerCard4.Appearance = System.Windows.Forms.Appearance.Button;
            this.PplayerCard4.AutoSize = true;
            this.PplayerCard4.BackColor = System.Drawing.Color.Transparent;
            this.PplayerCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PplayerCard4.FlatAppearance.BorderSize = 0;
            this.PplayerCard4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PplayerCard4.Location = new System.Drawing.Point(408, 44);
            this.PplayerCard4.MinimumSize = new System.Drawing.Size(100, 145);
            this.PplayerCard4.Name = "PplayerCard4";
            this.PplayerCard4.Size = new System.Drawing.Size(100, 145);
            this.PplayerCard4.TabIndex = 30;
            this.PplayerCard4.UseVisualStyleBackColor = false;
            this.PplayerCard4.CheckedChanged += new System.EventHandler(this.PplayerCard4_CheckedChanged);
            // 
            // PplayerCard5
            // 
            this.PplayerCard5.Appearance = System.Windows.Forms.Appearance.Button;
            this.PplayerCard5.AutoSize = true;
            this.PplayerCard5.BackColor = System.Drawing.Color.Transparent;
            this.PplayerCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PplayerCard5.FlatAppearance.BorderSize = 0;
            this.PplayerCard5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PplayerCard5.Location = new System.Drawing.Point(536, 44);
            this.PplayerCard5.MinimumSize = new System.Drawing.Size(100, 145);
            this.PplayerCard5.Name = "PplayerCard5";
            this.PplayerCard5.Size = new System.Drawing.Size(100, 145);
            this.PplayerCard5.TabIndex = 31;
            this.PplayerCard5.UseVisualStyleBackColor = false;
            this.PplayerCard5.CheckedChanged += new System.EventHandler(this.PplayerCard5_CheckedChanged);
            // 
            // PcomputerCard5
            // 
            this.PcomputerCard5.Appearance = System.Windows.Forms.Appearance.Button;
            this.PcomputerCard5.AutoSize = true;
            this.PcomputerCard5.BackColor = System.Drawing.Color.Transparent;
            this.PcomputerCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PcomputerCard5.FlatAppearance.BorderSize = 0;
            this.PcomputerCard5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PcomputerCard5.Location = new System.Drawing.Point(539, 12);
            this.PcomputerCard5.MinimumSize = new System.Drawing.Size(100, 145);
            this.PcomputerCard5.Name = "PcomputerCard5";
            this.PcomputerCard5.Size = new System.Drawing.Size(100, 145);
            this.PcomputerCard5.TabIndex = 36;
            this.PcomputerCard5.UseVisualStyleBackColor = false;
            this.PcomputerCard5.CheckedChanged += new System.EventHandler(this.PcomputerCard5_CheckedChanged);
            // 
            // PcomputerCard4
            // 
            this.PcomputerCard4.Appearance = System.Windows.Forms.Appearance.Button;
            this.PcomputerCard4.AutoSize = true;
            this.PcomputerCard4.BackColor = System.Drawing.Color.Transparent;
            this.PcomputerCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PcomputerCard4.FlatAppearance.BorderSize = 0;
            this.PcomputerCard4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PcomputerCard4.Location = new System.Drawing.Point(415, 12);
            this.PcomputerCard4.MinimumSize = new System.Drawing.Size(100, 145);
            this.PcomputerCard4.Name = "PcomputerCard4";
            this.PcomputerCard4.Size = new System.Drawing.Size(100, 145);
            this.PcomputerCard4.TabIndex = 35;
            this.PcomputerCard4.UseVisualStyleBackColor = false;
            this.PcomputerCard4.CheckedChanged += new System.EventHandler(this.PcomputerCard4_CheckedChanged);
            // 
            // PcomputerCard3
            // 
            this.PcomputerCard3.Appearance = System.Windows.Forms.Appearance.Button;
            this.PcomputerCard3.AutoSize = true;
            this.PcomputerCard3.BackColor = System.Drawing.Color.Transparent;
            this.PcomputerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PcomputerCard3.FlatAppearance.BorderSize = 0;
            this.PcomputerCard3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PcomputerCard3.Location = new System.Drawing.Point(291, 12);
            this.PcomputerCard3.MinimumSize = new System.Drawing.Size(100, 145);
            this.PcomputerCard3.Name = "PcomputerCard3";
            this.PcomputerCard3.Size = new System.Drawing.Size(100, 145);
            this.PcomputerCard3.TabIndex = 34;
            this.PcomputerCard3.UseVisualStyleBackColor = false;
            this.PcomputerCard3.CheckedChanged += new System.EventHandler(this.PcomputerCard3_CheckedChanged);
            // 
            // PcomputerCard2
            // 
            this.PcomputerCard2.Appearance = System.Windows.Forms.Appearance.Button;
            this.PcomputerCard2.AutoSize = true;
            this.PcomputerCard2.BackColor = System.Drawing.Color.Transparent;
            this.PcomputerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PcomputerCard2.FlatAppearance.BorderSize = 0;
            this.PcomputerCard2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PcomputerCard2.Location = new System.Drawing.Point(163, 12);
            this.PcomputerCard2.MinimumSize = new System.Drawing.Size(100, 145);
            this.PcomputerCard2.Name = "PcomputerCard2";
            this.PcomputerCard2.Size = new System.Drawing.Size(100, 145);
            this.PcomputerCard2.TabIndex = 33;
            this.PcomputerCard2.UseVisualStyleBackColor = false;
            this.PcomputerCard2.CheckedChanged += new System.EventHandler(this.PcomputerCard2_CheckedChanged);
            // 
            // PcomputerCard1
            // 
            this.PcomputerCard1.Appearance = System.Windows.Forms.Appearance.Button;
            this.PcomputerCard1.AutoSize = true;
            this.PcomputerCard1.BackColor = System.Drawing.Color.Transparent;
            this.PcomputerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PcomputerCard1.FlatAppearance.BorderSize = 0;
            this.PcomputerCard1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PcomputerCard1.Location = new System.Drawing.Point(42, 12);
            this.PcomputerCard1.MinimumSize = new System.Drawing.Size(100, 145);
            this.PcomputerCard1.Name = "PcomputerCard1";
            this.PcomputerCard1.Size = new System.Drawing.Size(100, 145);
            this.PcomputerCard1.TabIndex = 32;
            this.PcomputerCard1.UseVisualStyleBackColor = false;
            this.PcomputerCard1.CheckedChanged += new System.EventHandler(this.PcomputerCard1_CheckedChanged);
            // 
            // Winner2
            // 
            this.Winner2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Winner2.BackColor = System.Drawing.Color.Transparent;
            this.Winner2.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winner2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Winner2.Location = new System.Drawing.Point(753, 276);
            this.Winner2.Name = "Winner2";
            this.Winner2.Size = new System.Drawing.Size(180, 57);
            this.Winner2.TabIndex = 37;
            this.Winner2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerHandLabel
            // 
            this.PlayerHandLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerHandLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerHandLabel.Font = new System.Drawing.Font("Goudy Stout", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerHandLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PlayerHandLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlayerHandLabel.Location = new System.Drawing.Point(14, 318);
            this.PlayerHandLabel.Name = "PlayerHandLabel";
            this.PlayerHandLabel.Size = new System.Drawing.Size(214, 48);
            this.PlayerHandLabel.TabIndex = 38;
            this.PlayerHandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CompHandLabel
            // 
            this.CompHandLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompHandLabel.BackColor = System.Drawing.Color.Transparent;
            this.CompHandLabel.Font = new System.Drawing.Font("Goudy Stout", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompHandLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CompHandLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CompHandLabel.Location = new System.Drawing.Point(21, 226);
            this.CompHandLabel.Name = "CompHandLabel";
            this.CompHandLabel.Size = new System.Drawing.Size(215, 48);
            this.CompHandLabel.TabIndex = 39;
            this.CompHandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlayerBet
            // 
            this.PlayerBet.BackColor = System.Drawing.Color.Black;
            this.PlayerBet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayerBet.DecimalPlaces = 2;
            this.PlayerBet.Font = new System.Drawing.Font("Digital-7", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerBet.ForeColor = System.Drawing.Color.Cyan;
            this.PlayerBet.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PlayerBet.Location = new System.Drawing.Point(5, 98);
            this.PlayerBet.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PlayerBet.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PlayerBet.Name = "PlayerBet";
            this.PlayerBet.Size = new System.Drawing.Size(153, 30);
            this.PlayerBet.TabIndex = 40;
            this.PlayerBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PlayerBet.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // CompBet
            // 
            this.CompBet.BackColor = System.Drawing.Color.Black;
            this.CompBet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompBet.DecimalPlaces = 2;
            this.CompBet.Font = new System.Drawing.Font("Digital-7", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompBet.ForeColor = System.Drawing.Color.Cyan;
            this.CompBet.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CompBet.Location = new System.Drawing.Point(10, 82);
            this.CompBet.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CompBet.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CompBet.Name = "CompBet";
            this.CompBet.Size = new System.Drawing.Size(159, 30);
            this.CompBet.TabIndex = 41;
            this.CompBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CompBet.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // PlayerBetButton
            // 
            this.PlayerBetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PlayerBetButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayerBetButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayerBetButton.BackgroundImage")));
            this.PlayerBetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerBetButton.FlatAppearance.BorderSize = 0;
            this.PlayerBetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerBetButton.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerBetButton.ForeColor = System.Drawing.Color.Transparent;
            this.PlayerBetButton.Location = new System.Drawing.Point(0, 38);
            this.PlayerBetButton.Name = "PlayerBetButton";
            this.PlayerBetButton.Size = new System.Drawing.Size(106, 54);
            this.PlayerBetButton.TabIndex = 42;
            this.PlayerBetButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PlayerBetButton.UseVisualStyleBackColor = false;
            this.PlayerBetButton.Click += new System.EventHandler(this.PlayerBetButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Digital-7", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(412, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 64);
            this.label2.TabIndex = 44;
            this.label2.Text = "$";
            // 
            // CompPanel
            // 
            this.CompPanel.BackColor = System.Drawing.Color.Transparent;
            this.CompPanel.Controls.Add(this.PcomputerCard4);
            this.CompPanel.Controls.Add(this.PcomputerCard1);
            this.CompPanel.Controls.Add(this.PcomputerCard2);
            this.CompPanel.Controls.Add(this.PcomputerCard3);
            this.CompPanel.Controls.Add(this.PcomputerCard5);
            this.CompPanel.Enabled = false;
            this.CompPanel.ForeColor = System.Drawing.Color.Transparent;
            this.CompPanel.Location = new System.Drawing.Point(227, 8);
            this.CompPanel.Name = "CompPanel";
            this.CompPanel.Size = new System.Drawing.Size(723, 193);
            this.CompPanel.TabIndex = 47;
            this.CompPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CompPanel_Paint);
            // 
            // PlayerPanel
            // 
            this.PlayerPanel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerPanel.Controls.Add(this.PplayerCard1);
            this.PlayerPanel.Controls.Add(this.PplayerCard2);
            this.PlayerPanel.Controls.Add(this.PplayerCard3);
            this.PlayerPanel.Controls.Add(this.PplayerCard4);
            this.PlayerPanel.Controls.Add(this.PplayerCard5);
            this.PlayerPanel.Enabled = false;
            this.PlayerPanel.ForeColor = System.Drawing.Color.Transparent;
            this.PlayerPanel.Location = new System.Drawing.Point(234, 394);
            this.PlayerPanel.Name = "PlayerPanel";
            this.PlayerPanel.Size = new System.Drawing.Size(683, 220);
            this.PlayerPanel.TabIndex = 48;
            this.PlayerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PlayerPanel_Paint);
            // 
            // PlayerBetPanel
            // 
            this.PlayerBetPanel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerBetPanel.Controls.Add(this.PlayerBet);
            this.PlayerBetPanel.Controls.Add(this.PlayerBetButton);
            this.PlayerBetPanel.Controls.Add(this.playerMoney);
            this.PlayerBetPanel.Controls.Add(this.playerLabel);
            this.PlayerBetPanel.Enabled = false;
            this.PlayerBetPanel.ForeColor = System.Drawing.Color.Transparent;
            this.PlayerBetPanel.Location = new System.Drawing.Point(11, 404);
            this.PlayerBetPanel.Name = "PlayerBetPanel";
            this.PlayerBetPanel.Size = new System.Drawing.Size(217, 210);
            this.PlayerBetPanel.TabIndex = 43;
            // 
            // CompBetPanel
            // 
            this.CompBetPanel.BackColor = System.Drawing.Color.Transparent;
            this.CompBetPanel.Controls.Add(this.button1);
            this.CompBetPanel.Controls.Add(this.CompBetButton);
            this.CompBetPanel.Controls.Add(this.CompBet);
            this.CompBetPanel.Controls.Add(this.computerLabel);
            this.CompBetPanel.Controls.Add(this.compMoney);
            this.CompBetPanel.Enabled = false;
            this.CompBetPanel.ForeColor = System.Drawing.Color.Transparent;
            this.CompBetPanel.Location = new System.Drawing.Point(11, 13);
            this.CompBetPanel.Name = "CompBetPanel";
            this.CompBetPanel.Size = new System.Drawing.Size(200, 188);
            this.CompBetPanel.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(10, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 54);
            this.button1.TabIndex = 57;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // CompBetButton
            // 
            this.CompBetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CompBetButton.BackColor = System.Drawing.Color.Transparent;
            this.CompBetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CompBetButton.FlatAppearance.BorderSize = 0;
            this.CompBetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompBetButton.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompBetButton.ForeColor = System.Drawing.Color.Transparent;
            this.CompBetButton.Location = new System.Drawing.Point(0, 0);
            this.CompBetButton.Name = "CompBetButton";
            this.CompBetButton.Size = new System.Drawing.Size(10, 10);
            this.CompBetButton.TabIndex = 43;
            this.CompBetButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CompBetButton.UseVisualStyleBackColor = false;
            this.CompBetButton.Click += new System.EventHandler(this.CompBetButton_Click);
            // 
            // CompBetLabel
            // 
            this.CompBetLabel.AutoSize = true;
            this.CompBetLabel.BackColor = System.Drawing.Color.Transparent;
            this.CompBetLabel.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompBetLabel.Location = new System.Drawing.Point(20, 231);
            this.CompBetLabel.Name = "CompBetLabel";
            this.CompBetLabel.Size = new System.Drawing.Size(0, 19);
            this.CompBetLabel.TabIndex = 50;
            this.CompBetLabel.Visible = false;
            // 
            // PlayerBetLabel
            // 
            this.PlayerBetLabel.AutoSize = true;
            this.PlayerBetLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerBetLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerBetLabel.Location = new System.Drawing.Point(14, 335);
            this.PlayerBetLabel.Name = "PlayerBetLabel";
            this.PlayerBetLabel.Size = new System.Drawing.Size(110, 19);
            this.PlayerBetLabel.TabIndex = 51;
            this.PlayerBetLabel.Text = "Player\'s Bet!";
            this.PlayerBetLabel.Visible = false;
            // 
            // thinkLabel
            // 
            this.thinkLabel.AutoSize = true;
            this.thinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.thinkLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thinkLabel.Location = new System.Drawing.Point(17, 256);
            this.thinkLabel.Name = "thinkLabel";
            this.thinkLabel.Size = new System.Drawing.Size(0, 19);
            this.thinkLabel.TabIndex = 52;
            this.thinkLabel.Visible = false;
            // 
            // continueBtn
            // 
            this.continueBtn.BackColor = System.Drawing.Color.White;
            this.continueBtn.Enabled = false;
            this.continueBtn.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueBtn.Location = new System.Drawing.Point(341, 219);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(92, 29);
            this.continueBtn.TabIndex = 53;
            this.continueBtn.Text = "Continue?";
            this.continueBtn.UseVisualStyleBackColor = false;
            this.continueBtn.Visible = false;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.Color.White;
            this.quitBtn.Enabled = false;
            this.quitBtn.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.Location = new System.Drawing.Point(667, 221);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(92, 29);
            this.quitBtn.TabIndex = 54;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Visible = false;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // forrest
            // 
            this.forrest.BackColor = System.Drawing.Color.Transparent;
            this.forrest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forrest.Image = ((System.Drawing.Image)(resources.GetObject("forrest.Image")));
            this.forrest.Location = new System.Drawing.Point(358, 28);
            this.forrest.Name = "forrest";
            this.forrest.Size = new System.Drawing.Size(401, 188);
            this.forrest.TabIndex = 55;
            this.forrest.TabStop = false;
            this.forrest.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(890, -5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(231, 201);
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.Transparent;
            this.Help.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Help.BackgroundImage")));
            this.Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Help.FlatAppearance.BorderSize = 0;
            this.Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help.Location = new System.Drawing.Point(993, 266);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(107, 77);
            this.Help.TabIndex = 57;
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1101, 626);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.forrest);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.thinkLabel);
            this.Controls.Add(this.PlayerBetLabel);
            this.Controls.Add(this.CompBetLabel);
            this.Controls.Add(this.DealBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlayerHandLabel);
            this.Controls.Add(this.Winner2);
            this.Controls.Add(this.moneyPot);
            this.Controls.Add(this.Winner);
            this.Controls.Add(this.DrawBtn);
            this.Controls.Add(this.FoldBtn);
            this.Controls.Add(this.CompPanel);
            this.Controls.Add(this.PlayerPanel);
            this.Controls.Add(this.CompBetPanel);
            this.Controls.Add(this.PlayerBetPanel);
            this.Controls.Add(this.CompHandLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "GameBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.GameBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompBet)).EndInit();
            this.CompPanel.ResumeLayout(false);
            this.CompPanel.PerformLayout();
            this.PlayerPanel.ResumeLayout(false);
            this.PlayerPanel.PerformLayout();
            this.PlayerBetPanel.ResumeLayout(false);
            this.PlayerBetPanel.PerformLayout();
            this.CompBetPanel.ResumeLayout(false);
            this.CompBetPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forrest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PlayerPanel_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void CompPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Button FoldBtn;
        private System.Windows.Forms.Label moneyPot;
        private System.Windows.Forms.Button DealBtn;
        private System.Windows.Forms.Button DrawBtn;
        private System.Windows.Forms.Label compMoney;
        private System.Windows.Forms.Label playerMoney;
        private System.Windows.Forms.Label Winner;
        private System.Windows.Forms.CheckBox PplayerCard1;
        private System.Windows.Forms.CheckBox PplayerCard2;
        private System.Windows.Forms.CheckBox PplayerCard3;
        private System.Windows.Forms.CheckBox PplayerCard4;
        private System.Windows.Forms.CheckBox PplayerCard5;
        private System.Windows.Forms.CheckBox PcomputerCard5;
        private System.Windows.Forms.CheckBox PcomputerCard4;
        private System.Windows.Forms.CheckBox PcomputerCard3;
        private System.Windows.Forms.CheckBox PcomputerCard2;
        private System.Windows.Forms.CheckBox PcomputerCard1;
        private System.Windows.Forms.Label Winner2;
        private System.Windows.Forms.Label PlayerHandLabel;
        private System.Windows.Forms.Label CompHandLabel;
        private System.Windows.Forms.NumericUpDown PlayerBet;
        private System.Windows.Forms.NumericUpDown CompBet;
        private System.Windows.Forms.Button PlayerBetButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel CompPanel;
        private System.Windows.Forms.Panel PlayerPanel;
        private System.Windows.Forms.Panel PlayerBetPanel;
        private System.Windows.Forms.Panel CompBetPanel;
        private Label CompBetLabel;
        private Label PlayerBetLabel;
        private Label thinkLabel;
        private Button continueBtn;
        private Button quitBtn;
        private Button CompBetButton;
        private PictureBox forrest;
        private PictureBox pictureBox3;
        private Button button1;
        private HelpProvider helpProvider1;
        private Button Help;
    }
}

