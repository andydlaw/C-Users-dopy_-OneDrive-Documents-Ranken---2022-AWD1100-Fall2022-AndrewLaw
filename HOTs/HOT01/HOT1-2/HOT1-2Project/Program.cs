using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * EX2 (25pts)

Write a C# program named HOT1-2 that asks for any three real numbers and prints the 
average value of those numbers. Credit for the correct result will not be given 
if the average isn’t correct for any 3 given numbers.

*/

namespace HOT1_2Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal numOne;
            decimal numTwo;
            decimal numThree;
            decimal total;
            decimal avgNumber;

            Console.Write("Enter Number 1 of 3 to average: ");
            numOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2 of 3 to average: ");
            numTwo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 3 of 3 to average: ");
            numThree = Convert.ToInt32(Console.ReadLine());

            total = numOne + numTwo + numThree;
            avgNumber = total/ 3.0m;

            Console.WriteLine("Average of the 3 numbers: " + avgNumber.ToString("n2"));
            Console.ReadLine();





        }
    }
}
