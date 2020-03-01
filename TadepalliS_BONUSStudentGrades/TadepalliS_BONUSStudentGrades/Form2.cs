/*****************************************************************
    PROGRAMME	:	BONUS Student Grades

    OUTLINE		:	This form uses the data interpreted by frmMain
                    to create a visual distribution of the final
                    averages of the class, presented in ranges of 10
                    from 0- 100%. The data is outputted to a listbox.

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

namespace TadepalliS_BONUSStudentGrades
{
    public partial class frmDistribution : Form
    {
        public frmDistribution()
        {
            InitializeComponent();
        }

        private void frmDistribution_Load(object sender, EventArgs e)
        {
            string output = "";

            for (int i = 0; i < frmMain.distribution.Length; i++)
            {
                if (i == frmMain.distribution.Length - 1)
                {
                    int min = ((i + 1) * 10 - 10);
                    lstOut.Items.Add((min.ToString("D2") + " - 100 % : " + GetAsterisk(frmMain.distribution[i])));
                }
                else
                {
                    int min = ((i + 1) * 10 - 10);
                    int max = ((i + 1) * 10 - 1);
                    lstOut.Items.Add(("  "+ min.ToString("D2") + " - " + max.ToString("D2") + " % : " + GetAsterisk(frmMain.distribution[i])));
                }
            }
        }

        private string GetAsterisk(int length)
        {
            string output = "";

            for (int i = 0; i < length; i++)
                output += "*";

            return output;
        }
    }
}
