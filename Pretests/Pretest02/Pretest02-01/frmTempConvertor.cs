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
 *  

Write a C# GUI app that converts either a temperature inputted in Fahrenheit to Celsius or a temperature       inputted in Celsius to Fahrenheit.: 

 

Verify that either input is:  

a) Not empty.  

b) Not non-numeric.   

c) Within range. 

 

Create constants MINFAHR (-212), MAXFAHR (212), MINCELSIUS (-100), MAXCELSIUS (100).  Please try to modularize your program.  See program run examples.  Here are the conversion formulas: 

 

celsius = (fahrenheit - 32) / 1.8 

fahrenheit = (celsius * 1.8) + 32 

 

See the program runs on the next two pages for examples. 
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
        decimal temp;
        decimal celsius;
        decimal fahrenheit;

        //Declare and initialize program constants
        const decimal MINFAHR = -212;   //Min F temp allowed
        const decimal MAXFAHR = 212;    //Max F temp allowed
        const decimal MINCELSIUS = -100;    //Min C temp allowed
        const decimal MAXCELSIUS = 100;     //Max C temp allowed

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCellTemp.Text = "";
            txtFarhTemp.Text = "";
            txtFarhTemp.Focus();

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
        private void btnConvertFtoC_Click(object sender, EventArgs e)
        {
            bool keepGoing = true;  //Flag


            // Call routine to validate textbox not empty
            keepGoing = validateFahrTempNotEmpty();
           
            if (keepGoing)
            {
                // Call routine to validate textbox numeric
                keepGoing = validateFahrTempIsNumeric();
            }
            

            if (keepGoing)
            {
                // Call routine to validate textbox is in range
                keepGoing = validateFahrTempIsInRange();
            }
            

            if(keepGoing)
            {

                celsius = (temp - 32.0m) / 1.8m;
                txtCellTemp.Text = celsius.ToString("n2");
                temp = 0.0m;
                   
            }
            
        }

        // This method validates that the F to C box is not empty
        private bool validateFahrTempNotEmpty()
        {
            bool retVal = true;

            if (txtFarhTemp.Text.Trim() == "")
            {
                showMessage("Textbox Cannot Be Empty", "EMPTY FAHRENHEIT TEMP");
                retVal = false;
                txtFarhTemp.Focus();
            }

            return retVal;
        }


        // This method validates that the F to C box is numeric
        private bool validateFahrTempIsNumeric()
        {
            bool retVal = true;
            bool result;

            result = Decimal.TryParse(txtFarhTemp.Text, out temp);

            if (!result)
            {
                showMessage("Textbox must be numeric", "NON-NUMERIC FAHRENHEIT TEMP");
                retVal = false;
                txtFarhTemp.Text = "";
                txtFarhTemp.Focus();
            }

            return retVal;
        }


        //Check to see if F temp value is in range
        private bool validateFahrTempIsInRange()
        {
            bool retVal = true;

            if ((temp < MINFAHR || temp > MAXFAHR))
            {
                showMessage("Temperature Inputted Out-Of-Range", "OOR FAHRENHEIT TEMP");
                retVal = false;
                txtFarhTemp.Text = "";
                txtFarhTemp.Focus();
            }

            return retVal;
        }


        //CELSIUS


        //Call routine to validate textbox not empty
        private bool validateCelTempNotEmpty()
        {
            bool retVal = true;

            if (txtCellTemp.Text.Trim() == "")
            {
                showMessage("Textbox Cannot Be Empty", "EMPTY FAHRENHEIT TEMP");
                retVal = false;
                txtCellTemp.Focus();
            }

            return retVal;
        }


        // This method validates that the C to F box is numeric
        private bool validateCelTempIsNumeric()
        {
            bool retVal = true;
            bool result;

            result = Decimal.TryParse(txtCellTemp.Text, out temp);

            if (!result)
            {
                showMessage("Textbox must be numeric", "NON-NUMERIC FAHRENHEIT TEMP");
                retVal = false;
                txtCellTemp.Text = "";
                txtCellTemp.Focus();
            }

            return retVal;
        }


        //Check to see if C temp value is in range
        private bool validateCelTempIsInRange()
        {
            bool retVal = true;

            if ((temp < MINCELSIUS || temp > MAXCELSIUS))
            {
                showMessage("Temperature Inputted Out-Of-Range", "OOR FAHRENHEIT TEMP");
                retVal = false;
                txtCellTemp.Text = "";
                txtCellTemp.Focus();
            }

            return retVal;
        }


        //Message Box
        private void showMessage(String msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnConvertCtoF_Click(object sender, EventArgs e)
        {
            bool keepGoing = true;  //Flag


            // Call routine to validate textbox not empty
            keepGoing = validateCelTempNotEmpty();

            if (keepGoing)
            {
                // Call routine to validate textbox numeric
                keepGoing = validateCelTempIsNumeric();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                // Call routine to validate textbox is in range
                keepGoing = validateCelTempIsInRange();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {

                fahrenheit = (temp * 1.8m) + 32.0m;
                txtFarhTemp.Text = fahrenheit.ToString("n2");
                temp = 0.0m;

            }
            else
            {
                return;
            }
        }
    }
}
