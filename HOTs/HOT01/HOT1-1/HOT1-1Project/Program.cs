using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * EX1 (25pts)

Write a C# program named HOT1-1 that asks your name and prints the following message:

Hello, yourName! (where yourName is your full name).
*/
namespace HOT1_1Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string yourName;

            Console.Write("Please Enter Your Full Name: ");
            yourName = Console.ReadLine();

            Console.WriteLine("\nHello, " + yourName + "!");
            Console.ReadLine();


        }
    }
}
