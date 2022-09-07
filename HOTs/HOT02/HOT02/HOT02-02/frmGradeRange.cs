using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

/*
 * 
 * HOT02-02	Shown below is the Ranken grading system:

A 	92.5-100%  	Excellent
B+ 	89.5-92.49%  	Very Good
B 	83.5-89.49% 	Good
C+ 	80.5-83.49%	Above Average
C 	74.5-80.49%	Average
D 	69.5-74.49% 	Does not satisfy course requirement
F 	0-69.49		Failing

●	Write a C# Program that “flips” this, i.e., as shown below, you enter a letter grade of “A”, “B+”, “B”, “C+”, “C”, “D”, or “F” and have the program print out the number grade range and message for the letter grade. 
●	Add each of the grade percentages and explanations into your program as string constants.
●	Do not allow for blank or invalid input (i.e., only the grades shown above are valid input).
●	If a letter grade is entered in lowercase, you convert it to UPPERCASE before testing it.
●	You must use a Switch statement to determine what should go into the bottom textbox.
●	See below for a “practice program run”.
*/

namespace HOT02_02
{
    public partial class frmGradeRange : Form
    {
        public frmGradeRange()
        {
            InitializeComponent();
        }

        //Declaring Constants
        const string A_GRADE = "92.5-100%   Excellent";
        const string B_PLUS_GRADE = "89.5 - 92.49%   Very Good";
        const string B_GRADE = "83.5-89.49%   Good";
        const string C_PLUS_GRADE = "80.5-83.49%   Above Average";
        const string C_GRADE = "74.5-80.49%   Average";
        const string D_GRADE = "69.5-74.49%   Does not satisfy course requirement";
        const string F_GRADE = "0-69.49   Failing";

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
            txtLetterGrade.Text = "";
            lblResults.Text = "";
            //set curser to text box
            txtLetterGrade.Focus();
        }



        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string letterGrade = txtLetterGrade.Text;

            letterGrade = letterGrade.ToUpper(); //Converting inputed text to upper case
            txtLetterGrade.Text = letterGrade;

            //Calling Empty Field Funtion
            validateVariableNotEmpty();

            //Letter Grade Switch
            switch (letterGrade)
            {
                case "A":
                    lblResults.Text = A_GRADE;
                    break;
                case "B+":
                    lblResults.Text = B_PLUS_GRADE;
                    break;
                case "B":
                    lblResults.Text = B_GRADE;
                    break;
                case "C+":
                    lblResults.Text = C_PLUS_GRADE;
                    break;
                case "C":
                    lblResults.Text = C_GRADE;
                    break;
                case "D":
                    lblResults.Text = D_GRADE;
                    break;
                case "F":
                    lblResults.Text = F_GRADE;
                    break;
                default:
                    lblResults.Text = "Unknown Grade";
                    break;
            }

        }

        //Empty field method
        private bool validateVariableNotEmpty()
        {
            bool retVal = true;

            if (txtLetterGrade.Text.Trim() == "")
            {
                DialogResult dialog = MessageBox.Show("Letter Grade Cannot Be Empty", "EMPTY LETTER GRADE");
                retVal = false;
                txtLetterGrade.Focus();
            }

            return retVal;
        }
    }
}
