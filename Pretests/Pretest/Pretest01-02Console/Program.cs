using System;
using System.Runtime.CompilerServices;

namespace Pretest01_02Console
{
    internal class Program
    {
        const decimal KM_PER_MILE = 1.6m;

        static void Main(string[] args)
        { Console.Write("Enter Miles: ");
            decimal miles = Convert.ToDecimal(Console.ReadLine());
            decimal kilos = miles * KM_PER_MILE;

            Console.WriteLine(miles.ToString("n2") + " miles = " +
                kilos.ToString("n2") + " kilometers");

            Console.ReadLine();
        }
    }
}
