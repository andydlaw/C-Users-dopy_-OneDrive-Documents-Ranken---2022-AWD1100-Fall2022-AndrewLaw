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

/*
Extra 6-1 Create a simple calculator
In this exercise, you’ll create a form that accepts two operands and an operator from the user and then performs the requested operation.
1. Start a new project named SimpleCalculator in the Extra Starts\Chapter 06 directory.
2. Add labels, text boxes, and buttons to the default form and set the properties of the form and its controls so they appear as shown above. When the user presses the Enter key, the Click event of the Calculate button should fire. When the user presses the Esc key, the Click event of the Exit button should fire.
3. Code a private method named Calculate() that performs the requested operation and returns a decimal value. This method should accept the following arguments: Argument Description decimal operand1 The value entered for the first operand. string operator1 One of these four operators: +, -, *, or /. decimal operand2 The value entered for the second operand.
4. Create an event handler for the Click event of the Calculate button. This event handler should get the two numbers and operand the user enters, call the Calculate() method to get the result of the calculation, display the result rounded to four decimal places, and move the focus to the Operand 1 text box.
5. Create an event handler for the Click event of the Exit button that closes the form.
6. Create an event handler that clears the Result text box if the user changes the text in any of the other text boxes.
7. Test the application to be sure it works correctly.
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
        //decimal number1 ;
        //decimal number2 = 0m ;
        //decimal result = 0m;


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


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal number1 = Convert.ToDecimal(txtNumOne.Text);
            decimal number2 = Convert.ToDecimal(txtNumTwo.Text);
            string operator1 = txtOperator.Text;

            decimal answer = 0m;

            answer = calculate(number1, operator1, number2);

            txtResult.Text = answer.ToString("n4");
            txtNumOne.Focus();

        }

        private decimal calculate(decimal operand1, string operator1, decimal operand2)
        {
            decimal answer = 0m;
            switch (operator1)
            {
                case "+":
                    answer = operand1 + operand2;
                    break;
                case "-":
                    answer = operand1 - operand2;
                    break;
                case "*":
                    answer = operand1 * operand2;
                    break;
                case "/":
                    answer = operand1 / operand2;
                    break;
                default:
                    MessageBox.Show("Illegal Operator Entered\nMust be a +,-, * or /", "ILLEGAL OPERATOR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtOperator.Focus();
                    break;
            }
            return answer;
        }
    }
}