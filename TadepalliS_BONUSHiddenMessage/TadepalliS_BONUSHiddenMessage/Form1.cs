/*****************************************************************
    PROGRAMME	:	BONUS Hidden Message

    OUTLINE		:	This program simulates the game of Hangman. The
                    player is prompted to enter a hidden word and 
                    a clue if they so desire. They are then taken
                    to the main form where they are allowed to either
                    guess a letter or the entire word, and upon taking
                    a guess are presented with a suitable message relative
                    to their guesses accuracy. After 14 guesses, the player
                    is given the option to give up and have the answer 
                    presented to them.

    PROGRAMMER	:	Saikrishna Tadepalli

    DATE		:   January 6th 2020
*****************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TadepalliS_BONUSHiddenMessage
{
    public partial class frmMain : Form
    {
        string word = "";
        string encryptedWord = "";
        int guessCount = 0;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            string clue = "";

            btnGuess.Enabled = true;
            word = Interaction.InputBox("\nPlease Enter A Hidden Message!\nPress Cancel to Exit.", "Hidden Message", "", -1, -1).ToUpper();
            encryptedWord = "";

            if (word == "")
                Application.Exit();

            clue = Interaction.InputBox("\nPlease Enter A Clue/Hint!\nPress Cancel to Skip This Step.", "Hidden Message", "", -1, -1);

            if (clue == "")
                clue = "No Clues! Good Luck!";

            for (int i = 0; i < word.Length; i++)
                if (word[i].ToString() == " ")
                    encryptedWord += " ";
                else
                    encryptedWord += "-";

            encryptedWord = encryptedWord.ToString().ToUpper();
            lblWord.Text = encryptedWord;
            lblClue.Text = clue;
            this.AcceptButton = btnGuess;
        }
        private void CheckLetter(string letter)
        {
            if (Array.IndexOf(word.ToCharArray(), Convert.ToChar(letter)) > -1)
            {
                char[] arr = encryptedWord.ToCharArray();

                for (int i = 0; i < arr.Length; i++)
                    if (word.ToCharArray()[i] == Convert.ToChar(letter))
                        arr[i] = Convert.ToChar(letter);

                encryptedWord = new string(arr);
                lblWord.Text = encryptedWord;

                if (Array.IndexOf(encryptedWord.ToCharArray(), Convert.ToChar("-")) == -1)
                    GameOver(true);
            }
            else
            {
                MessageBox.Show("There are no " + letter.ToString().ToUpper() + "'s in the hidden message. Please guess again!", "Hidden Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CheckMessage(string message)
        {
            if (message == word)
                GameOver(true);
            else
                MessageBox.Show("You have failed to guess the hidden message. Please guess again!", "Hidden Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GameOver(bool win)
        {
            btnGuess.Enabled = false;
            lblWord.Text = word;
            btnGiveUp.Visible = true;

            if (win)
                lblClue.Text = "Congratulations! You've solved the hidden message!\nYou've taken an EXPLOSIVE " + guessCount + " guesses!";
            else
                lblClue.Text = "You have given up! How sad =(";

            btnGiveUp.Text = "Play Again!";
            this.AcceptButton = btnGiveUp;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string guess = "";

            while (guess.Length == 0)
                guess = Interaction.InputBox("\nMake a Guess By Entering A Single Character!\nOR, Guess the Entire Hidden Message!", "Hidden Message", "", -1, -1);

            guess = guess.ToUpper();

            if (guess.Length == 1)
                CheckLetter(guess);
            else 
                CheckMessage(guess);

            guessCount += 1;

            if (guessCount == 14)
                btnGiveUp.Visible = true;
        }

        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            if (btnGiveUp.Text == "Give Up!")
            {
                if (MessageBox.Show("Are you sure you wish to GIVE UP?", "Hidden Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    GameOver(false);
            }
            else
            {
                btnGiveUp.Text = "Give Up!";
                btnGiveUp.Visible = false;
                guessCount = 0;
                StartGame();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
