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
 Extra 6-2 Add a method and an event handler to the income tax calculator
In this exercise, you’ll add a method and another event handler to an income tax calculator application.
1. Open the TaxCalculator project in the Extra Starts\Chapter 06 directory and display the code for the form.
2. Code the declaration for a private method named CalculateTax() that receives the income amount and returns the tax amount.
3. Move the if-else statement in the btnCalculate_Click() event handler to the CalculateTax() method. Then, declare a variable for the tax at the beginning of this method, and return the tax at the end of the method.
4. Modify the statement in the btnCalculate_Click() event handler that declares the tax variable so it gets its value by calling the CalculateTax() method.
5. Create an event handler that clears the Income Tax Owed text box if the user changes the value in the Taxable Income text box.
6. Test the application to be sure it still works correctly. The income values of 8700 and 35350 should display taxable amounts of 870 and 4044.50.
 */

namespace TaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
