using System;
using System.Collections.Generic;
using System.Windows.Forms;

/*
 *Extra 8-2 Display a test scores list
In this exercise, you’ll modify the Score Calculator form so it saves the scores the user enters in a list and then lets the user display the sorted scores in a dialog box.
1. Open the ScoreCalculator project in the Extra Starts\Chapter 08\ScoreCalculatorList directory.
2. Replace the declaration for the array variable with a declaration for a List<int> object, and delete the class variable for the score count.
3. Modify the Click event handler for the Add button so it adds the score that’s entered by the user to the list. In addition, delete the statement that increments the score count variable you deleted.
4. Modify the Click event handler for the Clear button so it removes any scores that have been added to the list.
5. Modify the Click event handler for the Display Scores button so it sorts the scores in the list and then displays them in a dialog box.
6. Test the application to be sure it works correctly. In particular, see what happens if you enter more than 20 scores.*/
namespace Chapt8Homework
{
    public partial class frmScoreCalculator : Form
    {
        List<Int32> score = new List<Int32>(10);
        int totalScore;
        string scoreOutput = "";
        int scoreCount = 0;
        int avgScore;
        public frmScoreCalculator()
        {
            InitializeComponent();
        }

        private void frmScoreCalculator_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearAllFieldsSetFocus();
        }
        private void clearAllFieldsSetFocus()
        {
            //clear out all text boxes and set focus
            txtAvg.Text = "";
            txtScore.Text = "";
            txtScoreCount.Text = "";
            txtScoreTotal.Text = "";
            scoreCount = 0;
            //set curser to text box
            txtScore.Focus();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (scoreCount < 10)
            {
                score.Add (Convert.ToInt32(txtScore.Text));
                totalScore = totalScore + score[scoreCount];
                txtScoreTotal.Text = totalScore.ToString();
                avgScore = totalScore / (scoreCount + 1);
                txtAvg.Text = avgScore.ToString();
                scoreCount++;
                txtScoreCount.Text = scoreCount.ToString();
                scoreOutput = scoreOutput + Convert.ToString(score[scoreCount - 1]) + "\n";
            }
            if (scoreCount == 10)
            {
                MessageBox.Show(scoreOutput, "Sorted Scores", MessageBoxButtons.OK);
            }

        }



        private void btnDisplayScore_Click(object sender, EventArgs e)
        {

            MessageBox.Show(scoreOutput, "Sorted Scores", MessageBoxButtons.OK);
            txtScore.Focus();

        }
    }
}
