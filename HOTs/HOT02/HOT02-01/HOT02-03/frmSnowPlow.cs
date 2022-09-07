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
 * 
 * HOT02-03	[40 pts] Write a GUI-based program for a snow-plowing service.  Assume the following:
●	The snow plowing season lasts 15 weeks.
●	The fee for plowing a driveway that is 100 feet or more is $75 per plow.
●	The fee for plowing a driveway that is 60 square feet or more but under 100 feet is $50 per plow.
●	The fee for plowing a driveway that is under 60 feet is $25.
●	Assume here that each driveway will be plowed once per week during snow-plowing season.
●	Prompt the user for the length of their driveway in feet.
●	Display the total plowing fee for each plowing session.
●	Also display the total fee for the 15-week season.
●	Use constants wherever/whenever possible.
●	See below for a “practice program run”.

*/

namespace HOT02_03
{
    public partial class frmSnowPlow : Form
    {
        public frmSnowPlow()
        {
            InitializeComponent();
        }

        const decimal PLOWING_SEASON = 15;
        const decimal SMALLDRIVEWAYFEE = 25;
        const decimal MEDIUMDRIVEWAYFEE = 50;
        const decimal LARGEDRIVEWAYFEE = 75;

        private void button3_Click(object sender, EventArgs e)
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
            txtDrivewayLength.Text = "";
            lblResults.Text = "";
            //set curser to text box
            txtDrivewayLength.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal drivewaySize = Convert.ToDecimal(txtDrivewayLength.Text);
            decimal weeklyFee;
            decimal seasonFee;

            //If Else Statement
            if (drivewaySize >= 100)
            {
                weeklyFee = LARGEDRIVEWAYFEE;
                seasonFee = weeklyFee * PLOWING_SEASON;
                lblResults.Text = "Weekly Charge: " + LARGEDRIVEWAYFEE.ToString("c") + "\n\n Seasonal Charge: " + seasonFee.ToString("c");
            }
            else if (drivewaySize >= 60 && drivewaySize < 100)
            {
                weeklyFee = MEDIUMDRIVEWAYFEE;
                seasonFee = weeklyFee * PLOWING_SEASON;
                lblResults.Text = "Weekly Charge: " + MEDIUMDRIVEWAYFEE.ToString("c") + "\n\n Seasonal Charge: " + seasonFee.ToString("c");
            }
            else if (drivewaySize < 60)
            {
                weeklyFee = SMALLDRIVEWAYFEE;
                seasonFee = weeklyFee * PLOWING_SEASON;
                lblResults.Text = "Weekly Charge: " + SMALLDRIVEWAYFEE.ToString("c") + "\n\n Seasonal Charge: " + seasonFee.ToString("c");
            }
        }
    }
}
