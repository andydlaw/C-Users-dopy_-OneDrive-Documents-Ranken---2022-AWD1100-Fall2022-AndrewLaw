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

/*
 * LB1 BMI
Create a GUI application to calculate a person's Body Mass Index (BMI).
1.	If the user does not enter a number for their weight then display "INVALID WEIGHT" in red. (Make sure to handle FormatExceptions.)
2.	If the user enters a weight less than 1 lbs or more than 777 lbs then display "INVALID WEIGHT" in red.
3.	If the user does not enter a number for their height then display "INVALID HEIGHT" in red. (Make sure to handle FormatExceptions.)
4.	If the user enters a height less than 12 inches or more than 96 inches then display "INVALID HEIGHT" in red.
5.	If the weight and height are valid then display the calculated BMI and category.

 */

namespace Chap07_Lab01
{
    public partial class frmBMI : Form
    {
        public frmBMI()
        {
            InitializeComponent();
        }

        const int MINHEIGHT = 12;
        const int MAXHEIGHT = 96;
        const int MINWEIGHT = 1;
        const int MAXWEIGHT = 777;

        const string INVH = "INVALID HEIGHT";
        const string INVW = "INVALID WEIGHT";

        const double MINOPT = 18.5;
        const double MINOVR = 25.0;
        const double MINOBE = 30.0;

        const string UNDER = "UNDERWEIGHT";
        const string OPTIMAL = "OPTIMALWEIGHT";
        const string OVER = "OVERWEIGHT";
        const string OBESE= "OBESE";

        int height =0;
        int weight =0;
        double bmi = 0.0;
        string bmiStatus = "";

        private bool validateHeight()
        {
            bool retVal = true;
            bool result;
            try
            {
                result = Int32.TryParse(txtHeight.Text, out height);

                if (!result)
                {
                    throw new FormatException();
                }
                
                if ((height < MINHEIGHT) || (height > MAXHEIGHT))
                {
                    throw new ArgumentOutOfRangeException();
                }

                
            }
            catch (FormatException fex)
            {
                showMessage(fex, txtHeight.Tag.ToString());

                lblResult.ForeColor = Color.Red;
                lblResult.Text = INVH;
                
                retVal = false;
            }
            catch (ArgumentOutOfRangeException aex)
            {
                showMessage(aex, txtHeight.Tag.ToString());
                lblResult.ForeColor = Color.Red;
                lblResult.Text = INVH;
                
                retVal = false;
            }




            return retVal;
        }
        private bool validateWeight()
        {
            bool retVal = true;
            bool result;
            try
            {
                result = Int32.TryParse(txtWeight.Text, out weight);

                if (!result)
                {
                    throw new FormatException();
                }

                if ((weight < MINWEIGHT) || (weight > MAXWEIGHT))
                {
                    throw new ArgumentOutOfRangeException();
                }


            }
            catch (FormatException fex)
            {
                showMessage(fex, txtWeight.Tag.ToString());
                lblResult.ForeColor = Color.Red;
                lblResult.Text = INVW;
                
                retVal = false;
            }
            catch (ArgumentOutOfRangeException aex)
            {
                showMessage(aex, txtWeight.Tag.ToString());
                lblResult.ForeColor = Color.Red;
                lblResult.Text = INVW;
                
                retVal = false;
            }

            return retVal;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
             
            bool keepGoing = validateHeight();

            if (keepGoing)
            {
                keepGoing = validateWeight();

            }
            else
            {
                return;
            }
            if (keepGoing)
            {
                bmi = calculateBMI();

                bmiStatus = calculateBMIStatus();

                displayBMIStatus();
            }

           
        }

        private void displayBMIStatus()
        {
            lblResult.ForeColor = Color.Black;
            string str = "Body Mass Index (BMI): " + bmi.ToString("n2");
            str += ("\n\nBody Mass Index Status: " + bmiStatus);
            lblResult.Text = str;
        }
        private double calculateBMI()
        {
            return (weight * 703.0 / Math.Pow(height, 2));
        }
        private string calculateBMIStatus()
        {
            string status = "";

            if (bmi < MINOPT)
            {
                status = UNDER;
            }
            else if (bmi < MINOVR)
            {
                status = OPTIMAL;
            }
            else if (bmi < MINOBE)
            {
                status = OVER;
            }
            else
            {
                status = OBESE;
            }
            return status;
        }
        private void showMessage(Exception ex, string tag)
        {
            MessageBox.Show("Invalid " + tag + " was inputted!" + 
                            "\n\n The error message: " + ex.Message + 
                            "\n\n The Error type: " + ex.GetType().ToString() + 
                            "\n\n The stack trace: " + ex.StackTrace, 
                            "ERROR INFORMATION", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);

            if (tag == "height")
            {
                txtHeight.Text = "";
                txtHeight.Focus();

            }
            else if (tag == "weight")
            {
                txtWeight.Text = "";
                txtWeight.Focus();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAllFieldsSetFocus();
        }
        private void clearAllFieldsSetFocus()
        {
            //clear out all text boxes and set focus
            txtHeight.Text = "";
            txtWeight.Text = "";
            lblResult.Text = "";
            
            //set curser to text box
            txtHeight.Focus();
        }
        //Exit Button Code Method
        private void exitProgramOrNot()
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            exitProgramOrNot();
        }
    }

 
}
