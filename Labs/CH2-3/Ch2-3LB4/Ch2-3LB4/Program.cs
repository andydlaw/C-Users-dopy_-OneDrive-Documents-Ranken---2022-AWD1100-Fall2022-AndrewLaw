using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a console program that converts distances from miles to kilometers:
●	Declares a named constant named KM_PER_MILE which holds the number of kilometers in a mile (1.6 km per mile).
●	Prompts the user for a distance in miles.
●	Displays the distance in both kilometers and miles. For example: “3.0 miles is 4.8 kilometers”

 * 
 * 
 * */

namespace Ch2_3LB4
{
    internal class Program
    {
        
        
            const decimal KM_PER_MILE = 1.6m;

            static void Main(string[] args)
            {
                Console.Write("Enter Miles: ");
                decimal miles = Convert.ToDecimal(Console.ReadLine());
                decimal kilos = miles * KM_PER_MILE;

                Console.WriteLine(miles.ToString("n2") + " miles is " +
                    kilos.ToString("n2") + " kilometers");

                Console.ReadLine();
            }
    }
}
