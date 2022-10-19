using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Chapt12_1Homework
{
    public partial class frmNewInventory : Form
    {
        public frmNewInventory()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateItemNumber())
            {
                if (validateDesc())
                {
                    if (validatePrice())
                    {
                        handleNewItem();
                    }
                }


            }

            
        }

        private bool validateDesc()
        {
            bool retval = true;

            if (txtNewDescription.Text.Trim() == "")
            {
                MessageBox.Show("Cannot have and empty description", "EMPTY DESC", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNewDescription.Focus();
                retval = false;
                return retval;

            }
            retval = true;
            return retval;
        }
        private bool validatePrice()
        {
            bool retval = true;
            bool result;
            decimal price;

            if (txtNewPrice.Text.Trim() == "")
            {
                MessageBox.Show("Cannot have and empty price", "EMPTY PRICE", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNewPrice.Focus();
                retval = false;
            }
            else
            {
                result = decimal.TryParse(txtNewPrice.Text, out price);
                if (!result)
                {
                    MessageBox.Show("Cannot have and non-numeric price", "NON-NUMERIC PRICE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPrice.Text = "";
                    txtNewPrice.Focus();
                    retval = false;
                }
                else
                {
                    if (price <= 0)
                    {
                        MessageBox.Show("Cannot have and negative or zero price", "OUT-OF-RANGE PRICE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNewPrice.Text = "";
                        txtNewPrice.Focus();
                        retval = false;
                    }
                }
            }

            return retval;
        }
        private bool validateItemNumber()
        {
            bool retval = true;
            bool result;
            int itemNumber;

            if (txtNewItemNo.Text.Trim() == "")
            {
                MessageBox.Show("Cannot have and empty item number", "EMPTY ITEM NUMBER", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNewItemNo.Focus();
                retval = false;
            }
            else
            {
                result = int.TryParse(txtNewItemNo.Text, out itemNumber);
                if (!result)
                {
                    MessageBox.Show("Cannot have and non-numeric item number", "NON-NUMERIC ITEM NUMBER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewItemNo.Text = "";
                    txtNewItemNo.Focus();
                    retval = false;
                }
                else
                {
                    if (itemNumber <= 0)
                    {
                        MessageBox.Show("Cannot have and negative or zero item number", "OUT-OF-RANGE ITEM NUMBER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNewItemNo.Text = "";
                        txtNewItemNo.Focus();
                        retval = false;
                    }
                }
            }

            return retval;
        }


        private void handleNewItem()
        {
            frmInventoryMaintenance form1 = new frmInventoryMaintenance();
            form1.receiveData(Convert.ToInt32(txtNewItemNo.Text), txtNewDescription.Text, Convert.ToDecimal(txtNewPrice.Text));
            this.Close();
            form1.Show();
             //InvItem.(Convert.ToInt32(txtNewItemNo.Text), txtNewDescription.Text, Convert.ToDecimal(txtNewPrice.Text));
        }
    }
}
