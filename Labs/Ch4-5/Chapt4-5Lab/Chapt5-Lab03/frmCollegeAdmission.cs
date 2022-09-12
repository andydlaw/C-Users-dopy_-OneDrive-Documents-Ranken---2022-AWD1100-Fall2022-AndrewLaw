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

namespace Chapt5_Lab03
{
    public partial class frmCollegeAdmission : Form
    {
        public frmCollegeAdmission()
        {
            InitializeComponent();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear out all text boxes and set focus
            txtGPA.Text = "";
            txtAdmissionScore.Text = "";
            lblAdmissionScore.Text = "";
            lblResults.Text = "";
            //set curser to text box
            txtGPA.Focus();

        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            decimal GPA = Convert.ToDecimal(txtGPA.Text);
            decimal admissionScore = Convert.ToDecimal(txtAdmissionScore.Text);
            if ((GPA >= 3.0m) && (admissionScore >= 60))
            {
                lblResults.Text = "Accept";
            }
            else if ((GPA < 3.0m) && (admissionScore >= 80))
            {
                lblResults.Text = "Accept";
            }
            else
            {
                lblResults.Text = "Reject";
            }
        }

        private void frmCollegeAdmission_Load(object sender, EventArgs e)
        {

        }
    }
}
