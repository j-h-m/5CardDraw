namespace WindowsFormsApplication1
{
    partial class Main_Menu_Form
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
            this.main_menu_label = new System.Windows.Forms.Label();
            this.new_game_button = new System.Windows.Forms.Button();
            this.continue_button = new System.Windows.Forms.Button();
            this.statistics_button = new System.Windows.Forms.Button();
            this.exit_game_button = new System.Windows.Forms.Button();
            this.settings_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.settings_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // main_menu_label
            // 
            this.main_menu_label.AutoSize = true;
            this.main_menu_label.BackColor = System.Drawing.Color.Transparent;
            this.main_menu_label.Font = new System.Drawing.Font("Playbill", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_menu_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.main_menu_label.Location = new System.Drawing.Point(71, 10);
            this.main_menu_label.Name = "main_menu_label";
            this.main_menu_label.Size = new System.Drawing.Size(311, 98);
            this.main_menu_label.TabIndex = 0;
            this.main_menu_label.Text = "Main Menu";
            this.main_menu_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // new_game_button
            // 
            this.new_game_button.BackColor = System.Drawing.Color.Transparent;
            this.new_game_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_game_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_game_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.new_game_button.Location = new System.Drawing.Point(135, 111);
            this.new_game_button.Name = "new_game_button";
            this.new_game_button.Size = new System.Drawing.Size(177, 44);
            this.new_game_button.TabIndex = 1;
            this.new_game_button.Text = "New Game";
            this.new_game_button.UseVisualStyleBackColor = false;
            this.new_game_button.Click += new System.EventHandler(this.new_game_button_Click);
            // 
            // continue_button
            // 
            this.continue_button.BackColor = System.Drawing.Color.Transparent;
            this.continue_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continue_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continue_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.continue_button.Location = new System.Drawing.Point(135, 161);
            this.continue_button.Name = "continue_button";
            this.continue_button.Size = new System.Drawing.Size(177, 44);
            this.continue_button.TabIndex = 2;
            this.continue_button.Text = "Continue";
            this.continue_button.UseVisualStyleBackColor = false;
            this.continue_button.Click += new System.EventHandler(this.continue_button_Click);
            // 
            // statistics_button
            // 
            this.statistics_button.BackColor = System.Drawing.Color.Transparent;
            this.statistics_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statistics_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistics_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.statistics_button.Location = new System.Drawing.Point(135, 211);
            this.statistics_button.Name = "statistics_button";
            this.statistics_button.Size = new System.Drawing.Size(177, 44);
            this.statistics_button.TabIndex = 3;
            this.statistics_button.Text = "Statistics";
            this.statistics_button.UseVisualStyleBackColor = false;
            this.statistics_button.Click += new System.EventHandler(this.statistics_button_Click);
            // 
            // exit_game_button
            // 
            this.exit_game_button.BackColor = System.Drawing.Color.Transparent;
            this.exit_game_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_game_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_game_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exit_game_button.Location = new System.Drawing.Point(135, 261);
            this.exit_game_button.Name = "exit_game_button";
            this.exit_game_button.Size = new System.Drawing.Size(177, 44);
            this.exit_game_button.TabIndex = 4;
            this.exit_game_button.Text = "Exit Game";
            this.exit_game_button.UseVisualStyleBackColor = false;
            this.exit_game_button.Click += new System.EventHandler(this.exit_game_button_Click);
            // 
            // settings_picture
            // 
            this.settings_picture.BackColor = System.Drawing.Color.Transparent;
            this.settings_picture.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._1489065876_Settings;
            this.settings_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settings_picture.Location = new System.Drawing.Point(399, 284);
            this.settings_picture.Name = "settings_picture";
            this.settings_picture.Size = new System.Drawing.Size(49, 39);
            this.settings_picture.TabIndex = 5;
            this.settings_picture.TabStop = false;
            this.settings_picture.Click += new System.EventHandler(this.settings_picture_Click);
            // 
            // Main_Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.greenBackground01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(460, 335);
            this.Controls.Add(this.settings_picture);
            this.Controls.Add(this.exit_game_button);
            this.Controls.Add(this.statistics_button);
            this.Controls.Add(this.continue_button);
            this.Controls.Add(this.new_game_button);
            this.Controls.Add(this.main_menu_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Menu_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.settings_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label main_menu_label;
        private System.Windows.Forms.Button new_game_button;
        private System.Windows.Forms.Button continue_button;
        private System.Windows.Forms.Button statistics_button;
        private System.Windows.Forms.Button exit_game_button;
        private System.Windows.Forms.PictureBox settings_picture;
    }
}