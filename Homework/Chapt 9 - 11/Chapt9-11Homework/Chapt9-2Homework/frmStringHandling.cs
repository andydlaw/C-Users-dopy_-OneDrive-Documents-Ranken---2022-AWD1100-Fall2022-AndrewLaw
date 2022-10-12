using System;
using System.Windows.Forms;

/*
 * Extra 9-2 Work with strings
In this exercise, you’ll add code that parses an email address and formats the city, state, and zip code portion of an address.
Open the project and add code to parse an email address
1. Open the StringHandling project in the Extra Starts\Chapter 09 directory.
2. Add code to parse the email address into two parts when the user clicks the Parse button: the user name before the @ sign and the domain name after the @ sign. Be to check that the email contains an @ sign before you parse it, and display an error message if it doesn’t. Also, be sure to remove any leading or trailing spaces that the user enters. Display the results in a message box like the first one shown above.
3. Test the application with both valid and invalid email addresses to be sure it works correctly.
Add code to format an address
4. Add code to format the city, state, and zip code when the user clicks the Format button. To do that, create a string that contains the city, state, and zip code and then use the Insert() method to insert the appropriate characters. Be sure that the two-character state code is in uppercase. (You can assume that the user enters appropriate data in each text box.) Display the results in a message box like the second one shown above.
5. Test the application to be sure it formats the city, state, and zip code correctly.
 */

namespace Chapt9_2Homework
{
    public partial class frmStringHandling : Form
    {
        public frmStringHandling()
        {
            InitializeComponent();
        }
        private void stringParse()
        {
            string phrase = txtEmail.Text;
            phrase = phrase.Trim();
            if (string.IsNullOrEmpty(phrase))
            {
                MessageBox.Show("Email address requires input",
                    "EMAIL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
            else if (!phrase.Contains("@"))
            {
                MessageBox.Show("Email address requires @",
                    "EMAIL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String[] parts = phrase.Split(new[] { '@' });
                String username = parts[0];
                String domain = parts[1];
                MessageBox.Show("User name: " + username + "\nDomain name: " + domain,
                    "Parsed String", MessageBoxButtons.OK);
            }
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            stringParse();
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            formatAddress();
        }

        private void formatAddress()
        {
            string city = txtCity.Text;
            string state = txtState.Text.ToUpper();
            string zip = txtZipCode.Text;
            string output = city + ", " + state + " " + zip;


            MessageBox.Show("City, State, Zip: " .Insert(18,output),
                "Formatted String", MessageBoxButtons.OK);
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
