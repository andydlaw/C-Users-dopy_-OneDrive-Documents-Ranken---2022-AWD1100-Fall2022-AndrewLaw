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
 * 4. Write a GUI program that estimates the category of a hurricane based on the wind speed (based on the Saffir-Simpson Hurricane Scale):
●	Category 5 hurricanes have sustained winds of at least 157 miles per hour.
●	Category 4 hurricanes have sustained winds of at least 130 miles per hour.
●	Category 3 hurricanes have sustained winds of at least 111 miles per hour.
●	Category 2 hurricanes have sustained winds of at least 96 miles per hour.
●	Category 1 hurricanes have sustained winds of at least 74 miles per hour.
●	Any storm with winds of less than 74 miles per hour is not classified as a hurricane.
*/

namespace Chapt5Lab4
{
    public partial class frmHurricanScale : Form
    {
        public frmHurricanScale()
        {
            InitializeComponent();
        }


        //Declare and initialize program constants
        const int CATEGORY0 = 73;
        const int CATEGORY1 = 74;
        const int CATEGORY2 = 96;
        const int CATEGORY3 = 111;
        const int CATEGORY4 = 130;
        const int CATEGORY5 = 157;
        const string MSG = "Not Hurricane!";
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int windSpeed = Convert.ToInt32(txtWindSpeed.Text);
            string category;


            if (windSpeed > CATEGORY5)
            {
                category = "Category 5";
                txtCategory.Text = category.ToString();
            }
            else if (windSpeed >= CATEGORY4)
            {
                category = "Category 4";
                txtCategory.Text = category.ToString();
            }
            else if (windSpeed >= CATEGORY3)
            {
                category = "Category 3";
                txtCategory.Text = category.ToString();
            }
            else if (windSpeed >= CATEGORY2)
            {
                category = "Category 2";
                txtCategory.Text = category.ToString();
            }
            else if (windSpeed >= CATEGORY1)
            {
                category = "Category 1";
                txtCategory.Text = category.ToString();
            }
            else if (windSpeed <= CATEGORY0)
            {
                category = MSG;
                txtCategory.Text = category.ToString();
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
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
            txtWindSpeed.Text = "";
            txtCategory.Text = "";
            txtWindSpeed.Focus();
        }
    }
}
