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

namespace Chapt5_Lab5
{
    public partial class frmRockPaperScissors : Form
    {

        int PLAYERWINS = 0;
        int COMPUTERWINS = 0;
        public frmRockPaperScissors()
        {
            InitializeComponent();
        }







        private void btnRock_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int computerNum = rand.Next(1, 4);


            if (computerNum == 1)
            {
                lblComputerPick.Text = "Computer picked Rock";
                lblPlayerScore.Text = "Player score " + PLAYERWINS.ToString();
                lblComputerScore.Text = "Computer score " + COMPUTERWINS.ToString();
                if (PLAYERWINS == 2)
                {
                    lblWinner.Text = "Player Wins!!!";
                }
                else if (COMPUTERWINS == 2)
                {
                    lblWinner.Text = "Computer Wins!!!";
                }

            }
            else if (computerNum == 2)
            {
                lblComputerPick.Text = "Computer picked Paper";

                ++COMPUTERWINS;
                lblPlayerScore.Text = "Player score " + PLAYERWINS.ToString();
                lblComputerScore.Text = "Computer score " + COMPUTERWINS.ToString();
                if (PLAYERWINS == 2)
                {
                    lblWinner.Text = "Player Wins!!!";
                }
                else if (COMPUTERWINS == 2)
                {
                    lblWinner.Text = "Computer Wins!!!";
                }
            }
            else if (computerNum == 3)
            {
                lblComputerPick.Text = "Computer picked Scissors";
                ++PLAYERWINS;
                lblPlayerScore.Text = "Player score " + PLAYERWINS.ToString();
                lblComputerScore.Text = "Computer score " + COMPUTERWINS.ToString();
                if (PLAYERWINS == 2)
                {
                    lblWinner.Text = "Player Wins!!!";
                }
                else if (COMPUTERWINS == 2)
                {
                    lblWinner.Text = "Computer Wins!!!";
                }
            }





        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            {
                Random rand = new Random();
                int computerNum = rand.Next(1, 4);


                if (computerNum == 1)
                {
                    lblComputerPick.Text = "Computer picked Rock";
                    ++PLAYERWINS;
                    lblPlayerScore.Text = "Player score " + PLAYERWINS.ToString();
                    lblComputerScore.Text = "Computer score " + COMPUTERWINS.ToString();
                    
                    if (PLAYERWINS == 2)
                    {
                        lblWinner.Text = "Player Wins!!!";
                    }
                    else if (COMPUTERWINS == 2)
                    {
                        lblWinner.Text = "Computer Wins!!!";
                    }

                }
                else if (computerNum == 2)
                {
                    lblComputerPick.Text = "Computer picked Paper";

                    lblPlayerScore.Text = "Player score " + PLAYERWINS.ToString();
                    lblComputerScore.Text = "Computer score " + COMPUTERWINS.ToString();
                    if (PLAYERWINS == 2)
                    {
                        lblWinner.Text = "Player Wins!!!";
                    }
                    else if (COMPUTERWINS == 2)
                    {
                        lblWinner.Text = "Computer Wins!!!";
                    }
                }
                else if (computerNum == 3)
                {
                    lblComputerPick.Text = "Computer picked Scissors";
                    ++COMPUTERWINS;
                    lblPlayerScore.Text = "Player score " + PLAYERWINS.ToString();
                    lblComputerScore.Text = "Computer score " + COMPUTERWINS.ToString();
                    if (PLAYERWINS == 2)
                    {
                        lblWinner.Text = "Player Wins!!!";
                    }
                    else if (COMPUTERWINS == 2)
                    {
                        lblWinner.Text = "Computer Wins!!!";
                    }
                }
            }
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            {
                Random rand = new Random();
                int computerNum = rand.Next(1, 4);


                if (computerNum == 1)
                {
                    lblComputerPick.Text = "Computer picked Rock";
                    ++COMPUTERWINS;
                    lblPlayerScore.Text = "Player score " + PLAYERWINS.ToString();
                    lblComputerScore.Text = "Computer score " + COMPUTERWINS.ToString();
                    
                    if (PLAYERWINS == 2)
                    {
                        lblWinner.Text = "Player Wins!!!";
                    }
                    else if (COMPUTERWINS == 2)
                    {
                        lblWinner.Text = "Computer Wins!!!";
                    }

                }
                else if (computerNum == 2)
                {
                    lblComputerPick.Text = "Computer picked Paper";
                    ++PLAYERWINS;

                    lblPlayerScore.Text = "Player score " + PLAYERWINS.ToString();
                    lblComputerScore.Text = "Computer score " + COMPUTERWINS.ToString();
                    if (PLAYERWINS == 2)
                    {
                        lblWinner.Text = "Player Wins!!!";
                    }
                    else if (COMPUTERWINS == 2)
                    {
                        lblWinner.Text = "Computer Wins!!!";
                    }
                }
                else if (computerNum == 3)
                {
                    lblComputerPick.Text = "Computer picked Scissors";

                    lblPlayerScore.Text = "Player score " + PLAYERWINS.ToString();
                    lblComputerScore.Text = "Computer score " + COMPUTERWINS.ToString();
                    if (PLAYERWINS == 2)
                    {
                        lblWinner.Text = "Player Wins!!!";
                    }
                    else if (COMPUTERWINS == 2)
                    {
                        lblWinner.Text = "Computer Wins!!!";
                    }
                }
            }
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            //clear out all text boxes and set focus
            lblComputerScore.Text = "";
            lblPlayerScore.Text = "";
            PLAYERWINS = 0;
            COMPUTERWINS = 0;
            lblWinner.Text = "";
            
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
