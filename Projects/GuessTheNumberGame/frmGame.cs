using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumberGame
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }

        Random random = new Random();
        int guessNumber;

        private void frmGame_Load(object sender, EventArgs e)
        {
            ResetGame();
        }

        void ResetGame()
        {
            guessNumber = random.Next(0, 51);

            txtGuess.Text = "";
            txtGuess.Enabled = true;
            btCheck.Enabled = true;
            btRestart.Visible = false;
            txtGuess.Focus();

        }

        void CheckAnswer()
        {

            if (!int.TryParse(txtGuess.Text, out int guess))
            {
                MessageBox.Show("Please enter a valid number!");
                txtGuess.SelectAll();
                txtGuess.Focus();
                return;
            }

            if (guess < 0 || guess > 50)
            {
                MessageBox.Show("Enter a number between 0 and 50!");
                txtGuess.SelectAll();
                txtGuess.Focus();
                return;
            }

            if (guess == guessNumber)
            {
                MessageBox.Show("YOU WIN!");

                if (MessageBox.Show("Play Again?", "Restart",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ResetGame();
                }
                else
                {
                    txtGuess.Enabled = false;
                    btCheck.Enabled = false;
                    btRestart.Visible = true;
                }

                return;
            }

            if (guess < guessNumber)
                MessageBox.Show("Your guess is too low!");
            else
                MessageBox.Show("Your guess is too high!");

            txtGuess.SelectAll();
            txtGuess.Focus();
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtGuess.Text = guessNumber.ToString();

            txtGuess.Enabled = false;
            btCheck.Enabled = false;

            btRestart.Visible = true;
        }

        private void btRestart_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
