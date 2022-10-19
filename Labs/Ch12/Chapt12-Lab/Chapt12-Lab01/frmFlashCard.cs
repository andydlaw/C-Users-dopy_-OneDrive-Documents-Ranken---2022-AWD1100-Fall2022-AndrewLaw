using System;
using System.Collections.Generic;
using System.Windows.Forms;

/*
 * LB1 FlashCards (Group)
Create a GUI application to help students remember important terms.
●	The program can store definitions for up 20 terms.
●	The program comes with 5 definitions included.
●	Users can enter a term to get a definition for that term. (case insensitive search)
●	If the user enters a term that it doesn't have a definition for, then it will display "I don't know that term yet. What does it mean?" and prompt to enter the definition.
 */

namespace Chapt12_Lab01
{
    public partial class frmFlashCard : Form
    {
        public frmFlashCard()
        {
            InitializeComponent();
        }

        //global Constant
        const int MAXLENGTH = 10;



        List<Flashcard> flashcards = new List<Flashcard>()
        {
            new Flashcard("input","data entered into a computer"),
            new Flashcard("processing","converting data into information"),
            new Flashcard("output","information generated from data"),
            new Flashcard("data","unprocessed information"),
            new Flashcard("information","processed data"),
        };

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchTerm.Text == "")
            {
                MessageBox.Show("No term entered into textbox", "TEXTBOX EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearchTerm.Focus();

                return;
            }
            searchForTerm();

        }
        private void searchForTerm()
        {
            //travers through list for match
            for (int p = 0; p < flashcards.Count; ++p)
            {
                //if true show definition
                if (txtSearchTerm.Text.ToLower() == flashcards[p].GetTerm().ToLower())
                {
                    txtAddTerm.Visible = false;
                    btnAdd.Visible = false;
                    lblDefineOutput.Text = flashcards[p].GetDefinition();
                    return;
                }
            }
            if (flashcards.Count < MAXLENGTH)
            {
                lblDefineOutput.Text = "I don't know that term yet. What does it mean?";
                btnAdd.Visible = true;
                txtAddTerm.Visible = true;
                txtAddTerm.Focus();
                return;

            }
            else
            {
                lblDefineOutput.Text = "I don't know that term yet.";
                btnAdd.Visible = false;
                txtAddTerm.Visible = false;
                txtSearchTerm.Focus();
                return;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            handleNewTerm();
        }
        private void handleNewTerm()
        {
            flashcards.Add(new Flashcard(txtSearchTerm.Text, txtAddTerm.Text));
            lblDefineOutput.Text = txtAddTerm.Text;
            MessageBox.Show("Term added to list", "SUCCESSFUL ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtAddTerm.Visible = false;
            btnAdd.Visible = false;
        }


    }
}
