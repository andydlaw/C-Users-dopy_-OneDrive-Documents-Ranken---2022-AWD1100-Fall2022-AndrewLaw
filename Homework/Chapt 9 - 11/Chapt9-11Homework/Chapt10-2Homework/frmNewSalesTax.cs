using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapt10_2Homework
{
    public partial class frmNewSalesTax : Form
    {
        decimal salesTax = 0.0775m;
        public frmNewSalesTax()
        {
            InitializeComponent();
        }

        
        private void btnOK_Click(object sender, EventArgs e)
        {


            if (txtSalesTax.Text == "")
            {
                CancelOperator();
            }
            else
            {

                salesTax = Convert.ToDecimal(txtSalesTax.Text);
                frmLunchOrder subform2 = new frmLunchOrder();
                subform2.SalesTax = salesTax;
                subform2.Show(this);
                

                decimal results = subform2.SalesTax;
                
                Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelOperator();

        }
        private void CancelOperator()
        {
            frmLunchOrder subform1 = new frmLunchOrder();
            subform1.SalesTax = 0.0775m;
            subform1.Show(this);
            Hide();
        }
    }
}
