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

namespace Chapt4_2Homework
{
    public partial class frmScoreCalculator : Form
    {
        decimal scoreTotal = 0;
        decimal scoreCount = 0;
        public frmScoreCalculator()
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
            txtScore.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";
            txtScoreTotal.Text = "";
            scoreCount = 0;
            scoreTotal = 0;

            //set curser to text box
            txtScore.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal score = Convert.ToDecimal(txtScore.Text);
            decimal average = 0m;
            scoreTotal += score;
            txtScoreTotal.Text = scoreTotal.ToString();
            scoreCount += 1;
            txtScoreCount.Text = scoreCount.ToString();
            average = scoreTotal / scoreCount;
            txtAverage.Text = average.ToString("n2");


        }
    }
}
