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
 * EX1 [100 pts]
Write a GUI application for a loan company.

1.	The lender provides two types of loans. Short-Term and Long-Term loans.
2.	Short-Term loans have a monthly payment of $450 and an interest rate of 10%
3.	Long-Term loans have a monthly payment of $200 and an interest rate of 5%
4.	The program will allow the user to enter a loan name, amount and type.
5.	Once the loan has been created the user can make payments on the loan and see the current balance before and after interest is applied.
6.	The program should display an error message if a negative loan amount is entered.
 

ILoan
MakePayment() subtracts the appropriate payment amount from the balance.
ApplyInterest() adds the appropriate interest amount to the balance.

 */

namespace HOT07_01
{
    public partial class frmiLoan : Form
    {
        public frmiLoan()
        {
            InitializeComponent();
            rdoLongTermLoan.Checked = true;
            txtName.Focus();
        }
        

        List<ShortTermLoan> stLoans = new List<ShortTermLoan>();
        List<LongTermLoan> ltLoans = new List<LongTermLoan>();
        decimal balance;
        decimal monthlyPayment;
        decimal interestAccural;
        decimal balanceWithInterest;
        decimal interestRate;

        private void instantiateShortTermLoan()
        {
            ShortTermLoan stl = new ShortTermLoan(txtName.Text, Convert.ToDecimal( txtAmount.Text));

            stLoans.Add(stl);
            lblNameOutput.Text = stl.GetName();
            lblLoanTypeAmountOutput.Text = "Short-Term Loan of " +stl.GetAmount().ToString("c");
            
            monthlyPayment = stl.GetMontlyPayment();
            interestAccural = stl.ApplyInterest();
            interestRate = stl.GetInterestRate();
        }
        private void instantiateLongTermLoan()
        {
            LongTermLoan ltl = new LongTermLoan(txtName.Text, Convert.ToDecimal(txtAmount.Text));

            ltLoans.Add(ltl);
            lblNameOutput.Text = ltl.GetName();
            lblLoanTypeAmountOutput.Text = "Long-Term Loan of " + ltl.GetAmount().ToString("c");
            
            monthlyPayment = ltl.GetMontlyPayment();
            interestAccural = ltl.ApplyInterest();
            interestRate = ltl.GetInterestRate();
        }

        private void btnCreateLoan_Click(object sender, EventArgs e)
        {
            if (validateName())
            {
                if (validateAmount())
                {
                    balance = Convert.ToDecimal(txtAmount.Text);
                    if (rdoLongTermLoan.Checked)
                    {
                        instantiateLongTermLoan();
                        lblBalanceOutput.Text = "";
                        lblAccruedInterest.Text = "";
                    }
                    if (rdoShortTermLoan.Checked)
                    {
                        instantiateShortTermLoan();
                        lblBalanceOutput.Text = "";
                        lblAccruedInterest.Text = "";
                    }
                }
            }

           
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            if (balance <= 0 || balance<= monthlyPayment )
            {
                lblBalanceOutput.ForeColor = Color.Red;
                
                lblBalanceOutput.Text = "LOAN IS PAID OFF";
                lblAccruedInterest.Text = "";
                
            }
            else
            {
                lblBalanceOutput.ForeColor = Color.Black;
                MakePayment();
                balanceWithInterest = (balance * interestRate) + balance;
                lblBalanceOutput.Text = "After the last payment the loan is down to " + balance.ToString("c");
                lblAccruedInterest.Text = "After the last interest accumulation the loan is down to " + balanceWithInterest.ToString("c");
            }
        }
        private decimal MakePayment()
        {
            balance = balance - monthlyPayment;
            return balance;
        }
        private bool validateAmount()
        {
            bool retval = true;
            bool result;
            int width;

            if (txtAmount.Text.Trim() == "")
            {
                MessageBox.Show("Cannot have and empty amount", "EMPTY AMOUNT", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtAmount.Focus();
                retval = false;
            }
            else
            {
                result = int.TryParse(txtAmount.Text, out width);
                if (!result)
                {
                    MessageBox.Show("Cannot have and non-numeric amount", "NON-NUMERIC AMOUNT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAmount.Text = "";
                    txtAmount.Focus();
                    retval = false;
                }
                else
                {
                    if (width <= 0)
                    {
                        MessageBox.Show("Cannot have and negative or zero width", "OUT-OF-RANGE WIDTH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAmount.Text = "";
                        txtAmount.Focus();
                        retval = false;
                    }
                }
            }

            return retval;
        }

        private bool validateName()
        {

            bool retval = true;

            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Cannot have and empty name", "EMPTY NAME", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtName.Focus();
                retval = false;
                return retval;

            }
            retval = true;
            return retval;
        }
        
    }


    }
