/*****************************************************************
    PROGRAMME	:	BONUS Letters in word

    OUTLINE		:	This program asks the user to input a word into
                    a textbox, and then conceals the word. The user
                    is then prompted to enter 1 letter to guess the
                    letters that make up the originally entered word.
                    The program displays the number of occurences of 
                    each guess in the original word, and when all the
                    letters that make up the original word have been 
                    guessed, the game ends and the player is shown
                    all their guesses in alphabetic order.

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
using System.Text.RegularExpressions;

namespace TadepalliS_BONUSLettersInWord
{
    public partial class frmMain : Form
    {
        string[] letters = ("A B C D E F G H I J K L M N O P Q R S T U V W X Y Z").Split(Convert.ToChar(" "));
        bool[] containedLetters = new bool[26];
        string input = "";
        List<string> guessedLetters = new List<string>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnConfirm;
            btnGuess.Enabled = false;
            txtGuess.Enabled = false;
            txtWord.Focus();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            input = txtWord.Text;

            if (Regex.IsMatch(input, @"^[a-zA-Z]+$"))
            {
                input = input.ToString().ToUpper();

                for (int i = 0; i < containedLetters.Length; i++)
                {
                    containedLetters[i] = true;
                }

                btnConfirm.Enabled = false;
                txtWord.Enabled = false;
                txtWord.PasswordChar = Convert.ToChar("*");

                btnGuess.Enabled = true;
                this.AcceptButton = btnGuess;
                txtGuess.Enabled = true;
                txtGuess.Focus();
                lstOut.Items.Add("The word has " + input.Length + " letters.");
                lstOut.Items.Add("");
            }
            else
            {
                MessageBox.Show("Your word must only contain letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string guess = txtGuess.Text;

            if (Regex.IsMatch(guess, @"^[a-zA-Z]+$"))
            {
                guess = guess.ToString().ToUpper();

                if (containedLetters[Array.IndexOf(letters, guess)] == true)
                {
                    int count = 0;
                    containedLetters[Array.IndexOf(letters, guess)] = false;

                    for (int i = 0; i < input.Length; i++)
                    {
                        if (guess.ToString() == input[i].ToString())
                        {
                            count += 1;
                        }
                    }

                    guessedLetters.Add(guess);
                    lstOut.Items.Add("The letter " + guess + " appears " + count.ToString() + " times.");

                    guessedLetters = guessedLetters.Distinct().ToList();

                    bool cont = false;

                    for (int i = 0; i < input.Length; i++)
                    {
                        if (Array.IndexOf(guessedLetters.ToArray(),input[i].ToString())==-1)
                        {
                            cont = true;
                            break;
                        }
                    }

                    if (!cont)
                    {
                        lstOut.Items.Add("");
                        lstOut.Items.Add("Winner!");
                        lstOut.Items.Add("You have guessed all of the letters");
                        lstOut.Items.Add("The word was: " + input);
                        txtWord.PasswordChar = char.Parse("\0");
                        btnGuess.Enabled = false;
                        txtGuess.Enabled = false;
                    }
                    else
                    {
                        txtGuess.Text = "";
                        txtGuess.Focus();
                    }

                }
                else 
                {
                    MessageBox.Show("This character has already been guessed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Your guess must be a valid letter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFinishRound_Click(object sender, EventArgs e)
        {
            guessedLetters.Sort();
            string output = string.Join(",", guessedLetters);
            MessageBox.Show("Letters Guessed: " + output + ".", "Round Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnConfirm.Enabled = true;
            this.AcceptButton = btnConfirm;
            txtWord.Enabled = true;
            txtWord.Text = "";
            txtWord.Focus();
            txtGuess.Text = "";
            lstOut.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
