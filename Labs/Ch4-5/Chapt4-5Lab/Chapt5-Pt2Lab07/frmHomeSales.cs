using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * 
 * Write a console application that tracks the home sales of three salespeople (Danielle, Edward, Francis):
●	The program prompts the user for a salesperson initial (d, e, or f) and the sales amount, then updates the total sales.
●	Any user can have multiple sales.
●	If the user enters "z" for the initial then the program should display the total sales for each three salesperson, the grand total for all sales, and the name of the salesperson with the highest total.
●	If the user enters an initial other than "d", "e", "f" or "z" then the program should display an error and prompt the user for a new initial.
●	All initials should be treated in a case-insensitive manner.

Program must pass all provided unit tests. (To do so, you will need to follow the format to the right closely.)
*/

namespace Chapt5_Pt2Lab07
{
    public partial class frmHomeSales : Form
    {

        string salesman = "";

        decimal sale;
        decimal danielleSales = 0m;
        decimal edwardSales = 0m;
        decimal francisSales = 0m;
        decimal mostSales = 0m;
        decimal grandTotal = 0m;
        string highestSalesman = "";

        public frmHomeSales()
        {
            InitializeComponent();
        }

        private void btnDanielle_Click(object sender, EventArgs e)
        {
            sale = Convert.ToDecimal(txtSales.Text);
            danielleSales += sale;
            
            if (danielleSales >= mostSales)
            {
                mostSales = danielleSales;
                highestSalesman = "Danielle";
            }
            grandTotal = francisSales + edwardSales + danielleSales;

            lblDanielle.Text = danielleSales.ToString("c");
            lblEdward.Text = edwardSales.ToString("c");
            lblFrancis.Text = francisSales.ToString("c");
            lblGrand.Text = grandTotal.ToString("c");
            lblHighestSalesman.Text = highestSalesman + " has the most sales";
        }

        private void btnEdward_Click(object sender, EventArgs e)
        {
            sale = Convert.ToDecimal(txtSales.Text);
            edwardSales += sale;
            
            if (edwardSales >= mostSales)
            {
                mostSales = edwardSales;
                highestSalesman = "Edward";
            }

            grandTotal = francisSales + edwardSales + danielleSales;
            lblDanielle.Text = danielleSales.ToString("c");
            lblEdward.Text = edwardSales.ToString("c");
            lblFrancis.Text = francisSales.ToString("c");
            lblGrand.Text = grandTotal.ToString("c");
            lblHighestSalesman.Text = highestSalesman + " has the most sales";
        }

        private void btnFrancis_Click(object sender, EventArgs e)
        {
            sale = Convert.ToDecimal(txtSales.Text);
            francisSales += sale;
            
            if (francisSales >= mostSales)
            {
                mostSales = francisSales;
                highestSalesman = "Francis";
            }
            grandTotal = francisSales + edwardSales + danielleSales;
            lblDanielle.Text = danielleSales.ToString("c");
            lblEdward.Text = edwardSales.ToString("c");
            lblFrancis.Text = francisSales.ToString("c");
            lblGrand.Text = grandTotal.ToString("c");
            lblHighestSalesman.Text = highestSalesman + " has the most sales";
        }

        private void frmHomeSales_Load(object sender, EventArgs e)
        {

        }
    }
}
