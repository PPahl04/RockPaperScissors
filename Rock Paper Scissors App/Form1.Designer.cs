namespace Rock_Paper_Scissors_App
{
    partial class RPS_Game
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
            this.Rock = new System.Windows.Forms.Button();
            this.Paper = new System.Windows.Forms.Button();
            this.Scissors = new System.Windows.Forms.Button();
            this.ScoreField = new System.Windows.Forms.RichTextBox();
            this.CurrentInfo = new System.Windows.Forms.RichTextBox();
            this.NumberOfTies = new System.Windows.Forms.RichTextBox();
            this.CurrentMove = new System.Windows.Forms.RichTextBox();
            this.PlayerHandPaper = new System.Windows.Forms.PictureBox();
            this.PlayerHandScissors = new System.Windows.Forms.PictureBox();
            this.PlayerHandRock = new System.Windows.Forms.PictureBox();
            this.EnemyHandRock = new System.Windows.Forms.PictureBox();
            this.EnemyHand = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.PlayerHand = new System.Windows.Forms.PictureBox();
            this.EnemyConfused = new System.Windows.Forms.PictureBox();
            this.EnemyHappy = new System.Windows.Forms.PictureBox();
            this.EnemySad = new System.Windows.Forms.PictureBox();
            this.EnemyHappy2 = new System.Windows.Forms.PictureBox();
            this.EnemyConfused2 = new System.Windows.Forms.PictureBox();
            this.EnemySad2 = new System.Windows.Forms.PictureBox();
            this.EnemyHandScissors = new System.Windows.Forms.PictureBox();
            this.EnemyHandPaper = new System.Windows.Forms.PictureBox();
            this.BeginningTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHandPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHandScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHandRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHandRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyConfused)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemySad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHappy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyConfused2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemySad2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHandScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHandPaper)).BeginInit();
            this.SuspendLayout();
            // 
            // Rock
            // 
            this.Rock.BackColor = System.Drawing.Color.SeaShell;
            this.Rock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rock.FlatAppearance.BorderSize = 0;
            this.Rock.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rock.Location = new System.Drawing.Point(27, 414);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(114, 63);
            this.Rock.TabIndex = 0;
            this.Rock.Text = "Rock";
            this.Rock.UseVisualStyleBackColor = false;
            this.Rock.Click += new System.EventHandler(this.Rock_Click);
            // 
            // Paper
            // 
            this.Paper.BackColor = System.Drawing.Color.SeaShell;
            this.Paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Paper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Paper.FlatAppearance.BorderSize = 0;
            this.Paper.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paper.Location = new System.Drawing.Point(196, 414);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(114, 63);
            this.Paper.TabIndex = 1;
            this.Paper.Text = "Paper";
            this.Paper.UseVisualStyleBackColor = false;
            this.Paper.Click += new System.EventHandler(this.Paper_Click);
            // 
            // Scissors
            // 
            this.Scissors.BackColor = System.Drawing.Color.SeaShell;
            this.Scissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Scissors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Scissors.FlatAppearance.BorderSize = 0;
            this.Scissors.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scissors.Location = new System.Drawing.Point(359, 414);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(114, 63);
            this.Scissors.TabIndex = 2;
            this.Scissors.Text = "Scissors";
            this.Scissors.UseVisualStyleBackColor = false;
            this.Scissors.Click += new System.EventHandler(this.Scissors_Click);
            // 
            // ScoreField
            // 
            this.ScoreField.BackColor = System.Drawing.Color.Plum;
            this.ScoreField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScoreField.Cursor = System.Windows.Forms.Cursors.Default;
            this.ScoreField.Font = new System.Drawing.Font("Bahnschrift", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreField.Location = new System.Drawing.Point(210, 23);
            this.ScoreField.Name = "ScoreField";
            this.ScoreField.ReadOnly = true;
            this.ScoreField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScoreField.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ScoreField.Size = new System.Drawing.Size(119, 46);
            this.ScoreField.TabIndex = 5;
            this.ScoreField.Text = "0-0";
            // 
            // CurrentInfo
            // 
            this.CurrentInfo.BackColor = System.Drawing.Color.Plum;
            this.CurrentInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.CurrentInfo.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentInfo.Location = new System.Drawing.Point(185, 304);
            this.CurrentInfo.Name = "CurrentInfo";
            this.CurrentInfo.ReadOnly = true;
            this.CurrentInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.CurrentInfo.Size = new System.Drawing.Size(176, 73);
            this.CurrentInfo.TabIndex = 7;
            this.CurrentInfo.Text = "Make your choice.";
            this.CurrentInfo.Visible = false;
            // 
            // NumberOfTies
            // 
            this.NumberOfTies.BackColor = System.Drawing.Color.Plum;
            this.NumberOfTies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumberOfTies.Cursor = System.Windows.Forms.Cursors.Default;
            this.NumberOfTies.Font = new System.Drawing.Font("Bahnschrift", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfTies.Location = new System.Drawing.Point(12, 23);
            this.NumberOfTies.Name = "NumberOfTies";
            this.NumberOfTies.ReadOnly = true;
            this.NumberOfTies.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumberOfTies.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.NumberOfTies.Size = new System.Drawing.Size(143, 46);
            this.NumberOfTies.TabIndex = 17;
            this.NumberOfTies.Text = "Ties: ";
            // 
            // CurrentMove
            // 
            this.CurrentMove.BackColor = System.Drawing.Color.Plum;
            this.CurrentMove.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentMove.Cursor = System.Windows.Forms.Cursors.Default;
            this.CurrentMove.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentMove.Location = new System.Drawing.Point(27, 254);
            this.CurrentMove.Name = "CurrentMove";
            this.CurrentMove.ReadOnly = true;
            this.CurrentMove.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.CurrentMove.Size = new System.Drawing.Size(99, 30);
            this.CurrentMove.TabIndex = 21;
            this.CurrentMove.Text = "Your hand:";
            this.CurrentMove.Visible = false;
            // 
            // PlayerHandPaper
            // 
            this.PlayerHandPaper.BackColor = System.Drawing.Color.Transparent;
            this.PlayerHandPaper.Image = global::Rock_Paper_Scissors_App.Properties.Resources.PlayerHandPaper;
            this.PlayerHandPaper.Location = new System.Drawing.Point(12, 289);
            this.PlayerHandPaper.Name = "PlayerHandPaper";
            this.PlayerHandPaper.Size = new System.Drawing.Size(129, 119);
            this.PlayerHandPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerHandPaper.TabIndex = 13;
            this.PlayerHandPaper.TabStop = false;
            // 
            // PlayerHandScissors
            // 
            this.PlayerHandScissors.BackColor = System.Drawing.Color.Transparent;
            this.PlayerHandScissors.Image = global::Rock_Paper_Scissors_App.Properties.Resources.PlayerHandScissors;
            this.PlayerHandScissors.Location = new System.Drawing.Point(12, 289);
            this.PlayerHandScissors.Name = "PlayerHandScissors";
            this.PlayerHandScissors.Size = new System.Drawing.Size(129, 119);
            this.PlayerHandScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerHandScissors.TabIndex = 12;
            this.PlayerHandScissors.TabStop = false;
            // 
            // PlayerHandRock
            // 
            this.PlayerHandRock.BackColor = System.Drawing.Color.Transparent;
            this.PlayerHandRock.Image = global::Rock_Paper_Scissors_App.Properties.Resources.PlayerHandRock;
            this.PlayerHandRock.Location = new System.Drawing.Point(27, 321);
            this.PlayerHandRock.Name = "PlayerHandRock";
            this.PlayerHandRock.Size = new System.Drawing.Size(99, 87);
            this.PlayerHandRock.TabIndex = 11;
            this.PlayerHandRock.TabStop = false;
            // 
            // EnemyHandRock
            // 
            this.EnemyHandRock.BackColor = System.Drawing.Color.Transparent;
            this.EnemyHandRock.Image = global::Rock_Paper_Scissors_App.Properties.Resources.EnemyRock;
            this.EnemyHandRock.Location = new System.Drawing.Point(350, 197);
            this.EnemyHandRock.Name = "EnemyHandRock";
            this.EnemyHandRock.Size = new System.Drawing.Size(73, 64);
            this.EnemyHandRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyHandRock.TabIndex = 8;
            this.EnemyHandRock.TabStop = false;
            this.EnemyHandRock.Visible = false;
            // 
            // EnemyHand
            // 
            this.EnemyHand.BackColor = System.Drawing.Color.Transparent;
            this.EnemyHand.Image = global::Rock_Paper_Scissors_App.Properties.Resources.EnemyHand;
            this.EnemyHand.Location = new System.Drawing.Point(350, 114);
            this.EnemyHand.Name = "EnemyHand";
            this.EnemyHand.Size = new System.Drawing.Size(83, 77);
            this.EnemyHand.TabIndex = 4;
            this.EnemyHand.TabStop = false;
            // 
            // Enemy
            // 
            this.Enemy.BackColor = System.Drawing.Color.Transparent;
            this.Enemy.Image = global::Rock_Paper_Scissors_App.Properties.Resources.EnemyNormal;
            this.Enemy.Location = new System.Drawing.Point(162, 98);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(167, 163);
            this.Enemy.TabIndex = 3;
            this.Enemy.TabStop = false;
            // 
            // PlayerHand
            // 
            this.PlayerHand.BackColor = System.Drawing.Color.Transparent;
            this.PlayerHand.Image = global::Rock_Paper_Scissors_App.Properties.Resources.PlayerHand;
            this.PlayerHand.Location = new System.Drawing.Point(12, 251);
            this.PlayerHand.Name = "PlayerHand";
            this.PlayerHand.Size = new System.Drawing.Size(99, 87);
            this.PlayerHand.TabIndex = 6;
            this.PlayerHand.TabStop = false;
            // 
            // EnemyConfused
            // 
            this.EnemyConfused.BackColor = System.Drawing.Color.Transparent;
            this.EnemyConfused.Image = global::Rock_Paper_Scissors_App.Properties.Resources.EnemyTie;
            this.EnemyConfused.Location = new System.Drawing.Point(162, 98);
            this.EnemyConfused.Name = "EnemyConfused";
            this.EnemyConfused.Size = new System.Drawing.Size(167, 163);
            this.EnemyConfused.TabIndex = 14;
            this.EnemyConfused.TabStop = false;
            this.EnemyConfused.Visible = false;
            // 
            // EnemyHappy
            // 
            this.EnemyHappy.BackColor = System.Drawing.Color.Transparent;
            this.EnemyHappy.Image = global::Rock_Paper_Scissors_App.Properties.Resources.EnemyWin;
            this.EnemyHappy.Location = new System.Drawing.Point(162, 98);
            this.EnemyHappy.Name = "EnemyHappy";
            this.EnemyHappy.Size = new System.Drawing.Size(167, 163);
            this.EnemyHappy.TabIndex = 16;
            this.EnemyHappy.TabStop = false;
            this.EnemyHappy.Visible = false;
            // 
            // EnemySad
            // 
            this.EnemySad.BackColor = System.Drawing.Color.Transparent;
            this.EnemySad.Image = global::Rock_Paper_Scissors_App.Properties.Resources.EnemyLost;
            this.EnemySad.Location = new System.Drawing.Point(162, 98);
            this.EnemySad.Name = "EnemySad";
            this.EnemySad.Size = new System.Drawing.Size(167, 163);
            this.EnemySad.TabIndex = 15;
            this.EnemySad.TabStop = false;
            this.EnemySad.Visible = false;
            // 
            // EnemyHappy2
            // 
            this.EnemyHappy2.BackColor = System.Drawing.Color.Transparent;
            this.EnemyHappy2.Image = global::Rock_Paper_Scissors_App.Properties.Resources.EnemyLaugh;
            this.EnemyHappy2.Location = new System.Drawing.Point(162, 98);
            this.EnemyHappy2.Name = "EnemyHappy2";
            this.EnemyHappy2.Size = new System.Drawing.Size(167, 163);
            this.EnemyHappy2.TabIndex = 18;
            this.EnemyHappy2.TabStop = false;
            this.EnemyHappy2.Visible = false;
            // 
            // EnemyConfused2
            // 
            this.EnemyConfused2.BackColor = System.Drawing.Color.Transparent;
            this.EnemyConfused2.Image = global::Rock_Paper_Scissors_App.Properties.Resources.EnemyConfused;
            this.EnemyConfused2.Location = new System.Drawing.Point(162, 98);
            this.EnemyConfused2.Name = "EnemyConfused2";
            this.EnemyConfused2.Size = new System.Drawing.Size(167, 163);
            this.EnemyConfused2.TabIndex = 19;
            this.EnemyConfused2.TabStop = false;
            this.EnemyConfused2.Visible = false;
            // 
            // EnemySad2
            // 
            this.EnemySad2.BackColor = System.Drawing.Color.Transparent;
            this.EnemySad2.Image = global::Rock_Paper_Scissors_App.Properties.Resources.EnemySad;
            this.EnemySad2.Location = new System.Drawing.Point(162, 98);
            this.EnemySad2.Name = "EnemySad2";
            this.EnemySad2.Size = new System.Drawing.Size(167, 163);
            this.EnemySad2.TabIndex = 20;
            this.EnemySad2.TabStop = false;
            this.EnemySad2.Visible = false;
            // 
            // EnemyHandScissors
            // 
            this.EnemyHandScissors.BackColor = System.Drawing.Color.Transparent;
            this.EnemyHandScissors.Image = global::Rock_Paper_Scissors_App.Properties.Resources.EnemyScissors;
            this.EnemyHandScissors.Location = new System.Drawing.Point(350, 174);
            this.EnemyHandScissors.Name = "EnemyHandScissors";
            this.EnemyHandScissors.Size = new System.Drawing.Size(97, 87);
            this.EnemyHandScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyHandScissors.TabIndex = 10;
            this.EnemyHandScissors.TabStop = false;
            this.EnemyHandScissors.Visible = false;
            // 
            // EnemyHandPaper
            // 
            this.EnemyHandPaper.BackColor = System.Drawing.Color.Transparent;
            this.EnemyHandPaper.Image = global::Rock_Paper_Scissors_App.Properties.Resources.EnemyPaper;
            this.EnemyHandPaper.Location = new System.Drawing.Point(350, 174);
            this.EnemyHandPaper.Name = "EnemyHandPaper";
            this.EnemyHandPaper.Size = new System.Drawing.Size(97, 87);
            this.EnemyHandPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyHandPaper.TabIndex = 9;
            this.EnemyHandPaper.TabStop = false;
            this.EnemyHandPaper.Visible = false;
            // 
            // BeginningTextBox
            // 
            this.BeginningTextBox.BackColor = System.Drawing.Color.Plum;
            this.BeginningTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BeginningTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.BeginningTextBox.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginningTextBox.Location = new System.Drawing.Point(117, 304);
            this.BeginningTextBox.Name = "BeginningTextBox";
            this.BeginningTextBox.ReadOnly = true;
            this.BeginningTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BeginningTextBox.Size = new System.Drawing.Size(261, 53);
            this.BeginningTextBox.TabIndex = 22;
            this.BeginningTextBox.Text = "Make your choice.";
            // 
            // RPS_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 489);
            this.Controls.Add(this.BeginningTextBox);
            this.Controls.Add(this.CurrentMove);
            this.Controls.Add(this.ScoreField);
            this.Controls.Add(this.NumberOfTies);
            this.Controls.Add(this.EnemyHandRock);
            this.Controls.Add(this.CurrentInfo);
            this.Controls.Add(this.EnemyHand);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Rock);
            this.Controls.Add(this.PlayerHand);
            this.Controls.Add(this.EnemyConfused);
            this.Controls.Add(this.EnemyHappy);
            this.Controls.Add(this.EnemySad);
            this.Controls.Add(this.EnemyHappy2);
            this.Controls.Add(this.EnemyConfused2);
            this.Controls.Add(this.EnemySad2);
            this.Controls.Add(this.EnemyHandScissors);
            this.Controls.Add(this.EnemyHandPaper);
            this.Controls.Add(this.PlayerHandPaper);
            this.Controls.Add(this.PlayerHandScissors);
            this.Controls.Add(this.PlayerHandRock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RPS_Game";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors";
            this.Load += new System.EventHandler(this.RPS_Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHandPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHandScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHandRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHandRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyConfused)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemySad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHappy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyConfused2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemySad2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHandScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyHandPaper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Rock;
        private System.Windows.Forms.Button Paper;
        private System.Windows.Forms.Button Scissors;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.PictureBox EnemyHand;
        private System.Windows.Forms.RichTextBox ScoreField;
        private System.Windows.Forms.PictureBox PlayerHand;
        private System.Windows.Forms.RichTextBox CurrentInfo;
        private System.Windows.Forms.PictureBox EnemyHandRock;
        private System.Windows.Forms.PictureBox EnemyHandPaper;
        private System.Windows.Forms.PictureBox EnemyHandScissors;
        private System.Windows.Forms.PictureBox PlayerHandRock;
        private System.Windows.Forms.PictureBox PlayerHandScissors;
        private System.Windows.Forms.PictureBox PlayerHandPaper;
        private System.Windows.Forms.PictureBox EnemyConfused;
        private System.Windows.Forms.PictureBox EnemySad;
        private System.Windows.Forms.PictureBox EnemyHappy;
        private System.Windows.Forms.RichTextBox NumberOfTies;
        private System.Windows.Forms.PictureBox EnemyHappy2;
        private System.Windows.Forms.PictureBox EnemyConfused2;
        private System.Windows.Forms.PictureBox EnemySad2;
        private System.Windows.Forms.RichTextBox CurrentMove;
        private System.Windows.Forms.RichTextBox BeginningTextBox;
    }
}

