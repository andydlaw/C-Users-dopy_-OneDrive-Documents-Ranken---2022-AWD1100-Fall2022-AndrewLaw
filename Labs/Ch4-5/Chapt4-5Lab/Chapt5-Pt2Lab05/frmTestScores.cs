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
 * Write a GUI application that accepts an indefinite number of test scores for a student, and then computes some statistics about those scores:
●	Prompt the user for test scores until they enter 999
●	If the user enters a score inside the range of 0 through 100
○	Accept the score
○	Prompt the user for another score
●	If the user enters 999
○	Ignore the test score
○	Do not display an error message
○	display the number of scores, sum, average, min, and max
○	stop the program
●	If they enter a score outside the range of 0 through 100
○	Ignore the test score
○	Display an error message
○	Prompt the user for another score
*/


namespace Chapt5_Pt2Lab05
{
    public partial class frmTestScores : Form
    {

        const int MINSCORE = 0;
        const int MAXSCORE = 100;
        
        const String INV = "INVALID SCORE";

        int testScore = -1;
        int sumScore = 0;
        decimal avgScore = 00m;
        int numScore = 0;
        int highScore = -1;
        int lowScore = 999;
        string msg = "";
        public frmTestScores()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
             

            

            // Call routine to validate textbox not empty
            if (txtTestScore.Text.Trim() == "")
            {
                showMessage("Textbox Cannot Be Empty", "EMPTY TESTSCORE");

               
                txtTestScore.Text = "";
                txtTestScore.Focus();
                return;

            }
            else
            testScore = Convert.ToInt32(txtTestScore.Text);


            if ((testScore < MINSCORE || testScore > MAXSCORE))
            {
                showMessage("Textbox must be between 0 - 100", "OOR TEST SCORE");

                txtTestScore.Text = "";
                txtTestScore.Focus();
                return;
            }
            else if((testScore >= MINSCORE || testScore <= MAXSCORE))
            {
                ++numScore;
                sumScore += testScore;
                 avgScore = sumScore / numScore;

                if (testScore > highScore)
                {
                    highScore = testScore;
                }

                if (testScore < lowScore)
                {
                    lowScore = testScore;
                }


                lblAvg.Text = avgScore.ToString();
                lblHighest.Text = highScore.ToString();
                lblLowest.Text = lowScore.ToString();
                lblNumber.Text = numScore.ToString();
                lblSum.Text = sumScore.ToString();
            }









        }



       
        private void showMessage(String msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnExit_Click(object sender, EventArgs e)
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
    }
}
