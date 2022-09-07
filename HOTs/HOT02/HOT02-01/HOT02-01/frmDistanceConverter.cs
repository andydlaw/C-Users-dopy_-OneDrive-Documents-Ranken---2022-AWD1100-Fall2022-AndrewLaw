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
 * HOT02-01 [30 pts] Write a GUI-based program that converts distances between yards and meters.
●	The program must contain a constant named METERS_IN_A_YARD which holds the number of meters per yard (0.9144 meters per yard).
●	Prompt the user for a distance in yards.
●	Once the user presses the Calculate button, display the distance in both yards and meters as shown. Display the computed value for meters to 2 decimal places.
●	See below for a “practice program run”.
*/

namespace HOT02_01
{
    public partial class frmDistanceConverter : Form
    {
        public frmDistanceConverter()
        {
            InitializeComponent();
        }

        //Declaring Constant
        const decimal METERS_IN_A_YARD = 0.9144m;
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
            txtMeters.Text = "";
            txtYards.Text = "";
            //set curser to text box
            txtYards.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal yards = Convert.ToDecimal(txtYards.Text); //Declaring Yards Variable
            decimal meters = yards * METERS_IN_A_YARD; //Declaring Meters Variable and setting conversion formula
            txtMeters.Text = meters.ToString("n2"); //Outputting to textbox
        }
    }
}
