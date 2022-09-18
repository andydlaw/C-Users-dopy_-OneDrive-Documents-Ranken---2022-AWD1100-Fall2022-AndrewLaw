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
 3. Write a GUI program that converts temperatures between fahr and cel:
●	Declares a named constant named KM_PER_MILE which holds the number of cel in a mile (1.6 km per mile).
●	Prompts the user for a temperature in fahr or cel.
●	The user can convert fahr to cel.
●	The user can convert cel to fahr.
●	The program displays the temperature in both cel and fahr. For example: “3.0 fahr is 4.8 cel”

*/


namespace Pretest02_01
{
    public partial class frmTempConvertor : Form
    {
        public frmTempConvertor()
        {
            InitializeComponent();
        }

        //Global Class Level Variables
        decimal temperature;
        decimal fahr;
        decimal cel;

        //Declare and initialize program constants
        const decimal KM_PER_MILE = 1.6m;
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCel.Text = "";
            txtFahr.Text = "";
            txtFahr.Focus();

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
            keepGoing = IsPresent(txtFahr);

            if (keepGoing)
            {
                // Call routine to validate textbox numeric
                keepGoing = IsDecimal(txtFahr);
            }
            if (keepGoing)
            {
                // Call routine to validate textbox is in range
                keepGoing = IsInRange(txtFahr, -212, 212);
            }


            if (keepGoing)
            {
                temperature = Convert.ToDecimal(txtFahr.Text);
                cel = (temperature - 32.0m) / 1.8m;
                txtCel.Text = cel.ToString("n1");
                temperature = 0.0m;
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
            keepGoing = IsPresent(txtCel);
            if (keepGoing)
            {
                // Call routine to validate textbox numeric
                keepGoing = IsDecimal(txtCel);
            }
            if (keepGoing)
            {
                // Call routine to validate textbox is in range
                keepGoing = IsInRange(txtCel, -100, 100);
            }

            if (keepGoing)
            {
                temperature = Convert.ToDecimal(txtCel.Text);
                fahr = (temperature * 1.8m) + 32.0m;
                txtFahr.Text = fahr.ToString("n1");
                temperature = 0.0m;
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
                if (textBox.Tag == "fahr")
                {
                    fahr = number;
                }
                else if (textBox.Tag == "cel")
                {
                    cel = number;
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
        private bool IsInRange(TextBox textBox, int min, int max)
        {
            string ab = textBox.Tag.ToString();
            ab = ab.ToUpper();

            decimal number1 = Convert.ToDecimal(textBox.Text);
            if (number1 < min || number1 > max)
            {
                MessageBox.Show(textBox.Tag + " must be between " + min + " and " + max + ".", "OUT-OF-RANGE");
                textBox.Text = "";
                textBox.Focus();
                return false;
            }
            return true;
        }


    }
}
