using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a console application that tracks the home sales of three salespeople (Danielle, Edward, Francis):
●	The program prompts the user for a salesperson initial (d, e, or f) and the sales amount,
then updates the total sales.
●	Any user can have multiple sales.
●	If the user enters "z" for the initial then the program should display the total sales
for each three salesperson, the grand total for all sales, and the name of the salesperson 
with the highest total.
●	If the user enters an initial other than "d", "e", "f" or "z" then the program should display 
an error and prompt the user for a new initial.
●	All initials should be treated in a case-insensitive manner.

Program must pass all provided unit tests. (To do so, you will need to follow the 
format to the right closely.)

*/

namespace Chapt05_Pt2Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string salesman = "";
           
            decimal sale;
            decimal danielleSales = 0m;
            decimal edwardSales = 0m;
            decimal francisSales = 0m;
            decimal mostSales = 0m;
            string highestSalesman = "";

            //Variable Input

            while (salesman != "z")
            {
                Console.Write("Who made the sale? (D, E, or F. Z for Grand Total.)");
                salesman = Console.ReadLine();
                

                switch (salesman)
                {
                    case "d":
                    case "D":
                        Console.Write("How much was the sale? ");
                        sale = Convert.ToDecimal(Console.ReadLine());
                        danielleSales += sale;
                        if (danielleSales >= mostSales)
                        {
                            mostSales=danielleSales;
                            highestSalesman = "Danielle";
                        }
                        Console.WriteLine("");
                        break;
                    case "e":
                    case "E":
                        Console.Write("How much was the sale? ");
                        sale = Convert.ToDecimal(Console.ReadLine());
                        edwardSales += sale;
                        if (edwardSales >= mostSales)
                        {
                            mostSales = edwardSales;
                            highestSalesman = "Edward";
                        }
                        Console.WriteLine("");
                        break;
                    case "f":
                    case "F":
                        Console.Write("How much was the sale? ");
                        sale = Convert.ToDecimal(Console.ReadLine());
                        francisSales += sale;
                        if (francisSales >= mostSales)
                        {
                            mostSales = francisSales;
                            highestSalesman = "Franics";
                           
                        }
                        Console.WriteLine("");
                        break;
                    case "z":
                    case "Z":
                        salesman = "z";
                        break;
                    default:
                        Console.WriteLine("Invalid Initial");
                        break;
                }
            }
            decimal grandTotal = francisSales + danielleSales + edwardSales;

            Console.WriteLine("\nDanielle Sales: "+ danielleSales.ToString("c"));
            Console.WriteLine("Edward Sales: " + edwardSales.ToString("c"));
            Console.WriteLine("Francis Sales: " + francisSales.ToString("c"));
            Console.WriteLine("\nGrand Total: " + grandTotal.ToString("c"));
            Console.WriteLine(highestSalesman + " has the most sales");






            Console.ReadLine();





        }
    }
}
