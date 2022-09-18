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
 * LB6. Write a GUI application that estimates the cost of painting a room.  The price of the job is $6 per square foot. Assume that the room has four full walls and 9-foot ceilings.

Create the following methods:
●	Create a method named CalculateTotalArea() that accepts the length and width of the room in feet and returns the total area of the room in square feet.
●	Create a method named CalculatePaintEstimate() that accepts the total area the room in square feet and returns the total cost of the job in dollars.

All of the above methods should not have any side effects.

*/

namespace Chapt06_Lab06
{
    public partial class frmPaintingEstimate : Form
    {
        public frmPaintingEstimate()
        {
            InitializeComponent();
        }
        decimal costPerSqFt = 6.0m;
        private decimal CalculateTotalArea()
        {
            
            
            decimal width = Convert.ToDecimal(txtWidth.Text);
            decimal length = Convert.ToDecimal(txtLength.Text);
            decimal totalArea = width*length;
            return totalArea;
        }

        private decimal CalculatePaintEstimate()
        {
            decimal totalCost = CalculateTotalArea() * costPerSqFt;
            return totalCost;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal estTotCost = CalculatePaintEstimate();
            decimal totSqFt = CalculateTotalArea();
            lblTotCostOutput.Text = estTotCost.ToString("c");
            lblTotSqFtOutput.Text = totSqFt.ToString("n1");
        }
    }
}
