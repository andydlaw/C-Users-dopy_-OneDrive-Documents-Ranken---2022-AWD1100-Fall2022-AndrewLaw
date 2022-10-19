using System;
using System.Collections.Generic;
using System.Windows.Forms;

/*
 * LB4 GameBreak
Create a searchable database for a video game store.
●	The user can search by either the name of the game or the publisher.
●	If a game is found, then the program will display information about the game.
●	If a game is not found, then it will display an error message.

Name	Publisher	Price
Player Unknown's Battlegrounds (PUBG)	Bluehole	$35
League of Legends	Riot Games	$0
Call of Duty: Black Ops III	Activision	$60
Battlefield 4	Electronic Arts (EA)	$20
Super Mario Odyssey	Nintendo	$60

Screen Mockups
 
Methods
SearchForGame() searches for a game by name or publisher, returns the index of the game or -1 if not found.
ShowGameInfo() takes the index of a game. If the index is valid, displays the game's information. If the index is invalid, displays error messages.


 

 * */

namespace Chapt12_Lab04
{
    public partial class frmGameBreak : Form
    {
        public frmGameBreak()
        {
            InitializeComponent();
        }

        const int MAXLENGTH = 5;
        const string GNF = "Game Not Found";


        List<Game> games = new List<Game>()
        {
            new Game("Player Unknown's Battlegrounds (PUBG)",   "Bluehole", 35m),
            new Game("League of Legends","Riot Games",0m),
            new Game("Call of Duty: Black Ops III",    "Activision",    60m),
            new Game("Battlefield 4"  ,"Electronic Arts (EA)",  20m),
            new Game("Super Mario Odyssey",    "Nintendo",  60m),

        };

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int position = searchForGame();

            if (position == -1)
            {
                showGameNotFoundInfo();
            }
            else
            {
                showGameInfo(position);
            }
        }
        private void showGameInfo(int position)
        {
            lblNameOut.Text = games[position].GetName();
            lblPublisherOut.Text = games[position].GetPublisher();
            lblPriceOut.Text = games[position].GetPrice().ToString("c");
        }
        private void showGameNotFoundInfo()
        {
            lblNameOut.Text = GNF;
            lblPublisherOut.Text = GNF;
            lblPriceOut.Text = GNF;
        }

        //ShowGameInfo() takes the index of a game.If the index is valid,
        //displays the game's information.
        //If the index is invalid, displays error messages.
        private int searchForGame()
        {
            string searchTerm = txtSearchTerm.Text;
            //traverse to list looking for game or publisher match.
            for (int i = 0; i < games.Count; ++i)
            {
                if (games[i].GetName().ToLower().Contains(searchTerm.ToLower()) ||
                    games[i].GetPublisher().ToLower().Contains(searchTerm.ToLower()))
                {
                    return i;
                }
            }
            return -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearAndSetFocus();
        }

        private void clearAndSetFocus()
        {
            txtSearchTerm.Text = "";
            lblNameOut.Text = "";
            lblPriceOut.Text = "";
            lblPublisherOut.Text = "";
            txtSearchTerm.Focus();
        }
    }
}
