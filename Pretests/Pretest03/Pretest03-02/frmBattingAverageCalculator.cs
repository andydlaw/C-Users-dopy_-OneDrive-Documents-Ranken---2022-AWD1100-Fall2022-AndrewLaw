using System;
using System.Windows.Forms;

/*
For this pretest, you will continue working with the two different C# graphical user interface (GUI) windows forms projects you created for the first (Chapters 1 – 5) pretest.

NOTE: Requirements a – d below ARE NOT NEW, while requirements  e – f below ARE NEW: 

a) For both programs, set the Tab Order, AcceptButton, CancelButton, and Start Position accordingly.  

b) For both programs, change the name of the form accordingly and the form text as well.  

c) For both programs, create a program prologue at the beginning of the code.  

d) For both programs, for any numeric values inputted, verify that each value is not empty, not non-numeric, and not out of range.

e) NEW: Modularize each program.  Try to have no executable code in any control except for calls to user-written methods.

f)	NEW: Add exception handling to each program.  Change the Not Empty, Not non-numeric, and Range tests on the next pages to use try/catch exception handling instead of the current user-written methods.  Set up control tags where necessary.


In baseball, a player's average is calculated by dividing hits by at bats. For example, a player with 4 hits in 10 at bats has an average of .400, typically stated as a 400 average.

Write a C# GUI windows forms program that lets the user input hits and at bats. From there, calculate the associated batting average.

Also, keep track of the highest batting average, the lowest batting average, and the total number of averages that have been calculated. Store these are read-only textboxes.

NOTE: The requirements below ARE NOT NEW, but they have been modified!!!

For hits & at bats, use exception handling to verify that:

a) The value inputted is not empty.

b) The value inputted is not non-numeric.

c) The value inputted is 0 or more.

d) For hits, the value is <= the value for at bats.

See the program runs on the following pages for examples.

*/

namespace Pretest02_02
{
    public partial class frmBattingAverageCalculator : Form
    {
        public frmBattingAverageCalculator()
        {
            InitializeComponent();
        }

        //Declare global variables
        int atBat;
        decimal hits;
        decimal avg = 0.00m;
        int number;
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
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field.", textBox.Tag + " WAS NOT PROVIDED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
            return true;
        }
        //Numeric Field Validation Routine
        private bool IsInt32(TextBox textBox)
        {
            //int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                if (textBox.Tag == "At Bats")
                {
                    atBat = number;
                }
                else if (textBox.Tag == "Hits")
                {
                    hits = number;
                }

                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", textBox.Tag + " WAS NON-NUMERIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Text = "";
                textBox.Focus();
                return false;
            }
        }
        //In Range Field Validation Routine (Need to set min and max constants)
        private bool IsInRange(TextBox textBox, int min, int max)
        {
            string ab = textBox.Tag.ToString();
            ab = ab.ToUpper();

            int number1 = Convert.ToInt32(textBox.Text);
            if (number1 < min || number1 > max)
            {
                MessageBox.Show(textBox.Tag + " must be between " + min + " and " + max + ".", "OUT-OF-RANGE");
                textBox.Text = "";
                textBox.Focus();
                return false;
            }
            return true;
        }
        //Perform the calculations
        private void doTheCalculations()
        {
            avg = (decimal)hits / (decimal)atBat;
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
            keepGoing = IsPresent(txtAtBat);

            if (keepGoing)
            {
                // Call routine to validate textbox numeric
                keepGoing = IsInt32(txtAtBat);
            }
            if (keepGoing)
            {
                // Call routine to validate textbox is in range
                keepGoing = IsInRange(txtAtBat, 0, 100000);
            }
            if (keepGoing)
            {
                // Call routine to validate textbox is not empty
                keepGoing = IsPresent(txtHits);
            }
            if (keepGoing)
            {
                // Call routine to validate textbox is numeric
                keepGoing = IsInt32(txtHits);
            }
            if (keepGoing)
            {
                // Call routine to validate textbox is in range
                keepGoing = IsInRange(txtHits, 0, atBat);
            }
            if (keepGoing)
            {
                doTheCalculations();
            }
        }
    }
}
