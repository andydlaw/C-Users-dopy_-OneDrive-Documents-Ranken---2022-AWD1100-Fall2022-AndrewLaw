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
        // This method is executed when the M to K button is clicked.
        private void btnConvertMtoK_Click(object sender, EventArgs e)
        {
            bool keepGoing = true;  //Flag


            // Call routine to validate textbox not empty
            keepGoing = IsPresent(txtMiles);

            if (keepGoing)
            {
                // Call routine to validate textbox numeric
                keepGoing = IsDecimal(txtMiles);
            }


            if (keepGoing)
            {
                distance = Convert.ToDecimal(txtMiles.Text);
                kilometers = distance * KM_PER_MILE;
                txtKilometers.Text = kilometers.ToString("n1");
                lblOutput.Text = distance.ToString("n1") + " miles is " + kilometers.ToString("n1") + " kilometers";
                distance = 0.0m;
            }
            
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
            keepGoing = IsPresent(txtKilometers);
            if (keepGoing)
            {
                // Call routine to validate textbox numeric
                keepGoing = IsDecimal(txtKilometers);
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
        // This method validates textbox is not empty
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
        // This method validates textbox is numeric
        private bool IsDecimal(TextBox textBox)
        {
            decimal number = 0;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                if (textBox.Tag == "Miles")
                {
                    miles = number;
                }
                else if (textBox.Tag == "Kilometers")
                {
                    kilometers = number;
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

        private void txtMiles_TextChanged(object sender, EventArgs e)
        {
            lblOutput.Text = "";
        }

        private void txtKilometers_TextChanged(object sender, EventArgs e)
        {
            lblOutput.Text = "";
        }
    }
}
