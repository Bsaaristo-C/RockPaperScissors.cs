using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saaristo_Asg7_RPS
{
    public partial class Form1 : Form
    {
        string playerChoice;
        string computerChoice;
        string[] Options = { "R", "P", "S", "P", "S", "R" };
        Random random = new Random();
        int botScore;
        int playerScore;
        int totalGamesPlayed;
        int totalDraws;
        string draw;
        public Form1()
        {
            InitializeComponent();

        }

        private void MakeChoice(object sender, EventArgs e)
        {
            Button tempButton = sender as Button;
            playerChoice = (String)tempButton.Tag;
            int i = random.Next(0, Options.Length);
            computerChoice = Options[i];
            labelBotChoice.Text = "Bot is: " + updateTextAndImage(computerChoice, pictureBoxBot);
            labelPlayerChoice.Text = "Player is: " + updateTextAndImage(playerChoice, pictureBoxPlayer);
            checkGame();
        }

        private string updateTextAndImage(string text, PictureBox pic)
        {
            string word = null;
            switch (text)
            {
                case "R":
                    word = "ROCK";
                    pic.Image = Properties.Resources.rock;
                    break;
                case "P":
                    word = "PAPER";
                    pic.Image = Properties.Resources.paper;
                    break;
                case "S":
                    word = "SCISSORS";
                    pic.Image = Properties.Resources.scissors;
                    break;

            }
            return word;
        }
        private void checkGame()
        {
          if (computerChoice == playerChoice)
            {
                draw = " Draw!";
                totalGamesPlayed++;
                totalDraws++;
            }
          else if(playerChoice == "R" && computerChoice == "P" || playerChoice == "S" && computerChoice == "R" || playerChoice == "P" && computerChoice == "S")
            {
                botScore++;
                totalGamesPlayed++;
                draw = null;
            }
            else
            {
                playerScore++;
                totalGamesPlayed++;
                draw = null;
            }
            labelPlayerWinCount.Text = "Player Score: " + playerScore + Environment.NewLine + draw;
            labelBotWinCount.Text = "Bot Score: " + botScore + Environment.NewLine + draw;
            labelTotaldraws.Text = "Total Draws: " + totalDraws;
            labelTotalGamesPlayed.Text = "Total Games Played: " + totalGamesPlayed;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            labelPlayerWinCount.Text = "Player Score: ";
            labelBotWinCount.Text = "Bot Score: ";
            labelTotaldraws.Text = "Total Draws: ";
            labelTotalGamesPlayed.Text = "Total Games Played: ";
            labelBotChoice.Text = "Bot is: ";
            labelPlayerChoice.Text = "Player is: ";
            pictureBoxBot.Image = null;
            pictureBoxPlayer.Image = null;
            botScore = 0;
            playerScore = 0;
            totalGamesPlayed = 0;
            totalDraws = 0;
        }
    }
}
