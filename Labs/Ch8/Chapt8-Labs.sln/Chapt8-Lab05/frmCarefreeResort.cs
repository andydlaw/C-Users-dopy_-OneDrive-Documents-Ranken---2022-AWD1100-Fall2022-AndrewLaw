using System;
using System.Windows.Forms;
/*
 * LB5. Write a GUI application that calculates the cost of resort stay based on the number of nights stayed.

Program must pass all provided unit tests. Program must store this table in a pair of parallel arrays and use an appropriate loop.
*/

namespace Chapt8_Lab05
{
    public partial class frmCarefreeResort : Form
    {
        int[] nightsStayed = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] nightlyRate = { 200, 200, 180, 180, 160, 160, 160, 145 };
        public frmCarefreeResort()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int customerNightStayed = Convert.ToInt32(txtNightsStayed.Text);
            for (int i = 0; i < nightsStayed.Length; ++i)
            {
                if (customerNightStayed > nightsStayed[7])
                {
                    lblNightlyCost.Text = nightlyRate[7].ToString("c");
                    int totalCostOfStay = customerNightStayed * nightlyRate[7];
                    lblTotalCostOfStay.Text = totalCostOfStay.ToString("c");
                    break;
                }
                else if (customerNightStayed == nightsStayed[i])
                {

                    lblNightlyCost.Text = nightlyRate[i].ToString("c");
                    int totalCostOfStay = customerNightStayed * nightlyRate[i];
                    lblTotalCostOfStay.Text = totalCostOfStay.ToString("c");
                    break;


                }



            }
        }
    }
}
