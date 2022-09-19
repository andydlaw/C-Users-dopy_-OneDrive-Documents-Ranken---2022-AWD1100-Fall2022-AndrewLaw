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
Please create the projects under the same solution used for the previous test 
and upload Completed work to existing GitHub (10 points).

EX1 [90 pts] Write a GUI-based program that create a simple payroll system. 
Please see the next page for program run examples.

● The program must use constants for department 
(possible values are INFOTECHNOLOGY with value "INFO TECHNOLOGY", 
WEBDEVELOPMENT with value "WEB DEVELOPMENT", 
PROGRAMMING with value "PROGRAMMING", 
ACCOUNTING with value "ACCOUNTING", and 
SHIPPING with value SHIPPING"), 
minimum hours worked (0), 
maximum hours worked (84), 
minimum hourly rate (0), 
maximum hourly rate (99.99), 
maximum hours worked with no overtime (40), and 
overtime rate (1.5). I also used constants for my titles. See Pages 3 and 4 for examples.

● You must use try/catch exception handling for the following: a) first name and last name cannot be empty. b) department cannot be empty. c) department must be 1 of the 5 constants listed above. d) hours worked and hourly rate cannot be empty. e) hours worked and hourly rate must be numeric. f) hours worked and hourly rate must be with range of constants listed above. Correct program runs are shown on the next page. Error program runs are shown on Pages 3 – 4. Try to use the generic Murach error handlers Page 213.

*/

