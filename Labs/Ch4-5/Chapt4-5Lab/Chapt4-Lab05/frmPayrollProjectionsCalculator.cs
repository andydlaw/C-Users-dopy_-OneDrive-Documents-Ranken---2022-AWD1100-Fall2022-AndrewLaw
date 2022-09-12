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
 * Write a GUI program that calculates projected raises:
●	Declares a named constant PERCENT_RAISE and assign it a value of 4% (or 1.04)
●	Prompts the user for the names and salaries of three employees.
●	Displays the projected salaries for these three employees over the next 2 years in a table, assuming that they get a 4% raise every year.
*/

namespace Chapt4_Lab05
{
    public partial class frmPayrollProjectionsCalculator : Form
    {
        public frmPayrollProjectionsCalculator()
        {
            InitializeComponent();
        }
        const decimal PERCENT_RAISE = 1.04m;
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear out all text boxes and set focus
            txtNameOne.Text = "";
            txtNameTwo.Text = "";
            txtNameThree.Text = "";
            txtSalaryOne.Text = "";
            txtSalaryTwo.Text = "";
            txtSalaryThree.Text = "";
            lblEmployeeOne.Text = "";
            lblEmployeeTwo.Text = "";
            lblEmployeeThree.Text = "";
            lblYear.Text = "";
            //set curser to text box
            txtNameOne.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string nameOne = txtNameOne.Text;
            string nameTwo = txtNameTwo.Text;
            string nameThree = txtNameThree.Text;


            decimal employeeOneSalary = Convert.ToInt32(txtSalaryOne.Text);
            decimal employeeOneYearTwoSalary = employeeOneSalary * PERCENT_RAISE;
            decimal employeeOneYearThreeSalary = employeeOneYearTwoSalary * PERCENT_RAISE;

            decimal employeeTwoSalary = Convert.ToInt32(txtSalaryTwo.Text);
            decimal employeeTwoYearTwoSalary = employeeTwoSalary * PERCENT_RAISE;
            decimal employeeTwoYearThreeSalary = employeeTwoYearTwoSalary * PERCENT_RAISE;

            decimal employeeThreeSalary = Convert.ToInt32(txtSalaryThree.Text);
            decimal employeeThreeYearTwoSalary = employeeThreeSalary * PERCENT_RAISE;
            decimal employeeThreeYearThreeSalary = employeeThreeYearTwoSalary * PERCENT_RAISE;

            lblYear.Text = "Year\n\n2022\n2023\n2024";
            string msg1 = nameOne + "\n \n" + employeeOneSalary.ToString("c") +"\n"+employeeOneYearTwoSalary.ToString("c") + "\n"+employeeOneYearThreeSalary.ToString("c");
            string msg2 = nameTwo + "\n \n" + employeeTwoSalary.ToString("c") + "\n" + employeeTwoYearTwoSalary.ToString("c") + "\n" + employeeTwoYearThreeSalary.ToString("c");
            string msg3 = nameThree + "\n \n" + employeeThreeSalary.ToString("c") + "\n" + employeeThreeYearTwoSalary.ToString("c") + "\n" + employeeThreeYearThreeSalary.ToString("c");


            lblEmployeeOne.Text = msg1;
            lblEmployeeTwo.Text = msg2;
            lblEmployeeThree.Text = msg3;
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

        private void frmPayrollProjectionsCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
