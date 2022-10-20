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
 * EX2 [50 pts]

A network scanner is a common tool for finding security gaps in a network. Create a prototype that accepts an IP address and displays information about the machine.

Computer Name IP Address Services

My-Desktop 127.0.0.1 20, 21, 23, 25, 53, 80, 123, 389, 443

google-public-dns-a 8.8.8.8 53

ranken.edu 47.44.246.80 25, 80, 443

Features

1. The user can enter an IP address.

2. If the IP address is in the table then display the available computer info.

3. If the IP address is not in the table then display the output as shown.

Methods

ScanIpAddress() takes an ip address and returns the computer with that ip address. Or null if no computer has that ip address.

ShowComputer() takes the results of the scan and displays the appropriate info.
 */

namespace HOT05_02
{
    public partial class frmNetworkScanner : Form
    {
        
        public frmNetworkScanner()
        {
            InitializeComponent();
        }
       


        List<Computer> computers = new List<Computer>()
        {
            new Computer("My-Desktop","127.0.0.1",1),
            new Computer("google-public-dns-a","8.8.8.8",2),
            new Computer("ranken.edu","47.44.246.80",3),

        };

        int computerPosition;
        string outputString;
        int serviceString;
        public void ShowComputer()
        {
            
            lblComputer.ForeColor = Color.Black;
            lblComputer.Text = computers[computerPosition].GetName();
            lblIPAddressOutput.Text = computers[computerPosition].GetIPAddress();
            txtIPAddress.Focus();
            
            lblServicesOutput.Text = outputString;

        }
        public void GetServicesOutput()
        {

            if (serviceString == 1)
            {
                outputString = "20: FTP_Data\r\n21: FTP_Control\r\n23: Telenet\r\n25: SMTP\r\n53: DNS\r\n80: HTTP\r\n123: NTP\r\n389: LDAP\r\n443: HTTPS";
            }
            else if (serviceString == 2)
            {
                outputString = "53: DNS";
            }
            else if (serviceString == 3)
            {
                outputString = "25: SMTP\r\n80: HTTP\r\n443: HTTPS";
            }
            
        }
        public void ScanIpAddress()
        {
            for (int p = 0; p < computers.Count; ++p)
            {
                //if true show definition
                if (computers[p].GetIPAddress() == txtIPAddress.Text)
                {
                    serviceString = computers[p].GetServices();
                    computerPosition = p;
                    GetServicesOutput();
                    ShowComputer();
                    return;
                }
                else
                {
                    lblComputer.ForeColor = Color.Red;
                    lblIPAddressOutput.Text = txtIPAddress.Text;
                    lblComputer.Text = "Request Timed Out";
                    lblServicesOutput.Text = "NONE";
                }
            }
        }
        private bool validateIP()
        {
            bool retval = true;

            if (txtIPAddress.Text.Trim() == "")
            {
                MessageBox.Show("Cannot have and empty IP Address", "EMPTY IP ADDRESS", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtIPAddress.Focus();
                retval = false;
                return retval;

            }
            retval = true;
            return retval;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if (validateIP())
            {
                ScanIpAddress();
            }
        }
    }
}
