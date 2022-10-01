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
     * Lb6 GameDatabase
Create a searchable database for a video game store.  
	**Hint** 
Research: String.Contains() & String.ToLower()
●	The user can search by either the name of the game or the publisher.
●	The user should be able to perform partial keyword searches.  “Mario” should return “Super Mario Odyssey”
●	If a game is found, then the program will display information about the game.
●	The search should be case insensitive
●	If a game is not found, then it will display an error message.
'*/

namespace Chapt8_Lab06
{
    public partial class frmGameDatabase : Form
    {
        string[] gameName = { "Player Unknown's Battlegrounds (PUBG)", "League of Legends", "Call of Duty: Black Ops III", "Battlefield 4", "Super Mario Odyssey" };
        string[] publisher = { "Bluehole", "Riot Games", "Activision", "Electronic Arts (EA)", "Nintendo" };
        string[] price = { "$35.00", "$0.00", "$60.00", "$20.00", "$60.00" };
        string outputName;
        public frmGameDatabase()
        {
            InitializeComponent();
        }
        private void errorMessage()
        {

            lblName.Text = "Game Not Found";
            lblPrice.Text = "Game Not Found";
            lblPublisher.Text = "Game Not Found";
           
            txtGameSearch.Focus();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtGameSearch.Text == "")
            {
                errorMessage();
            }

            else
            {
                string searchValue = txtGameSearch.Text.ToLower();
                var result = char.ToUpper(searchValue[0]) + searchValue.Substring(1);


                //loop to find matching fields
                for (int i = 0; i < gameName.Length; ++i)
                {
                    if ((gameName[i].Contains(result)) || (publisher[i].Contains(result)))
                    {

                         outputName = (gameName[i]);
                        lblName.Text = gameName[i];
                        lblPublisher.Text = publisher[i];
                        lblPrice.Text = price[i];
                        break;

                    }
                    else if (outputName == "")
                    {
                        errorMessage();
                    }


                }
                outputName = "";


            }
        }
    }
}
