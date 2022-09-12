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

namespace Chapt5_1Homework
{
    public partial class frmFactorialCalculator : Form
    {
        long factorialNumber = 1;
        public frmFactorialCalculator()
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
            txtNumber.Text = "";
            txtFactorial.Text = "";
            factorialNumber = 1;
            
            //set curser to text box
            txtNumber.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            long number = Convert.ToInt64(txtNumber.Text);
            int i;


            for (i = 1; i <= number; i++)
            {
                factorialNumber *= i;
            }

            txtFactorial.Text = factorialNumber.ToString("n0");
            factorialNumber = 1;

            txtNumber.Focus();
        }
    }
}
