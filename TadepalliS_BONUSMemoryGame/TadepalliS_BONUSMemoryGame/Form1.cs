/************************************************************
    PROGRAMME : BONUS Memory Game

    OUTLINE : In this program the player gets to click on any 2 Buttons.
              Each button has a hidden letter, and if the two selected
              buttons have the same letter then they remain flipped. If 
              there is no match, the buttons go Red for a second they 
              go back to the X. When all letters are matched, the player wins.              

    PROGRAMMER : Saikrishna Tadepalli

    DATE : October 31, 2019
 ************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TadepalliS_BONUSMemoryGame
{
    public partial class Form1 : Form
    {
        Button[] btnBox = new Button[10];
        Button[] btnButtonsClicked = new Button[2];
        string[] letterArray = new string[10];
        int clickCount = 0;
        int finished = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < btnBox.Length; i++)
            {
                btnBox[i] = (this.Controls[("btnBox" + i)] as Button);
                btnBox[i].Click += new EventHandler(clickedButton);
                btnBox[i].Enabled = false;
                btnBox[i].BackColor = Color.White;
            }
        }
        private void clickedButton(object sender, System.EventArgs e)
        {
            clickCount += 1;
            btnButtonsClicked[1] = btnButtonsClicked[0];
            btnButtonsClicked[0] = sender as Button;
            btnButtonsClicked[0].Text = letterArray[Array.IndexOf(btnBox, btnButtonsClicked[0])];                        

                if (clickCount % 2 == 0)
                {
                    if (btnButtonsClicked[0].Text == btnButtonsClicked[1].Text)
                    {
                        for (int i = 0; i < btnButtonsClicked.Length; i++)
                        {
                            btnButtonsClicked[i].BackColor = Color.LightGreen;
                            btnButtonsClicked[i].Enabled = false;
                            btnButtonsClicked[i] = null;
                        }
                        finished += 1;
                    }
                else
                    {
                        btnButtonsClicked[0].BackColor = Color.Red;
                        btnButtonsClicked[1].BackColor = Color.Red;
                    for (int i = 0; i < btnBox.Length; i++)
                        btnBox[i].Enabled = false;
                    this.Refresh();
                        Thread.Sleep(500);
                    for (int i = 0; i < btnBox.Length; i++)
                        btnBox[i].Enabled = true;
                    for (int i = 0; i < btnButtonsClicked.Length; i++)
                        {
                            btnButtonsClicked[i].Enabled = true;
                            btnButtonsClicked[i].BackColor = Color.White;
                            btnButtonsClicked[i].Text = "X";
                        }
                    }
                }
                else
                {
                    btnButtonsClicked[0].BackColor = Color.LightGray;
                    btnButtonsClicked[0].Enabled = false;
                }

            if (finished == 5)
                MessageBox.Show("Winner!","Memory Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < btnBox.Length; i++)
            {
                btnBox[i].BackColor = Color.White;
                btnBox[i].Text = "X";
                btnBox[i].Enabled = true;
            }
            finished = 0; clickCount = 0;
            GenerateLetters();
        }
        private void GenerateLetters()
        {
            Random rand = new Random();
            letterArray = ("A A B B C C D D E E").Split(Convert.ToChar(" ")).OrderBy(x => rand.Next()).ToArray();
        }
    }
}
