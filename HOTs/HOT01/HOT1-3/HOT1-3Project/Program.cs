using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * EX3 (50pts)

Write a C# program named HOT1-3 that prompts the user for a name, street address, city, state, zip code, and quantity of t-shirts ordered at $14.99 each. In an attractive format (similar to the one below), display all the input data as well as the following:

● Total Price: defined as number ordered times price each

● Sales tax: defined as 8% of the total price

● Amount due: defined as amount due before tax, plus tax
*/

namespace HOT1_3Project
{
    internal class Program
    {
        //Program Constants
        const decimal shirtPrice = 14.99m;
        const decimal taxRate = 0.08m;
        static void Main(string[] args)
        {
            string fullName;
            string address;
            string city;
            string zip;
            string state;
            int numTshirtBought;
            decimal subTotal;
            decimal taxTotal;
            decimal finalTotal;

            Console.Write("Enter your name: ");
            fullName = Console.ReadLine();
            Console.Write("Street address: ");
            address = Console.ReadLine();
            Console.Write("City: ");
            city = Console.ReadLine();
            Console.Write("State: ");
            state = Console.ReadLine();
            Console.Write("Zip: ");
            zip = Console.ReadLine();
            Console.Write("How many T-Shirts did you want to order: ");
            numTshirtBought = Convert.ToInt32(Console.ReadLine());


            //Calculate Subtotal
            subTotal = numTshirtBought * shirtPrice;
            taxTotal = subTotal * taxRate;
            finalTotal = subTotal + taxTotal;


            Console.WriteLine("\n\nReciept for:");
            Console.WriteLine(fullName);
            Console.WriteLine(address);
            Console.WriteLine(city + ", " + state + " " + zip);
            Console.WriteLine("\n" + numTshirtBought + " T-Shirts ordered @ $14.99 each");
            Console.WriteLine("\nTotal:       " + subTotal.ToString("c"));
            Console.WriteLine("Tax:          " + taxTotal.ToString("c"));
            Console.WriteLine("--------------------");
            Console.WriteLine("Due:         " + finalTotal.ToString("c"));
            






        }
    }
}