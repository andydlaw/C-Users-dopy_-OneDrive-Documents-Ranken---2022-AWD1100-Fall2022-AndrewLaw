using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapt07_Lab02
{
    public partial class frmOrderValidator : Form
    {
        public frmOrderValidator()
        {
            InitializeComponent();
        }
        const int MINITEM = 100;
        const int MAXITEM = 999;
        const int MINQUANTITY = 1;
        const int MAXQUANTITY = 12;
        const int MINESTDELIVERY = 1;
        const int MAXESTDELIVERY = 30;

        const string INVO = "Order is not valid";
        const string VO = "Order is valid";

        int item;
        int quanity;
        int delivery;

        private bool validateItem()
        {
            bool retVal = true;
            bool result;
            try
            {
                result = Int32.TryParse(txtItemNumber.Text, out item);

                if (!result)
                {
                    throw new FormatException();
                }

                if ((item < MINITEM) || (item > MAXITEM))
                {
                    throw new ArgumentOutOfRangeException();
                }


            }
            catch (FormatException fex)
            {
                showMessage(fex, txtItemNumber.Tag.ToString());

                
                lblResults.Text = INVO;

                retVal = false;
            }
            catch (ArgumentOutOfRangeException aex)
            {
                showMessage(aex, txtItemNumber.Tag.ToString());
                
                lblResults.Text = INVO;

                retVal = false;
            }
            return retVal;

        }
        private bool validateQuantity()
        {
            bool retVal = true;
            bool result;
            try
            {
                result = Int32.TryParse(txtQuantity.Text, out quanity);

                if (!result)
                {
                    throw new FormatException();
                }

                if ((quanity < MINQUANTITY) || (quanity > MAXQUANTITY))
                {
                    throw new ArgumentOutOfRangeException();
                }


            }
            catch (FormatException fex)
            {
                showMessage(fex, txtQuantity.Tag.ToString());


                lblResults.Text = INVO;

                retVal = false;
            }
            catch (ArgumentOutOfRangeException aex)
            {
                showMessage(aex, txtQuantity.Tag.ToString());

                lblResults.Text = INVO;

                retVal = false;
            }
            return retVal;

        }
        private bool validateDelivery()
        {
            bool retVal = true;
            bool result;
            try
            {
                result = Int32.TryParse(txtEstDelivery.Text, out delivery);

                if (!result)
                {
                    throw new FormatException();
                }

                if ((delivery < MINESTDELIVERY) || (delivery > MAXESTDELIVERY))
                {
                    throw new ArgumentOutOfRangeException();
                }


            }
            catch (FormatException fex)
            {
                showMessage(fex, txtEstDelivery.Tag.ToString());


                lblResults.Text = INVO;

                retVal = false;
            }
            catch (ArgumentOutOfRangeException aex)
            {
                showMessage(aex, txtEstDelivery.Tag.ToString());

                lblResults.Text = INVO;

                retVal = false;
            }
            return retVal;

        }
        private void displayOrderStatus()
        {
            lblResults.Text = VO;
        }

        private void showMessage(Exception ex, string tag)
        {
            MessageBox.Show("Invalid " + tag + " was inputted!" +
                            "\n\n The error message: " + ex.Message +
                            "\n\n The Error type: " + ex.GetType().ToString() +
                            "\n\n The stack trace: " + ex.StackTrace,
                            "ERROR INFORMATION",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

            if (tag == "item")
            {
                txtItemNumber.Text = "";
                txtItemNumber.Focus();

            }
            else if (tag == "quantity")
            {
                txtQuantity.Text = "";
                txtQuantity.Focus();

            }
            else if (tag == "delivery")
            {
                txtEstDelivery.Text = "";
                txtEstDelivery.Focus();

            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            bool keepGoing = validateItem();

            if (keepGoing)
            {
                keepGoing = validateQuantity();
            }
            if(keepGoing)
            {
                keepGoing = validateDelivery();
            }
            else 
            {
                return;
            }
            if (keepGoing)
            {
                displayOrderStatus();
            }
            
            
           
        }
    }
}
