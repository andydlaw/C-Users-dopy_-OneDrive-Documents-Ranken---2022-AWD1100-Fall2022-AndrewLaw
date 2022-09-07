using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


/*
 * Extra 5-2 Calculate change
In this exercise, you’ll develop a form that tells how many quarters, dimes, nickels,
    and pennies are needed to make change for any amount of change from 0 through 99 
    cents. One way to get the results is to use the division and modulus operators and to 
    cast the result of each division to an integer.

1. Start a new project named ChangeCalculator in the Extra Starts\Chapter 05 directory.
2. Add labels, text boxes, and buttons to the default form and set the properties of the 
    form and its controls so they appear as shown above. When the user presses the Enter key, 
    the Click event of the Calculate button should fire. When the user presses the Esc key, 
    the Click event of the Exit button should fire.
3. Create an event handler for the Click event of the Calculate button. Then, write the code 
    for calculating and displaying the number of quarters, dimes, nickels, and pennies that 
    are needed for the change amount the user enters. This code should provide for integer entries, 
    but you can assume that the user will enter valid integer values.
4. Create an event handler for the Click event of the Exit button that closes the form.
5. Test the application to be sure it works correctly.
*/

namespace Chapt5_2Homework
{
    public partial class frmChangeCalculator : Form
    {
        public frmChangeCalculator()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmChangeCalculator_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            //clear out all text boxes and set focus
            txtAmtChangeDue.Text = "";
            txtDimes.Text = "";
            txtQuarters.Text = "";
            txtNickels.Text = "";
            txtPennies.Text = "";
            //set curser to text box
            txtAmtChangeDue.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int amtChangeDue = Convert.ToInt32(txtAmtChangeDue.Text);
            int quartersDue;
            int dimesDue;
            int nickelsDue;
            int penniesDue;
            int whatsLeft;

            // Calculate Number of Quarters
            quartersDue = amtChangeDue / 25;
            whatsLeft = amtChangeDue % 25;

            // Calculate Number of Dimes
            dimesDue = whatsLeft / 10;
            whatsLeft = whatsLeft % 10;

            // Calculate Number of Nickel
            nickelsDue = whatsLeft / 5;
            whatsLeft = whatsLeft % 5;

            // Calculate Number of Pennies
            penniesDue = whatsLeft;

            //Fill text boxes
            txtQuarters.Text =  quartersDue.ToString();
            txtDimes.Text = dimesDue.ToString();
            txtNickels.Text = nickelsDue.ToString();
            txtPennies.Text = penniesDue.ToString();




        }
    }
}
