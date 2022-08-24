using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pretest01_02GUI
{
    public partial class frmMilesToKilometers : Form
    {
        public frmMilesToKilometers()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKilometers.Text = "";
            txtMiles.Text = "";
            

            txtMiles.Focus();
        }

        private void frmMilesToKilometers_Load(object sender, EventArgs e)
        {

        }

        const decimal KM_PER_MILE = 1.6m;

        //  This code runs when the Calculate button is clicked.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //  Declare variables
            decimal miles = Convert.ToDecimal(txtMiles.Text);
            decimal kilos = miles * KM_PER_MILE;

            txtKilometers.Text = kilos.ToString("n2");
        }
    }
}
