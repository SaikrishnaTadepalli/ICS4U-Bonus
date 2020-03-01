/*****************************************************************
    PROGRAMME	:	BONUS Student Grades

    OUTLINE		:	This program reads a file named "ICS4UStudents.txt"
                    and outputs the students names along with their
                    marks for the 3 tests, final exam, and overall 
                    average. It allows for the user to also see the
                    grade distribution by clicking a button which
                    opens a form made for the above functionality.

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
using System.IO;
using System.Text.RegularExpressions;

namespace TadepalliS_BONUSStudentGrades
{
    public partial class frmMain : Form
    {
        public static int[] distribution = new int[10];
        bool allowFrm2 = false;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnStudentGrades_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("ICS4UStudents.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                string[] characters = lines[i].Split(Convert.ToChar(","));
                characters = characters.Take(characters.Count() - 1).ToArray();

                string name = characters[0];
                string[] marks = { characters[1],characters[2],characters[3],characters[4], ""};

                double average = 0;

                for (int j = 0; j < marks.Length - 1; j++)
                {
                    string mark = new string((marks[j].Where(c => char.IsDigit(c)).ToArray()));
                    average += double.Parse(mark);
                    marks[j] += "%";
                }

                average /= marks.Length-1;

                for (int k = 0; k < distribution.Length; k++)
                {
                    if (average == 100)
                    {
                        distribution[distribution.Length - 1] += 1;
                        continue;
                    }

                    if ( average >= ((k + 1) * 10 - 10) && average <= ((k+ 1)*10 -1))
                        distribution[k] += 1;
                }

                marks[4] = string.Format("{0:F2}", average) + "%";

                lsvOut.Items.Add(name).SubItems.AddRange(marks);
            }
            allowFrm2 = true;
        }

        private void btnDistribution_Click(object sender, EventArgs e)
        {
            if (allowFrm2)
            {
                Form frm2 = new frmDistribution();
                frm2.ShowDialog();
            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            Keys pressed = e.KeyCode;

            if (Keys.Escape == pressed)
                Application.Exit();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblTitle.Text = "ICS4U REPORT CARD MARKS - " + DateTime.Now.ToString("dddd, MMMM dd, yyyy hh:mm:ss tt");
        }
    }
}
