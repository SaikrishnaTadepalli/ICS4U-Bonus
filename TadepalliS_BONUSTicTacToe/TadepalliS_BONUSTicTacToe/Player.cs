/*****************************************************************
    PROGRAMME	:	BONUS Tic-Tac-Toe - Player Class

    OUTLINE		:	This class is built to handle the player objects
                    and their functions. The class assigns a name and
                    image to each declared player. It tracks where 
                    each player was placed on the grid and allows
                    for a check to see if a player has won. 

    PROGRAMMER	:	Saikrishna Tadepalli

    DATE		:   January 6th 2020
*****************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TadepalliS_BONUSTicTacToe
{
    class Player
    {
        public List<int> slots = new List<int>();
        public Image playerImage;
        string playerName;
        public Player(Image img, string name)
        {
            playerImage = img;
            playerName = name;
        }

        public void Reset()
        {
            slots.Clear();
        }

        public bool IsWinner()
        {
            for (int i = 1; i < 4; i++)
            {
                if (slots.Contains(1 + 3 * i) && slots.Contains(2 + 3 * i) && slots.Contains(3 + 3 * i))
                {
                    return true;
                }
            }

            for (int i = 1; i < 4; i++)
            {
                if (slots.Contains(1 + i) && slots.Contains(4 + i) && slots.Contains(7 + i))
                {
                    return true;
                }
            }

            if (slots.Contains(1) && slots.Contains(5) && slots.Contains(9))
            {
                return true;
            }
            else if (slots.Contains(3) && slots.Contains(5) && slots.Contains(7))
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return playerName.ToUpper(); 
        }

        public string ShowList()
        {
            string output = "";

            for (int i = 0; i < slots.ToArray().Length; i++)
            {
                output += slots[i] + "  ";
            }

            return output;
        }
    }
}
