using System;
using System.Windows.Forms;

namespace Chapt12_Lab03
{
    public class Account
    {
        public decimal MINIMUMBALANCE = 25.00m;

        private readonly string _title;
        private readonly string _firstname;
        private readonly string _lastname;
        private readonly string _accountnumber;
        private readonly string _pin;
        private decimal _balance;

        //constructor
        public Account(string title, string firstname, string lastname, string accountnumber, string pin, decimal balance)
        {
            _title = title;
            _firstname = firstname;
            _lastname = lastname;
            _accountnumber = accountnumber;
            _pin = pin;
            _balance = balance;
        }

        //getters
        public string GetTitle()
        {
            return _title;
        }
        public string GetFirstName()
        {
            return _firstname;
        }
        public string GetLastName()
        {
            return _lastname;
        }
        public string GetAccountNumber()
        {
            return _accountnumber;
        }
        public string GetPin()
        {
            return _pin;
        }
        public decimal GetBalance()
        {
            return _balance;
        }
        public void MakeDeposit(decimal amount)
        {
            decimal theDeposit = -1;
            bool result;

            //Check for null input
            if (amount.ToString() == "")
            {
                return;
            }

            result = decimal.TryParse(amount.ToString(), out theDeposit);
            if (!result)
            {
                MessageBox.Show("Illegal Non-Numeric Input for Deposit", "ILLEGAL DEPOSIT ATTEMPTED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                //Attempt to make deposit
                if (theDeposit <= 0)
                {
                    MessageBox.Show("Illegal Input for Deposit", "ILLEGAL DEPOSIT ATTEMPTED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                //legal value inputted for deposit
                _balance += theDeposit;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown Error Occurred\n\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public void MakeWidthdrawl(decimal amount)
        {
            decimal theWithdrawl = -1m;
            decimal amountLeft = 0m;
            bool result;

            //Check for null input
            if (amount.ToString() == "")
            {
                return;
            }

            result = decimal.TryParse(amount.ToString(), out theWithdrawl);
            if (!result)
            {
                MessageBox.Show("Illegal Non-Numeric Input for Withdrawl", "ILLEGAL WITHDRAWL ATTEMPTED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                //Attempt to make withdrawl
                if (theWithdrawl <= 0)
                {
                    MessageBox.Show("Illegal Input for Withdrawl", "ILLEGAL WITHDRAWL ATTEMPTED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                //legal value inputted for widthdrawl
                //check if funds are available
                //if funds are available make withdrawl
                //if funds are not available do not allow withdrawl
                amountLeft = _balance - theWithdrawl;

                if (amountLeft > MINIMUMBALANCE)
                {
                    _balance -= theWithdrawl;
                }
                else
                {
                    MessageBox.Show("Insufficient funds for withdrawl.", "OVERDRAWN ATTEMPTED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown Error Occurred\n\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }

}
