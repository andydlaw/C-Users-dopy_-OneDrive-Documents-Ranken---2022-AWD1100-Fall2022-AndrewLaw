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
 * LB4. Write a GUI application that sorts all of the words in a phrase entered by the user.

Create a method named SortWords() that accepts a parameter array for the unsorted words and returns an array with the sorted words.

Program must pass all provided unit tests. You may want to look up the String.Split() method for this lab.
https://msdn.microsoft.com/en-us/library/b873y76a(v=vs.110).aspx

*/

namespace Chapt8_Lab04B
{
    public partial class frmSortedPhrase : Form
    {
        public frmSortedPhrase()
        {
            InitializeComponent();
        }

        private void sortTheWords()

        {
            string words = txtPhrase.Text;
            //parameter array that splits text with each space.
            string[] wordStr = words.Split(' ');
            
            string sortStr="";

            //sort the array ascending
            Array.Sort(wordStr);

            //Array.Reverse(wordStr);
            
            //filling output string with sorted words from array
            for (int i = 0; i < wordStr.Length; i++)
            {
                sortStr += wordStr[i] + " ";                
            }
            

            lblSortedPhrase.Text = sortStr;

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            sortTheWords();
        }
    }
}
