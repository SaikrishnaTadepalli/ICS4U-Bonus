/************************************************************
    PROGRAMME : BONUS Apartment Rentals

    OUTLINE : The programme prompts the user to input the number
              of apartment units, the rent to occupy one of the 
              units, the increase in rent that results in a vacant 
              unit, and the amount to maintain a rented unit.The 
              program then calculates the number of units to be 
              rented in order to make the maximum profit.

    PROGRAMMER : Saikrishna Tadepalli

    DATE : January 6th 2020
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

namespace TadepalliS_BONUSAppartmentRental
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            if ((CheckDouble(txtAppartmentUnits) && CheckDouble(txtRentAll) && CheckDouble(txtRentIncrease) && CheckDouble(txtMaintainUnit)))
            {
                double appartmentsMax = Double.Parse(txtAppartmentUnits.Text);
                double rentPerUnit = Double.Parse(txtRentAll.Text);
                double rentIncrease = Double.Parse(txtRentIncrease.Text);
                double maintainanceCost = Double.Parse(txtMaintainUnit.Text);

                double rooms = Math.Round(((rentPerUnit - maintainanceCost + rentIncrease*appartmentsMax)/rentIncrease)/2);
                double profit = (rooms) * (rentPerUnit - maintainanceCost + rentIncrease * (appartmentsMax - rooms));

                lblOut.Text = "The number of units to rent to make the maximum profit of " + profit.ToString("C") + " is " + rooms + " units.";
            }
        }

        private bool CheckDouble(TextBox t)
        {
            double outVar = new double();
            string errorMessage = "Invalid Input!";

            if (double.TryParse(t.Text, out outVar))
                return true;
            else
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            return false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
