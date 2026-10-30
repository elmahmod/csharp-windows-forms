using RockPaperScissorsGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsGame
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }
        Random random = new Random();
        enum enWinner
        {
            Player,
            Computer,
            Draw,
            InPorgress
        }

        enum enChoice
        {
            Rock = 1,
            Paper,
            Scissors,
            None
        }

        struct stGameStatus
        {

            public enWinner winner;
            public enChoice playerChoice;
            public enChoice computerChoice;
            public bool isGameOver;
        }

        stGameStatus gameStatus;

        void ResetGame()
        {
            gameStatus.isGameOver = false;
            gameStatus.winner = enWinner.InPorgress;
            gameStatus.playerChoice = enChoice.None;
            gameStatus.computerChoice = enChoice.None;

            pbPlayer.Image = GetChoiceImage(gameStatus.playerChoice);
            pbComputer.Image = GetChoiceImage(gameStatus.computerChoice);
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            ResetGame();
        }

        enChoice GetPlayerChoice(Button bt)
        {
            if (bt.Tag.ToString() == "Rock")
                return enChoice.Rock;
            if (bt.Tag.ToString() == "Paper")
                return enChoice.Paper;
            if (bt.Tag.ToString() == "Scissors")
                return enChoice.Scissors;

            return enChoice.None;
        }

        enChoice GetComputerChoice()
        {
            return (enChoice)random.Next(1, 4);
        }

        Image GetChoiceImage(enChoice choice)
        {
            switch (choice)
            {
                case enChoice.Rock:
                    return Resources.Rock;

                case enChoice.Paper:
                    return Resources.Paper;

                case enChoice.Scissors:
                    return Resources.Scissors;

                default:
                    return Resources.QuestionMark;
            }
        }

        void CheckWinner()
        {
            if (gameStatus.playerChoice == gameStatus.computerChoice)
            {
                gameStatus.winner = enWinner.Draw;
                gameStatus.isGameOver = true;
                return;
            }

            switch (gameStatus.playerChoice)
            {
                case enChoice.Paper:
                    if (gameStatus.computerChoice == enChoice.Rock)
                        gameStatus.winner = enWinner.Player;
                    else
                        gameStatus.winner = enWinner.Computer;
                    break;

                case enChoice.Rock:
                    if (gameStatus.computerChoice == enChoice.Scissors)
                        gameStatus.winner = enWinner.Player;
                    else
                        gameStatus.winner = enWinner.Computer;
                    break;

                case enChoice.Scissors:
                    if (gameStatus.computerChoice == enChoice.Paper)
                        gameStatus.winner = enWinner.Player;
                    else
                        gameStatus.winner = enWinner.Computer;
                    break;

                case enChoice.None:
                    gameStatus.winner = enWinner.InPorgress;
                    return;
            }
            gameStatus.isGameOver = true;
        }

        string GetWinnerName()
        {
            switch (gameStatus.winner)
            {
                case enWinner.Player:
                    return "Player";
                case enWinner.Computer:
                    return "Computer";
                case enWinner.Draw:
                    return "Draw";
                case enWinner.InPorgress:
                    return "In Progress";
            }
            return "Error";
        }

        void PlayRound(Button bt)
        {
            if (gameStatus.isGameOver)
                return;

            gameStatus.playerChoice = GetPlayerChoice(bt);
            pbPlayer.Image = GetChoiceImage(gameStatus.playerChoice);

            gameStatus.computerChoice = GetComputerChoice();
            pbComputer.Image = GetChoiceImage(gameStatus.computerChoice);

            CheckWinner();

            if (gameStatus.isGameOver)
            {
                if (gameStatus.winner == enWinner.Draw)
                    MessageBox.Show("Draw");
                else
                    MessageBox.Show($"{GetWinnerName()} Win!");
            }

            if (MessageBox.Show("Play again?", "Restart", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                ResetGame();
        }

        private void btChoice_Click(object sender, EventArgs e)
        {
            PlayRound((Button)sender);
        }
    }
}