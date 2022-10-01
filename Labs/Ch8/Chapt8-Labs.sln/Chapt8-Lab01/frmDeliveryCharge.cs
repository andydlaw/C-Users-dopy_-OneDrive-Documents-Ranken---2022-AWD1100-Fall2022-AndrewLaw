using System;
using System.Windows.Forms;

/*
 * LB4. Write a GUI application that calculates delivery charges to 10 different zip codes based on the following table.

Program must pass all provided unit tests. Program must store this table in a pair of parallel arrays and use an appropriate loop.
*/

namespace Chapt8_Lab01
{
    public partial class frmDeliveryCharge : Form
    {
        string[] zipCode = { "63101", "63103", "63105", "63109", "63113", "63118", "63130", "63133", "63136", "63137" };
        string[] deliveryCharge = { "$20.00", "$12.00", "$25.00", "$15.00", "$10.00", "$23.00", "$18.00", "$20.00", "$17.00", "$12.00" };
        public frmDeliveryCharge()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string result = txtZipCode.Text;
            for (int i = 0; i < zipCode.Length; ++i)
            {
                if ((zipCode[i] == (result)))
                {

                    lblDeliveryCharge.Text = (deliveryCharge[i]);
                    break;


                }
                else
                {
                    lblDeliveryCharge.Text = "Not valid zip.";
                }


            }
        }
    }
}
