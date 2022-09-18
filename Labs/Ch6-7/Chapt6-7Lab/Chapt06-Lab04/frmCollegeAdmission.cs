using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
