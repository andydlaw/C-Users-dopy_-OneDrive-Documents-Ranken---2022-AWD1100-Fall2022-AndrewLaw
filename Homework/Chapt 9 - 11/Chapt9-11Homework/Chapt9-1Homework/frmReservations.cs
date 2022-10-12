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
Extra 9-1 Calculate reservation totals
In this exercise, you’ll add code that calculates the number of nights, total price, and average price for a reservation based on the arrival and departure dates the user enters.
Open the project and implement the calculations
1. Open the Reservations project in the Extra Starts\Chapter 09 directory. Then, display the code for the form and notice that some of the methods are commented out so they don’t return errors.
2. Add code to get the arrival and departure dates the user enters when the user clicks the Calculate button. Then, calculate the number of days between those dates, calculate the total price based on a price per night of $120, calculate the average price per night, and display the results.
3. Test the application to be sure it works correctly. At this point, the average price will be the same as the nightly price.
Enhance the way the form works
4. Add an event handler for the Load event of the form. This event handler should get the current date and three days after the current date and assign these dates to the Arrival Date and Departure Date text boxes as default values. Be sure to format the dates as shown above.
5. Modify the code so Friday and Saturday nights are charged at $150 and other nights are charged at $120. One way to do this is to use a while loop that checks the day for each date of the reservation.
6. Test the application to be sure that the default dates are displayed correctly and that the totals are calculated correctly.
Add code to validate the dates
7. Uncomment the IsDateTime() method and then add code to check that the arrival and departure dates are valid dates.
8. Uncomment the IsWithinRange() method and then add code to check that the arrival and departure dates are within a range that includes the minimum and maximum dates that are passed to it.
17 Extra exercises for Murach’s C# (7th Edition)
9. Uncomment the IsValidData() method and then add code that uses the IsPresent(), IsDateTime(), and IsWithinRange() methods to validate the arrival and departure dates. These dates should be in a range from the current date to five years after the current date.
10. Add code that uses the IsValidData() method to validate the arrival and departure dates. In addition, add code to check that the departure date is after the arrival date.
11. Test the application to be sure the dates are validated properly. */

namespace Chapt9_1Homework
{
    public partial class frmReservations : Form
    {
        decimal pricePerNight = 120m;
        decimal premiumPricePerNight = 150m;
        decimal totalPrice;
        DateTime arrivalDate;
        DateTime departureDate;
        public frmReservations()
        {
            InitializeComponent();
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            IsValidData();

        }

        private void calulateFinals()
        {
            arrivalDate = Convert.ToDateTime(txtArriveDate.Text);
            departureDate = Convert.ToDateTime(txtDepartDate.Text);

            double result = (departureDate - arrivalDate).TotalDays;
            //decimal totalPrice = Convert.ToInt32(result) * pricePerNight;
            calculatePremium();
            decimal avgPricePerNight = totalPrice / Convert.ToInt32(result);
            txtNumOfNights.Text = result.ToString();
            txtTotalPrice.Text = totalPrice.ToString("c");
            txtAvgPrice.Text = avgPricePerNight.ToString("c");
            totalPrice = 0m;
        }

        private void IsValidData()
        {
            IsPresent();
          
            
        }
        private void IsPresent()
        {
            if (txtArriveDate.Text.Trim() == "")
            {
                MessageBox.Show("You must input a value in the from field", "NOTHING INPUTTED", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtArriveDate.Focus();
                return;
            }
            else if (txtDepartDate.Text.Trim() == "")
            {
                MessageBox.Show("You must input a value in the from field", "NOTHING INPUTTED", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtDepartDate.Focus();
                return;
            }
            else
            {
                IsDateTime();
            }
        }
        private void IsDateTime() 
        {
            
            bool result = DateTime.TryParse(txtArriveDate.Text, out arrivalDate);
            bool result2 = DateTime.TryParse(txtDepartDate.Text, out departureDate);
            if (!result)
            {
                MessageBox.Show("You must input a date in the from field", "NON-DATE INPUTTED", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtArriveDate.Focus();
                return;
            }
            else if (!result2)
            {
                MessageBox.Show("You must input a date in the from field", "NON-DATE INPUTTED", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtDepartDate.Focus();
                return;
            }
            else
            {
                IsWithinRange();
            }

        }
        private void IsWithinRange()
        {
            if (arrivalDate< DateTime.Today)
            {
                MessageBox.Show("Arrival date cannot be in the past", "OUT OF RANGE INPUTTED", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtArriveDate.Focus();
                return;
            }
            else if(departureDate > DateTime.Today.AddYears(5))
            {
                MessageBox.Show("Departure date cannot be more than 5 years from now", "OUT OF RANGE INPUTTED", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtDepartDate.Focus();
                return;
            }
            else if (departureDate < arrivalDate)
            {
                MessageBox.Show("Departure date cannot before arrival date", "OUT OF RANGE INPUTTED", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtDepartDate.Focus();
                return;
            }
            else
            {
                calulateFinals();
            }
        }



        private void calculatePremium()
        {
            DateTime pCheckArrivalDate = arrivalDate;
            DateTime pCheckDepatureDate = departureDate;
            do
            {
                if (pCheckArrivalDate.DayOfWeek == DayOfWeek.Friday || pCheckArrivalDate.DayOfWeek == DayOfWeek.Saturday)
                {
                    totalPrice = totalPrice + premiumPricePerNight;
                }
                else
                {
                    totalPrice = totalPrice + pricePerNight;
                }
                    pCheckArrivalDate = pCheckArrivalDate.AddDays(1);
            }
            while (pCheckArrivalDate<pCheckDepatureDate);
        }

        private void frmReservations_Load(object sender, EventArgs e)
        {
            DateTime currentArrival = DateTime.Today;
            DateTime currentDeparture = currentArrival.AddDays(3);
            txtArriveDate.Text = currentArrival.ToString("MM/dd/yyyy");
            txtDepartDate.Text = currentDeparture.ToString("MM/dd/yyyy");
        }
    }
}
