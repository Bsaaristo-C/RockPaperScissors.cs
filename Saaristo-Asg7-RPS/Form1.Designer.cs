namespace Saaristo_Asg7_RPS
{
    partial class Form1
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
            this.buttonRock = new System.Windows.Forms.Button();
            this.buttonPaper = new System.Windows.Forms.Button();
            this.buttonScissors = new System.Windows.Forms.Button();
            this.pictureBoxBot = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.labelBotChoice = new System.Windows.Forms.Label();
            this.labelPlayerWinCount = new System.Windows.Forms.Label();
            this.labelBotWinCount = new System.Windows.Forms.Label();
            this.labelPlayerChoice = new System.Windows.Forms.Label();
            this.labelTotalGamesPlayed = new System.Windows.Forms.Label();
            this.labelTotaldraws = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRock
            // 
            this.buttonRock.Location = new System.Drawing.Point(26, 350);
            this.buttonRock.Name = "buttonRock";
            this.buttonRock.Size = new System.Drawing.Size(166, 68);
            this.buttonRock.TabIndex = 0;
            this.buttonRock.Tag = "R";
            this.buttonRock.Text = "Rock";
            this.buttonRock.UseVisualStyleBackColor = true;
            this.buttonRock.Click += new System.EventHandler(this.MakeChoice);
            // 
            // buttonPaper
            // 
            this.buttonPaper.Location = new System.Drawing.Point(239, 350);
            this.buttonPaper.Name = "buttonPaper";
            this.buttonPaper.Size = new System.Drawing.Size(166, 68);
            this.buttonPaper.TabIndex = 1;
            this.buttonPaper.Tag = "P";
            this.buttonPaper.Text = "Paper";
            this.buttonPaper.UseVisualStyleBackColor = true;
            this.buttonPaper.Click += new System.EventHandler(this.MakeChoice);
            // 
            // buttonScissors
            // 
            this.buttonScissors.Location = new System.Drawing.Point(453, 350);
            this.buttonScissors.Name = "buttonScissors";
            this.buttonScissors.Size = new System.Drawing.Size(166, 68);
            this.buttonScissors.TabIndex = 2;
            this.buttonScissors.Tag = "S";
            this.buttonScissors.Text = "Scissors";
            this.buttonScissors.UseVisualStyleBackColor = true;
            this.buttonScissors.Click += new System.EventHandler(this.MakeChoice);
            // 
            // pictureBoxBot
            // 
            this.pictureBoxBot.Location = new System.Drawing.Point(319, 35);
            this.pictureBoxBot.Name = "pictureBoxBot";
            this.pictureBoxBot.Size = new System.Drawing.Size(148, 115);
            this.pictureBoxBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBot.TabIndex = 3;
            this.pictureBoxBot.TabStop = false;
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.Location = new System.Drawing.Point(319, 199);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(148, 115);
            this.pictureBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlayer.TabIndex = 4;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // labelBotChoice
            // 
            this.labelBotChoice.AutoSize = true;
            this.labelBotChoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBotChoice.Location = new System.Drawing.Point(347, 9);
            this.labelBotChoice.Name = "labelBotChoice";
            this.labelBotChoice.Size = new System.Drawing.Size(82, 16);
            this.labelBotChoice.TabIndex = 5;
            this.labelBotChoice.Text = "Bot\'s Choice";
            // 
            // labelPlayerWinCount
            // 
            this.labelPlayerWinCount.AutoSize = true;
            this.labelPlayerWinCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPlayerWinCount.Location = new System.Drawing.Point(97, 164);
            this.labelPlayerWinCount.Name = "labelPlayerWinCount";
            this.labelPlayerWinCount.Size = new System.Drawing.Size(109, 16);
            this.labelPlayerWinCount.TabIndex = 6;
            this.labelPlayerWinCount.Text = "Player Win Count";
            // 
            // labelBotWinCount
            // 
            this.labelBotWinCount.AutoSize = true;
            this.labelBotWinCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBotWinCount.Location = new System.Drawing.Point(601, 164);
            this.labelBotWinCount.Name = "labelBotWinCount";
            this.labelBotWinCount.Size = new System.Drawing.Size(90, 16);
            this.labelBotWinCount.TabIndex = 7;
            this.labelBotWinCount.Text = "Bot Win Count";
            // 
            // labelPlayerChoice
            // 
            this.labelPlayerChoice.AutoSize = true;
            this.labelPlayerChoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPlayerChoice.Location = new System.Drawing.Point(347, 317);
            this.labelPlayerChoice.Name = "labelPlayerChoice";
            this.labelPlayerChoice.Size = new System.Drawing.Size(99, 16);
            this.labelPlayerChoice.TabIndex = 8;
            this.labelPlayerChoice.Text = "Player\'s choice";
            // 
            // labelTotalGamesPlayed
            // 
            this.labelTotalGamesPlayed.AutoSize = true;
            this.labelTotalGamesPlayed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTotalGamesPlayed.Location = new System.Drawing.Point(601, 217);
            this.labelTotalGamesPlayed.Name = "labelTotalGamesPlayed";
            this.labelTotalGamesPlayed.Size = new System.Drawing.Size(134, 16);
            this.labelTotalGamesPlayed.TabIndex = 9;
            this.labelTotalGamesPlayed.Text = "Total Games Played:";
            // 
            // labelTotaldraws
            // 
            this.labelTotaldraws.AutoSize = true;
            this.labelTotaldraws.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTotaldraws.Location = new System.Drawing.Point(601, 252);
            this.labelTotaldraws.Name = "labelTotaldraws";
            this.labelTotaldraws.Size = new System.Drawing.Size(82, 16);
            this.labelTotaldraws.TabIndex = 10;
            this.labelTotaldraws.Text = "Total Draws:";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(660, 333);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(119, 43);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(660, 395);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(119, 43);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelTotaldraws);
            this.Controls.Add(this.labelTotalGamesPlayed);
            this.Controls.Add(this.labelPlayerChoice);
            this.Controls.Add(this.labelBotWinCount);
            this.Controls.Add(this.labelPlayerWinCount);
            this.Controls.Add(this.labelBotChoice);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.pictureBoxBot);
            this.Controls.Add(this.buttonScissors);
            this.Controls.Add(this.buttonPaper);
            this.Controls.Add(this.buttonRock);
            this.Name = "Form1";
            this.Text = "Saaristo Asg7 RPS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRock;
        private System.Windows.Forms.Button buttonPaper;
        private System.Windows.Forms.Button buttonScissors;
        private System.Windows.Forms.PictureBox pictureBoxBot;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.Label labelBotChoice;
        private System.Windows.Forms.Label labelPlayerWinCount;
        private System.Windows.Forms.Label labelBotWinCount;
        private System.Windows.Forms.Label labelPlayerChoice;
        private System.Windows.Forms.Label labelTotalGamesPlayed;
        private System.Windows.Forms.Label labelTotaldraws;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
    }
}

