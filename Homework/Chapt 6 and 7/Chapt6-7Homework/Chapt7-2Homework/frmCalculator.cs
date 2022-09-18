using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;

/*
Extra 7-2 Add data validation to the simple calculator
In this exercise, you’ll add data validation to the Simple Calculator form.
1. Open the SimpleCalculator project in the Extra Starts\Chapter 07\SimpleCalculatorValidation directory.
2. Code methods named IsPresent(), IsDecimal(), and IsWithinRange() that work like the methods described in chapter 7 of the book.
3. Code a method named IsOperator() that checks that the text box that’s passed to it contains a value of +, -, *, or /.
4. Code a method named IsValidOperation() that checks for a divide by zero operation. This method will need to check the Operand 2 text box and the value of the Operator text box.
5. Code a method named IsValidData() that checks that the Operand 1 and Operand 2 text boxes contain a decimal value between 0 and 1,000,000, that the Operator text box contains a valid operator, and that the operation is valid.
6. Delete all of the catch blocks from the try-catch statement in the btnCalculate_Click() event handler except for the one that catches any exception. Then, add code to this event handler that performs the calculation and displays the result only if the values of the text boxes are valid.
7. Test the application to be sure that all the data is validated properly.
*/

namespace Ch6CalculatorGUI01
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
            //cboOperation.SelectedIndex = 0;
        }
        decimal number1 = 0m;
        decimal number2 = 0m;
        decimal result = 0m;
        string operator1 = "";


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

        private void btnClear_Click(object sender, EventArgs e)
        {

            clearAllFieldsSetFocus();

        }
        private void clearAllFieldsSetFocus()
        {
            //clear out all text boxes and set focus
            txtNumOne.Text = "";
            txtNumTwo.Text = "";
            txtOperator.Text = "";
            txtResult.Text = "";
            txtNumOne.Focus();
        }
        private void IsPresent()
        {
            if (txtNumOne.Text == "")
            {
                MessageBox.Show("Operand 1 cannot be null.", "NULL VALUE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumOne.Focus();
            }
            else if (txtNumTwo.Text == "")
            {
                MessageBox.Show("Operand 2 cannot be null.", "NULL VALUE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumTwo.Focus();
            }
            else if (txtOperator.Text == "")
            {
                MessageBox.Show("Operator cannot be null.", "NULL VALUE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOperator.Focus();
            }
        } 
        private void IsDecimal()
        {          
            bool try1;
            bool try2;      
            try1 = Decimal.TryParse(txtNumOne.Text, out number1);
            try2 = Decimal.TryParse(txtNumTwo.Text, out number2);
            if (!try1)
            {
                MessageBox.Show("Operand 1 cannot be non-numeric.", "NON-NUMERIC VALUE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumOne.Focus();
            }
            else if (!try2)
            {
                MessageBox.Show("Operand 2 cannot be non-numeric.", "NON-NUMERIC VALUE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumTwo.Focus();
            }
            else
            {
                number1 = Convert.ToDecimal(txtNumOne.Text);
                number2 = Convert.ToDecimal(txtNumTwo.Text);
            }
        }
        private void IsWithinRange()
        {
            decimal maxNum = 1000000m;
            decimal minNum = 0m;
            if (number1 > maxNum || number1 < minNum)
            {
                MessageBox.Show("Operand 1 cannot be less than 0 or greater than 1,000,000.", "OUT OF RANGE VALUE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumOne.Focus();
            }
            else if (number2 > maxNum || number2 < minNum)
            {
                MessageBox.Show("Operand 2 cannot be less than 0 or greater than 1, 000, 000.", "OUT OF RANGE VALUE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumTwo.Focus();
            }
        }
        private void IsOperator()
        {
            operator1 = txtOperator.Text;
            if ((operator1 != "+") && (operator1 != "-") && (operator1 != "*") && (operator1 != "/"))
            {
                MessageBox.Show("Illegal Operator Entered\nMust be a +,-, * or /", "ILLEGAL OPERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOperator.Focus();
            }

        }

        private void IsValidOperation()
        {
            if ((number1 == 0 && operator1 == "/"))
            {
                MessageBox.Show("Operand cannot be divided by 0.", "DIVIDE BY ZERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumOne.Focus();
            }
            else if ((number2 == 0 && operator1 == "/"))
            {
                MessageBox.Show("Operand cannot be divided by 0.", "DIVIDE BY ZERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumTwo.Focus();
            }
            else
            {
                calculate();
            }

        }
        private void IsValidData()
        {

            operator1 = Convert.ToString(txtOperator.Text);
            IsWithinRange();
            IsOperator();
            IsValidOperation();

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            IsPresent();
            IsDecimal();
            IsValidData();
            
        }


        private void calculate()
        {
            decimal answer = 0m;
            if (operator1 == "+")
            {
                answer = number1 + number2;
                txtResult.Text = answer.ToString();
            }
            else if (operator1 == "*")
            {
                answer = number1 * number2;
                txtResult.Text = answer.ToString();
            }
            else if (operator1 == "-")
            {
                answer = number1 - number2;
                txtResult.Text = answer.ToString();
            }
            else if (operator1 == "/")
            {
                answer = number1 / number2;
                txtResult.Text = answer.ToString();
            }
           
        }

        private void txtNumOne_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void txtOperator_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void txtNumTwo_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }
    }
}