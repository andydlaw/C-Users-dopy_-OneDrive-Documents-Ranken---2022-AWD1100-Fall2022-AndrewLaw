using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

/*
 * Chapt 18 Homework Song Database Search
 */

namespace SongList
{
    public partial class frmSongList : Form
    {
        public frmSongList()
        {
            InitializeComponent();
        }

        const string NOTHINGINPUTTED = "No value inputted for search";
        const string NOTITLEFOUND = "No title matching search criteria";
        const string NOARTISTFOUND = "No artist matching search criteria";
        const string NOGENREFOUND = "No genre matching search criteria";

        static List<Song> songs = SongManager.LoadData();

        private void button3_Click(object sender, EventArgs e)
        {
            exitProgramOrNot();
        }
        private void exitProgramOrNot()
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

        private void frmSongList_Load(object sender, EventArgs e)
        {
            ddlLinqQueries.Items.Clear();
            ddlLinqQueries.Items.Add("Show Songs Ascending by Title");
            ddlLinqQueries.Items.Add("Show Songs Ascending by Artist");
            ddlLinqQueries.Items.Add("Show Songs Ascending by Genre");
            ddlLinqQueries.Items.Add("Search for Song(s) by Title");
            ddlLinqQueries.Items.Add("Search for Song(s) by Artist");
            ddlLinqQueries.Items.Add("Search for Song(s) by Genre");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "";
            lvwSongList.Items.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            decideWhichFunctionToCall();
        }
        private void decideWhichFunctionToCall()
        {
            int sel = ddlLinqQueries.SelectedIndex;

            switch (sel)
            {
                case -1:
                    showMsg("You must select and option!", "NO DROPDOWN LIST OPTION MADE");
                    ddlLinqQueries.Focus();
                    return;
                case 0:
                    showSongListByTitleAscending();
                    break;
                case 1:
                    showSongListByArtistAscending();
                    break;
                case 2:
                    showSongListByGenreAscending();
                    break;
                case 3:
                    showSongListByTitleSearch();
                    break;
                case 4:
                    showSongListByArtistSearch();
                    break;
                case 5:
                    showSongListByGenreSearch();
                    break;
                default:
                    showMsg("Invalid DDL Option!", "INVALID OPTION IN DROPDOWN LIST");
                    ddlLinqQueries.Focus();
                    break;


            }

        }
        private void showSongListByTitleAscending()
        {
            lvwSongList.Items.Clear();

            var titleAscending = from s in songs orderby s.SongTitle ascending select s;
            lblTitle.Text = "Song List Ascending Title Order";
            foreach (var s in titleAscending)
            {
                ListViewItem lvitem = new ListViewItem(s.SongTitle);
                lvitem.SubItems.Add(s.SongArtist);
                lvitem.SubItems.Add(s.SongGenre);
                lvwSongList.Items.Add(lvitem);
            }

        }
        private void showSongListByArtistAscending()
        {
            lvwSongList.Items.Clear();

            var artistAscending = from s in songs orderby s.SongArtist ascending select s;
            lblTitle.Text = "Song List Ascending Artist Order";
            foreach (var s in artistAscending)
            {
                ListViewItem lvitem = new ListViewItem(s.SongTitle);
                lvitem.SubItems.Add(s.SongArtist);
                lvitem.SubItems.Add(s.SongGenre);
                lvwSongList.Items.Add(lvitem);
            }
        }
        private void showSongListByGenreAscending()
        {
            lvwSongList.Items.Clear();

            var genreAscending = from s in songs orderby s.SongGenre ascending select s;
            lblTitle.Text = "Song List Ascending Genre Order";
            foreach (var s in genreAscending)
            {
                ListViewItem lvitem = new ListViewItem(s.SongTitle);
                lvitem.SubItems.Add(s.SongArtist);
                lvitem.SubItems.Add(s.SongGenre);
                lvwSongList.Items.Add(lvitem);
            }
        }
        private void showSongListByTitleSearch()
        {

            lvwSongList.Items.Clear();

            string title = Interaction.InputBox("Enter a song title to search for now (full or partial title)");
            if (title.Trim() == "")
            {
                lvwSongList.Items.Add(NOTHINGINPUTTED);
            }
            else
            {
                var songTitles = from s in songs orderby s.SongTitle ascending where s.SongTitle.ToUpper().Contains(title.ToUpper()) select s;

                if (!songTitles.Any())
                {
                    lblTitle.Text = "Song List Search Title: " + title;
                    lvwSongList.Items.Add(NOTITLEFOUND);
                    return;
                }
                else
                {
                    lblTitle.Text = "Song List Search Title: " + title;
                    foreach (var s in songTitles)
                    {
                        ListViewItem lvitem = new ListViewItem(s.SongTitle);
                        lvitem.SubItems.Add(s.SongArtist);
                        lvitem.SubItems.Add(s.SongGenre);
                        lvwSongList.Items.Add(lvitem);
                    }
                }
                
            }


        }
        private void showSongListByArtistSearch()
        {
            lvwSongList.Items.Clear();

            string artist = Interaction.InputBox("Enter a song artist to search for now (full or partial title)");
            if (artist.Trim() == "")
            {
                lvwSongList.Items.Add(NOTHINGINPUTTED);
            }
            else
            {
                var songArtist = from s in songs orderby s.SongArtist ascending where s.SongArtist.ToUpper().Contains(artist.ToUpper()) select s;
                if (!songArtist.Any())
                {
                    lblTitle.Text = "Song List Search Artist: " + artist;
                    lvwSongList.Items.Add(NOARTISTFOUND);
                    return;
                }
                else
                {
                    lblTitle.Text = "Song List Search Artist: " + artist;
                    foreach (var s in songArtist)
                    {
                        ListViewItem lvitem = new ListViewItem(s.SongTitle);
                        lvitem.SubItems.Add(s.SongArtist);
                        lvitem.SubItems.Add(s.SongGenre);
                        lvwSongList.Items.Add(lvitem);
                    }
                }
              
            }
        }
        private void showSongListByGenreSearch()
        {
            lvwSongList.Items.Clear();

            string genre = Interaction.InputBox("Enter a song genre to search for now (full or partial title)");
            if (genre.Trim() == "")
            {
                lvwSongList.Items.Add(NOTHINGINPUTTED);
            }
            else
            {
                var songGenre = from s in songs orderby s.SongGenre ascending where s.SongGenre.ToUpper().Contains(genre.ToUpper()) select s;
                if (!songGenre.Any())
                {
                    lblTitle.Text = "Song List Search Genre: " + genre;
                    lvwSongList.Items.Add(NOGENREFOUND);
                    return;
                }
                else
                {

                    lblTitle.Text = "Song List Search Genre: " + genre;
                    foreach (var s in songGenre)
                    {
                        ListViewItem lvitem = new ListViewItem(s.SongTitle);
                        lvitem.SubItems.Add(s.SongArtist);
                        lvitem.SubItems.Add(s.SongGenre);
                        lvwSongList.Items.Add(lvitem);
                    }
                }
                
                
            }

        }
        private void showMsg(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ddlLinqQueries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
