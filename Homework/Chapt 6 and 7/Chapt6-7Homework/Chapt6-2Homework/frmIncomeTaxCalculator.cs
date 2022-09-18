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
 Extra 6-2 Add a method and an event handler to the income tax calculator
In this exercise, you’ll add a method and another event handler to an income tax calculator application.
1. Open the TaxCalculator project in the Extra Starts\Chapter 06 directory and display the code for the form.
2. Code the declaration for a private method named CalculateTax() that receives the income amount and returns the tax amount.
3. Move the if-else statement in the btnCalculate_Click() event handler to the CalculateTax() method. Then, declare a variable for the tax at the beginning of this method, and return the tax at the end of the method.
4. Modify the statement in the btnCalculate_Click() event handler that declares the tax variable so it gets its value by calling the CalculateTax() method.
5. Create an event handler that clears the Income Tax Owed text box if the user changes the value in the Taxable Income text box.
6. Test the application to be sure it still works correctly. The income values of 8700 and 35350 should display taxable amounts of 870 and 4044.50.
 */

namespace Chapt5_3Homework
{
    public partial class frmIncomeTaxCalculator : Form
    {

        decimal taxOwed;
        public frmIncomeTaxCalculator()
        {
            InitializeComponent();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear out all text boxes and set focus
            txtTaxableIncome.Text = "";
            txtIncomeTaxOwed.Text = "";
            taxOwed = 0;
            //set curser to text box
            txtTaxableIncome.Focus();
        }

        private decimal CalculateTax(decimal income)
        {
            if (income >= 0 && income <= 9875)
            {
                taxOwed = 0 + (income * .10m);
            }
            else if (income >= 9876 && income <= 40125)
            {
                taxOwed = 987.50m + ((income - 9875) * .12m);
            }
            else if (income >= 40126 && income <= 85525)
            {
                taxOwed = 4617.50m + ((income - 40125) * .22m);
            }
            else if (income >= 85526 && income <= 163300)
            {
                taxOwed = 14605.50m + ((income - 85525) * .24m);
            }
            else if (income >= 163301 && income <= 207350)
            {
                taxOwed = 33271.50m + ((income - 163300) * .32m);
            }
            else if (income >= 207351 && income <= 518400)
            {
                taxOwed = 47367.50m + ((income - 207350) * .35m);
            }
            else if (income >= 207351)
            {
                taxOwed = 156235 + ((income - 518400) * .37m);
            }
            return taxOwed;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal income = Convert.ToDecimal(txtTaxableIncome.Text);


            taxOwed = CalculateTax(income);


            txtIncomeTaxOwed.Text = taxOwed.ToString("c");
            //txtTaxableIncome.Text = income.ToString("c");
            taxOwed = 0m;


        }

        private void txtTaxableIncome_TextChanged(object sender, EventArgs e)
        {
            txtIncomeTaxOwed.Text = "";
        }
    }
}
