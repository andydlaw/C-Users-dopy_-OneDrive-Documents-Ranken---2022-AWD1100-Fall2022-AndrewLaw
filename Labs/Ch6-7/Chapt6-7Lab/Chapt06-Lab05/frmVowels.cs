﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapt06_Lab05
{
    public partial class frmVowels : Form
    {
        public frmVowels()
        {
            InitializeComponent();
        }

        private decimal CountVowels()
        {
            string myStr = txtPhrase.Text;
            int i;
            int len;
            int vowel_count = 0;
                
                
                
            // find length
            len = myStr.Length;
            for (i = 0; i < len; i++)
            {
                if (myStr[i] == 'a' || myStr[i] == 'e' || myStr[i] == 'i' || myStr[i] == 'o' || myStr[i] == 'u' || myStr[i] == 'A' || myStr[i] == 'E' || myStr[i] == 'I' || myStr[i] == 'O' || myStr[i] == 'U')
                {
                    vowel_count++;
                }

            }
            return vowel_count;

            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            lblResult.Text ="There are " + Convert.ToString(CountVowels())+" vowels in your phrase.";
        }
    }
}
