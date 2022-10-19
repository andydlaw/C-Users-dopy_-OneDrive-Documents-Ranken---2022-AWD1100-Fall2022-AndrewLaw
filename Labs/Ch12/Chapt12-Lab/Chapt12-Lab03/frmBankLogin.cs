using System;
using System.Collections.Generic;
using System.Windows.Forms;

/*
 * LB3 BankLogin
Create a prototype for an online bank.
●	The program requires an account number and pin number to login.
●	Once logged in, the user can deposit or withdraw money.
●	When the user is done, they can log out of the system.
●	There can only be one user logged in at a time.
●	The program should have at least 5 accounts.
Screen Mockups
 
Methods
Login() accepts an account number and pin number as strings. If valid, logs the user in, displays a welcome message, and displays their balance.  If invalid, logs out the previous user and displays an error message. 
Logout() logs out the active user.
MakeDeposit() accepts a deposit amount as a decimal and displays the user's updated balance.
MakeWithdrawal() accepts a withdrawal amount as a decimal and displays the user's updated balance. 

 */

namespace Chapt12_Lab03
{
    public partial class frmBankLogin : Form
    {
        public frmBankLogin()
        {
            InitializeComponent();
        }
        //constant
        const int NUMCUSTOMERS = 5;

        //global variables
        List<Account> accounts = new List<Account>();

        int validAccountNumLoc = -1;
        int validPinNumLoc = -1;
        bool yourLoggedIn = false;

        private void frmBankLogin_Load(object sender, EventArgs e)
        {
            accounts.Add(new Account("Mrs.", "Lori", "Law", "123456", "1111", 2000m));
            accounts.Add(new Account("Ms.", "Remy", "Law", "098765", "2222", 2500m));
            accounts.Add(new Account("Ms.", "Zoey", "Law", "234567", "3333", 2400.44m));
            accounts.Add(new Account("Mr.", "Andy", "Law", "345678", "44444", 2300.33m));
            accounts.Add(new Account("Mr.", "Whiskey", "Law", "456789", "5555", 2900.55m));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Logout()
        {
            //Logout User
            yourLoggedIn = false;
            btnLogin.Enabled = true;
            btnLogout.Enabled = false;
            txtAcctNum.Enabled = true;
            txtPin.Enabled = true;
            txtDeposit.Enabled = false;
            txtWithdrawl.Enabled = false;
            btnWithdrawl.Enabled = false;
            btnDeposit.Enabled = false;
            txtAcctNum.Focus();
            txtAcctNum.Text = "";
            txtPin.Text = "";
            txtDeposit.Text = "";
            txtWithdrawl.Text = "";
            txtWelcomeInfo.Text = "You're logged out.";
        }

        private void Login()
        {
            bool missingInfo = true;
            bool badAcctNum = true;
            bool badPinNum = true;


            //Check for missing Acct or Pin
            missingInfo = isAnyLoginInfoMissing();
            if (missingInfo)
            {
                return;
            }

            //Check for bad Acct or Pin
            badAcctNum = validateAccountNumber(txtAcctNum.Text);
            badPinNum = validatePin(txtPin.Text);
            if (badPinNum || badAcctNum)
            {
                displayBadAcctNumBadPinMsg();
                return;
            }

            if (validAccountNumLoc != validPinNumLoc)
            {
                displayBadAcctNumBadPinMsg();
                return;
            }

            //valid acct and pin
            rewriteWelcomeScreen();
            makeScreenActive();
        }

        public void makeScreenActive()
        {
            //Login User
            yourLoggedIn = true;
            btnLogin.Enabled = false;
            btnLogout.Enabled = true;
            txtAcctNum.Enabled = false;
            txtPin.Enabled = false;
            txtDeposit.Enabled = true;
            txtWithdrawl.Enabled = true;
            btnWithdrawl.Enabled = true;
            btnDeposit.Enabled = true;
            txtDeposit.Focus();
        }
        public void rewriteWelcomeScreen()
        {
            yourLoggedIn = true;
            txtWelcomeInfo.Text = "";
            string outputStr = "Welcome, ";
            outputStr += accounts[validPinNumLoc].GetTitle() + " " + accounts[validPinNumLoc].GetFirstName() + " " + accounts[validPinNumLoc].GetLastName() + "!";
            outputStr += "\r\nYour Account Balance is ";
            outputStr += accounts[validPinNumLoc].GetBalance().ToString("c");
            txtWelcomeInfo.Text = outputStr;
        }
        private bool validateAccountNumber(string an)
        {
            validAccountNumLoc = -1;
            for (int i = 0; i < accounts.Count; ++i)
            {
                if (an == accounts[i].GetAccountNumber())
                {
                    validAccountNumLoc = i;
                    return false;
                }
            }
            return true;
        }
        private bool validatePin(string p)
        {
            validPinNumLoc = -1;
            for (int i = 0; i < accounts.Count; ++i)
            {
                if (p == accounts[i].GetPin())
                {
                    validPinNumLoc = i;
                    return false;
                }
            }
            return true;
        }
        private void displayBadAcctNumBadPinMsg()
        {
            txtWelcomeInfo.Text = "";
            string outputStr = "Bad Account Number and/or bad Pin";
            outputStr += "\r\nPlease re-enter your info now!";

            txtWelcomeInfo.Text = outputStr;
            clearLoginFields();
            return;
        }
        private bool isAnyLoginInfoMissing()
        {
            txtWelcomeInfo.Text = "";
            string outputStr = "Account Number and Pin are mandatory!";
            outputStr += "\r\nAccount Number must be in ###### format!";
            outputStr += "\r\nPin must be in #### format!";
            outputStr += "\r\nPlease try again and enter both values.";

            if (txtAcctNum.Text.Trim() == "" || txtPin.Text.Trim() == "")
            {
                txtWelcomeInfo.Text = outputStr;

                clearLoginFields();

                return true;
            }
            return false;
        }
        private void clearLoginFields()
        {
            txtPin.Text = "";
            txtAcctNum.Text = "";
            txtAcctNum.Focus();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Exit Button Code
            DialogResult dialog = MessageBox.Show(
                "Do You Really Want To LOGOUT?",
                "LOGOUT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Logout();
            }

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            attemptTheDeposit();
            return;
        }
        private void attemptTheDeposit()
        {
            decimal deposit = 0m;
            try
            {
                deposit = Convert.ToDecimal(txtDeposit.Text);
                accounts[validPinNumLoc].MakeDeposit(deposit);
                rewriteWelcomeScreen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown Error Occurred\n\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDeposit.Text = "";
                txtDeposit.Focus();
                return;
            }

        }

        private void btnWithdrawl_Click(object sender, EventArgs e)
        {
            attemptTheWithdrawal();
        }
        private void attemptTheWithdrawal()
        {
            decimal withdrawl = 0m;
            try
            {
                withdrawl = Convert.ToDecimal(txtWithdrawl.Text);
                accounts[validPinNumLoc].MakeWidthdrawl(withdrawl);
                rewriteWelcomeScreen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown Error Occurred\n\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWithdrawl.Text = "";
                txtWithdrawl.Focus();
                return;
            }
        }
    }
}
