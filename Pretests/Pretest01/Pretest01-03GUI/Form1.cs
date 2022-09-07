using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 1.3b
 Write C# GUI program Pretest01-03 that lets a user enter a number grade and displays the associated 
 letter grade. Include constants MINGRADE (0) and MAXGRADE (100).  
 
 The associated letter grade code we used is shown below: 

90 - 100 = A
80 -89 =B
70 - 79 = C
60 - 69 = D
0 - 59 = F

Display the Number Grade and letter grade

Set Accept button, cancel button, start position, and tab order accordingly
 * 
 */

namespace Pretest01_03GUI
{
    public partial class frmGrades : Form
    {
        public frmGrades()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        const int MINGRADE = 0; //Lowest possible grade
        const int MAXGRADE = 100; // Highest possible grade
        private void button1_Click(object sender, EventArgs e)
        {
            int numberGrade = Convert.ToInt32(txtNumberGrade.Text);
            string letterGrade = "";

            if ((numberGrade > MAXGRADE) ||
                (numberGrade < MINGRADE))
            {
                letterGrade = "Invalid";
            }

            else if (numberGrade >= 90)
            {
                letterGrade = "A";
            }

            else if (numberGrade >= 80)
            {
                letterGrade = "B";
            }

            else if (numberGrade >= 70)
            {
                letterGrade = "C";
            }

            else if (numberGrade >= 60)
            {
                letterGrade = "D";
            }

            else if (numberGrade >= MINGRADE)
            {
                letterGrade = "F";
            }

            txtLetterGrade.Text = letterGrade;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtLetterGrade.Text = "";
            txtNumberGrade.Text = "";
            txtNumberGrade.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}

/*
 * Console.Write("Enter Grade (0-100): ");
            int numberGrade = Convert.ToInt32(Console.ReadLine());
            string letterGrade = "";

            if ((numberGrade > MAXGRADE) ||
                (numberGrade < MINGRADE))
            {
                letterGrade = "Invalid Number Grade";
            }

            else if (numberGrade >= 90)
            {
                letterGrade = "A";
            }

            else if (numberGrade >= 80)
            {
                letterGrade = "B";
            }

            else if (numberGrade >= 70)
            {
                letterGrade = "C";
            }

            else if (numberGrade >= 60)
            {
                letterGrade = "D";
            }

            else if (numberGrade >= MINGRADE)
            {
                letterGrade = "F";
            }

            Console.WriteLine("\nNumber Grade was : " + numberGrade.ToString() +
                 "\nLetter Grade was : " + letterGrade.ToString());

            Console.Read();

*/