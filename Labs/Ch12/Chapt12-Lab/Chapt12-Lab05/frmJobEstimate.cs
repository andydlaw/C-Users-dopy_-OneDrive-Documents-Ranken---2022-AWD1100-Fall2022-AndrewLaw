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
 * LB5 JobEstimate
Create a GUI application for Harold's Home Services that estimates the cost of various jobs.

The base cost of a job is hours times the hourly rate. Also for each job there is an additional trip fee of $35.

Create a Job class according to the UML diagram below. 
1.	The constructor should calculate the total fee as above.
2.	The setter for HoursToComplete should calculate the total fee as above.
3.	The setter for HourlyFee should calculate the total fee as above.

Each time the user presses the update button:
1.	If a Job object has not been created then create one.
2.	If a Job object has been created then update it's properties.
3.	Displays the current values of the Job's properties below as shown

Program must pass all provided unit tests. 
Please remember to set the tab order.

 */

namespace Chapt12_Lab05
{
    public partial class frmJobEstimate : Form
    {
        public frmJobEstimate()
        {
            InitializeComponent();
        }
        const decimal TRIPFEE = 35.00m;

        List<Job> jobs = new List<Job>();
        decimal hoursToComplete;
        decimal hourlyRate;
        decimal totalFee;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            decimal result = 0.00m;
            bool keepGoing = validateDescription();
            if (keepGoing)
            {
                keepGoing = validateHoursToComplete();
            }
            else
            {
                return;
            }
            if (keepGoing)
            {
                keepGoing=validtateHourlyRate();
                
            }
            else
            {
                return;
            }

            //all textboxes have been validated
            //create new job object
            if (keepGoing)
            {
                Job job = new Job(txtDescription.Text, hoursToComplete, hourlyRate);
                result = job.HoursToComplete * job.HourlyFee + TRIPFEE;

                lblCurrentTotal.Text = result.ToString("c");
                jobs.Add(job);                
                lblCurrentHoursToComplete.Text = job.GetHoursToComplete().ToString("n2");
                lblCurrentHourlyRate .Text = job.GetHourlyFee().ToString("c");
                lblCurrentTotal.Text = job.TotalFee.ToString("c");
                lblCurrentValueDescr .Text = job.GetDescription();
            }
                
        }

        private bool validateDescription()
        {
            bool result = true;

            if (txtDescription.Text.Trim() =="")
            {
                MessageBox.Show("Cannot have and empty description", "EMPTY DESCRIPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtDescription.Focus();
                    result = false;
            }

            return result;
        }
        private bool validateHoursToComplete()
        {
            bool retval = true;
            bool result;

            if (txtHoursToComplete.Text.Trim() == "")
            {
                MessageBox.Show("Cannot have and empty hours to complete", "EMPTY HOURS TO COMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtHoursToComplete.Focus();
                retval = false;
            }
            else
            {
                result = decimal.TryParse(txtHoursToComplete.Text, out hoursToComplete);
                if (!result)
                {
                    MessageBox.Show("Cannot have and non-numeric hours to complete", "NON-NUMERIC HOURS TO COMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHoursToComplete.Text = "";
                    txtHoursToComplete.Focus();
                    retval = false;
                }
                else
                {
                    if( hoursToComplete <= 0)
                    {
                        MessageBox.Show("Cannot have and negative or zero hours to complete", "OUT-OF-RANGE HOURS TO COMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtHoursToComplete.Text = "";
                        txtHoursToComplete.Focus();
                        retval = false;
                    }
                }
            }

            return retval;
        }
        private bool validtateHourlyRate()
        {
            bool retval = true;
            bool result;

            if (txtHourlyRate.Text.Trim() == "")
            {
                MessageBox.Show("Cannot have and empty hourly rate", "EMPTY HOURLY RATE", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtHourlyRate.Focus();
                retval = false;
            }
            else
            {
                result = decimal.TryParse(txtHourlyRate.Text, out hourlyRate);
                if (!result)
                {
                    MessageBox.Show("Cannot have and non-numeric hourly rate", "NON-NUMERIC HOURLY RATE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHourlyRate.Text = "";
                    txtHourlyRate.Focus();
                    retval = false;
                }
                else
                {
                    if (hourlyRate <= 0)
                    {
                        MessageBox.Show("Cannot have and negative or zero hourly rate", "OUT-OF-RANGE HOURLY RATE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtHourlyRate.Text = "";
                        txtHourlyRate.Focus();
                        retval = false;
                    }
                }
            }

            return retval;
        }
    }
}
