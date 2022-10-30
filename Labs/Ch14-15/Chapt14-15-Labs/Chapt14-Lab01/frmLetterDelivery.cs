using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * LB1 Letters
Create a GUI application for a letter delivery service.
●	Letters cost 50 cents to send.
●	Certified letter cost an additional 15 cents to send, but include a tracking number.
●	The user can send up to 20 letters.
●	Every time a letter is sent it will be added to the top of the transaction log.
●	Store the list of sent letters in a single array.
●	If the letter does not include a tracking number then instantiate a Letter object.
●	If the letter includes a tracking number then instantiate a CertifiedLetter object.

 */

namespace Chapt14_Lab01
{
    public partial class frmLetterDelivery : Form
    {
        public frmLetterDelivery()
        {
            InitializeComponent();
        }
        //Global Constant
        const int TOTALLETTERS = 20;

        List<Letter> letters= new List<Letter>(TOTALLETTERS);
        List<CertifiedLetter> certified = new List<CertifiedLetter>(TOTALLETTERS);
        string[]    sentLetters = new string[TOTALLETTERS];
        int numElement = 0;
        DateTime sentDate;

        private void btnSend_Click(object sender, EventArgs e)
        {
            bool keepGoing = validateRecipient();
            if (keepGoing)
            {
                keepGoing = validateSentDate();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                keepGoing = isThereTrackingNumber();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                instantiateCertifiedLetter();
            }
            else
            {
                instantiateLetter();
            }
            txtRecipient.Text = "";
            txtTrackingNumber.Text = "";
            txtRecipient.Focus();
        }
        private void instantiateCertifiedLetter()
        {
            if (numElement < TOTALLETTERS)
            {
                CertifiedLetter cl = new CertifiedLetter(txtRecipient.Text, sentDate, txtTrackingNumber.Text);

                certified.Add(cl);

                txtOutput.Text += cl.ToString() + "\r\n";

                sentLetters = txtOutput.Text.Split('\n');
                lblMemo.Visible = true;

                ++numElement;
            }
            else
            {
                showMessage("No more room for certified letter in list", "LIST IS FULL");
                lblMemo.Visible = false;
            }
        }
        private void instantiateLetter()
        {
            if (numElement < TOTALLETTERS)
            {
                Letter l = new Letter(txtRecipient.Text, sentDate);

                letters.Add(l);

                txtOutput.Text += l.ToString() + "\r\n";

                sentLetters = txtOutput.Text.Split('\n');
                lblMemo.Visible = false;

                ++numElement;
            }
            else
            {
                showMessage("No more room for letter in list", "LIST IS FULL");
                lblMemo.Visible = false;
            }
        }

        private bool isThereTrackingNumber()
        {
            bool retVal = true;
            if (txtTrackingNumber.Text.Trim() == "")
            {
                retVal = false;
            }
            return retVal;
        }

        private bool validateRecipient()
        {
            bool retVal = true;
            if (txtRecipient.Text.Trim() == "")
            {
                showMessage("Recipient cannot be emty!", "RECIPIENT FIELD EMPTY");
                txtRecipient.Focus();
                retVal = false;
            }
            return retVal;
        }
        private bool validateSentDate()
        {
            bool result;
            bool retVal = true;
            if (txtSentDate.Text.Trim() == "")
            {
                showMessage("Sent Date cannot be emty!", "SENT DATE FIELD EMPTY");
                txtSentDate.Focus();
                retVal = false;
            }
            else
            {


                result = DateTime.TryParse(txtSentDate.Text, out sentDate);

                if (!result)
                {
                    showMessage("Sent Date must be a valid date!", "SENT DATE FIELD NOT VALID");
                    txtSentDate.Text = "";
                    txtSentDate.Focus();
                    retVal = false;
                }
            }
            return retVal;
        }
        private void showMessage(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
