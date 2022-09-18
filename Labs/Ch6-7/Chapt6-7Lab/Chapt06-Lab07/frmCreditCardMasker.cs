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
 * LB7. Write a GUI application that masks all but the last 4 digits of a credit card number with a X
1.	Leave the last four digits as is.
2.	Leave any spaces as is.
3.	Replace any number or letter with a # 
a.	HINT** Research Char.IsDigit() & Char.IsLetter())
4.	The program should work for credit card numbers that are any length (including numbers that are less than four digits long).
5.	The program must support credit card numbers with spaces, dashes, or no separator.

Create a method named MaskNumber() that accepts an unmasked string, a replacement character, the number of digits to preserve, then returns the masked string. This method should not have any side effects.

*/

namespace Chapt06_Lab07
{
    public partial class frmCreditCardMasker : Form
    {
        public frmCreditCardMasker()
        {
            InitializeComponent();
        }

        string cardNumber;
        string lastDigit;
        string firstDigit;
        string masked;
        int len;
        private void btnMask_Click(object sender, EventArgs e)
        {
            MaskNumber();
        }
        private void MaskNumber()
        {
            cardNumber = txtCreditCard.Text;
            firstDigit = cardNumber.Substring(0, cardNumber.Length - 4);
            lastDigit = cardNumber.Substring(cardNumber.Length - 4);
            len = firstDigit.Length;
            for (int i = 0; i < len; i++)
            {
                if (char.IsDigit(firstDigit[i]) || char.IsLetter(firstDigit[i]))
                {
                    masked += "#";
                }

                else if (!char.IsDigit(firstDigit[i]) || !char.IsLetter(firstDigit[i]))
                {
                    masked += firstDigit[i];
                }
            }
            lblMasked.Text = masked + lastDigit;
            masked = "";
        }

        private void txtCreditCard_TextChanged(object sender, EventArgs e)
        {
            lblMasked.Text = "";
        }
    }
}
