using System;
using System.Windows.Forms;

/*
 * EX1 [60 pts] Write a GUI application that looks up contact information by first or last name.

Program must store this table in three parallel arrays or lists and use an appropriate loop
*/

namespace HOT04_01
{
    public partial class frmAddressBook : Form
    {
        public frmAddressBook()
        {
            InitializeComponent();

        }
        //decaring global variables.
        string[] firstName = { "Markel", "Luiza", "Bryony", "Giraldo", "Lowri" };
        string[] lastName = { "Diggory", "Gunnar", "Hester", "Addy", "Hari" };
        string[] phoneNumber = { "555-8390", "555-4618", "555-4440", "555-1687", "555-7763" };
        string outputFName;
        string outputLName;
        string outputPNum;

        //error message
        private void errorMessage()
        {

            lblFName.Text = "error";
            lblLName.Text = "error";
            lblPNum.Text = "error";
            lblUserNotFound.Text = "User Not Found";
            txtSearchBox.Focus();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //null value capture
            if (txtSearchBox.Text == "")
            {
                errorMessage();
            }

            else
            {
                string searchValue = txtSearchBox.Text.ToLower();
                var result = char.ToUpper(searchValue[0]) + searchValue.Substring(1);


                //loop to find matching fields
                for (int i = 0; i < firstName.Length; ++i)
                {
                    if ((firstName[i].Contains(result)) || (lastName[i].Contains(result)))
                    {

                        outputFName = (firstName[i]);
                        outputLName = (lastName[i]);
                        outputPNum = (phoneNumber[i]);
                        lblFName.Text = outputFName;
                        lblLName.Text = outputLName;
                        lblPNum.Text = outputPNum;

                    }
                    else if (outputFName == "")
                    {
                        errorMessage();
                    }


                }
                outputFName = "";


            }


        }
    }
}
