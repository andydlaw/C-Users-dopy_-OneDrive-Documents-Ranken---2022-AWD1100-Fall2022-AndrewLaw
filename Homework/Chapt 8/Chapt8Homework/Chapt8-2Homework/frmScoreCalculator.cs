using System;
using System.Windows.Forms;

/*
 * Extra 8-1 Display a test scores array
In this exercise, you’ll enhance the Score Calculator form so it saves the scores the user enters in an array and then lets the user display the sorted scores in a dialog box.
1. Open the ScoreCalculator project in the Extra Starts\Chapter 08\ScoreCalculatorArray directory.
2. Declare a class variable for an array that can hold up to 10 scores, and delete the class variable for the score total.
3. Modify the Click event handler for the Add button so it adds the score that’s entered by the user to the next element in the array. To do that, you can use the score count variable to refer to the element. Then, convert the code that refers to the deleted total class variable to a local variable. Finally, use a foreach loop to add each score in the array to this local total variable.
4. Move the Clear button as shown above. Then, modify the Click event handler for this button so it removes any scores that have been added to the array. The easiest way to do that is to create a new array and assign it to the array variable. Also, remove the reference to the deleted total class variable.
5. Add a Display Scores button that sorts the scores in the array, displays the scores in a dialog box, and moves the focus to the Score text box. Be sure that only the elements that contain scores are displayed.
6. Test the application to be sure it works correctly. In particular, see what happens if you enter more than 10 scores.
*/
namespace Chapt8Homework
{
    public partial class frmScoreCalculator : Form
    {
        int[] score = new int[10];
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
                score[scoreCount] = Convert.ToInt32(txtScore.Text);
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

        }
    }
}
