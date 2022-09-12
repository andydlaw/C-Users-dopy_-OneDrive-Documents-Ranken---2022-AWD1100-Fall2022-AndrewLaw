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
 * . Write a GUI program that adds up the number of eggs produced by some chickens:
●	Prompts the user for a number of eggs laid by four chickens.
●	Sum the eggs laid and display the total in dozens and eggs.  For example, a total 
    of 127 eggs would be displayed as “10 dozen and 7 eggs”

*/

namespace Chapt4Lab04
{
    public partial class frmChickenFarmer : Form
    {
        public frmChickenFarmer()
        {
            InitializeComponent();
        }



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

        private void button2_Click(object sender, EventArgs e)
        {
            //clear out all text boxes and set focus
            txtChicken1.Text = "";
            txtChicken2.Text = "";
            txtChicken3.Text = "";
            txtChicken4.Text = "";
            //set curser to text box
            txtChicken1.Focus();
            lblOutput.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int chicken1 = Convert.ToInt32(txtChicken1.Text);
            int chicken2 = Convert.ToInt32(txtChicken2.Text);
            int chicken3 = Convert.ToInt32(txtChicken3.Text);
            int chicken4 = Convert.ToInt32(txtChicken4.Text);
            int totalEggs = (chicken1 + chicken2 + chicken3 + chicken4);
            int totalDozens = totalEggs / 12;
            int eggsLeft = totalEggs % 12;

            lblOutput.Text = totalEggs.ToString() + " Total, or " + totalDozens.ToString() + " Dozens and " +
                eggsLeft.ToString() + " eggs.";
        }

        private void frmChickenFarmer_Load(object sender, EventArgs e)
        {

        }
    }
}
