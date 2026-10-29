using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeVersion2.Properties;

namespace TicTacToeVersion2
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }

        enum enPlayerTurn
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            InProgress
        }

        struct stGameStatus
        {
            public int movesCount;
            public bool isGameOver;
            public enWinner winner;
        }

        stGameStatus gameStatus;
        enPlayerTurn playerTurn;

        private void frmGame_Load(object sender, EventArgs e)
        {
            ResetGame();
        }

        bool CheckValue(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.OliveDrab;
                btn2.BackColor = Color.OliveDrab;
                btn3.BackColor = Color.OliveDrab;

                if (btn1.Tag.ToString() == "X")
                    gameStatus.winner = enWinner.Player1;
                else
                    gameStatus.winner = enWinner.Player2;

                gameStatus.isGameOver = true;
                return true;
            }


            gameStatus.isGameOver = false;
            return false;
        }

        void CheckWinner()
        {
            if (CheckValue(btn1, btn2, btn3))
                return;

            if (CheckValue(btn4, btn5, btn6))
                return;

            if (CheckValue(btn7, btn8, btn9))
                return;

            if (CheckValue(btn1, btn4, btn7))
                return;

            if (CheckValue(btn2, btn5, btn8))
                return;

            if (CheckValue(btn3, btn6, btn9))
                return;

            if (CheckValue(btn1, btn5, btn9))
                return;

            if (CheckValue(btn3, btn5, btn7))
                return;

            if (!gameStatus.isGameOver && gameStatus.movesCount == 9)
            {
                gameStatus.winner = enWinner.Draw;
                gameStatus.isGameOver = true;
                return;
            }
        }

        string GetPlayerName()
        {
            switch (playerTurn)
            {
                case enPlayerTurn.Player1:
                    return "Mohammed";
                case enPlayerTurn.Player2:
                    return "Ali";
            }
            return "None";
        }

        string GetWinnerName()
        {
            switch (gameStatus.winner)
            {
                case enWinner.Player1:
                    return GetPlayerName();

                case enWinner.Player2:
                    return GetPlayerName();

                case enWinner.Draw:
                    return "Draw";

                case enWinner.InProgress:
                    return "In Progress";
            }
            return "Error";
        }

        void ChangeImage(Button btn)
        {
            if (gameStatus.isGameOver)
                return;

            if (btn.Tag.ToString() != "?")
            {
                MessageBox.Show("Already changed", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (playerTurn)
            {
                case enPlayerTurn.Player1:
                    btn.Tag = "X";
                    btn.BackgroundImage = Resources.X;
                    break;

                case enPlayerTurn.Player2:
                    btn.Tag = "O";
                    btn.BackgroundImage = Resources.O;
                    break;

            }

            gameStatus.movesCount++;

            CheckWinner();

            // ends?
            if (gameStatus.isGameOver)
            {
                
                lblWinner.Text = GetWinnerName();
                lblTurn.Text = "Game Over!";
                if (gameStatus.winner == enWinner.Draw)
                    MessageBox.Show("It's a Draw!", "Game Over");
                else
                    MessageBox.Show($"{lblWinner.Text} Wins! Congratulations!", "Game Over");

                return;
            }

            // Continues?
            switch (playerTurn)
            {
                case enPlayerTurn.Player1:
                    playerTurn = enPlayerTurn.Player2;
                    break;

                case enPlayerTurn.Player2:
                    playerTurn = enPlayerTurn.Player1;
                    break;
            }
            lblTurn.Text = GetPlayerName();
        }
        private void btnImage_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }

        // reset section
        void ResetButton(Button btn)
        {
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;
            btn.BackgroundImage = Resources.QuestionMark;
        }

        void ResetGame()
        {
            gameStatus.winner = enWinner.InProgress;
            lblWinner.Text = GetWinnerName();

            playerTurn = enPlayerTurn.Player1;
            lblTurn.Text = GetPlayerName();

            gameStatus.movesCount = 0;
            gameStatus.isGameOver = false;
            lblWinner.ForeColor = Color.Teal;
            lblTurn.ForeColor = Color.Teal;

            Button[] buttons =
            {   btn1, btn2, btn3,
                btn4, btn5, btn6,
                btn7, btn8, btn9
            };

            foreach (Button btn in buttons)
            {
                ResetButton(btn);
            }
        }
        private void btnResetGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void lblWinner_TextChanged(object sender, EventArgs e)
        {
            if (gameStatus.isGameOver)
            {
                lblWinner.ForeColor = Color.Firebrick;
                lblTurn.ForeColor = Color.Firebrick;
            }
        }
    }
}
