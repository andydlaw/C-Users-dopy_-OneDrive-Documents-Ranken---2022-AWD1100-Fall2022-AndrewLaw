using Chapt10_2Homework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapt10_2Homework
{
    /*
     * Extra 10-2 Process lunch orders
In this exercise, you’ll complete a form that accepts a lunch order from the user and then calculates the order subtotal and total.
The application should provide for these main courses and add-ons: Main course Price Add-on Add-on price Hamburger 6.95 Lettuce, tomato, and onions .75 Ketchup, mustard, and mayo French fries Pizza 5.95 Pepperoni .50 Sausage Olives Salad 4.95 Croutons .25 Bacon bits Bread sticks
1. Open the LunchOrder project in the Extra Starts\Chapter 10 directory.
2. Add three radio buttons to the Main Course group box, and set their properties so they appear as shown above. The Hamburger option should be selected by default.
3. Add a group box for the add-on items. Then, add three check boxes to this group box as shown above. None of the check boxes should be selected by default.
4. Code a method name ClearTotals() that clears the three text boxes and a method named ClearAddOns() that removes the check marks from the three check boxes.
5. Code an event handler that changes the text that’s displayed for the Add-ons group box and the three check boxes when the user selects a different main course. This event handler should also remove the check marks from the add-ons and clear the order totals. Test the application to be sure this works correctly.
6. Code an event handler that calculates and displays the subtotal, tax, and order total when the user clicks the Place Order button. The subtotal is the cost of the main course plus the cost of the add-ons. The tax is 7.75% of the subtotal. And the order total is the
     */
    public partial class frmLunchOrder : Form
    {
        decimal salesTax = 0.0775m;
        decimal mainCoursePrice = 0m;
        decimal addOnPrice = 0m;
        frmNewSalesTax f2;
        public frmLunchOrder()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {



            this.Hide();
            frmNewSalesTax fo = new frmNewSalesTax();
            fo.Visible = true;

            //frmNewSalesTax subform1 = new frmNewSalesTax();            
            //subform1.Show();

            //Hide();

        }

        public decimal SalesTax { get { return salesTax; } set { salesTax = value; } }

        private void frmLunchOrder_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculateTotals();
            
        }
        private void calculateTotals()
        {
            decimal SubTotal = mainCoursePrice + addOnPrice;
            decimal TaxTotal = SubTotal * salesTax;
            decimal Total = SubTotal + TaxTotal;

            txtSubtotal.Text = SubTotal.ToString("c");
            txtTax.Text = TaxTotal.ToString("c");
            txtOrderTotal.Text = Total.ToString("c");
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radHamburger.Checked)
            { mainCoursePrice = 6.95m; }
        }

        private void radPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (radPizza.Checked)
            { mainCoursePrice = 5.95m; }
        }

        private void radSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (radSalad.Checked)
            { mainCoursePrice = 4.95m; }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckLTO.Checked)
            {
                addOnPrice = addOnPrice + 0.75m;
                calculateTotals();
            }
            else
            {
                addOnPrice = addOnPrice - 0.75m;
                calculateTotals();
            }
        }

        private void ckKMM_CheckedChanged(object sender, EventArgs e)
        {
            if (ckKMM.Checked)
            {
                addOnPrice = addOnPrice + 0.75m;
                calculateTotals();
            }
            else
            {
                addOnPrice = addOnPrice - 0.75m;
                calculateTotals();
            }
        }

        private void ckFF_CheckedChanged(object sender, EventArgs e)
        {
            if (ckFF.Checked)
            {
                addOnPrice = addOnPrice + 0.75m;
                calculateTotals();
            }
            else
            {
                addOnPrice = addOnPrice - 0.75m;
                calculateTotals();
            }    
        }
    }
}
