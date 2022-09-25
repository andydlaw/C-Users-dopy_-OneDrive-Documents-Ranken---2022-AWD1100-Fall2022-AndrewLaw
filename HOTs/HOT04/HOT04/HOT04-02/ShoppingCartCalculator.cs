using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/*
 * EX2 [40 pts] Write a console application that allows the user to enter the price of all the items in their shopping cart, and then computes the total cost of those items:

● Prompt the user for prices until they enter zero

● If the user enters a price that is greater than zero

o Accept the price

o Prompt the user for another item

● If they enter price that is less than zero

o Ignore the price

o Display an error message

o Prompt the user for another item

● If the user enters a price of zero

o Ignore the price

o Do not display an error message

o Display the number of items purchased, the average price per item, the subtotal, the total tax (8%), and the grand total

o Stop the program
*/

namespace HOT04_02
{
    internal class Program
    {

        static void Main(string[] args)
        {
            decimal[] price = new decimal[1000];


            //program variables
            int lcv = -1;
            int itemsPurchased = 0;
            decimal totalItemsPrice = 0m;
            decimal averageItemPrice = 0.0m;
            decimal tax = 0.08m;

            //do while loop
            do
            {
                lcv++;
                Write("0" + (lcv + 1).ToString() + ": ");
                price[lcv] = decimal.Parse(Console.ReadLine());
                if (price[lcv] < 0)
                {
                    Write("INVALID PRICE\n0" + (lcv + 1).ToString() + ": ");
                    price[lcv] = decimal.Parse(Console.ReadLine());
                }
                itemsPurchased++;
                totalItemsPrice += price[lcv];
                

            } while (price[lcv] != 0);

            //output
            averageItemPrice = totalItemsPrice / (itemsPurchased-1);
            Write("\n----------------------------");
            Write("\nItems Purchased: " + (itemsPurchased-1));
            Write("\nAverage Item Price: " + averageItemPrice.ToString("c"));
            Write("\nSubtotal: " + totalItemsPrice.ToString("c"));
            Write("\nTax: " + (tax*totalItemsPrice).ToString("c"));
            Write("\nTotal: " + ((tax * totalItemsPrice)+totalItemsPrice).ToString("c"));
            ReadLine();


        }
    }
}
