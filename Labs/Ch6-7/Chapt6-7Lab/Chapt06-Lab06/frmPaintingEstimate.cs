using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
