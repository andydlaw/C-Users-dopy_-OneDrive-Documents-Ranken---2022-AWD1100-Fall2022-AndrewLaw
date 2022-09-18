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
 * LB4. Write a GUI program that determines eligibility for college applicants:

●	Prompt the user for the high-school GPA and admission test score.
●	Display “Accept” if the student’s GPA is 3.0 or higher and their admission test score is 60 or greater.
●	Display “Accept” if the student’s GPA is less than 3.0 and their admission test score is 80 or greater.
●	Otherwise display “Reject”

Create a method named IsStudentAccepted() that accepts a GPA and an admission test score, and returns a boolean indicating whether or not the student was accepted. This method should not have any side effects.
*/

namespace Chapt06_Lab04
{
    public partial class frm : Form
    {
        const decimal MINGPA = 3.0m;

        decimal gpa;
        decimal testScore;
        
        
       
        public frm()
        {
            InitializeComponent();
        }
        private bool IsStudentAccepted()
        {
            bool accepted = false;
            gpa = Convert.ToDecimal(txtGPA.Text);
            testScore = Convert.ToDecimal(txtAdmissionScore.Text);

            if ((gpa >= MINGPA) && (testScore >= 60))
            {
                accepted = true;
                
            }
            else if ((gpa < MINGPA) && (testScore >= 80))
            {
                accepted = true;
            }
            else
            {
                accepted = false;
            }
            return accepted;
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            bool accepted = IsStudentAccepted();
            
            if (accepted)
            {
                lblResults.Text = "Accepted";
            }
            else
            {
                lblResults.Text = "Rejected";
            }

        }
    }
}
