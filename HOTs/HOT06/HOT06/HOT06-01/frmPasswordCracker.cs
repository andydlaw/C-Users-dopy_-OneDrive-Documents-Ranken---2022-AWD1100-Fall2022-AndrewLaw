using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

/*
 * EX1 [50 pts]
A common way to crack MD5 hashed passwords is to use a rainbow table. Below is a short rainbow table for some common passwords. Use this table to build a basic password cracker.

You can quickly generate MD5 hashes yourself using this website:
http://www.miraclesalad.com/webtools/md5.php

Password	MD5 Hash
123456	e10adc3949ba59abbe56e057f20f883e
123456789	25f9e794323b453885f5181f1b624d0b
qwerty	d8578edf8458ce06fbc5bb76a58c5ca4
111111	96e79218965eb72c92a549dd5a330112
password	5f4dcc3b5aa765d61d8327deb882cf99
qwertyuiop	6eea9b7ef19179a06954edd0f6c05ceb
123321	c8837b23ff8aaa8a2dde915473ce0991
google	c822c1b63853ed273b89687ac505f9fa
P@ssw0rd	161ebd7d45089b3446ee4e0d86dbcf92
Tr0ub4dor&3	4ece57a61323b52ccffdbef021956754

Features
1.	The user can enter an MD5 hash.
2.	If the hash is in the table then display the raw password.
3.	If the hash is not in the table then display "* FAIL *"

Methods
CrackPassword() A method in the form that takes an MD5 hash and returns the raw password, if the hash is in the table. If the hash is not in the table then it should return null.

 */

namespace HOT05_01
{
    public partial class frmPasswordCracker : Form
    {
        public frmPasswordCracker()
        {
            InitializeComponent();
        }

        List<Password> passwords = new List<Password>()
        {
            new Password("123456","e10adc3949ba59abbe56e057f20f883e"),
            new Password("123456789","25f9e794323b453885f5181f1b624d0b"),
            new Password("qwerty","d8578edf8458ce06fbc5bb76a58c5ca4"),
            new Password("111111","96e79218965eb72c92a549dd5a330112"),
            new Password("password","5f4dcc3b5aa765d61d8327deb882cf99"),
            new Password("qwertyuiop","6eea9b7ef19179a06954edd0f6c05ceb"),
            new Password("123321","c8837b23ff8aaa8a2dde915473ce0991"),
            new Password("google","c822c1b63853ed273b89687ac505f9fa"),
            new Password("P@ssw0rd","161ebd7d45089b3446ee4e0d86dbcf92"),
            new Password("Tr0ub4dor&3","4ece57a61323b52ccffdbef021956754"),
        };

        private void CrackPassword()
        {
            for (int p = 0; p < passwords.Count; ++p)
            {
                //if true show definition
                if (passwords[p].GetHash().ToLower() == txtHash.Text.ToLower())
                {
                    lblRaw.ForeColor = Color.Black;
                    lblRaw.Text = passwords[p].GetRaw();
                    txtHash.Focus();
                    return;
                }
                else
                {
                    lblRaw.ForeColor = Color.Red; 
                    lblRaw.Text = "* FAIL *";
                }
            }
        }
        private bool validateHash()
        {
            bool retval = true;

            if (txtHash.Text.Trim() == "")
            {
                MessageBox.Show("Cannot have and empty hash", "EMPTY HASH", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtHash.Focus();
                retval = false;
                return retval;

            }
            retval = true;
            return retval;
        }

        private void btnCrack_Click(object sender, EventArgs e)
        {
            if (validateHash())
            {
                CrackPassword();
            }
        }
    }
}
