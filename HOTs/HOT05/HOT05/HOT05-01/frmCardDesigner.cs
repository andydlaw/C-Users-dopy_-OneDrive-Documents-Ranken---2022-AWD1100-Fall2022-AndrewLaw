using System;
using System.Windows.Forms;

/*
 * Using your textbook, labs and lecture notes to complete the following test in 4 hours.

All code submitted must be your original work. When finished, your solution must be uploaded to your GitHub repository.

EX1 [100 pts]

Write GUI application CardDesignerGUI that allows the user to design a card.

● The user can select from 3 different occasions.

● The user can select from 3 different styles for each occasion.

● Each card style has a different base cost.

● The user can choose to add an envelope for 25 cents.

● The user can choose to add a stamp for 50 cents.

● The user can choose to add a custom message for 25 cents.

● The user can only enter a custom message if the checkbox is checked.

● The user can preview their custom message on the card.

● The application correctly calculates the card cost at all times.
 */

namespace HOT05_01
{
    public partial class frmCardDesigner : Form
    {
        //declaring all variables
        decimal totalCost = 0m;
        decimal envelopeCost = 0m;
        decimal customMessageCost = 0m;
        decimal stampCost = 0m;
        decimal cardCost = 0m;
        public frmCardDesigner()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //calculates cost of card and displays card
            Calculate();
        }
        private void Calculate()
        {
            StyleSelect();
            OccasionSelect();
            TotalCost();
            lblCustomMessage.Text = txtCustomMessage.Text;


        }

        private void TotalCost()
        {
            //check cost of custom message
            if (ckbxCustomMessage.Checked == true)
            {
                customMessageCost = 0.25m;
            }
            //check cost of envelope
            if (ckbxEnvelope.Checked == true)
            {
                envelopeCost = 0.25m;
            }
            //check cost of stamp
            if (ckbxStamp.Checked == true)
            {
                stampCost = 0.50m;
            }
            totalCost = envelopeCost + customMessageCost + stampCost + cardCost;
            lblTotalCost.Text = totalCost.ToString("c");
        }


        private void StyleSelect()
        {
            //switch to display style of card and calculate base cost
            switch (cbxStyle.SelectedIndex)
            {
                case 0:
                    imgCardBackgroundDigital.Visible = false;
                    imgCardBackgroundOperator.Visible = false;
                    imgCardBackgroundEDC.Visible = false;
                    MessageBox.Show("You Must Choose A Style From The List Below",
                        "INVALID STYLE CHOSEN",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    cbxStyle.Focus();
                    break;
                case 1:
                    imgCardBackgroundDigital.Visible = true;
                    imgCardBackgroundOperator.Visible = false;
                    imgCardBackgroundEDC.Visible = false;
                    cardCost = 2.50m;
                    break;
                case 2:
                    imgCardBackgroundDigital.Visible = false;
                    imgCardBackgroundOperator.Visible = true;
                    imgCardBackgroundEDC.Visible = false;
                    cardCost = 1.50m;
                    break;
                case 3:
                    imgCardBackgroundDigital.Visible = false;
                    imgCardBackgroundOperator.Visible = false;
                    imgCardBackgroundEDC.Visible = true;
                    cardCost = 3.50m;
                    break;
                default:
                    MessageBox.Show("You Must Choose A Style From The List Below",
                        "INVALID STYLE CHOSEN",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    cbxStyle.Focus();
                    break;
            }


        }

        private void OccasionSelect()
        {
            //switch to display occasion of card 
            switch (cbxOccasion.SelectedIndex)
            {
                case 0:
                    imgThankYou.Visible = false;
                    imgGetWell.Visible = false;
                    imgCongrats.Visible = false;
                    MessageBox.Show("You Must Choose An Occasion From The List Below",
                        "INVALID OCCASION CHOSEN",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    cbxOccasion.Focus();
                    break;
                case 1:
                    imgThankYou.Visible = true;
                    imgGetWell.Visible = false;
                    imgCongrats.Visible = false;
                    break;
                case 2:
                    imgThankYou.Visible = false;
                    imgGetWell.Visible = true;
                    imgCongrats.Visible = false;
                    break;
                case 3:
                    imgThankYou.Visible = false;
                    imgGetWell.Visible = false;
                    imgCongrats.Visible = true;
                    break;
                default:
                    MessageBox.Show("You Must Choose An Occasion From The List Below",
                        "INVALID OCCASION CHOSEN",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    cbxOccasion.Focus();
                    break;
            }

        }

        private void btnSplashScreen_Click(object sender, EventArgs e)
        {
            //show splash screen
            Form splashForm = new frmSplashScreen();
            splashForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ckbxCustomMessage_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxCustomMessage.Checked)
            {
                txtCustomMessage.ReadOnly = false;
                lblCustomMessage.Visible = true;

            }
            else
            {
                txtCustomMessage.ReadOnly = true;
                lblCustomMessage.Visible = false;
            }
        }
    }
}
