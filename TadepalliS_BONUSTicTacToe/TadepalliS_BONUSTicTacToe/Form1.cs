/*****************************************************************
    PROGRAMME	:	BONUS Tic-Tac-Toe

    OUTLINE		:	This program allows two players to play the gam
                    of Tic-Tac-Toe. Each player takes turns to make
                    thier move until either someone wins or the game
                    ends at a stalemate.

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

namespace TadepalliS_BONUSTicTacToe
{
    public partial class frmMain : Form
    {
        private PictureBox[,] picCol = new PictureBox[3,3];

        Player x = new Player(Properties.Resources.X, "X");
        Player o = new Player(Properties.Resources.O, "O");
        Player currentPlayer;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            for (int r = 0; r < 3; r++)
                for (int s = 0; s < 3; s++)
                    picCol[r, s] = (PictureBox)(Controls["picBox" + r.ToString() + s.ToString()]);

            for (int r = 0; r < 3; r++)
            {
                for (int s = 0; s < 3; s++)
                {
                    picCol[r, s].Image = Properties.Resources.blank;
                    picCol[r, s].Click += new EventHandler(PicClicked);
                    picCol[r, s].Enabled = false;
                }
            }
        }

        private void PicClicked(object sender, EventArgs e)
        {
            PictureBox picClicked = (PictureBox)sender;
            picClicked.Image = currentPlayer.playerImage;

            int clickedR = int.Parse(picClicked.Name[6].ToString());
            int clickedS = int.Parse(picClicked.Name[7].ToString());

            currentPlayer.slots.Add((clickedS+ 1) + 3* clickedR);

            if (currentPlayer.IsWinner())
            {
                GameOver("Game Over.\nPlayer " + currentPlayer.ToString() + " is the Winner!");
            }
            else if ((x.slots.ToArray().Length + o.slots.ToArray().Length) == 9)
            {
                GameOver("Game Over.\nThere was no Winner.");
            }
            else
            {
                if (currentPlayer == x)
                    currentPlayer = o;
                else if (currentPlayer == o)
                    currentPlayer = x;

                lblStatusOut.Text = "Player " + currentPlayer.ToString() + "'s Turn";
            }
        }

        private void GameOver(string outStr)
        {
            lblStatusOut.Text = outStr;

            for (int r = 0; r < 3; r++) 
                for (int s = 0; s < 3; s++) 
                    picCol[r, s].Enabled = false; 

            x.Reset();
            o.Reset();

            btnPlay.Enabled = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            for (int r = 0; r < 3; r++)
            {
                for (int s = 0; s < 3; s++)
                {
                    picCol[r, s].Image = Properties.Resources.blank;
                    picCol[r, s].Enabled = true;
                }
            }

            btnPlay.Enabled = false;
            currentPlayer = x;
            lblStatusOut.Text = "Player "+currentPlayer.ToString() + "'s Turn";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
