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
Extra 7-1 Add exception handling to the simple calculator
In this exercise, you’ll add exception handling to the Simple Calculator form.
1. Open the SimpleCalculator project in the Extra Starts\Chapter 07\SimpleCalculatorExceptionHandling directory.
2. Add a try-catch statement in the btnCalculate_Click() event handler that will catch any exceptions that occur when the statements in that event handler are executed. If an exception occurs, display a dialog box with the error message, the type of error, and a stack trace. Test the application by entering a nonnumeric value for one of the operands.
3. Add three additional catch blocks to the try-catch statement that will catch a FormatException, an OverflowException, and a DivideByZeroException. These catch blocks should display a dialog box with an appropriate error message.
4. Test the application again by entering a nonnumeric value for one of the operands. Then, enter 0 for the second operand as shown above to see what happens.
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
            decimal number1 = 0m;
            decimal number2 = 0m;
            string operator1 = "";
            decimal answer = 0m;
            bool result1;
            bool result2;

            try
            {
                result1 = Decimal.TryParse(txtNumOne.Text, out number1);
                result2 = Decimal.TryParse(txtNumTwo.Text, out number2);
                if (!result1 || !result2)
                {
                    throw new FormatException();
                }
                operator1 = txtOperator.Text;

                if((operator1!="+")&& (operator1 != "-") && (operator1 != "*") && (operator1 != "/") )
                {
                    throw new ArgumentException();
                }
                answer = calculate(number1, operator1, number1);
                txtResult.Text = answer.ToString("n4");
                txtNumOne.Focus();

            }
            catch (FormatException fex)
            {
                displayErrorReport(fex);
            }
            catch (ArgumentException aex)
            {
                displayErrorReport(aex);
            }
            catch (OverflowException oex)
            {
                displayErrorReport(oex);
            }
            catch (DivideByZeroException dex)
            {
                displayErrorReport(dex);
            }

        }
        private void displayErrorReport(Exception ex)
        {
            MessageBox.Show("The following error type occured: \n" + ex.GetType().ToString() + "\n\nWith the following error message: \n" + ex.Message + "\n\nHere is the stack trace: \n" + ex.StackTrace ,"ERROR MESSAGE DETAILS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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