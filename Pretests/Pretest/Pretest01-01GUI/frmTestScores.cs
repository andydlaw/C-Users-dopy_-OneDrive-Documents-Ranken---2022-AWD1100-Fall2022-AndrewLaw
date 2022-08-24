using System;
using System.Windows.Forms;

/*
1-1a. Write C# GUI program Pretest01-01 that calculates the average grade for a student: 
Prompt the user for four test scores 
Displays each test score and the average of all test scores. 
Set the AcceptButton, CancelButton, StartPosition, and Tab Order accordingly. 
 */

namespace Pretest01_01GUI
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTestScore1.Text = "";
            txtTestScore2.Text = "";
            txtTestScore3.Text = "";
            txtTestScore4.Text = "";
            txtAvgScore.Text = "";

            txtTestScore1.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
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
        //this code will run when the calculate button is clicked
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declare each testScore variable as the
            //numerical value of what's in the associated textbox
            int testScore1 = Convert.ToInt32(txtTestScore1.Text);
            int testScore2 = Convert.ToInt32(txtTestScore2.Text);
            int testScore3 = Convert.ToInt32(txtTestScore3.Text);
            int testScore4 = Convert.ToInt32(txtTestScore4.Text);
            
            // totScore is the sum fo the four test scores
            int totScore = testScore1 + testScore2 + 
                testScore3 + testScore4;
            
            // avgScore is the totScore divided by 4 (# of test)
            decimal avgScore = totScore / 4.0m;
            txtAvgScore.Text = avgScore.ToString("n2");
        }
    }
}
