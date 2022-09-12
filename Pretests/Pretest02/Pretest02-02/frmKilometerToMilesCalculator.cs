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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

/*
 * In baseball, a player's average is calculated by dividing hits by at bats.  For example, a player with 4 hits in 10 at bats has an average of .400, typically stated as a 400 average. 

 

Write a C# GUI windows forms program that lets the user input hits and at bats.  From there, calculate the associated batting average. 

 

Also, keep track of the highest batting average, the lowest batting average, and the total number of averages that have been calculated.  Store these are read-only textboxes. 

 

For both hits and at bats, verify that: 

 

a) The value inputted is not empty. 

b) The value inputted is not non-numeric. 

c) The value inputted is 0 or more. 

d) For hits, the value is <= the value for at bats. 
*/

namespace Pretest02_02
{
    public partial class frmKilometerToMilesCalculator : Form
    {
        public frmKilometerToMilesCalculator()
        {
            InitializeComponent();
        }

        //Declare global variables
        int atBat;
        decimal hits;
        decimal avg = 0.00m;



        int totalNumberOfAverages = 0;
        decimal highestBattingAverage = 0;
        decimal lowestBattingAverage = 1.000m;

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
             "Do You Really Want To Exit The Program?",
                "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAtBat.Text = "";
            txtHits.Text = "";
            //set curser to text box
            txtAtBat.Focus();
        }


        //Empty Field Validation Routine
        private bool validateAtBatNotEmpty()
        {
            bool retVal = true;

            if (txtAtBat.Text.Trim() == "")
            {
                showMessage("At Bat Cannot Be Empty", "EMPTY VARIABLE");
                retVal = false;
                txtAtBat.Focus();
            }

            return retVal;
        }


        //Numeric Field Validation Routine
        private bool validateAtBatIsNumeric()
        {
            bool retVal = true;
            bool result;

            result = Int32.TryParse(txtAtBat.Text, out atBat);

            if (!result)
            {
                showMessage("At Bat must be numeric", "NON-NUMERIC VARIABLE");
                retVal = false;
                txtAtBat.Text = "";
                txtAtBat.Focus();
            }

            return retVal;
        }

        //In Range Field Validation Routine (Need to set min and max constants)
        private bool validateAtBatIsPositive()
        {
            bool retVal = true;

            if ((atBat < 0))
            {
                showMessage("At bats have to be greater than 0", "OOR VARIABLE");
                retVal = false;
                txtAtBat.Text = "";
                txtAtBat.Focus();
            }

            return retVal;
        }

        //HITS
        //Empty Field Validation Routine
        private bool validateHitsNotEmpty()
        {
            bool retVal = true;

            if (txtHits.Text.Trim() == "")
            {
                showMessage("Hits Cannot Be Empty", "EMPTY VARIABLE");
                retVal = false;
                txtHits.Focus();
            }

            return retVal;
        }


        //Numeric Field Validation Routine
        private bool validateHitsIsNumeric()
        {
            bool retVal = true;
            bool result;

            result = Decimal.TryParse(txtHits.Text, out hits);

            if (!result)
            {
                showMessage("Hits must be numeric", "NON-NUMERIC VARIABLE");
                retVal = false;
                txtHits.Text = "";
                txtHits.Focus();
            }

            return retVal;
        }

        //In Range Field Validation Routine (Need to set min and max constants)
        private bool validateHitsIsInRange()
        {
            bool retVal = true;

            if ((hits > atBat))
            {
                showMessage("Hits cannot be greater than at bats", "OOR Hits");
                retVal = false;
                txtHits.Text = "";
                txtHits.Focus();
            }

            return retVal;
        }

        private void doTheCalculations()
        {
            avg = (decimal)hits / (decimal) atBat;
            txtAvg.Text = avg.ToString("n3");

            ++totalNumberOfAverages;
            txtTotNumOfAvg.Text = totalNumberOfAverages.ToString();

            if (avg > highestBattingAverage)
            {
                highestBattingAverage = avg;
            }

            txtHighestAvg.Text = highestBattingAverage.ToString("n3");

            if (avg < lowestBattingAverage)
            {
                lowestBattingAverage = avg;
            }

            txtLowestAvg.Text = lowestBattingAverage.ToString("n3");
        }

        //Message Box
        private void showMessage(String msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool keepGoing = true;  //Flag


            // Call routine to validate textbox not empty
            keepGoing = validateAtBatNotEmpty();


            if (keepGoing)
            {
                // Call routine to validate textbox numeric
                keepGoing = validateAtBatIsNumeric();
            }


            if (keepGoing)
            {
                // Call routine to validate textbox is in range
                keepGoing = validateAtBatIsPositive();
            }
            if (keepGoing)
            {
                // Call routine to validate textbox is not empty
                keepGoing = validateHitsNotEmpty();
            }
            if (keepGoing)
            {
                // Call routine to validate textbox is numeric
                keepGoing = validateHitsIsNumeric();
            }
            if (keepGoing)
            {
                // Call routine to validate textbox is in range
                keepGoing = validateHitsIsInRange();
            }
            if (keepGoing)
            {
                doTheCalculations();
            }




        }
    }
}
