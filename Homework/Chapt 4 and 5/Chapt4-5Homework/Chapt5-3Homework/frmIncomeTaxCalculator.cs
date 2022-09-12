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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal income = Convert.ToDecimal(txtTaxableIncome.Text);
            


            if (income >= 0 && income <= 9875)
            { 
                taxOwed = 0 + (income * .10m); 
            }
            else if (income >= 9876 && income <= 40125)
            { 
                taxOwed = 987.50m + ((income-9875) * .12m); 
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
            
            txtIncomeTaxOwed.Text = taxOwed.ToString("c");
            txtTaxableIncome.Text = income.ToString("c");
            taxOwed = 0m;


        }
    }
}