namespace HOT03_01
{
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }

        const string WEBDEVELOPMENT = "WEB DEVELOPMENT"; 
        const string PROGRAMMING = "PROGRAMMING";
        const string ACCOUNTING = "ACCOUNTING";
        const string SHIPPING ="SHIPPING";
        const decimal MINHOURSWORKED = 0.0m;
        const decimal MAXHOURSWORKED = 84m;
        const decimal MINHOURLYRATE = 0.0m;
        const decimal MAXHOURLYRATE = 99.99m;
        const decimal MAXREGHOURSWORKED = 40.0m;
        const decimal OVERTIMERATE = 1.5m;
        decimal hoursWorked = 0.0m;
        decimal hourlyRate = 0.0m;
        decimal gross;
        int totalEmployees = 0;
        decimal totalGrossPay = 0;
        decimal avgGrossPay = 0;
        decimal highestGrossPay = -1m;
        decimal lowestGrossPay = 10000m;
        string firstName;
        string lastName;

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            exitProgramOrNot();
        }
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
        private void clearAllFieldsSetFocus()
        {
            //clear out all text boxes and set focus
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtDepartment.Text = "";
            txtHoursWorked.Text = "";
            txtHourlyRate.Text = "";
            txtGrossPay.Text = "";
            txtFirstName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAllFieldsSetFocus();
        }
        //message box that displays if textboxes are null
        private void showMessageNull(Exception ex, string tag)
        {
            MessageBox.Show("System Message: Value cannont be null.\n" +
                            "Parameter name: Associated Input is Missing for " + tag+ 
                            "!\n\nProgrammer Message: " + tag + " is a required field!",
                            "Associated Input is Missiong For " + tag,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
        //validates first name text box to make sure it is not null
        private bool validateFirstName()
        {
            bool retVal = true;
            bool result;
            try
            {
                result = txtFirstName.Text != "";

                if (!result)
                {
                    throw new FormatException();
                }
            }
            catch (FormatException fex)
            {
                txtFirstName.Focus();
                showMessageNull(fex, txtFirstName.Tag.ToString());
                retVal = false;
            }
            
            return retVal;
        }
        //validates last name text box to make sure it is not null
        private bool validateLastName()
        {
            bool retVal = true;
            bool result;
            try
            {
                result = txtLastName.Text != "";

                if (!result)
                {
                    throw new FormatException();
                }
            }
            catch (FormatException fex)
            {
                txtLastName.Focus();
                showMessageNull(fex, txtLastName.Tag.ToString());
                retVal = false;
            }
            firstName = txtFirstName.Text.ToUpper();
            lastName = txtLastName.Text.ToUpper();

            return retVal;
        }
        //validates department name text box to make sure it is not null
        private bool validateDepartmentName()
        {
            bool retVal = true;
            bool result;
            try
            {
                result = txtDepartment.Text != "";

                if (!result)
                {
                    throw new FormatException();
                }
            }
            catch (FormatException fex)
            {
                txtDepartment.Focus();
                showMessageNull(fex, txtDepartment.Tag.ToString());
                retVal = false;
            }
            return retVal;
        }
        //validates hours worked text box to make sure it is not null
        private bool validateHoursWorked()
        {
            bool retVal = true;
            bool result;
            try
            {
                result = txtHoursWorked.Text != "";

                if (!result)
                {
                    throw new FormatException();
                }
            }
            catch (FormatException fex)
            {
                txtHoursWorked.Focus();
                showMessageNull(fex, txtHoursWorked.Tag.ToString());
                retVal = false;
            }
            return retVal;
        }
        //validates hourly rate text box to make sure it is not null
        private bool validateHourlyRate()
        {
            bool retVal = true;
            bool result;
            try
            {
                result = txtHourlyRate.Text != "";

                if (!result)
                {
                    throw new FormatException();
                }
            }
            catch (FormatException fex)
            {
                txtHourlyRate.Focus();
                showMessageNull(fex, txtHourlyRate.Tag.ToString());
                retVal = false;
            }
            return retVal;
        }
        //validates Department name text box to make sure it is the desired value
        private bool validateDepartmentData()
        {
            
            string result = txtDepartment.Text.ToUpper();
            bool retVal = true;
            
            if ((!result.Equals("INFOTECHNOLOGY")) && (!result.Equals("WEBDEVELOPMENT")) && (!result.Equals("PROGRAMMING")) && (!result.Equals("ACCOUNTING")))
            {
                retVal = false;
            MessageBox.Show("Department Name Must be INFORTECHNOLOGY, WEBDEVELOPMENT, PROGRAMMING, or ACCOUNTING", "INVALID DEPARMENT ENTERED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDepartment.Text = result;
                txtDepartment.Focus();
            }
            else
            {
                txtDepartment.Text = result;
                retVal = true;
            }
            return retVal;
        }
        //validates numerical text boxes to make sure they are numerics
        private bool IsDecimal()
        {
            bool try1;
            bool try2;
            bool results = true;
            

            try1 = Decimal.TryParse(txtHourlyRate.Text, out hourlyRate);
            try2 = Decimal.TryParse(txtHoursWorked.Text, out hoursWorked);
            if (!try1)
            {
                MessageBox.Show("System Message: Non-numeric Input for Hourly Rate!\n\nProgrammer Message: hourlyRate must be a valid decimal value!", "Non-numeric Input for Hourly Rate!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHourlyRate.Focus();
                results = false;
            }
            else if (!try2)
            {
                MessageBox.Show("System Message: Non-numeric Input for Hours Worked!\n\nProgrammer Message: hoursWorked must be a valid decimal value!", "Non-numeric Input for Hours Worked!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoursWorked.Focus();
                results = false;
            }
            else
            {
                results = true;
            }
            return results;
        }
        //validates numerical text box to make sure it is in range
        private bool IsWithinRange()
        {
            bool retVal = true;
            if ( hoursWorked > MAXHOURSWORKED || hoursWorked < MINHOURSWORKED)
            {
                MessageBox.Show("Parameter name: Out-Of-Range input for Hours Worked!\n\nProgrammer Message: hoursWorked must be between "+ MINHOURSWORKED+ " and " + MAXHOURSWORKED+"!", "Out-Of-Range Input for Hours Worked!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                retVal = false;
                txtHoursWorked.Focus();
            }
            else if (hourlyRate > MAXHOURLYRATE|| hourlyRate < MINHOURLYRATE)
            {
                MessageBox.Show("Parameter name: Out-Of-Range input for Hourly Rate!\n\nProgrammer Message: hourlyRate must be between " + MINHOURLYRATE + " and " + MAXHOURLYRATE + "!", "Out-Of-Range Input for Hourly Rate!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                retVal = false;
                txtHourlyRate.Focus();
            }
            return retVal;
        }
        //all the calculation functions
        private void calculate()
        {


            if (hoursWorked <= MAXREGHOURSWORKED)
            {
                 gross = hoursWorked * hourlyRate;
                
            }
            else 
            {
                 gross = ((MAXREGHOURSWORKED * hourlyRate) + ((hoursWorked - MAXREGHOURSWORKED) * (hourlyRate * OVERTIMERATE)));
            }
            

            //Increment totalGrossPays
            //set textbox
            ++totalEmployees;
            txtTotalEmployees.Text = totalEmployees.ToString();

            //Increment totalGrossPays
            //set textbox
            totalGrossPay += gross;
            txtTotGrossPay.Text = totalGrossPay.ToString("c");

            //Calculate avgGrossPay
            //set textbox
            avgGrossPay = totalGrossPay / totalEmployees;
            txtAverageGross.Text = avgGrossPay.ToString("c");

            //Calcuate maxGrossPay
            //set textbox
            if (gross > highestGrossPay)
            {
                highestGrossPay = gross;
            }

            txtHighestGross.Text = highestGrossPay.ToString("c");

            //Calcuate maxGrossPay
            //set text box
            if (gross < lowestGrossPay)
            {
                lowestGrossPay = gross;
            }

            txtLowestGross.Text = lowestGrossPay.ToString("c");

            txtGrossPay.Text = gross.ToString("c");
            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;

        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!validateFirstName())
            {
                return;
            }
            else if (!validateLastName())
            {
                return;                
            }
            else if(!validateDepartmentName())
            {
                return ;
            }
            else if (!validateHoursWorked())
            {
                return;
            }
            else if (!validateHourlyRate())
            {
                return;
            }
            else if (!validateDepartmentData())
            {
                return;
            }
            else if (!IsDecimal())
            {
                return;
            }
            else if (!IsWithinRange())
            {
                return;
            }
            calculate();




        }
    }
}
