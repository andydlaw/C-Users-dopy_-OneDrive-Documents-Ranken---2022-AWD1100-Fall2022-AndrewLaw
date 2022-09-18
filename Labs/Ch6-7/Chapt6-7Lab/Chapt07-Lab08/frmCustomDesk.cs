using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * LB8. Write a GUI application that estimates the cost of a custom built desk based on a few of factors.

The user can select from four kinds of wood:
●	Enter "m" for mahogany
●	Enter "o" for oak
●	Enter "p" for pine
●	Enter anything else for other 

Pine desks have a base cost of $100.
Oak desks have a base cost of $140.
All other woods have a base cost of $180.
There is a $30 surcharge added for each drawer.

Create the following methods:
●	GetWood() accepts no parameters, and returns the type of wood as a string ("mahogany", "oak", "pine", "other").
●	GetDrawers() accepts no parameters, and returns the number of drawers as an int.
●	CalculateWoodCost() accepts type of wood as a string, and returns the cost of the wood as a double.
●	CalculateDrawerCost() accepts the number of drawers as an int, and returns the cost of the drawers as a double.
●	CalculateTotalCost() accepts type of wood as a string and the number of drawers as an int, and returns the total cost of the desk as a double.

All of the above methods should not have any side effects.
*/

namespace Chapt07_Lab08
{
    public partial class frmCustomDesk : Form
    {
        public frmCustomDesk()
        {
            InitializeComponent();
        }
        string woodType;
        string wood;
        int drawers;
        decimal woodPrice;
        decimal drawerPrice = 30.0m;
        decimal drawerTotalPrice;
        decimal totalCost;
        private void btnEstimate_Click(object sender, EventArgs e)
        {
            bool keepGoing = true;  //Flag


            // Call routine to validate textbox not empty
            keepGoing = IsPresent(txtTypeOfWood);
            if (keepGoing)
            {
                // Call routine to validate textbox numeric
                keepGoing = IsPresent(txtNumOfDrawers);
            }
            if (keepGoing)
            {
                GetWood();
                GetDrawers();
                CalculateWoodCost();
                CalculateDrawerCost();
                CalculateTotalCost();
            }
            else
            {
                return;
            }
        }

        private bool IsPresent(TextBox textBox)
        {            
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field.", textBox.Tag + " WAS NOT PROVIDED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
            return true;
        }
        private void GetWood()
        {
            woodType = txtTypeOfWood.Text;
            if (woodType == "m" || woodType == "M")
            {
                wood = "mahogany";
            }
            else if (woodType == "o" || woodType == "O")
            {
                wood = "oak";
            }
            else if (woodType == "P" || woodType == "p")
            {
                wood = "pine";
            }
            else
            {
                wood = "other";
            }
        }
        private void GetDrawers()
        {
            drawers = Convert.ToInt32(txtNumOfDrawers.Text);
        }
        private void CalculateWoodCost()
        {
            if (wood == "pine")
            {
                woodPrice = 100.00m;
                lblCostOfWood.Text = woodPrice.ToString("c");
            }
            else if (wood == "oak")
            {
                woodPrice = 140.00m;
                lblCostOfWood.Text = woodPrice.ToString("c");
            }
            else if (wood == "mahogany")
            {
                woodPrice = 180.00m;
                lblCostOfWood.Text = woodPrice.ToString("c");
            }
            else if (wood == "other")
            {
                woodPrice = 180.00m;
                lblCostOfWood.Text = woodPrice.ToString("c");
            }
        }
        private void CalculateDrawerCost()
        {
            drawerTotalPrice = drawers * drawerPrice;
            lblCostOfDrawers.Text = drawerTotalPrice.ToString("c");
        }
        private void CalculateTotalCost() 
        {
            totalCost = woodPrice + drawerTotalPrice;
            lblTotalCost.Text = totalCost.ToString("c");
        }

    }
}
