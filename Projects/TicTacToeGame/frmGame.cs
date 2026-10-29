
using System;
using System.Drawing;
using System.Windows.Forms;
using TicTacToeGame.Properties;

namespace TicTacToeGame
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }

        enum enTurn
        {
            player1,
            player2
        }

        enum enWinner
        {
            player1,
            player2,
            draw,
            gameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public int MovesCount;
        }

        enTurn turn;
        stGameStatus GameStatus;

        private void frmGame_Load(object sender, EventArgs e)
        {
            ResetGame();
        }

        // Drawing Board
        private void frmGame_Paint(object sender, PaintEventArgs e)
        {
            using (Pen whitePen = new Pen(Color.White, 8))
            {
                whitePen.StartCap =
                    System.Drawing.Drawing2D.LineCap.Round;

                whitePen.EndCap =
                    System.Drawing.Drawing2D.LineCap.Round;

                // Horizontal Lines
                e.Graphics.DrawLine(whitePen, 400, 300, 1050, 300);
                e.Graphics.DrawLine(whitePen, 400, 460, 1050, 460);

                // Vertical Lines
                e.Graphics.DrawLine(whitePen, 610, 140, 610, 620);
                e.Graphics.DrawLine(whitePen, 840, 140, 840, 620);
            }
        }

        // Check Three Values
        bool CheckValues(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            if (pb1.Tag.ToString() != "?" &&
                pb1.Tag.ToString() == pb2.Tag.ToString() &&
                pb1.Tag.ToString() == pb3.Tag.ToString())
            {
                pb1.BackColor = Color.GreenYellow;
                pb2.BackColor = Color.GreenYellow;
                pb3.BackColor = Color.GreenYellow;

                if (pb1.Tag.ToString() == "X")
                    GameStatus.Winner = enWinner.player1;
                else
                    GameStatus.Winner = enWinner.player2;

                EndGame();
                return true;
            }

            return false;
        }

        // Check Winner
        void CheckWinner()
        {
            // Rows
            if (CheckValues(pictureBox1, pictureBox2, pictureBox3))
                return;

            if (CheckValues(pictureBox4, pictureBox5, pictureBox6))
                return;

            if (CheckValues(pictureBox7, pictureBox8, pictureBox9))
                return;

            // Columns
            if (CheckValues(pictureBox1, pictureBox4, pictureBox7))
                return;

            if (CheckValues(pictureBox2, pictureBox5, pictureBox8))
                return;

            if (CheckValues(pictureBox3, pictureBox6, pictureBox9))
                return;

            // Diagonals
            if (CheckValues(pictureBox1, pictureBox5, pictureBox9))
                return;

            if (CheckValues(pictureBox3, pictureBox5, pictureBox7))
                return;

            if (GameStatus.MovesCount == 9 && !GameStatus.GameOver)
            {
                GameStatus.Winner = enWinner.draw;
                EndGame();
            }
        }

        // End Game
        void EndGame()
        {
            GameStatus.GameOver = true;
            lblTurn.Text = "Game Over";

            switch (GameStatus.Winner)
            {
                case enWinner.player1:
                    lblWinner.Text = "Player 1";
                    break;

                case enWinner.player2:
                    lblWinner.Text = "Player 2";
                    break;

                case enWinner.draw:
                    lblWinner.Text = "Draw";
                    break;
            }
        }

        // Change Image
        void ChangeImage(PictureBox pb)
        {
            if (GameStatus.GameOver)
                return;

            if (pb.Tag.ToString() != "?")
            {
                MessageBox.Show("Wrong Choice", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (turn)
            {
                case enTurn.player1:
                    pb.Image = Resources.X;
                    pb.Tag = "X";
                    break;

                case enTurn.player2:
                    pb.Image = Resources.O;
                    pb.Tag = "O";
                    break;
            }

            GameStatus.MovesCount++;
            CheckWinner();

            if (GameStatus.GameOver)
                return;

            // Change Turn
            if (turn == enTurn.player1)
            {
                turn = enTurn.player2;
                lblTurn.Text = "Player 2";
            }
            else
            {
                turn = enTurn.player1;
                lblTurn.Text = "Player 1";
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            ChangeImage((PictureBox)sender);
        }

        // Reset PictureBox
        void ResetPictureBox(PictureBox pb)
        {
            pb.Image = Resources.QuestionMark;
            pb.Tag = "?";
            pb.BackColor = Color.Transparent;
        }

        // Reset Game
        void ResetGame()
        {
            turn = enTurn.player1;

            GameStatus.Winner = enWinner.gameInProgress;
            GameStatus.GameOver = false;
            GameStatus.MovesCount = 0;

            lblWinner.Text = "In Progress";
            lblTurn.Text = "Player 1";

            PictureBox[] boxes =
            {
                pictureBox1, pictureBox2, pictureBox3,
                pictureBox4, pictureBox5, pictureBox6,
                pictureBox7, pictureBox8, pictureBox9
            };

            foreach (PictureBox pb in boxes)
            {
                ResetPictureBox(pb);
            }
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
