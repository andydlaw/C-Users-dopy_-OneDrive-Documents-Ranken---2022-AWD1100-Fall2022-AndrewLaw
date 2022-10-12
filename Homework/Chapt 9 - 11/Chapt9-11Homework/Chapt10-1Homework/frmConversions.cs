using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapt10_1Homework
{
    /*
     * Extra 10-1 Convert lengths
In this exercise, you’ll add code to a form that converts the value the user enters based on the selected conversion type.
The application should handle the following conversions: From To Conversion Miles Kilometers 1 mile = 1.6093 kilometers Kilometers Miles 1 kilometer = 0.6214 miles Feet Meters 1 foot = 0.3048 meters Meters Feet 1 meter = 3.2808 feet Inches Centimeters 1 inch = 2.54 centimeters Centimeters Inches 1 centimeter = 0.3937 inches
1. Open the LengthConversions project in the Extra Starts\Chapter 10 directory. Display the code for the form, and notice the rectangular array whose rows contain the value to be displayed in the combo box, the text for the labels that identify the two text boxes, and the multiplier for the conversion as shown above.
2. Set the DropDownStyle property of the combo box so the user must select an item from the list.
3. Add code to load the combo box with the first element in each row of the rectangular array, and display the first item in the combo box when the form is loaded.
4. Add code to change the labels for the text boxes, clear the calculated length, and move the focus to the entry text box when the user selects a different item from the combo box.
5. Test the application to be sure the conversions are displayed in the combo box, the first conversion is selected by default, and the labels change appropriately when a different conversion is selected.
6. Add code to calculate and display the converted length when the user clicks the Calculate button. To calculate the length, you can get the index for the selected conversion and then use that index to get the multiplier from the array. Test the application to be sure this works correctly.
7. Add code to check that the user enters a valid decimal value for the length. Then, test the application one more time to be sure the validation works correctly.
     */
    public partial class frmConversions : Form
    {
        public frmConversions()
        {
            InitializeComponent();
        }

        const decimal MAXINPUTVALUE = 1000000m;
        const decimal MILESTOKILOS = 1.6093m;
        const decimal KILOSTOMILES = 0.6214m;
        const decimal FTTOMETERS= 0.3048m;
        const decimal METERSTOFT= 3.2808m;
        const decimal INCHESTOCM= 2.54m;
        const decimal CMTOINCHES= 0.3937m;

        string[] conversions =
        {
            "Please select conversion",
            "Miles to Kilometers",
            "Kilometers to Miles",
            "Feet to Meters",
            "Meters to Feet",
            "Inches to Centimeters",
            "Centimeters to Inches"
        };

        private void frmConversions_Load(object sender, EventArgs e)
        {
            for (int i=0;i<conversions.Length;++i)
            {
                cbxConversion.Items.Add(conversions[i]);
            }
            cbxConversion.SelectedIndex = 0;
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

        private void cbxConversion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void callTheDriver()
        {
            decimal fromValue = 0m;
            decimal toValue = 0m;

            bool keepGoing = verifyNumberToConvertFromExists();
            if (keepGoing)
            {
                keepGoing = verifyNumberToConvertFromNumeric();
            }
            else
            {
                return;
            }
            if(keepGoing)
            {
                keepGoing = verifyConversionTypeChosen();
            }
            else
            {
                return;
            }
            if(keepGoing)
            {
                performTheConversion(ref fromValue, ref toValue);
            }


        }

        private bool verifyNumberToConvertFromExists()
        {
            bool retVal = true;
            if (txtFrom.Text.Trim()=="")
            {
                MessageBox.Show("You must input a value in the from field", "NOTHING INPUTTED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                retVal = false;
                txtFrom.Focus();
            }
            return retVal;
        }
        private bool verifyNumberToConvertFromNumeric()
        {
            bool result = false;
            bool retVal = true;
            decimal fromValue;

            result = decimal.TryParse(txtFrom.Text, out fromValue);
            if (!result)
            {
                MessageBox.Show("You must input a number in the from field", "NON-NUMERIC INPUTTED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                retVal = false;
                txtFrom.Focus();
            }
            return retVal;
        }
        private bool verifyConversionTypeChosen()
        {
            bool retVal = true;

            if (cbxConversion.SelectedIndex <=0)
            {
                MessageBox.Show("You must choose conversion type", "NO CONVERSION TYPE CHOSEN INPUTTED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                retVal = false;
                cbxConversion.Focus();
            }
            return retVal;
        }
        private void performTheConversion( ref decimal fromValue, ref decimal toValue)
        {
            fromValue= Convert.ToDecimal(txtFrom.Text);
            switch(cbxConversion.SelectedIndex)
            {
                case -1:
                    case 0:
                    return;
                    case 1:
                    toValue = fromValue * MILESTOKILOS;
                    lblFrom.Text = "Miles";
                    lblTo.Text = "Kilometers";
                    break;
                case 2:
                    toValue = fromValue * KILOSTOMILES;
                    lblFrom.Text = "Kilometers";
                    lblTo.Text = "Miles";
                    break;
                case 3:
                    toValue = fromValue * FTTOMETERS;
                    lblFrom.Text = "Feet";
                    lblTo.Text = "Meters";
                    break;
                case 4:
                    toValue = fromValue * METERSTOFT;
                    lblFrom.Text = "Meters";
                    lblTo.Text = "Feet";
                    break;
                case 5:
                    toValue = fromValue * INCHESTOCM;
                    lblFrom.Text = "Inches";
                    lblTo.Text = "Centimeters";
                    break;
                case 6:
                    toValue = fromValue * CMTOINCHES;
                    lblFrom.Text = "Centimeters";
                    lblTo.Text = "Inches";
                    break;
                    default:
                    return;
            }
            txtTo.Text = toValue.ToString("n4");

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            callTheDriver();
        }
    }
}
