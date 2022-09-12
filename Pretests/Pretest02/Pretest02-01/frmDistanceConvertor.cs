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
 3. Write a GUI program that converts distances between miles and kilometers:
●	Declares a named constant named KM_PER_MILE which holds the number of kilometers in a mile (1.6 km per mile).
●	Prompts the user for a distance in miles or kilometers.
●	The user can convert miles to kilometers.
●	The user can convert kilometers to miles.
●	The program displays the distance in both kilometers and miles. For example: “3.0 miles is 4.8 kilometers”

*/


namespace Pretest02_01
{
    public partial class frmDistanceConvertor : Form
    {
        public frmDistanceConvertor()
        {
            InitializeComponent();
        }

        //Global Class Level Variables
        decimal distance;
        decimal miles;
        decimal kilometers;

        //Declare and initialize program constants
        const decimal KM_PER_MILE = 1.6m;
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKilometers.Text = "";
            txtMiles.Text = "";
            lblOutput.Text = "";
            txtMiles.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit Button Code
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


        // This method is executed when the F to C button is clicked.
        private void btnConvertMtoK_Click(object sender, EventArgs e)
        {
            bool keepGoing = true;  //Flag


            // Call routine to validate textbox not empty
            keepGoing = validateMilesTempNotEmpty();
           
            if (keepGoing)
            {
                // Call routine to validate textbox numeric
                keepGoing = validateMilesTempIsNumeric();
            }
            
           

            if(keepGoing)
            {
                distance = Convert.ToDecimal(txtMiles.Text);
                kilometers = distance * KM_PER_MILE;
                txtKilometers.Text = kilometers.ToString("n1");
                lblOutput.Text = distance.ToString("n1") + " miles is " + kilometers.ToString("n1") + " kilometers";
                distance = 0.0m;
                   
            }
            
        }

        // This method validates that the M to K box is not empty
        private bool validateMilesTempNotEmpty()
        {
            bool retVal = true;

            if (txtMiles.Text.Trim() == "")
            {
                showMessage("Textbox Cannot Be Empty", "EMPTY MILES");
                retVal = false;
                txtMiles.Focus();
            }

            return retVal;
        }


        // This method validates that the M to K box is numeric
        private bool validateMilesTempIsNumeric()
        {
            bool retVal = true;
            bool result;

            result = Decimal.TryParse(txtMiles.Text, out distance);

            if (!result)
            {
                showMessage("Textbox must be numeric", "NON-NUMERIC MILES");
                retVal = false;
                txtMiles.Text = "";
                
                txtMiles.Focus();
            }

            return retVal;
        }


        


        //KILOMETERS


        //Call routine to validate textbox not empty
        private bool validateKiloNotEmpty()
        {
            bool retVal = true;

            if (txtKilometers.Text.Trim() == "")
            {
                showMessage("Textbox Cannot Be Empty", "EMPTY KILOMETERS");
                retVal = false;
                txtKilometers.Focus();
            }

            return retVal;
        }


        // This method validates that the K to M box is numeric
        private bool validateKiloIsNumeric()
        {
            bool retVal = true;
            bool result;

            result = Decimal.TryParse(txtKilometers.Text, out distance);

            if (!result)
            {
                showMessage("Textbox must be numeric", "NON-NUMERIC KILOMETERS");
                retVal = false;
                txtKilometers.Text = "";
                txtKilometers.Focus();
            }

            return retVal;
        }


        


        //Message Box
        private void showMessage(String msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnConvertKtoM_Click(object sender, EventArgs e)
        {
            bool keepGoing = true;  //Flag


            // Call routine to validate textbox not empty
            keepGoing = validateKiloNotEmpty();

            if (keepGoing)
            {
                // Call routine to validate textbox numeric
                keepGoing = validateKiloIsNumeric();
            }
            else
            {
                return;
            }

            

            if (keepGoing)
            {
                distance = Convert.ToDecimal(txtKilometers.Text);
                miles = distance / KM_PER_MILE;
                txtMiles.Text = miles.ToString("n1");
                lblOutput.Text = distance.ToString("n1") + " kilometers is " + miles.ToString("n1") + " miles";

                distance = 0.0m;

            }
            else
            {
                return;
            }
        }
    }
}
